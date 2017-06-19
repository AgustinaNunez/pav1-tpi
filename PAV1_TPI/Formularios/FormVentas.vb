Imports System.ComponentModel
Imports System.Data.OleDb
Public Class FormVentas
    Dim hay_articulos_cargados As Boolean = False
    Dim subtotal As Double = 0
    Dim total As Double = 0
    Dim flag As Boolean = False
    Dim valor_monto_inicial As Double
    Dim total_con_descuento_sinfp As Double = 0
    Private estado_actual_transaccion As estado_transaccion = estado_transaccion._sin_iniciar
    Dim flag_cupon_debito As Boolean = False
    Dim flag_cupon_credito As Boolean = False

    Enum estado_transaccion
        _iniciada
        _sin_iniciar
    End Enum

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoporteGUI.tipo_form_ACTUAL = SoporteGUI.tipo_form.transaccion
        SoporteGUI.cargar_combo(cmb_tipoDocCLIENTE, SoporteBD.leerBD_simple("SELECT * FROM tipo_documento"), "id_tipo_documento", "nombre_tipo_documento")
        SoporteGUI.cargar_combo(cmb_producto, SoporteBD.leerBD_simple("SELECT * FROM productos WHERE dado_de_baja = 0  AND stock > 0 ORDER BY descripcion"), "id_producto", "descripcion")
        Me.txt_usuarioLogueado.Text = Usuario.apellido & ", " & Usuario.nombre
        Me.limpiar_camposVENTA()
        Me.limpiar_camposCLIENTE()
        Me.limpiar_camposDETALLE()
        Me.txt_idVENTA.Text = Format(SoporteBD.autogenerar_codigo("AUTOGENERARCODIGO_ventas"), "000000")
        Venta.id_venta = Me.txt_idVENTA.Text
    End Sub

    Private Sub limpiar_camposDETALLE()
        Me.cmb_producto.SelectedIndex = -1
        Me.txt_precio.Text = "0,00"
        Me.txt_cantidad.Text = "1"
    End Sub


    Private Sub limpiar_camposVENTA()
        'Me.txt_fecha.Text = DateTime.Now.ToString("d-MM-yyyy")
        Me.txt_fecha.Text = DateTime.Now.ToString("yyyy-MM-d")
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
        'PAGO
        Me.btn_dtoVENTA.Enabled = True
        Me.txt_dtoVENTA.Enabled = True
    End Sub

    Private Sub btn_agregarDETALLE_Click(sender As Object, e As EventArgs) Handles btn_agregarDETALLE.Click
        If Me.hay_articulos_cargados = False Then
            Me.hay_articulos_cargados = True
        End If
        If validar_camposARTICULO() Then
            Dim cantidad As Integer = Convert.ToInt32(Me.txt_cantidad.Text)
            Dim stock_actual As Integer = Me.stock_disponible(Me.cmb_producto.SelectedValue)
            Dim stock_final As Integer = stock_actual - cantidad
            If stock_final < 0 Then
                MessageBox.Show("Stock insuficiente." & vbCrLf & "Cantidad disponible: " & stock_actual & ".", "Gestión de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.limpiar_camposDETALLE()
                Return
            End If
            Dim precio As Integer = Convert.ToDouble(Me.txt_precio.Text)
            Me.dgv_detalle.Rows.Add(Me.cmb_producto.SelectedValue, Me.cmb_producto.Text, Me.txt_cantidad.Text, Me.txt_precio.Text, cantidad * precio, Me.stock_final)
            Me.calcular_subtotal()
            Me.limpiar_camposDETALLE()
            Me.txt_dtoVENTA.Enabled = True
            Me.chk_descuento.Enabled = True
            Me.btn_cancelarVENTA.Enabled = True
        End If
    End Sub

    Private Function stock_disponible(ByRef id_producto As Integer)
        Dim stock As Integer = 0
        Dim sql As String = "SELECT stock FROM productos WHERE id_producto = " & id_producto
        Dim tabla As New DataTable
        tabla = SoporteBD.leerBD_simple(sql)
        If tabla.Rows.Count = 1 Then
            stock = tabla.Rows(0)("stock")
        End If
        Return stock
    End Function

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

    Private Function articulo_ya_cargado()
        Dim c As Integer
        For c = 0 To Me.dgv_detalle.Rows.Count - 1
            If Me.dgv_detalle.Rows(c).Cells(0).Value = Me.cmb_producto.SelectedValue Then
                If MessageBox.Show("El artículo " & Articulo.nombre & " ya ha sido agregado a la venta." & vbCrLf & "¿Desea modificar ese ítem de la venta?",
                                "CLOTTA _ Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                    Me.txt_cantidad.Text = Me.dgv_detalle.Rows(c).Cells(2).Value
                    Me.btn_aceptarDETALLE.Visible = True
                    Me.btn_aceptarDETALLE.Enabled = True
                    Me.txt_cantidad.Focus()
                    Me.btn_eliminarDETALLE.Visible = True
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
        If Me.cmb_tipoDocCLIENTE.SelectedIndex = -1 Then
            MessageBox.Show("Falta ingresar el tipo documento.", "Gestión de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim sql As String = ""
        sql &= "SELECT * FROM clientes c JOIN tipo_documento td ON c.tipo_documento = td.id_tipo_documento "
        sql &= " WHERE td.nombre_tipo_documento = '" & Me.cmb_tipoDocCLIENTE.Text & "'"
        sql &= " AND c.numero_documento = '" & Me.txt_nroDocCLIENTE.Text & "'"
        Dim tabla As New DataTable
        tabla = SoporteBD.leerBD_simple(sql)

        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No se encontró el cliente con " & Me.cmb_tipoDocCLIENTE.Text & " " & Me.txt_nroDocCLIENTE.Text & ".", "Gestión de Ventas",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txt_nroDocCLIENTE.Text = ""
            Me.txt_nroDocCLIENTE.Focus()
            Me.limpiar_camposCLIENTE()
            Return
        End If

        Me.txt_nombreCLIENTE.Text = tabla.Rows(0)("apellido_cliente") & ", " & tabla.Rows(0)("nombre_cliente")
    End Sub

    Private Sub btn_eliminarDETALLE_Click(sender As Object, e As EventArgs) Handles btn_eliminarDETALLE.Click
        If Me.dgv_detalle.Rows.Count > 0 Then
            Me.dgv_detalle.Rows.Remove(Me.dgv_detalle.CurrentRow)
            Me.calcular_subtotal()
        End If

        If Me.dgv_detalle.Rows.Count = 0 Then
            Me.txt_subtotalVENTA.Text = 0
            Me.txt_totalVENTA.Text = 0
            subtotal = 0
            Me.btn_cancelarVENTA.Enabled = True
        End If

        Me.btn_eliminarDETALLE.Visible = False
        Me.btn_aceptarDETALLE.Visible = False
        Me.btn_agregarDETALLE.Enabled = True
        Me.btn_eliminarDETALLE.Enabled = False
        Me.btn_aceptarDETALLE.Enabled = False
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

    Private Sub btn_modificarARTICULO_Click(sender As Object, e As EventArgs) Handles btn_aceptarDETALLE.Click
        Me.dgv_detalle.CurrentRow.Cells(2).Value = Me.txt_cantidad.Text
        Dim cantidad As Integer = Convert.ToInt32(Me.txt_cantidad.Text)
        Dim precio As Integer = Convert.ToDouble(Me.txt_precio.Text)
        Me.dgv_detalle.CurrentRow.Cells(4).Value = cantidad * precio
        Me.btn_aceptarDETALLE.Enabled = False
        Me.btn_eliminarDETALLE.Enabled = False
        Me.btn_agregarDETALLE.Enabled = True
        Me.cmb_producto.Enabled = True
        Me.btn_eliminarDETALLE.Visible = False
        Me.btn_aceptarDETALLE.Visible = False
        Me.calcular_subtotal()
        Me.limpiar_camposDETALLE()
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

        Me.btn_eliminarDETALLE.Visible = True
        Me.btn_aceptarDETALLE.Visible = True
        Me.btn_eliminarDETALLE.Enabled = True
        Me.btn_aceptarDETALLE.Enabled = True
        Me.btn_agregarDETALLE.Enabled = False
        Me.cmb_producto.Enabled = False
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
            total = total_con_descuento
            Venta.total = total
        End If
    End Sub

    Private Sub btn_nuevaVENTA_Click(sender As Object, e As EventArgs) Handles btn_nuevaVENTA.Click
        SoporteGUI.respuesta_ventana = DialogResult.No
        If estado_actual_transaccion = estado_transaccion._iniciada Then
            If MessageBox.Show("¿Está seguro que desea cancelar la venta actual?", "Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
                Return
            End If
        End If
        estado_actual_transaccion = estado_transaccion._iniciada
        Me.habilitar_camposVENTA()
        Me.limpiar_camposVENTA()
        Me.limpiar_camposCLIENTE()
        Me.limpiar_camposDETALLE()
        Me.txt_nroDocCLIENTE.Focus()
        Me.txt_idVENTA.Text = SoporteBD.autogenerar_codigo("AUTOGENERARCODIGO_ventas")
        Me.dgv_detalle.Rows.Clear()
        Me.btn_guardarVENTA.Enabled = False
        Venta.id_venta = Me.txt_idVENTA.Text
        Me.btn_eliminarDETALLE.Visible = False
        Me.btn_aceptarDETALLE.Visible = False
        Me.chk_descuento.Enabled = False
        Me.chk_descuento.Checked = False
        FormVentasFORMASPAGO.cadena = Nothing
    End Sub

    Private Sub btn_guardarVENTA_Click(sender As Object, e As EventArgs) Handles btn_guardarVENTA.Click
        If SoporteGUI.respuesta_ventana = DialogResult.OK Then
            SoporteBD.iniciar_conexion_con_transaccion()
            'INSERTAR VENTA
            Dim tabla_venta As New DataTable
            Dim sql_insertar_venta As String = ""
            sql_insertar_venta &= "INSERT INTO ventas(id_venta,fecha_venta,hora_venta,id_usuario,numero_documento_cliente,tipo_documento_cliente,total) VALUES("
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
                sql_insertar_venta &= ", NULL"
            Else
                sql_insertar_venta &= ", '" & cmb_tipoDocCLIENTE.SelectedValue & "'"
            End If

            sql_insertar_venta &= ", " & txt_totalVENTA.Text & ")"

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

            'ACTUALIZAR STOCK DE PRODUCTOS
            Dim tabla_productos As New DataTable
            Dim sql_actualizar_productos As String = ""
            For c = 0 To Me.dgv_detalle.Rows.Count - 1
                sql_actualizar_productos &= "UPDATE productos SET stock = stock - " & Convert.ToInt32(Me.dgv_detalle.Rows(c).Cells(2).Value)
                sql_actualizar_productos &= " WHERE id_producto = " & Me.dgv_detalle.Rows(c).Cells(0).Value
                SoporteBD.escribirBD_transaccion(sql_actualizar_productos)
                sql_actualizar_productos = ""
            Next

            'INSERTAR FORMAS DE PAGO + CUPONES
            SoporteBD.escribirBD_transaccion(FormVentasFORMASPAGO.cadena)
            FormVentasFORMASPAGO.cadena = Nothing

            MessageBox.Show("Venta registrada.", "Gestión de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)

            SoporteBD.cerrar_conexion_con_transaccion()
            estado_actual_transaccion = estado_transaccion._sin_iniciar
            Me.deshabilitar_cliente()
            Me.deshabilitar_detalle_venta()
            Me.btn_guardarVENTA.Enabled = False
            Me.btn_agregarDETALLE.Enabled = False
            Me.btn_cancelarVENTA.Enabled = False
            Me.limpiar_deshabilitar_todo()
        Else
            MessageBox.Show("No hay formas de pago almacenadas", "Gestión de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub limpiar_deshabilitar_todo()
        Me.cmb_tipoDocCLIENTE.SelectedIndex = -1
        Me.txt_nroDocCLIENTE.Text = ""
        Me.txt_nombreCLIENTE.Text = ""
        Me.txt_fecha.Text = ""
        Me.txt_hora.Text = ""
        Me.txt_subtotalVENTA.Text = "0"
        Me.txt_dtoVENTA.Text = "0"
        Me.txt_totalVENTA.Text = "0"
        Me.cmb_producto.SelectedIndex = -1
        Me.txt_precio.Text = "0,00"
        Me.txt_cantidad.Text = "1"
        Me.dgv_detalle.Rows.Clear()
        Me.deshabilitar_camposCLIENTE()
        Me.deshabilitar_camposDETALLE()
        Me.deshabilitar_cliente()
        Me.deshabilitar_detalle_venta()
    End Sub


    Private Sub btn_cancelarVENTA_Click_1(sender As Object, e As EventArgs) Handles btn_cancelarVENTA.Click
        If Me.transaccion_iniciada Then
            If MessageBox.Show("¿Está seguro que desea cancelar la venta actual?", "Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
                Return
            End If
        End If
        estado_actual_transaccion = estado_transaccion._sin_iniciar
        'Me.habilitar_camposVENTA()
        Me.limpiar_camposVENTA()
        Me.limpiar_camposCLIENTE()
        Me.limpiar_camposDETALLE()
        Me.deshabilitar_camposCLIENTE()
        Me.dgv_detalle.Rows.Clear()
        Me.deshabilitar_camposDETALLE()
        Me.btn_guardarVENTA.Enabled = False
        Me.btn_cancelarVENTA.Enabled = False
        Me.btn_eliminarDETALLE.Visible = False
        Me.btn_aceptarDETALLE.Visible = False
        Me.btn_formasPago.Enabled = False
        Me.chk_descuento.Enabled = False
        Me.chk_descuento.Checked = False
    End Sub

    Private Sub deshabilitar_camposCLIENTE()
        Me.cmb_tipoDocCLIENTE.Enabled = False
        Me.txt_nroDocCLIENTE.Enabled = False
        Me.btn_buscarCLIENTE.Enabled = False
    End Sub

    Private Sub deshabilitar_camposDETALLE()
        Me.cmb_producto.Enabled = False
        Me.txt_cantidad.Enabled = False
        Me.btn_agregarDETALLE.Enabled = False
        Me.btn_eliminarDETALLE.Enabled = False
        Me.btn_aceptarDETALLE.Enabled = False
        Me.dgv_detalle.Enabled = False
    End Sub

    Private Sub FormVentas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.transaccion_iniciada Then
            If MessageBox.Show("¿Está seguro desea cancelar la venta actual?", "Iniciar Sesión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Function transaccion_iniciada()
        Dim flag As Boolean = False
        If Me.dgv_detalle.Rows.Count > 0 Or Me.txt_nombreCLIENTE.Text <> "" Then
            flag = True
        End If
        Return flag
    End Function

    Private Sub txt_nombreCLIENTE_TextChanged(sender As Object, e As EventArgs) Handles txt_nombreCLIENTE.TextChanged
        If Me.txt_nombreCLIENTE.Text <> "" Then
            Me.btn_cancelarVENTA.Enabled = True
            Me.btn_borrarCLIENTE.Enabled = True
        Else
            Me.btn_borrarCLIENTE.Enabled = False
        End If
    End Sub

    Private Sub btn_borrarCLIENTE_Click(sender As Object, e As EventArgs) Handles btn_borrarCLIENTE.Click
        Me.limpiar_camposCLIENTE()
    End Sub

    Private Sub btn_formasPago_Click(sender As Object, e As EventArgs) Handles btn_formasPago.Click
        Venta.subtotal = Me.txt_totalVENTA.Text
        Dim frmFormaPago = New FormVentasFORMASPAGO
        frmFormaPago.ShowDialog()
        If SoporteGUI.respuesta_ventana = Windows.Forms.DialogResult.OK Then
            Me.btn_guardarVENTA.Enabled = True
            Me.btn_formasPago.Enabled = False
        End If
    End Sub

    Private Sub btn_guardarDESCUENTO_Click(sender As Object, e As EventArgs) Handles btn_dtoVENTA.Click
        If dgv_detalle.Rows.Count = 0 Then
            MessageBox.Show("No hay productos agregados", "Gestión de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("¿El descuento aplicado es correcto?", "Gestión de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                total_con_descuento_sinfp = Math.Round(Convert.ToDouble(Me.txt_totalVENTA.Text))
                Venta.total = total_con_descuento_sinfp
                Me.txt_dtoVENTA.Enabled = False
                Me.btn_dtoVENTA.Enabled = False
                Me.deshabilitar_camposDETALLE()
                Me.btn_formasPago.Enabled = True
            End If
        End If

    End Sub

End Class