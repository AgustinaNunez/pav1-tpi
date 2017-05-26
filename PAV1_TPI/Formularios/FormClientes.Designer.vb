<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClientes))
        Me.btn_nuevo_cliente_carga = New System.Windows.Forms.Button()
        Me.btn_eliminar_cliente_carga = New System.Windows.Forms.Button()
        Me.btn_guardar_cliente_carga = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_apellido_cliente_carga = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nombre_cliente_carga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_email_cliente_cliente_carga = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_documento_cliente_carga = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_telefono_cliente_carga = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_tipo_documento_cliente_busqueda = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.col_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipo_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_msj = New System.Windows.Forms.Label()
        Me.txt_numero_documento_cliente_busqueda = New System.Windows.Forms.TextBox()
        Me.txt_numero_documento_carga = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_apellidoERROR = New System.Windows.Forms.Label()
        Me.lbl_nombreERROR = New System.Windows.Forms.Label()
        Me.lbl_tipodocERROR = New System.Windows.Forms.Label()
        Me.lbl_documentoERROR = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_seleccionar = New System.Windows.Forms.Button()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_nuevo_cliente_carga
        '
        Me.btn_nuevo_cliente_carga.BackColor = System.Drawing.Color.White
        Me.btn_nuevo_cliente_carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo_cliente_carga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_nuevo_cliente_carga.Image = Global.PAV1_TPI.My.Resources.Resources.plus_circular_button32
        Me.btn_nuevo_cliente_carga.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo_cliente_carga.Location = New System.Drawing.Point(834, 326)
        Me.btn_nuevo_cliente_carga.Name = "btn_nuevo_cliente_carga"
        Me.btn_nuevo_cliente_carga.Size = New System.Drawing.Size(98, 45)
        Me.btn_nuevo_cliente_carga.TabIndex = 6
        Me.btn_nuevo_cliente_carga.Text = "Nuevo"
        Me.btn_nuevo_cliente_carga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_cliente_carga.UseVisualStyleBackColor = False
        '
        'btn_eliminar_cliente_carga
        '
        Me.btn_eliminar_cliente_carga.BackColor = System.Drawing.Color.White
        Me.btn_eliminar_cliente_carga.Enabled = False
        Me.btn_eliminar_cliente_carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar_cliente_carga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_eliminar_cliente_carga.Image = Global.PAV1_TPI.My.Resources.Resources.trash_bin32
        Me.btn_eliminar_cliente_carga.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar_cliente_carga.Location = New System.Drawing.Point(1042, 326)
        Me.btn_eliminar_cliente_carga.Name = "btn_eliminar_cliente_carga"
        Me.btn_eliminar_cliente_carga.Size = New System.Drawing.Size(98, 45)
        Me.btn_eliminar_cliente_carga.TabIndex = 8
        Me.btn_eliminar_cliente_carga.Text = "Eliminar"
        Me.btn_eliminar_cliente_carga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar_cliente_carga.UseVisualStyleBackColor = False
        Me.btn_eliminar_cliente_carga.Visible = False
        '
        'btn_guardar_cliente_carga
        '
        Me.btn_guardar_cliente_carga.BackColor = System.Drawing.Color.White
        Me.btn_guardar_cliente_carga.Enabled = False
        Me.btn_guardar_cliente_carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar_cliente_carga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_guardar_cliente_carga.Image = Global.PAV1_TPI.My.Resources.Resources.check_mark
        Me.btn_guardar_cliente_carga.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar_cliente_carga.Location = New System.Drawing.Point(938, 326)
        Me.btn_guardar_cliente_carga.Name = "btn_guardar_cliente_carga"
        Me.btn_guardar_cliente_carga.Size = New System.Drawing.Size(98, 45)
        Me.btn_guardar_cliente_carga.TabIndex = 7
        Me.btn_guardar_cliente_carga.Text = "Guardar"
        Me.btn_guardar_cliente_carga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar_cliente_carga.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(60, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apellido: (*)"
        '
        'txt_apellido_cliente_carga
        '
        Me.txt_apellido_cliente_carga.Enabled = False
        Me.txt_apellido_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellido_cliente_carga.ForeColor = System.Drawing.Color.Black
        Me.txt_apellido_cliente_carga.Location = New System.Drawing.Point(141, 33)
        Me.txt_apellido_cliente_carga.Name = "txt_apellido_cliente_carga"
        Me.txt_apellido_cliente_carga.Size = New System.Drawing.Size(217, 25)
        Me.txt_apellido_cliente_carga.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(59, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre: (*)"
        '
        'txt_nombre_cliente_carga
        '
        Me.txt_nombre_cliente_carga.Enabled = False
        Me.txt_nombre_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_cliente_carga.ForeColor = System.Drawing.Color.Black
        Me.txt_nombre_cliente_carga.Location = New System.Drawing.Point(141, 64)
        Me.txt_nombre_cliente_carga.Name = "txt_nombre_cliente_carga"
        Me.txt_nombre_cliente_carga.Size = New System.Drawing.Size(217, 25)
        Me.txt_nombre_cliente_carga.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo Documento: (*)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(41, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Documento: (*)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(86, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "E-mail:"
        '
        'txt_email_cliente_cliente_carga
        '
        Me.txt_email_cliente_cliente_carga.Enabled = False
        Me.txt_email_cliente_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email_cliente_cliente_carga.ForeColor = System.Drawing.Color.Black
        Me.txt_email_cliente_cliente_carga.Location = New System.Drawing.Point(141, 157)
        Me.txt_email_cliente_cliente_carga.Name = "txt_email_cliente_cliente_carga"
        Me.txt_email_cliente_cliente_carga.Size = New System.Drawing.Size(217, 25)
        Me.txt_email_cliente_cliente_carga.TabIndex = 4
        '
        'cmb_tipo_documento_cliente_carga
        '
        Me.cmb_tipo_documento_cliente_carga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_documento_cliente_carga.Enabled = False
        Me.cmb_tipo_documento_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_documento_cliente_carga.ForeColor = System.Drawing.Color.Black
        Me.cmb_tipo_documento_cliente_carga.FormattingEnabled = True
        Me.cmb_tipo_documento_cliente_carga.Location = New System.Drawing.Point(141, 95)
        Me.cmb_tipo_documento_cliente_carga.Name = "cmb_tipo_documento_cliente_carga"
        Me.cmb_tipo_documento_cliente_carga.Size = New System.Drawing.Size(217, 25)
        Me.cmb_tipo_documento_cliente_carga.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(72, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Teléfono:"
        '
        'txt_telefono_cliente_carga
        '
        Me.txt_telefono_cliente_carga.Enabled = False
        Me.txt_telefono_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono_cliente_carga.ForeColor = System.Drawing.Color.Black
        Me.txt_telefono_cliente_carga.Location = New System.Drawing.Point(141, 188)
        Me.txt_telefono_cliente_carga.Mask = "99999999999"
        Me.txt_telefono_cliente_carga.Name = "txt_telefono_cliente_carga"
        Me.txt_telefono_cliente_carga.Size = New System.Drawing.Size(91, 25)
        Me.txt_telefono_cliente_carga.TabIndex = 5
        '
        'cmb_tipo_documento_cliente_busqueda
        '
        Me.cmb_tipo_documento_cliente_busqueda.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_documento_cliente_busqueda.FormattingEnabled = True
        Me.cmb_tipo_documento_cliente_busqueda.Location = New System.Drawing.Point(126, 33)
        Me.cmb_tipo_documento_cliente_busqueda.Name = "cmb_tipo_documento_cliente_busqueda"
        Me.cmb_tipo_documento_cliente_busqueda.Size = New System.Drawing.Size(89, 25)
        Me.cmb_tipo_documento_cliente_busqueda.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(221, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Documento:"
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_clientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_clientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_apellido, Me.col_nombre, Me.col_tipo_documento, Me.col_documento, Me.col_email, Me.col_telefono})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_clientes.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_clientes.Location = New System.Drawing.Point(18, 72)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_clientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_clientes.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_clientes.Size = New System.Drawing.Size(782, 490)
        Me.dgv_clientes.TabIndex = 3
        '
        'col_apellido
        '
        Me.col_apellido.HeaderText = "Apellido"
        Me.col_apellido.Name = "col_apellido"
        Me.col_apellido.ReadOnly = True
        Me.col_apellido.Width = 120
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        Me.col_nombre.Width = 120
        '
        'col_tipo_documento
        '
        Me.col_tipo_documento.HeaderText = "Tipo Doc."
        Me.col_tipo_documento.Name = "col_tipo_documento"
        Me.col_tipo_documento.ReadOnly = True
        Me.col_tipo_documento.Width = 95
        '
        'col_documento
        '
        Me.col_documento.HeaderText = "Documento"
        Me.col_documento.Name = "col_documento"
        Me.col_documento.ReadOnly = True
        '
        'col_email
        '
        Me.col_email.HeaderText = "E-mail"
        Me.col_email.Name = "col_email"
        Me.col_email.ReadOnly = True
        Me.col_email.Width = 180
        '
        'col_telefono
        '
        Me.col_telefono.HeaderText = "Teléfono"
        Me.col_telefono.Name = "col_telefono"
        Me.col_telefono.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(15, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Tipo Documento:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_msj)
        Me.GroupBox1.Controls.Add(Me.txt_numero_documento_cliente_busqueda)
        Me.GroupBox1.Controls.Add(Me.dgv_clientes)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmb_tipo_documento_cliente_busqueda)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(820, 583)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Clientes"
        '
        'lbl_msj
        '
        Me.lbl_msj.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lbl_msj.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_msj.ForeColor = System.Drawing.Color.White
        Me.lbl_msj.Location = New System.Drawing.Point(536, 33)
        Me.lbl_msj.Name = "lbl_msj"
        Me.lbl_msj.Size = New System.Drawing.Size(264, 25)
        Me.lbl_msj.TabIndex = 30
        Me.lbl_msj.Text = " mensaje"
        Me.lbl_msj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_msj.Visible = False
        '
        'txt_numero_documento_cliente_busqueda
        '
        Me.txt_numero_documento_cliente_busqueda.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero_documento_cliente_busqueda.Location = New System.Drawing.Point(302, 33)
        Me.txt_numero_documento_cliente_busqueda.Name = "txt_numero_documento_cliente_busqueda"
        Me.txt_numero_documento_cliente_busqueda.Size = New System.Drawing.Size(100, 25)
        Me.txt_numero_documento_cliente_busqueda.TabIndex = 1
        '
        'txt_numero_documento_carga
        '
        Me.txt_numero_documento_carga.Enabled = False
        Me.txt_numero_documento_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero_documento_carga.ForeColor = System.Drawing.Color.Black
        Me.txt_numero_documento_carga.Location = New System.Drawing.Point(141, 126)
        Me.txt_numero_documento_carga.Name = "txt_numero_documento_carga"
        Me.txt_numero_documento_carga.Size = New System.Drawing.Size(217, 25)
        Me.txt_numero_documento_carga.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(14, 234)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(344, 17)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Observación: Los campos marcados con (*) son obligatorios."
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Image = Global.PAV1_TPI.My.Resources.Resources.clotta_nombre
        Me.Label7.Location = New System.Drawing.Point(1130, 600)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 33)
        Me.Label7.TabIndex = 26
        '
        'lbl_apellidoERROR
        '
        Me.lbl_apellidoERROR.AutoSize = True
        Me.lbl_apellidoERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_apellidoERROR.Location = New System.Drawing.Point(364, 36)
        Me.lbl_apellidoERROR.Name = "lbl_apellidoERROR"
        Me.lbl_apellidoERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_apellidoERROR.TabIndex = 27
        Me.lbl_apellidoERROR.Text = "   "
        Me.lbl_apellidoERROR.Visible = False
        '
        'lbl_nombreERROR
        '
        Me.lbl_nombreERROR.AutoSize = True
        Me.lbl_nombreERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_nombreERROR.Location = New System.Drawing.Point(364, 67)
        Me.lbl_nombreERROR.Name = "lbl_nombreERROR"
        Me.lbl_nombreERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_nombreERROR.TabIndex = 27
        Me.lbl_nombreERROR.Text = "   "
        Me.lbl_nombreERROR.Visible = False
        '
        'lbl_tipodocERROR
        '
        Me.lbl_tipodocERROR.AutoSize = True
        Me.lbl_tipodocERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_tipodocERROR.Location = New System.Drawing.Point(364, 98)
        Me.lbl_tipodocERROR.Name = "lbl_tipodocERROR"
        Me.lbl_tipodocERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_tipodocERROR.TabIndex = 27
        Me.lbl_tipodocERROR.Text = "   "
        Me.lbl_tipodocERROR.Visible = False
        '
        'lbl_documentoERROR
        '
        Me.lbl_documentoERROR.AutoSize = True
        Me.lbl_documentoERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_documentoERROR.Location = New System.Drawing.Point(364, 129)
        Me.lbl_documentoERROR.Name = "lbl_documentoERROR"
        Me.lbl_documentoERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_documentoERROR.TabIndex = 27
        Me.lbl_documentoERROR.Text = "   "
        Me.lbl_documentoERROR.Visible = False
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1251, 47)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "  Administración de Clientes"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_apellido_cliente_carga)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lbl_documentoERROR)
        Me.GroupBox2.Controls.Add(Me.txt_nombre_cliente_carga)
        Me.GroupBox2.Controls.Add(Me.lbl_tipodocERROR)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lbl_nombreERROR)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lbl_apellidoERROR)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txt_email_cliente_cliente_carga)
        Me.GroupBox2.Controls.Add(Me.txt_numero_documento_carga)
        Me.GroupBox2.Controls.Add(Me.cmb_tipo_documento_cliente_carga)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_telefono_cliente_carga)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(834, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(405, 270)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Carga de Clientes"
        '
        'btn_seleccionar
        '
        Me.btn_seleccionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_seleccionar.Enabled = False
        Me.btn_seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_seleccionar.ForeColor = System.Drawing.Color.White
        Me.btn_seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_seleccionar.Location = New System.Drawing.Point(1144, 326)
        Me.btn_seleccionar.Name = "btn_seleccionar"
        Me.btn_seleccionar.Size = New System.Drawing.Size(95, 45)
        Me.btn_seleccionar.TabIndex = 30
        Me.btn_seleccionar.Text = "Seleccionar"
        Me.btn_seleccionar.UseVisualStyleBackColor = False
        Me.btn_seleccionar.Visible = False
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1251, 646)
        Me.Controls.Add(Me.btn_seleccionar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_guardar_cliente_carga)
        Me.Controls.Add(Me.btn_eliminar_cliente_carga)
        Me.Controls.Add(Me.btn_nuevo_cliente_carga)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLOTTA Clientes"
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_nuevo_cliente_carga As Button
    Friend WithEvents btn_eliminar_cliente_carga As Button
    Friend WithEvents btn_guardar_cliente_carga As Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido_cliente_carga As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_cliente_carga As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_email_cliente_cliente_carga As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tipo_documento_cliente_carga As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono_cliente_carga As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_tipo_documento_cliente_busqueda As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgv_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_numero_documento_cliente_busqueda As System.Windows.Forms.TextBox
    Friend WithEvents txt_numero_documento_carga As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_apellidoERROR As System.Windows.Forms.Label
    Friend WithEvents lbl_nombreERROR As System.Windows.Forms.Label
    Friend WithEvents lbl_tipodocERROR As System.Windows.Forms.Label
    Friend WithEvents lbl_documentoERROR As System.Windows.Forms.Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents col_apellido As DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
    Friend WithEvents col_tipo_documento As DataGridViewTextBoxColumn
    Friend WithEvents col_documento As DataGridViewTextBoxColumn
    Friend WithEvents col_email As DataGridViewTextBoxColumn
    Friend WithEvents col_telefono As DataGridViewTextBoxColumn
    Friend WithEvents lbl_msj As Label
    Friend WithEvents btn_seleccionar As Button
End Class
