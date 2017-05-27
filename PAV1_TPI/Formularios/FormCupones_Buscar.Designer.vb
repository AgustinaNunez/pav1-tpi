<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCupones_Buscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCupones_Buscar))
        Me.grid1 = New System.Windows.Forms.DataGridView()
        Me.numero_lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero_autorizacion_online = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tarjeta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_cupon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_buscarTARJETA = New System.Windows.Forms.Button()
        Me.btn_buscarBANCO = New System.Windows.Forms.Button()
        Me.cmb_tarjetaBUSCAR = New System.Windows.Forms.ComboBox()
        Me.cmb_bancoBUSCAR = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero_lote, Me.numero_autorizacion_online, Me.id_tarjeta, Me.nombre_banco, Me.monto, Me.id_banco, Me.id_cupon})
        Me.grid1.Location = New System.Drawing.Point(12, 178)
        Me.grid1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grid1.Name = "grid1"
        Me.grid1.Size = New System.Drawing.Size(651, 327)
        Me.grid1.TabIndex = 3
        '
        'numero_lote
        '
        Me.numero_lote.HeaderText = "Nro. Lote"
        Me.numero_lote.Name = "numero_lote"
        Me.numero_lote.Width = 90
        '
        'numero_autorizacion_online
        '
        Me.numero_autorizacion_online.HeaderText = "Nro. Autorización"
        Me.numero_autorizacion_online.Name = "numero_autorizacion_online"
        Me.numero_autorizacion_online.Width = 140
        '
        'id_tarjeta
        '
        Me.id_tarjeta.HeaderText = "Tarjeta"
        Me.id_tarjeta.Name = "id_tarjeta"
        Me.id_tarjeta.Width = 120
        '
        'nombre_banco
        '
        Me.nombre_banco.HeaderText = "Banco"
        Me.nombre_banco.Name = "nombre_banco"
        Me.nombre_banco.Width = 150
        '
        'monto
        '
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        Me.monto.Width = 80
        '
        'id_banco
        '
        Me.id_banco.HeaderText = "id_banco"
        Me.id_banco.Name = "id_banco"
        Me.id_banco.Visible = False
        '
        'id_cupon
        '
        Me.id_cupon.HeaderText = "id_cupon"
        Me.id_cupon.Name = "id_cupon"
        Me.id_cupon.Visible = False
        '
        'btn_buscarTARJETA
        '
        Me.btn_buscarTARJETA.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_buscarTARJETA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscarTARJETA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscarTARJETA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_buscarTARJETA.Image = Global.PAV1_TPI.My.Resources.Resources.magnifier16
        Me.btn_buscarTARJETA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscarTARJETA.Location = New System.Drawing.Point(267, 69)
        Me.btn_buscarTARJETA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_buscarTARJETA.Name = "btn_buscarTARJETA"
        Me.btn_buscarTARJETA.Size = New System.Drawing.Size(25, 25)
        Me.btn_buscarTARJETA.TabIndex = 25
        Me.btn_buscarTARJETA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscarTARJETA.UseVisualStyleBackColor = True
        '
        'btn_buscarBANCO
        '
        Me.btn_buscarBANCO.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_buscarBANCO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscarBANCO.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscarBANCO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_buscarBANCO.Image = Global.PAV1_TPI.My.Resources.Resources.magnifier16
        Me.btn_buscarBANCO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscarBANCO.Location = New System.Drawing.Point(267, 36)
        Me.btn_buscarBANCO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_buscarBANCO.Name = "btn_buscarBANCO"
        Me.btn_buscarBANCO.Size = New System.Drawing.Size(25, 25)
        Me.btn_buscarBANCO.TabIndex = 20
        Me.btn_buscarBANCO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscarBANCO.UseVisualStyleBackColor = True
        '
        'cmb_tarjetaBUSCAR
        '
        Me.cmb_tarjetaBUSCAR.BackColor = System.Drawing.Color.White
        Me.cmb_tarjetaBUSCAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tarjetaBUSCAR.ForeColor = System.Drawing.Color.Black
        Me.cmb_tarjetaBUSCAR.FormattingEnabled = True
        Me.cmb_tarjetaBUSCAR.Location = New System.Drawing.Point(85, 70)
        Me.cmb_tarjetaBUSCAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmb_tarjetaBUSCAR.Name = "cmb_tarjetaBUSCAR"
        Me.cmb_tarjetaBUSCAR.Size = New System.Drawing.Size(176, 25)
        Me.cmb_tarjetaBUSCAR.TabIndex = 24
        Me.cmb_tarjetaBUSCAR.Text = "(Seleccionar Tarjeta)"
        '
        'cmb_bancoBUSCAR
        '
        Me.cmb_bancoBUSCAR.BackColor = System.Drawing.Color.White
        Me.cmb_bancoBUSCAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_bancoBUSCAR.ForeColor = System.Drawing.Color.Black
        Me.cmb_bancoBUSCAR.FormattingEnabled = True
        Me.cmb_bancoBUSCAR.Location = New System.Drawing.Point(85, 37)
        Me.cmb_bancoBUSCAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmb_bancoBUSCAR.Name = "cmb_bancoBUSCAR"
        Me.cmb_bancoBUSCAR.Size = New System.Drawing.Size(176, 25)
        Me.cmb_bancoBUSCAR.TabIndex = 22
        Me.cmb_bancoBUSCAR.Text = "(Seleccionar Banco)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(32, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Tarjeta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(36, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Banco"
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(681, 61)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "  Cupones registrados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmb_bancoBUSCAR)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.btn_buscarTARJETA)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btn_buscarBANCO)
        Me.GroupBox3.Controls.Add(Me.cmb_tarjetaBUSCAR)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(344, 117)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtrar cupones por..."
        '
        'FormCupones_Buscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(681, 519)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grid1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormCupones_Buscar"
        Me.Text = "Cupones Registrados"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_buscarTARJETA As System.Windows.Forms.Button
    Friend WithEvents btn_buscarBANCO As System.Windows.Forms.Button
    Friend WithEvents cmb_tarjetaBUSCAR As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_bancoBUSCAR As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents numero_lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero_autorizacion_online As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tarjeta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_banco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_banco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_cupon As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
