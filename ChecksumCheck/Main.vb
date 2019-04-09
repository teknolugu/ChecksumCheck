Imports System.ComponentModel
Imports System.IO

Public Class Main
    Private ComputedFile As New List(Of FileInformation)
    Private SelectedFileInfo As FileInformation
    Private FolderSelect As Boolean = False
    Private MultipleFiles As Boolean
    Private openFile As New OpenFileDialog
    Private OpenFolder As New FolderBrowserDialog
    Private SelectedFile As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.Region = New Region(New RectangleF(TabPage1.Left, TabPage1.Top, TabPage1.Width, TabPage1.Height))
        CheckForIllegalCrossThreadCalls = False
        Try
            Dim FilePath As String = Environment.GetCommandLineArgs(2)
            Dim Parameter As String = Environment.GetCommandLineArgs(1)
            SetParameter(Parameter)
            TxtPath.Text = FilePath
            btnCheck.PerformClick()
        Catch
        End Try
    End Sub

#Region "Parameter Handler"

    Private Sub SetParameter(parameter As String)
        Select Case parameter
            Case "/md5"
                CheckMD5.Checked = True
            Case "/sha1"
                CheckSHA1.Checked = True
            Case "/sha256"
                CheckSHA256.Checked = True
            Case "/sha512"
                CheckSHA512.Checked = True
            Case "/crc32"
                CheckCRC32.Checked = True
        End Select
    End Sub

#End Region

#Region "UI Customizer"

    Public Sub SetForeColor(Btn1 As Color, Btn2 As Color)
        BtnCekFile.ForeColor = Btn1
        BtnHasil.ForeColor = Btn2
    End Sub

#End Region

#Region "TabController"

    Private Sub BtnCekFile_Click(sender As Object, e As EventArgs) Handles BtnCekFile.Click
        TabControl1.SelectedTab = TabPage2
        PnlSelector.Size = New Size(56, 3)
        PnlSelector.Location = New Point(37, 99)
        SetForeColor(Color.White, Color.DarkGray)
    End Sub

    Private Sub BtnHasil_Click(sender As Object, e As EventArgs) Handles BtnHasil.Click
        TabControl1.SelectedTab = TabPage1
        PnlSelector.Size = New Size(56, 3)
        PnlSelector.Location = New Point(118, 99)
        SetForeColor(Color.DarkGray, Color.White)
    End Sub

#End Region

#Region "ButtonDataController"

    Private Sub BtnBuang_Click(sender As Object, e As EventArgs) Handles BtnBuang.Click
        Try
            ListFiles.Items.Remove(ListFiles.SelectedItem)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ResetCompare()
        ResetSavedFileInfo()
        LblFileName.Text = "Hasil"
        TreeFile.Nodes.Clear()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        MultipleFiles = False
        openFile.Multiselect = False
        BtnTambah.Visible = True
        BtnClose.Visible = False
        BtnBuang.Visible = False
        ListFiles.Visible = False
        ListFiles.Items.Clear()

    End Sub

    Private Sub BtnSelectMode_Click(sender As Object, e As EventArgs) Handles BtnSelectMode.Click
        If FolderSelect = False Then
            MultipleFiles = True
            FolderSelect = True
            BtnSelectMode.Image = My.Resources.baseline_insert_drive_file_white_18dp
            LblStatus.Text = "Pilih Folder"
            BtnTambah.Visible = False
            ListFiles.Visible = True
            BtnBuang.Visible = True
            ToolTip1.SetToolTip(BtnSelectMode, "Select file")
        Else
            BtnTambah.Visible = True
            ListFiles.Items.Clear()
            LblStatus.Text = "Pilih File"
            BtnBuang.Visible = False
            ListFiles.Visible = False
            MultipleFiles = False
            FolderSelect = False
            BtnSelectMode.Image = My.Resources.baseline_folder_open_white_18dp
            ToolTip1.SetToolTip(BtnSelectMode, "Select folder")
        End If

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        MultipleFiles = True
        openFile.Multiselect = True
        BtnTambah.Visible = False
        BtnClose.Visible = True
        BtnBuang.Visible = True
        ListFiles.Visible = True
    End Sub

