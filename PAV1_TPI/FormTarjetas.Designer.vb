<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTarjetas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTarjetas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_numero_tarjeta = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_fecha_vencimiento = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_banco_adherido = New System.Windows.Forms.ComboBox()
        Me.cmb_entidad_crediticia = New System.Windows.Forms.ComboBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Carga de tarjetas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "N° Tarjeta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Apellido y Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha de Vencimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Banco adherido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Entidad crediticia"
        '
        'txt_numero_tarjeta
        '
        Me.txt_numero_tarjeta.Location = New System.Drawing.Point(166, 92)
        Me.txt_numero_tarjeta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_numero_tarjeta.Name = "txt_numero_tarjeta"
        Me.txt_numero_tarjeta.Size = New System.Drawing.Size(268, 25)
        Me.txt_numero_tarjeta.TabIndex = 0
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(166, 125)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(268, 25)
        Me.txt_nombre.TabIndex = 1
        '
        'txt_fecha_vencimiento
        '
        Me.txt_fecha_vencimiento.Location = New System.Drawing.Point(166, 158)
        Me.txt_fecha_vencimiento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_fecha_vencimiento.Mask = "00/00"
        Me.txt_fecha_vencimiento.Name = "txt_fecha_vencimiento"
        Me.txt_fecha_vencimiento.Size = New System.Drawing.Size(268, 25)
        Me.txt_fecha_vencimiento.TabIndex = 3
        '
        'cmb_banco_adherido
        '
        Me.cmb_banco_adherido.FormattingEnabled = True
        Me.cmb_banco_adherido.Location = New System.Drawing.Point(166, 191)
        Me.cmb_banco_adherido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmb_banco_adherido.Name = "cmb_banco_adherido"
        Me.cmb_banco_adherido.Size = New System.Drawing.Size(268, 25)
        Me.cmb_banco_adherido.TabIndex = 4
        '
        'cmb_entidad_crediticia
        '
        Me.cmb_entidad_crediticia.FormattingEnabled = True
        Me.cmb_entidad_crediticia.Location = New System.Drawing.Point(166, 224)
        Me.cmb_entidad_crediticia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmb_entidad_crediticia.Name = "cmb_entidad_crediticia"
        Me.cmb_entidad_crediticia.Size = New System.Drawing.Size(268, 25)
        Me.cmb_entidad_crediticia.TabIndex = 5
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(334, 285)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(100, 35)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(228, 285)
        Me.btn_aceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(100, 35)
        Me.btn_aceptar.TabIndex = 6
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'FormTarjetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(468, 353)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.cmb_entidad_crediticia)
        Me.Controls.Add(Me.cmb_banco_adherido)
        Me.Controls.Add(Me.txt_fecha_vencimiento)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_numero_tarjeta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormTarjetas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLOTTA Tarjetas"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_tarjeta As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha_vencimiento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_banco_adherido As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_entidad_crediticia As System.Windows.Forms.ComboBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
End Class
