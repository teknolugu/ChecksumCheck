Imports System.Globalization
Imports System.Threading
Public Class LanguageSettings
    Public Shared Function GetLanguage() As Language
        Select Case My.Settings.Language
            Case 0
                Return Language.Indonesian
            Case 1
                Return Language.English
        End Select
    End Function

    Public Shared Sub SetLanguage(MyLanguage As Language)
        If MyLanguage = Language.Indonesian Then
            Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("id")
        Else
            Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("en-US")
        End If
    End Sub
End Class