#End Region

#Region "Form Mode"

    Public Enum mode
        Read
        ReadWrite
    End Enum

    Public Sub SetMode(Mode As mode)
        Select Case Mode
            Case mode.Read
                BtnBrowse.Enabled = False
                BtnTambah.Enabled = False
                BtnBuang.Enabled = False
                BtnClose.Enabled = False
                BtnSelectMode.Enabled = False
                btnCheck.Enabled = False
                PnlCheck.Enabled = False
                PnlHasil.Enabled = False
                BtnPengaturan.Enabled = False
            Case mode.ReadWrite
                BtnPengaturan.Enabled = True
                BtnBrowse.Enabled = True
                PnlHasil.Enabled = True
                PnlCheck.Enabled = True
                BtnTambah.Enabled = True
                BtnBuang.Enabled = True
                BtnClose.Enabled = True
                BtnSelectMode.Enabled = True
                btnCheck.Enabled = True
                LblProgress.Text = "Ready"
        End Select
    End Sub

#End Region

#Region "FormController"

    Public Function NothingChecked() As Boolean
        If CheckMD5.Checked = False And CheckSHA1.Checked = False And CheckSHA256.Checked = False And CheckSHA512.Checked = False And CheckCRC32.Checked = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        If FolderSelect = True Then
            If OpenFolder.ShowDialog = DialogResult.OK Then
                For Each LstFile As String In Directory.GetFiles(OpenFolder.SelectedPath)
                    ListFiles.Items.Add(LstFile)
                Next
            End If
        Else
            If openFile.ShowDialog = DialogResult.OK Then
                If MultipleFiles = True Then
                    For Each item As String In openFile.FileNames
                        ListFiles.Items.Add(item)
                    Next
                Else
                    TxtPath.Text = openFile.FileName
                End If
            End If
        End If

    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        CleanResult()
        LblFileName.Text = "Hasil"
        If NothingChecked() Then
            MsgBox("Jenis hash belum dipilih", MsgBoxStyle.Critical, "Error")
        Else
            If MultipleFiles Then
                If ListFiles.Items.Count = 0 Then
                    MsgBox("File belum dipilih", MsgBoxStyle.Critical, "Error")
                ElseIf ListFiles.Items.Count = 1 Then
                    MsgBox("Pilih Minimal 2 file", MsgBoxStyle.Critical, "Error")
                Else
                    BtnBack.Visible = True
                    BtnNext.Visible = True
                    MultipleFileChecker.RunWorkerAsync()
                    SetMode(mode.Read)
                End If
            Else
                If Not TxtPath.Text = "" Then
                    Dim FileInfo As New FileInformation
                    FileInfo.Index = 0
                    FileInfo.FileName = Path.GetFileName(TxtPath.Text)
                    FileInfo.Format = Path.GetExtension(TxtPath.Text)
                    FileInfo.Path = TxtPath.Text

                    BtnBack.Visible = False
                    BtnNext.Visible = False
                    SingleFileChecker.RunWorkerAsync(FileInfo)
                    SetMode(mode.Read)
                Else
                    MsgBox("File belum dipilih", MsgBoxStyle.Critical, "Error")
                End If
                'initialize file

            End If
        End If
    End Sub

    Private Sub CleanResult()
        ResetSavedFileInfo()
        ResetCompare()
        TreeFile.Nodes.Clear()
        CmbFile.Items.Clear()
    End Sub

#End Region

