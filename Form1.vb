Imports System.Management
Imports System.IO
Imports System.Text

Public Class Form1
    Private imageList As New ImageList()

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        SetupImageList()
        LoadHardwareDevices()
        LoadCategories()

    End Sub

    Private Sub SetupImageList()

        TreeView1.ImageList = ImageList1
    End Sub

    Private Sub LoadHardwareDevices()
        TreeView1.Nodes.Clear()

        Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity")
        Dim collection As ManagementObjectCollection = searcher.Get()

        For Each device As ManagementObject In collection
            Dim deviceName As String = CType(device("Name"), String)
            Dim deviceClass As String = CType(device("PNPClass"), String)

            Dim parentNode As TreeNode = FindOrCreateNode(TreeView1.Nodes, deviceClass, 0) ' Categoria
            parentNode.Nodes.Add(deviceName, deviceName, 1) ' Dispositivo
        Next
    End Sub

    Private Function FindOrCreateNode(ByVal nodes As TreeNodeCollection, ByVal nodeName As String, ByVal imageIndex As Integer) As TreeNode
        For Each node As TreeNode In nodes
            If node.Text = nodeName Then
                Return node
            End If
        Next

        Dim newNode As New TreeNode(nodeName)
        newNode.ImageIndex = imageIndex
        newNode.SelectedImageIndex = imageIndex
        nodes.Add(newNode)
        Return newNode
    End Function

    Private Sub LoadCategories()
        Dim categories As New List(Of String)()
        categories.Add("Todas as Categorias") ' Adiciona a opção "Todas as Categorias" no início

        For Each node As TreeNode In TreeView1.Nodes
            categories.Add(node.Text)
        Next

        ComboBox1.DataSource = categories
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedCategory As String = ComboBox1.SelectedItem.ToString()

        If selectedCategory = "Todas as Categorias" Then
            LoadHardwareDevices()
        Else
            FilterHardwareDevicesByCategory(selectedCategory)
        End If
    End Sub

    Private Sub FilterHardwareDevicesByCategory(ByVal category As String)
        TreeView1.Nodes.Clear()

        Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity")
        Dim collection As ManagementObjectCollection = searcher.Get()

        For Each device As ManagementObject In collection
            Dim deviceName As String = CType(device("Name"), String)
            Dim deviceClass As String = CType(device("PNPClass"), String)

            If deviceClass = category Then
                Dim parentNode As TreeNode = FindOrCreateNode(TreeView1.Nodes, deviceClass, 0) ' Categoria
                parentNode.Nodes.Add(deviceName, deviceName, 1) ' Dispositivo
            End If
        Next
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If e.Node.Level = 1 Then ' Somente dispositivos
            Dim deviceName As String = e.Node.Text
            Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Name = '" & deviceName & "'")
            Dim collection As ManagementObjectCollection = searcher.Get()

            If collection.Count > 0 Then
                Dim device As ManagementObject = collection(0)
                Dim properties As PropertyDataCollection = device.Properties

                ListView1.Items.Clear()

                For Each [property] As PropertyData In properties
                    Dim propertyName As String = [property].Name
                    Dim propertyValue As String = [property].Value?.ToString()

                    Dim iconIndex As Integer = 2 ' Índice do ícone desejado no ImageList
                    Dim item As New ListViewItem(propertyName, iconIndex)
                    item.SubItems.Add(propertyValue)

                    ListView1.Items.Add(item)
                Next

                Dim caption As String = device("Caption").ToString()
                Label1.Text = caption
            End If
        End If
    End Sub



    Private Sub btnExportDevice_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportDevice.Click
        ExportListViewToHtml(ListView1)
    End Sub

    Private Sub btnExportDeviceList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportDeviceList.Click
        If TreeView1.Nodes.Count > 0 Then
            ExportDeviceListToFile(TreeView1.Nodes)
        Else
            MessageBox.Show("Nenhum dispositivo encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ExportDeviceDataToFile(ByVal items As ListBox.ObjectCollection)
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Arquivo HTML (*.html)|*.html"
        saveDialog.Title = "Exportar Dados do Dispositivo"
        saveDialog.DefaultExt = "html"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveDialog.FileName

            Dim htmlContent As New StringBuilder()
            htmlContent.AppendLine("<html>")
            htmlContent.AppendLine($"<link href='https://getbootstrap.com/docs/4.3/dist/css/bootstrap.min.css' rel='stylesheet' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>")

            htmlContent.AppendLine("<head>")
            htmlContent.AppendLine("<title>Dados do Dispositivo</title>")
            htmlContent.AppendLine("</head>")
            htmlContent.AppendLine("<body>")

            For Each item As String In items
                htmlContent.AppendLine("<p>" & item & "</p>")
            Next

            htmlContent.AppendLine("</body>")
            htmlContent.AppendLine("</html>")

            File.WriteAllText(filePath, htmlContent.ToString())

            MessageBox.Show("Dados do dispositivo exportados com sucesso.", "Exportação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ExportDeviceListToFile(ByVal nodes As TreeNodeCollection)
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Arquivo HTML (*.html)|*.html"
        saveDialog.Title = "Exportar Lista de Dispositivos"
        saveDialog.DefaultExt = "html"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveDialog.FileName

            Dim htmlContent As New StringBuilder()
            htmlContent.AppendLine("<html>")
            htmlContent.AppendLine("<head>")
            htmlContent.AppendLine("<title>Lista de Dispositivos</title>")
            htmlContent.AppendLine($"<link href='https://getbootstrap.com/docs/4.3/dist/css/bootstrap.min.css' rel='stylesheet' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>")

            htmlContent.AppendLine("</head>")
            htmlContent.AppendLine("<body>")

            For Each node As TreeNode In nodes
                htmlContent.AppendLine("<h2>" & node.Text & "</h2>")
                htmlContent.AppendLine("<ul>")

                For Each subNode As TreeNode In node.Nodes
                    htmlContent.AppendLine("<li>" & subNode.Text & "</li>")
                Next

                htmlContent.AppendLine("</ul>")
            Next

            htmlContent.AppendLine("</body>")
            htmlContent.AppendLine("</html>")

            File.WriteAllText(filePath, htmlContent.ToString())

            MessageBox.Show("Lista de dispositivos exportada com sucesso.", "Exportação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ExportListViewToHtml(ByVal listView As ListView)
        If listView.Items.Count > 0 Then
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Arquivo HTML (*.html)|*.html"
            saveDialog.Title = "Exportar Dados do ListView"
            saveDialog.DefaultExt = "html"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = saveDialog.FileName

                Dim htmlContent As New StringBuilder()
                htmlContent.AppendLine("<html>")
                htmlContent.AppendLine($"<link href='https://getbootstrap.com/docs/4.3/dist/css/bootstrap.min.css' rel='stylesheet' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>")
                htmlContent.AppendLine("<head>")
                htmlContent.AppendLine("<title>Dados do ListView</title>")
                htmlContent.AppendLine("</head>")
                htmlContent.AppendLine("<body>")
                htmlContent.AppendLine("<table>")

                ' Cabeçalhos das colunas
                htmlContent.AppendLine("<tr>")
                For Each column As ColumnHeader In listView.Columns
                    htmlContent.AppendLine("<th>" & column.Text & "</th>")
                Next
                htmlContent.AppendLine("</tr>")

                ' Dados das linhas
                For Each item As ListViewItem In listView.Items
                    htmlContent.AppendLine("<tr>")
                    For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                        htmlContent.AppendLine("<td>" & subItem.Text & "</td>")
                    Next
                    htmlContent.AppendLine("</tr>")
                Next

                htmlContent.AppendLine("</table>")
                htmlContent.AppendLine("</body>")
                htmlContent.AppendLine("</html>")

                File.WriteAllText(filePath, htmlContent.ToString())

                MessageBox.Show("Dados do ListView exportados com sucesso.", "Exportação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Nenhum dado no ListView para exportar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub CpuInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CpuInfoToolStripMenuItem.Click
        Form2.Show()

    End Sub

    Private Sub InformaçõesDaMemoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaçõesDaMemoriaToolStripMenuItem.Click
        Form3.Show()

    End Sub

    Private Sub InformaçõesDeDiscoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaçõesDeDiscoToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub InformaçõesDaBateriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaçõesDaBateriaToolStripMenuItem.Click
        Form5.Show()

    End Sub

    Private Sub UtilitárioDeFormataçãoDeDiscoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UtilitárioDeFormataçãoDeDiscoToolStripMenuItem.Click
        Form6.Show()

    End Sub
End Class
