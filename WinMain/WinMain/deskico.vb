Public Class deskico
    Private dragging As Boolean
    Private beginX, beginY As Integer
    Public Event deskico_clicked(ByVal path As String)

    Private Sub deskico_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        RaiseEvent deskico_clicked(lblpath.Text)
    End Sub

    Private Sub deskico_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        dragging = True
        beginX = e.X
        beginY = e.Y
    End Sub

    Private Sub deskico_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If dragging = True Then
            Me.Location = New Point(Me.Location.X + e.X -
            beginX, Me.Location.Y + e.Y - beginY)
            Me.Refresh()
        End If
    End Sub

    Private Sub deskico_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        dragging = False
    End Sub
    Private lol As Color

    Private Sub deskico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lol = Me.BackColor
    End Sub

    Private Sub deskico_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        Me.BackColor = Color.Aqua

    End Sub

    Private Sub deskico_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.BackColor = lol
    End Sub
End Class
