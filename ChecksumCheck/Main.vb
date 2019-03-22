Imports System.ComponentModel
Imports System.IO
Public Class Main
    Dim MultipleFiles As Boolean
    Dim FolderSelect As Boolean = False
    Dim openFile As New OpenFileDialog
    Public SelectedHash As ListViewItem
    Public ComputedFile As New List(Of FileInformation)
    Dim OpenFolder As New FolderBrowserDialog
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.Region = New Region(New RectangleF(Me.TabPage1.Left, Me.TabPage1.Top, Me.TabPage1.Width, Me.TabPage1.Height))
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
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ResetCompare()
        ResetSavedFileInfo()
        LstResult.Clear()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        MultipleFiles = True
        openFile.Multiselect = True
        BtnTambah.Visible = False
        BtnClose.Visible = True
        BtnBuang.Visible = True
        ListFiles.Visible = True
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

    Private Sub BtnBuang_Click(sender As Object, e As EventArgs) Handles BtnBuang.Click
        Try
            ListFiles.Items.Remove(ListFiles.SelectedItem)
        Catch ex As Exception

        End Try
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
                PnlCompare.Visible = False
                PnlCheck.Enabled = False
                PnlHasil.Enabled = False
            Case mode.ReadWrite
                BtnBrowse.Enabled = True
                PnlHasil.Enabled = False
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

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        ResetCompare()
        ResetSavedFileInfo()
        LstResult.Clear()
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

                    SingleFileChecker.RunWorkerAsync(FileInfo)
                    SetMode(mode.Read)
                Else
                    MsgBox("File belum dipilih", MsgBoxStyle.Critical, "Error")
                End If
                'initialize file


            End If
        End If
    End Sub
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
#End Region

