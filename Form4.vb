Imports System.IO
Imports System.Management
Imports OpenHardwareMonitor.Hardware

Public Class Form4

    Private computer As New Computer()

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Obter informações do disco principal
        Dim drive As DriveInfo = New DriveInfo("C") ' Altere a letra do disco conforme necessário

        ' Exibir informações do disco
        LabelNomeDisco.Text = $"Nome do Disco: {GetDiskDriveName()}"
        LabelTipoDisco.Text = $"Tipo de Disco: {GetDriveType()}"
        LabelTamanhoTotal.Text = $"Tamanho Total: {FormatBytes(drive.TotalSize)}"
        LabelEspacoLivre.Text = $"Espaço Livre: {FormatBytes(drive.TotalFreeSpace)}"
        LabelEspacoOcupado.Text = $"Espaço Ocupado: {FormatBytes(drive.TotalSize - drive.TotalFreeSpace)}"
        LabelSistemaArquivos.Text = $"Sistema de Arquivos: {drive.DriveFormat}"
        ' Configurar ProgressBar do disco
        ProgressBarDisco.Minimum = 0
        ProgressBarDisco.Maximum = 100
        ProgressBarDisco.Value = GetDiskUsagePercentage()

        ' Começa a leitura do smart do disco



    End Sub


    Private Function GetDiskUsagePercentage() As Integer
        Dim drive As DriveInfo = New DriveInfo("C") ' Altere a letra do disco conforme necessário
        Dim totalSize As Long = drive.TotalSize
        Dim usedSpace As Long = totalSize - drive.AvailableFreeSpace
        Dim usagePercentage As Integer = CInt((usedSpace * 100) / totalSize)
        Return usagePercentage
    End Function
    Public Class SmartAttribute
        Public Property ID As Integer
        Public Property Name As String
        Public Property Value As String
        Public Property Threshold As String
        Public Property RAWValue As String
    End Class
    Private Sub UpdateDiskInformation()
        Dim drive As DriveInfo = New DriveInfo("C") ' Altere a letra do disco conforme necessário
        Dim drive2 As String = "C:"
        Dim diskInfo As String = ""

        LabelNomeDisco.Text = $"Disco: {drive.VolumeLabel}"
        LabelTipoDisco.Text = $"Tipo: {GetDriveType()}"
        LabelTamanhoTotal.Text = $"Tamanho Total: {FormatBytes(drive.TotalSize)}"
        LabelEspacoLivre.Text = $"Espaço Livre: {FormatBytes(drive.AvailableFreeSpace)}"
        LabelEspacoOcupado.Text = $"Espaço Ocupado: {FormatBytes(drive.TotalSize - drive.AvailableFreeSpace)}"

        ProgressBarDisco.Value = GetDiskUsagePercentage()

        For Each hardware As IHardware In computer.Hardware
            If hardware.HardwareType = HardwareType.HDD OrElse hardware.HardwareType = HardwareType.HDD Then
                For Each sensor As ISensor In hardware.Sensors
                    If sensor.SensorType = SensorType.Data AndAlso sensor.Name.Contains(drive2) Then
                        diskInfo = sensor.Name
                        Exit For
                    End If
                Next
                Exit For
            End If
        Next

        LabelDiskInfo.Text = "Informações do Disco: " & diskInfo

    End Sub






    Private Function GetDriveType() As String
        Dim driveType As String = "Desconhecido"
        Dim query As String = "SELECT MediaType FROM Win32_PhysicalMedia"

        Dim searcher As New ManagementObjectSearcher(query)

        For Each obj As ManagementObject In searcher.Get()
            If obj("MediaType") IsNot Nothing Then
                Dim mediaType As String = obj("MediaType").ToString()

                If mediaType = "Fixed hard disk media" Then
                    driveType = "HD"
                ElseIf mediaType = "Removable media other than floppy" Then
                    driveType = "Removível"
                End If
            End If
        Next

        Return driveType
    End Function

    Private Function GetDiskDriveName() As String
        Dim query As String = "SELECT * FROM Win32_DiskDrive WHERE MediaType = 'Fixed hard disk media'"
        Dim searcher As New ManagementObjectSearcher(query)

        For Each obj As ManagementObject In searcher.Get()
            Return obj("Model").ToString()
        Next

        Return "Desconhecido"
    End Function

    Private Function FormatBytes(bytes As Long) As String
        Dim units() As String = {"B", "KB", "MB", "GB", "TB"}
        Dim index As Integer = 0

        While bytes >= 1024 AndAlso index < units.Length - 1
            bytes /= 1024
            index += 1
        End While

        Return $"{bytes:0.##} {units(index)}"
    End Function
End Class
