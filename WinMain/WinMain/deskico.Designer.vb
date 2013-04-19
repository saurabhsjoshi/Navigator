<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deskico
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblpath = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 41)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(67, 14)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(27, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "new"
        '
        'lblpath
        '
        Me.lblpath.AutoSize = True
        Me.lblpath.Location = New System.Drawing.Point(170, 0)
        Me.lblpath.Name = "lblpath"
        Me.lblpath.Size = New System.Drawing.Size(28, 13)
        Me.lblpath.TabIndex = 2
        Me.lblpath.Text = "path"
        Me.lblpath.Visible = False
        '
        'deskico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblpath)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "deskico"
        Me.Size = New System.Drawing.Size(198, 41)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblpath As System.Windows.Forms.Label

End Class
