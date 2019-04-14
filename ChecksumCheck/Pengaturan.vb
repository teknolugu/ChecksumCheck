Imports System.Runtime.InteropServices
Imports System.Threading
Public Class Pengaturan
    Dim RegistryManager As New RegEdit
    <DllImport("user32", CharSet:=CharSet.Auto, SetLastError:=True)>
    Shared Function SendMessage(
        ByVal hWnd As IntPtr,
        ByVal Msg As UInt32,
        ByVal wParam As Integer,
        ByVal lParam As IntPtr) _
        As Integer
    End Function
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Const BCM_SETSHIELD As UInt32 = &H160C
    Private Sub Pengaturan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check if registry exists
        Try
            Select Case RegistryManager.CheckIfRegistryExists
                Case True
                    My.Settings.ExplorerContextMenu = True
                Case False
                    My.Settings.ExplorerContextMenu = False
            End Select
            My.Settings.Save()
        Catch ex As Exception
            MsgBox("An error occured when checking registry settings " + ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try

        BackColor = ColorTranslator.FromHtml("#2E2E2E")
        ChckExplorer.Checked = My.Settings.ExplorerContextMenu
        SendMessage(ChckExplorer.Handle, BCM_SETSHIELD, 0, New IntPtr(1))
        AddHandler ChckExplorer.CheckedChanged, AddressOf ChckExplorer_CheckedChanged

        Select Case My.Settings.Language
            Case 0
                RdIndonesia.Checked = True
            Case 1
                RdEnglish.Checked = True
        End Select

        AddHandler RdIndonesia.CheckedChanged, AddressOf RdIndonesia_CheckedChanged
        AddHandler RdEnglish.CheckedChanged, AddressOf RdEnglish_CheckedChanged
    End Sub

    Private Sub ChckExplorer_CheckedChanged(sender As Object, e As EventArgs)
        If Not My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
            Select Case MessageBox.Show(Me, "This action require administrator permission " & Environment.NewLine & Environment.NewLine & "Would you like to restart the app and run app as administrator?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case DialogResult.Yes
                    Dim proc As New ProcessStartInfo
                    proc.UseShellExecute = True
                    proc.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory
                    proc.FileName = Application.ExecutablePath
                    proc.Verb = "runas"
                    Try
                        Process.Start(proc)
                        End
                    Catch ex As Exception

                    End Try
                Case DialogResult.No
                    Controls.Clear()
                    InitializeComponent()
                    Pengaturan_Load(e, e)
                    MsgBox("Action canceled", MsgBoxStyle.Critical)
            End Select

        Else
            If ChckExplorer.Checked = True Then
                Try
                    RegistryManager.CreateRegistry()
                    My.Settings.ExplorerContextMenu = True
                Catch ex As Exception
                    MsgBox("Error saat membuat context menu", MsgBoxStyle.Critical)
                End Try
            Else
                Try
                    RegistryManager.DeleteRegistry()
                    My.Settings.ExplorerContextMenu = False
                Catch ex As Exception
                    MsgBox("Error saat menghapus context menu", MsgBoxStyle.Critical)
                    If ex.Message.Contains("not exist") Then
                        My.Settings.ExplorerContextMenu = False
                    End If
                End Try
            End If
            My.Settings.Save()
        End If

    End Sub
    Private Sub ChangeLanguage()


    End Sub

    Private Sub RdEnglish_CheckedChanged(sender As Object, e As EventArgs)
        If RdEnglish.Checked Then
            My.Settings.Language = 1
            My.Settings.Save()

            LanguageSettings.SetLanguage(Language.English)

            Controls.Clear()
            InitializeComponent()
            Pengaturan_Load(e, e)
            'main form
            Main.Close()
            Main.Show()
        End If
    End Sub

    Private Sub RdIndonesia_CheckedChanged(sender As Object, e As EventArgs)
        If RdIndonesia.Checked Then
            My.Settings.Language = 0
            My.Settings.Save()

            LanguageSettings.SetLanguage(Language.Indonesian)

            Controls.Clear()
            InitializeComponent()
            Pengaturan_Load(e, e)
            'main form
            Main.Close()
            Main.Show()
        End If
    End Sub
End Class