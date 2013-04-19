Imports System
Imports System.IO
Public Class cpy
    Dim p() As String = Form1.cpysrc
    Dim desti As String = Form1.cpydest
    Private lol As String
    Private _totalFileSize As Long = 0
    Private _totalBytesCopied As Long = 0
    Private _copyProgressRoutine As CopyProgressRoutine
    Private ROOTFOLDER As String
    Private DESTFOLDER As String
    Private Delegate Function CopyProgressRoutine(ByVal totalFileSize As Int64, ByVal totalBytesTransferred As Int64, ByVal streamSize As Int64, ByVal streamBytesTransferred As Int64, ByVal dwStreamNumber As Int32, ByVal dwCallbackReason As Int32, ByVal hSourceFile As Int32, ByVal hDestinationFile As Int32, ByVal lpData As Int32) As Int32

    Private Declare Auto Function CopyFileEx Lib "kernel32.dll" (ByVal lpExistingFileName As String, ByVal lpNewFileName As String, ByVal lpProgressRoutine As CopyProgressRoutine, ByVal lpData As Int32, ByVal lpBool As Int32, ByVal dwCopyFlags As Int32) As Int32
    Private Function CopyProgress(ByVal totalFileSize As Int64, ByVal totalBytesTransferred As Int64, ByVal streamSize As Int64, ByVal streamBytesTransferred As Int64, ByVal dwStreamNumber As Int32, ByVal dwCallbackReason As Int32, ByVal hSourceFile As Int32, ByVal hDestinationFile As Int32, ByVal lpData As Int32) As Int32
        Label1.Text = "Now Copying:" & lol & " (" & Convert.ToInt32(totalBytesTransferred / 1024) & "KB of " & Convert.ToInt32(totalFileSize / 1024) & "KB)"
        ProgressBar1.Value = Convert.ToInt32(totalBytesTransferred / totalFileSize * 100)
    End Function
    Private Sub cpy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Timer1.Start()
        Dim l As New Threading.Thread(AddressOf cpys)
        l.Start()
    End Sub
    Private Sub cpys()
        Dim i As Integer
        For i = 0 To p.Length - 1
            If IO.File.Exists(p(i)) Then
                Dim fil As New FileInfo(p(i))
                lol = fil.Name
                Dim cpr As New CopyProgressRoutine(AddressOf CopyProgress)
                CopyFileEx(p(i), desti & "\" & lol, cpr, 0, 0, 0)
            ElseIf IO.Directory.Exists(p(i)) Then
                ROOTFOLDER = p(i)
                DESTFOLDER = desti
                Dim l As New DirectoryInfo(ROOTFOLDER)
                Directory.CreateDirectory(DESTFOLDER & "\" & l.Name)
                DESTFOLDER = DESTFOLDER & "\" & l.Name
                MsgBox(DESTFOLDER)

                GetTotalFileSize(New System.IO.DirectoryInfo(ROOTFOLDER))
                _copyProgressRoutine = New CopyProgressRoutine(AddressOf CopyDir)
                CopyFiles(New System.IO.DirectoryInfo(ROOTFOLDER), DESTFOLDER)
            End If
        Next
        Me.Close()
    End Sub
    Public abort As Boolean
    Function GetFolderSize(ByVal DirPath As String) As Long
        Try
            Dim size As Double = 0
            Dim di As New DirectoryInfo(DirPath)
            Dim files() As FileInfo
            files = di.GetFiles("*", SearchOption.AllDirectories)
            Dim ie As IEnumerator = files.GetEnumerator
            While ie.MoveNext And Not abort
                size += DirectCast(ie.Current, FileInfo).Length
            End While
            Return size
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return -1
        End Try
    End Function
    Private Function CopyDir(ByVal totalFileSize As Int64, ByVal totalBytesTransferred As Int64, ByVal streamSize As Int64, ByVal streamBytesTransferred As Int64, ByVal dwStreamNumber As Int32, ByVal dwCallbackReason As Int32, ByVal hSourceFile As Int32, ByVal hDestinationFile As Int32, ByVal lpData As Int32) As Int32
        ProgressBar1.Value = Convert.ToInt32((_totalBytesCopied + totalBytesTransferred) / _totalFileSize * 100)
        Label1.Text = "Now Copying: " & ROOTFOLDER & " (" & Convert.ToInt32(_totalBytesCopied + totalBytesTransferred) & " of " & Convert.ToInt32(_totalFileSize) & ")"
        Application.DoEvents()
    End Function

    Private Sub GetTotalFileSize(ByVal folder As System.IO.DirectoryInfo)
        For Each fi As System.IO.FileInfo In folder.GetFiles
            _totalFileSize += fi.Length
        Next
        For Each di As System.IO.DirectoryInfo In folder.GetDirectories
            GetTotalFileSize(di)
        Next
    End Sub
    Private Sub CopyFiles(ByVal folder As System.IO.DirectoryInfo, ByVal destinationFolder As String)
        If Not System.IO.Directory.Exists(destinationFolder) Then
            System.IO.Directory.CreateDirectory(destinationFolder)
        End If
        For Each fi As System.IO.FileInfo In folder.GetFiles
            CopyFileEx(fi.FullName, destinationFolder & "\" & fi.Name, _copyProgressRoutine, 0, 0, 0)
            _totalBytesCopied += fi.Length
        Next
        For Each di As System.IO.DirectoryInfo In folder.GetDirectories
            CopyFiles(di, di.FullName.Replace(ROOTFOLDER, DESTFOLDER))
        Next

    End Sub
End Class