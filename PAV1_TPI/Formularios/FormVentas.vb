Imports System.ComponentModel
Imports System.Data.OleDb
Public Class FormVentas
    Dim hay_articulos_cargados As Boolean = False
    Dim subtotal As Double = 0
    Dim total As Double = 0
    Dim flag As Boolean = False
    Dim valor_monto_inicial As Double
    Dim frmCupon As New FormCupones
    Dim total_con_descuento_sinfp As Double = 0
    Private estado_actual_transaccion As estado_transaccion = estado_transaccion._sin_iniciar

    Enum estado_transaccion
        _iniciada
        _sin_iniciar
    End Enum

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoporteGUI.cargar_combo(cmb_tipoDocCLIENTE, SoporteBD.leerBD_simple("SELECT * FROM tipo_documento"), "id_tipo_documento", "nombre_tipo_documento")
        SoporteGUI.cargar_combo(cmb_producto, SoporteBD.leerBD_simple("SELECT * FROM productos ORDER BY descripcion"), "id_producto", "descripcion")
        SoporteGUI.cargar_combo(cmb_formaPago, SoporteBD.leerBD_simple("SELECT * FROM formas_pago ORDER BY nombre"), "id_forma_pago", "nombre")
        Me.txt_usuarioLogueado.Text = Usuario.apellido & ", " & Usuario.nombre
        Me.limpiar_camposVENTA()
        Me.limpiar_camposCLIENTE()
        Me.limpiar_camposDETALLE()
        Me.limpiar_camposFORMAPAGO()
        Me.txt_idVENTA.Text = Format(SoporteBD.autogenerar_codigo("AUTOGENERARCODIGO_ventas"), "000000")

    End Sub

    Private Sub btn_nuevaVENTA_Click(sender As Object, e As EventArgs) Handles btn_nuevaVENTA.Click
        If estado_actual_transaccion = estado_transaccion._iniciada Then
            If MessageBox.Show("¿Desea cancelar la transaccion?", "Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
                Return
            End If
        End If
        estado_actual_transaccion = estado_transaccion._iniciada
        Me.habilitar_camposVENTA()
        Me.limpiar_camposVENTA()
        Me.limpiar_camposCLIENTE()
        Me.limpiar_camposDETALLE()
        Me.limpiar_camposFORMAPAGO()
        Me.txt_nroDocCLIENTE.Focus()
        Me.txt_idVENTA.Text = SoporteBD.autogenerar_codigo("AUTOGENERARCODIGO_ventas")
        Me.dgv_detalle.Rows.Clear()
        Me.dgv_formaPago.Rows.Clear()
        Me.deshabilitar_formapago()
        Me.btn_guardarVENTA.Enabled = False
        Me.btn_agregarCUPON.Visible = False
        Me.chk_descuento.Enabled = False
        Me.chk_descuento.Checked = False

    End Sub

    Private Sub deshabilitar_formapago()
        Me.btn_agregarFORMAPAGO.Enabled = False
        Me.btn_eliminarFORMAPAGO.Enabled = False
        Me.btn_aceptar.Enabled = False
        Me.cmb_formaPago.Enabled = False
        Me.txt_montoFORMAPAGO.Enabled = False
        Me.dgv_formaPago.Enabled = False
    End Sub

    Private Sub limpiar_camposDETALLE()
        Me.cmb_producto.SelectedIndex = -1
        Me.txt_precio.Text = "0,00"
        Me.txt_cantidad.Text = "1"
    End Sub

    Private Sub limpiar_camposFORMAPAGO()
        Me.cmb_formaPago.SelectedIndex = -1
        Me.txt_montoFORMAPAGO.Text = "0,00"
    End Sub

    Private Sub limpiar_camposVENTA()
        'Me.txt_idVENTA.Text = "000000"
        Me.txt_fecha.Text = Today
        Me.txt_hora.Text = TimeOfDay
        Me.txt_subtotalVENTA.Text = "0"
        Me.txt_dtoVENTA.Text = "0"
        Me.txt_totalVENTA.Text = "0"
    End Sub

    Private Sub limpiar_camposCLIENTE()
        Me.cmb_tipoDocCLIENTE.SelectedIndex = -1
        Me.txt_nroDocCLIENTE.Text = ""
        Me.txt_nombreCLIENTE.Text = ""
    End Sub

    Private Sub habilitar_camposVENTA()
        'CLIENTE
        Me.cmb_tipoDocCLIENTE.Enabled = True
        Me.txt_nroDocCLIENTE.Enabled = True
        Me.btn_buscarCLIENTE.Enabled = True
        'DETALLE
        Me.cmb_producto.Enabled = True
        Me.txt_cantidad.Enabled = True
        Me.btn_agregarDETALLE.Enabled = True
    End Sub

    Private Sub habilitar_camposPAGO()
        'FORMA_PAGO
        Me.cmb_formaPago.Enabled = True
        Me.txt_montoFORMAPAGO.Enabled = True
        Me.btn_agregarFORMAPAGO.Enabled = True
    End Sub

    Private Sub btn_agregarDETALLE_Click(sender As Object, e As EventArgs) Handles btn_agregarDETALLE.Click
        If Me.hay_articulos_cargados = False Then
            Me.hay_articulos_cargados = True
            'Me.habilitar_camposPAGO()
        End If
        If validar_camposARTICULO() Then
            Dim cantidad As Integer = Convert.ToInt32(Me.txt_cantidad.Text)
            Dim precio As Integer = Convert.ToDouble(Me.txt_precio.Text)
            Me.dgv_detalle.Rows.Add(Me.cmb_producto.SelectedValue, Me.cmb_producto.Text, Me.txt_cantidad.Text, Me.txt_precio.Text, cantidad * precio)
            Me.calcular_subtotal()
            'Me.habilitar_camposPAGO()
            Me.limpiar_camposDETALLE()
            Me.txt_dtoVENTA.Enabled = True
            Me.chk_descuento.Enabled = True
        End If
    End Sub

    Private Function validar_camposARTICULO()
        Dim flag As Boolean = True
        Dim mensaje As String = "Hay campos obligatorios sin completar:"
        If Me.cmb_producto.SelectedIndex = -1 Then
            mensaje &= vbCrLf & "- producto"
            flag = False
        Else
            If Me.articulo_ya_cargado() Then
                Return False
            Else
                If Me.txt_precio.Text = "" Then
                    mensaje &= vbCrLf & "- precio"
                    flag = False
                End If
                If Me.txt_cantidad.Text = "" Then
                    mensaje &= vbCrLf & "- cantidad"
                    flag = False
                End If
            End If
        End If
        If flag = False Then
            MessageBox.Show(mensaje, "CLOTTA _ Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return flag
    End Function

    Private Function validar_camposFORMAPAGO()
        Dim flag As Boolean = True
        Dim mensaje As String = "Hay campos obligatorios sin completar:"
        If Me.cmb_formaPago.SelectedIndex = -1 Then
            mensaje &= vbCrLf & "- Forma de pago"
            flag = False
        Else
            If Me.formapago_ya_cargada() Then
                Return False
            Else
                If Me.txt_montoFORMAPAGO.Text = "" Then
                    mensaje &= vbCrLf & "- monto"
                    flag = False
                End If
            End If
        End If
        If flag = False Then
            MessageBox.Show(mensaje, "CLOTTA _ Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return flag
    End Function

    Private Function formapago_ya_cargada()
        Dim c As Integer
        For c = 0 To Me.dgv_formaPago.Rows.Count - 1
            If Me.dgv_formaPago.Rows(c).Cells(4).Value = Me.cmb_formaPago.SelectedValue Then
                MessageBox.Show("La forma de pago con " & cmb_formaPago.Text & " ya ha sido agregada.", "CLOTTA _ Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return True
            End If
        Next
        Return False
    End Function

    Private Function articulo_ya_cargado()
        Dim c As Integer
        For c = 0 To Me.dgv_detalle.Rows.Count - 1
            If Me.dgv_detalle.Rows(c).Cells(0).Value = Me.cmb_producto.SelectedValue Then
                If MessageBox.Show("El artículo " & Articulo.nombre & " ya ha sido agregado a la venta." & vbCrLf & "¿Desea modificar ese ítem de la venta?",
                                "CLOTTA _ Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                    Me.txt_cantidad.Text = Me.dgv_detalle.Rows(c).Cells(2).Value
                    Me.btn_modificarARTICULO.Enabled = True
                    Me.txt_cantidad.Focus()
                    Me.btn_eliminarDETALLE.Enabled = False
                    Me.btn_agregarDETALLE.Enabled = False
                    Me.cmb_producto.Enabled = False
                Else
                    Me.limpiar_camposDETALLE()
                End If
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub btn_buscarCLIENTE_Click(sender As Object, e As EventArgs) Handles btn_buscarCLIENTE.Click
        If Me.txt_nroDocCLIENTE.Text = "" Then
            Dim frmClientes = New FormClientes
            frmClientes.ShowDialog()
            If SoporteGUI.flag Then
                Me.txt_nombreCLIENTE.Text = Cliente.apellido & ", " & Cliente.nombre
                Me.txt_nroDocCLIENTE.Text = Cliente.nro_doc
                Me.cmb_tipoDocCLIENTE.SelectedValue = Cliente.tipo_doc
            End If
            Return
        End If

        Dim sql As String = ""
        sql &= "SELECT * FROM clientes c JOIN tipo_documento td ON c.tipo_documento = td.id_tipo_documento "
        sql &= " WHERE td.nombre_tipo_documento = '" & Me.cmb_tipoDocCLIENTE.Text & "'"
        sql &= " AND c.numero_documento = '" & Me.txt_nroDocCLIENTE.Text & "'"
        Dim tabla As New DataTable
        tabla = SoporteBD.leerBD_simple(sql)

        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No se encontró el cliente con " & Me.cmb_tipoDocCLIENTE.SelectedText & Me.txt_nroDocCLIENTE.Text & ".", "Gestión de Ventas",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txt_nroDocCLIENTE.Text = ""
            Me.txt_nroDocCLIENTE.Focus()
            Return
        End If

        Me.txt_nombreCLIENTE.Text = tabla.Rows(0)("apellido_cliente") & ", " & tabla.Rows(0)("nombre_cliente")
    End Sub

    'GENERADOR DE CODIGOS AUTOMATICOS ASCENDENTES
    'Private Function GENERARCODIGO() As Integer

    '    Dim RG As New OleDbCommand
    '    Dim conexion As New Data.OleDb.OleDbConnection
    '    Dim cmd As New Data.OleDb.OleDbCommand

    '    conexion.ConnectionString = SoporteBD.cadena_conexion_juan

    '    conexion.Open()
    '    cmd.Connection = conexion
    '    RG = New OleDbCommand("AUTOGENERARCODIGO_ventas", conexion)
    '    Dim PARAM As New OleDbParameter("@CODIGO", SqlDbType.Int)
    '    PARAM.Direction = ParameterDirection.Output
    '    With RG
    '        .CommandType = CommandType.StoredProcedure
    '        .Parameters.Add(PARAM)
    '        .ExecuteNonQuery()
    '        conexion.Close()
    '        Return .Parameters("@CODIGO").Value
    '    End With

    'End Function

    Private Sub btn_eliminarDETALLE_Click(sender As Object, e As EventArgs) Handles btn_eliminarDETALLE.Click
        If Me.dgv_detalle.Rows.Count > 0 Then
            Me.dgv_detalle.Rows.Remove(Me.dgv_detalle.CurrentRow)
            Me.calcular_subtotal()
        End If

        If Me.dgv_detalle.Rows.Count = 0 Then
            Me.txt_subtotalVENTA.Text = 0
            Me.txt_totalVENTA.Text = 0
            subtotal = 0
            Me.deshabilitar_formapago()
        End If

        Me.btn_agregarDETALLE.Enabled = True
        Me.btn_eliminarDETALLE.Enabled = False
        Me.btn_modificarARTICULO.Enabled = False
        Me.limpiar_camposDETALLE()
        Me.cmb_producto.Enabled = True

    End Sub

    Private Sub cmb_producto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_producto.SelectionChangeCommitted
        If cmb_producto.SelectedIndex = -1 Then
            Me.txt_precio.Text = "0,00"
        Else
            Dim tabla As New DataTable
            tabla = SoporteBD.leerBD_simple("SELECT precio_lista FROM productos WHERE id_producto = " & Me.cmb_producto.SelectedValue)
            Me.txt_precio.Text = tabla.Rows(0)("precio_lista")
        End If
    End Sub

    Private Sub btn_agregarCUPON_Click(sender As Object, e As EventArgs) Handles btn_agregarCUPON.Click
        Dim pago_debito As Integer = 2
        Dim pago_credito As Integer = 3
        Dim c As Integer
        For c = 0 To Me.dgv_formaPago.Rows.Count - 1
            If pago_debito = Me.dgv_formaPago.Rows(c).Cells("col_id_formapago").Value Then
                Dim frmCupon As New FormCupones
                frmCupon.ShowDialog()
                If SoporteGUI.respuesta_ventana = Windows.Forms.DialogResult.OK Then
                    Me.btn_guardarVENTA.Enabled = True
                    Me.btn_agregarCUPON.Enabled = False
                End If
            End If

            If pago_credito = Me.dgv_formaPago.Rows(c).Cells("col_id_formapago").Value Then
                Dim frmCupon As New FormCupones
                frmCupon.ShowDialog()
                'If frmCupon.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If SoporteGUI.respuesta_ventana = Windows.Forms.DialogResult.OK Then
                    Me.btn_guardarVENTA.Enabled = True
                    Me.btn_agregarCUPON.Enabled = False
                End If
            End If
        Next

        'Dim frmCupon As New FormCupones
        'frmCupon.ShowDialog()
        'Me.btn_guardarVENTA.Enabled = True
        'Me.btn_agregarCUPON.Enabled = False

    End Sub

    Private Sub btn_modificarARTICULO_Click(sender As Object, e As EventArgs) Handles btn_modificarARTICULO.Click
        Me.dgv_detalle.CurrentRow.Cells(2).Value = Me.txt_cantidad.Text
        Dim cantidad As Integer = Convert.ToInt32(Me.txt_cantidad.Text)
        Dim precio As Integer = Convert.ToDouble(Me.txt_precio.Text)
        Me.dgv_detalle.CurrentRow.Cells(4).Value = cantidad * precio
        Me.btn_modificarARTICULO.Enabled = False
        Me.btn_eliminarDETALLE.Enabled = False
        Me.btn_agregarDETALLE.Enabled = True
        Me.cmb_producto.Enabled = True

        Me.calcular_subtotal()
    End Sub

    Private Sub calcular_subtotal()
        subtotal = 0
        Dim c As Integer
        For c = 0 To dgv_detalle.Rows.Count - 1
            Dim cantidad As Integer = Me.dgv_detalle.Rows(c).Cells(3).Value
            Dim precio As Integer = Me.dgv_detalle.Rows(c).Cells(2).Value
            subtotal = Me.subtotal + (cantidad * precio)
        Next

        Me.txt_subtotalVENTA.Text = Me.subtotal
        Me.txt_totalVENTA.Text = Me.subtotal
        'Me.txt_montoFORMAPAGO.Text = Me.subtotal
    End Sub

    Private Sub dgv_detalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_detalle.CellContentClick, dgv_detalle.CellContentDoubleClick

        Me.cmb_producto.SelectedValue = Me.dgv_detalle.CurrentRow.Cells(0).Value
        Me.txt_precio.Text = Me.dgv_detalle.CurrentRow.Cells(3).Value
        Me.txt_cantidad.Text = Me.dgv_detalle.CurrentRow.Cells(2).Value

        Me.btn_eliminarDETALLE.Enabled = True
        Me.btn_modificarARTICULO.Enabled = True
        Me.btn_agregarDETALLE.Enabled = False
        Me.cmb_producto.Enabled = False
    End Sub

    Private Sub calcular_monto_formapago()
        Dim c As Integer
        'Dim total As Double = Convert.ToDouble(Me.txt_totalVENTA.Text)
        Dim monto_sin_descuento As Double
        For c = 0 To Me.dgv_formaPago.Rows.Count - 1
            monto_sin_descuento = monto_sin_descuento + Convert.ToDouble(Me.dgv_formaPago.Rows(c).Cells("col_montoSINDTO").Value)
        Next
        Me.txt_montoFORMAPAGO.Text = total_con_descuento_sinfp - monto_sin_descuento
    End Sub

    Private Sub cargar_tabla_formapago()
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql &= "SELECT porcentaje FROM formas_pago WHERE id_forma_pago = " & Me.cmb_formaPago.SelectedValue
        tabla = SoporteBD.leerBD_simple(sql)
        Dim porcentaje As Double = tabla.Rows(0)("porcentaje")

        Dim monto_sin_descuento As Double = Convert.ToDouble(Me.txt_montoFORMAPAGO.Text)

        If cmb_formaPago.SelectedValue <> 3 Then
            If cmb_formaPago.SelectedValue = 1 Then
                Me.dgv_formaPago.Rows.Add(Me.cmb_formaPago.Text, porcentaje, monto_sin_descuento, Math.Round((1 - porcentaje) * monto_sin_descuento), Me.cmb_formaPago.SelectedValue)
                Me.calcular_monto_formapago()
                Me.calcular_total_con_dto_formapago()
                Me.btn_guardarVENTA.Enabled = True
            Else
                Me.dgv_formaPago.Rows.Add(Me.cmb_formaPago.Text, porcentaje, monto_sin_descuento, Math.Round((1 - porcentaje) * monto_sin_descuento), Me.cmb_formaPago.SelectedValue)
                Me.calcular_monto_formapago()
                Me.calcular_total_con_dto_formapago()
            End If
        Else
            Me.dgv_formaPago.Rows.Add(Me.cmb_formaPago.Text, porcentaje, monto_sin_descuento, Math.Round(monto_sin_descuento), Me.cmb_formaPago.SelectedValue)
            Me.calcular_monto_formapago()
            Me.calcular_total_con_dto_formapago()
        End If
        Me.dgv_formaPago.Enabled = True
    End Sub

    Dim banderita As Boolean = False

    Private Sub btn_agregarFORMAPAGO_Click(sender As Object, e As EventArgs) Handles btn_agregarFORMAPAGO.Click

        If validar_camposFORMAPAGO() = True Then
            Dim total_a_pagar As Double = Convert.ToDouble(Me.txt_totalVENTA.Text)

            If Me.dgv_formaPago.Rows.Count > 0 Then
                If Convert.ToDouble(txt_montoFORMAPAGO.Text) > valor_monto_inicial Then
                    MsgBox("El monto no puede ser mayor que el total a abonar", MsgBoxStyle.OkOnly, "Error")
                    Me.txt_montoFORMAPAGO.Text = valor_monto_inicial
                Else
                    Me.cargar_tabla_formapago()
                End If
            End If

            If Me.dgv_formaPago.Rows.Count = 0 Then
                If Convert.ToDouble(txt_montoFORMAPAGO.Text) > total_con_descuento_sinfp Then
                    Me.calcular_monto_formapago()
                    MsgBox("El monto no puede ser mayor que el total a abonar", MsgBoxStyle.OkOnly, "Error")
                Else
                    valor_monto_inicial = total_a_pagar - Convert.ToDouble(Me.txt_montoFORMAPAGO.Text)
                    Me.cargar_tabla_formapago()
                End If
            End If

            If Me.dgv_formaPago.Rows.Count = 3 Then
                If Math.Round(Convert.ToDouble(txt_montoFORMAPAGO.Text)) > 0 Then
                    MsgBox("Queda monto por cargar, reintentar", MsgBoxStyle.OkOnly, "Error")
                    Me.dgv_formaPago.Rows.RemoveAt(2)
                    Me.calcular_monto_formapago()
                End If
            End If

        End If

    End Sub

    Private Sub dgv_formaPago_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_formaPago.CellContentClick

        If dgv_formaPago.CurrentRow.Cells(0).Value = "DÉBITO" Then
            Me.btn_agregarCUPON.Visible = True
            Me.btn_agregarCUPON.Enabled = True
        End If

        If dgv_formaPago.CurrentRow.Cells(0).Value = "CRÉDITO" Then
            Me.btn_agregarCUPON.Visible = True
            Me.btn_agregarCUPON.Enabled = True
        End If

        If dgv_formaPago.CurrentRow.Cells(0).Value = "EFECTIVO" Then
            Me.btn_agregarCUPON.Visible = False
            Me.btn_agregarCUPON.Enabled = False
        End If

        Me.txt_montoFORMAPAGO.Text = Me.dgv_formaPago.CurrentRow.Cells(2).Value
        Me.txt_montoFORMAPAGO.Enabled = True
        Me.cmb_formaPago.SelectedValue = Me.dgv_formaPago.CurrentRow.Cells(4).Value
        Me.cmb_formaPago.Enabled = False
        Me.btn_agregarFORMAPAGO.Enabled = False
        Me.btn_eliminarFORMAPAGO.Enabled = True
        Me.btn_aceptar.Enabled = True
        Me.btn_aceptar.Visible = True

    End Sub

    Private Function obtener_subtotal()
        subtotal = 0
        Dim c As Integer
        For c = 0 To dgv_detalle.Rows.Count - 1
            Dim cantidad As Integer = Me.dgv_detalle.Rows(c).Cells(3).Value
            Dim precio As Integer = Me.dgv_detalle.Rows(c).Cells(2).Value
            subtotal = Me.subtotal + (cantidad * precio)
        Next
        Return subtotal
    End Function

    Private Sub btn_eliminarFORMAPAGO_Click(sender As Object, e As EventArgs) Handles btn_eliminarFORMAPAGO.Click

        If Me.dgv_formaPago.Rows.Count = 0 Then
            Me.limpiar_camposFORMAPAGO()
            Me.txt_totalVENTA.Text = obtener_subtotal()
            Me.btn_guardarVENTA.Enabled = False
        End If

        If Me.dgv_formaPago.Rows.Count > 0 Then
            Me.dgv_formaPago.Rows.Remove(Me.dgv_formaPago.CurrentRow)
            Me.limpiar_camposFORMAPAGO()
            'Me.calcular_total_venta()
        End If

        If Me.dgv_formaPago.Rows.Count = 0 Then
            Me.btn_guardarVENTA.Enabled = False
            Me.btn_agregarCUPON.Visible = False
            Me.btn_guardarVENTA.Enabled = False
        End If

        Me.btn_agregarFORMAPAGO.Enabled = True
        Me.btn_eliminarFORMAPAGO.Enabled = False
        Me.cmb_formaPago.Enabled = True
        Me.cmb_formaPago.SelectedIndex = -1
        Me.btn_aceptar.Enabled = False
        Me.btn_aceptar.Visible = False
        Me.calcular_monto_formapago()
        Me.calcular_total_con_dto_formapago()
        Me.txt_montoFORMAPAGO.Enabled = True

    End Sub


    Private Sub btn_guardarVENTA_Click(sender As Object, e As EventArgs) Handles btn_guardarVENTA.Click
        SoporteBD.iniciar_conexion_con_transaccion()

        'INSERTAR VENTA
        Dim tabla_venta As New DataTable
        Dim sql_insertar_venta As String = ""
        sql_insertar_venta &= "INSERT INTO ventas(id_venta,fecha_venta,hora_venta,id_usuario,numero_documento_cliente,tipo_documento_cliente) VALUES("
        sql_insertar_venta &= txt_idVENTA.Text
        sql_insertar_venta &= ", '" & txt_fecha.Text & "'"
        sql_insertar_venta &= ", '" & txt_hora.Text & "'"
        sql_insertar_venta &= ", '" & Usuario.username & "'"

        If txt_nroDocCLIENTE.Text = "" Then
            sql_insertar_venta &= ", NULL"
        Else
            sql_insertar_venta &= ", '" & txt_nroDocCLIENTE.Text & "'"
        End If

        If cmb_tipoDocCLIENTE.SelectedIndex = -1 Then
            sql_insertar_venta &= ", NULL)"
        Else
            sql_insertar_venta &= ", '" & cmb_tipoDocCLIENTE.SelectedValue & "')"
        End If

        SoporteBD.escribirBD_transaccion(sql_insertar_venta)

        'INSERTAR DETALLE DE VENTA
        Dim tabla_detalle As New DataTable
        Dim sql_insertar_detalle As String = ""
        For c = 0 To Me.dgv_detalle.Rows.Count - 1
            sql_insertar_detalle &= " INSERT INTO detalle_ventas(id_venta,id_producto,cantidad,precio_unitario) VALUES (" & txt_idVENTA.Text
            sql_insertar_detalle &= "," & Me.dgv_detalle.Rows(c).Cells("col_id_producto").Value
            sql_insertar_detalle &= "," & Me.dgv_detalle.Rows(c).Cells("col_cantidad").Value
            sql_insertar_detalle &= "," & Me.dgv_detalle.Rows(c).Cells("col_precio").Value & ")"
            SoporteBD.escribirBD_transaccion(sql_insertar_detalle)
            sql_insertar_detalle = ""
        Next

        'INSERTAR FORMA DE PAGO
        Dim tabla_formapago As New DataTable
        Dim sql_insertar_formapago As String = ""
        For d = 0 To Me.dgv_formaPago.Rows.Count - 1
            'SI LA FORMA DE PAGO ES EN EFECTIVO QUE INSERTE NULL EN LOS VALORES DEL CUPON
            If dgv_formaPago.Rows(d).Cells("col_id_formapago").Value = 1 Then
                sql_insertar_formapago &= "INSERT INTO ventasXformas_pago(id_venta,id_forma_pago,monto_vxfp,id_cupon,id_banco,id_entidad_crediticia) VALUES ("
                sql_insertar_formapago &= txt_idVENTA.Text
                sql_insertar_formapago &= ", " & Me.dgv_formaPago.Rows(d).Cells("col_id_formapago").Value
                sql_insertar_formapago &= ", " & Me.dgv_formaPago.Rows(d).Cells("col_montoDTO").Value
                sql_insertar_formapago &= ", NULL"
                sql_insertar_formapago &= ", NULL"
                sql_insertar_formapago &= ", NULL)"
                SoporteBD.escribirBD_transaccion(sql_insertar_formapago)
                sql_insertar_formapago = ""
            Else
                sql_insertar_formapago &= "INSERT INTO ventasXformas_pago(id_venta,id_forma_pago,monto_vxfp,id_cupon,id_banco,id_entidad_crediticia) VALUES ("
                sql_insertar_formapago &= txt_idVENTA.Text
                sql_insertar_formapago &= ", " & Me.dgv_formaPago.Rows(d).Cells("col_id_formapago").Value
                sql_insertar_formapago &= ", " & Me.dgv_formaPago.Rows(d).Cells("col_montoDTO").Value
                sql_insertar_formapago &= ", " & Cupon.id_cupon
                sql_insertar_formapago &= ", " & Cupon.id_banco
                sql_insertar_formapago &= ", " & Cupon.id_entidad_crediticia & ")"
                SoporteBD.escribirBD_transaccion(sql_insertar_formapago)
                sql_insertar_formapago = ""
            End If

        Next

        MessageBox.Show("Venta registrada.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        SoporteBD.cerrar_conexion_con_transaccion()
        estado_actual_transaccion = estado_transaccion._sin_iniciar
        Me.deshabilitar_formapago()
        Me.deshabilitar_cliente()
        Me.deshabilitar_detalle_venta()
        Me.btn_guardarVENTA.Enabled = False
    End Sub

    Private Sub deshabilitar_cliente()
        Me.cmb_tipoDocCLIENTE.Enabled = False
        Me.txt_nroDocCLIENTE.Enabled = False
        Me.btn_buscarCLIENTE.Enabled = False
    End Sub

    Private Sub deshabilitar_detalle_venta()
        Me.cmb_producto.Enabled = False
        Me.txt_cantidad.Enabled = False
        Me.dgv_detalle.Enabled = False
    End Sub

    Private Sub txt_dtoVENTA_TextChanged(sender As Object, e As EventArgs) Handles txt_dtoVENTA.TextChanged
        Dim total_con_descuento As Double = 0
        Dim descuento_compra As Double
        If Me.txt_dtoVENTA.Text = "" Then
            'Me.calcular_total_venta()
            Me.txt_totalVENTA.Text = Me.txt_subtotalVENTA.Text
        Else
            total = Convert.ToDouble(Me.txt_totalVENTA.Text)
            descuento_compra = Convert.ToDouble(Me.txt_dtoVENTA.Text)
            total_con_descuento = Math.Round(total_con_descuento + (total * (1 - (descuento_compra / 100))))
            Me.txt_totalVENTA.Text = total_con_descuento
            Me.txt_montoFORMAPAGO.Text = total_con_descuento
            total = total_con_descuento
        End If
    End Sub

    Private Sub calcular_total_con_dto_formapago()
        Dim c As Integer
        Dim precio_con_dto As Integer = 0
        For c = 0 To dgv_formaPago.Rows.Count - 1
            precio_con_dto = precio_con_dto + Math.Round(Convert.ToDouble(Me.dgv_formaPago.Rows(c).Cells("col_montoDTO").Value))
        Next
        Me.txt_totalVENTA.Text = precio_con_dto
    End Sub

    Private Sub txt_totalVENTA_TextChanged(sender As Object, e As EventArgs) Handles txt_totalVENTA.TextChanged
        If chk_descuento.Checked = False Then
            Me.txt_montoFORMAPAGO.Text = Convert.ToDouble(Me.txt_totalVENTA.Text)
        Else
            If dgv_formaPago.Rows.Count = 0 Then
                Me.txt_totalVENTA.Text = total_con_descuento_sinfp
            End If
        End If

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Me.cmb_formaPago.Enabled = True
        Me.dgv_formaPago.Enabled = True
        Me.btn_aceptar.Visible = False
        Me.btn_eliminarFORMAPAGO.Enabled = False
        If dgv_formaPago.Rows.Count = 3 Then
            If Math.Round(Convert.ToDouble(Me.txt_montoFORMAPAGO.Text)) = 0 Then
                Me.btn_agregarFORMAPAGO.Enabled = False
            End If
        Else
            Me.btn_agregarFORMAPAGO.Enabled = True
        End If
        Me.calcular_monto_formapago()
        Me.calcular_total_con_dto_formapago()
        Me.btn_aceptar.Visible = False
        Me.btn_agregarCUPON.Visible = False
        If Math.Round(Convert.ToDouble(Me.txt_montoFORMAPAGO.Text)) = 0 Then
            Me.txt_montoFORMAPAGO.Enabled = False
        Else
            Me.txt_montoFORMAPAGO.Enabled = True
        End If

    End Sub

    Private Sub chk_descuento_CheckedChanged(sender As Object, e As EventArgs) Handles chk_descuento.CheckedChanged
        If chk_descuento.Checked = True Then
            If MsgBox("¿El descuento aplicado es correcto?", MsgBoxStyle.OkCancel, "Consulta") = MsgBoxResult.Ok Then
                total_con_descuento_sinfp = Math.Round(Convert.ToDouble(Me.txt_totalVENTA.Text))
                Me.habilitar_camposPAGO()
                Me.txt_dtoVENTA.Enabled = False
                Me.chk_descuento.Enabled = False
            Else
                Me.chk_descuento.Checked = False
            End If
        Else
            Me.txt_dtoVENTA.Enabled = True
            Me.deshabilitar_formapago()
            Me.chk_descuento.Checked = False
        End If
    End Sub

    Private Sub txt_montoFORMAPAGO_TextChanged(sender As Object, e As EventArgs) Handles txt_montoFORMAPAGO.TextChanged

        If txt_montoFORMAPAGO.Text = "" Then
            Return
        End If

        If Me.dgv_formaPago.Rows.Count > 0 Then
            If Convert.ToDouble(txt_montoFORMAPAGO.Text) = 0 Then
                Me.txt_montoFORMAPAGO.Enabled = False
                Me.btn_agregarFORMAPAGO.Enabled = False
            Else
                If chk_descuento.Checked = True Then
                    Me.txt_montoFORMAPAGO.Enabled = True
                End If
            End If
        End If
        

    End Sub

End Class