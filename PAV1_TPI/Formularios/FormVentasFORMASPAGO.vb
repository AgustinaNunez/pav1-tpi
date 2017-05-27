Public Class FormVentasFORMASPAGO
    Enum respuesta_validacion
        _error
        _ok
    End Enum

    Private Sub FormVentasFORMASPAGO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoporteGUI.cargar_combo(cmb_formaPago, SoporteBD.leerBD_simple("SELECT * FROM formas_pago ORDER BY nombre"), "id_forma_pago", "nombre")
        SoporteGUI.cargar_combo(cmb_banco, SoporteBD.leerBD_simple("SELECT * FROM bancos"), "id_banco", "nombre")
        SoporteGUI.cargar_combo(cmb_entidad, SoporteBD.leerBD_simple("SELECT * FROM entidades_crediticias"), "id_entidad_crediticia", "nombre")

        Me.habilitar_campos(False)
        Me.txt_subtotalFACTURA.Text = Venta.subtotal
        Me.txt_totalFACTURA.Text = Venta.subtotal
        Me.cmb_formaPago.SelectedIndex = -1
        Me.limpiar_campos()
        'Me.txt_monto.Text = Cupon.precio
    End Sub

    Private Sub limpiar_campos()
        Me.txt_numero_cupon.Text = ""
        Me.txt_numero_lote.Text = ""
        Me.txt_numero_autorizacion.Text = ""
        Me.txt_monto.Text = ""
        Me.cmb_banco.SelectedIndex = -1
        Me.cmb_entidad.SelectedIndex = -1
    End Sub

    'SUBRUTINA PARA INSERTAR TARJETAS A LA BD
    Private Sub insertar()
        Dim sql As String = ""
        sql &= "INSERT INTO cupon( "
        sql &= "id_cupon, "
        sql &= "numero_lote,"
        sql &= "numero_autorizacion_online,"
        sql &= "precio)"
        sql &= "VALUES("
        sql &= txt_numero_cupon.Text
        sql &= ", " & txt_numero_lote.Text
        sql &= ", " & txt_numero_autorizacion.Text
        sql &= ", " & txt_monto.Text
        sql &= ") "

        SoporteBD.escribirBD_simple(sql)
    End Sub

    'FUNCION QUE VALIDA LOS CAMPOS X
    Private Function validar_campos() As respuesta_validacion
        Dim mensaje As String = "Hay campos por completar: "
        Me.ocultar_lblERROR()
        Dim rdo = respuesta_validacion._ok
        If txt_numero_cupon.Text = "" Then
            lbl_cuponERROR.Visible = True
            txt_numero_cupon.Focus()
            rdo = respuesta_validacion._error
            mensaje &= vbCrLf & "- número de cupón"
        End If
        If txt_numero_lote.Text = "" Then
            lbl_loteERROR.Visible = True
            txt_numero_lote.Focus()
            rdo = respuesta_validacion._error
            mensaje &= vbCrLf & "- número de lote"
        End If
        If txt_numero_autorizacion.Text = "" Then
            lbl_autorizacionERROR.Visible = True
            txt_numero_autorizacion.Focus()
            rdo = respuesta_validacion._error
            mensaje &= vbCrLf & "- número de autorización"
        End If

        If txt_monto.Text = "" Then
            lbl_montoERROR.Visible = True
            txt_monto.Focus()
            rdo = respuesta_validacion._error
            mensaje &= vbCrLf & "- producto"
        End If

        If rdo = respuesta_validacion._error Then
            MsgBox(mensaje, MsgBoxStyle.OkOnly, "Error")
        End If
        Return rdo
    End Function

    'SUBRUTINA QUE OCULTA LOS X
    Private Sub ocultar_lblERROR()
        lbl_autorizacionERROR.Visible = False
        lbl_cuponERROR.Visible = False
        lbl_loteERROR.Visible = False
    End Sub


    Private Function validar_cupon()
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql &= "SELECT * from cupon WHERE id_cupon = " & Me.txt_numero_cupon.Text
        tabla = SoporteBD.leerBD_simple(sql)

        If tabla.Rows.Count = 1 Then
            MsgBox("El cupón ya existe en la base de datos", MsgBoxStyle.OkOnly, "Error")
            Return respuesta_validacion._error
        End If
        Return respuesta_validacion._ok
    End Function

    'BOTON ACEPTAR
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If validar_campos() = respuesta_validacion._ok Then
            If validar_cupon() = respuesta_validacion._ok Then
                If MessageBox.Show("¿Los datos ingresados son correctos?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    insertar()
                    Cupon.id_banco = Me.cmb_banco.SelectedValue
                    Cupon.id_cupon = Me.txt_numero_cupon.Text
                    Cupon.id_entidad_crediticia = Me.cmb_entidad.SelectedValue
                    SoporteGUI.respuesta_ventana = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    SoporteGUI.respuesta_ventana = Windows.Forms.DialogResult.Cancel
                End If
            End If
        End If
    End Sub

    Private Sub dgv_formaPago_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_formaPago.CellContentClick

    End Sub

    Private Sub btn_agregarFORMAPAGO_Click(sender As Object, e As EventArgs) Handles btn_agregarFORMAPAGO.Click

    End Sub

    Private Sub btn_eliminarFORMAPAGO_Click(sender As Object, e As EventArgs) Handles btn_eliminarFORMAPAGO.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub btn_agregarCUPON_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmb_formaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_formaPago.SelectedIndexChanged

    End Sub

    Private Sub cmb_formaPago_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_formaPago.SelectionChangeCommitted
        If Me.cmb_formaPago.SelectedIndex = 3 Then
            Me.habilitar_campos(True)
        Else
            Me.habilitar_campos(False)
        End If
    End Sub

    Private Sub habilitar_campos(ByVal flag As Boolean)
        Me.txt_numero_cupon.Enabled = flag
        Me.txt_numero_autorizacion.Enabled = flag
        Me.txt_numero_lote.Enabled = flag
        Me.txt_monto.Enabled = flag
        Me.cmb_banco.Enabled = flag
        Me.cmb_entidad.Enabled = flag
        Me.btn_aceptar.Enabled = flag
    End Sub
End Class