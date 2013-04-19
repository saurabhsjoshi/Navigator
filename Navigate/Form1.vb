Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Reflection
Imports Microsoft.Win32

Public Class Form1
    Public omg As String
    Public engine As New Threading.Thread(AddressOf getalldirs)
    Public opc As Integer = 100
    Public Declare Auto Function ExtractIcon Lib "shell32" (ByVal hInstance As IntPtr, ByVal lpszExeFileName As String, ByVal nIconIndex As Integer) As IntPtr
    Private Function seticon2(ByVal path As String, ByVal name As String)
        Dim hInstance As IntPtr = Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0))
        Dim hIcon As IntPtr = ExtractIcon(hInstance, path, 0)
        'If Not hIcon.Equals(IntPtr.Zero) Then
        'usr.PictureBox1.Image = Bitmap.FromHicon(hIcon)
        'Else
        'End If
        Return "oh"
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        loaddrives()
        Dim o As New IO.StreamWriter(Application.StartupPath & "\explo.expo")
        o.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
        o.Close()

    End Sub
    Private Sub loaddrives()
        special()
        treeFolders.ImageIndex = 0
        On Error Resume Next
        Dim x As Integer = 2
        Dim y As Integer = My.Computer.FileSystem.Drives.Count
        For x = 0 To y - 1
            'If My.Computer.FileSystem.Drives(x).IsReady = True Then
            treeFolders.Nodes.Add(My.Computer.FileSystem.Drives(x).Name, My.Computer.FileSystem.Drives(x).Name)
            treeFolders.Nodes(My.Computer.FileSystem.Drives(x).Name).Tag = My.Computer.FileSystem.Drives(x).Name
            Dim z As New DirectoryInfo(My.Computer.FileSystem.Drives(x).Name)
            Dim dis() As DirectoryInfo = z.GetDirectories
            Dim l As DirectoryInfo
            For Each l In dis
                treeFolders.Nodes(x).Nodes.Add(l.Name, l.Name)
                treeFolders.Nodes(x).Nodes(l.Name).Tag = l.Name
            Next
            'End If
        Next
    End Sub
    Private Sub special()
        treeFolders.ImageIndex = 3
        treeFolders.Nodes.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Desktop")
        treeFolders.Nodes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)).Tag = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        treeFolders.Nodes(0).SelectedImageIndex = 3
    End Sub
    Private Sub treeFolders_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles treeFolders.BeforeExpand
        On Error Resume Next
        Dim MyTopDirectoryInfo As System.IO.DirectoryInfo
        'Clear the Sub Directories first
        e.Node.Nodes.Clear()
        'Now we loop through our directories as "TopDirectory" and Get it's Name and Full Path with
        'GetDirectoryInfo() and reading the "Tag" property
        For Each TopDirectory As String In My.Computer.FileSystem.GetDirectories(e.Node.Tag)
            MyTopDirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(TopDirectory)
            'adding the Node
            e.Node.Nodes.Add(TopDirectory, MyTopDirectoryInfo.Name)
            'setting its tag property to the full path
            e.Node.Nodes(TopDirectory).Tag = MyTopDirectoryInfo.FullName
            'repeat the process for the sub directories
            For Each SubDirectory As String In My.Computer.FileSystem.GetDirectories(e.Node.Nodes(TopDirectory).Tag)
                MyTopDirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(SubDirectory)
                'add the node
                e.Node.Nodes(TopDirectory).Nodes.Add(SubDirectory, MyTopDirectoryInfo.Name)
                'settting the Tag of the Sub Directory to the full path
                e.Node.Nodes(TopDirectory).Nodes(SubDirectory).Tag = MyTopDirectoryInfo.FullName
            Next
        Next
    End Sub
    Private Sub treeFolders_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles treeFolders.NodeMouseClick

        loading.Visible = True
        lstDirectoryInfo.Visible = False
        If e.Button = Windows.Forms.MouseButtons.Left Then
            noof = getnumber(e.Node.Tag)
            omg = e.Node.Tag
            If engine.IsAlive Then
                engine.Abort()
            End If
            engine = New Threading.Thread(AddressOf getalldirs)
            engine.Start()

            'Dim p As New Threading.Thread(AddressOf getalldirs)
            'p.Start()
        End If
    End Sub
    Private Sub slp()
        System.Threading.Thread.Sleep(10)
    End Sub
    Private Sub getalldirs()
        On Error Resume Next
        lstDirectoryInfo.Visible = False
        loading.Visible = True
        Label2.Visible = True
        Dim e As String = omg
        Dim MyTopDirectoryInfo As System.IO.DirectoryInfo
        Dim MyFileInfo As System.IO.FileInfo
        lblfolder.Text = omg
        'clear the ListView
        lstDirectoryInfo.Items.Clear()
        Dim lmk As Integer = 0
        'looping through all the sub directories in the selected Directory and adding them to 
        'the listveiw
        For Each TopDirectory As String In My.Computer.FileSystem.GetDirectories(e)
            Label2.Text = "Loading items " & lmk & " of " & noof
            lmk = lmk + 1
            MyTopDirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(TopDirectory)
            'set the "Key", "Text" and "ImageIndex" for the folder to be added
            'remember the "1" is the index in our imgSmall and imgLarge for "Folders"
            lstDirectoryInfo.Items.Add(MyTopDirectoryInfo.Name, MyTopDirectoryInfo.Name, 0)
            'set the item to the "Folders" group
            'remember the "0" is the index for the "Folders" Group
            lstDirectoryInfo.Items(MyTopDirectoryInfo.Name).Group = lstDirectoryInfo.Groups(0)
        Next
        'next we will add all the files, but first get the info for the Files in 
        'the current directory by reading the "Tag"
        For Each MyFile As String In My.Computer.FileSystem.GetFiles(e)
            Label2.Text = "Loading items " & lmk & " of " & noof
            lmk = lmk + 1
            MyFileInfo = My.Computer.FileSystem.GetFileInfo(MyFile)
            'We are not showing hidden files but you can modify this however needed
            If MyFileInfo.Attributes.ToString.Contains(IO.FileAttributes.Hidden.ToString) Then
                'hidden files
            Else
                Dim x As Integer = 1

                Dim hInstance As IntPtr = Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0))
                Dim hIcon As IntPtr = ExtractIcon(hInstance, MyFileInfo.FullName, 0)

                If Not hIcon.Equals(IntPtr.Zero) Then
                    x = imglarge.Images.Count
                    imglarge.Images.Add(Bitmap.FromHicon(hIcon))
                ElseIf MyFileInfo.Extension.ToLower = ".jpg" Then
                    x = imglarge.Images.Count
                    imglarge.Images.Add(Bitmap.FromFile(MyFileInfo.FullName))
                ElseIf MyFileInfo.Extension.ToLower = ".png" Then
                    x = imglarge.Images.Count
                    imglarge.Images.Add(Bitmap.FromFile(MyFileInfo.FullName))
                ElseIf MyFileInfo.Extension.ToLower = ".bmp" Then
                    x = imglarge.Images.Count
                    imglarge.Images.Add(Bitmap.FromFile(MyFileInfo.FullName))
                ElseIf MyFileInfo.Extension.ToLower = ".jpeg" Then
                    x = imglarge.Images.Count
                    imglarge.Images.Add(Bitmap.FromFile(MyFileInfo.FullName))
                Else
                    Dim gt() As String = File.ReadAllLines(Application.StartupPath & "\icns.expo")
                    Dim et As String = MyFileInfo.Extension.ToLower
                    Dim i As Integer = 0
                    For i = 0 To gt.Length - 1
                        If gt(i) = et Then
                            x = gt(i + 1)
                            Exit For
                        End If
                    Next

                End If

                'add the files to the listview and set the Image Index to "0" for Files
                lstDirectoryInfo.Items.Add(MyFile, MyFileInfo.Name, x)

                'our Image Index for our "Group", "Files" is 0
                lstDirectoryInfo.Items(MyFile).Group = lstDirectoryInfo.Groups(1)

            End If
            'MsgBox(MyFile & "-" & MyFileInfo.Attributes.ToString)
        Next
        noof = 0
        loading.Visible = False
        lstDirectoryInfo.Visible = True
        Label2.Visible = False
    End Sub


    Private Function getnumber(ByVal m As String)
        On Error Resume Next
        Dim ret As Integer = 0
        For Each a As String In Directory.GetFiles(m)
            ret = ret + 1
        Next
        For Each a In Directory.GetDirectories(m)
            ret = ret + 1
        Next
        Return ret
    End Function
    Private noof As Integer = 0
    Private Sub lstDirectoryInfo_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstDirectoryInfo.MouseDoubleClick
        lstDirectoryInfo.Visible = False
        Try
            For I = 0 To lstDirectoryInfo.SelectedItems.Count - 1
                noof = getnumber(omg & "\" & lstDirectoryInfo.SelectedItems(I).Text)
                Dim o As String = omg & "\" & lstDirectoryInfo.SelectedItems(I).Text
                If File.Exists(o) Then
                    System.Diagnostics.Process.Start(o)
                ElseIf Directory.Exists(o) Then
                    Dim hist() As String = System.IO.File.ReadAllLines(Application.StartupPath & "\explo.expo")
                    ReDim Preserve hist(hist.Length)
                    If hist.Length = 0 Then
                        hist(0) = omg
                    Else
                        current = hist.Count - 1
                        Dim county As Integer = hist.Count - 1
                        If (hist(county - 1)) <> omg Then
                            hist(county) = omg
                        End If
                    End If
                    IO.File.WriteAllLines(Application.StartupPath & "\explo.expo", hist)
                    omg = o
                    loading.Visible = True
                    If engine.IsAlive Then
                        engine.Abort()
                    End If
                    engine = New Threading.Thread(AddressOf getalldirs)
                    engine.Start()
                Else
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub treeFolders_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeFolders.AfterSelect
        On Error Resume Next
        lblfolder.Text = omg
    End Sub
    Private current As Integer = 0
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picback.Click

        On Error GoTo 1
        Dim u() As String = File.ReadAllLines(Application.StartupPath & "\explo.expo")
        omg = u(current)
        noof = getnumber(omg)
        current = current - 1
        If engine.IsAlive Then
            engine.Abort()
        End If
        engine = New Threading.Thread(AddressOf getalldirs)
        engine.Start()
        Exit Sub
1:
        Dim o As New IO.StreamWriter(Application.StartupPath & "\explo.expo")
        o.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
        o.Close()

    End Sub
#Region "Picture box Events"

    Private Sub picback_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picback.MouseEnter
        picback.BackColor = Color.Turquoise
    End Sub

    Private Sub picback_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picback.MouseLeave
        picback.BackColor = Color.White
    End Sub

    Private Sub piccpy_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles piccpy.MouseEnter
        piccpy.BackColor = Color.Yellow
    End Sub

    Private Sub piccpy_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles piccpy.MouseLeave
        piccpy.BackColor = Color.White
    End Sub
    Private Sub picdel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picdel.MouseEnter
        picdel.BackColor = Color.OrangeRed
    End Sub

    Private Sub picdel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picdel.MouseLeave
        picdel.BackColor = Color.White
    End Sub
#End Region
    Public cpysrc() As String
    Public cpydest As String
    Private Sub piccpy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piccpy.Click
        Try
            ReDim cpysrc(lstDirectoryInfo.SelectedItems.Count)
            For I = 0 To lstDirectoryInfo.SelectedItems.Count - 1
                Dim o As String = omg & "\" & lstDirectoryInfo.SelectedItems(I).Text
                cpysrc(I) = o
            Next
        Catch ex As Exception
            MsgBox("Error occured while reading selected files!", MsgBoxStyle.Information, "Error")

            Exit Sub
        End Try
        Dim k As New ProcessStartInfo
        k.FileName = Application.StartupPath & "\notify\notification.exe"
        k.WorkingDirectory = Application.StartupPath & "\notify"
        k.Arguments = "Files ready for copy"
        Process.Start(k)
        PictureBox1.Enabled = True

    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        cpydest = omg
        Dim p As New cpy
        p.Show()


    End Sub

    Private Sub picdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picdel.Click
        Dim p As New Threading.Thread(AddressOf del)
        p.Start()
    End Sub
    Private Sub del()
        Dim re As Integer
        re = MsgBox("Are you sure you want to delete these file and/or folders?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Delete")
        If re = DialogResult.Yes Then
            For I = 0 To lstDirectoryInfo.SelectedItems.Count - 1
                Dim o As String = omg & "\" & lstDirectoryInfo.SelectedItems(I).Text
                If File.Exists(o) Then
                    File.Delete(o)
                ElseIf Directory.Exists(o) Then
                    Directory.Delete(o, True)
                End If

            Next
        End If
        If engine.IsAlive Then
            engine.Abort()
        End If
        omg = lblfolder.Text
        engine = New Threading.Thread(AddressOf getalldirs)
        engine.Start()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
       
        If engine.IsAlive Then
            engine.Abort()
        End If
        omg = lblfolder.Text
        noof = getnumber(omg)

        engine = New Threading.Thread(AddressOf getalldirs)
        engine.Start()
    End Sub
End Class
