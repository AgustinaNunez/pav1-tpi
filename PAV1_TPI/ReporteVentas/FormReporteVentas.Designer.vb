﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteVentas
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.cmb_buscar_usuario = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataSetVentas = New PAV1_TPI.DataSetVentas()
        Me.t_ventaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSetVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t_ventaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_buscar_usuario
        '
        Me.cmb_buscar_usuario.FormattingEnabled = True
        Me.cmb_buscar_usuario.Location = New System.Drawing.Point(146, 67)
        Me.cmb_buscar_usuario.Name = "cmb_buscar_usuario"
        Me.cmb_buscar_usuario.Size = New System.Drawing.Size(121, 21)
        Me.cmb_buscar_usuario.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Buscar Usuario:"
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(965, 47)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "  Listado de Ventas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.t_ventaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PAV1_TPI.ReportVenta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(22, 94)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(907, 436)
        Me.ReportViewer1.TabIndex = 56
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(312, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataSetVentas
        '
        Me.DataSetVentas.DataSetName = "DataSetVentas"
        Me.DataSetVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        't_ventaBindingSource
        '
        Me.t_ventaBindingSource.DataMember = "t_venta"
        Me.t_ventaBindingSource.DataSource = Me.DataSetVentas
        '
        'FormReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 542)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.cmb_buscar_usuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Name = "FormReporteVentas"
        Me.Text = "FormReporteVentas"
        CType(Me.DataSetVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t_ventaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_buscar_usuario As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents t_ventaBindingSource As BindingSource
    Friend WithEvents DataSetVentas As DataSetVentas
    Friend WithEvents Button1 As Button
End Class