#Region "WorkerManager"
    Private Sub CompareFileChecker_DoWork(sender As Object, e As DoWorkEventArgs) Handles CompareFileChecker.DoWork
        Try
            Dim ChecksumScanner As New Checksum
            Dim FileInfo As FileInformation = e.Argument
            LblProgress.Text = "Computing " & FileInfo.FileName & "..."


            FileInfo.MD5 = ChecksumScanner.ComputeFile(FileInfo.Path, HashType.MD5)
            TxtComparer.Text = FileInfo.MD5

        Catch ex As Exception
            e.Cancel = True
            SetMode(mode.ReadWrite)
        End Try
    End Sub

    Private Sub CompareFileChecker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles CompareFileChecker.RunWorkerCompleted
        SetMode(mode.ReadWrite)
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
    Private Sub ResetSavedFileInfo()
        ComputedFile.Clear()
        LblPath.Text = ""
    End Sub
    Private Sub SingleFileChecker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles SingleFileChecker.RunWorkerCompleted
        Dim FileInfo As FileInformation = ComputedFile(0)
        ComputedFile.Add(FileInfo)
        'for filename
        Dim column As ColumnHeader
        'setup column filename
        Dim columnName As New ColumnHeader
        columnName.Text = "File Name"
        'add column file name to listview
        LstResult.Columns.Add(columnName)
        Dim lstItem As ListViewItem = New ListViewItem(FileInfo.FileName)
        If Not FileInfo.MD5 = Nothing Then
            column = New ColumnHeader
            column.Text = "MD5"
            lstItem.SubItems.Add(FileInfo.MD5)
            'add column md5 to listview
            LstResult.Columns.Add(column)
        End If
        If Not FileInfo.SHA1 = Nothing Then
            column = New ColumnHeader
            column.Text = "SHA1"
            lstItem.SubItems.Add(FileInfo.SHA1)
            'add column sha1 to listview
            LstResult.Columns.Add(column)
        End If
        If Not FileInfo.SHA256 = Nothing Then
            column = New ColumnHeader
            column.Text = "SHA256"
            lstItem.SubItems.Add(FileInfo.SHA256)
            'add column sha256 to listview
            LstResult.Columns.Add(column)
        End If
        If Not FileInfo.SHA512 = Nothing Then
            column = New ColumnHeader
            column.Text = "SHA512"
            lstItem.SubItems.Add(FileInfo.SHA512)
            'add column sha512 to listview
            LstResult.Columns.Add(column)
        End If
        If Not FileInfo.CRC32 = Nothing Then
            column = New ColumnHeader
            column.Text = "CRC32"
            lstItem.SubItems.Add(FileInfo.CRC32)
            'add column crc32 to listview
            LstResult.Columns.Add(column)
        End If
        LstResult.Items.Add(lstItem)

        LstResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        ContextMenuOrganizer(LstResult.Columns)

        BtnHasil.PerformClick()
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
                ComputedFile.Add(FileInfo)
            Next
        Catch ex As Exception
            e.Cancel = True
        End Try

    End Sub

    Private Sub MultipleFileChecker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles MultipleFileChecker.RunWorkerCompleted
        Dim column As ColumnHeader
        Dim columnName As New ColumnHeader
        columnName.Text = "File Name"
        'add column file name to listview
        LstResult.Columns.Add(columnName)

        Dim FirstData = ComputedFile(0)
        If Not FirstData.MD5 = Nothing Then
            column = New ColumnHeader
            column.Name = "MD5"
            column.Text = "MD5"
            'add column md5 to listview
            LstResult.Columns.Add(column)
        End If
        If Not FirstData.SHA1 = Nothing Then
            column = New ColumnHeader
            column.Name = "SHA1"
            column.Text = "SHA1"
            'add column sha1 to listview
            LstResult.Columns.Add(column)
        End If
        If Not FirstData.SHA256 = Nothing Then
            column = New ColumnHeader
            column.Text = "SHA256"
            'add column sha256 to listview
            LstResult.Columns.Add(column)
        End If
        If Not FirstData.SHA512 = Nothing Then
            column = New ColumnHeader
            column.Text = "SHA512"
            'add column sha512 to listview
            LstResult.Columns.Add(column)
        End If
        If Not FirstData.CRC32 = Nothing Then
            column = New ColumnHeader
            column.Text = "CRC32"
            'add column crc32 to listview
            LstResult.Columns.Add(column)
        End If
        For Each FileInfo As FileInformation In ComputedFile
            Dim lstItem As ListViewItem = New ListViewItem(FileInfo.FileName)
            If Not FileInfo.MD5 = Nothing Then
                lstItem.SubItems.Add(FileInfo.MD5)
            End If
            If Not FileInfo.SHA1 = Nothing Then
                lstItem.SubItems.Add(FileInfo.SHA1)
            End If
            If Not FileInfo.SHA256 = Nothing Then
                lstItem.SubItems.Add(FileInfo.SHA256)
            End If
            If Not FileInfo.SHA512 = Nothing Then
                lstItem.SubItems.Add(FileInfo.SHA512)
            End If
            If Not FileInfo.CRC32 = Nothing Then
                lstItem.SubItems.Add(FileInfo.CRC32)
            End If
            LstResult.Items.Add(lstItem)
        Next
        LstResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        ContextMenuOrganizer(LstResult.Columns)
        BtnHasil.PerformClick()
        SetMode(mode.ReadWrite)
    End Sub

#End Region

#Region "Top Menu"
    Private Sub BtnPengaturan_Click(sender As Object, e As EventArgs) Handles BtnPengaturan.Click
        Pengaturan.Show()
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        AboutBox1.ShowDialog()
    End Sub
#End Region

