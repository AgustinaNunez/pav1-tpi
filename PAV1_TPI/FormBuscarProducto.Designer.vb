<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuscarProducto))
        Me.gb_busqueda = New System.Windows.Forms.GroupBox()
        Me.btn_buscarFABRICA = New System.Windows.Forms.Button()
        Me.btn_buscarRUBRO = New System.Windows.Forms.Button()
        Me.btn_buscarID = New System.Windows.Forms.Button()
        Me.cbo_fabricaBUSCAR = New System.Windows.Forms.ComboBox()
        Me.cbo_rubroBUSCAR = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_idBUSCAR = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gb_listado = New System.Windows.Forms.GroupBox()
        Me.dgv_productos = New System.Windows.Forms.DataGridView()
        Me.id_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_lista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_rubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_fabrica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_producto = New System.Windows.Forms.Label()
        Me.btn_seleccionar = New System.Windows.Forms.Button()
        Me.gb_busqueda.SuspendLayout()
        Me.gb_listado.SuspendLayout()
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.gb_busqueda.Location = New System.Drawing.Point(743, 12)
        Me.gb_busqueda.Name = "gb_busqueda"
        Me.gb_busqueda.Size = New System.Drawing.Size(335, 133)
        Me.gb_busqueda.TabIndex = 18
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
        Me.btn_buscarFABRICA.Location = New System.Drawing.Point(284, 91)
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
        Me.btn_buscarRUBRO.Location = New System.Drawing.Point(284, 60)
        Me.btn_buscarRUBRO.Name = "btn_buscarRUBRO"
        Me.btn_buscarRUBRO.Size = New System.Drawing.Size(25, 25)
        Me.btn_buscarRUBRO.TabIndex = 8
        Me.btn_buscarRUBRO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscarRUBRO.UseVisualStyleBackColor = True
        '
        'btn_buscarID
        '
        Me.btn_buscarID.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_buscarID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscarID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscarID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_buscarID.Image = Global.PAV1_TPI.My.Resources.Resources.magnifier16
        Me.btn_buscarID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscarID.Location = New System.Drawing.Point(284, 29)
        Me.btn_buscarID.Name = "btn_buscarID"
        Me.btn_buscarID.Size = New System.Drawing.Size(25, 25)
        Me.btn_buscarID.TabIndex = 2
        Me.btn_buscarID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscarID.UseVisualStyleBackColor = True
        '
        'cbo_fabricaBUSCAR
        '
        Me.cbo_fabricaBUSCAR.BackColor = System.Drawing.Color.White
        Me.cbo_fabricaBUSCAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_fabricaBUSCAR.ForeColor = System.Drawing.Color.Black
        Me.cbo_fabricaBUSCAR.FormattingEnabled = True
        Me.cbo_fabricaBUSCAR.Location = New System.Drawing.Point(102, 91)
        Me.cbo_fabricaBUSCAR.Name = "cbo_fabricaBUSCAR"
        Me.cbo_fabricaBUSCAR.Size = New System.Drawing.Size(176, 25)
        Me.cbo_fabricaBUSCAR.TabIndex = 15
        Me.cbo_fabricaBUSCAR.Text = "(seleccione fábrica)"
        '
        'cbo_rubroBUSCAR
        '
        Me.cbo_rubroBUSCAR.BackColor = System.Drawing.Color.White
        Me.cbo_rubroBUSCAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_rubroBUSCAR.ForeColor = System.Drawing.Color.Black
        Me.cbo_rubroBUSCAR.FormattingEnabled = True
        Me.cbo_rubroBUSCAR.Location = New System.Drawing.Point(102, 60)
        Me.cbo_rubroBUSCAR.Name = "cbo_rubroBUSCAR"
        Me.cbo_rubroBUSCAR.Size = New System.Drawing.Size(176, 25)
        Me.cbo_rubroBUSCAR.TabIndex = 13
        Me.cbo_rubroBUSCAR.Text = "(seleccione rubro)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(46, 94)
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
        Me.Label2.Location = New System.Drawing.Point(52, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Rubro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Id. producto"
        '
        'txt_idBUSCAR
        '
        Me.txt_idBUSCAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idBUSCAR.Location = New System.Drawing.Point(102, 29)
        Me.txt_idBUSCAR.Mask = "999"
        Me.txt_idBUSCAR.Name = "txt_idBUSCAR"
        Me.txt_idBUSCAR.Size = New System.Drawing.Size(102, 25)
        Me.txt_idBUSCAR.TabIndex = 1
        Me.txt_idBUSCAR.ValidatingType = GetType(Integer)
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Image = Global.PAV1_TPI.My.Resources.Resources.clotta_nombre
        Me.Label3.Location = New System.Drawing.Point(969, 384)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 33)
        Me.Label3.TabIndex = 20
        '
        'gb_listado
        '
        Me.gb_listado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_listado.Controls.Add(Me.dgv_productos)
        Me.gb_listado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_listado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gb_listado.Location = New System.Drawing.Point(12, 12)
        Me.gb_listado.Name = "gb_listado"
        Me.gb_listado.Size = New System.Drawing.Size(725, 405)
        Me.gb_listado.TabIndex = 21
        Me.gb_listado.TabStop = False
        Me.gb_listado.Text = "Listado de Productos"
        '
        'dgv_productos
        '
        Me.dgv_productos.AllowUserToAddRows = False
        Me.dgv_productos.AllowUserToDeleteRows = False
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
        Me.dgv_productos.ReadOnly = True
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
        Me.dgv_productos.Size = New System.Drawing.Size(683, 357)
        Me.dgv_productos.TabIndex = 3
        '
        'id_producto
        '
        Me.id_producto.HeaderText = "Id."
        Me.id_producto.Name = "id_producto"
        Me.id_producto.ReadOnly = True
        Me.id_producto.Width = 50
        '
        'descrip
        '
        Me.descrip.HeaderText = "Descripción"
        Me.descrip.Name = "descrip"
        Me.descrip.ReadOnly = True
        Me.descrip.Width = 210
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.ReadOnly = True
        Me.stock.Width = 60
        '
        'precio_lista
        '
        Me.precio_lista.HeaderText = "Precio"
        Me.precio_lista.Name = "precio_lista"
        Me.precio_lista.ReadOnly = True
        Me.precio_lista.Width = 60
        '
        'id_rubro
        '
        Me.id_rubro.HeaderText = "Rubro"
        Me.id_rubro.Name = "id_rubro"
        Me.id_rubro.ReadOnly = True
        Me.id_rubro.Width = 120
        '
        'id_fabrica
        '
        Me.id_fabrica.HeaderText = "Fábrica"
        Me.id_fabrica.Name = "id_fabrica"
        Me.id_fabrica.ReadOnly = True
        Me.id_fabrica.Width = 120
        '
        'lbl_producto
        '
        Me.lbl_producto.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lbl_producto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_producto.ForeColor = System.Drawing.Color.White
        Me.lbl_producto.Location = New System.Drawing.Point(743, 148)
        Me.lbl_producto.Name = "lbl_producto"
        Me.lbl_producto.Size = New System.Drawing.Size(335, 33)
        Me.lbl_producto.TabIndex = 4
        Me.lbl_producto.Text = "lbl_producto"
        Me.lbl_producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_seleccionar
        '
        Me.btn_seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_seleccionar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_seleccionar.Image = Global.PAV1_TPI.My.Resources.Resources.check_mark
        Me.btn_seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_seleccionar.Location = New System.Drawing.Point(743, 194)
        Me.btn_seleccionar.Name = "btn_seleccionar"
        Me.btn_seleccionar.Size = New System.Drawing.Size(122, 45)
        Me.btn_seleccionar.TabIndex = 22
        Me.btn_seleccionar.Text = "Seleccionar"
        Me.btn_seleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_seleccionar.UseVisualStyleBackColor = True
        '
        'FormBuscarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1092, 429)
        Me.Controls.Add(Me.lbl_producto)
        Me.Controls.Add(Me.btn_seleccionar)
        Me.Controls.Add(Me.gb_listado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gb_busqueda)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormBuscarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.gb_busqueda.ResumeLayout(False)
        Me.gb_busqueda.PerformLayout()
        Me.gb_listado.ResumeLayout(False)
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_busqueda As GroupBox
    Friend WithEvents btn_buscarFABRICA As Button
    Friend WithEvents btn_buscarRUBRO As Button
    Friend WithEvents btn_buscarID As Button
    Friend WithEvents cbo_fabricaBUSCAR As ComboBox
    Friend WithEvents cbo_rubroBUSCAR As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_idBUSCAR As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gb_listado As GroupBox
    Friend WithEvents dgv_productos As DataGridView
    Friend WithEvents id_producto As DataGridViewTextBoxColumn
    Friend WithEvents descrip As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents precio_lista As DataGridViewTextBoxColumn
    Friend WithEvents id_rubro As DataGridViewTextBoxColumn
    Friend WithEvents id_fabrica As DataGridViewTextBoxColumn
    Friend WithEvents btn_seleccionar As Button
    Friend WithEvents lbl_producto As Label
End Class
