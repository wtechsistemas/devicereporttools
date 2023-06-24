<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        LabelNomeDisco = New Label()
        LabelTipoDisco = New Label()
        LabelTamanhoTotal = New Label()
        LabelEspacoLivre = New Label()
        LabelEspacoOcupado = New Label()
        LabelSistemaArquivos = New Label()
        ProgressBarDisco = New ProgressBar()
        Labeldiskinfo = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' LabelNomeDisco
        ' 
        LabelNomeDisco.AutoSize = True
        LabelNomeDisco.Location = New Point(20, 24)
        LabelNomeDisco.Name = "LabelNomeDisco"
        LabelNomeDisco.Size = New Size(41, 15)
        LabelNomeDisco.TabIndex = 0
        LabelNomeDisco.Text = "Label1"
        ' 
        ' LabelTipoDisco
        ' 
        LabelTipoDisco.AutoSize = True
        LabelTipoDisco.Location = New Point(20, 49)
        LabelTipoDisco.Name = "LabelTipoDisco"
        LabelTipoDisco.Size = New Size(41, 15)
        LabelTipoDisco.TabIndex = 1
        LabelTipoDisco.Text = "Label2"
        ' 
        ' LabelTamanhoTotal
        ' 
        LabelTamanhoTotal.AutoSize = True
        LabelTamanhoTotal.Location = New Point(20, 74)
        LabelTamanhoTotal.Name = "LabelTamanhoTotal"
        LabelTamanhoTotal.Size = New Size(41, 15)
        LabelTamanhoTotal.TabIndex = 2
        LabelTamanhoTotal.Text = "Label3"
        ' 
        ' LabelEspacoLivre
        ' 
        LabelEspacoLivre.AutoSize = True
        LabelEspacoLivre.Location = New Point(20, 99)
        LabelEspacoLivre.Name = "LabelEspacoLivre"
        LabelEspacoLivre.Size = New Size(41, 15)
        LabelEspacoLivre.TabIndex = 3
        LabelEspacoLivre.Text = "Label4"
        ' 
        ' LabelEspacoOcupado
        ' 
        LabelEspacoOcupado.AutoSize = True
        LabelEspacoOcupado.Location = New Point(20, 125)
        LabelEspacoOcupado.Name = "LabelEspacoOcupado"
        LabelEspacoOcupado.Size = New Size(41, 15)
        LabelEspacoOcupado.TabIndex = 4
        LabelEspacoOcupado.Text = "Label5"
        ' 
        ' LabelSistemaArquivos
        ' 
        LabelSistemaArquivos.AutoSize = True
        LabelSistemaArquivos.Location = New Point(20, 152)
        LabelSistemaArquivos.Name = "LabelSistemaArquivos"
        LabelSistemaArquivos.Size = New Size(41, 15)
        LabelSistemaArquivos.TabIndex = 5
        LabelSistemaArquivos.Text = "Label6"
        ' 
        ' ProgressBarDisco
        ' 
        ProgressBarDisco.Location = New Point(20, 181)
        ProgressBarDisco.Name = "ProgressBarDisco"
        ProgressBarDisco.Size = New Size(186, 23)
        ProgressBarDisco.TabIndex = 6
        ' 
        ' Labeldiskinfo
        ' 
        Labeldiskinfo.AutoSize = True
        Labeldiskinfo.Location = New Point(51, 337)
        Labeldiskinfo.Name = "Labeldiskinfo"
        Labeldiskinfo.Size = New Size(41, 15)
        Labeldiskinfo.TabIndex = 8
        Labeldiskinfo.Text = "Label1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 232)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 15)
        Label1.TabIndex = 9
        Label1.Text = "***recurso em construção***"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(253, 276)
        Controls.Add(Label1)
        Controls.Add(Labeldiskinfo)
        Controls.Add(ProgressBarDisco)
        Controls.Add(LabelSistemaArquivos)
        Controls.Add(LabelEspacoOcupado)
        Controls.Add(LabelEspacoLivre)
        Controls.Add(LabelTamanhoTotal)
        Controls.Add(LabelTipoDisco)
        Controls.Add(LabelNomeDisco)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form4"
        Text = "Informações do disco principal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelNomeDisco As Label
    Friend WithEvents LabelTipoDisco As Label
    Friend WithEvents LabelTamanhoTotal As Label
    Friend WithEvents LabelEspacoLivre As Label
    Friend WithEvents LabelEspacoOcupado As Label
    Friend WithEvents LabelSistemaArquivos As Label
    Friend WithEvents ProgressBarDisco As ProgressBar
    Friend WithEvents Labeldiskinfo As Label
    Friend WithEvents Label1 As Label
End Class
