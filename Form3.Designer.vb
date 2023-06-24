<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        components = New ComponentModel.Container()
        GroupBox1 = New GroupBox()
        ListViewMemory = New ListView()
        GroupBox2 = New GroupBox()
        ProgressBarMemoria = New ProgressBar()
        LabelLivre = New Label()
        LabelUtilizada = New Label()
        LabelTotal = New Label()
        GroupBox3 = New GroupBox()
        ListViewProcessos = New ListView()
        Timerprocessos = New Timer(components)
        ButtonEncerrarProcesso = New Button()
        ButtonExecutarProcesso = New Button()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ListViewMemory)
        GroupBox1.Location = New Point(12, 192)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(411, 246)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Pentes de Memória"
        ' 
        ' ListViewMemory
        ' 
        ListViewMemory.Dock = DockStyle.Fill
        ListViewMemory.Location = New Point(3, 19)
        ListViewMemory.Name = "ListViewMemory"
        ListViewMemory.Size = New Size(405, 224)
        ListViewMemory.TabIndex = 1
        ListViewMemory.UseCompatibleStateImageBehavior = False
        ListViewMemory.View = View.Details
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ProgressBarMemoria)
        GroupBox2.Controls.Add(LabelLivre)
        GroupBox2.Controls.Add(LabelUtilizada)
        GroupBox2.Controls.Add(LabelTotal)
        GroupBox2.Location = New Point(15, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(405, 172)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Status da Memória"
        ' 
        ' ProgressBarMemoria
        ' 
        ProgressBarMemoria.Location = New Point(28, 131)
        ProgressBarMemoria.Name = "ProgressBarMemoria"
        ProgressBarMemoria.Size = New Size(356, 23)
        ProgressBarMemoria.Style = ProgressBarStyle.Continuous
        ProgressBarMemoria.TabIndex = 3
        ' 
        ' LabelLivre
        ' 
        LabelLivre.AutoSize = True
        LabelLivre.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LabelLivre.Location = New Point(28, 98)
        LabelLivre.Name = "LabelLivre"
        LabelLivre.Size = New Size(43, 15)
        LabelLivre.TabIndex = 2
        LabelLivre.Text = "Label2"
        ' 
        ' LabelUtilizada
        ' 
        LabelUtilizada.AutoSize = True
        LabelUtilizada.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LabelUtilizada.Location = New Point(28, 69)
        LabelUtilizada.Name = "LabelUtilizada"
        LabelUtilizada.Size = New Size(43, 15)
        LabelUtilizada.TabIndex = 1
        LabelUtilizada.Text = "Label1"
        ' 
        ' LabelTotal
        ' 
        LabelTotal.AutoSize = True
        LabelTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTotal.Location = New Point(28, 39)
        LabelTotal.Name = "LabelTotal"
        LabelTotal.Size = New Size(43, 15)
        LabelTotal.TabIndex = 0
        LabelTotal.Text = "Label1"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(ListViewProcessos)
        GroupBox3.Location = New Point(429, 12)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(351, 367)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "Gerenciador de Processos"
        ' 
        ' ListViewProcessos
        ' 
        ListViewProcessos.Dock = DockStyle.Fill
        ListViewProcessos.Location = New Point(3, 19)
        ListViewProcessos.Name = "ListViewProcessos"
        ListViewProcessos.Size = New Size(345, 345)
        ListViewProcessos.TabIndex = 0
        ListViewProcessos.UseCompatibleStateImageBehavior = False
        ' 
        ' Timerprocessos
        ' 
        Timerprocessos.Enabled = True
        Timerprocessos.Interval = 1000
        ' 
        ' ButtonEncerrarProcesso
        ' 
        ButtonEncerrarProcesso.Location = New Point(429, 383)
        ButtonEncerrarProcesso.Name = "ButtonEncerrarProcesso"
        ButtonEncerrarProcesso.Size = New Size(149, 41)
        ButtonEncerrarProcesso.TabIndex = 4
        ButtonEncerrarProcesso.Text = "Encerrar Processo"
        ButtonEncerrarProcesso.UseVisualStyleBackColor = True
        ' 
        ' ButtonExecutarProcesso
        ' 
        ButtonExecutarProcesso.Location = New Point(584, 383)
        ButtonExecutarProcesso.Name = "ButtonExecutarProcesso"
        ButtonExecutarProcesso.Size = New Size(91, 41)
        ButtonExecutarProcesso.TabIndex = 5
        ButtonExecutarProcesso.Text = "Executar"
        ButtonExecutarProcesso.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(681, 383)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 41)
        Button1.TabIndex = 6
        Button1.Text = "Relatório"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(ButtonExecutarProcesso)
        Controls.Add(ButtonEncerrarProcesso)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form3"
        Text = "Memória ram"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListViewMemory As ListView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ProgressBarMemoria As ProgressBar
    Friend WithEvents LabelLivre As Label
    Friend WithEvents LabelUtilizada As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ListViewProcessos As ListView
    Friend WithEvents Timerprocessos As Timer
    Friend WithEvents ButtonEncerrarProcesso As Button
    Friend WithEvents ButtonExecutarProcesso As Button
    Friend WithEvents Button1 As Button
End Class
