Module Module1
    Public env As String = Application.StartupPath
    Public sys As String = env & "\sys"
    Public logpath As String = sys & "\basesys\log.txt"

    Public Sub logit(ByVal what As String)
        Dim prev As String = reader(logpath)
        prev = prev & vbNewLine & what
        writer(logpath, prev, False)
    End Sub
    Public Sub writer(ByVal PATH As String, ByVal TOWRITE As String, ByVal appendit As Boolean)
        On Error Resume Next
        Dim w As New System.IO.StreamWriter(PATH, appendit)
        w.Write(TOWRITE)
        w.Close()
    End Sub
    Public Function reader(ByVal PATH As String) As String
        Dim r As New System.IO.StreamReader(PATH)
        Dim ret As String = r.ReadToEnd
        r.Close()
        Return ret
    End Function
End Module
