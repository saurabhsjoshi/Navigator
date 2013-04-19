<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
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
        Me.pid = New System.Windows.Forms.Label()
        Me.procName = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 41)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pid
        '
        Me.pid.AutoSize = True
        Me.pid.Location = New System.Drawing.Point(33, 0)
        Me.pid.Name = "pid"
        Me.pid.Size = New System.Drawing.Size(39, 13)
        Me.pid.TabIndex = 1
        Me.pid.Text = "Label1"
        Me.pid.Visible = False
        '
        'procName
        '
        Me.procName.AutoSize = True
        Me.procName.Location = New System.Drawing.Point(11, 14)
        Me.procName.Name = "procName"
        Me.procName.Size = New System.Drawing.Size(39, 13)
        Me.procName.TabIndex = 2
        Me.procName.Text = "Label1"
        Me.procName.Visible = False
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.procName)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(61, 41)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pid As System.Windows.Forms.Label
    Friend WithEvents procName As System.Windows.Forms.Label

End Class
