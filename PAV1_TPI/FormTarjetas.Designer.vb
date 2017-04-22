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
        Me.Label1.Location = New System.Drawing.Point(155, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Carga de tarjetas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "N° Tarjeta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Apellido y Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha de Vencimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Banco adherido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Entidad crediticia"
        '
        'txt_numero_tarjeta
        '
        Me.txt_numero_tarjeta.Location = New System.Drawing.Point(142, 70)
        Me.txt_numero_tarjeta.Name = "txt_numero_tarjeta"
        Me.txt_numero_tarjeta.Size = New System.Drawing.Size(230, 20)
        Me.txt_numero_tarjeta.TabIndex = 0
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(142, 120)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(230, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'txt_fecha_vencimiento
        '
        Me.txt_fecha_vencimiento.Location = New System.Drawing.Point(142, 161)
        Me.txt_fecha_vencimiento.Mask = "00/00"
        Me.txt_fecha_vencimiento.Name = "txt_fecha_vencimiento"
        Me.txt_fecha_vencimiento.Size = New System.Drawing.Size(38, 20)
        Me.txt_fecha_vencimiento.TabIndex = 3
        '
        'cmb_banco_adherido
        '
        Me.cmb_banco_adherido.FormattingEnabled = True
        Me.cmb_banco_adherido.Location = New System.Drawing.Point(142, 210)
        Me.cmb_banco_adherido.Name = "cmb_banco_adherido"
        Me.cmb_banco_adherido.Size = New System.Drawing.Size(230, 21)
        Me.cmb_banco_adherido.TabIndex = 4
        '
        'cmb_entidad_crediticia
        '
        Me.cmb_entidad_crediticia.FormattingEnabled = True
        Me.cmb_entidad_crediticia.Location = New System.Drawing.Point(142, 251)
        Me.cmb_entidad_crediticia.Name = "cmb_entidad_crediticia"
        Me.cmb_entidad_crediticia.Size = New System.Drawing.Size(230, 21)
        Me.cmb_entidad_crediticia.TabIndex = 5
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(297, 309)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 37)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(216, 309)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 37)
        Me.btn_aceptar.TabIndex = 6
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'FormTarjetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 363)
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
        Me.Name = "FormTarjetas"
        Me.Text = "FormTarjetas"
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
