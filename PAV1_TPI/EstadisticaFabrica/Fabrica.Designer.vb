<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FabricaReporte
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmb_temporadas = New System.Windows.Forms.ComboBox()
        Me.cmb_año = New System.Windows.Forms.ComboBox()
        Me.fabricaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosFabrica = New asd.DatosFabrica()
        CType(Me.fabricaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosFabrica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DatosFabricas"
        ReportDataSource1.Value = Me.fabricaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "asd.Fabrica.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 66)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(792, 433)
        Me.ReportViewer1.TabIndex = 0
        '
        'cmb_temporadas
        '
        Me.cmb_temporadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_temporadas.FormattingEnabled = True
        Me.cmb_temporadas.Items.AddRange(New Object() {"Otoño-Invierno", "Primavera-Verano"})
        Me.cmb_temporadas.Location = New System.Drawing.Point(13, 31)
        Me.cmb_temporadas.Name = "cmb_temporadas"
        Me.cmb_temporadas.Size = New System.Drawing.Size(121, 21)
        Me.cmb_temporadas.TabIndex = 1
        '
        'cmb_año
        '
        Me.cmb_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_año.FormattingEnabled = True
        Me.cmb_año.Items.AddRange(New Object() {"2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024"})
        Me.cmb_año.Location = New System.Drawing.Point(140, 31)
        Me.cmb_año.Name = "cmb_año"
        Me.cmb_año.Size = New System.Drawing.Size(121, 21)
        Me.cmb_año.TabIndex = 1
        '
        'fabricaBindingSource
        '
        Me.fabricaBindingSource.DataMember = "fabrica"
        Me.fabricaBindingSource.DataSource = Me.DatosFabrica
        '
        'DatosFabrica
        '
        Me.DatosFabrica.DataSetName = "DatosFabrica"
        Me.DatosFabrica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 550)
        Me.Controls.Add(Me.cmb_año)
        Me.Controls.Add(Me.cmb_temporadas)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.fabricaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosFabrica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents fabricaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatosFabrica As asd.DatosFabrica
    Friend WithEvents cmb_temporadas As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_año As System.Windows.Forms.ComboBox

End Class
