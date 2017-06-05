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
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_fabricaBUSCAR = New System.Windows.Forms.ComboBox()
        Me.Rubro = New System.Windows.Forms.Label()
        Me.cbo_rubroBUSCAR = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_habilitado = New System.Windows.Forms.ComboBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.DataSetProductos = New PAV1_TPI.DataSetProductos()
        Me.t_productosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataSetProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t_productosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource7.Name = "ReporteProductos"
        ReportDataSource7.Value = Me.t_productosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PAV1_TPI.ReporteProductos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 61)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(753, 348)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'cbo_fabricaBUSCAR
        '
        Me.cbo_fabricaBUSCAR.FormattingEnabled = True
        Me.cbo_fabricaBUSCAR.Location = New System.Drawing.Point(232, 21)
        Me.cbo_fabricaBUSCAR.Name = "cbo_fabricaBUSCAR"
        Me.cbo_fabricaBUSCAR.Size = New System.Drawing.Size(121, 21)
        Me.cbo_fabricaBUSCAR.TabIndex = 2
        '
        'Rubro
        '
        Me.Rubro.AutoSize = True
        Me.Rubro.Location = New System.Drawing.Point(391, 24)
        Me.Rubro.Name = "Rubro"
        Me.Rubro.Size = New System.Drawing.Size(36, 13)
        Me.Rubro.TabIndex = 1
        Me.Rubro.Text = "Rubro"
        '
        'cbo_rubroBUSCAR
        '
        Me.cbo_rubroBUSCAR.FormattingEnabled = True
        Me.cbo_rubroBUSCAR.Location = New System.Drawing.Point(433, 21)
        Me.cbo_rubroBUSCAR.Name = "cbo_rubroBUSCAR"
        Me.cbo_rubroBUSCAR.Size = New System.Drawing.Size(121, 21)
        Me.cbo_rubroBUSCAR.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(584, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Habilitado"
        '
        'cmb_habilitado
        '
        Me.cmb_habilitado.FormattingEnabled = True
        Me.cmb_habilitado.Items.AddRange(New Object() {"Si", "No", "Ambos"})
        Me.cmb_habilitado.Location = New System.Drawing.Point(644, 21)
        Me.cmb_habilitado.Name = "cmb_habilitado"
        Me.cmb_habilitado.Size = New System.Drawing.Size(121, 21)
        Me.cmb_habilitado.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(74, 21)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 3
        '
        'DataSetProductos
        '
        Me.DataSetProductos.DataSetName = "DataSetProductos"
        Me.DataSetProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        't_productosBindingSource
        '
        Me.t_productosBindingSource.DataMember = "t_productos"
        Me.t_productosBindingSource.DataSource = Me.DataSetProductos
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fabrica"
        '
        'ReporteProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 433)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.cmb_habilitado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbo_rubroBUSCAR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Rubro)
        Me.Controls.Add(Me.cbo_fabricaBUSCAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteProductos"
        Me.Text = "ReporteProductos"
        CType(Me.DataSetProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t_productosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_fabricaBUSCAR As ComboBox
    Friend WithEvents Rubro As Label
    Friend WithEvents cbo_rubroBUSCAR As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_habilitado As ComboBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents t_productosBindingSource As BindingSource
    Friend WithEvents DataSetProductos As DataSetProductos
    Friend WithEvents Label3 As Label
End Class
