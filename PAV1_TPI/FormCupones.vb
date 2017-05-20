Public Class FormCupones
    Enum respuesta_validacion
        _error
        _ok
    End Enum

    Private Sub FormTarjetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txt_numero_cupon.Focus()
    End Sub


    'SUBRUTINA PARA INSERTAR TARJETAS A LA BD
    Private Sub insertar()
        Dim sql As String = ""
        sql &= "INSERT INTO cupon( "
        sql &= "id_cupon, "
        sql &= "numero_lote,"
        sql &= "numero_autorizacion_online)"
        sql &= "VALUES("
        sql &= txt_numero_cupon.Text
        sql &= ", " & txt_numero_lote.Text
        sql &= ", " & txt_numero_autorizacion.Text
        sql &= ") "

        SoporteBD.escribirBD_simple(sql)
    End Sub

    'FUNCION QUE VALIDA LOS CAMPOS X
    Private Function validar_campos() As respuesta_validacion
        Me.ocultar_lblERROR()
        Dim rdo = respuesta_validacion._ok
        If txt_numero_cupon.Text = "" Then
            lbl_cuponERROR.Visible = True
            txt_numero_cupon.Focus()
            rdo = respuesta_validacion._error
            MsgBox("El número del cupón no fue ingresado", MsgBoxStyle.OkOnly, "Error")
        End If
        If txt_numero_lote.Text = "" Then
            lbl_loteERROR.Visible = True
            txt_numero_lote.Focus()
            rdo = respuesta_validacion._error
            MsgBox("El número de lote no fue ingresado", MsgBoxStyle.OkOnly, "Error")
        End If
        If txt_numero_autorizacion.Text = "" Then
            lbl_autorizacionERROR.Visible = True
            txt_numero_autorizacion.Focus()
            rdo = respuesta_validacion._error
            MsgBox("El número de autorización no fue ingresado", MsgBoxStyle.OkOnly, "Error")
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

                    MsgBox("¡Datos ingresados!", MessageBoxButtons.OK, "Carga de cupones")

                    Me.Close()

                End If

            End If

        End If

    End Sub


End Class