<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        ComboBoxRemovableDrives = New ComboBox()
        LabelCapacidade = New Label()
        TextBoxNomeDisco = New TextBox()
        ComboBoxComboFS = New ComboBox()
        ButtonFormatar = New Button()
        ProgressBar1 = New ProgressBar()
        SuspendLayout()
        ' 
        ' ComboBoxRemovableDrives
        ' 
        ComboBoxRemovableDrives.FormattingEnabled = True
        ComboBoxRemovableDrives.Location = New Point(15, 28)
        ComboBoxRemovableDrives.Name = "ComboBoxRemovableDrives"
        ComboBoxRemovableDrives.Size = New Size(163, 23)
        ComboBoxRemovableDrives.TabIndex = 0
        ' 
        ' LabelCapacidade
        ' 
        LabelCapacidade.AutoSize = True
        LabelCapacidade.Location = New Point(15, 77)
        LabelCapacidade.Name = "LabelCapacidade"
        LabelCapacidade.Size = New Size(41, 15)
        LabelCapacidade.TabIndex = 1
        LabelCapacidade.Text = "Label1"
        ' 
        ' TextBoxNomeDisco
        ' 
        TextBoxNomeDisco.Location = New Point(15, 110)
        TextBoxNomeDisco.Name = "TextBoxNomeDisco"
        TextBoxNomeDisco.Size = New Size(163, 23)
        TextBoxNomeDisco.TabIndex = 2
        ' 
        ' ComboBoxComboFS
        ' 
        ComboBoxComboFS.FormattingEnabled = True
        ComboBoxComboFS.Location = New Point(15, 151)
        ComboBoxComboFS.Name = "ComboBoxComboFS"
        ComboBoxComboFS.Size = New Size(163, 23)
        ComboBoxComboFS.TabIndex = 3
        ' 
        ' ButtonFormatar
        ' 
        ButtonFormatar.Location = New Point(12, 253)
        ButtonFormatar.Name = "ButtonFormatar"
        ButtonFormatar.Size = New Size(82, 30)
        ButtonFormatar.TabIndex = 4
        ButtonFormatar.Text = "Formatar"
        ButtonFormatar.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(16, 207)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(162, 23)
        ProgressBar1.TabIndex = 5
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ProgressBar1)
        Controls.Add(ButtonFormatar)
        Controls.Add(ComboBoxComboFS)
        Controls.Add(TextBoxNomeDisco)
        Controls.Add(LabelCapacidade)
        Controls.Add(ComboBoxRemovableDrives)
        Name = "Form6"
        Text = "Form6"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBoxRemovableDrives As ComboBox
    Friend WithEvents LabelCapacidade As Label
    Friend WithEvents TextBoxNomeDisco As TextBox
    Friend WithEvents ComboBoxComboFS As ComboBox
    Friend WithEvents ButtonFormatar As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