#Region "Context Menu"
    Public Sub ContextMenuOrganizer(HashAvailable As ListView.ColumnHeaderCollection)
        'clear context menu item
        ContextLstView.Items.Clear()

        're-add context menu item
        For Each HashType As ColumnHeader In HashAvailable
            Dim item = ContextLstView.Items.Add("&Copy " & HashType.Text & " value")
            If item.Text.Contains("MD5") Then
                AddHandler item.Click, AddressOf MD5CopyEventHandler
            ElseIf item.Text.Contains("SHA1") Then
                AddHandler item.Click, AddressOf SHA1CopyEventHandler
            ElseIf item.Text.Contains("SHA256") Then
                AddHandler item.Click, AddressOf SHA256CopyEventHandler
            ElseIf item.Text.Contains("SHA512") Then
                AddHandler item.Click, AddressOf SHA512CopyEventHandler
            ElseIf item.Text.Contains("CRC32") Then
                AddHandler item.Click, AddressOf CRC32CopyEventHandler
            End If
        Next
    End Sub
    Private Sub MD5CopyEventHandler()
        Dim selectedInfo = ComputedFile.FindAll(Function(p) p.FileName = LstResult.FocusedItem.Text And p.Index = LstResult.FocusedItem.Index)
        Clipboard.SetText(selectedInfo(0).MD5)
    End Sub
    Private Sub SHA1CopyEventHandler()
        Dim selectedInfo = ComputedFile.FindAll(Function(p) p.FileName = LstResult.FocusedItem.Text And p.Index = LstResult.FocusedItem.Index)
        Clipboard.SetText(selectedInfo(0).SHA1)
    End Sub

    Private Sub SHA256CopyEventHandler()
        Dim selectedInfo = ComputedFile.FindAll(Function(p) p.FileName = LstResult.FocusedItem.Text And p.Index = LstResult.FocusedItem.Index)
        Clipboard.SetText(selectedInfo(0).SHA256)
    End Sub

    Private Sub SHA512CopyEventHandler()
        Dim selectedInfo = ComputedFile.FindAll(Function(p) p.FileName = LstResult.FocusedItem.Text And p.Index = LstResult.FocusedItem.Index)
        Clipboard.SetText(selectedInfo(0).SHA512)
    End Sub
    Private Sub CRC32CopyEventHandler()
        Dim selectedInfo = ComputedFile.FindAll(Function(p) p.FileName = LstResult.FocusedItem.Text And p.Index = LstResult.FocusedItem.Index)
        Clipboard.SetText(selectedInfo(0).CRC32)
    End Sub
#End Region

#Region "Drag drop file"
    Private Sub PnlDrag_DragEnter(sender As Object, e As DragEventArgs) Handles PnlDrag.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

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

    Private Sub LstResult_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstResult.SelectedIndexChanged
        LblPath.Visible = True
        PnlCompare.Visible = True

        Dim selectedInfo = ComputedFile.FindAll(Function(p) p.FileName = LstResult.FocusedItem.Text)
        LblPath.Text = selectedInfo.Item(0).Path
        LblFileName.Text = selectedInfo.Item(0).FileName

        SelectedHash = LstResult.FocusedItem
    End Sub

    Private Sub LstResult_MouseClick(sender As Object, e As MouseEventArgs) Handles LstResult.MouseClick
        If e.Button = MouseButtons.Right Then
            If LstResult.FocusedItem.Bounds.Contains(e.Location) Then
                ContextLstView.Show(Cursor.Position)
            End If
        End If
    End Sub

#End Region

#Region "Compare Checksum"

    Private Sub ResetCompare()
        TxtComparer.Clear()
        PictCompareStatus.Image = My.Resources.ask_outlined_grey_128px
        LblCompareStatus.Text = "Unknown"
    End Sub

    Private Sub TxtComparer_TextChanged(sender As Object, e As EventArgs) Handles TxtComparer.TextChanged
        Dim Result As Tuple(Of Image, String)
        Dim Similiar As Boolean = False
        For i = 1 To SelectedHash.SubItems.Count - 1
            If SelectedHash.SubItems(i).Text = TxtComparer.Text.ToUpper Then
                Result = New Tuple(Of Image, String)(My.Resources.checklist, "Same")
                Exit For
            Else
                Result = New Tuple(Of Image, String)(My.Resources.close, "Not Same")
            End If

        Next
        PictCompareStatus.Image = Result.Item1
        LblCompareStatus.Text = Result.Item2
    End Sub

    Private Sub BtnCompareFile_Click(sender As Object, e As EventArgs) Handles BtnCompareFile.Click
        If openFile.ShowDialog = DialogResult.OK Then
            Dim FileInfo As New FileInformation
            FileInfo.Path = openFile.FileName
            FileInfo.FileName = openFile.SafeFileName
            SetMode(mode.Read)
            CompareFileChecker.RunWorkerAsync(FileInfo)
        End If
    End Sub
#End Region

End Class