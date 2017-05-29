Public Class FormVentasFORMASPAGO
    Enum respuesta_validacion
        _error
        _ok
    End Enum
    Dim total_con_descuento_sinfp As Double
    Private respuesta_validacion_actual As respuesta_validacion = respuesta_validacion._ok
    Dim valor_monto_inicial As Double
    Dim txt_error As String
    Dim monto_actual As Double
    Dim listado_cupones_mostrar As New ArrayList
    Dim listado_cupones_grabar As New ArrayList
    Dim cadena As String = ""

    Private Sub FormVentasFORMASPAGO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoporteGUI.cargar_combo(cmb_formaPago, SoporteBD.leerBD_simple("SELECT * FROM formas_pago ORDER BY nombre"), "id_forma_pago", "nombre")
        SoporteGUI.cargar_combo(cmb_banco, SoporteBD.leerBD_simple("SELECT * FROM bancos"), "id_banco", "nombre")
        SoporteGUI.cargar_combo(cmb_entidad, SoporteBD.leerBD_simple("SELECT * FROM entidades_crediticias"), "id_entidad_crediticia", "nombre")

        Me.habilitar_cupon(False)
        Me.txt_subtotalFACTURA.Text = Venta.total
        total_con_descuento_sinfp = Math.Round(Convert.ToDouble(Me.txt_subtotalFACTURA.Text))
        Me.txt_monto_formapago.Text = Math.Round(Convert.ToDouble(Me.txt_subtotalFACTURA.Text))
        Me.cmb_formaPago.SelectedIndex = -1
        Me.limpiar_campos()
        Me.btn_agregarFORMAPAGO.Enabled = True
        Me.cmb_formaPago.Enabled = True
        'Me.txt_monto.Text = Cupon.precio
    End Sub

    Private Sub limpiar_formapago()
        Me.cmb_formaPago.SelectedIndex = -1
        'Me.txt_monto_formapago.Text = 0
    End Sub

    Private Sub limpiar_campos()
        Me.txt_numero_cupon.Text = ""
        Me.txt_numero_lote.Text = ""
        Me.txt_numero_autorizacion.Text = ""
        Me.txt_monto_cupon.Text = ""
        Me.cmb_banco.SelectedIndex = -1
        Me.cmb_entidad.SelectedIndex = -1
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

        If txt_monto_cupon.Text = "" Then
            lbl_montoERROR.Visible = True
            txt_monto_cupon.Focus()
            rdo = respuesta_validacion._error
            mensaje &= vbCrLf & "- producto"
        End If

        If cmb_banco.SelectedValue = Nothing Then
            lbl_bancoERROR.Visible = True
            cmb_banco.Focus()
            rdo = respuesta_validacion._error
            mensaje &= vbCrLf & "- banco"
        End If

        If cmb_entidad.SelectedValue = Nothing Then
            lbl_entidadERROR.Visible = True
            cmb_entidad.Focus()
            rdo = respuesta_validacion._error
            mensaje &= vbCrLf & "- entidad crediticia"
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
        Dim c As Integer
        Dim contador As Integer
        For c = 0 To Me.dgv_formaPago.Rows.Count - 1
            If Me.dgv_formaPago.Rows(c).Cells("col_flag").Value = True Then
                contador = contador + 1
            End If
        Next

        If contador > 0 Then
            MessageBox.Show("Faltan cupones por cargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If contador = 0 Then
            SoporteGUI.respuesta_ventana = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Structure estructura_cupon_mostrar
        Public numero_cupon As Integer
        Public numero_lote As Integer
        Public numero_autorizacion As Integer
        Public monto_cupon As Double
        Public banco_cupon As Integer
        Public entidad_cupon As Integer
    End Structure

    Private Sub agregar_cupon_mostrar(ByVal cupon As Integer, ByVal lote As Integer, ByVal autorizacion As Integer, _
                                      ByVal monto As Double, banco As Integer, entidad As Integer)

        Dim obj_cupon As estructura_cupon_mostrar

        obj_cupon.numero_cupon = cupon
        obj_cupon.numero_lote = lote
        obj_cupon.numero_autorizacion = autorizacion
        obj_cupon.monto_cupon = monto
        obj_cupon.banco_cupon = banco
        obj_cupon.entidad_cupon = entidad

        listado_cupones_mostrar.Add(obj_cupon)

    End Sub

    Private Structure estructura_cupon_grabar
        Public numero_cupon As Integer
        Public numero_lote As Integer
        Public numero_autorizacion As Integer
        Public monto_cupon As Double
    End Structure

    Private Sub agregar_cupon_grabar(ByVal cupon As Integer, ByVal lote As Integer, ByVal autorizacion As Integer, ByVal monto As Double)

        Dim obj_cupon As estructura_cupon_grabar

        obj_cupon.numero_cupon = cupon
        obj_cupon.numero_lote = lote
        obj_cupon.numero_autorizacion = autorizacion
        obj_cupon.monto_cupon = monto

        listado_cupones_mostrar.Add(obj_cupon)

    End Sub

    Private Sub limpiar_cupon()
        Me.txt_numero_cupon.Text = ""
        Me.txt_numero_autorizacion.Text = ""
        Me.txt_numero_lote.Text = ""
        Me.cmb_banco.SelectedValue = -1
        Me.cmb_entidad.SelectedValue = -1
    End Sub

    Private Sub dgv_formaPago_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_formaPago.CellContentClick

        If dgv_formaPago.CurrentRow.Cells(0).Value = "DÉBITO" Then
            If dgv_formaPago.CurrentRow.Cells("col_flag").Value = False Then
                habilitar_cupon(False)
            Else
                Me.limpiar_cupon()
                Me.habilitar_cupon(True)
                Me.txt_monto_cupon.Text = Math.Round(Convert.ToDouble(Me.dgv_formaPago.CurrentRow().Cells("col_montoDTO").Value))
            End If
        End If


        If dgv_formaPago.CurrentRow.Cells(0).Value = "CRÉDITO" Then
            If dgv_formaPago.CurrentRow.Cells("col_flag").Value = False Then
                habilitar_cupon(False)
            Else
                Me.limpiar_cupon()
                Me.habilitar_cupon(True)
                Me.txt_monto_cupon.Text = Math.Round(Convert.ToDouble(Me.dgv_formaPago.CurrentRow().Cells("col_montoDTO").Value))
            End If
        End If


        If dgv_formaPago.CurrentRow.Cells(0).Value = "EFECTIVO" Then
            Me.btn_aceptar.Enabled = True
            Me.limpiar_cupon()
            Me.habilitar_cupon(False)
        End If


        Me.txt_monto_formapago.Text = Me.dgv_formaPago.CurrentRow.Cells(2).Value
        Me.txt_monto_formapago.Enabled = False

        Me.cmb_formaPago.SelectedValue = Me.dgv_formaPago.CurrentRow.Cells(4).Value
        Me.cmb_formaPago.Enabled = False

        Me.btn_agregarFORMAPAGO.Enabled = False
        Me.btn_aceptar_formapago.Enabled = True
        Me.btn_eliminarFORMAPAGO.Enabled = True
        'Me.btn_aceptar.Enabled = True


    End Sub

    Private Function validar_formapago()
        txt_error = "Hay campos obligatorios sin completar:"
        Dim flag As Boolean = True
        If Me.cmb_formaPago.SelectedIndex = -1 Then
            txt_error &= vbCrLf & "-Forma de pago"
            flag = False
        End If

        If Me.txt_monto_formapago.Text = "" Then
            txt_error &= vbCrLf & "-Monto"
            flag = False
        End If

        If flag = False Then
            Return respuesta_validacion._error
        End If

        Return respuesta_validacion._ok

    End Function

    Private Sub cargar_tabla_formapago()
        Dim tabla_porcentaje As New DataTable
        Dim consulta_porcentaje As String = ""
        consulta_porcentaje &= "SELECT porcentaje FROM formas_pago WHERE id_forma_pago = " & Me.cmb_formaPago.SelectedValue
        tabla_porcentaje = SoporteBD.leerBD_simple(consulta_porcentaje)
        Dim porcentaje As Double = tabla_porcentaje.Rows(0)("porcentaje")

        'Dim tabla_formaspago As New DataTable
        'Dim consulta_formaspago As String = ""
        'consulta_formaspago &= "SELECT nombre FROM formas_pago WHERE id_forma_pago = " & Me.cmb_formaPago.SelectedValue
        'tabla_formaspago = SoporteBD.leerBD_simple(consulta_formaspago)
        'Dim forma_de_pago As String = tabla_formaspago.Rows(0)("nombre")

        Dim monto_sin_descuento As Double = Convert.ToDouble(Me.txt_monto_formapago.Text)

        If cmb_formaPago.Text = "EFECTIVO" Then
            Me.dgv_formaPago.Rows.Add(Me.cmb_formaPago.Text, porcentaje, monto_sin_descuento, Math.Round((1 - porcentaje) * monto_sin_descuento), Me.cmb_formaPago.SelectedValue, False)
            Me.calcular_monto_formapago()
            Me.calcular_total_con_dto_formapago()
            If txt_monto_formapago.Enabled = False Then
                Me.btn_aceptar.Enabled = True
            End If
        End If

        If cmb_formaPago.Text = "DÉBITO" Or cmb_formaPago.Text = "CRÉDITO" Then
            Me.dgv_formaPago.Rows.Add(Me.cmb_formaPago.Text, porcentaje, monto_sin_descuento, Math.Round((1 - porcentaje) * monto_sin_descuento), Me.cmb_formaPago.SelectedValue, True)
            Me.calcular_monto_formapago()
            Me.calcular_total_con_dto_formapago()
        End If

        Me.dgv_formaPago.Enabled = True
    End Sub

    Private Sub calcular_monto_formapago()
        Dim c As Integer
        Dim monto_sin_descuento As Double = 0
        For c = 0 To Me.dgv_formaPago.Rows.Count - 1
            monto_sin_descuento = monto_sin_descuento + Convert.ToDouble(Me.dgv_formaPago.Rows(c).Cells("col_montoSINDTO").Value)
        Next
        Me.txt_monto_formapago.Text = total_con_descuento_sinfp - monto_sin_descuento
        monto_actual = Convert.ToDouble(Me.txt_monto_formapago.Text)
    End Sub

    Private Sub calcular_total_con_dto_formapago()
        Dim c As Integer
        Dim precio_con_dto As Integer = 0
        For c = 0 To dgv_formaPago.Rows.Count - 1
            precio_con_dto = precio_con_dto + Math.Round(Convert.ToDouble(Me.dgv_formaPago.Rows(c).Cells("col_montoDTO").Value))
        Next
        Me.txt_totalFACTURA.Text = precio_con_dto
    End Sub

    Private Sub btn_agregarFORMAPAGO_Click(sender As Object, e As EventArgs) Handles btn_agregarFORMAPAGO.Click

        If validar_formapago() = respuesta_validacion._ok Then
            Dim total_a_pagar As Double = Convert.ToDouble(Me.txt_subtotalFACTURA.Text)
            valor_monto_inicial = Math.Round(Convert.ToDouble(Me.txt_monto_formapago.Text))

            If Me.dgv_formaPago.Rows.Count > 0 Then
                If Convert.ToDouble(txt_monto_formapago.Text) > valor_monto_inicial Then
                    MsgBox("El monto no puede ser mayor que el total a abonar", MsgBoxStyle.OkOnly, "Error")
                    Me.txt_monto_formapago.Text = valor_monto_inicial
                Else
                    Me.cargar_tabla_formapago()
                End If
            End If

            If Me.dgv_formaPago.Rows.Count = 0 Then
                If Convert.ToDouble(txt_monto_formapago.Text) > total_con_descuento_sinfp Then
                    Me.calcular_monto_formapago()
                    MsgBox("El monto no puede ser mayor que el total a abonar", MsgBoxStyle.OkOnly, "Error")
                Else
                    valor_monto_inicial = total_a_pagar - Convert.ToDouble(Me.txt_monto_formapago.Text)
                    Me.cargar_tabla_formapago()
                End If
            End If

            Dim d As Integer
            Dim sumatoria As Integer
            For d = 0 To Me.dgv_formaPago.Rows.Count - 1
                sumatoria = sumatoria + Math.Round(Convert.ToDouble(Me.dgv_formaPago.Rows(d).Cells("col_montoSINDTO").Value))
            Next

            If sumatoria = valor_monto_inicial Then
                Return
            End If

            If sumatoria > total_a_pagar Then
                MsgBox("Valor mayor al monto faltante, reintentar", MsgBoxStyle.OkOnly, "Error")
                Dim ultima_fila As Integer
                ultima_fila = Me.dgv_formaPago.Rows().GetLastRow(DataGridViewElementStates.None)
                Me.dgv_formaPago.Rows.RemoveAt(ultima_fila)
                Me.calcular_monto_formapago()
                Me.calcular_total_con_dto_formapago()
            End If

        Else
            MessageBox.Show(txt_error, "CLOTTA _ Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub btn_eliminarFORMAPAGO_Click(sender As Object, e As EventArgs) Handles btn_eliminarFORMAPAGO.Click

        If Me.dgv_formaPago.Rows.Count > 0 Then
            Me.dgv_formaPago.Rows.Remove(Me.dgv_formaPago.CurrentRow)
            Me.limpiar_formapago()
            'Me.calcular_total_venta()
        End If

        Me.btn_agregarFORMAPAGO.Enabled = True
        Me.btn_eliminarFORMAPAGO.Enabled = False
        Me.btn_aceptar_formapago.Enabled = False

        Me.cmb_formaPago.Enabled = True
        Me.cmb_formaPago.SelectedIndex = -1


        Me.calcular_monto_formapago()
        Me.calcular_total_con_dto_formapago()
        Me.txt_monto_formapago.Enabled = True
    End Sub

    Private Sub habilitar_cupon(ByVal flag As Boolean)
        Me.txt_numero_cupon.Enabled = flag
        Me.txt_numero_autorizacion.Enabled = flag
        Me.txt_numero_lote.Enabled = flag
        'Me.txt_monto_cupon.Enabled = flag
        Me.cmb_banco.Enabled = flag
        Me.cmb_entidad.Enabled = flag
        Me.btn_guardar_cupon.Enabled = flag
    End Sub

    Private Sub txt_totalFACTURA_TextChanged(sender As Object, e As EventArgs) Handles txt_totalFACTURA.TextChanged
        If dgv_formaPago.Rows.Count = 0 Then
            Me.txt_totalFACTURA.Text = 0
        Else
            Dim c As Integer
            Dim total_actual As Double
            For c = 0 To dgv_formaPago.Rows.Count - 1
                total_actual = total_actual + Math.Round(Convert.ToDouble(Me.dgv_formaPago.Rows(c).Cells("col_montoDTO").Value))
            Next
            Me.txt_totalFACTURA.Text = total_actual
        End If

    End Sub

    Private Sub txt_monto_formapago_TextChanged(sender As Object, e As EventArgs) Handles txt_monto_formapago.TextChanged
        If txt_monto_formapago.Text = "" Then
            Return
        End If
        If Me.dgv_formaPago.Rows.Count > 0 Then
            If Convert.ToDouble(txt_monto_formapago.Text) = 0 Then
                Me.txt_monto_formapago.Enabled = False
                Me.btn_agregarFORMAPAGO.Enabled = False
            Else
                Me.txt_monto_formapago.Enabled = True
            End If
        End If
    End Sub

    Private Sub btn_guardar_cupon_Click(sender As Object, e As EventArgs) Handles btn_guardar_cupon.Click
        If validar_campos() = respuesta_validacion._ok Then
            If validar_cupon() = respuesta_validacion._ok Then
                If MessageBox.Show("¿Los datos ingresados son correctos?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

                    If Convert.ToString(Me.dgv_formaPago.CurrentRow.Cells("forma_pago").Value) = "EFECTIVO" Then
                        concatenador_ventaxformapago(Convert.ToInt32(Me.dgv_formaPago.CurrentRow.Cells("col_id_formapago").Value), _
                                     Convert.ToDouble(Me.dgv_formaPago.CurrentRow.Cells("col_montoDTO").Value), _
                                     0, _
                                     0, _
                                     0)
                    End If

                    If Convert.ToString(Me.dgv_formaPago.CurrentRow.Cells("forma_pago").Value) = "DÉBITO" Then
                        concatenador_ventaxformapago(Convert.ToInt32(Me.dgv_formaPago.CurrentRow.Cells("col_id_formapago").Value), _
                                     Convert.ToDouble(Me.dgv_formaPago.CurrentRow.Cells("col_montoDTO").Value), _
                                     Me.txt_numero_cupon.Text, _
                                     cmb_banco.SelectedValue, _
                                     cmb_entidad.SelectedValue)

                        Me.dgv_formaPago.CurrentRow.Cells("col_flag").Value = False

                        concatenador_cupones(Me.txt_numero_cupon.Text, Me.txt_numero_lote.Text, Me.txt_numero_autorizacion.Text, _
                                             Convert.ToDouble(Me.txt_monto_cupon.Text))
                    End If

                    If Convert.ToString(Me.dgv_formaPago.CurrentRow.Cells("forma_pago").Value) = "CRÉDITO" Then
                        concatenador_ventaxformapago(Convert.ToInt32(Me.dgv_formaPago.CurrentRow.Cells("col_id_formapago").Value), _
                                     Convert.ToDouble(Me.dgv_formaPago.CurrentRow.Cells("col_montoDTO").Value), _
                                     Me.txt_numero_cupon.Text, _
                                     cmb_banco.SelectedValue, _
                                     cmb_entidad.SelectedValue)

                        Me.dgv_formaPago.CurrentRow.Cells("col_flag").Value = False

                        concatenador_cupones(Me.txt_numero_cupon.Text, Me.txt_numero_lote.Text, Me.txt_numero_autorizacion.Text, _
                                             Convert.ToDouble(Me.txt_monto_cupon.Text))
                    End If

                End If

            End If
        End If

    End Sub

    Private Sub concatenador_cupones(ByVal id_cupon As Integer, ByVal numero_lote As Integer, ByVal numero_autorizacion As Integer, precio As Double)

        Dim sql As String = ""
        sql &= "INSERT INTO cupon(id_cupon,numero_lote,numero_autorizacion_online,precio) VALUES("
        sql &= id_cupon
        sql &= ", " & numero_lote
        sql &= ", " & numero_autorizacion
        sql &= ", " & precio
        sql &= ")"
        sql &= vbCrLf

        cadena = cadena + sql

    End Sub

    Private Sub concatenador_ventaxformapago(ByVal id_forma_pago As Integer, ByVal monto_vxfp As Double, ByVal id_cupon As Integer, _
                                             ByVal id_banco As Integer, ByVal id_entidad_crediticia As Integer)
        Dim sql As String = ""
        sql &= " INSERT INTO ventasXformas_pago(id_venta,id_forma_pago,monto_vxfp,id_cupon,id_banco,id_entidad_crediticia)"
        sql &= " VALUES( "
        sql &= Venta.id_venta
        sql &= ", " & id_forma_pago
        sql &= ", " & monto_vxfp
        sql &= ", " & id_cupon
        sql &= ", " & id_banco
        sql &= ", " & id_entidad_crediticia
        sql &= ")"
        sql &= vbCrLf

        cadena = cadena + sql

    End Sub

    Public Function get_string_ventaxformapago()
        Return cadena
    End Function

    Private Sub btn_aceptar_formapago_Click(sender As Object, e As EventArgs) Handles btn_aceptar_formapago.Click
        Me.btn_eliminarFORMAPAGO.Enabled = False
        Me.btn_agregarFORMAPAGO.Enabled = True
        Me.btn_aceptar_formapago.Enabled = False
        Me.limpiar_formapago()

    End Sub

End Class