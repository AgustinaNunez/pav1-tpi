<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUsuarios))
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grilla_usuarios = New System.Windows.Forms.DataGridView()
        Me.id_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_alta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_fecha_alta = New System.Windows.Forms.MaskedTextBox()
        Me.txt_contraseña2 = New System.Windows.Forms.TextBox()
        Me.txt_contraseña1 = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_buscar_usuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id_usuario = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.groupBox = New System.Windows.Forms.GroupBox()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_grabar = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        CType(Me.grilla_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(200, 286)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 17)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(200, 253)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 17)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(200, 217)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 17)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "*"
        '
        'grilla_usuarios
        '
        Me.grilla_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_usuario, Me.nombre, Me.apellido, Me.fecha_alta})
        Me.grilla_usuarios.Location = New System.Drawing.Point(30, 89)
        Me.grilla_usuarios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grilla_usuarios.Name = "grilla_usuarios"
        Me.grilla_usuarios.Size = New System.Drawing.Size(443, 300)
        Me.grilla_usuarios.TabIndex = 27
        '
        'id_usuario
        '
        Me.id_usuario.HeaderText = "User Name"
        Me.id_usuario.Name = "id_usuario"
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        '
        'fecha_alta
        '
        Me.fecha_alta.HeaderText = "Fecha Alta"
        Me.fecha_alta.Name = "fecha_alta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(61, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 17)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Nombre Usuario:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(344, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Observación: Los campos marcados con (*) son obligatorios."
        '
        'txt_fecha_alta
        '
        Me.txt_fecha_alta.Location = New System.Drawing.Point(219, 283)
        Me.txt_fecha_alta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_fecha_alta.Mask = "00/00/0000"
        Me.txt_fecha_alta.Name = "txt_fecha_alta"
        Me.txt_fecha_alta.Size = New System.Drawing.Size(116, 25)
        Me.txt_fecha_alta.TabIndex = 5
        Me.txt_fecha_alta.ValidatingType = GetType(Date)
        '
        'txt_contraseña2
        '
        Me.txt_contraseña2.Enabled = False
        Me.txt_contraseña2.Location = New System.Drawing.Point(219, 250)
        Me.txt_contraseña2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_contraseña2.Name = "txt_contraseña2"
        Me.txt_contraseña2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contraseña2.Size = New System.Drawing.Size(116, 25)
        Me.txt_contraseña2.TabIndex = 4
        '
        'txt_contraseña1
        '
        Me.txt_contraseña1.Enabled = False
        Me.txt_contraseña1.Location = New System.Drawing.Point(219, 217)
        Me.txt_contraseña1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_contraseña1.Name = "txt_contraseña1"
        Me.txt_contraseña1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contraseña1.Size = New System.Drawing.Size(116, 25)
        Me.txt_contraseña1.TabIndex = 3
        '
        'txt_apellido
        '
        Me.txt_apellido.Enabled = False
        Me.txt_apellido.Location = New System.Drawing.Point(219, 151)
        Me.txt_apellido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(116, 25)
        Me.txt_apellido.TabIndex = 1
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(219, 184)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(116, 25)
        Me.txt_nombre.TabIndex = 2
        '
        'txt_buscar_usuario
        '
        Me.txt_buscar_usuario.Location = New System.Drawing.Point(176, 55)
        Me.txt_buscar_usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_buscar_usuario.Name = "txt_buscar_usuario"
        Me.txt_buscar_usuario.Size = New System.Drawing.Size(116, 25)
        Me.txt_buscar_usuario.TabIndex = 1
        Me.txt_buscar_usuario.Text = "Buscar..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(113, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Fecha de Alta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Vuelva a cargar la Contraseña:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(143, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Carga de Datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Administración de Usuario"
        '
        'txt_id_usuario
        '
        Me.txt_id_usuario.Enabled = False
        Me.txt_id_usuario.Location = New System.Drawing.Point(219, 118)
        Me.txt_id_usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_id_usuario.Name = "txt_id_usuario"
        Me.txt_id_usuario.Size = New System.Drawing.Size(116, 25)
        Me.txt_id_usuario.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(75, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 17)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Nombre de Usuario:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(200, 121)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 17)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "*"
        '
        'groupBox
        '
        Me.groupBox.Controls.Add(Me.cmd_buscar)
        Me.groupBox.Controls.Add(Me.grilla_usuarios)
        Me.groupBox.Controls.Add(Me.txt_buscar_usuario)
        Me.groupBox.Controls.Add(Me.Label9)
        Me.groupBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox.Location = New System.Drawing.Point(427, 78)
        Me.groupBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox.Name = "groupBox"
        Me.groupBox.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox.Size = New System.Drawing.Size(506, 414)
        Me.groupBox.TabIndex = 38
        Me.groupBox.TabStop = False
        Me.groupBox.Text = "Listado de Usuarios"
        '
        'cmd_buscar
        '
        Me.cmd_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.cmd_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmd_buscar.Location = New System.Drawing.Point(298, 55)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(77, 27)
        Me.cmd_buscar.TabIndex = 42
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = False
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.cmd_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_nuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmd_nuevo.Location = New System.Drawing.Point(24, 377)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(100, 30)
        Me.cmd_nuevo.TabIndex = 39
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'cmd_grabar
        '
        Me.cmd_grabar.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.cmd_grabar.Enabled = False
        Me.cmd_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_grabar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmd_grabar.Location = New System.Drawing.Point(24, 470)
        Me.cmd_grabar.Name = "cmd_grabar"
        Me.cmd_grabar.Size = New System.Drawing.Size(100, 30)
        Me.cmd_grabar.TabIndex = 40
        Me.cmd_grabar.Text = "Guardar"
        Me.cmd_grabar.UseVisualStyleBackColor = False
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.cmd_eliminar.Enabled = False
        Me.cmd_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmd_eliminar.Location = New System.Drawing.Point(24, 423)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(100, 30)
        Me.cmd_eliminar.TabIndex = 41
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = False
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(945, 512)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_grabar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.groupBox)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_fecha_alta)
        Me.Controls.Add(Me.txt_contraseña2)
        Me.Controls.Add(Me.txt_contraseña1)
        Me.Controls.Add(Me.txt_id_usuario)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLOTTA Usuarios"
        CType(Me.grilla_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox.ResumeLayout(False)
        Me.groupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents grilla_usuarios As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_alta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_contraseña2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_contraseña1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_buscar_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_id_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents groupBox As System.Windows.Forms.GroupBox
    Friend WithEvents id_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_alta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_grabar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
End Class
