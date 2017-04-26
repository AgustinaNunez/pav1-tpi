<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFabrica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFabrica))
        Me.Grilla_Fabrica = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_fabrica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nombre_fabrica = New System.Windows.Forms.TextBox()
        Me.btn_guardar_fabrica = New System.Windows.Forms.Button()
        Me.btn_eliminar_fabrica = New System.Windows.Forms.Button()
        Me.btn_nueva_fabrica = New System.Windows.Forms.Button()
        Me.txt_telefono_fabrica = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_buscar_fabrica = New System.Windows.Forms.Button()
        Me.labelbuscar = New System.Windows.Forms.Label()
        Me.txt_bucar_fabrica = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_codigo_fabrica = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.Grilla_Fabrica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grilla_Fabrica
        '
        Me.Grilla_Fabrica.AllowUserToAddRows = False
        Me.Grilla_Fabrica.AllowUserToDeleteRows = False
        Me.Grilla_Fabrica.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Grilla_Fabrica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Fabrica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Telefono, Me.id_fabrica})
        Me.Grilla_Fabrica.Location = New System.Drawing.Point(0, 85)
        Me.Grilla_Fabrica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Grilla_Fabrica.Name = "Grilla_Fabrica"
        Me.Grilla_Fabrica.ReadOnly = True
        Me.Grilla_Fabrica.Size = New System.Drawing.Size(400, 293)
        Me.Grilla_Fabrica.TabIndex = 2
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 7
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 150
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Teléfono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Width = 150
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
        Me.Label6.Location = New System.Drawing.Point(430, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(344, 17)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Observación: Los campos marcados con (*) son obligatorios."
        '
        'txt_nombre_fabrica
        '
        Me.txt_nombre_fabrica.Enabled = False
        Me.txt_nombre_fabrica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_fabrica.Location = New System.Drawing.Point(496, 102)
        Me.txt_nombre_fabrica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nombre_fabrica.Name = "txt_nombre_fabrica"
        Me.txt_nombre_fabrica.Size = New System.Drawing.Size(259, 25)
        Me.txt_nombre_fabrica.TabIndex = 1
        '
        'btn_guardar_fabrica
        '
        Me.btn_guardar_fabrica.Enabled = False
        Me.btn_guardar_fabrica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar_fabrica.Location = New System.Drawing.Point(429, 253)
        Me.btn_guardar_fabrica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_guardar_fabrica.Name = "btn_guardar_fabrica"
        Me.btn_guardar_fabrica.Size = New System.Drawing.Size(150, 35)
        Me.btn_guardar_fabrica.TabIndex = 4
        Me.btn_guardar_fabrica.Text = "Guardar Fábrica"
        Me.btn_guardar_fabrica.UseVisualStyleBackColor = True
        '
        'btn_eliminar_fabrica
        '
        Me.btn_eliminar_fabrica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_fabrica.Location = New System.Drawing.Point(429, 296)
        Me.btn_eliminar_fabrica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_eliminar_fabrica.Name = "btn_eliminar_fabrica"
        Me.btn_eliminar_fabrica.Size = New System.Drawing.Size(150, 35)
        Me.btn_eliminar_fabrica.TabIndex = 5
        Me.btn_eliminar_fabrica.Text = "Eliminar Fábrica"
        Me.btn_eliminar_fabrica.UseVisualStyleBackColor = True
        '
        'btn_nueva_fabrica
        '
        Me.btn_nueva_fabrica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nueva_fabrica.ForeColor = System.Drawing.Color.Black
        Me.btn_nueva_fabrica.Location = New System.Drawing.Point(429, 210)
        Me.btn_nueva_fabrica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_nueva_fabrica.Name = "btn_nueva_fabrica"
        Me.btn_nueva_fabrica.Size = New System.Drawing.Size(150, 35)
        Me.btn_nueva_fabrica.TabIndex = 3
        Me.btn_nueva_fabrica.Text = "Nueva Fábrica"
        Me.btn_nueva_fabrica.UseVisualStyleBackColor = True
        '
        'txt_telefono_fabrica
        '
        Me.txt_telefono_fabrica.Enabled = False
        Me.txt_telefono_fabrica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono_fabrica.Location = New System.Drawing.Point(496, 133)
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
        Me.Label3.Location = New System.Drawing.Point(431, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Teléfono "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(431, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Nombre "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(430, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(100, 17)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Carga de datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 30)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Administración de Fábricas"
        '
        'btn_buscar_fabrica
        '
        Me.btn_buscar_fabrica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar_fabrica.Location = New System.Drawing.Point(250, 43)
        Me.btn_buscar_fabrica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_buscar_fabrica.Name = "btn_buscar_fabrica"
        Me.btn_buscar_fabrica.Size = New System.Drawing.Size(150, 35)
        Me.btn_buscar_fabrica.TabIndex = 1
        Me.btn_buscar_fabrica.Text = "Buscar Fábrica"
        Me.btn_buscar_fabrica.UseVisualStyleBackColor = True
        '
        'labelbuscar
        '
        Me.labelbuscar.AutoSize = True
        Me.labelbuscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbuscar.Location = New System.Drawing.Point(5, 51)
        Me.labelbuscar.Name = "labelbuscar"
        Me.labelbuscar.Size = New System.Drawing.Size(64, 17)
        Me.labelbuscar.TabIndex = 28
        Me.labelbuscar.Text = "Nombre :"
        '
        'txt_bucar_fabrica
        '
        Me.txt_bucar_fabrica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bucar_fabrica.Location = New System.Drawing.Point(72, 48)
        Me.txt_bucar_fabrica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_bucar_fabrica.Name = "txt_bucar_fabrica"
        Me.txt_bucar_fabrica.Size = New System.Drawing.Size(172, 25)
        Me.txt_bucar_fabrica.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(437, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Codigo"
        '
        'txt_codigo_fabrica
        '
        Me.txt_codigo_fabrica.Enabled = False
        Me.txt_codigo_fabrica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo_fabrica.Location = New System.Drawing.Point(496, 71)
        Me.txt_codigo_fabrica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_codigo_fabrica.Name = "txt_codigo_fabrica"
        Me.txt_codigo_fabrica.Size = New System.Drawing.Size(259, 25)
        Me.txt_codigo_fabrica.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Grilla_Fabrica)
        Me.GroupBox1.Controls.Add(Me.labelbuscar)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_fabrica)
        Me.GroupBox1.Controls.Add(Me.txt_bucar_fabrica)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 394)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda de Fabricas"
        '
        'FormFabrica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(778, 451)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_codigo_fabrica)
        Me.Controls.Add(Me.txt_nombre_fabrica)
        Me.Controls.Add(Me.btn_guardar_fabrica)
        Me.Controls.Add(Me.btn_eliminar_fabrica)
        Me.Controls.Add(Me.btn_nueva_fabrica)
        Me.Controls.Add(Me.txt_telefono_fabrica)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormFabrica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLOTTA Fábrica"
        CType(Me.Grilla_Fabrica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar_fabrica As System.Windows.Forms.Button
    Friend WithEvents labelbuscar As System.Windows.Forms.Label
    Friend WithEvents txt_bucar_fabrica As System.Windows.Forms.TextBox
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_fabrica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo_fabrica As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
