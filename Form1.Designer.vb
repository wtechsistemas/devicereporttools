<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        SplitContainer1 = New SplitContainer()
        TreeView1 = New TreeView()
        ComboBox1 = New ComboBox()
        SplitContainer2 = New SplitContainer()
        ToolStrip1 = New ToolStrip()
        Label1 = New ToolStripLabel()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ImageList1 = New ImageList(components)
        btnExportDevice = New Button()
        btnExportDeviceList = New Button()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ArquivoToolStripMenuItem = New ToolStripMenuItem()
        ExportarlistaDeDispositivosToolStripMenuItem = New ToolStripMenuItem()
        ExportarinformaçõesDoDispositivoToolStripMenuItem = New ToolStripMenuItem()
        SairToolStripMenuItem = New ToolStripMenuItem()
        FerramentasToolStripMenuItem = New ToolStripMenuItem()
        CpuInfoToolStripMenuItem = New ToolStripMenuItem()
        InformaçõesDaMemoriaToolStripMenuItem = New ToolStripMenuItem()
        InformaçõesDeDiscoToolStripMenuItem = New ToolStripMenuItem()
        InformaçõesDaBateriaToolStripMenuItem = New ToolStripMenuItem()
        UtilitárioDeFormataçãoDeDiscoToolStripMenuItem = New ToolStripMenuItem()
        AjudaToolStripMenuItem = New ToolStripMenuItem()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        ToolStrip1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 24)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(TreeView1)
        SplitContainer1.Panel1.Controls.Add(ComboBox1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(SplitContainer2)
        SplitContainer1.Size = New Size(800, 426)
        SplitContainer1.SplitterDistance = 266
        SplitContainer1.TabIndex = 0
        ' 
        ' TreeView1
        ' 
        TreeView1.Dock = DockStyle.Fill
        TreeView1.Location = New Point(0, 23)
        TreeView1.Name = "TreeView1"
        TreeView1.Size = New Size(266, 403)
        TreeView1.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Dock = DockStyle.Top
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(0, 0)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(266, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.Location = New Point(0, 0)
        SplitContainer2.Name = "SplitContainer2"
        SplitContainer2.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(ToolStrip1)
        SplitContainer2.Panel1.Controls.Add(ListView1)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(btnExportDevice)
        SplitContainer2.Panel2.Controls.Add(btnExportDeviceList)
        SplitContainer2.Size = New Size(530, 426)
        SplitContainer2.SplitterDistance = 349
        SplitContainer2.TabIndex = 5
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {Label1})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(530, 25)
        ToolStrip1.TabIndex = 2
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 22)
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2})
        ListView1.Dock = DockStyle.Fill
        ListView1.LargeImageList = ImageList1
        ListView1.Location = New Point(0, 0)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(530, 349)
        ListView1.SmallImageList = ImageList1
        ListView1.TabIndex = 1
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Campo"
        ColumnHeader1.Width = 200
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Valor"
        ColumnHeader2.Width = 600
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth8Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "mail-mark-important.png")
        ImageList1.Images.SetKeyName(1, "chardevice.png")
        ImageList1.Images.SetKeyName(2, "dialog-info.png")
        ' 
        ' btnExportDevice
        ' 
        btnExportDevice.Location = New Point(199, 14)
        btnExportDevice.Name = "btnExportDevice"
        btnExportDevice.Size = New Size(190, 50)
        btnExportDevice.TabIndex = 4
        btnExportDevice.Text = "Exportar dados deste dispositivo"
        btnExportDevice.UseVisualStyleBackColor = True
        ' 
        ' btnExportDeviceList
        ' 
        btnExportDeviceList.Location = New Point(3, 14)
        btnExportDeviceList.Name = "btnExportDeviceList"
        btnExportDeviceList.Size = New Size(190, 50)
        btnExportDeviceList.TabIndex = 3
        btnExportDeviceList.Text = "Exportar dispositivos"
        btnExportDeviceList.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, ArquivoToolStripMenuItem, FerramentasToolStripMenuItem, AjudaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(12, 20)
        ' 
        ' ArquivoToolStripMenuItem
        ' 
        ArquivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExportarlistaDeDispositivosToolStripMenuItem, ExportarinformaçõesDoDispositivoToolStripMenuItem, SairToolStripMenuItem})
        ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        ArquivoToolStripMenuItem.Size = New Size(61, 20)
        ArquivoToolStripMenuItem.Text = "&Arquivo"
        ' 
        ' ExportarlistaDeDispositivosToolStripMenuItem
        ' 
        ExportarlistaDeDispositivosToolStripMenuItem.Name = "ExportarlistaDeDispositivosToolStripMenuItem"
        ExportarlistaDeDispositivosToolStripMenuItem.Size = New Size(264, 22)
        ExportarlistaDeDispositivosToolStripMenuItem.Text = "Exportar &lista de dispositivos"
        ' 
        ' ExportarinformaçõesDoDispositivoToolStripMenuItem
        ' 
        ExportarinformaçõesDoDispositivoToolStripMenuItem.Name = "ExportarinformaçõesDoDispositivoToolStripMenuItem"
        ExportarinformaçõesDoDispositivoToolStripMenuItem.Size = New Size(264, 22)
        ExportarinformaçõesDoDispositivoToolStripMenuItem.Text = "Exportar &informações do dispositivo"
        ' 
        ' SairToolStripMenuItem
        ' 
        SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        SairToolStripMenuItem.Size = New Size(264, 22)
        SairToolStripMenuItem.Text = "&Sair"
        ' 
        ' FerramentasToolStripMenuItem
        ' 
        FerramentasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CpuInfoToolStripMenuItem, InformaçõesDaMemoriaToolStripMenuItem, InformaçõesDeDiscoToolStripMenuItem, InformaçõesDaBateriaToolStripMenuItem, UtilitárioDeFormataçãoDeDiscoToolStripMenuItem})
        FerramentasToolStripMenuItem.Name = "FerramentasToolStripMenuItem"
        FerramentasToolStripMenuItem.Size = New Size(84, 20)
        FerramentasToolStripMenuItem.Text = "&Ferramentas"
        ' 
        ' CpuInfoToolStripMenuItem
        ' 
        CpuInfoToolStripMenuItem.Name = "CpuInfoToolStripMenuItem"
        CpuInfoToolStripMenuItem.Size = New Size(249, 22)
        CpuInfoToolStripMenuItem.Text = "Informações do processador"
        ' 
        ' InformaçõesDaMemoriaToolStripMenuItem
        ' 
        InformaçõesDaMemoriaToolStripMenuItem.Name = "InformaçõesDaMemoriaToolStripMenuItem"
        InformaçõesDaMemoriaToolStripMenuItem.Size = New Size(249, 22)
        InformaçõesDaMemoriaToolStripMenuItem.Text = "&Informações da memoria"
        ' 
        ' InformaçõesDeDiscoToolStripMenuItem
        ' 
        InformaçõesDeDiscoToolStripMenuItem.Name = "InformaçõesDeDiscoToolStripMenuItem"
        InformaçõesDeDiscoToolStripMenuItem.Size = New Size(249, 22)
        InformaçõesDeDiscoToolStripMenuItem.Text = "Informações de disco"
        ' 
        ' InformaçõesDaBateriaToolStripMenuItem
        ' 
        InformaçõesDaBateriaToolStripMenuItem.Name = "InformaçõesDaBateriaToolStripMenuItem"
        InformaçõesDaBateriaToolStripMenuItem.Size = New Size(249, 22)
        InformaçõesDaBateriaToolStripMenuItem.Text = "Informações da bateria"
        ' 
        ' UtilitárioDeFormataçãoDeDiscoToolStripMenuItem
        ' 
        UtilitárioDeFormataçãoDeDiscoToolStripMenuItem.Name = "UtilitárioDeFormataçãoDeDiscoToolStripMenuItem"
        UtilitárioDeFormataçãoDeDiscoToolStripMenuItem.Size = New Size(249, 22)
        UtilitárioDeFormataçãoDeDiscoToolStripMenuItem.Text = "Utilitário de formatação de disco "
        ' 
        ' AjudaToolStripMenuItem
        ' 
        AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        AjudaToolStripMenuItem.Size = New Size(50, 20)
        AjudaToolStripMenuItem.Text = "A&juda"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SplitContainer1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Gerenciador de dispositivos"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel1.PerformLayout()
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents btnExportDevice As Button
    Friend WithEvents btnExportDeviceList As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Label1 As ToolStripLabel
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FerramentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportarlistaDeDispositivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportarinformaçõesDoDispositivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CpuInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformaçõesDaMemoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformaçõesDeDiscoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformaçõesDaBateriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilitárioDeFormataçãoDeDiscoToolStripMenuItem As ToolStripMenuItem
End Class
