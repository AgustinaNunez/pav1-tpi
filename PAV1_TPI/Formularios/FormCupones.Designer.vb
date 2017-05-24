<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCupones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCupones))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_numero_cupon = New System.Windows.Forms.TextBox()
        Me.txt_numero_lote = New System.Windows.Forms.TextBox()
        Me.txt_numero_autorizacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_cuponERROR = New System.Windows.Forms.Label()
        Me.lbl_loteERROR = New System.Windows.Forms.Label()
        Me.lbl_autorizacionERROR = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_banco = New System.Windows.Forms.ComboBox()
        Me.cmb_entidad = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.lbl_precioERROR = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "N° Cupón (*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "N° Lote (*)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "N° Autorización (*)"
        '
        'txt_numero_cupon
        '
        Me.txt_numero_cupon.Location = New System.Drawing.Point(143, 51)
        Me.txt_numero_cupon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_numero_cupon.Name = "txt_numero_cupon"
        Me.txt_numero_cupon.Size = New System.Drawing.Size(216, 25)
        Me.txt_numero_cupon.TabIndex = 0
        '
        'txt_numero_lote
        '
        Me.txt_numero_lote.Location = New System.Drawing.Point(143, 84)
        Me.txt_numero_lote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_numero_lote.Name = "txt_numero_lote"
        Me.txt_numero_lote.Size = New System.Drawing.Size(216, 25)
        Me.txt_numero_lote.TabIndex = 1
        '
        'txt_numero_autorizacion
        '
        Me.txt_numero_autorizacion.Location = New System.Drawing.Point(143, 117)
        Me.txt_numero_autorizacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_numero_autorizacion.Name = "txt_numero_autorizacion"
        Me.txt_numero_autorizacion.Size = New System.Drawing.Size(216, 25)
        Me.txt_numero_autorizacion.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(344, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Observación: Los campos marcados con (*) son obligatorios."
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.Color.White
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_aceptar.Image = Global.PAV1_TPI.My.Resources.Resources.check_mark
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.Location = New System.Drawing.Point(150, 308)
        Me.btn_aceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(100, 41)
        Me.btn_aceptar.TabIndex = 6
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Image = Global.PAV1_TPI.My.Resources.Resources.clotta_nombre
        Me.Label4.Location = New System.Drawing.Point(298, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 33)
        Me.Label4.TabIndex = 26
        '
        'lbl_cuponERROR
        '
        Me.lbl_cuponERROR.AutoSize = True
        Me.lbl_cuponERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_cuponERROR.Location = New System.Drawing.Point(365, 54)
        Me.lbl_cuponERROR.Name = "lbl_cuponERROR"
        Me.lbl_cuponERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_cuponERROR.TabIndex = 27
        Me.lbl_cuponERROR.Text = "   "
        Me.lbl_cuponERROR.Visible = False
        '
        'lbl_loteERROR
        '
        Me.lbl_loteERROR.AutoSize = True
        Me.lbl_loteERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_loteERROR.Location = New System.Drawing.Point(365, 87)
        Me.lbl_loteERROR.Name = "lbl_loteERROR"
        Me.lbl_loteERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_loteERROR.TabIndex = 27
        Me.lbl_loteERROR.Text = "   "
        Me.lbl_loteERROR.Visible = False
        '
        'lbl_autorizacionERROR
        '
        Me.lbl_autorizacionERROR.AutoSize = True
        Me.lbl_autorizacionERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_autorizacionERROR.Location = New System.Drawing.Point(365, 120)
        Me.lbl_autorizacionERROR.Name = "lbl_autorizacionERROR"
        Me.lbl_autorizacionERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_autorizacionERROR.TabIndex = 27
        Me.lbl_autorizacionERROR.Text = "   "
        Me.lbl_autorizacionERROR.Visible = False
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(419, 47)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "   Carga de Cupones"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_banco
        '
        Me.cmb_banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_banco.FormattingEnabled = True
        Me.cmb_banco.Location = New System.Drawing.Point(143, 185)
        Me.cmb_banco.Name = "cmb_banco"
        Me.cmb_banco.Size = New System.Drawing.Size(216, 25)
        Me.cmb_banco.TabIndex = 4
        '
        'cmb_entidad
        '
        Me.cmb_entidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_entidad.FormattingEnabled = True
        Me.cmb_entidad.Location = New System.Drawing.Point(143, 216)
        Me.cmb_entidad.Name = "cmb_entidad"
        Me.cmb_entidad.Size = New System.Drawing.Size(216, 25)
        Me.cmb_entidad.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Banco asociado (*)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Entidad Crediticia (*)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Precio (*)"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(143, 152)
        Me.txt_precio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(216, 25)
        Me.txt_precio.TabIndex = 3
        '
        'lbl_precioERROR
        '
        Me.lbl_precioERROR.AutoSize = True
        Me.lbl_precioERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_precioERROR.Location = New System.Drawing.Point(365, 155)
        Me.lbl_precioERROR.Name = "lbl_precioERROR"
        Me.lbl_precioERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_precioERROR.TabIndex = 27
        Me.lbl_precioERROR.Text = "   "
        Me.lbl_precioERROR.Visible = False
        '
        'FormCupones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(419, 403)
        Me.Controls.Add(Me.cmb_entidad)
        Me.Controls.Add(Me.cmb_banco)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_precioERROR)
        Me.Controls.Add(Me.lbl_autorizacionERROR)
        Me.Controls.Add(Me.lbl_loteERROR)
        Me.Controls.Add(Me.lbl_cuponERROR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_numero_autorizacion)
        Me.Controls.Add(Me.txt_numero_lote)
        Me.Controls.Add(Me.txt_numero_cupon)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormCupones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cupón"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_cupon As System.Windows.Forms.TextBox
    Friend WithEvents txt_numero_lote As System.Windows.Forms.TextBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents txt_numero_autorizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_cuponERROR As System.Windows.Forms.Label
    Friend WithEvents lbl_loteERROR As System.Windows.Forms.Label
    Friend WithEvents lbl_autorizacionERROR As System.Windows.Forms.Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_banco As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_entidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents lbl_precioERROR As System.Windows.Forms.Label
End Class
