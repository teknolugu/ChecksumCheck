<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pengaturan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pengaturan))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChckExplorer = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RdIndonesia = New System.Windows.Forms.RadioButton()
        Me.RdEnglish = New System.Windows.Forms.RadioButton()
        Me.ChckLowerCase = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Name = "Label2"
        '
        'ChckExplorer
        '
        resources.ApplyResources(Me.ChckExplorer, "ChckExplorer")
        Me.ChckExplorer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChckExplorer.Name = "ChckExplorer"
        Me.ChckExplorer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Name = "Label1"
        '
        'RdIndonesia
        '
        resources.ApplyResources(Me.RdIndonesia, "RdIndonesia")
        Me.RdIndonesia.Checked = True
        Me.RdIndonesia.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RdIndonesia.Name = "RdIndonesia"
        Me.RdIndonesia.TabStop = True
        Me.RdIndonesia.UseVisualStyleBackColor = True
        '
        'RdEnglish
        '
        resources.ApplyResources(Me.RdEnglish, "RdEnglish")
        Me.RdEnglish.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RdEnglish.Name = "RdEnglish"
        Me.RdEnglish.UseVisualStyleBackColor = True
        '
        'ChckLowerCase
        '
        resources.ApplyResources(Me.ChckLowerCase, "ChckLowerCase")
        Me.ChckLowerCase.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChckLowerCase.Name = "ChckLowerCase"
        Me.ChckLowerCase.UseVisualStyleBackColor = True
        '
        'Pengaturan
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.ChckLowerCase)
        Me.Controls.Add(Me.RdEnglish)
        Me.Controls.Add(Me.RdIndonesia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChckExplorer)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "Pengaturan"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents ChckExplorer As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RdIndonesia As RadioButton
    Friend WithEvents RdEnglish As RadioButton
    Friend WithEvents ChckLowerCase As CheckBox
End Class