#Region "WorkerManager"

    Private Sub CompareFileChecker_DoWork(sender As Object, e As DoWorkEventArgs) Handles CompareFileChecker.DoWork
        Try
            Dim HashToCompare = ""
            Dim ChecksumScanner As New Checksum
            Dim FileInfo As FileInformation = e.Argument
            If Not SelectedFileInfo.CRC32 = Nothing Then
                HashToCompare = "CRC32"
            End If
            If Not SelectedFileInfo.SHA512 = Nothing Then
                HashToCompare = "SHA512"
            End If
            If Not SelectedFileInfo.SHA256 = Nothing Then
                HashToCompare = "SHA256"
            End If
            If Not SelectedFileInfo.SHA1 = Nothing Then
                HashToCompare = "SHA1"
            End If
            If Not SelectedFileInfo.MD5 = Nothing Then
                HashToCompare = "MD5"
            End If
            LblProgress.Text = "Computing " & FileInfo.FileName & "..."

            If HashToCompare = "MD5" Then
                FileInfo.MD5 = ChecksumScanner.ComputeFile(FileInfo.Path, HashType.MD5)
                TxtComparer.Text = FileInfo.MD5
            ElseIf HashToCompare = "SHA1" Then
                FileInfo.SHA1 = ChecksumScanner.ComputeFile(FileInfo.Path, HashType.SHA1)
                TxtComparer.Text = FileInfo.SHA1
            ElseIf HashToCompare = "SHA256" Then
                FileInfo.SHA256 = ChecksumScanner.ComputeFile(FileInfo.Path, HashType.SHA256)
                TxtComparer.Text = FileInfo.SHA256
            ElseIf HashToCompare = "SHA512" Then
                FileInfo.SHA512 = ChecksumScanner.ComputeFile(FileInfo.Path, HashType.SHA512)
                TxtComparer.Text = FileInfo.SHA512
            ElseIf HashToCompare = "CRC32" Then
                FileInfo.CRC32 = ChecksumScanner.ComputeFile(FileInfo.Path, HashType.CRC32)
                TxtComparer.Text = FileInfo.CRC32
            End If
        Catch ex As Exception
            e.Cancel = True
            SetMode(mode.ReadWrite)
        End Try

    End Sub

    Private Sub CompareFileChecker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles CompareFileChecker.RunWorkerCompleted
        SetMode(mode.ReadWrite)
    End Sub

    Private Sub MultipleFileChecker_DoWork(sender As Object, e As DoWorkEventArgs) Handles MultipleFileChecker.DoWork
        Try
            Dim ChecksumScanner As New Checksum
            For i = 0 To ListFiles.Items.Count - 1
                Dim FileInfo As New FileInformation
                FileInfo.Index = i
                FileInfo.Path = ListFiles.Items(i)
                FileInfo.FileName = Path.GetFileName(FileInfo.Path)
                FileInfo.Format = Path.GetExtension(FileInfo.Path)
                LblProgress.Text = "Computing " & FileInfo.FileName & "..."
                If CheckMD5.Checked Then
                    FileInfo.MD5 = ChecksumScanner.ComputeFile(FileInfo.Path, HashType.MD5)
                End If
                If CheckSHA1.Checked Then
                    FileInfo.SHA1 = ChecksumScanner.ComputeFile(FileInfo.Path, HashType.SHA1)
                End If
                If CheckSHA256.Checked Then
                    FileInfo.SHA256 = ChecksumScanner.ComputeFile(FileInfo.Path, HashType.SHA256)
                End If
                If CheckSHA512.Checked Then
                    FileInfo.SHA512 = ChecksumScanner.ComputeFile(FileInfo.Path, HashType.SHA512)
                End If
                If CheckCRC32.Checked Then
                    FileInfo.CRC32 = ChecksumScanner.ComputeFile(FileInfo.Path, HashType.CRC32)
                End If
                CmbFile.Items.Add(FileInfo.FileName)
                ComputedFile.Add(FileInfo)
            Next
        Catch ex As Exception
            e.Cancel = True
        End Try

    End Sub

    Private Sub MultipleFileChecker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles MultipleFileChecker.RunWorkerCompleted
        SetView(ViewPage.First)
        CountPage()
        ContextMenuOrganizer()

        BtnHasil.PerformClick()
        SetMode(mode.ReadWrite)
    End Sub

    Private Sub ResetSavedFileInfo()
        ComputedFile.Clear()
        LblPath.Text = ""
    End Sub

    Private Sub CountPage()
        LblTotalPage.Text = ComputedFile.Count
    End Sub

    Private Sub SingleFileChecker_DoWork(sender As Object, e As DoWorkEventArgs) Handles SingleFileChecker.DoWork
        Try
            Dim ChecksumScanner As New Checksum
            Dim FileInfo As FileInformation = e.Argument
            LblProgress.Text = "Computing " & FileInfo.FileName & "..."

            If CheckMD5.Checked Then
                FileInfo.MD5 = ChecksumScanner.ComputeFile(FileInfo.Path, HashType.MD5)
            End If
            If CheckSHA1.Checked Then
                FileInfo.SHA1 = ChecksumScanner.ComputeFile(FileInfo.Path, HashType.SHA1)
            End If
            If CheckSHA256.Checked Then
                FileInfo.SHA256 = ChecksumScanner.ComputeFile(FileInfo.Path, HashType.SHA256)
            End If
            If CheckSHA512.Checked Then
                FileInfo.SHA512 = ChecksumScanner.ComputeFile(FileInfo.Path, HashType.SHA512)
            End If
            If CheckCRC32.Checked Then
                FileInfo.CRC32 = ChecksumScanner.ComputeFile(FileInfo.Path, HashType.CRC32)
            End If

            ComputedFile.Add(FileInfo)
        Catch ex As Exception
            e.Cancel = True
            SetMode(mode.ReadWrite)
        End Try
    End Sub

    Private Sub SingleFileChecker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles SingleFileChecker.RunWorkerCompleted
        SetView(ViewPage.First)
        CountPage()
        ContextMenuOrganizer()

        BtnHasil.PerformClick()
        SetMode(mode.ReadWrite)
    End Sub

