Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Threading
Namespace My
    Partial Class MyApplication
        Protected Overrides Function OnStartup(eventArgs As StartupEventArgs) As Boolean
            If Settings.Language = 0 Then
                Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("id")
            Else
                Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("en-US")
            End If
            Return MyBase.OnStartup(eventArgs)
        End Function
    End Class
End Namespace
