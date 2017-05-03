<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProductos))
        Me.dgv_productos = New System.Windows.Forms.DataGridView()
        Me.id_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_lista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_rubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_fabrica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_idBUSCAR = New System.Windows.Forms.MaskedTextBox()
        Me.cbo_fabrica = New System.Windows.Forms.ComboBox()
        Me.cbo_rubro = New System.Windows.Forms.ComboBox()
        Me.lbl_fabrica = New System.Windows.Forms.Label()
        Me.lbl_rubro = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.txt_stock = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.MaskedTextBox()
        Me.txt_descrip = New System.Windows.Forms.TextBox()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.gb_listado = New System.Windows.Forms.GroupBox()
        Me.btn_buscarID = New System.Windows.Forms.Button()
        Me.gb_datos = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_fabricaERROR = New System.Windows.Forms.Label()
        Me.lbl_rubroERROR = New System.Windows.Forms.Label()
        Me.lbl_precioERROR = New System.Windows.Forms.Label()
        Me.lbl_idERROR = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_msj = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.gb_busqueda = New System.Windows.Forms.GroupBox()
        Me.btn_buscarFABRICA = New System.Windows.Forms.Button()
        Me.btn_buscarRUBRO = New System.Windows.Forms.Button()
        Me.cbo_fabricaBUSCAR = New System.Windows.Forms.ComboBox()
        Me.cbo_rubroBUSCAR = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_listado.SuspendLayout()
        Me.gb_datos.SuspendLayout()
        Me.gb_busqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_productos
        '
        Me.dgv_productos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv_productos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_productos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_producto, Me.descrip, Me.stock, Me.precio_lista, Me.id_rubro, Me.id_fabrica})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_productos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_productos.Location = New System.Drawing.Point(19, 24)
        Me.dgv_productos.Name = "dgv_productos"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_productos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_productos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_productos.Size = New System.Drawing.Size(683, 531)
        Me.dgv_productos.TabIndex = 3
        '
        'id_producto
        '
        Me.id_producto.HeaderText = "Id."
        Me.id_producto.Name = "id_producto"
        Me.id_producto.Width = 50
        '
        'descrip
        '
        Me.descrip.HeaderText = "Descripción"
        Me.descrip.Name = "descrip"
        Me.descrip.Width = 210
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.Width = 60
        '
        'precio_lista
        '
        Me.precio_lista.HeaderText = "Precio"
        Me.precio_lista.Name = "precio_lista"
        Me.precio_lista.Width = 60
        '
        'id_rubro
        '
        Me.id_rubro.HeaderText = "Rubro"
        Me.id_rubro.Name = "id_rubro"
        Me.id_rubro.Width = 120
        '
        'id_fabrica
        '
        Me.id_fabrica.HeaderText = "Fábrica"
        Me.id_fabrica.Name = "id_fabrica"
        Me.id_fabrica.Width = 120
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(46, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Id. producto"
        '
        'txt_idBUSCAR
        '
        Me.txt_idBUSCAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idBUSCAR.Location = New System.Drawing.Point(132, 34)
        Me.txt_idBUSCAR.Mask = "999"
        Me.txt_idBUSCAR.Name = "txt_idBUSCAR"
        Me.txt_idBUSCAR.Size = New System.Drawing.Size(124, 25)
        Me.txt_idBUSCAR.TabIndex = 1
        Me.txt_idBUSCAR.ValidatingType = GetType(Integer)
        '
        'cbo_fabrica
        '
        Me.cbo_fabrica.BackColor = System.Drawing.Color.White
        Me.cbo_fabrica.Enabled = False
        Me.cbo_fabrica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_fabrica.ForeColor = System.Drawing.Color.Black
        Me.cbo_fabrica.FormattingEnabled = True
        Me.cbo_fabrica.Location = New System.Drawing.Point(132, 186)
        Me.cbo_fabrica.Name = "cbo_fabrica"
        Me.cbo_fabrica.Size = New System.Drawing.Size(207, 25)
        Me.cbo_fabrica.TabIndex = 11
        Me.cbo_fabrica.Text = "(seleccione fábrica)"
        '
        'cbo_rubro
        '
        Me.cbo_rubro.BackColor = System.Drawing.Color.White
        Me.cbo_rubro.Enabled = False
        Me.cbo_rubro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_rubro.ForeColor = System.Drawing.Color.Black
        Me.cbo_rubro.FormattingEnabled = True
        Me.cbo_rubro.Location = New System.Drawing.Point(132, 155)
        Me.cbo_rubro.Name = "cbo_rubro"
        Me.cbo_rubro.Size = New System.Drawing.Size(207, 25)
        Me.cbo_rubro.TabIndex = 9
        Me.cbo_rubro.Text = "(seleccione rubro)"
        '
        'lbl_fabrica
        '
        Me.lbl_fabrica.AutoSize = True
        Me.lbl_fabrica.Enabled = False
        Me.lbl_fabrica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fabrica.ForeColor = System.Drawing.Color.Black
        Me.lbl_fabrica.Location = New System.Drawing.Point(59, 189)
        Me.lbl_fabrica.Name = "lbl_fabrica"
        Me.lbl_fabrica.Size = New System.Drawing.Size(67, 17)
        Me.lbl_fabrica.TabIndex = 10
        Me.lbl_fabrica.Text = "Fábrica (*)"
        '
        'lbl_rubro
        '
        Me.lbl_rubro.AutoSize = True
        Me.lbl_rubro.Enabled = False
        Me.lbl_rubro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rubro.ForeColor = System.Drawing.Color.Black
        Me.lbl_rubro.Location = New System.Drawing.Point(65, 158)
        Me.lbl_rubro.Name = "lbl_rubro"
        Me.lbl_rubro.Size = New System.Drawing.Size(61, 17)
        Me.lbl_rubro.TabIndex = 8
        Me.lbl_rubro.Text = "Rubro (*)"
        '
        'txt_precio
        '
        Me.txt_precio.BackColor = System.Drawing.Color.White
        Me.txt_precio.Enabled = False
        Me.txt_precio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio.ForeColor = System.Drawing.Color.Black
        Me.txt_precio.Location = New System.Drawing.Point(132, 124)
        Me.txt_precio.Mask = "99999"
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(124, 25)
        Me.txt_precio.TabIndex = 7
        Me.txt_precio.ValidatingType = GetType(Integer)
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Enabled = False
        Me.lbl_precio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio.ForeColor = System.Drawing.Color.Black
        Me.lbl_precio.Location = New System.Drawing.Point(19, 127)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(107, 17)
        Me.lbl_precio.TabIndex = 6
        Me.lbl_precio.Text = "Precio de lista (*)"
        '
        'txt_stock
        '
        Me.txt_stock.BackColor = System.Drawing.Color.White
        Me.txt_stock.Enabled = False
        Me.txt_stock.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_stock.ForeColor = System.Drawing.Color.Black
        Me.txt_stock.Location = New System.Drawing.Point(132, 93)
        Me.txt_stock.Mask = "99999"
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(124, 25)
        Me.txt_stock.TabIndex = 5
        Me.txt_stock.ValidatingType = GetType(Integer)
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Enabled = False
        Me.lbl_stock.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stock.ForeColor = System.Drawing.Color.Black
        Me.lbl_stock.Location = New System.Drawing.Point(87, 96)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(39, 17)
        Me.lbl_stock.TabIndex = 4
        Me.lbl_stock.Text = "Stock"
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.White
        Me.txt_id.Enabled = False
        Me.txt_id.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.ForeColor = System.Drawing.Color.Black
        Me.txt_id.Location = New System.Drawing.Point(132, 31)
        Me.txt_id.Mask = "9999999999"
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(124, 25)
        Me.txt_id.TabIndex = 1
        '
        'txt_descrip
        '
        Me.txt_descrip.BackColor = System.Drawing.Color.White
        Me.txt_descrip.Enabled = False
        Me.txt_descrip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descrip.ForeColor = System.Drawing.Color.Black
        Me.txt_descrip.Location = New System.Drawing.Point(132, 62)
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.Size = New System.Drawing.Size(207, 25)
        Me.txt_descrip.TabIndex = 3
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Enabled = False
        Me.lbl_descripcion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcion.ForeColor = System.Drawing.Color.Black
        Me.lbl_descripcion.Location = New System.Drawing.Point(50, 65)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(76, 17)
        Me.lbl_descripcion.TabIndex = 2
        Me.lbl_descripcion.Text = "Descripción"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Enabled = False
        Me.lbl_id.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.Black
        Me.lbl_id.Location = New System.Drawing.Point(29, 34)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(97, 17)
        Me.lbl_id.TabIndex = 0
        Me.lbl_id.Text = "Id. producto (*)"
        '
        'gb_listado
        '
        Me.gb_listado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_listado.Controls.Add(Me.dgv_productos)
        Me.gb_listado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_listado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gb_listado.Location = New System.Drawing.Point(12, 50)
        Me.gb_listado.Name = "gb_listado"
        Me.gb_listado.Size = New System.Drawing.Size(725, 574)
        Me.gb_listado.TabIndex = 1
        Me.gb_listado.TabStop = False
        Me.gb_listado.Text = "Listado de Productos"
        '
        'btn_buscarID
        '
        Me.btn_buscarID.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_buscarID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscarID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscarID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_buscarID.Image = Global.PAV1_TPI.My.Resources.Resources.magnifier16
        Me.btn_buscarID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscarID.Location = New System.Drawing.Point(345, 34)
        Me.btn_buscarID.Name = "btn_buscarID"
        Me.btn_buscarID.Size = New System.Drawing.Size(25, 25)
        Me.btn_buscarID.TabIndex = 2
        Me.btn_buscarID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscarID.UseVisualStyleBackColor = True
        '
        'gb_datos
        '
        Me.gb_datos.Controls.Add(Me.Label4)
        Me.gb_datos.Controls.Add(Me.lbl_fabricaERROR)
        Me.gb_datos.Controls.Add(Me.lbl_rubroERROR)
        Me.gb_datos.Controls.Add(Me.lbl_precioERROR)
        Me.gb_datos.Controls.Add(Me.lbl_idERROR)
        Me.gb_datos.Controls.Add(Me.txt_id)
        Me.gb_datos.Controls.Add(Me.lbl_id)
        Me.gb_datos.Controls.Add(Me.lbl_descripcion)
        Me.gb_datos.Controls.Add(Me.txt_descrip)
        Me.gb_datos.Controls.Add(Me.lbl_stock)
        Me.gb_datos.Controls.Add(Me.txt_stock)
        Me.gb_datos.Controls.Add(Me.cbo_fabrica)
        Me.gb_datos.Controls.Add(Me.lbl_precio)
        Me.gb_datos.Controls.Add(Me.cbo_rubro)
        Me.gb_datos.Controls.Add(Me.txt_precio)
        Me.gb_datos.Controls.Add(Me.lbl_fabrica)
        Me.gb_datos.Controls.Add(Me.lbl_rubro)
        Me.gb_datos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_datos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gb_datos.Location = New System.Drawing.Point(746, 50)
        Me.gb_datos.Name = "gb_datos"
        Me.gb_datos.Size = New System.Drawing.Size(382, 262)
        Me.gb_datos.TabIndex = 4
        Me.gb_datos.TabStop = False
        Me.gb_datos.Text = "Datos del Producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(344, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Observación: Los campos marcados con (*) son obligatorios."
        '
        'lbl_fabricaERROR
        '
        Me.lbl_fabricaERROR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fabricaERROR.ForeColor = System.Drawing.Color.Black
        Me.lbl_fabricaERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_fabricaERROR.Location = New System.Drawing.Point(345, 189)
        Me.lbl_fabricaERROR.Name = "lbl_fabricaERROR"
        Me.lbl_fabricaERROR.Size = New System.Drawing.Size(17, 17)
        Me.lbl_fabricaERROR.TabIndex = 15
        Me.lbl_fabricaERROR.Visible = False
        '
        'lbl_rubroERROR
        '
        Me.lbl_rubroERROR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rubroERROR.ForeColor = System.Drawing.Color.Black
        Me.lbl_rubroERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_rubroERROR.Location = New System.Drawing.Point(345, 158)
        Me.lbl_rubroERROR.Name = "lbl_rubroERROR"
        Me.lbl_rubroERROR.Size = New System.Drawing.Size(17, 17)
        Me.lbl_rubroERROR.TabIndex = 14
        Me.lbl_rubroERROR.Visible = False
        '
        'lbl_precioERROR
        '
        Me.lbl_precioERROR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precioERROR.ForeColor = System.Drawing.Color.Black
        Me.lbl_precioERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_precioERROR.Location = New System.Drawing.Point(262, 127)
        Me.lbl_precioERROR.Name = "lbl_precioERROR"
        Me.lbl_precioERROR.Size = New System.Drawing.Size(17, 17)
        Me.lbl_precioERROR.TabIndex = 14
        Me.lbl_precioERROR.Visible = False
        '
        'lbl_idERROR
        '
        Me.lbl_idERROR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idERROR.ForeColor = System.Drawing.Color.Black
        Me.lbl_idERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_idERROR.Location = New System.Drawing.Point(262, 34)
        Me.lbl_idERROR.Name = "lbl_idERROR"
        Me.lbl_idERROR.Size = New System.Drawing.Size(17, 17)
        Me.lbl_idERROR.TabIndex = 13
        Me.lbl_idERROR.Visible = False
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1148, 47)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "  Administración de Productos"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_msj
        '
        Me.lbl_msj.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lbl_msj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_msj.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_msj.ForeColor = System.Drawing.Color.White
        Me.lbl_msj.Location = New System.Drawing.Point(746, 514)
        Me.lbl_msj.Name = "lbl_msj"
        Me.lbl_msj.Size = New System.Drawing.Size(382, 35)
        Me.lbl_msj.TabIndex = 0
        Me.lbl_msj.Text = " Mensajes"
        Me.lbl_msj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_guardar
        '
        Me.btn_guardar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_guardar.Image = Global.PAV1_TPI.My.Resources.Resources.check_mark
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.Location = New System.Drawing.Point(968, 318)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(105, 45)
        Me.btn_guardar.TabIndex = 6
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_eliminar.Image = Global.PAV1_TPI.My.Resources.Resources.trash_bin32
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.Location = New System.Drawing.Point(857, 318)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(105, 45)
        Me.btn_eliminar.TabIndex = 5
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_nuevo.Image = Global.PAV1_TPI.My.Resources.Resources.plus_circular_button32
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo.Location = New System.Drawing.Point(746, 318)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(105, 45)
        Me.btn_nuevo.TabIndex = 2
        Me.btn_nuevo.Tag = ""
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'gb_busqueda
        '
        Me.gb_busqueda.Controls.Add(Me.btn_buscarFABRICA)
        Me.gb_busqueda.Controls.Add(Me.btn_buscarRUBRO)
        Me.gb_busqueda.Controls.Add(Me.btn_buscarID)
        Me.gb_busqueda.Controls.Add(Me.cbo_fabricaBUSCAR)
        Me.gb_busqueda.Controls.Add(Me.cbo_rubroBUSCAR)
        Me.gb_busqueda.Controls.Add(Me.Label1)
        Me.gb_busqueda.Controls.Add(Me.Label2)
        Me.gb_busqueda.Controls.Add(Me.Label7)
        Me.gb_busqueda.Controls.Add(Me.txt_idBUSCAR)
        Me.gb_busqueda.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_busqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gb_busqueda.Location = New System.Drawing.Point(746, 378)
        Me.gb_busqueda.Name = "gb_busqueda"
        Me.gb_busqueda.Size = New System.Drawing.Size(382, 133)
        Me.gb_busqueda.TabIndex = 7
        Me.gb_busqueda.TabStop = False
        Me.gb_busqueda.Text = "Búsqueda"
        '
        'btn_buscarFABRICA
        '
        Me.btn_buscarFABRICA.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_buscarFABRICA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscarFABRICA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscarFABRICA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_buscarFABRICA.Image = Global.PAV1_TPI.My.Resources.Resources.magnifier16
        Me.btn_buscarFABRICA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscarFABRICA.Location = New System.Drawing.Point(345, 96)
        Me.btn_buscarFABRICA.Name = "btn_buscarFABRICA"
        Me.btn_buscarFABRICA.Size = New System.Drawing.Size(25, 25)
        Me.btn_buscarFABRICA.TabIndex = 16
        Me.btn_buscarFABRICA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscarFABRICA.UseVisualStyleBackColor = True
        '
        'btn_buscarRUBRO
        '
        Me.btn_buscarRUBRO.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_buscarRUBRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscarRUBRO.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscarRUBRO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_buscarRUBRO.Image = Global.PAV1_TPI.My.Resources.Resources.magnifier16
        Me.btn_buscarRUBRO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscarRUBRO.Location = New System.Drawing.Point(345, 65)
        Me.btn_buscarRUBRO.Name = "btn_buscarRUBRO"
        Me.btn_buscarRUBRO.Size = New System.Drawing.Size(25, 25)
        Me.btn_buscarRUBRO.TabIndex = 8
        Me.btn_buscarRUBRO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscarRUBRO.UseVisualStyleBackColor = True
        '
        'cbo_fabricaBUSCAR
        '
        Me.cbo_fabricaBUSCAR.BackColor = System.Drawing.Color.White
        Me.cbo_fabricaBUSCAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_fabricaBUSCAR.ForeColor = System.Drawing.Color.Black
        Me.cbo_fabricaBUSCAR.FormattingEnabled = True
        Me.cbo_fabricaBUSCAR.Location = New System.Drawing.Point(132, 96)
        Me.cbo_fabricaBUSCAR.Name = "cbo_fabricaBUSCAR"
        Me.cbo_fabricaBUSCAR.Size = New System.Drawing.Size(207, 25)
        Me.cbo_fabricaBUSCAR.TabIndex = 15
        Me.cbo_fabricaBUSCAR.Text = "(seleccione fábrica)"
        '
        'cbo_rubroBUSCAR
        '
        Me.cbo_rubroBUSCAR.BackColor = System.Drawing.Color.White
        Me.cbo_rubroBUSCAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_rubroBUSCAR.ForeColor = System.Drawing.Color.Black
        Me.cbo_rubroBUSCAR.FormattingEnabled = True
        Me.cbo_rubroBUSCAR.Location = New System.Drawing.Point(132, 65)
        Me.cbo_rubroBUSCAR.Name = "cbo_rubroBUSCAR"
        Me.cbo_rubroBUSCAR.Size = New System.Drawing.Size(207, 25)
        Me.cbo_rubroBUSCAR.TabIndex = 13
        Me.cbo_rubroBUSCAR.Text = "(seleccione rubro)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(76, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Fábrica"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(82, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Rubro"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Image = Global.PAV1_TPI.My.Resources.Resources.clotta_nombre
        Me.Label3.Location = New System.Drawing.Point(1019, 591)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 33)
        Me.Label3.TabIndex = 16
        '
        'FormProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1148, 636)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gb_busqueda)
        Me.Controls.Add(Me.lbl_msj)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.gb_datos)
        Me.Controls.Add(Me.gb_listado)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLOTTA Productos"
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_listado.ResumeLayout(False)
        Me.gb_datos.ResumeLayout(False)
        Me.gb_datos.PerformLayout()
        Me.gb_busqueda.ResumeLayout(False)
        Me.gb_busqueda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_productos As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_idBUSCAR As MaskedTextBox
    Friend WithEvents cbo_fabrica As ComboBox
    Friend WithEvents cbo_rubro As ComboBox
    Friend WithEvents lbl_fabrica As Label
    Friend WithEvents lbl_rubro As Label
    Friend WithEvents txt_precio As MaskedTextBox
    Friend WithEvents lbl_precio As Label
    Friend WithEvents txt_stock As MaskedTextBox
    Friend WithEvents lbl_stock As Label
    Friend WithEvents txt_id As MaskedTextBox
    Friend WithEvents txt_descrip As TextBox
    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents gb_listado As GroupBox
    Friend WithEvents gb_datos As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_buscarID As Button
    Friend WithEvents lbl_msj As Label
    Friend WithEvents lbl_idERROR As Label
    Friend WithEvents id_producto As DataGridViewTextBoxColumn
    Friend WithEvents descrip As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents precio_lista As DataGridViewTextBoxColumn
    Friend WithEvents id_rubro As DataGridViewTextBoxColumn
    Friend WithEvents id_fabrica As DataGridViewTextBoxColumn
    Friend WithEvents lbl_fabricaERROR As Label
    Friend WithEvents lbl_rubroERROR As Label
    Friend WithEvents lbl_precioERROR As Label
    Friend WithEvents gb_busqueda As GroupBox
    Friend WithEvents cbo_fabricaBUSCAR As ComboBox
    Friend WithEvents cbo_rubroBUSCAR As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_buscarFABRICA As Button
    Friend WithEvents btn_buscarRUBRO As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