#End Region

#Region "Top Menu"

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub BtnPengaturan_Click(sender As Object, e As EventArgs) Handles BtnPengaturan.Click
        Pengaturan.Show()
    End Sub

#End Region

#Region "Compare Checksum"

    Private Sub BtnCompareFile_Click(sender As Object, e As EventArgs) Handles BtnCompareFile.Click
        If openFile.ShowDialog = DialogResult.OK Then
            Dim FileInfo As New FileInformation
            FileInfo.Path = openFile.FileName
            FileInfo.FileName = openFile.SafeFileName
            SetMode(mode.Read)
            CompareFileChecker.RunWorkerAsync(FileInfo)
        End If
    End Sub

    Private Sub ResetCompare()
        TxtComparer.Clear()
        PictCompareStatus.Image = My.Resources.ask_outlined_grey_128px
        LblCompareStatus.Text = "Unknown"
    End Sub

    Private Sub Compare(hashToCompare As String)
        Dim Result As Tuple(Of String, Image, HashType) = Nothing
        Dim obj As Tuple(Of String, HashType)
        Dim HashCollection As New List(Of Tuple(Of String, HashType))
        If Not SelectedFileInfo.MD5 = Nothing Then
            obj = New Tuple(Of String, HashType)(SelectedFileInfo.MD5, HashType.MD5)
            HashCollection.Add(obj)
        End If
        If Not SelectedFileInfo.SHA1 = Nothing Then
            obj = New Tuple(Of String, HashType)(SelectedFileInfo.SHA1, HashType.SHA1)
            HashCollection.Add(obj)
        End If
        If Not SelectedFileInfo.SHA256 = Nothing Then
            obj = New Tuple(Of String, HashType)(SelectedFileInfo.SHA256, HashType.SHA256)
            HashCollection.Add(obj)
        End If
        If Not SelectedFileInfo.SHA512 = Nothing Then
            obj = New Tuple(Of String, HashType)(SelectedFileInfo.SHA512, HashType.SHA512)
            HashCollection.Add(obj)
        End If
        If Not SelectedFileInfo.CRC32 = Nothing Then
            obj = New Tuple(Of String, HashType)(SelectedFileInfo.CRC32, HashType.CRC32)
            HashCollection.Add(obj)
        End If

        'compare
        For i As Integer = 0 To HashCollection.Count - 1
            If HashCollection(i).Item1.ToUpper = hashToCompare.ToUpper Then
                Result = New Tuple(Of String, Image, HashType)("Same", My.Resources.checklist, HashCollection(i).Item2)
                Exit For
            Else
                Result = New Tuple(Of String, Image, HashType)("Not same", My.Resources.close, Nothing)
            End If
        Next

        PictCompareStatus.Image = Result.Item2
        If Result.Item1.Contains("Same") Then
            LblCompareStatus.Text = [Enum].GetName(GetType(HashType), Result.Item3) & " is match"
        Else
            PictCompareStatus.Image = Result.Item2
            LblCompareStatus.Text = "Hash is not match"
        End If
    End Sub

    Private Sub TxtComparer_TextChanged(sender As Object, e As EventArgs) Handles TxtComparer.TextChanged
        Compare(TxtComparer.Text)
    End Sub

