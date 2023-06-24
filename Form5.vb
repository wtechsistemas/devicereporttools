Imports System.Windows.Forms
Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.Windows.Forms.SystemInformation.PowerStatus.BatteryChargeStatus = BatteryChargeStatus.NoSystemBattery Then
            ' Não há bateria no sistema
            LabelBatteryInfo.Text = "Sem bateria"
            ProgressBarBattery.Visible = False
        Else
            ' Exibir informações da bateria
            Dim batteryPercent As Integer = CInt(System.Windows.Forms.SystemInformation.PowerStatus.BatteryLifePercent * 100)


            LabelBatteryInfo.Text = $"Bateria: {batteryPercent}%"
            ProgressBarBattery.Value = batteryPercent

        End If
        ' Configurar o ListView
        ListViewPowerInfo.View = View.Details
        ListViewPowerInfo.Columns.Add("Propriedade", 150)
        ListViewPowerInfo.Columns.Add("Valor", 150)

        ' Adicionar as informações sobre energia no ListView
        AddPowerInfo("PowerStatus", System.Windows.Forms.SystemInformation.PowerStatus.ToString())
        AddPowerInfo("BatteryChargeStatus", System.Windows.Forms.SystemInformation.PowerStatus.BatteryChargeStatus.ToString())
        AddPowerInfo("BatteryFullLifetime", System.Windows.Forms.SystemInformation.PowerStatus.BatteryFullLifetime.ToString())
        AddPowerInfo("BatteryLifePercent", System.Windows.Forms.SystemInformation.PowerStatus.BatteryLifePercent.ToString())
        AddPowerInfo("BatteryLifeRemaining", System.Windows.Forms.SystemInformation.PowerStatus.BatteryLifeRemaining.ToString())
        AddPowerInfo("PowerLineStatus", System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus.ToString())

        ' Redimensionar as colunas do ListView para ajustar o conteúdo
        ListViewPowerInfo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

    End Sub
    Private Sub AddPowerInfo(propertyName As String, propertyValue As String)
        Dim item As New ListViewItem(propertyName)
        item.SubItems.Add(propertyValue)
        ListViewPowerInfo.Items.Add(item)
    End Sub
End Class