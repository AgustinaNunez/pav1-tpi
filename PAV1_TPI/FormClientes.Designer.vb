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
        Me.btn_buscar_cliente = New System.Windows.Forms.Button()
        Me.grid_clientes = New System.Windows.Forms.DataGridView()
        Me.col_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipo_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_numero_documento_cliente_busqueda = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_numero_documento_carga = New System.Windows.Forms.TextBox()
        CType(Me.grid_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_nuevo_cliente_carga
        '
        Me.btn_nuevo_cliente_carga.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_nuevo_cliente_carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo_cliente_carga.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_nuevo_cliente_carga.Location = New System.Drawing.Point(714, 327)
        Me.btn_nuevo_cliente_carga.Name = "btn_nuevo_cliente_carga"
        Me.btn_nuevo_cliente_carga.Size = New System.Drawing.Size(150, 35)
        Me.btn_nuevo_cliente_carga.TabIndex = 6
        Me.btn_nuevo_cliente_carga.Text = "Nuevo Cliente"
        Me.btn_nuevo_cliente_carga.UseVisualStyleBackColor = False
        '
        'btn_eliminar_cliente_carga
        '
        Me.btn_eliminar_cliente_carga.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_eliminar_cliente_carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar_cliente_carga.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_eliminar_cliente_carga.Location = New System.Drawing.Point(714, 410)
        Me.btn_eliminar_cliente_carga.Name = "btn_eliminar_cliente_carga"
        Me.btn_eliminar_cliente_carga.Size = New System.Drawing.Size(150, 35)
        Me.btn_eliminar_cliente_carga.TabIndex = 8
        Me.btn_eliminar_cliente_carga.Text = "Eliminar Cliente"
        Me.btn_eliminar_cliente_carga.UseVisualStyleBackColor = False
        '
        'btn_guardar_cliente_carga
        '
        Me.btn_guardar_cliente_carga.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_guardar_cliente_carga.Enabled = False
        Me.btn_guardar_cliente_carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar_cliente_carga.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_guardar_cliente_carga.Location = New System.Drawing.Point(714, 369)
        Me.btn_guardar_cliente_carga.Name = "btn_guardar_cliente_carga"
        Me.btn_guardar_cliente_carga.Size = New System.Drawing.Size(150, 35)
        Me.btn_guardar_cliente_carga.TabIndex = 7
        Me.btn_guardar_cliente_carga.Text = "Guardar Cliente"
        Me.btn_guardar_cliente_carga.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(760, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apellido"
        '
        'txt_apellido_cliente_carga
        '
        Me.txt_apellido_cliente_carga.Enabled = False
        Me.txt_apellido_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellido_cliente_carga.Location = New System.Drawing.Point(822, 99)
        Me.txt_apellido_cliente_carga.Name = "txt_apellido_cliente_carga"
        Me.txt_apellido_cliente_carga.Size = New System.Drawing.Size(237, 25)
        Me.txt_apellido_cliente_carga.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(759, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txt_nombre_cliente_carga
        '
        Me.txt_nombre_cliente_carga.Enabled = False
        Me.txt_nombre_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_cliente_carga.Location = New System.Drawing.Point(822, 130)
        Me.txt_nombre_cliente_carga.Name = "txt_nombre_cliente_carga"
        Me.txt_nombre_cliente_carga.Size = New System.Drawing.Size(237, 25)
        Me.txt_nombre_cliente_carga.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(711, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(741, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Documento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(770, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "E-mail"
        '
        'txt_email_cliente_cliente_carga
        '
        Me.txt_email_cliente_cliente_carga.Enabled = False
        Me.txt_email_cliente_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email_cliente_cliente_carga.Location = New System.Drawing.Point(822, 223)
        Me.txt_email_cliente_cliente_carga.Name = "txt_email_cliente_cliente_carga"
        Me.txt_email_cliente_cliente_carga.Size = New System.Drawing.Size(237, 25)
        Me.txt_email_cliente_cliente_carga.TabIndex = 4
        '
        'cmb_tipo_documento_cliente_carga
        '
        Me.cmb_tipo_documento_cliente_carga.Enabled = False
        Me.cmb_tipo_documento_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_documento_cliente_carga.FormattingEnabled = True
        Me.cmb_tipo_documento_cliente_carga.Location = New System.Drawing.Point(822, 161)
        Me.cmb_tipo_documento_cliente_carga.Name = "cmb_tipo_documento_cliente_carga"
        Me.cmb_tipo_documento_cliente_carga.Size = New System.Drawing.Size(237, 25)
        Me.cmb_tipo_documento_cliente_carga.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(758, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Teléfono"
        '
        'txt_telefono_cliente_carga
        '
        Me.txt_telefono_cliente_carga.Enabled = False
        Me.txt_telefono_cliente_carga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono_cliente_carga.Location = New System.Drawing.Point(822, 254)
        Me.txt_telefono_cliente_carga.Mask = "99999999999"
        Me.txt_telefono_cliente_carga.Name = "txt_telefono_cliente_carga"
        Me.txt_telefono_cliente_carga.Size = New System.Drawing.Size(91, 25)
        Me.txt_telefono_cliente_carga.TabIndex = 5
        '
        'cmb_tipo_documento_cliente_busqueda
        '
        Me.cmb_tipo_documento_cliente_busqueda.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_documento_cliente_busqueda.FormattingEnabled = True
        Me.cmb_tipo_documento_cliente_busqueda.Location = New System.Drawing.Point(127, 44)
        Me.cmb_tipo_documento_cliente_busqueda.Name = "cmb_tipo_documento_cliente_busqueda"
        Me.cmb_tipo_documento_cliente_busqueda.Size = New System.Drawing.Size(111, 25)
        Me.cmb_tipo_documento_cliente_busqueda.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(300, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Documento"
        '
        'btn_buscar_cliente
        '
        Me.btn_buscar_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_buscar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar_cliente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar_cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_buscar_cliente.Location = New System.Drawing.Point(540, 40)
        Me.btn_buscar_cliente.Name = "btn_buscar_cliente"
        Me.btn_buscar_cliente.Size = New System.Drawing.Size(140, 30)
        Me.btn_buscar_cliente.TabIndex = 2
        Me.btn_buscar_cliente.Text = "Buscar Cliente"
        Me.btn_buscar_cliente.UseVisualStyleBackColor = False
        '
        'grid_clientes
        '
        Me.grid_clientes.AllowUserToAddRows = False
        Me.grid_clientes.AllowUserToDeleteRows = False
        Me.grid_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_apellido, Me.col_nombre, Me.col_tipo_documento, Me.col_documento, Me.col_email, Me.col_telefono})
        Me.grid_clientes.Location = New System.Drawing.Point(18, 104)
        Me.grid_clientes.Name = "grid_clientes"
        Me.grid_clientes.ReadOnly = True
        Me.grid_clientes.Size = New System.Drawing.Size(643, 445)
        Me.grid_clientes.TabIndex = 3
        '
        'col_apellido
        '
        Me.col_apellido.HeaderText = "Apellido"
        Me.col_apellido.Name = "col_apellido"
        Me.col_apellido.ReadOnly = True
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        '
        'col_tipo_documento
        '
        Me.col_tipo_documento.HeaderText = "Tipo Documento"
        Me.col_tipo_documento.Name = "col_tipo_documento"
        Me.col_tipo_documento.ReadOnly = True
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
        '
        'col_telefono
        '
        Me.col_telefono.HeaderText = "Telefono"
        Me.col_telefono.Name = "col_telefono"
        Me.col_telefono.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Tipo Documento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(739, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(145, 25)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Carga de datos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_numero_documento_cliente_busqueda)
        Me.GroupBox1.Controls.Add(Me.grid_clientes)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmb_tipo_documento_cliente_busqueda)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_cliente)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 578)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Clientes"
        '
        'txt_numero_documento_cliente_busqueda
        '
        Me.txt_numero_documento_cliente_busqueda.Location = New System.Drawing.Point(381, 44)
        Me.txt_numero_documento_cliente_busqueda.Name = "txt_numero_documento_cliente_busqueda"
        Me.txt_numero_documento_cliente_busqueda.Size = New System.Drawing.Size(100, 25)
        Me.txt_numero_documento_cliente_busqueda.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(703, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(750, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 17)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(750, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 17)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(731, 197)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 17)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(760, 295)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 17)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "* Campos obligatorios"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(425, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(248, 25)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Administración de Clientes"
        '
        'txt_numero_documento_carga
        '
        Me.txt_numero_documento_carga.Enabled = False
        Me.txt_numero_documento_carga.Location = New System.Drawing.Point(822, 192)
        Me.txt_numero_documento_carga.Name = "txt_numero_documento_carga"
        Me.txt_numero_documento_carga.Size = New System.Drawing.Size(237, 25)
        Me.txt_numero_documento_carga.TabIndex = 3
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1095, 643)
        Me.Controls.Add(Me.txt_numero_documento_carga)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_telefono_cliente_carga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_guardar_cliente_carga)
        Me.Controls.Add(Me.cmb_tipo_documento_cliente_carga)
        Me.Controls.Add(Me.btn_eliminar_cliente_carga)
        Me.Controls.Add(Me.txt_email_cliente_cliente_carga)
        Me.Controls.Add(Me.btn_nuevo_cliente_carga)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_apellido_cliente_carga)
        Me.Controls.Add(Me.txt_nombre_cliente_carga)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLOTTA Clientes"
        CType(Me.grid_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents btn_buscar_cliente As System.Windows.Forms.Button
    Friend WithEvents grid_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents col_apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tipo_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_numero_documento_cliente_busqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_documento_carga As System.Windows.Forms.TextBox
End Class
