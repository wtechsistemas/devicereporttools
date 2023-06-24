Imports System.IO
Imports System.Diagnostics

Public Class Form6

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Preencher ComboBox com os discos removíveis disponíveis
        For Each drive As DriveInfo In DriveInfo.GetDrives()
            If drive.DriveType = DriveType.Removable Then
                ComboBoxRemovableDrives.Items.Add(drive)
            End If
        Next
    End Sub

    Private Sub ComboBoxRemovableDrives_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRemovableDrives.SelectedIndexChanged
        ' Verificar se um disco removível está selecionado
        If ComboBoxRemovableDrives.SelectedItem IsNot Nothing Then
            ' Obter o disco selecionado na ComboBox
            Dim selectedDrive As DriveInfo = DirectCast(ComboBoxRemovableDrives.SelectedItem, DriveInfo)

            ' Preencher TextBoxNomeDisco com o nome do volume do disco selecionado
            TextBoxNomeDisco.Text = selectedDrive.VolumeLabel

            ' Preencher ComboBoxComboFS com o sistema de arquivos atual do disco selecionado
            ComboBoxComboFS.Text = selectedDrive.DriveFormat
        End If
    End Sub

    Private Sub ButtonFormatar_Click(sender As Object, e As EventArgs) Handles ButtonFormatar.Click
        ' Verificar se um disco removível está selecionado
        If ComboBoxRemovableDrives.SelectedItem IsNot Nothing Then
            ' Obter o disco selecionado na ComboBox
            Dim selectedDrive As DriveInfo = DirectCast(ComboBoxRemovableDrives.SelectedItem, DriveInfo)

            ' Obter o sistema de arquivos selecionado na ComboBoxComboFS
            Dim selectedFileSystem As String = ComboBoxComboFS.Text

            ' Confirmar a formatação com o usuário
            Dim confirmationMessage As String = String.Format("Formatando o disco {0} com a capacidade de {1} GB, sistema de arquivos {2}. Deseja formatar?", selectedDrive.Name, selectedDrive.TotalSize \ (1024 * 1024 * 1024), selectedFileSystem)
            Dim result As DialogResult = MessageBox.Show(confirmationMessage, "Confirmação de Formatação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Executar o utilitário de formatação do sistema operacional
                Dim processStartInfo As New ProcessStartInfo()
                processStartInfo.FileName = "format.com"
                processStartInfo.Arguments = String.Format("/FS:{0} {1}", selectedFileSystem, selectedDrive.Name)
                processStartInfo.CreateNoWindow = True
                processStartInfo.RedirectStandardOutput = True
                processStartInfo.UseShellExecute = False

                ' Criar o processo para executar o utilitário de formatação
                Dim process As Process = Process.Start(processStartInfo)

                ' Exibir a janela de progresso
                Dim progressBar As New ProgressBar()
                progressBar.Minimum = 0
                progressBar.Maximum = 100
                progressBar.Dock = DockStyle.Top
                Controls.Add(progressBar)

                ' Ler a saída padrão do processo para atualizar a progressbar
                While Not process.StandardOutput.EndOfStream
                    Dim outputLine As String = process.StandardOutput.ReadLine()

                    ' Verificar se a linha contém o progresso da formatação
                    If outputLine.StartsWith("Percent") Then
                        Dim percentValue As Integer = CInt(outputLine.Substring(outputLine.LastIndexOf(" ") + 1))
                        progressBar.Value = percentValue
                    End If
                End While

                ' Aguardar a finalização do processo
                process.WaitForExit()

                ' Remover a ProgressBar do formulário
                Controls.Remove(progressBar)
            End If
        End If
    End Sub

End Class
