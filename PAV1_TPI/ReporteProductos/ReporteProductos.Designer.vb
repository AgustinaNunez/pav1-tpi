<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteProductos))
        Me.t_productosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetProductos = New PAV1_TPI.DataSetProductos()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_fabricaBUSCAR = New System.Windows.Forms.ComboBox()
        Me.Rubro = New System.Windows.Forms.Label()
        Me.cbo_rubroBUSCAR = New System.Windows.Forms.ComboBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_stock = New System.Windows.Forms.ComboBox()
        CType(Me.t_productosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        't_productosBindingSource
        '
        Me.t_productosBindingSource.DataMember = "t_productos"
        Me.t_productosBindingSource.DataSource = Me.DataSetProductos
        '
        'DataSetProductos
        '
        Me.DataSetProductos.DataSetName = "DataSetProductos"
        Me.DataSetProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "ReporteProductos"
        ReportDataSource1.Value = Me.t_productosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PAV1_TPI.ReporteProductos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 107)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(867, 454)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Descripción"
        '
        'cbo_fabricaBUSCAR
        '
        Me.cbo_fabricaBUSCAR.FormattingEnabled = True
        Me.cbo_fabricaBUSCAR.Location = New System.Drawing.Point(344, 54)
        Me.cbo_fabricaBUSCAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_fabricaBUSCAR.Name = "cbo_fabricaBUSCAR"
        Me.cbo_fabricaBUSCAR.Size = New System.Drawing.Size(140, 25)
        Me.cbo_fabricaBUSCAR.TabIndex = 2
        '
        'Rubro
        '
        Me.Rubro.AutoSize = True
        Me.Rubro.Location = New System.Drawing.Point(490, 58)
        Me.Rubro.Name = "Rubro"
        Me.Rubro.Size = New System.Drawing.Size(44, 17)
        Me.Rubro.TabIndex = 1
        Me.Rubro.Text = "Rubro"
        '
        'cbo_rubroBUSCAR
        '
        Me.cbo_rubroBUSCAR.FormattingEnabled = True
        Me.cbo_rubroBUSCAR.Location = New System.Drawing.Point(539, 54)
        Me.cbo_rubroBUSCAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_rubroBUSCAR.Name = "cbo_rubroBUSCAR"
        Me.cbo_rubroBUSCAR.Size = New System.Drawing.Size(140, 25)
        Me.cbo_rubroBUSCAR.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(94, 55)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(188, 25)
        Me.txt_nombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fábrica"
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(891, 47)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "  Listado de Productos"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(690, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Stock"
        '
        'cmb_stock
        '
        Me.cmb_stock.FormattingEnabled = True
        Me.cmb_stock.Items.AddRange(New Object() {"Disponible", "No disponible", "Ambos"})
        Me.cmb_stock.Location = New System.Drawing.Point(739, 54)
        Me.cmb_stock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmb_stock.Name = "cmb_stock"
        Me.cmb_stock.Size = New System.Drawing.Size(140, 25)
        Me.cmb_stock.TabIndex = 2
        '
        'ReporteProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(891, 575)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.cmb_stock)
        Me.Controls.Add(Me.cbo_rubroBUSCAR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Rubro)
        Me.Controls.Add(Me.cbo_fabricaBUSCAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ReporteProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informes"
        CType(Me.t_productosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_fabricaBUSCAR As ComboBox
    Friend WithEvents Rubro As Label
    Friend WithEvents cbo_rubroBUSCAR As ComboBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents t_productosBindingSource As BindingSource
    Friend WithEvents DataSetProductos As DataSetProductos
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_stock As ComboBox
End Class
