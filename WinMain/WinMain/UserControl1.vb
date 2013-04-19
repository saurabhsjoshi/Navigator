Public Class UserControl1
    Public Event pic_clicked(ByVal prcnm As String, ByVal pid As Integer)
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        RaiseEvent pic_clicked(procName.Text, pid.Text)
    End Sub
End Class
