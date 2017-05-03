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
        Me.grilla_usuarios = New System.Windows.Forms.DataGridView()
        Me.id_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.groupBox = New System.Windows.Forms.GroupBox()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_grabar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_usuarioERROR = New System.Windows.Forms.Label()
        Me.lbl_constraseñaERROR = New System.Windows.Forms.Label()
        Me.lbl_contraseña2ERROR = New System.Windows.Forms.Label()
        Me.lbl_fechaERROR = New System.Windows.Forms.Label()
        Me.lbl_apellidoERROR = New System.Windows.Forms.Label()
        Me.lbl_nombreERROR = New System.Windows.Forms.Label()
        CType(Me.grilla_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'grilla_usuarios
        '
        Me.grilla_usuarios.AllowUserToAddRows = False
        Me.grilla_usuarios.AllowUserToDeleteRows = False
        Me.grilla_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_usuario, Me.apellido, Me.nombre, Me.fecha_alta})
        Me.grilla_usuarios.Location = New System.Drawing.Point(30, 89)
        Me.grilla_usuarios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grilla_usuarios.Name = "grilla_usuarios"
        Me.grilla_usuarios.ReadOnly = True
        Me.grilla_usuarios.Size = New System.Drawing.Size(443, 300)
        Me.grilla_usuarios.TabIndex = 27
        '
        'id_usuario
        '
        Me.id_usuario.HeaderText = "User Name"
        Me.id_usuario.Name = "id_usuario"
        Me.id_usuario.ReadOnly = True
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'fecha_alta
        '
        Me.fecha_alta.HeaderText = "Fecha Alta"
        Me.fecha_alta.Name = "fecha_alta"
        Me.fecha_alta.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(27, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 17)
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
        Me.txt_fecha_alta.Enabled = False
        Me.txt_fecha_alta.Location = New System.Drawing.Point(219, 283)
        Me.txt_fecha_alta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_fecha_alta.Mask = "00/00/0000"
        Me.txt_fecha_alta.Name = "txt_fecha_alta"
        Me.txt_fecha_alta.Size = New System.Drawing.Size(143, 25)
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
        Me.txt_contraseña2.Size = New System.Drawing.Size(143, 25)
        Me.txt_contraseña2.TabIndex = 4
        '
        'txt_contraseña1
        '
        Me.txt_contraseña1.Enabled = False
        Me.txt_contraseña1.Location = New System.Drawing.Point(219, 217)
        Me.txt_contraseña1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_contraseña1.Name = "txt_contraseña1"
        Me.txt_contraseña1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contraseña1.Size = New System.Drawing.Size(143, 25)
        Me.txt_contraseña1.TabIndex = 3
        '
        'txt_apellido
        '
        Me.txt_apellido.Enabled = False
        Me.txt_apellido.Location = New System.Drawing.Point(219, 151)
        Me.txt_apellido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(143, 25)
        Me.txt_apellido.TabIndex = 1
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(219, 184)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(143, 25)
        Me.txt_nombre.TabIndex = 2
        '
        'txt_buscar_usuario
        '
        Me.txt_buscar_usuario.Location = New System.Drawing.Point(162, 60)
        Me.txt_buscar_usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_buscar_usuario.Name = "txt_buscar_usuario"
        Me.txt_buscar_usuario.Size = New System.Drawing.Size(116, 25)
        Me.txt_buscar_usuario.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(101, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Fecha de Alta: (*)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Repetir contraseña: (*)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(113, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Contraseña: (*)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(130, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Nombre: (*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Apellido: (*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
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
        Me.Label1.Size = New System.Drawing.Size(256, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Administración de Usuarios"
        '
        'txt_id_usuario
        '
        Me.txt_id_usuario.Enabled = False
        Me.txt_id_usuario.Location = New System.Drawing.Point(219, 118)
        Me.txt_id_usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_id_usuario.Name = "txt_id_usuario"
        Me.txt_id_usuario.Size = New System.Drawing.Size(143, 25)
        Me.txt_id_usuario.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(62, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(145, 17)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Nombre de Usuario: (*)"
        '
        'groupBox
        '
        Me.groupBox.Controls.Add(Me.cmd_buscar)
        Me.groupBox.Controls.Add(Me.grilla_usuarios)
        Me.groupBox.Controls.Add(Me.txt_buscar_usuario)
        Me.groupBox.Controls.Add(Me.Label9)
        Me.groupBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
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
        Me.cmd_buscar.BackColor = System.Drawing.Color.White
        Me.cmd_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_buscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.cmd_buscar.Image = Global.PAV1_TPI.My.Resources.Resources.magnifier16
        Me.cmd_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_buscar.Location = New System.Drawing.Point(302, 58)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(118, 27)
        Me.cmd_buscar.TabIndex = 1
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = False
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.AutoEllipsis = True
        Me.cmd_eliminar.BackColor = System.Drawing.Color.White
        Me.cmd_eliminar.Enabled = False
        Me.cmd_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_eliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.cmd_eliminar.Image = Global.PAV1_TPI.My.Resources.Resources.trash_bin32
        Me.cmd_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_eliminar.Location = New System.Drawing.Point(24, 413)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(100, 40)
        Me.cmd_eliminar.TabIndex = 7
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_eliminar.UseVisualStyleBackColor = False
        '
        'cmd_grabar
        '
        Me.cmd_grabar.BackColor = System.Drawing.Color.White
        Me.cmd_grabar.Enabled = False
        Me.cmd_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_grabar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.cmd_grabar.Image = Global.PAV1_TPI.My.Resources.Resources.check_mark
        Me.cmd_grabar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_grabar.Location = New System.Drawing.Point(24, 459)
        Me.cmd_grabar.Name = "cmd_grabar"
        Me.cmd_grabar.Size = New System.Drawing.Size(100, 41)
        Me.cmd_grabar.TabIndex = 8
        Me.cmd_grabar.Text = "Guardar"
        Me.cmd_grabar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_grabar.UseVisualStyleBackColor = False
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.BackColor = System.Drawing.Color.White
        Me.cmd_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_nuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.cmd_nuevo.Image = Global.PAV1_TPI.My.Resources.Resources.plus_circular_button32
        Me.cmd_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_nuevo.Location = New System.Drawing.Point(24, 367)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(99, 40)
        Me.cmd_nuevo.TabIndex = 6
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Image = Global.PAV1_TPI.My.Resources.Resources.clotta_nombre
        Me.Label10.Location = New System.Drawing.Point(824, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 33)
        Me.Label10.TabIndex = 28
        '
        'lbl_usuarioERROR
        '
        Me.lbl_usuarioERROR.AutoSize = True
        Me.lbl_usuarioERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_usuarioERROR.Location = New System.Drawing.Point(368, 121)
        Me.lbl_usuarioERROR.Name = "lbl_usuarioERROR"
        Me.lbl_usuarioERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_usuarioERROR.TabIndex = 39
        Me.lbl_usuarioERROR.Text = "   "
        Me.lbl_usuarioERROR.Visible = False
        '
        'lbl_constraseñaERROR
        '
        Me.lbl_constraseñaERROR.AutoSize = True
        Me.lbl_constraseñaERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_constraseñaERROR.Location = New System.Drawing.Point(367, 220)
        Me.lbl_constraseñaERROR.Name = "lbl_constraseñaERROR"
        Me.lbl_constraseñaERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_constraseñaERROR.TabIndex = 39
        Me.lbl_constraseñaERROR.Text = "   "
        Me.lbl_constraseñaERROR.Visible = False
        '
        'lbl_contraseña2ERROR
        '
        Me.lbl_contraseña2ERROR.AutoSize = True
        Me.lbl_contraseña2ERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_contraseña2ERROR.Location = New System.Drawing.Point(367, 253)
        Me.lbl_contraseña2ERROR.Name = "lbl_contraseña2ERROR"
        Me.lbl_contraseña2ERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_contraseña2ERROR.TabIndex = 39
        Me.lbl_contraseña2ERROR.Text = "   "
        Me.lbl_contraseña2ERROR.Visible = False
        '
        'lbl_fechaERROR
        '
        Me.lbl_fechaERROR.AutoSize = True
        Me.lbl_fechaERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_fechaERROR.Location = New System.Drawing.Point(367, 286)
        Me.lbl_fechaERROR.Name = "lbl_fechaERROR"
        Me.lbl_fechaERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_fechaERROR.TabIndex = 39
        Me.lbl_fechaERROR.Text = "   "
        Me.lbl_fechaERROR.Visible = False
        '
        'lbl_apellidoERROR
        '
        Me.lbl_apellidoERROR.AutoSize = True
        Me.lbl_apellidoERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_apellidoERROR.Location = New System.Drawing.Point(367, 187)
        Me.lbl_apellidoERROR.Name = "lbl_apellidoERROR"
        Me.lbl_apellidoERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_apellidoERROR.TabIndex = 39
        Me.lbl_apellidoERROR.Text = "   "
        Me.lbl_apellidoERROR.Visible = False
        '
        'lbl_nombreERROR
        '
        Me.lbl_nombreERROR.AutoSize = True
        Me.lbl_nombreERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_nombreERROR.Location = New System.Drawing.Point(367, 154)
        Me.lbl_nombreERROR.Name = "lbl_nombreERROR"
        Me.lbl_nombreERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_nombreERROR.TabIndex = 39
        Me.lbl_nombreERROR.Text = "   "
        Me.lbl_nombreERROR.Visible = False
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(945, 512)
        Me.Controls.Add(Me.lbl_fechaERROR)
        Me.Controls.Add(Me.lbl_contraseña2ERROR)
        Me.Controls.Add(Me.lbl_constraseñaERROR)
        Me.Controls.Add(Me.lbl_apellidoERROR)
        Me.Controls.Add(Me.lbl_nombreERROR)
        Me.Controls.Add(Me.lbl_usuarioERROR)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_grabar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.groupBox)
        Me.Controls.Add(Me.Label15)
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
    Friend WithEvents groupBox As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_grabar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents id_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_alta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_usuarioERROR As System.Windows.Forms.Label
    Friend WithEvents lbl_constraseñaERROR As System.Windows.Forms.Label
    Friend WithEvents lbl_contraseña2ERROR As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaERROR As System.Windows.Forms.Label
    Friend WithEvents lbl_apellidoERROR As System.Windows.Forms.Label
    Friend WithEvents lbl_nombreERROR As System.Windows.Forms.Label
End Class
