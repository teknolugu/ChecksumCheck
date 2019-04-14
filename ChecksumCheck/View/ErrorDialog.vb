Imports System.Windows.Forms

Public Class ErrorDialog
    Public Property ErrorMessage As AppErrorMessage
        Get
            Return _ErrorMessage
        End Get
        Set
            _ErrorMessage = Value
        End Set
    End Property

    Private _ErrorMessage As AppErrorMessage

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ErrorDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = ErrorMessage.GetMessageTitle
        Label1.Text = ErrorMessage.GetMessageBody
    End Sub

End Class
