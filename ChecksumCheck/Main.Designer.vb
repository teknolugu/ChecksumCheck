<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.BtnHasil = New System.Windows.Forms.Button()
        Me.BtnCekFile = New System.Windows.Forms.Button()
        Me.BtnAbout = New System.Windows.Forms.Button()
        Me.BtnPengaturan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlSelector = New System.Windows.Forms.Panel()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSelectMode = New System.Windows.Forms.Button()
        Me.BtnBuang = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.PnlCheck = New System.Windows.Forms.Panel()
        Me.ListFiles = New System.Windows.Forms.ListBox()
        Me.PnlDrag = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckCRC32 = New System.Windows.Forms.CheckBox()
        Me.CheckSHA512 = New System.Windows.Forms.CheckBox()
        Me.CheckSHA256 = New System.Windows.Forms.CheckBox()
        Me.CheckSHA1 = New System.Windows.Forms.CheckBox()
        Me.CheckMD5 = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PnlHasil = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblTotalPage = New System.Windows.Forms.Label()
        Me.LblCurrentPage = New System.Windows.Forms.Label()
        Me.CmbFile = New System.Windows.Forms.ComboBox()
        Me.TreeFile = New System.Windows.Forms.TreeView()
        Me.LblFileName = New System.Windows.Forms.Label()
        Me.LblPath = New System.Windows.Forms.Label()
        Me.PnlCompare = New System.Windows.Forms.Panel()
        Me.TxtComparer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCompareFile = New System.Windows.Forms.Button()
        Me.LblCompareStatus = New System.Windows.Forms.Label()
        Me.PictCompareStatus = New System.Windows.Forms.PictureBox()
        Me.SingleFileChecker = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LblProgress = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MultipleFileChecker = New System.ComponentModel.BackgroundWorker()
        Me.ContextLstView = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CompareFileChecker = New System.ComponentModel.BackgroundWorker()
        Me.PnlHeader.SuspendLayout()
        Me.PnlCheck.SuspendLayout()
        Me.PnlDrag.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PnlHasil.SuspendLayout()
        Me.PnlCompare.SuspendLayout()
        CType(Me.PictCompareStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.PnlHeader.Controls.Add(Me.BtnHasil)
        Me.PnlHeader.Controls.Add(Me.BtnCekFile)
        Me.PnlHeader.Controls.Add(Me.BtnAbout)
        Me.PnlHeader.Controls.Add(Me.BtnPengaturan)
        Me.PnlHeader.Controls.Add(Me.Label1)
        Me.PnlHeader.Controls.Add(Me.PnlSelector)
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(840, 103)
        Me.PnlHeader.TabIndex = 0
        '
        'BtnHasil
        '
        Me.BtnHasil.BackColor = System.Drawing.Color.Transparent
        Me.BtnHasil.FlatAppearance.BorderSize = 0
        Me.BtnHasil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnHasil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnHasil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHasil.ForeColor = System.Drawing.Color.DarkGray
        Me.BtnHasil.Location = New System.Drawing.Point(118, 67)
        Me.BtnHasil.Name = "BtnHasil"
        Me.BtnHasil.Size = New System.Drawing.Size(57, 32)
        Me.BtnHasil.TabIndex = 27
        Me.BtnHasil.Text = "Hasil"
        Me.BtnHasil.UseVisualStyleBackColor = False
        '
        'BtnCekFile
        '
        Me.BtnCekFile.BackColor = System.Drawing.Color.Transparent
        Me.BtnCekFile.FlatAppearance.BorderSize = 0
        Me.BtnCekFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnCekFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnCekFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCekFile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCekFile.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCekFile.Location = New System.Drawing.Point(37, 67)
        Me.BtnCekFile.Name = "BtnCekFile"
        Me.BtnCekFile.Size = New System.Drawing.Size(56, 32)
        Me.BtnCekFile.TabIndex = 26
        Me.BtnCekFile.Text = "Cek File"
        Me.BtnCekFile.UseVisualStyleBackColor = False
        '
        'BtnAbout
        '
        Me.BtnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAbout.FlatAppearance.BorderSize = 0
        Me.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbout.Image = Global.ChecksumCheck.My.Resources.Resources.outline_help_outline_white_18dp
        Me.BtnAbout.Location = New System.Drawing.Point(799, 19)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Size = New System.Drawing.Size(27, 23)
        Me.BtnAbout.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.BtnAbout, "Tentang & Bantuan")
        Me.BtnAbout.UseVisualStyleBackColor = True
        '
        'BtnPengaturan
        '
        Me.BtnPengaturan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPengaturan.FlatAppearance.BorderSize = 0
        Me.BtnPengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPengaturan.Image = Global.ChecksumCheck.My.Resources.Resources.outline_settings_white_18dp
        Me.BtnPengaturan.Location = New System.Drawing.Point(765, 19)
        Me.BtnPengaturan.Name = "BtnPengaturan"
        Me.BtnPengaturan.Size = New System.Drawing.Size(27, 23)
        Me.BtnPengaturan.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.BtnPengaturan, "Pengaturan")
        Me.BtnPengaturan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(32, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Checksum Check"
        '
        'PnlSelector
        '
        Me.PnlSelector.BackColor = System.Drawing.SystemColors.Highlight
        Me.PnlSelector.Location = New System.Drawing.Point(37, 99)
        Me.PnlSelector.Name = "PnlSelector"
        Me.PnlSelector.Size = New System.Drawing.Size(56, 3)
        Me.PnlSelector.TabIndex = 1
        '
        'TxtPath
        '
        Me.TxtPath.AllowDrop = True
        Me.TxtPath.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TxtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPath.ForeColor = System.Drawing.Color.White
        Me.TxtPath.Location = New System.Drawing.Point(127, 102)
        Me.TxtPath.MaximumSize = New System.Drawing.Size(506, 20)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(506, 20)
        Me.TxtPath.TabIndex = 1
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblStatus.Location = New System.Drawing.Point(122, 71)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(76, 25)
        Me.LblStatus.TabIndex = 4
        Me.LblStatus.Text = "Pilih File"
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BtnBrowse.FlatAppearance.BorderSize = 0
        Me.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrowse.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBrowse.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBrowse.Location = New System.Drawing.Point(639, 102)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(75, 20)
        Me.BtnBrowse.TabIndex = 5
        Me.BtnBrowse.Text = "..."
        Me.ToolTip1.SetToolTip(Me.BtnBrowse, "Jelajahi file untuk memilih file")
        Me.BtnBrowse.UseVisualStyleBackColor = False
        '
        'btnCheck
        '
        Me.btnCheck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCheck.FlatAppearance.BorderSize = 0
        Me.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheck.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCheck.Location = New System.Drawing.Point(376, 467)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(97, 31)
        Me.btnCheck.TabIndex = 7
        Me.btnCheck.Text = "Check"
        Me.ToolTip1.SetToolTip(Me.btnCheck, "Mulai cek checksum file")
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(122, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Jenis"
        '
        'BtnSelectMode
        '
        Me.BtnSelectMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSelectMode.FlatAppearance.BorderSize = 0
        Me.BtnSelectMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelectMode.Image = Global.ChecksumCheck.My.Resources.Resources.baseline_folder_open_white_18dp
        Me.BtnSelectMode.Location = New System.Drawing.Point(543, 77)
        Me.BtnSelectMode.Name = "BtnSelectMode"
        Me.BtnSelectMode.Size = New System.Drawing.Size(27, 23)
        Me.BtnSelectMode.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.BtnSelectMode, "Tambah folder")
        Me.BtnSelectMode.UseVisualStyleBackColor = True
        Me.BtnSelectMode.Visible = False
        '
        'BtnBuang
        '
        Me.BtnBuang.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuang.FlatAppearance.BorderSize = 0
        Me.BtnBuang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuang.Image = Global.ChecksumCheck.My.Resources.Resources.outline_delete_white_18dp
        Me.BtnBuang.Location = New System.Drawing.Point(576, 77)
        Me.BtnBuang.Name = "BtnBuang"
        Me.BtnBuang.Size = New System.Drawing.Size(27, 23)
        Me.BtnBuang.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.BtnBuang, "Hapus yang dipilih")
        Me.BtnBuang.UseVisualStyleBackColor = True
        Me.BtnBuang.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Image = Global.ChecksumCheck.My.Resources.Resources.outline_close_white_18dp
        Me.BtnClose.Location = New System.Drawing.Point(606, 77)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(27, 23)
        Me.BtnClose.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.BtnClose, "Tutup")
        Me.BtnClose.UseVisualStyleBackColor = True
        Me.BtnClose.Visible = False
        '
        'BtnTambah
        '
        Me.BtnTambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTambah.FlatAppearance.BorderSize = 0
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.Image = Global.ChecksumCheck.My.Resources.Resources.outline_add_white_18dp
        Me.BtnTambah.Location = New System.Drawing.Point(606, 77)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(27, 23)
        Me.BtnTambah.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.BtnTambah, "Tambahkan banyak file sekaligus")
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClear.FlatAppearance.BorderSize = 0
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Image = Global.ChecksumCheck.My.Resources.Resources.outline_delete_white_18dp
        Me.BtnClear.Location = New System.Drawing.Point(786, 34)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(27, 23)
        Me.BtnClear.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.BtnClear, "Hapus Semua")
        Me.BtnClear.UseVisualStyleBackColor = True
        Me.BtnClear.Visible = False
        '
        'BtnBack
        '
        Me.BtnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Image = Global.ChecksumCheck.My.Resources.Resources.baseline_arrow_back_ios_white_18dp
        Me.BtnBack.Location = New System.Drawing.Point(740, 39)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(27, 23)
        Me.BtnBack.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.BtnBack, "Back")
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNext.FlatAppearance.BorderSize = 0
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNext.Image = Global.ChecksumCheck.My.Resources.Resources.baseline_arrow_forward_ios_white_18dp
        Me.BtnNext.Location = New System.Drawing.Point(782, 39)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(27, 23)
        Me.BtnNext.TabIndex = 39
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'PnlCheck
        '
        Me.PnlCheck.AllowDrop = True
        Me.PnlCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PnlCheck.Controls.Add(Me.ListFiles)
        Me.PnlCheck.Controls.Add(Me.PnlDrag)
        Me.PnlCheck.Controls.Add(Me.BtnSelectMode)
        Me.PnlCheck.Controls.Add(Me.CheckCRC32)
        Me.PnlCheck.Controls.Add(Me.CheckSHA512)
        Me.PnlCheck.Controls.Add(Me.CheckSHA256)
        Me.PnlCheck.Controls.Add(Me.CheckSHA1)
        Me.PnlCheck.Controls.Add(Me.CheckMD5)
        Me.PnlCheck.Controls.Add(Me.BtnBuang)
        Me.PnlCheck.Controls.Add(Me.TxtPath)
        Me.PnlCheck.Controls.Add(Me.LblStatus)
        Me.PnlCheck.Controls.Add(Me.Label4)
        Me.PnlCheck.Controls.Add(Me.BtnBrowse)
        Me.PnlCheck.Controls.Add(Me.btnCheck)
        Me.PnlCheck.Controls.Add(Me.BtnClose)
        Me.PnlCheck.Controls.Add(Me.BtnTambah)
        Me.PnlCheck.Location = New System.Drawing.Point(-13, 44)
        Me.PnlCheck.Name = "PnlCheck"
        Me.PnlCheck.Size = New System.Drawing.Size(849, 552)
        Me.PnlCheck.TabIndex = 19
        '
        'ListFiles
        '
        Me.ListFiles.AllowDrop = True
        Me.ListFiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListFiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ListFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListFiles.ForeColor = System.Drawing.Color.White
        Me.ListFiles.FormattingEnabled = True
        Me.ListFiles.Location = New System.Drawing.Point(127, 102)
        Me.ListFiles.Name = "ListFiles"
        Me.ListFiles.Size = New System.Drawing.Size(506, 80)
        Me.ListFiles.TabIndex = 20
        Me.ListFiles.Visible = False
        '
        'PnlDrag
        '
        Me.PnlDrag.AllowDrop = True
        Me.PnlDrag.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlDrag.BackColor = System.Drawing.Color.Transparent
        Me.PnlDrag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlDrag.Controls.Add(Me.Label3)
        Me.PnlDrag.Controls.Add(Me.PictureBox1)
        Me.PnlDrag.Location = New System.Drawing.Point(127, 212)
        Me.PnlDrag.Name = "PnlDrag"
        Me.PnlDrag.Size = New System.Drawing.Size(587, 111)
        Me.PnlDrag.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(217, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 25)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Drag drop file disini"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ChecksumCheck.My.Resources.Resources.baseline_insert_drive_file_white_24dp
        Me.PictureBox1.Location = New System.Drawing.Point(283, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'CheckCRC32
        '
        Me.CheckCRC32.AutoSize = True
        Me.CheckCRC32.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckCRC32.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckCRC32.Location = New System.Drawing.Point(309, 384)
        Me.CheckCRC32.Name = "CheckCRC32"
        Me.CheckCRC32.Size = New System.Drawing.Size(59, 19)
        Me.CheckCRC32.TabIndex = 30
        Me.CheckCRC32.Text = "CRC32"
        Me.CheckCRC32.UseVisualStyleBackColor = True
        '
        'CheckSHA512
        '
        Me.CheckSHA512.AutoSize = True
        Me.CheckSHA512.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckSHA512.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckSHA512.Location = New System.Drawing.Point(214, 407)
        Me.CheckSHA512.Name = "CheckSHA512"
        Me.CheckSHA512.Size = New System.Drawing.Size(65, 19)
        Me.CheckSHA512.TabIndex = 29
        Me.CheckSHA512.Text = "SHA512"
        Me.CheckSHA512.UseVisualStyleBackColor = True
        '
        'CheckSHA256
        '
        Me.CheckSHA256.AutoSize = True
        Me.CheckSHA256.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckSHA256.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckSHA256.Location = New System.Drawing.Point(214, 384)
        Me.CheckSHA256.Name = "CheckSHA256"
        Me.CheckSHA256.Size = New System.Drawing.Size(66, 19)
        Me.CheckSHA256.TabIndex = 28
        Me.CheckSHA256.Text = "SHA256"
        Me.CheckSHA256.UseVisualStyleBackColor = True
        '
        'CheckSHA1
        '
        Me.CheckSHA1.AutoSize = True
        Me.CheckSHA1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckSHA1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckSHA1.Location = New System.Drawing.Point(127, 407)
        Me.CheckSHA1.Name = "CheckSHA1"
        Me.CheckSHA1.Size = New System.Drawing.Size(53, 19)
        Me.CheckSHA1.TabIndex = 27
        Me.CheckSHA1.Text = "SHA1"
        Me.CheckSHA1.UseVisualStyleBackColor = True
        '
        'CheckMD5
        '
        Me.CheckMD5.AutoSize = True
        Me.CheckMD5.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckMD5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckMD5.Location = New System.Drawing.Point(127, 384)
        Me.CheckMD5.Name = "CheckMD5"
        Me.CheckMD5.Size = New System.Drawing.Size(50, 19)
        Me.CheckMD5.TabIndex = 26
        Me.CheckMD5.Text = "MD5"
        Me.CheckMD5.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(840, 605)
        Me.TabControl1.TabIndex = 20
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PnlCheck)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(832, 579)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PnlHasil)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(832, 579)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PnlHasil
        '
        Me.PnlHasil.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PnlHasil.Controls.Add(Me.Label6)
        Me.PnlHasil.Controls.Add(Me.Label5)
        Me.PnlHasil.Controls.Add(Me.LblTotalPage)
        Me.PnlHasil.Controls.Add(Me.LblCurrentPage)
        Me.PnlHasil.Controls.Add(Me.CmbFile)
        Me.PnlHasil.Controls.Add(Me.BtnBack)
        Me.PnlHasil.Controls.Add(Me.BtnNext)
        Me.PnlHasil.Controls.Add(Me.TreeFile)
        Me.PnlHasil.Controls.Add(Me.LblFileName)
        Me.PnlHasil.Controls.Add(Me.LblPath)
        Me.PnlHasil.Controls.Add(Me.PnlCompare)
        Me.PnlHasil.Controls.Add(Me.BtnClear)
        Me.PnlHasil.Location = New System.Drawing.Point(-2, 80)
        Me.PnlHasil.Name = "PnlHasil"
        Me.PnlHasil.Size = New System.Drawing.Size(835, 503)
        Me.PnlHasil.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(771, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 15)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Of"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(707, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Page :"
        '
        'LblTotalPage
        '
        Me.LblTotalPage.AutoSize = True
        Me.LblTotalPage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblTotalPage.Location = New System.Drawing.Point(797, 11)
        Me.LblTotalPage.Name = "LblTotalPage"
        Me.LblTotalPage.Size = New System.Drawing.Size(13, 15)
        Me.LblTotalPage.TabIndex = 45
        Me.LblTotalPage.Text = "0"
        '
        'LblCurrentPage
        '
        Me.LblCurrentPage.AutoSize = True
        Me.LblCurrentPage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrentPage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblCurrentPage.Location = New System.Drawing.Point(752, 11)
        Me.LblCurrentPage.Name = "LblCurrentPage"
        Me.LblCurrentPage.Size = New System.Drawing.Size(13, 15)
        Me.LblCurrentPage.TabIndex = 46
        Me.LblCurrentPage.Text = "0"
        '
        'CmbFile
        '
        Me.CmbFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.CmbFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbFile.ForeColor = System.Drawing.Color.White
        Me.CmbFile.FormattingEnabled = True
        Me.CmbFile.Location = New System.Drawing.Point(18, 41)
        Me.CmbFile.Name = "CmbFile"
        Me.CmbFile.Size = New System.Drawing.Size(379, 21)
        Me.CmbFile.TabIndex = 44
        '
        'TreeFile
        '
        Me.TreeFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TreeFile.ForeColor = System.Drawing.SystemColors.Window
        Me.TreeFile.Location = New System.Drawing.Point(18, 77)
        Me.TreeFile.Name = "TreeFile"
        Me.TreeFile.Size = New System.Drawing.Size(794, 269)
        Me.TreeFile.TabIndex = 43
        '
        'LblFileName
        '
        Me.LblFileName.AutoEllipsis = True
        Me.LblFileName.BackColor = System.Drawing.Color.Transparent
        Me.LblFileName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFileName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblFileName.Location = New System.Drawing.Point(14, 11)
        Me.LblFileName.Name = "LblFileName"
        Me.LblFileName.Size = New System.Drawing.Size(283, 25)
        Me.LblFileName.TabIndex = 20
        Me.LblFileName.Text = "-"
        Me.LblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPath
        '
        Me.LblPath.AutoEllipsis = True
        Me.LblPath.BackColor = System.Drawing.Color.Transparent
        Me.LblPath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPath.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblPath.Location = New System.Drawing.Point(15, 36)
        Me.LblPath.Name = "LblPath"
        Me.LblPath.Size = New System.Drawing.Size(549, 15)
        Me.LblPath.TabIndex = 36
        Me.LblPath.Text = "-"
        Me.LblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblPath.Visible = False
        '
        'PnlCompare
        '
        Me.PnlCompare.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.PnlCompare.Controls.Add(Me.TxtComparer)
        Me.PnlCompare.Controls.Add(Me.Label2)
        Me.PnlCompare.Controls.Add(Me.BtnCompareFile)
        Me.PnlCompare.Controls.Add(Me.LblCompareStatus)
        Me.PnlCompare.Controls.Add(Me.PictCompareStatus)
        Me.PnlCompare.Location = New System.Drawing.Point(18, 360)
        Me.PnlCompare.Name = "PnlCompare"
        Me.PnlCompare.Size = New System.Drawing.Size(509, 106)
        Me.PnlCompare.TabIndex = 38
        '
        'TxtComparer
        '
        Me.TxtComparer.AllowDrop = True
        Me.TxtComparer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtComparer.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TxtComparer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtComparer.ForeColor = System.Drawing.Color.White
        Me.TxtComparer.Location = New System.Drawing.Point(11, 39)
        Me.TxtComparer.Name = "TxtComparer"
        Me.TxtComparer.Size = New System.Drawing.Size(475, 20)
        Me.TxtComparer.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(7, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 21)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Bandingkan Checksum"
        '
        'BtnCompareFile
        '
        Me.BtnCompareFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCompareFile.BackColor = System.Drawing.Color.Transparent
        Me.BtnCompareFile.FlatAppearance.BorderSize = 0
        Me.BtnCompareFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnCompareFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnCompareFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompareFile.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompareFile.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCompareFile.Image = Global.ChecksumCheck.My.Resources.Resources.baseline_insert_drive_file_white_18dp
        Me.BtnCompareFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCompareFile.Location = New System.Drawing.Point(320, 9)
        Me.BtnCompareFile.Name = "BtnCompareFile"
        Me.BtnCompareFile.Size = New System.Drawing.Size(166, 23)
        Me.BtnCompareFile.TabIndex = 32
        Me.BtnCompareFile.Text = "        Bandingkan dengan file"
        Me.BtnCompareFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCompareFile.UseVisualStyleBackColor = False
        '
        'LblCompareStatus
        '
        Me.LblCompareStatus.AutoEllipsis = True
        Me.LblCompareStatus.AutoSize = True
        Me.LblCompareStatus.BackColor = System.Drawing.Color.Transparent
        Me.LblCompareStatus.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCompareStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblCompareStatus.Location = New System.Drawing.Point(42, 72)
        Me.LblCompareStatus.Name = "LblCompareStatus"
        Me.LblCompareStatus.Size = New System.Drawing.Size(70, 20)
        Me.LblCompareStatus.TabIndex = 27
        Me.LblCompareStatus.Text = "Unknown"
        '
        'PictCompareStatus
        '
        Me.PictCompareStatus.Image = Global.ChecksumCheck.My.Resources.Resources.ask_outlined_grey_128px
        Me.PictCompareStatus.Location = New System.Drawing.Point(12, 70)
        Me.PictCompareStatus.Name = "PictCompareStatus"
        Me.PictCompareStatus.Size = New System.Drawing.Size(24, 24)
        Me.PictCompareStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictCompareStatus.TabIndex = 24
        Me.PictCompareStatus.TabStop = False
        '
        'SingleFileChecker
        '
        Me.SingleFileChecker.WorkerReportsProgress = True
        Me.SingleFileChecker.WorkerSupportsCancellation = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Highlight
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblProgress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 583)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(840, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LblProgress
        '
        Me.LblProgress.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblProgress.Name = "LblProgress"
        Me.LblProgress.Size = New System.Drawing.Size(39, 17)
        Me.LblProgress.Text = "Ready"
        '
        'MultipleFileChecker
        '
        Me.MultipleFileChecker.WorkerReportsProgress = True
        Me.MultipleFileChecker.WorkerSupportsCancellation = True
        '
        'ContextLstView
        '
        Me.ContextLstView.Name = "ContextLstView"
        Me.ContextLstView.Size = New System.Drawing.Size(61, 4)
        '
        'CompareFileChecker
        '
        '
        'Main
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(840, 605)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PnlHeader)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(856, 644)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checksum Checker"
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlHeader.PerformLayout()
        Me.PnlCheck.ResumeLayout(False)
        Me.PnlCheck.PerformLayout()
        Me.PnlDrag.ResumeLayout(False)
        Me.PnlDrag.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.PnlHasil.ResumeLayout(False)
        Me.PnlHasil.PerformLayout()
        Me.PnlCompare.ResumeLayout(False)
        Me.PnlCompare.PerformLayout()
        CType(Me.PictCompareStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlHeader As Panel
    Friend WithEvents PnlSelector As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPath As TextBox
    Friend WithEvents LblStatus As Label
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PnlCheck As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnTambah As Button
    Friend WithEvents ListFiles As ListBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnBuang As Button
    Friend WithEvents CheckSHA1 As CheckBox
    Friend WithEvents CheckMD5 As CheckBox
    Friend WithEvents CheckCRC32 As CheckBox
    Friend WithEvents CheckSHA512 As CheckBox
    Friend WithEvents CheckSHA256 As CheckBox
    Friend WithEvents BtnSelectMode As Button
    Friend WithEvents SingleFileChecker As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LblProgress As ToolStripStatusLabel
    Friend WithEvents BtnPengaturan As Button
    Friend WithEvents MultipleFileChecker As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnAbout As Button
    Friend WithEvents BtnCekFile As Button
    Friend WithEvents BtnHasil As Button
    Friend WithEvents ContextLstView As ContextMenuStrip
    Friend WithEvents CompareFileChecker As System.ComponentModel.BackgroundWorker
    Friend WithEvents PnlDrag As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PnlHasil As Panel
    Friend WithEvents PnlCompare As Panel
    Friend WithEvents TxtComparer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCompareFile As Button
    Friend WithEvents LblCompareStatus As Label
    Friend WithEvents PictCompareStatus As PictureBox
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents TreeFile As TreeView
    Friend WithEvents CmbFile As ComboBox
    Friend WithEvents LblFileName As Label
    Friend WithEvents LblPath As Label
    Friend WithEvents LblTotalPage As Label
    Friend WithEvents LblCurrentPage As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
