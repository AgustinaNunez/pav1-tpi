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
        Me.col_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_producto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.grid_compras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Hora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(455, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Monto"
        '
        'txt_id_compra
        '
        Me.txt_id_compra.Location = New System.Drawing.Point(67, 22)
        Me.txt_id_compra.Name = "txt_id_compra"
        Me.txt_id_compra.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_compra.TabIndex = 1
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(207, 22)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha.TabIndex = 1
        '
        'txt_hora
        '
        Me.txt_hora.Enabled = False
        Me.txt_hora.Location = New System.Drawing.Point(349, 22)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(100, 20)
        Me.txt_hora.TabIndex = 1
        '
        'txt_monto
        '
        Me.txt_monto.Enabled = False
        Me.txt_monto.Location = New System.Drawing.Point(490, 22)
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Size = New System.Drawing.Size(75, 20)
        Me.txt_monto.TabIndex = 1
        '
        'grid_compras
        '
        Me.grid_compras.AllowUserToAddRows = False
        Me.grid_compras.AllowUserToDeleteRows = False
        Me.grid_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_compras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_producto, Me.col_cantidad, Me.col_precio})
        Me.grid_compras.Location = New System.Drawing.Point(10, 157)
        Me.grid_compras.Name = "grid_compras"
        Me.grid_compras.ReadOnly = True
        Me.grid_compras.Size = New System.Drawing.Size(553, 200)
        Me.grid_compras.TabIndex = 2
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
        Me.col_cantidad.ReadOnly = True
        '
        'col_precio
        '
        Me.col_precio.HeaderText = "Precio"
        Me.col_precio.Name = "col_precio"
        Me.col_precio.ReadOnly = True
        '
        'cmb_producto
        '
        Me.cmb_producto.FormattingEnabled = True
        Me.cmb_producto.Location = New System.Drawing.Point(64, 73)
        Me.cmb_producto.Name = "cmb_producto"
        Me.cmb_producto.Size = New System.Drawing.Size(201, 21)
        Me.cmb_producto.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cantidad"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(64, 101)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(201, 20)
        Me.txt_cantidad.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Precio"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(64, 131)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(201, 20)
        Me.txt_precio.TabIndex = 1
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(297, 101)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 5
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_guardar.Location = New System.Drawing.Point(15, 377)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 5
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(108, 377)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 5
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'FormCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 414)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_producto)
        Me.Controls.Add(Me.grid_compras)
        Me.Controls.Add(Me.txt_monto)
        Me.Controls.Add(Me.txt_hora)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.txt_id_compra)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCompras"
        Me.Text = "Gestión de Compras"
        CType(Me.grid_compras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents col_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_precio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
