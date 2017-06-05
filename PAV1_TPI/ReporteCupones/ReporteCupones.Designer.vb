<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteCupones
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
        Me.ReportCupon = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetClotta = New PAV1_TPI.DataSetClotta()
        Me.t_cuponBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_bancoBUSCAR = New System.Windows.Forms.ComboBox()
        Me.lbl_banco = New System.Windows.Forms.Label()
        Me.cmb_tarjetaBUSCAR = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataSetClotta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t_cuponBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportCupon
        '
        ReportDataSource1.Name = "ReporteCupon"
        ReportDataSource1.Value = Me.t_cuponBindingSource
        Me.ReportCupon.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportCupon.LocalReport.ReportEmbeddedResource = "PAV1_TPI.Report2.rdlc"
        Me.ReportCupon.Location = New System.Drawing.Point(12, 41)
        Me.ReportCupon.Name = "ReportCupon"
        Me.ReportCupon.ServerReport.BearerToken = Nothing
        Me.ReportCupon.Size = New System.Drawing.Size(758, 301)
        Me.ReportCupon.TabIndex = 0
        '
        'DataSetClotta
        '
        Me.DataSetClotta.DataSetName = "DataSetClotta"
        Me.DataSetClotta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        't_cuponBindingSource
        '
        Me.t_cuponBindingSource.DataMember = "t_cupon"
        Me.t_cuponBindingSource.DataSource = Me.DataSetClotta
        '
        'cmb_bancoBUSCAR
        '
        Me.cmb_bancoBUSCAR.FormattingEnabled = True
        Me.cmb_bancoBUSCAR.Location = New System.Drawing.Point(58, 10)
        Me.cmb_bancoBUSCAR.Name = "cmb_bancoBUSCAR"
        Me.cmb_bancoBUSCAR.Size = New System.Drawing.Size(121, 21)
        Me.cmb_bancoBUSCAR.TabIndex = 1
        '
        'lbl_banco
        '
        Me.lbl_banco.AutoSize = True
        Me.lbl_banco.Location = New System.Drawing.Point(13, 13)
        Me.lbl_banco.Name = "lbl_banco"
        Me.lbl_banco.Size = New System.Drawing.Size(38, 13)
        Me.lbl_banco.TabIndex = 2
        Me.lbl_banco.Text = "Banco"
        '
        'cmb_tarjetaBUSCAR
        '
        Me.cmb_tarjetaBUSCAR.FormattingEnabled = True
        Me.cmb_tarjetaBUSCAR.Location = New System.Drawing.Point(245, 12)
        Me.cmb_tarjetaBUSCAR.Name = "cmb_tarjetaBUSCAR"
        Me.cmb_tarjetaBUSCAR.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tarjetaBUSCAR.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tarjeta"
        '
        'ReporteCupones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 354)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_banco)
        Me.Controls.Add(Me.cmb_tarjetaBUSCAR)
        Me.Controls.Add(Me.cmb_bancoBUSCAR)
        Me.Controls.Add(Me.ReportCupon)
        Me.Name = "ReporteCupones"
        Me.Text = "ReporteCupones"
        CType(Me.DataSetClotta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t_cuponBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportCupon As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents t_cuponBindingSource As BindingSource
    Friend WithEvents DataSetClotta As DataSetClotta
    Friend WithEvents cmb_bancoBUSCAR As ComboBox
    Friend WithEvents lbl_banco As Label
    Friend WithEvents cmb_tarjetaBUSCAR As ComboBox
    Friend WithEvents Label1 As Label
End Class
