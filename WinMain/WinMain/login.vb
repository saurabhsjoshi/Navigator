Public Class login

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As New ProcessStartInfo
        a.FileName = (sys & "\basesys\strt.bat")
        a.WorkingDirectory = sys & "\basesys"
        a.CreateNoWindow = False
        Process.Start(a).WaitForExit()
        Desktop.Show()
        Me.Close()

    End Sub
End Class