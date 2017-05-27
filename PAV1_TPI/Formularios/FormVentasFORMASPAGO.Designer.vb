<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentasFORMASPAGO
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVentasFORMASPAGO))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgv_formaPago = New System.Windows.Forms.DataGridView()
        Me.forma_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_montoSINDTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_montoDTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id_formapago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_flag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_eliminarFORMAPAGO = New System.Windows.Forms.Button()
        Me.btn_agregarFORMAPAGO = New System.Windows.Forms.Button()
        Me.cmb_formaPago = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_entidadERROR = New System.Windows.Forms.Label()
        Me.lbl_bancoERROR = New System.Windows.Forms.Label()
        Me.cmb_entidad = New System.Windows.Forms.ComboBox()
        Me.cmb_banco = New System.Windows.Forms.ComboBox()
        Me.lbl_montoERROR = New System.Windows.Forms.Label()
        Me.lbl_autorizacionERROR = New System.Windows.Forms.Label()
        Me.lbl_loteERROR = New System.Windows.Forms.Label()
        Me.lbl_cuponERROR = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_monto = New System.Windows.Forms.TextBox()
        Me.txt_numero_autorizacion = New System.Windows.Forms.TextBox()
        Me.txt_numero_lote = New System.Windows.Forms.TextBox()
        Me.txt_numero_cupon = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_formaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(910, 47)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "   Formas de Pago"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Image = Global.PAV1_TPI.My.Resources.Resources.clotta_nombre
        Me.Label4.Location = New System.Drawing.Point(780, 421)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 33)
        Me.Label4.TabIndex = 43
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.Color.White
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_aceptar.Image = Global.PAV1_TPI.My.Resources.Resources.check_mark
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.Location = New System.Drawing.Point(478, 393)
        Me.btn_aceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(100, 41)
        Me.btn_aceptar.TabIndex = 41
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_formaPago)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.btn_eliminarFORMAPAGO)
        Me.GroupBox3.Controls.Add(Me.btn_agregarFORMAPAGO)
        Me.GroupBox3.Controls.Add(Me.cmb_formaPago)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(460, 351)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Forma de pago"
        '
        'dgv_formaPago
        '
        Me.dgv_formaPago.AllowUserToAddRows = False
        Me.dgv_formaPago.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_formaPago.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_formaPago.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_formaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_formaPago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.forma_pago, Me.dto, Me.col_montoSINDTO, Me.col_montoDTO, Me.col_id_formapago, Me.col_flag})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_formaPago.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_formaPago.Enabled = False
        Me.dgv_formaPago.Location = New System.Drawing.Point(18, 62)
        Me.dgv_formaPago.Name = "dgv_formaPago"
        Me.dgv_formaPago.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_formaPago.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_formaPago.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_formaPago.Size = New System.Drawing.Size(423, 221)
        Me.dgv_formaPago.TabIndex = 13
        '
        'forma_pago
        '
        Me.forma_pago.HeaderText = "Forma de pago"
        Me.forma_pago.Name = "forma_pago"
        Me.forma_pago.ReadOnly = True
        Me.forma_pago.Width = 125
        '
        'dto
        '
        Me.dto.HeaderText = "% Dto."
        Me.dto.Name = "dto"
        Me.dto.ReadOnly = True
        Me.dto.Width = 80
        '
        'col_montoSINDTO
        '
        Me.col_montoSINDTO.HeaderText = "s/ Dto."
        Me.col_montoSINDTO.Name = "col_montoSINDTO"
        Me.col_montoSINDTO.ReadOnly = True
        Me.col_montoSINDTO.Width = 80
        '
        'col_montoDTO
        '
        Me.col_montoDTO.HeaderText = "c/ Dto."
        Me.col_montoDTO.Name = "col_montoDTO"
        Me.col_montoDTO.ReadOnly = True
        Me.col_montoDTO.Width = 80
        '
        'col_id_formapago
        '
        Me.col_id_formapago.HeaderText = "id_forma_pago"
        Me.col_id_formapago.Name = "col_id_formapago"
        Me.col_id_formapago.ReadOnly = True
        Me.col_id_formapago.Visible = False
        '
        'col_flag
        '
        Me.col_flag.HeaderText = "flag"
        Me.col_flag.Name = "col_flag"
        Me.col_flag.ReadOnly = True
        Me.col_flag.Visible = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Button1.Image = Global.PAV1_TPI.My.Resources.Resources.check_mark
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(240, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 45)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Aceptar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'btn_eliminarFORMAPAGO
        '
        Me.btn_eliminarFORMAPAGO.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_eliminarFORMAPAGO.Enabled = False
        Me.btn_eliminarFORMAPAGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminarFORMAPAGO.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminarFORMAPAGO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_eliminarFORMAPAGO.Image = Global.PAV1_TPI.My.Resources.Resources.trash_bin32
        Me.btn_eliminarFORMAPAGO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminarFORMAPAGO.Location = New System.Drawing.Point(129, 290)
        Me.btn_eliminarFORMAPAGO.Name = "btn_eliminarFORMAPAGO"
        Me.btn_eliminarFORMAPAGO.Size = New System.Drawing.Size(105, 45)
        Me.btn_eliminarFORMAPAGO.TabIndex = 10
        Me.btn_eliminarFORMAPAGO.Text = "Eliminar"
        Me.btn_eliminarFORMAPAGO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminarFORMAPAGO.UseVisualStyleBackColor = True
        Me.btn_eliminarFORMAPAGO.Visible = False
        '
        'btn_agregarFORMAPAGO
        '
        Me.btn_agregarFORMAPAGO.Enabled = False
        Me.btn_agregarFORMAPAGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregarFORMAPAGO.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregarFORMAPAGO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_agregarFORMAPAGO.Image = Global.PAV1_TPI.My.Resources.Resources.plus_circular_button32
        Me.btn_agregarFORMAPAGO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregarFORMAPAGO.Location = New System.Drawing.Point(18, 290)
        Me.btn_agregarFORMAPAGO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_agregarFORMAPAGO.Name = "btn_agregarFORMAPAGO"
        Me.btn_agregarFORMAPAGO.Size = New System.Drawing.Size(105, 45)
        Me.btn_agregarFORMAPAGO.TabIndex = 10
        Me.btn_agregarFORMAPAGO.Text = "Agregar"
        Me.btn_agregarFORMAPAGO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_agregarFORMAPAGO.UseVisualStyleBackColor = True
        '
        'cmb_formaPago
        '
        Me.cmb_formaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_formaPago.Enabled = False
        Me.cmb_formaPago.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_formaPago.ForeColor = System.Drawing.Color.Black
        Me.cmb_formaPago.FormattingEnabled = True
        Me.cmb_formaPago.Location = New System.Drawing.Point(135, 30)
        Me.cmb_formaPago.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmb_formaPago.Name = "cmb_formaPago"
        Me.cmb_formaPago.Size = New System.Drawing.Size(125, 25)
        Me.cmb_formaPago.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(15, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Forma de pago (*)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_entidadERROR)
        Me.GroupBox1.Controls.Add(Me.lbl_bancoERROR)
        Me.GroupBox1.Controls.Add(Me.cmb_entidad)
        Me.GroupBox1.Controls.Add(Me.cmb_banco)
        Me.GroupBox1.Controls.Add(Me.lbl_montoERROR)
        Me.GroupBox1.Controls.Add(Me.lbl_autorizacionERROR)
        Me.GroupBox1.Controls.Add(Me.lbl_loteERROR)
        Me.GroupBox1.Controls.Add(Me.lbl_cuponERROR)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_monto)
        Me.GroupBox1.Controls.Add(Me.txt_numero_autorizacion)
        Me.GroupBox1.Controls.Add(Me.txt_numero_lote)
        Me.GroupBox1.Controls.Add(Me.txt_numero_cupon)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(478, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 283)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del cupón"
        '
        'lbl_entidadERROR
        '
        Me.lbl_entidadERROR.AutoSize = True
        Me.lbl_entidadERROR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_entidadERROR.ForeColor = System.Drawing.Color.Black
        Me.lbl_entidadERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_entidadERROR.Location = New System.Drawing.Point(368, 202)
        Me.lbl_entidadERROR.Name = "lbl_entidadERROR"
        Me.lbl_entidadERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_entidadERROR.TabIndex = 66
        Me.lbl_entidadERROR.Text = "   "
        Me.lbl_entidadERROR.Visible = False
        '
        'lbl_bancoERROR
        '
        Me.lbl_bancoERROR.AutoSize = True
        Me.lbl_bancoERROR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bancoERROR.ForeColor = System.Drawing.Color.Black
        Me.lbl_bancoERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_bancoERROR.Location = New System.Drawing.Point(368, 169)
        Me.lbl_bancoERROR.Name = "lbl_bancoERROR"
        Me.lbl_bancoERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_bancoERROR.TabIndex = 65
        Me.lbl_bancoERROR.Text = "   "
        Me.lbl_bancoERROR.Visible = False
        '
        'cmb_entidad
        '
        Me.cmb_entidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_entidad.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_entidad.ForeColor = System.Drawing.Color.Black
        Me.cmb_entidad.FormattingEnabled = True
        Me.cmb_entidad.Location = New System.Drawing.Point(146, 199)
        Me.cmb_entidad.Name = "cmb_entidad"
        Me.cmb_entidad.Size = New System.Drawing.Size(216, 25)
        Me.cmb_entidad.TabIndex = 59
        '
        'cmb_banco
        '
        Me.cmb_banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_banco.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_banco.ForeColor = System.Drawing.Color.Black
        Me.cmb_banco.FormattingEnabled = True
        Me.cmb_banco.Location = New System.Drawing.Point(146, 166)
        Me.cmb_banco.Name = "cmb_banco"
        Me.cmb_banco.Size = New System.Drawing.Size(216, 25)
        Me.cmb_banco.TabIndex = 58
        '
        'lbl_montoERROR
        '
        Me.lbl_montoERROR.AutoSize = True
        Me.lbl_montoERROR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_montoERROR.ForeColor = System.Drawing.Color.Black
        Me.lbl_montoERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_montoERROR.Location = New System.Drawing.Point(368, 136)
        Me.lbl_montoERROR.Name = "lbl_montoERROR"
        Me.lbl_montoERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_montoERROR.TabIndex = 64
        Me.lbl_montoERROR.Text = "   "
        Me.lbl_montoERROR.Visible = False
        '
        'lbl_autorizacionERROR
        '
        Me.lbl_autorizacionERROR.AutoSize = True
        Me.lbl_autorizacionERROR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_autorizacionERROR.ForeColor = System.Drawing.Color.Black
        Me.lbl_autorizacionERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_autorizacionERROR.Location = New System.Drawing.Point(368, 101)
        Me.lbl_autorizacionERROR.Name = "lbl_autorizacionERROR"
        Me.lbl_autorizacionERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_autorizacionERROR.TabIndex = 63
        Me.lbl_autorizacionERROR.Text = "   "
        Me.lbl_autorizacionERROR.Visible = False
        '
        'lbl_loteERROR
        '
        Me.lbl_loteERROR.AutoSize = True
        Me.lbl_loteERROR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loteERROR.ForeColor = System.Drawing.Color.Black
        Me.lbl_loteERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_loteERROR.Location = New System.Drawing.Point(368, 68)
        Me.lbl_loteERROR.Name = "lbl_loteERROR"
        Me.lbl_loteERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_loteERROR.TabIndex = 62
        Me.lbl_loteERROR.Text = "   "
        Me.lbl_loteERROR.Visible = False
        '
        'lbl_cuponERROR
        '
        Me.lbl_cuponERROR.AutoSize = True
        Me.lbl_cuponERROR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cuponERROR.ForeColor = System.Drawing.Color.Black
        Me.lbl_cuponERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_cuponERROR.Location = New System.Drawing.Point(368, 35)
        Me.lbl_cuponERROR.Name = "lbl_cuponERROR"
        Me.lbl_cuponERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_cuponERROR.TabIndex = 61
        Me.lbl_cuponERROR.Text = "   "
        Me.lbl_cuponERROR.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(344, 17)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Observación: Los campos marcados con (*) son obligatorios."
        '
        'txt_monto
        '
        Me.txt_monto.Enabled = False
        Me.txt_monto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_monto.ForeColor = System.Drawing.Color.Black
        Me.txt_monto.Location = New System.Drawing.Point(146, 133)
        Me.txt_monto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Size = New System.Drawing.Size(216, 25)
        Me.txt_monto.TabIndex = 57
        '
        'txt_numero_autorizacion
        '
        Me.txt_numero_autorizacion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero_autorizacion.ForeColor = System.Drawing.Color.Black
        Me.txt_numero_autorizacion.Location = New System.Drawing.Point(146, 98)
        Me.txt_numero_autorizacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_numero_autorizacion.Name = "txt_numero_autorizacion"
        Me.txt_numero_autorizacion.Size = New System.Drawing.Size(216, 25)
        Me.txt_numero_autorizacion.TabIndex = 56
        '
        'txt_numero_lote
        '
        Me.txt_numero_lote.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero_lote.ForeColor = System.Drawing.Color.Black
        Me.txt_numero_lote.Location = New System.Drawing.Point(146, 65)
        Me.txt_numero_lote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_numero_lote.Name = "txt_numero_lote"
        Me.txt_numero_lote.Size = New System.Drawing.Size(216, 25)
        Me.txt_numero_lote.TabIndex = 55
        '
        'txt_numero_cupon
        '
        Me.txt_numero_cupon.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero_cupon.ForeColor = System.Drawing.Color.Black
        Me.txt_numero_cupon.Location = New System.Drawing.Point(146, 32)
        Me.txt_numero_cupon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_numero_cupon.Name = "txt_numero_cupon"
        Me.txt_numero_cupon.Size = New System.Drawing.Size(216, 25)
        Me.txt_numero_cupon.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 17)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Entidad crediticia (*)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(76, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Monto (*)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(23, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 17)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Banco asociado (*)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(24, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 17)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "N° Autorización (*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(71, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "N° Lote (*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(58, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "N° Cupón (*)"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Enabled = False
        Me.txt_subtotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal.ForeColor = System.Drawing.Color.Black
        Me.txt_subtotal.Location = New System.Drawing.Point(147, 71)
        Me.txt_subtotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(125, 25)
        Me.txt_subtotal.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(41, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Subtotal Factura"
        '
        'FormVentasFORMASPAGO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(910, 474)
        Me.Controls.Add(Me.txt_subtotal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormVentasFORMASPAGO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formas de pago"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_formaPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgv_formaPago As DataGridView
    Friend WithEvents forma_pago As DataGridViewTextBoxColumn
    Friend WithEvents dto As DataGridViewTextBoxColumn
    Friend WithEvents col_montoSINDTO As DataGridViewTextBoxColumn
    Friend WithEvents col_montoDTO As DataGridViewTextBoxColumn
    Friend WithEvents col_id_formapago As DataGridViewTextBoxColumn
    Friend WithEvents col_flag As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_eliminarFORMAPAGO As Button
    Friend WithEvents btn_agregarFORMAPAGO As Button
    Friend WithEvents cmb_formaPago As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_entidadERROR As Label
    Friend WithEvents lbl_bancoERROR As Label
    Friend WithEvents cmb_entidad As ComboBox
    Friend WithEvents cmb_banco As ComboBox
    Friend WithEvents lbl_montoERROR As Label
    Friend WithEvents lbl_autorizacionERROR As Label
    Friend WithEvents lbl_loteERROR As Label
    Friend WithEvents lbl_cuponERROR As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_monto As TextBox
    Friend WithEvents txt_numero_autorizacion As TextBox
    Friend WithEvents txt_numero_lote As TextBox
    Friend WithEvents txt_numero_cupon As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents Label7 As Label
End Class
