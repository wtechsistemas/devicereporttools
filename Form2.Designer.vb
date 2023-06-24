<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        ImageList1 = New ImageList(components)
        ListView1 = New ListView()
        Label1 = New Label()
        ListBox1 = New ListBox()
        Timer1 = New Timer(components)
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth8Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "htop.png")
        ImageList1.Images.SetKeyName(1, "9055411_bxs_factory_icon.ico")
        ImageList1.Images.SetKeyName(2, "605496_arch_architecture_building_museum_theatre_icon.ico")
        ImageList1.Images.SetKeyName(3, "1904667_apple_computer_desktop_device_monitor_icon.ico")
        ImageList1.Images.SetKeyName(4, "4691222_nucleo_icon.ico")
        ImageList1.Images.SetKeyName(5, "4691222_nucleo_icon.ico")
        ImageList1.Images.SetKeyName(6, "9071490_speed_one_icon.ico")
        ImageList1.Images.SetKeyName(7, "9071490_speed_one_icon.ico")
        ImageList1.Images.SetKeyName(8, "70279_ram_icon.ico")
        ImageList1.Images.SetKeyName(9, "70279_ram_icon.ico")
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(12, 71)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(553, 238)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(81, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 30)
        Label1.TabIndex = 1
        Label1.Text = "%proc"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(14, 323)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(551, 94)
        ListBox1.TabIndex = 2
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._4064121_computer_cpu_hardware_processor_technology_icon
        PictureBox1.Location = New Point(14, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(52, 53)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(581, 429)
        Controls.Add(PictureBox1)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Controls.Add(ListView1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        Text = "Informações do processador"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
