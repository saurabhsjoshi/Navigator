<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desktop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desktop))
        Me.pnltask = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pndrive = New System.Windows.Forms.Panel()
        Me.pnapps = New System.Windows.Forms.Panel()
        Me.pnicon = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sockety = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chckup = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.TIMEupd = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.pnicon.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnltask
        '
        Me.pnltask.BackColor = System.Drawing.SystemColors.Control
        Me.pnltask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnltask.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnltask.Location = New System.Drawing.Point(0, 467)
        Me.pnltask.Name = "pnltask"
        Me.pnltask.Size = New System.Drawing.Size(631, 42)
        Me.pnltask.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pndrive)
        Me.Panel2.Controls.Add(Me.pnapps)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(431, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 467)
        Me.Panel2.TabIndex = 1
        '
        'pndrive
        '
        Me.pndrive.AutoScroll = True
        Me.pndrive.AutoSize = True
        Me.pndrive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pndrive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pndrive.Location = New System.Drawing.Point(0, 195)
        Me.pndrive.Name = "pndrive"
        Me.pndrive.Size = New System.Drawing.Size(200, 272)
        Me.pndrive.TabIndex = 0
        '
        'pnapps
        '
        Me.pnapps.AutoScroll = True
        Me.pnapps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnapps.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnapps.Location = New System.Drawing.Point(0, 0)
        Me.pnapps.Name = "pnapps"
        Me.pnapps.Size = New System.Drawing.Size(200, 195)
        Me.pnapps.TabIndex = 1
        '
        'pnicon
        '
        Me.pnicon.BackColor = System.Drawing.SystemColors.Control
        Me.pnicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnicon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnicon.Controls.Add(Me.Button1)
        Me.pnicon.Controls.Add(Me.MenuStrip1)
        Me.pnicon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnicon.Location = New System.Drawing.Point(0, 0)
        Me.pnicon.Name = "pnicon"
        Me.pnicon.Size = New System.Drawing.Size(431, 467)
        Me.pnicon.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(-90, 234)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(98, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "New Shortcut"
        Me.MenuStrip1.Visible = False
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.NewToolStripMenuItem.Text = "New shortcut"
        '
        'sockety
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'chckup
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblDay)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 37)
        Me.Panel1.TabIndex = 3
        '
        'lblDay
        '
        Me.lblDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(195, 4)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(70, 18)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "Thursday"
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(350, 7)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(73, 15)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "99/99/9999"
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(271, 7)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(73, 15)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "99/99/9999"
        '
        'TIMEupd
        '
        Me.TIMEupd.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 33)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(10, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox3.Location = New System.Drawing.Point(34, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 33)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 509)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnicon)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnltask)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Desktop"
        Me.Text = "Desktop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnicon.ResumeLayout(False)
        Me.pnicon.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnltask As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnapps As System.Windows.Forms.Panel
    Friend WithEvents pndrive As System.Windows.Forms.Panel
    Friend WithEvents pnicon As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents sockety As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chckup As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents TIMEupd As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
