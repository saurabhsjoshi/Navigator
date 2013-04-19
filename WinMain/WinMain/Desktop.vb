Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Reflection
Imports Microsoft.Win32
Imports System
Imports System.Net.Sockets
Public Class Desktop
    Public needupdate As Boolean = False
    Dim curver As String = sys & "\updt\curver.txt"
    Dim cur() As String

#Region "WIN32 function calls etc."
    Private county As Integer = 0
    Private Structure POINTAPI
        Public x As Integer
        Public y As Integer
    End Structure

    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure
    Private Structure WINDOWPLACEMENT
        Public Length As Integer
        Public flags As Integer
        Public showCmd As Integer
        Public ptMinPosition As POINTAPI
        Public ptMaxPosition As POINTAPI
        Public rcNormalPosition As RECT
    End Structure
    Private Enum SHOW_WINDOW As Integer
        SW_HIDE = 0
        SW_SHOWNORMAL = 1
        SW_NORMAL = 1
        SW_SHOWMINIMIZE = 2
        SW_MAXIMIZE = 3
        SW_RESTORE = 9
        SW_SHOW = 5
        SW_SHOWNOACTIVATE = 4
        SW_SHOWDEFAULT = 10
    End Enum
    Private Declare Function ShowWindow Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal nCmdShow As SHOW_WINDOW) As Boolean
    Public Declare Auto Function ExtractIcon Lib "shell32" (ByVal hInstance As IntPtr, ByVal lpszExeFileName As String, ByVal nIconIndex As Integer) As IntPtr
    Private Declare Function GetWindowPlacement Lib "user32" (ByVal hwnd As Integer, ByRef lpwndpl As WINDOWPLACEMENT) As Integer
    <DllImport("USER32.DLL")> Private Shared Function GetShellWindow() As IntPtr
    End Function
    <DllImport("USER32.DLL")> _
    Private Shared Function GetWindowText(ByVal hWnd As IntPtr, ByVal lpString As StringBuilder, ByVal nMaxCount As Integer) As Integer
    End Function
    <DllImport("USER32.DLL")> Private Shared Function GetWindowTextLength(ByVal hWnd As IntPtr) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=True)> Private Shared Function GetWindowThreadProcessId(ByVal hWnd As IntPtr, <Out()> ByRef lpdwProcessId As UInt32) As UInt32
    End Function
    <DllImport("USER32.DLL")> Private Shared Function IsWindowVisible(ByVal hWnd As IntPtr) As Boolean
    End Function
    Private Delegate Function EnumWindowsProc(ByVal hWnd As IntPtr, ByVal lParam As Integer) As Boolean
    <DllImport("USER32.DLL")> Private Shared Function EnumWindows(ByVal enumFunc As EnumWindowsProc, ByVal lParam As Integer) As Boolean
    End Function
    Private hShellWindow As IntPtr = GetShellWindow()
    Private dictWindows As New Dictionary(Of IntPtr, String)
    Private currentProcessID As Integer
    Public Function GetOpenWindowsFromPID(ByVal processID As Integer) As IDictionary(Of IntPtr, String)
        dictWindows.Clear()
        currentProcessID = processID
        EnumWindows(AddressOf enumWindowsInternal, 0)
        Return dictWindows
    End Function
    Private Function enumWindowsInternal(ByVal hWnd As IntPtr, ByVal lParam As Integer) As Boolean
        If (hWnd <> hShellWindow) Then
            Dim windowPid As UInt32
            If Not IsWindowVisible(hWnd) Then
                Return True
            End If
            Dim length As Integer = GetWindowTextLength(hWnd)
            If (length = 0) Then
                Return True
            End If
            GetWindowThreadProcessId(hWnd, windowPid)
            If (windowPid <> currentProcessID) Then
                Return True
            End If
            Dim stringBuilder As New System.Text.StringBuilder(length)
            GetWindowText(hWnd, stringBuilder, (length + 1))
            dictWindows.Add(hWnd, stringBuilder.ToString)
        End If
        Return True
    End Function
