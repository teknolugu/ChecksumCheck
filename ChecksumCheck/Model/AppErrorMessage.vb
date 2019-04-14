Public Class AppErrorMessage
    Private _MessageTitle As String
    Private _MessageIcon As Image
    Private _MessageBody As String
    Public Sub New(parent As IWin32Window, MessageBody As String, MessageTitle As String)
        Me.SetMessageBody(MessageBody)
        Me.SetMessageTitle(MessageTitle)

        Me.ShowErrorMessage(parent, Me)
    End Sub
    Public Function GetMessageTitle() As String
        Return _MessageTitle
    End Function

    Public Sub SetMessageTitle(AutoPropertyValue As String)
        _MessageTitle = AutoPropertyValue
    End Sub

    Public Function GetMessageBody() As String
        Return _MessageBody
    End Function

    Public Sub SetMessageBody(AutoPropertyValue As String)
        _MessageBody = AutoPropertyValue
    End Sub

    Public Sub ShowErrorMessage(parent As IWin32Window, ErrorMessage As AppErrorMessage)
        ErrorDialog.ErrorMessage = ErrorMessage
        ErrorDialog.ShowDialog(parent)
    End Sub
End Class
