<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFabrica
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFabrica))
        Me.Grilla_Fabrica = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_fabrica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nombre_fabrica = New System.Windows.Forms.TextBox()
        Me.txt_telefono_fabrica = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelbuscar = New System.Windows.Forms.Label()
        Me.txt_bucar_fabrica = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_codigo_fabrica = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_guardar_fabrica = New System.Windows.Forms.Button()
        Me.btn_eliminar_fabrica = New System.Windows.Forms.Button()
        Me.btn_nueva_fabrica = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_nombreERROR = New System.Windows.Forms.Label()
        Me.lbl_telefonoERROR = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.Grilla_Fabrica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grilla_Fabrica
        '
        Me.Grilla_Fabrica.AllowUserToAddRows = False
        Me.Grilla_Fabrica.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grilla_Fabrica.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grilla_Fabrica.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Fabrica.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grilla_Fabrica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Fabrica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Telefono, Me.id_fabrica})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grilla_Fabrica.DefaultCellStyle = DataGridViewCellStyle3
        Me.Grilla_Fabrica.Location = New System.Drawing.Point(17, 67)
        Me.Grilla_Fabrica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Grilla_Fabrica.Name = "Grilla_Fabrica"
        Me.Grilla_Fabrica.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Fabrica.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grilla_Fabrica.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Grilla_Fabrica.Size = New System.Drawing.Size(369, 293)
        Me.Grilla_Fabrica.TabIndex = 2
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 7
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 170
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Teléfono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Width = 120
        '
        'id_fabrica
        '
        Me.id_fabrica.HeaderText = "id_fabrica"
        Me.id_fabrica.Name = "id_fabrica"
        Me.id_fabrica.ReadOnly = True
        Me.id_fabrica.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(344, 17)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Observación: Los campos marcados con (*) son obligatorios."
        '
        'txt_nombre_fabrica
        '
        Me.txt_nombre_fabrica.Enabled = False
        Me.txt_nombre_fabrica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_fabrica.ForeColor = System.Drawing.Color.Black
        Me.txt_nombre_fabrica.Location = New System.Drawing.Point(99, 61)
        Me.txt_nombre_fabrica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nombre_fabrica.Name = "txt_nombre_fabrica"
        Me.txt_nombre_fabrica.Size = New System.Drawing.Size(215, 25)
        Me.txt_nombre_fabrica.TabIndex = 1
        '
        'txt_telefono_fabrica
        '
        Me.txt_telefono_fabrica.Enabled = False
        Me.txt_telefono_fabrica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono_fabrica.ForeColor = System.Drawing.Color.Black
        Me.txt_telefono_fabrica.Location = New System.Drawing.Point(99, 93)
        Me.txt_telefono_fabrica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_telefono_fabrica.Mask = "99999999999"
        Me.txt_telefono_fabrica.Name = "txt_telefono_fabrica"
        Me.txt_telefono_fabrica.Size = New System.Drawing.Size(116, 25)
        Me.txt_telefono_fabrica.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(18, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Teléfono (*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Nombre (*)"
        '
        'labelbuscar
        '
        Me.labelbuscar.AutoSize = True
        Me.labelbuscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbuscar.ForeColor = System.Drawing.Color.Black
        Me.labelbuscar.Location = New System.Drawing.Point(18, 33)
        Me.labelbuscar.Name = "labelbuscar"
        Me.labelbuscar.Size = New System.Drawing.Size(57, 17)
        Me.labelbuscar.TabIndex = 28
        Me.labelbuscar.Text = "Nombre"
        '
        'txt_bucar_fabrica
        '
        Me.txt_bucar_fabrica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bucar_fabrica.Location = New System.Drawing.Point(81, 30)
        Me.txt_bucar_fabrica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_bucar_fabrica.Name = "txt_bucar_fabrica"
        Me.txt_bucar_fabrica.Size = New System.Drawing.Size(172, 25)
        Me.txt_bucar_fabrica.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(42, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Código"
        '
        'txt_codigo_fabrica
        '
        Me.txt_codigo_fabrica.Enabled = False
        Me.txt_codigo_fabrica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo_fabrica.ForeColor = System.Drawing.Color.Black
        Me.txt_codigo_fabrica.Location = New System.Drawing.Point(99, 30)
        Me.txt_codigo_fabrica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_codigo_fabrica.Name = "txt_codigo_fabrica"
        Me.txt_codigo_fabrica.Size = New System.Drawing.Size(215, 25)
        Me.txt_codigo_fabrica.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Grilla_Fabrica)
        Me.GroupBox1.Controls.Add(Me.labelbuscar)
        Me.GroupBox1.Controls.Add(Me.txt_bucar_fabrica)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 386)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Fábricas"
        '
        'btn_guardar_fabrica
        '
        Me.btn_guardar_fabrica.BackColor = System.Drawing.Color.White
        Me.btn_guardar_fabrica.Enabled = False
        Me.btn_guardar_fabrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar_fabrica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar_fabrica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_guardar_fabrica.Image = Global.PAV1_TPI.My.Resources.Resources.check_mark
        Me.btn_guardar_fabrica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar_fabrica.Location = New System.Drawing.Point(540, 224)
        Me.btn_guardar_fabrica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_guardar_fabrica.Name = "btn_guardar_fabrica"
        Me.btn_guardar_fabrica.Size = New System.Drawing.Size(105, 45)
        Me.btn_guardar_fabrica.TabIndex = 4
        Me.btn_guardar_fabrica.Text = "Guardar"
        Me.btn_guardar_fabrica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar_fabrica.UseVisualStyleBackColor = False
        '
        'btn_eliminar_fabrica
        '
        Me.btn_eliminar_fabrica.BackColor = System.Drawing.Color.White
        Me.btn_eliminar_fabrica.Enabled = False
        Me.btn_eliminar_fabrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar_fabrica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_fabrica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_eliminar_fabrica.Image = Global.PAV1_TPI.My.Resources.Resources.trash_bin32
        Me.btn_eliminar_fabrica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar_fabrica.Location = New System.Drawing.Point(651, 224)
        Me.btn_eliminar_fabrica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_eliminar_fabrica.Name = "btn_eliminar_fabrica"
        Me.btn_eliminar_fabrica.Size = New System.Drawing.Size(105, 45)
        Me.btn_eliminar_fabrica.TabIndex = 5
        Me.btn_eliminar_fabrica.Text = "Eliminar"
        Me.btn_eliminar_fabrica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar_fabrica.UseVisualStyleBackColor = False
        Me.btn_eliminar_fabrica.Visible = False
        '
        'btn_nueva_fabrica
        '
        Me.btn_nueva_fabrica.BackColor = System.Drawing.Color.White
        Me.btn_nueva_fabrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nueva_fabrica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nueva_fabrica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_nueva_fabrica.Image = Global.PAV1_TPI.My.Resources.Resources.plus_circular_button32
        Me.btn_nueva_fabrica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nueva_fabrica.Location = New System.Drawing.Point(429, 224)
        Me.btn_nueva_fabrica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_nueva_fabrica.Name = "btn_nueva_fabrica"
        Me.btn_nueva_fabrica.Size = New System.Drawing.Size(105, 45)
        Me.btn_nueva_fabrica.TabIndex = 3
        Me.btn_nueva_fabrica.Text = "Nueva"
        Me.btn_nueva_fabrica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nueva_fabrica.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Image = Global.PAV1_TPI.My.Resources.Resources.clotta_nombre
        Me.Label5.Location = New System.Drawing.Point(693, 406)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 33)
        Me.Label5.TabIndex = 47
        '
        'lbl_nombreERROR
        '
        Me.lbl_nombreERROR.AutoSize = True
        Me.lbl_nombreERROR.ForeColor = System.Drawing.Color.Black
        Me.lbl_nombreERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_nombreERROR.Location = New System.Drawing.Point(321, 66)
        Me.lbl_nombreERROR.Name = "lbl_nombreERROR"
        Me.lbl_nombreERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_nombreERROR.TabIndex = 48
        Me.lbl_nombreERROR.Text = "   "
        Me.lbl_nombreERROR.Visible = False
        '
        'lbl_telefonoERROR
        '
        Me.lbl_telefonoERROR.AutoSize = True
        Me.lbl_telefonoERROR.ForeColor = System.Drawing.Color.Black
        Me.lbl_telefonoERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_telefonoERROR.Location = New System.Drawing.Point(221, 98)
        Me.lbl_telefonoERROR.Name = "lbl_telefonoERROR"
        Me.lbl_telefonoERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_telefonoERROR.TabIndex = 48
        Me.lbl_telefonoERROR.Text = "   "
        Me.lbl_telefonoERROR.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lbl_telefonoERROR)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lbl_nombreERROR)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_telefono_fabrica)
        Me.GroupBox2.Controls.Add(Me.txt_nombre_fabrica)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_codigo_fabrica)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(429, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(373, 164)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Fábricas"
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(816, 47)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "  Administración de Fábricas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormFabrica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(816, 451)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_guardar_fabrica)
        Me.Controls.Add(Me.btn_eliminar_fabrica)
        Me.Controls.Add(Me.btn_nueva_fabrica)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormFabrica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fábricas"
        CType(Me.Grilla_Fabrica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grilla_Fabrica As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_fabrica As System.Windows.Forms.TextBox
    Friend WithEvents btn_guardar_fabrica As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar_fabrica As System.Windows.Forms.Button
    Friend WithEvents btn_nueva_fabrica As System.Windows.Forms.Button
    Friend WithEvents txt_telefono_fabrica As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents labelbuscar As System.Windows.Forms.Label
    Friend WithEvents txt_bucar_fabrica As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo_fabrica As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_nombreERROR As System.Windows.Forms.Label
    Friend WithEvents lbl_telefonoERROR As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents id_fabrica As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
End Class
