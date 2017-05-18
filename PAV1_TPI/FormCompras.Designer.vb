<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCompras))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_id_compra = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.txt_monto = New System.Windows.Forms.TextBox()
        Me.grid_compras = New System.Windows.Forms.DataGridView()
        Me.cmb_producto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.col_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        CType(Me.grid_compras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nro. Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(243, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(415, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(20, 431)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total a pagar"
        '
        'txt_id_compra
        '
        Me.txt_id_compra.Enabled = False
        Me.txt_id_compra.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_compra.ForeColor = System.Drawing.Color.Black
        Me.txt_id_compra.Location = New System.Drawing.Point(119, 34)
        Me.txt_id_compra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_id_compra.Name = "txt_id_compra"
        Me.txt_id_compra.Size = New System.Drawing.Size(98, 25)
        Me.txt_id_compra.TabIndex = 0
        '
        'txt_fecha
        '
        Me.txt_fecha.Enabled = False
        Me.txt_fecha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha.ForeColor = System.Drawing.Color.Black
        Me.txt_fecha.Location = New System.Drawing.Point(290, 34)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(98, 25)
        Me.txt_fecha.TabIndex = 1
        '
        'txt_hora
        '
        Me.txt_hora.Enabled = False
        Me.txt_hora.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hora.ForeColor = System.Drawing.Color.Black
        Me.txt_hora.Location = New System.Drawing.Point(457, 34)
        Me.txt_hora.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(98, 25)
        Me.txt_hora.TabIndex = 2
        '
        'txt_monto
        '
        Me.txt_monto.Enabled = False
        Me.txt_monto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_monto.ForeColor = System.Drawing.Color.Black
        Me.txt_monto.Location = New System.Drawing.Point(112, 428)
        Me.txt_monto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Size = New System.Drawing.Size(98, 25)
        Me.txt_monto.TabIndex = 3
        '
        'grid_compras
        '
        Me.grid_compras.AllowUserToAddRows = False
        Me.grid_compras.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_compras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_compras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grid_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_compras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_producto, Me.col_cantidad, Me.col_precio, Me.col_id_producto})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_compras.DefaultCellStyle = DataGridViewCellStyle3
        Me.grid_compras.Enabled = False
        Me.grid_compras.Location = New System.Drawing.Point(18, 122)
        Me.grid_compras.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grid_compras.Name = "grid_compras"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_compras.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grid_compras.Size = New System.Drawing.Size(645, 196)
        Me.grid_compras.TabIndex = 8
        '
        'cmb_producto
        '
        Me.cmb_producto.Enabled = False
        Me.cmb_producto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_producto.ForeColor = System.Drawing.Color.Black
        Me.cmb_producto.FormattingEnabled = True
        Me.cmb_producto.Location = New System.Drawing.Point(82, 36)
        Me.cmb_producto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmb_producto.Name = "cmb_producto"
        Me.cmb_producto.Size = New System.Drawing.Size(221, 25)
        Me.cmb_producto.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(524, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Cantidad"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Enabled = False
        Me.txt_cantidad.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.ForeColor = System.Drawing.Color.Black
        Me.txt_cantidad.Location = New System.Drawing.Point(590, 35)
        Me.txt_cantidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(73, 25)
        Me.txt_cantidad.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(309, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Precio de compra"
        '
        'txt_precio
        '
        Me.txt_precio.Enabled = False
        Me.txt_precio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio.ForeColor = System.Drawing.Color.Black
        Me.txt_precio.Location = New System.Drawing.Point(422, 35)
        Me.txt_precio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(96, 25)
        Me.txt_precio.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txt_id_compra)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Controls.Add(Me.txt_hora)
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Controls.Add(Me.txt_fecha)
        Me.GroupBox1.Controls.Add(Me.txt_monto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(729, 544)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Compra"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btn_eliminar)
        Me.GroupBox2.Controls.Add(Me.cmb_producto)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_cantidad)
        Me.GroupBox2.Controls.Add(Me.txt_precio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.grid_compras)
        Me.GroupBox2.Controls.Add(Me.btn_agregar)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(20, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(685, 336)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles de la Compra"
        '
        'btn_agregar
        '
        Me.btn_agregar.Enabled = False
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_agregar.Image = Global.PAV1_TPI.My.Resources.Resources.plus_circular_button32
        Me.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregar.Location = New System.Drawing.Point(18, 70)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(105, 45)
        Me.btn_agregar.TabIndex = 5
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(455, 47)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "  Registro de Compra"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Image = Global.PAV1_TPI.My.Resources.Resources.clotta_nombre
        Me.Label9.Location = New System.Drawing.Point(596, 480)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 33)
        Me.Label9.TabIndex = 17
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_nuevo.Image = Global.PAV1_TPI.My.Resources.Resources.plus_circular_button32
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo.Location = New System.Drawing.Point(20, 468)
        Me.btn_nuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(105, 45)
        Me.btn_nuevo.TabIndex = 1
        Me.btn_nuevo.Text = "Nueva"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_guardar.Image = Global.PAV1_TPI.My.Resources.Resources.check_mark
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.Location = New System.Drawing.Point(131, 468)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(105, 45)
        Me.btn_guardar.TabIndex = 3
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'col_producto
        '
        Me.col_producto.HeaderText = "Producto"
        Me.col_producto.Name = "col_producto"
        Me.col_producto.ReadOnly = True
        Me.col_producto.Width = 300
        '
        'col_cantidad
        '
        Me.col_cantidad.HeaderText = "Cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        '
        'col_precio
        '
        Me.col_precio.HeaderText = "Precio de compra"
        Me.col_precio.Name = "col_precio"
        Me.col_precio.Width = 150
        '
        'col_id_producto
        '
        Me.col_id_producto.HeaderText = "id_producto"
        Me.col_id_producto.Name = "col_id_producto"
        Me.col_id_producto.Visible = False
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
        Me.Button1.Location = New System.Drawing.Point(240, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 45)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Guardar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_eliminar.Image = Global.PAV1_TPI.My.Resources.Resources.trash_bin32
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.Location = New System.Drawing.Point(129, 70)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(105, 45)
        Me.btn_eliminar.TabIndex = 9
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'FormCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(755, 614)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Compras"
        CType(Me.grid_compras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_id_compra As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents txt_monto As System.Windows.Forms.TextBox
    Friend WithEvents grid_compras As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents col_producto As DataGridViewTextBoxColumn
    Friend WithEvents col_cantidad As DataGridViewTextBoxColumn
    Friend WithEvents col_precio As DataGridViewTextBoxColumn
    Friend WithEvents col_id_producto As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_eliminar As Button
End Class
