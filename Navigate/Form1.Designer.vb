<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Folders", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Files", System.Windows.Forms.HorizontalAlignment.Left)
        Me.imgsmall = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.treeFolders = New System.Windows.Forms.TreeView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lstDirectoryInfo = New System.Windows.Forms.ListView()
        Me.imglarge = New System.Windows.Forms.ImageList(Me.components)
        Me.loading = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picdel = New System.Windows.Forms.PictureBox()
        Me.piccpy = New System.Windows.Forms.PictureBox()
        Me.picback = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblfolder = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.loading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picdel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piccpy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgsmall
        '
        Me.imgsmall.ImageStream = CType(resources.GetObject("imgsmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgsmall.TransparentColor = System.Drawing.Color.Transparent
        Me.imgsmall.Images.SetKeyName(0, "folder.png")
        Me.imgsmall.Images.SetKeyName(1, "docsm.png")
        Me.imgsmall.Images.SetKeyName(2, "favorite.png")
        Me.imgsmall.Images.SetKeyName(3, "dek.png")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.treeFolders)
        Me.Panel1.Location = New System.Drawing.Point(0, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 466)
        Me.Panel1.TabIndex = 0
        '
        'treeFolders
        '
        Me.treeFolders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeFolders.ImageIndex = 0
        Me.treeFolders.ImageList = Me.imgsmall
        Me.treeFolders.Location = New System.Drawing.Point(0, 0)
        Me.treeFolders.Name = "treeFolders"
        Me.treeFolders.SelectedImageIndex = 0
        Me.treeFolders.Size = New System.Drawing.Size(287, 462)
        Me.treeFolders.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.AutoSize = True
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lstDirectoryInfo)
        Me.Panel2.Location = New System.Drawing.Point(297, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(414, 466)
        Me.Panel2.TabIndex = 1
        '
        'lstDirectoryInfo
        '
        Me.lstDirectoryInfo.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = "Folders"
        ListViewGroup1.Name = "grpFolders"
        ListViewGroup2.Header = "Files"
        ListViewGroup2.Name = "grpFiles"
        Me.lstDirectoryInfo.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.lstDirectoryInfo.LargeImageList = Me.imglarge
        Me.lstDirectoryInfo.Location = New System.Drawing.Point(0, 0)
        Me.lstDirectoryInfo.Name = "lstDirectoryInfo"
        Me.lstDirectoryInfo.Size = New System.Drawing.Size(410, 462)
        Me.lstDirectoryInfo.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstDirectoryInfo.TabIndex = 0
        Me.lstDirectoryInfo.UseCompatibleStateImageBehavior = False
        '
        'imglarge
        '
        Me.imglarge.ImageStream = CType(resources.GetObject("imglarge.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglarge.TransparentColor = System.Drawing.Color.Transparent
        Me.imglarge.Images.SetKeyName(0, "folderbig.png")
        Me.imglarge.Images.SetKeyName(1, "doc.png")
        Me.imglarge.Images.SetKeyName(2, "cmd.png")
        Me.imglarge.Images.SetKeyName(3, "note.png")
        Me.imglarge.Images.SetKeyName(4, "mus.png")
        Me.imglarge.Images.SetKeyName(5, "py.png")
        Me.imglarge.Images.SetKeyName(6, "vid.png")
        Me.imglarge.Images.SetKeyName(7, "ppt.png")
        Me.imglarge.Images.SetKeyName(8, "word.png")
        Me.imglarge.Images.SetKeyName(9, "cel.png")
        Me.imglarge.Images.SetKeyName(10, "7zip.png")
        Me.imglarge.Images.SetKeyName(11, "zip.png")
        Me.imglarge.Images.SetKeyName(12, "system.png")
        Me.imglarge.Images.SetKeyName(13, "dos.png")
        Me.imglarge.Images.SetKeyName(14, "pdf.png")
        Me.imglarge.Images.SetKeyName(15, "iso.png")
        Me.imglarge.Images.SetKeyName(16, "cpp.png")
        Me.imglarge.Images.SetKeyName(17, "html.png")
        '
        'loading
        '
        Me.loading.BackColor = System.Drawing.Color.White
        Me.loading.Dock = System.Windows.Forms.DockStyle.Right
        Me.loading.Image = CType(resources.GetObject("loading.Image"), System.Drawing.Image)
        Me.loading.Location = New System.Drawing.Point(703, 0)
        Me.loading.Name = "loading"
        Me.loading.Size = New System.Drawing.Size(20, 67)
        Me.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.loading.TabIndex = 1
        Me.loading.TabStop = False
        Me.loading.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.loading)
        Me.Panel3.Controls.Add(Me.picdel)
        Me.Panel3.Controls.Add(Me.piccpy)
        Me.Panel3.Controls.Add(Me.picback)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(723, 67)
        Me.Panel3.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(272, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 67)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(202, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 67)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'picdel
        '
        Me.picdel.Dock = System.Windows.Forms.DockStyle.Left
        Me.picdel.Image = CType(resources.GetObject("picdel.Image"), System.Drawing.Image)
        Me.picdel.Location = New System.Drawing.Point(138, 0)
        Me.picdel.Name = "picdel"
        Me.picdel.Size = New System.Drawing.Size(64, 67)
        Me.picdel.TabIndex = 3
        Me.picdel.TabStop = False
        '
        'piccpy
        '
        Me.piccpy.Dock = System.Windows.Forms.DockStyle.Left
        Me.piccpy.Image = CType(resources.GetObject("piccpy.Image"), System.Drawing.Image)
        Me.piccpy.Location = New System.Drawing.Point(69, 0)
        Me.piccpy.Name = "piccpy"
        Me.piccpy.Size = New System.Drawing.Size(69, 67)
        Me.piccpy.TabIndex = 2
        Me.piccpy.TabStop = False
        '
        'picback
        '
        Me.picback.Dock = System.Windows.Forms.DockStyle.Left
        Me.picback.Image = CType(resources.GetObject("picback.Image"), System.Drawing.Image)
        Me.picback.Location = New System.Drawing.Point(0, 0)
        Me.picback.Name = "picback"
        Me.picback.Size = New System.Drawing.Size(69, 67)
        Me.picback.TabIndex = 0
        Me.picback.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gray
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.lblfolder)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 543)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(723, 72)
        Me.Panel4.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(629, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Built By: BattleX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 5
        '
        'lblfolder
        '
        Me.lblfolder.AutoSize = True
        Me.lblfolder.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfolder.Location = New System.Drawing.Point(235, 12)
        Me.lblfolder.Name = "lblfolder"
        Me.lblfolder.Size = New System.Drawing.Size(0, 25)
        Me.lblfolder.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Current Folder:"
        '
        'PictureBox5
        '
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(97, 72)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(723, 615)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Navigate(Alpha 2.0)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.loading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picdel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piccpy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgsmall As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents treeFolders As System.Windows.Forms.TreeView
    Friend WithEvents imglarge As System.Windows.Forms.ImageList
    Friend WithEvents lstDirectoryInfo As System.Windows.Forms.ListView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents loading As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents picback As System.Windows.Forms.PictureBox
    Friend WithEvents piccpy As System.Windows.Forms.PictureBox
    Friend WithEvents picdel As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblfolder As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
