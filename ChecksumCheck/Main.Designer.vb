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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LblProgress = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ContextLstView = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SingleFileChecker = New System.ComponentModel.BackgroundWorker()
        Me.MultipleFileChecker = New System.ComponentModel.BackgroundWorker()
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
        resources.ApplyResources(Me.PnlHeader, "PnlHeader")
        Me.PnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.PnlHeader.Controls.Add(Me.BtnHasil)
        Me.PnlHeader.Controls.Add(Me.BtnCekFile)
        Me.PnlHeader.Controls.Add(Me.BtnAbout)
        Me.PnlHeader.Controls.Add(Me.BtnPengaturan)
        Me.PnlHeader.Controls.Add(Me.Label1)
        Me.PnlHeader.Controls.Add(Me.PnlSelector)
        Me.PnlHeader.Name = "PnlHeader"
        Me.ToolTip1.SetToolTip(Me.PnlHeader, resources.GetString("PnlHeader.ToolTip"))
        '
        'BtnHasil
        '
        resources.ApplyResources(Me.BtnHasil, "BtnHasil")
        Me.BtnHasil.BackColor = System.Drawing.Color.Transparent
        Me.BtnHasil.FlatAppearance.BorderSize = 0
        Me.BtnHasil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnHasil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnHasil.ForeColor = System.Drawing.Color.DarkGray
        Me.BtnHasil.Name = "BtnHasil"
        Me.ToolTip1.SetToolTip(Me.BtnHasil, resources.GetString("BtnHasil.ToolTip"))
        Me.BtnHasil.UseVisualStyleBackColor = False
        '
        'BtnCekFile
        '
        resources.ApplyResources(Me.BtnCekFile, "BtnCekFile")
        Me.BtnCekFile.BackColor = System.Drawing.Color.Transparent
        Me.BtnCekFile.FlatAppearance.BorderSize = 0
        Me.BtnCekFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnCekFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnCekFile.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCekFile.Name = "BtnCekFile"
        Me.ToolTip1.SetToolTip(Me.BtnCekFile, resources.GetString("BtnCekFile.ToolTip"))
        Me.BtnCekFile.UseVisualStyleBackColor = False
        '
        'BtnAbout
        '
        resources.ApplyResources(Me.BtnAbout, "BtnAbout")
        Me.BtnAbout.FlatAppearance.BorderSize = 0
        Me.BtnAbout.Image = Global.ChecksumCheck.My.Resources.Resources.outline_help_outline_white_18dp
        Me.BtnAbout.Name = "BtnAbout"
        Me.ToolTip1.SetToolTip(Me.BtnAbout, resources.GetString("BtnAbout.ToolTip"))
        Me.BtnAbout.UseVisualStyleBackColor = True
        '
        'BtnPengaturan
        '
        resources.ApplyResources(Me.BtnPengaturan, "BtnPengaturan")
        Me.BtnPengaturan.FlatAppearance.BorderSize = 0
        Me.BtnPengaturan.Image = Global.ChecksumCheck.My.Resources.Resources.outline_settings_white_18dp
        Me.BtnPengaturan.Name = "BtnPengaturan"
        Me.ToolTip1.SetToolTip(Me.BtnPengaturan, resources.GetString("BtnPengaturan.ToolTip"))
        Me.BtnPengaturan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Name = "Label1"
        Me.ToolTip1.SetToolTip(Me.Label1, resources.GetString("Label1.ToolTip"))
        '
        'PnlSelector
        '
        resources.ApplyResources(Me.PnlSelector, "PnlSelector")
        Me.PnlSelector.BackColor = System.Drawing.SystemColors.Highlight
        Me.PnlSelector.Name = "PnlSelector"
        Me.ToolTip1.SetToolTip(Me.PnlSelector, resources.GetString("PnlSelector.ToolTip"))
        '
        'TxtPath
        '
        resources.ApplyResources(Me.TxtPath, "TxtPath")
        Me.TxtPath.AllowDrop = True
        Me.TxtPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TxtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPath.ForeColor = System.Drawing.Color.White
        Me.TxtPath.Name = "TxtPath"
        Me.ToolTip1.SetToolTip(Me.TxtPath, resources.GetString("TxtPath.ToolTip"))
        '
        'LblStatus
        '
        resources.ApplyResources(Me.LblStatus, "LblStatus")
        Me.LblStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblStatus.Name = "LblStatus"
        Me.ToolTip1.SetToolTip(Me.LblStatus, resources.GetString("LblStatus.ToolTip"))
        '
        'BtnBrowse
        '
        resources.ApplyResources(Me.BtnBrowse, "BtnBrowse")
        Me.BtnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BtnBrowse.FlatAppearance.BorderSize = 0
        Me.BtnBrowse.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.ToolTip1.SetToolTip(Me.BtnBrowse, resources.GetString("BtnBrowse.ToolTip"))
        Me.BtnBrowse.UseVisualStyleBackColor = False
        '
        'btnCheck
        '
        resources.ApplyResources(Me.btnCheck, "btnCheck")
        Me.btnCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCheck.FlatAppearance.BorderSize = 0
        Me.btnCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCheck.Name = "btnCheck"
        Me.ToolTip1.SetToolTip(Me.btnCheck, resources.GetString("btnCheck.ToolTip"))
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Name = "Label4"
        Me.ToolTip1.SetToolTip(Me.Label4, resources.GetString("Label4.ToolTip"))
        '
        'BtnSelectMode
        '
        resources.ApplyResources(Me.BtnSelectMode, "BtnSelectMode")
        Me.BtnSelectMode.FlatAppearance.BorderSize = 0
        Me.BtnSelectMode.Image = Global.ChecksumCheck.My.Resources.Resources.baseline_folder_open_white_18dp
        Me.BtnSelectMode.Name = "BtnSelectMode"
        Me.ToolTip1.SetToolTip(Me.BtnSelectMode, resources.GetString("BtnSelectMode.ToolTip"))
        Me.BtnSelectMode.UseVisualStyleBackColor = True
        '
        'BtnBuang
        '
        resources.ApplyResources(Me.BtnBuang, "BtnBuang")
        Me.BtnBuang.FlatAppearance.BorderSize = 0
        Me.BtnBuang.Image = Global.ChecksumCheck.My.Resources.Resources.outline_delete_white_18dp
        Me.BtnBuang.Name = "BtnBuang"
        Me.ToolTip1.SetToolTip(Me.BtnBuang, resources.GetString("BtnBuang.ToolTip"))
        Me.BtnBuang.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        resources.ApplyResources(Me.BtnClose, "BtnClose")
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.Image = Global.ChecksumCheck.My.Resources.Resources.outline_close_white_18dp
        Me.BtnClose.Name = "BtnClose"
        Me.ToolTip1.SetToolTip(Me.BtnClose, resources.GetString("BtnClose.ToolTip"))
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        resources.ApplyResources(Me.BtnTambah, "BtnTambah")
        Me.BtnTambah.FlatAppearance.BorderSize = 0
        Me.BtnTambah.Image = Global.ChecksumCheck.My.Resources.Resources.outline_add_white_18dp
        Me.BtnTambah.Name = "BtnTambah"
        Me.ToolTip1.SetToolTip(Me.BtnTambah, resources.GetString("BtnTambah.ToolTip"))
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        resources.ApplyResources(Me.BtnClear, "BtnClear")
        Me.BtnClear.FlatAppearance.BorderSize = 0
        Me.BtnClear.Image = Global.ChecksumCheck.My.Resources.Resources.outline_delete_white_18dp
        Me.BtnClear.Name = "BtnClear"
        Me.ToolTip1.SetToolTip(Me.BtnClear, resources.GetString("BtnClear.ToolTip"))
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        resources.ApplyResources(Me.BtnBack, "BtnBack")
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.Image = Global.ChecksumCheck.My.Resources.Resources.baseline_arrow_back_ios_white_18dp
        Me.BtnBack.Name = "BtnBack"
        Me.ToolTip1.SetToolTip(Me.BtnBack, resources.GetString("BtnBack.ToolTip"))
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        resources.ApplyResources(Me.BtnNext, "BtnNext")
        Me.BtnNext.FlatAppearance.BorderSize = 0
        Me.BtnNext.Image = Global.ChecksumCheck.My.Resources.Resources.baseline_arrow_forward_ios_white_18dp
        Me.BtnNext.Name = "BtnNext"
        Me.ToolTip1.SetToolTip(Me.BtnNext, resources.GetString("BtnNext.ToolTip"))
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'PnlCheck
        '
        resources.ApplyResources(Me.PnlCheck, "PnlCheck")
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
        Me.PnlCheck.Name = "PnlCheck"
        Me.ToolTip1.SetToolTip(Me.PnlCheck, resources.GetString("PnlCheck.ToolTip"))
        '
        'ListFiles
        '
        resources.ApplyResources(Me.ListFiles, "ListFiles")
        Me.ListFiles.AllowDrop = True
        Me.ListFiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ListFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListFiles.ForeColor = System.Drawing.Color.White
        Me.ListFiles.FormattingEnabled = True
        Me.ListFiles.Name = "ListFiles"
        Me.ToolTip1.SetToolTip(Me.ListFiles, resources.GetString("ListFiles.ToolTip"))
        '
        'PnlDrag
        '
        resources.ApplyResources(Me.PnlDrag, "PnlDrag")
        Me.PnlDrag.AllowDrop = True
        Me.PnlDrag.BackColor = System.Drawing.Color.Transparent
        Me.PnlDrag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlDrag.Controls.Add(Me.Label3)
        Me.PnlDrag.Controls.Add(Me.PictureBox1)
        Me.PnlDrag.Name = "PnlDrag"
        Me.ToolTip1.SetToolTip(Me.PnlDrag, resources.GetString("PnlDrag.ToolTip"))
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Name = "Label3"
        Me.ToolTip1.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip"))
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Image = Global.ChecksumCheck.My.Resources.Resources.baseline_insert_drive_file_white_24dp
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, resources.GetString("PictureBox1.ToolTip"))
        '
        'CheckCRC32
        '
        resources.ApplyResources(Me.CheckCRC32, "CheckCRC32")
        Me.CheckCRC32.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckCRC32.Name = "CheckCRC32"
        Me.ToolTip1.SetToolTip(Me.CheckCRC32, resources.GetString("CheckCRC32.ToolTip"))
        Me.CheckCRC32.UseVisualStyleBackColor = True
        '
        'CheckSHA512
        '
        resources.ApplyResources(Me.CheckSHA512, "CheckSHA512")
        Me.CheckSHA512.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckSHA512.Name = "CheckSHA512"
        Me.ToolTip1.SetToolTip(Me.CheckSHA512, resources.GetString("CheckSHA512.ToolTip"))
        Me.CheckSHA512.UseVisualStyleBackColor = True
        '
        'CheckSHA256
        '
        resources.ApplyResources(Me.CheckSHA256, "CheckSHA256")
        Me.CheckSHA256.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckSHA256.Name = "CheckSHA256"
        Me.ToolTip1.SetToolTip(Me.CheckSHA256, resources.GetString("CheckSHA256.ToolTip"))
        Me.CheckSHA256.UseVisualStyleBackColor = True
        '
        'CheckSHA1
        '
        resources.ApplyResources(Me.CheckSHA1, "CheckSHA1")
        Me.CheckSHA1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckSHA1.Name = "CheckSHA1"
        Me.ToolTip1.SetToolTip(Me.CheckSHA1, resources.GetString("CheckSHA1.ToolTip"))
        Me.CheckSHA1.UseVisualStyleBackColor = True
        '
        'CheckMD5
        '
        resources.ApplyResources(Me.CheckMD5, "CheckMD5")
        Me.CheckMD5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckMD5.Name = "CheckMD5"
        Me.ToolTip1.SetToolTip(Me.CheckMD5, resources.GetString("CheckMD5.ToolTip"))
        Me.CheckMD5.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.ToolTip1.SetToolTip(Me.TabControl1, resources.GetString("TabControl1.ToolTip"))
        '
        'TabPage2
        '
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Controls.Add(Me.PnlCheck)
        Me.TabPage2.Name = "TabPage2"
        Me.ToolTip1.SetToolTip(Me.TabPage2, resources.GetString("TabPage2.ToolTip"))
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Controls.Add(Me.PnlHasil)
        Me.TabPage1.Name = "TabPage1"
        Me.ToolTip1.SetToolTip(Me.TabPage1, resources.GetString("TabPage1.ToolTip"))
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PnlHasil
        '
        resources.ApplyResources(Me.PnlHasil, "PnlHasil")
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
        Me.PnlHasil.Name = "PnlHasil"
        Me.ToolTip1.SetToolTip(Me.PnlHasil, resources.GetString("PnlHasil.ToolTip"))
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Name = "Label6"
        Me.ToolTip1.SetToolTip(Me.Label6, resources.GetString("Label6.ToolTip"))
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Name = "Label5"
        Me.ToolTip1.SetToolTip(Me.Label5, resources.GetString("Label5.ToolTip"))
        '
        'LblTotalPage
        '
        resources.ApplyResources(Me.LblTotalPage, "LblTotalPage")
        Me.LblTotalPage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblTotalPage.Name = "LblTotalPage"
        Me.ToolTip1.SetToolTip(Me.LblTotalPage, resources.GetString("LblTotalPage.ToolTip"))
        '
        'LblCurrentPage
        '
        resources.ApplyResources(Me.LblCurrentPage, "LblCurrentPage")
        Me.LblCurrentPage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblCurrentPage.Name = "LblCurrentPage"
        Me.ToolTip1.SetToolTip(Me.LblCurrentPage, resources.GetString("LblCurrentPage.ToolTip"))
        '
        'CmbFile
        '
        resources.ApplyResources(Me.CmbFile, "CmbFile")
        Me.CmbFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.CmbFile.ForeColor = System.Drawing.Color.White
        Me.CmbFile.FormattingEnabled = True
        Me.CmbFile.Name = "CmbFile"
        Me.ToolTip1.SetToolTip(Me.CmbFile, resources.GetString("CmbFile.ToolTip"))
        '
        'TreeFile
        '
        resources.ApplyResources(Me.TreeFile, "TreeFile")
        Me.TreeFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TreeFile.ForeColor = System.Drawing.SystemColors.Window
        Me.TreeFile.Name = "TreeFile"
        Me.ToolTip1.SetToolTip(Me.TreeFile, resources.GetString("TreeFile.ToolTip"))
        '
        'LblFileName
        '
        resources.ApplyResources(Me.LblFileName, "LblFileName")
        Me.LblFileName.AutoEllipsis = True
        Me.LblFileName.BackColor = System.Drawing.Color.Transparent
        Me.LblFileName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblFileName.Name = "LblFileName"
        Me.ToolTip1.SetToolTip(Me.LblFileName, resources.GetString("LblFileName.ToolTip"))
        '
        'LblPath
        '
        resources.ApplyResources(Me.LblPath, "LblPath")
        Me.LblPath.AutoEllipsis = True
        Me.LblPath.BackColor = System.Drawing.Color.Transparent
        Me.LblPath.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblPath.Name = "LblPath"
        Me.ToolTip1.SetToolTip(Me.LblPath, resources.GetString("LblPath.ToolTip"))
        '
        'PnlCompare
        '
        resources.ApplyResources(Me.PnlCompare, "PnlCompare")
        Me.PnlCompare.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.PnlCompare.Controls.Add(Me.TxtComparer)
        Me.PnlCompare.Controls.Add(Me.Label2)
        Me.PnlCompare.Controls.Add(Me.BtnCompareFile)
        Me.PnlCompare.Controls.Add(Me.LblCompareStatus)
        Me.PnlCompare.Controls.Add(Me.PictCompareStatus)
        Me.PnlCompare.Name = "PnlCompare"
        Me.ToolTip1.SetToolTip(Me.PnlCompare, resources.GetString("PnlCompare.ToolTip"))
        '
        'TxtComparer
        '
        resources.ApplyResources(Me.TxtComparer, "TxtComparer")
        Me.TxtComparer.AllowDrop = True
        Me.TxtComparer.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TxtComparer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtComparer.ForeColor = System.Drawing.Color.White
        Me.TxtComparer.Name = "TxtComparer"
        Me.ToolTip1.SetToolTip(Me.TxtComparer, resources.GetString("TxtComparer.ToolTip"))
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.AutoEllipsis = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Name = "Label2"
        Me.ToolTip1.SetToolTip(Me.Label2, resources.GetString("Label2.ToolTip"))
        '
        'BtnCompareFile
        '
        resources.ApplyResources(Me.BtnCompareFile, "BtnCompareFile")
        Me.BtnCompareFile.BackColor = System.Drawing.Color.Transparent
        Me.BtnCompareFile.FlatAppearance.BorderSize = 0
        Me.BtnCompareFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnCompareFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BtnCompareFile.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCompareFile.Image = Global.ChecksumCheck.My.Resources.Resources.baseline_insert_drive_file_white_18dp
        Me.BtnCompareFile.Name = "BtnCompareFile"
        Me.ToolTip1.SetToolTip(Me.BtnCompareFile, resources.GetString("BtnCompareFile.ToolTip"))
        Me.BtnCompareFile.UseVisualStyleBackColor = False
        '
        'LblCompareStatus
        '
        resources.ApplyResources(Me.LblCompareStatus, "LblCompareStatus")
        Me.LblCompareStatus.AutoEllipsis = True
        Me.LblCompareStatus.BackColor = System.Drawing.Color.Transparent
        Me.LblCompareStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblCompareStatus.Name = "LblCompareStatus"
        Me.ToolTip1.SetToolTip(Me.LblCompareStatus, resources.GetString("LblCompareStatus.ToolTip"))
        '
        'PictCompareStatus
        '
        resources.ApplyResources(Me.PictCompareStatus, "PictCompareStatus")
        Me.PictCompareStatus.Image = Global.ChecksumCheck.My.Resources.Resources.ask_outlined_grey_128px
        Me.PictCompareStatus.Name = "PictCompareStatus"
        Me.PictCompareStatus.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictCompareStatus, resources.GetString("PictCompareStatus.ToolTip"))
        '
        'StatusStrip1
        '
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Highlight
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblProgress})
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.SizingGrip = False
        Me.ToolTip1.SetToolTip(Me.StatusStrip1, resources.GetString("StatusStrip1.ToolTip"))
        '
        'LblProgress
        '
        resources.ApplyResources(Me.LblProgress, "LblProgress")
        Me.LblProgress.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblProgress.Name = "LblProgress"
        '
        'ContextLstView
        '
        resources.ApplyResources(Me.ContextLstView, "ContextLstView")
        Me.ContextLstView.Name = "ContextLstView"
        Me.ToolTip1.SetToolTip(Me.ContextLstView, resources.GetString("ContextLstView.ToolTip"))
        '
        'SingleFileChecker
        '
        Me.SingleFileChecker.WorkerReportsProgress = True
        Me.SingleFileChecker.WorkerSupportsCancellation = True
        '
        'MultipleFileChecker
        '
        Me.MultipleFileChecker.WorkerReportsProgress = True
        Me.MultipleFileChecker.WorkerSupportsCancellation = True
        '
        'CompareFileChecker
        '
        '
        'Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PnlHeader)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
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
