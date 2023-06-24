Imports System.Management
Imports System.Diagnostics

Public Class Form2
    Private cpuCounter As New PerformanceCounter("Processor", "% Processor Time", "_Total")
    Private coreCount As Integer = Environment.ProcessorCount
    Private coreCounters As PerformanceCounter() = New PerformanceCounter(coreCount - 1) {}

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar os contadores de desempenho para cada núcleo
        For core As Integer = 0 To coreCount - 1
            coreCounters(core) = New PerformanceCounter("Processor", "% Processor Time", core.ToString())
        Next

        ' Iniciar o timer para atualização periódica
        Timer1.Interval = 1000 ' 1 segundo
        Timer1.Start()
        ' Associe o ImageList1 ao ListView
        ListView1.SmallImageList = ImageList1

        ' Configura o ListView para exibição em formato de tabela
        ListView1.View = View.Details

        ' Adiciona as colunas correspondentes às propriedades exibidas
        ListView1.Columns.Add("Campo", 200)
        ListView1.Columns.Add("Valor", 300)

        Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_Processor")
        Dim collection As ManagementObjectCollection = searcher.Get()

        For Each processor As ManagementObject In collection
            Dim processorName As String = processor("Name").ToString()
            Dim processorDescription As String = processor("Description").ToString()
            Dim processorManufacturer As String = processor("Manufacturer").ToString()
            Dim processorArchitecture As String = processor("Architecture").ToString()
            Dim processorFamily As String = processor("Family").ToString()
            Dim processorNumberOfCores As Integer = Convert.ToInt32(processor("NumberOfCores"))
            Dim processorNumberOfLogicalProcessors As Integer = Convert.ToInt32(processor("NumberOfLogicalProcessors"))
            Dim processorMaxClockSpeed As UInt32 = Convert.ToUInt32(processor("MaxClockSpeed"))
            Dim processorCurrentClockSpeed As UInt32 = Convert.ToUInt32(processor("CurrentClockSpeed"))
            Dim processorL2CacheSize As UInt32 = Convert.ToUInt32(processor("L2CacheSize"))
            Dim processorL3CacheSize As UInt32 = Convert.ToUInt32(processor("L3CacheSize"))

            ' Cria um novo item para cada propriedade e adiciona ao ListView
            Dim item As New ListViewItem("Descrição", 0) ' Ícone para campo 1
            item.SubItems.Add(processorDescription)
            ListView1.Items.Add(item)

            item = New ListViewItem("Fabricante", 1) ' Ícone para campo 2
            item.SubItems.Add(processorManufacturer)
            ListView1.Items.Add(item)

            item = New ListViewItem("Arquitetura", 2) ' Ícone para campo 3
            item.SubItems.Add(processorArchitecture)
            ListView1.Items.Add(item)

            item = New ListViewItem("Família", 3) ' Ícone para campo 4
            item.SubItems.Add(processorFamily)
            ListView1.Items.Add(item)

            item = New ListViewItem("Número de Núcleos", 4) ' Ícone para campo 5
            item.SubItems.Add(processorNumberOfCores.ToString())
            ListView1.Items.Add(item)

            item = New ListViewItem("Número de Processadores Lógicos", 5) ' Ícone para campo 6
            item.SubItems.Add(processorNumberOfLogicalProcessors.ToString())
            ListView1.Items.Add(item)

            item = New ListViewItem("Velocidade Máxima", 6) ' Ícone para campo 7
            item.SubItems.Add(processorMaxClockSpeed.ToString() & " MHz")
            ListView1.Items.Add(item)

            item = New ListViewItem("Velocidade Atual", 7) ' Ícone para campo 8
            item.SubItems.Add(processorCurrentClockSpeed.ToString() & " MHz")
            ListView1.Items.Add(item)

            item = New ListViewItem("Tamanho do Cache L2", 8) ' Ícone para campo 9
            item.SubItems.Add(processorL2CacheSize.ToString() & " KB")
            ListView1.Items.Add(item)

            item = New ListViewItem("Tamanho do Cache L3", 9) ' Ícone para campo 10
            item.SubItems.Add(processorL3CacheSize.ToString() & " KB")
            ListView1.Items.Add(item)

            ' Exibe o nome do processador no Label1
            Label1.Text = processorName
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Obter a utilização do processador total
        Dim cpuUsage As Single = cpuCounter.NextValue()

        ' Atualizar o ListBox com a utilização do processador total
        ListBox1.Items.Clear()
        ListBox1.Items.Add($"CPU Usage: {cpuUsage}%")

        ' Obter a utilização de cada núcleo do processador
        For core As Integer = 0 To coreCount - 1
            Dim coreUsage As Single = coreCounters(core).NextValue()

            ' Atualizar o ListBox com a utilização de cada núcleo do processador
            ListBox1.Items.Add($"Core {core}: {coreUsage}%")
        Next
    End Sub
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Parar o timer e liberar os recursos dos contadores de desempenho
        Timer1.Stop()
        cpuCounter.Dispose()

        For core As Integer = 0 To coreCount - 1
            coreCounters(core).Dispose()
        Next
    End Sub

End Class
