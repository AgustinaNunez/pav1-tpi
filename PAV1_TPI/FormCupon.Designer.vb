<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCupon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCupon))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_numero_cupon = New System.Windows.Forms.TextBox()
        Me.txt_numero_lote = New System.Windows.Forms.TextBox()
        Me.txt_numero_autorizacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_cuponERROR = New System.Windows.Forms.Label()
        Me.lbl_loteERROR = New System.Windows.Forms.Label()
        Me.lbl_autorizacionERROR = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Carga de cupones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "N° Cupón: (*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "N° Lote: (*)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "N° Autorizacion: (*)"
        '
        'txt_numero_cupon
        '
        Me.txt_numero_cupon.Location = New System.Drawing.Point(128, 78)
        Me.txt_numero_cupon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_numero_cupon.Name = "txt_numero_cupon"
        Me.txt_numero_cupon.Size = New System.Drawing.Size(238, 25)
        Me.txt_numero_cupon.TabIndex = 0
        '
        'txt_numero_lote
        '
        Me.txt_numero_lote.Location = New System.Drawing.Point(128, 111)
        Me.txt_numero_lote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_numero_lote.Name = "txt_numero_lote"
        Me.txt_numero_lote.Size = New System.Drawing.Size(238, 25)
        Me.txt_numero_lote.TabIndex = 1
        '
        'txt_numero_autorizacion
        '
        Me.txt_numero_autorizacion.Location = New System.Drawing.Point(128, 144)
        Me.txt_numero_autorizacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_numero_autorizacion.Name = "txt_numero_autorizacion"
        Me.txt_numero_autorizacion.Size = New System.Drawing.Size(238, 25)
        Me.txt_numero_autorizacion.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 179)
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
        Me.btn_aceptar.Location = New System.Drawing.Point(85, 216)
        Me.btn_aceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(100, 41)
        Me.btn_aceptar.TabIndex = 3
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.White
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_cancelar.Image = Global.PAV1_TPI.My.Resources.Resources.trash_bin32
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(234, 216)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(100, 41)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Image = Global.PAV1_TPI.My.Resources.Resources.clotta_nombre
        Me.Label4.Location = New System.Drawing.Point(298, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 33)
        Me.Label4.TabIndex = 26
        '
        'lbl_cuponERROR
        '
        Me.lbl_cuponERROR.AutoSize = True
        Me.lbl_cuponERROR.Image = Global.PAV1_TPI.My.Resources.Resources.close_cross16
        Me.lbl_cuponERROR.Location = New System.Drawing.Point(372, 81)
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
        Me.lbl_loteERROR.Location = New System.Drawing.Point(372, 114)
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
        Me.lbl_autorizacionERROR.Location = New System.Drawing.Point(372, 148)
        Me.lbl_autorizacionERROR.Name = "lbl_autorizacionERROR"
        Me.lbl_autorizacionERROR.Size = New System.Drawing.Size(20, 17)
        Me.lbl_autorizacionERROR.TabIndex = 27
        Me.lbl_autorizacionERROR.Text = "   "
        Me.lbl_autorizacionERROR.Visible = False
        '
        'FormCupon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(419, 274)
        Me.Controls.Add(Me.lbl_autorizacionERROR)
        Me.Controls.Add(Me.lbl_loteERROR)
        Me.Controls.Add(Me.lbl_cuponERROR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.txt_numero_autorizacion)
        Me.Controls.Add(Me.txt_numero_lote)
        Me.Controls.Add(Me.txt_numero_cupon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormCupon"
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
    Friend WithEvents txt_numero_cupon As System.Windows.Forms.TextBox
    Friend WithEvents txt_numero_lote As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents txt_numero_autorizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_cuponERROR As System.Windows.Forms.Label
    Friend WithEvents lbl_loteERROR As System.Windows.Forms.Label
    Friend WithEvents lbl_autorizacionERROR As System.Windows.Forms.Label
End Class