#End Region

#Region "Navigation"

    Private Sub SetSelectedFile(index As Integer)
        Try
            'clear treeview
            TreeFile.Nodes.Clear()

            SelectedFileInfo = ComputedFile(index)
            'setup icon
            Dim imgList As New ImageList
            imgList.ImageSize = New Size(18, 18)
            TreeFile.ImageList = imgList

            imgList.Images.Add(Icon.ExtractAssociatedIcon(SelectedFileInfo.Path).ToBitmap)
            imgList.Images.Add(My.Resources.baseline_code_white_18dp)
            'setup item
            Dim FileNameNodes = TreeFile.Nodes.Add("File name : " & SelectedFileInfo.FileName)
            FileNameNodes.ImageIndex = 0
            'subnode
            If Not SelectedFileInfo.MD5 = Nothing Then
                Dim MD5Nodes = FileNameNodes.Nodes.Add("MD5 : " & SelectedFileInfo.MD5)
                MD5Nodes.ImageIndex = 1
                MD5Nodes.SelectedImageIndex = 1
            End If
            If Not SelectedFileInfo.SHA1 = Nothing Then
                Dim SHA1Nodes = FileNameNodes.Nodes.Add("SHA1 : " & SelectedFileInfo.SHA1)
                SHA1Nodes.ImageIndex = 1
                SHA1Nodes.SelectedImageIndex = 1
            End If
            If Not SelectedFileInfo.SHA256 = Nothing Then
                Dim SHA256Nodes = FileNameNodes.Nodes.Add("SHA256 : " & SelectedFileInfo.SHA256)
                SHA256Nodes.ImageIndex = 1
                SHA256Nodes.SelectedImageIndex = 1
            End If
            If Not SelectedFileInfo.SHA512 = Nothing Then
                Dim SHA512Nodes = FileNameNodes.Nodes.Add("SHA512 : " & SelectedFileInfo.SHA512)
                SHA512Nodes.ImageIndex = 1
                SHA512Nodes.SelectedImageIndex = 1
            End If
            If Not SelectedFileInfo.CRC32 = Nothing Then
                Dim CRC32Nodes = FileNameNodes.Nodes.Add("CRC32 : " & SelectedFileInfo.CRC32)
                CRC32Nodes.ImageIndex = 1
                CRC32Nodes.SelectedImageIndex = 1
            End If
        Catch ex As Exception
            MsgBox("An error occured " & ex.Message, MsgBoxStyle.Critical)
            SetView(ViewPage.First)
        End Try
    End Sub

    Private Sub JumpPage(PageNumber As Integer)
        If Not PageNumber = ComputedFile.Count - 1 Then
            SetSelectedFile(PageNumber)
        End If
    End Sub

    Private Sub SetView(Action As ViewPage)
        If Action = ViewPage.Forward Then
            If Not SelectedFile = ComputedFile.Count And Not SelectedFile = ComputedFile.Count - 1 Then
                SelectedFile += 1
                LblCurrentPage.Text = SelectedFile + 1
                SetSelectedFile(SelectedFile)
            End If
        ElseIf Action = ViewPage.Backward Then
            If Not SelectedFile = 0 Then
                SelectedFile -= 1
                LblCurrentPage.Text = SelectedFile + 1
                SetSelectedFile(SelectedFile)
            End If
        ElseIf Action = ViewPage.First Then
            SelectedFile = 0
            LblCurrentPage.Text = SelectedFile + 1
            SetSelectedFile(SelectedFile)
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        SetView(ViewPage.Backward)
        If Not TxtComparer.Text = Nothing Then
            Compare(TxtComparer.Text)
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        SetView(ViewPage.Forward)
        If Not TxtComparer.Text = Nothing Then
            Compare(TxtComparer.Text)
        End If
    End Sub

    Private Sub CmbFile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFile.SelectedIndexChanged
        JumpPage(CmbFile.SelectedIndex)
        SelectedFile = CmbFile.SelectedIndex
        LblCurrentPage.Text = CmbFile.SelectedIndex + 1
        If Not TxtComparer.Text = Nothing Then
            Compare(TxtComparer.Text)
        End If
    End Sub

