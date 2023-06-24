<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LabelBatteryInfo = New Label()
        ProgressBarBattery = New ProgressBar()
        ListViewPowerInfo = New ListView()
        SuspendLayout()
        ' 
        ' LabelBatteryInfo
        ' 
        LabelBatteryInfo.AutoSize = True
        LabelBatteryInfo.Location = New Point(20, 23)
        LabelBatteryInfo.Name = "LabelBatteryInfo"
        LabelBatteryInfo.Size = New Size(41, 15)
        LabelBatteryInfo.TabIndex = 0
        LabelBatteryInfo.Text = "Label1"
        ' 
        ' ProgressBarBattery
        ' 
        ProgressBarBattery.Location = New Point(198, 15)
        ProgressBarBattery.Name = "ProgressBarBattery"
        ProgressBarBattery.Size = New Size(234, 23)
        ProgressBarBattery.TabIndex = 2
        ' 
        ' ListViewPowerInfo
        ' 
        ListViewPowerInfo.Location = New Point(12, 44)
        ListViewPowerInfo.Name = "ListViewPowerInfo"
        ListViewPowerInfo.Size = New Size(420, 146)
        ListViewPowerInfo.TabIndex = 3
        ListViewPowerInfo.UseCompatibleStateImageBehavior = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(449, 204)
        Controls.Add(ListViewPowerInfo)
        Controls.Add(ProgressBarBattery)
        Controls.Add(LabelBatteryInfo)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "Form5"
        Text = "Monitor de bateria"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelBatteryInfo As Label
    Friend WithEvents ProgressBarBattery As ProgressBar
    Friend WithEvents ListViewPowerInfo As ListView
End Class