#End Region
#Region "Taskbar"
    Private Sub makelist()
        On Error Resume Next
        'pnltask.Visible = False
        pnltask.Controls.Clear()
        For Each P As Process In Process.GetProcesses
            If P.ProcessName.ToLower <> "winmain" Then
                Dim windows As IDictionary(Of IntPtr, String) = GetOpenWindowsFromPID(P.Id)
                For Each kvp As KeyValuePair(Of IntPtr, String) In windows
                    If kvp.Value.ToLower = "start" = False Then
                        seticon(P.MainModule.FileName.ToString, P.ProcessName, P.Id)
                    End If
                Next

            End If
        Next
        pnltask.Visible = True
    End Sub
    Private Sub seticon(ByVal path As String, ByVal name As String, ByVal ids As Integer)
        Dim hInstance As IntPtr = Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0))
        Dim hIcon As IntPtr = ExtractIcon(hInstance, path, 0)
        If Not hIcon.Equals(IntPtr.Zero) Then
            Dim usr As New WinMain.UserControl1
            usr.PictureBox1.Image = Bitmap.FromHicon(hIcon)
            usr.Dock = DockStyle.Left
            usr.procName.Text = name
            usr.pid.Text = ids
            pnltask.Controls.Add(usr)
            AddHandler usr.pic_clicked, AddressOf minmax
        End If
    End Sub
    Private Sub minmax(ByVal proce As String, ByVal pi As Integer)
        Dim wp As WINDOWPLACEMENT
        wp.Length = Marshal.SizeOf(wp)
        For Each P As Process In Process.GetProcesses
            Dim windows As IDictionary(Of IntPtr, String) = GetOpenWindowsFromPID(P.Id)
            For Each kvp As KeyValuePair(Of IntPtr, String) In windows
                If kvp.Value.ToLower = "start" = False Then
                    If (GetWindowPlacement(P.MainWindowHandle, wp)) Then
                        If P.Id = pi Then
                            If wp.showCmd = SHOW_WINDOW.SW_SHOWMINIMIZE Then 'Or SHOW_WINDOW.SW_SHOWNORMAL Or SHOW_WINDOW.SW_NORMAL Then
                                ShowWindow(P.MainWindowHandle, SHOW_WINDOW.SW_MAXIMIZE)
                            ElseIf wp.showCmd = SHOW_WINDOW.SW_NORMAL Then
                                ShowWindow(P.MainWindowHandle, SHOW_WINDOW.SW_MAXIMIZE)
                            ElseIf wp.showCmd = SHOW_WINDOW.SW_SHOWNOACTIVATE Then
                                ShowWindow(P.MainWindowHandle, SHOW_WINDOW.SW_NORMAL)
                            ElseIf wp.showCmd = SHOW_WINDOW.SW_MAXIMIZE Then
                                ShowWindow(P.MainWindowHandle, SHOW_WINDOW.SW_SHOWNORMAL)
                            End If
                        End If
                    End If
                End If
            Next
        Next
    End Sub
#End Region
#Region "Communication with winmain!"
    Private Sub sockety_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles sockety.DoWork
        Dim serversocket As New TcpListener(8888)
        Dim clientsocket As TcpClient
        Dim counter As Integer
        serversocket.Start()
        counter = 0
        While (True)
            counter += 1
            clientsocket = serversocket.AcceptTcpClient()
            startClient(clientsocket, Convert.ToString(counter))
        End While
    End Sub
    Dim clientSocket As TcpClient
    Dim clNO As String
    Public Sub startClient(ByVal inClientSocket As TcpClient, ByVal clineNo As String)
        clientSocket = inClientSocket
        clNO = clineNo
        Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf dochat)
        ctThread.Start()
    End Sub
    Private Sub dochat()
        On Error Resume Next
        Dim requestCount As Integer
        Dim bytesFrom(10024) As Byte
        Dim dataFromClient As String
        Dim sendBytes As [Byte]()
        Dim rCount As String
        requestCount = 0
        While (True)

            requestCount = requestCount + 1
            Dim networkStream As NetworkStream = clientSocket.GetStream()
            networkStream.Read(bytesFrom, 0, CInt(clientSocket.ReceiveBufferSize))
            dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom)
            Dim res As String = "default"
            If dataFromClient.Contains("there") Then
                res = "YES"
            ElseIf dataFromClient.Contains("tempdir") Then
                res = sys & "\temp"
            Else
                res = "wrong value!"
            End If
            sendBytes = Encoding.ASCII.GetBytes(res)
            networkStream.Write(sendBytes, 0, sendBytes.Length)
            rCount = Convert.ToString(requestCount)
            networkStream.Flush()
            Exit While

        End While
        dochat()
    End Sub
#End Region
#Region "Process handling"
    Private Sub getprocs()
        Dim o As String = "l"
        For Each proc In Process.GetProcesses(My.Computer.Name)
            o = o & vbNewLine & proc.ProcessName
        Next
        writer(o, sys & "\updt\proc.txt", False)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        makelist()
    End Sub