#End Region

#Region "Context menu"

    Private Sub TreeFile_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeFile.NodeMouseClick
        If e.Button.Equals(MouseButtons.Right) Then
            ContextLstView.Show(MousePosition)
        End If
    End Sub

    Private Sub ContextMenuOrganizer()
        ContextLstView.Items.Clear()

        If Not SelectedFileInfo.MD5 = Nothing Then
            Dim item As ToolStripItem = ContextLstView.Items.Add("&Copy MD5 value")
            AddHandler item.Click, AddressOf MD5_Copy_Menu_ItemClick
        End If

        If Not SelectedFileInfo.SHA1 = Nothing Then
            Dim item As ToolStripItem = ContextLstView.Items.Add("&Copy SHA1 value")
            AddHandler item.Click, AddressOf SHA1_Copy_Menu_ItemClick
        End If

        If Not SelectedFileInfo.SHA256 = Nothing Then
            Dim item As ToolStripItem = ContextLstView.Items.Add("&Copy SHA256 value")
            AddHandler item.Click, AddressOf SHA256_Copy_Menu_ItemClick
        End If

        If Not SelectedFileInfo.SHA512 = Nothing Then
            Dim item As ToolStripItem = ContextLstView.Items.Add("&Copy SHA512 value")
            AddHandler item.Click, AddressOf SHA512_Copy_Menu_ItemClick
        End If
        If Not SelectedFileInfo.CRC32 = Nothing Then
            Dim item As ToolStripItem = ContextLstView.Items.Add("&Copy CRC32 value")
            AddHandler item.Click, AddressOf CRC32_Copy_Menu_ItemClick
        End If

    End Sub

    Private Sub MD5_Copy_Menu_ItemClick()
        Clipboard.SetText(SelectedFileInfo.MD5)
    End Sub

    Private Sub SHA1_Copy_Menu_ItemClick()
        Clipboard.SetText(SelectedFileInfo.SHA1)
    End Sub

    Private Sub SHA256_Copy_Menu_ItemClick()
        Clipboard.SetText(SelectedFileInfo.SHA256)
    End Sub

    Private Sub SHA512_Copy_Menu_ItemClick()
        Clipboard.SetText(SelectedFileInfo.SHA512)
    End Sub

    Private Sub CRC32_Copy_Menu_ItemClick()
        Clipboard.SetText(SelectedFileInfo.CRC32)
    End Sub

#End Region

#Region "Drag drop"

    Private Sub PnlDrag_DragDrop(sender As Object, e As DragEventArgs) Handles PnlDrag.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        If files.Count > 1 Then
            If Not MultipleFiles Then
                BtnTambah.PerformClick()
            End If
            For Each path In files
                Dim attr As FileAttributes = File.GetAttributes(path)
                If Not attr.HasFlag(FileAttributes.Directory) Then
                    ListFiles.Items.Add(path)
                Else
                    MsgBox("Directory is not supported", MsgBoxStyle.Critical)
                End If
            Next
        ElseIf files.Count = 1 Then
            Dim attr As FileAttributes = File.GetAttributes(files(0))
            If Not attr.HasFlag(FileAttributes.Directory) Then
                If MultipleFiles Then
                    ListFiles.Items.Add(files(0))
                Else
                    TxtPath.Text = files(0)
                End If
            Else
                MsgBox("Directory is not supported", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub PnlDrag_DragEnter(sender As Object, e As DragEventArgs) Handles PnlDrag.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

#End Region

End Class