<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormParaBuscarCupones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormParaBuscarCupones))
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grid1 = New System.Windows.Forms.DataGridView()
        Me.id_cupon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero_lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero_autorizacion_online = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_buscarTARJETA = New System.Windows.Forms.Button()
        Me.btn_buscarBANCO = New System.Windows.Forms.Button()
        Me.cmb_tarjetaBUSCAR = New System.Windows.Forms.ComboBox()
        Me.cmb_bancoBUSCAR = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(90, 61)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(126, 20)
        Me.txt_buscar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar cupon:"
        '
        'grid1
        '
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_cupon, Me.numero_lote, Me.numero_autorizacion_online})
        Me.grid1.Location = New System.Drawing.Point(43, 221)
        Me.grid1.Name = "grid1"
        Me.grid1.Size = New System.Drawing.Size(244, 150)
        Me.grid1.TabIndex = 3
        '
        'id_cupon
        '
        Me.id_cupon.HeaderText = "id_cupon"
        Me.id_cupon.Name = "id_cupon"
        Me.id_cupon.Visible = False
        '
        'numero_lote
        '
        Me.numero_lote.HeaderText = "Numero Lote"
        Me.numero_lote.Name = "numero_lote"
        '
        'numero_autorizacion_online
        '
        Me.numero_autorizacion_online.HeaderText = "Nro.Autorizacion"
        Me.numero_autorizacion_online.Name = "numero_autorizacion_online"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cupones Registrados"
        '
        'btn_buscarTARJETA
        '
        Me.btn_buscarTARJETA.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_buscarTARJETA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscarTARJETA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscarTARJETA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_buscarTARJETA.Image = Global.PAV1_TPI.My.Resources.Resources.magnifier16
        Me.btn_buscarTARJETA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscarTARJETA.Location = New System.Drawing.Point(303, 150)
        Me.btn_buscarTARJETA.Name = "btn_buscarTARJETA"
        Me.btn_buscarTARJETA.Size = New System.Drawing.Size(25, 25)
        Me.btn_buscarTARJETA.TabIndex = 25
        Me.btn_buscarTARJETA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscarTARJETA.UseVisualStyleBackColor = True
        '
        'btn_buscarBANCO
        '
        Me.btn_buscarBANCO.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_buscarBANCO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscarBANCO.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscarBANCO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_buscarBANCO.Image = Global.PAV1_TPI.My.Resources.Resources.magnifier16
        Me.btn_buscarBANCO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscarBANCO.Location = New System.Drawing.Point(303, 119)
        Me.btn_buscarBANCO.Name = "btn_buscarBANCO"
        Me.btn_buscarBANCO.Size = New System.Drawing.Size(25, 25)
        Me.btn_buscarBANCO.TabIndex = 20
        Me.btn_buscarBANCO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscarBANCO.UseVisualStyleBackColor = True
        '
        'cmb_tarjetaBUSCAR
        '
        Me.cmb_tarjetaBUSCAR.BackColor = System.Drawing.Color.White
        Me.cmb_tarjetaBUSCAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tarjetaBUSCAR.ForeColor = System.Drawing.Color.Black
        Me.cmb_tarjetaBUSCAR.FormattingEnabled = True
        Me.cmb_tarjetaBUSCAR.Location = New System.Drawing.Point(90, 150)
        Me.cmb_tarjetaBUSCAR.Name = "cmb_tarjetaBUSCAR"
        Me.cmb_tarjetaBUSCAR.Size = New System.Drawing.Size(207, 25)
        Me.cmb_tarjetaBUSCAR.TabIndex = 24
        Me.cmb_tarjetaBUSCAR.Text = "(seleccione Tarjeta)"
        '
        'cmb_bancoBUSCAR
        '
        Me.cmb_bancoBUSCAR.BackColor = System.Drawing.Color.White
        Me.cmb_bancoBUSCAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_bancoBUSCAR.ForeColor = System.Drawing.Color.Black
        Me.cmb_bancoBUSCAR.FormattingEnabled = True
        Me.cmb_bancoBUSCAR.Location = New System.Drawing.Point(90, 119)
        Me.cmb_bancoBUSCAR.Name = "cmb_bancoBUSCAR"
        Me.cmb_bancoBUSCAR.Size = New System.Drawing.Size(207, 25)
        Me.cmb_bancoBUSCAR.TabIndex = 22
        Me.cmb_bancoBUSCAR.Text = "(seleccione Banco)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(34, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Tarjeta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(40, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Banco"
        '
        'FormParaBuscarCupones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(337, 406)
        Me.Controls.Add(Me.btn_buscarTARJETA)
        Me.Controls.Add(Me.btn_buscarBANCO)
        Me.Controls.Add(Me.cmb_tarjetaBUSCAR)
        Me.Controls.Add(Me.cmb_bancoBUSCAR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_buscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormParaBuscarCupones"
        Me.Text = "Cupones Registrados"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grid1 As System.Windows.Forms.DataGridView
    Friend WithEvents id_cupon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero_lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero_autorizacion_online As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_buscarTARJETA As System.Windows.Forms.Button
    Friend WithEvents btn_buscarBANCO As System.Windows.Forms.Button
    Friend WithEvents cmb_tarjetaBUSCAR As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_bancoBUSCAR As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