#End Region
#Region "Updater"
    Private Sub chckup_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles chckup.DoWork
        On Error GoTo 1

        PictureBox2.Image = System.Drawing.Bitmap.FromFile(sys & "\pics\ld4.gif")



        System.IO.File.Delete(curver)


        My.Computer.Network.DownloadFile("http://www.fileden.com/files/2011/10/5/3204996/curver.txt", curver)



        cur = IO.File.ReadAllLines(curver)
        Dim ver() As String = IO.File.ReadAllLines(sys & "\basesys\settings.txt")



        If ver(1) < cur(1) Then
            PictureBox1.Image = PictureBox1.ErrorImage
            PictureBox2.Visible = False
            needupdate = True
        Else
            PictureBox2.Image = System.Drawing.Bitmap.FromFile(sys & "\pics\tick.png")
        End If

        Exit Sub
1:
        PictureBox2.Image = System.Drawing.Bitmap.FromFile(sys & "\pics\crs.png")

    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If needupdate = True Then
            Dim l As Integer = MsgBox("Start Update?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Update")
            If l = vbYes Then
                Dim sett(3) As String
                sett(0) = Application.StartupPath
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''I WAS HERE!!!!!!!!!!!!!!!!!!!''''''''''''''''''
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            End If
        End If
    End Sub
#End Region

    Private Sub loaddrives()
        For Each drive As IO.DriveInfo In IO.DriveInfo.GetDrives
            Dim itemText As String = drive.Name
            Dim Type As String
            Dim format As String
            Dim ltr As String = drive.Name
            If drive.IsReady AndAlso drive.VolumeLabel <> "" Then
                itemText = drive.VolumeLabel
                format = drive.DriveFormat
            Else
                Select Case drive.DriveType
                    Case IO.DriveType.Fixed : itemText = "Local Disk"
                    Case IO.DriveType.CDRom : itemText = "CD-ROM"
                    Case IO.DriveType.Network : itemText = "Network Drive"
                    Case IO.DriveType.Removable : itemText = "Removable Disk"
                    Case IO.DriveType.Unknown : itemText = "Unknown"
                End Select
            End If
            Select Case drive.DriveType
                Case IO.DriveType.Fixed : Type = "Local Disk"
                Case IO.DriveType.CDRom : Type = "CD-ROM"
                Case IO.DriveType.Network : Type = "Network Drive"
                Case IO.DriveType.Removable : Type = "Removable Disk"
                Case IO.DriveType.Unknown : Type = "Unknown"
            End Select
            Dim dr As New hdd
            dr.Dock = DockStyle.Top
            dr.Label1.Text = drive.Name
            Select Case Type
                Case "Local Disk"
                    dr.PictureBox1.Image = New System.Drawing.Bitmap(sys & "\pics\hdd.png")
                Case "CD-ROM"
                    dr.PictureBox1.Image = New System.Drawing.Bitmap(sys & "\pics\cd.png")
                Case "Removable Disk"
                    dr.PictureBox1.Image = New System.Drawing.Bitmap(sys & "\pics\usb.png")
                Case "Unknown"
                    dr.PictureBox1.Image = New System.Drawing.Bitmap(sys & "\pics\quest.png")
            End Select
            pndrive.Controls.Add(dr)
        Next
        Me.WindowState = FormWindowState.Maximized

    End Sub
    Private Sub startup()
        TIMEupd.Start()
        makelist()
        getprocs()
        chckup.RunWorkerAsync()
        loaddrives()
        Timer1.Start()
        sockety.RunWorkerAsync()
    End Sub
    Private Sub Desktop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Me.TopLevel = True
        logit("*****STARTED WINMAIN SUCCESSFULLY*****")
        startup()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As New ProcessStartInfo
        a.FileName = (sys & "\basesys\end.bat")
        a.WorkingDirectory = sys & "\basesys"
        a.CreateNoWindow = False
        Process.Start(a)
        Application.Exit()
    End Sub
    Private Sub pnicon_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnicon.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            MenuStrip1.Location = MousePosition
            MenuStrip1.Visible = True
        End If
    End Sub
    Private Sub MenuStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        If e.ClickedItem.Text = "New shortcut " Then

        End If
    End Sub


    Private Sub TIMEupd_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIMEupd.Tick
        lblTime.Text = TimeOfDay
        Dim d As Date = Today
        lblDate.Text = d
        lblDay.Text = d.DayOfWeek.ToString

    End Sub

   
End Class