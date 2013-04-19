Public Class newico

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        File1.SupportMultiDottedExtensions = True
        File1.Multiselect = False
        File1.ShowDialog()
        TextBox2.Text = File1.FileName

    End Sub
End Class