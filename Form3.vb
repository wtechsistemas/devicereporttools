Imports System.Management
Imports Microsoft.VisualBasic.Devices
Imports System.IO
Imports System.Text


Public Class Form3
    Private processInfoList As New Dictionary(Of Integer, String)()
    Private computerInfo As New ComputerInfo()
    Private timer As New Timer()


    Private Sub ExportarParaHTML()
        ' Criar um StringBuilder para construir a estrutura HTML da tabela
        Dim htmlBuilder As New StringBuilder()

        ' Adicionar a data e hora atual ao início do arquivo
        htmlBuilder.AppendLine($"<link href='https://getbootstrap.com/docs/4.3/dist/css/bootstrap.min.css' rel='stylesheet' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>")
        htmlBuilder.AppendLine($"<p>Data e hora de geração do arquivo: {DateTime.Now}</p>")

        ' Exportar informações dos labels
        htmlBuilder.AppendLine("<h2>Informações Gerais</h2>")
        htmlBuilder.AppendLine("<table>")
        htmlBuilder.AppendLine("<tr><th>Título</th><th>Valor</th></tr>")
        htmlBuilder.AppendLine($"<tr><td>Total</td><td>{LabelTotal.Text}</td></tr>")
        htmlBuilder.AppendLine($"<tr><td>Utilizada</td><td>{LabelUtilizada.Text}</td></tr>")
        htmlBuilder.AppendLine($"<tr><td>Livre</td><td>{LabelLivre.Text}</td></tr>")
        htmlBuilder.AppendLine("</table>")

        ' Exportar informações do ListView de Memória
        htmlBuilder.AppendLine("<h2>Informações da Memória</h2>")
        htmlBuilder.AppendLine("<table>")
        htmlBuilder.AppendLine("<tr><th>Fabricante</th><th>Capacidade</th><th>Velocidade (MHz)</th><th>Tipo</th><th>Número de Série</th></tr>")
        For Each item As ListViewItem In ListViewMemory.Items
            htmlBuilder.AppendLine($"<tr><td>{item.SubItems(0).Text}</td><td>{item.SubItems(1).Text}</td><td>{item.SubItems(2).Text}</td><td>{item.SubItems(3).Text}</td><td>{item.SubItems(4).Text}</td></tr>")
        Next
        htmlBuilder.AppendLine("</table>")

        ' Exportar informações do ListView de Processos
        htmlBuilder.AppendLine("<h2>Informações dos Processos</h2>")
        htmlBuilder.AppendLine("<table>")
        htmlBuilder.AppendLine("<tr><th>Nome do Processo</th><th>Uso de Memória</th></tr>")
        For Each item As ListViewItem In ListViewProcessos.Items
            htmlBuilder.AppendLine($"<tr><td>{item.Text}</td><td>{item.SubItems(1).Text}</td></tr>")
        Next
        htmlBuilder.AppendLine("</table>")

        ' Exibir diálogo de salvamento de arquivo
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Arquivos HTML (*.html)|*.html"
        saveDialog.Title = "Salvar Relatório HTML"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            ' Salvar o conteúdo em um arquivo HTML
            Dim filePath As String = saveDialog.FileName
            Using writer As New StreamWriter(filePath)
                writer.Write(htmlBuilder.ToString())
            End Using

            MessageBox.Show("Relatório HTML exportado com sucesso.", "Exportar para HTML", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer.Interval = 1000 ' Definir intervalo do timer em milissegundos
        AddHandler timer.Tick, AddressOf Timer_Tick ' Adicionar evento ao tick do timer

        ' Configurar rótulos e ProgressBar
        UpdateMemoryInformation()

        LabelLivre.Text = "Livre: " & FormatBytes(computerInfo.AvailablePhysicalMemory)
        ProgressBarMemoria.Maximum = 100 ' Definir o máximo como 100 (porcentagem)

        timer.Start() ' Iniciar o timer
        ListViewProcessos.View = View.Details
        ListViewProcessos.Columns.Add("Nome do Processo", 200)
        ListViewProcessos.Columns.Add("Uso de Memória", 150)
        Timerprocessos.Enabled = True
        For Each process As Process In Process.GetProcesses()
            processInfoList.Add(process.Id, FormatBytes(process.WorkingSet64))

        Next

        Dim processList As Process() = Process.GetProcesses()

        ListViewProcessos.Items.Clear()

        'For Each process As Process In processList
        'Dim processName As String = process.ProcessName
        'Dim memoryUsage As String = FormatBytes(process.WorkingSet64)
        '
        'Dim item As New ListViewItem(processName)
        'item.SubItems.Add(memoryUsage)

        'ListViewProcessos.Items.Add(item)
        'Next
        'For Each process As Process In processList
        'Dim processName As String = process.ProcessName
        'Dim memoryUsage As String = FormatBytes(process.WorkingSet64)
        '
        'Dim item As New ListViewItem(processName)
        'item.SubItems.Add(memoryUsage)

        'item.Tag = process.Id ' Configurar o ID do processo como valor da propriedade Tag

        'ListViewProcessos.Items.Add(item)
        'Next
        For Each process As Process In processList
            Dim processName As String = process.ProcessName
            Dim memoryUsage As String = FormatBytes(process.WorkingSet64)

            Dim item As New ListViewItem(processName)
            item.SubItems.Add(memoryUsage)

            item.Tag = process ' Configurar o objeto Process como valor da propriedade Tag

            ListViewProcessos.Items.Add(item)
        Next

    End Sub


    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        ' Calcular a porcentagem de memória utilizada
        Dim memoriaTotal As Long = computerInfo.TotalPhysicalMemory
        Dim memoriaUtilizada As Long = memoriaTotal - computerInfo.AvailablePhysicalMemory
        Dim porcentagemUtilizada As Integer = CInt((memoriaUtilizada * 100) / memoriaTotal)

        ' Atualizar as informações a cada tick do timer
        LabelUtilizada.Text = "Utilizada: " & FormatBytes(memoriaUtilizada)
        ProgressBarMemoria.Value = porcentagemUtilizada

        ' Alterar a cor do LabelUtilizada com base na porcentagem de memória utilizada
        If porcentagemUtilizada > 80 Then
            LabelUtilizada.ForeColor = Color.Red
        ElseIf porcentagemUtilizada > 60 Then
            LabelUtilizada.ForeColor = Color.Orange
        Else
            LabelUtilizada.ForeColor = Color.Black
        End If

    End Sub

    Private Sub UpdateMemoryInformation()
        ' Obter informações sobre os módulos de memória física
        Dim query As String = "SELECT * FROM Win32_PhysicalMemory"
        Dim searcher As New ManagementObjectSearcher(query)

        ListViewMemory.Items.Clear()
        ListViewMemory.View = View.Details ' Definir o modo de exibição do ListView como detalhes
        ListViewMemory.Columns.Clear() ' Limpar as colunas existentes

        ' Adicionar as colunas ao ListView
        ListViewMemory.Columns.Add("Fabricante", 150)
        ListViewMemory.Columns.Add("Capacidade", 100)
        ListViewMemory.Columns.Add("Velocidade (MHz)", 100)
        ListViewMemory.Columns.Add("Tipo", 100)
        ListViewMemory.Columns.Add("Número de Série", 150)

        For Each obj As ManagementObject In searcher.Get()
            Dim manufacturer As String = obj("Manufacturer").ToString()
            Dim capacity As ULong = Convert.ToUInt64(obj("Capacity"))
            Dim speed As UInteger = Convert.ToUInt32(obj("Speed"))
            Dim memoryType As String = GetMemoryType(obj("MemoryType"))
            Dim serialNumber As String = obj("SerialNumber").ToString()

            Dim item As New ListViewItem(manufacturer)
            item.SubItems.Add(FormatBytes(capacity))
            item.SubItems.Add(speed.ToString())
            item.SubItems.Add(memoryType)
            item.SubItems.Add(serialNumber)

            ListViewMemory.Items.Add(item)
        Next

        Dim ramType As String = GetMemoryType()
        Dim totalMemory As Long = computerInfo.TotalPhysicalMemory
        Dim formattedTotalMemory As String = FormatBytes(totalMemory)

        LabelTotal.Text = $"Total de RAM ({ramType}): {formattedTotalMemory}"
    End Sub

    Private Function GetMemoryType() As String
        Dim query As String = "SELECT * FROM Win32_PhysicalMemory"
        Dim searcher As New ManagementObjectSearcher(query)

        For Each obj As ManagementObject In searcher.Get()
            If obj("MemoryType") IsNot Nothing Then
                Dim memoryType As Integer = CInt(obj("MemoryType"))

                Select Case memoryType
                    Case 20
                        Return "DDR"
                    Case 21
                        Return "DDR2"
                    Case 24
                        Return "DDR3"
                    Case 26
                        Return "DDR4"
                    Case 29
                        Return "DDR5"
                    Case Else
                        Return "Unknown"
                End Select
            End If
        Next

        Return "Unknown"
    End Function


    Private Function GetMemoryType(typeCode As Integer) As String
        Select Case typeCode
            Case 20
                Return "DDR"
            Case 21
                Return "DDR2"
            Case 24
                Return "DDR3"
            Case 26
                Return "DDR4"
            Case 29
                Return "DDR5"
            Case Else
                Return "Unknown"
        End Select
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

    Private Sub Timerprocessos_Tick(sender As Object, e As EventArgs) Handles Timerprocessos.Tick
        Dim processList As Process() = Process.GetProcesses()

        For Each process As Process In processList
            Dim processId As Integer = process.Id

            If processInfoList.ContainsKey(processId) Then
                Dim previousMemoryUsage As String = processInfoList(processId)
                Dim currentMemoryUsage As String = FormatBytes(process.WorkingSet64)

                ' Verificar se houve alteração no uso de memória do processo
                If previousMemoryUsage <> currentMemoryUsage Then
                    ' Atualizar somente o campo "Uso de Memória" do item modificado
                    For Each item As ListViewItem In ListViewProcessos.Items
                        If item.Text = process.ProcessName Then
                            item.SubItems(1).Text = currentMemoryUsage
                            Exit For
                        End If
                    Next

                    ' Atualizar o valor na variável processInfoList
                    processInfoList(processId) = currentMemoryUsage
                End If
            Else
                ' Adicionar novo processo à variável processInfoList
                processInfoList.Add(processId, FormatBytes(process.WorkingSet64))

                ' Adicionar novo item ao ListView
                Dim item As New ListViewItem(process.ProcessName)
                item.SubItems.Add(FormatBytes(process.WorkingSet64))

                ListViewProcessos.Items.Add(item)
            End If
        Next

        ' Remover processos encerrados do ListView e da variável processInfoList
        For Each item As ListViewItem In ListViewProcessos.Items
            Dim processName As String = item.Text
            Dim processId As Integer = Process.GetProcessesByName(processName).FirstOrDefault()?.Id

            If Not processInfoList.ContainsKey(processId) Then
                ListViewProcessos.Items.Remove(item)
            End If
        Next

    End Sub

    Private Sub ButtonEncerrarProcesso_Click(sender As Object, e As EventArgs) Handles ButtonEncerrarProcesso.Click
        If ListViewProcessos.SelectedItems.Count > 0 Then
            Dim selectedProcessItem As ListViewItem = ListViewProcessos.SelectedItems(0)
            Dim selectedProcess As Process = DirectCast(selectedProcessItem.Tag, Process)

            Dim confirmationMessage As String = $"Você está prestes a encerrar o processo '{selectedProcess.ProcessName}'. Isso pode deixar o sistema instável. Deseja continuar?"
            Dim confirmationResult As DialogResult = MessageBox.Show(confirmationMessage, "Confirmação de Encerramento de Processo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If confirmationResult = DialogResult.Yes Then
                Try
                    selectedProcess.Kill()
                    MessageBox.Show("O processo foi encerrado com sucesso.", "Processo Encerrado", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ListViewProcessos.Items.Remove(selectedProcessItem)
                Catch ex As Exception
                    MessageBox.Show("Ocorreu um erro ao tentar encerrar o processo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Selecione um processo na lista.", "Processo não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonExecutarProcesso_Click(sender As Object, e As EventArgs) Handles ButtonExecutarProcesso.Click
        Dim nomeExecutavel As String = InputBox("Digite o nome do executável a ser iniciado:", "Executar Processo")

        If Not String.IsNullOrWhiteSpace(nomeExecutavel) Then
            Try
                Dim process As Process = Process.Start(nomeExecutavel)
                processInfoList.Add(process.Id, FormatBytes(process.WorkingSet64))

                Dim item As New ListViewItem(process.ProcessName)
                item.SubItems.Add(FormatBytes(process.WorkingSet64))
                item.Tag = process

                ListViewProcessos.Items.Add(item)
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro ao tentar iniciar o processo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ExportarParaHTML()
    End Sub
End Class
