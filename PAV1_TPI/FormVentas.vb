Imports System.ComponentModel
Imports System.Data.OleDb
Public Class FormVentas
    Dim hay_articulos_cargados As Boolean = False
    Dim subtotal As Double = 0
    Dim total As Double = 0
    Dim flag As Boolean = False


    Enum estado_transaccion
        _iniciada
        _sin_iniciar
    End Enum
    Private estado_actual_transaccion As estado_transaccion = estado_transaccion._sin_iniciar

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoporteGUI.cargar_combo(cmb_tipoDocCLIENTE, SoporteBD.leerBD_simple("SELECT * FROM tipo_documento"), "id_tipo_documento", "nombre_tipo_documento")
        SoporteGUI.cargar_combo(cmb_producto, SoporteBD.leerBD_simple("SELECT * FROM productos"), "id_producto", "descripcion")
        SoporteGUI.cargar_combo(cmb_formaPago, SoporteBD.leerBD_simple("SELECT * FROM formas_pago"), "id_forma_pago", "nombre")
        Me.txt_usuarioLogueado.Text = Usuario.apellido & ", " & Usuario.nombre
        Me.limpiar_camposVENTA()
        Me.limpiar_camposCLIENTE()
        Me.limpiar_camposDETALLE()
        Me.limpiar_camposFORMAPAGO()
        Me.txt_idVENTA.Text = Format(GENERARCODIGO, "000000")
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
        Me.txt_idVENTA.Text = Me.GENERARCODIGO()
        Me.dgv_detalle.Rows.Clear()
        Me.dgv_formaPago.Rows.Clear()
        Me.deshabilitar_formapago()
        Me.btn_guardarVENTA.Enabled = False

    End Sub

    Private Sub deshabilitar_formapago()
        Me.btn_agregarFORMAPAGO.Enabled = False
        Me.btn_eliminarFORMAPAGO.Enabled = False
        Me.btn_modificarFORMAPAGO.Enabled = False
        Me.cmb_formaPago.Enabled = False
        Me.txt_montoFORMAPAGO.Enabled = False
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
        Me.txt_subtotalVENTA.Text = "0,00"
        Me.txt_dtoVENTA.Text = "0,00"
        Me.txt_totalVENTA.Text = "0,00"
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
            Me.habilitar_camposPAGO()
        End If
        If validar_camposARTICULO() Then
            Dim cantidad As Integer = Convert.ToInt32(Me.txt_cantidad.Text)
            Dim precio As Integer = Convert.ToDouble(Me.txt_precio.Text)
            Me.dgv_detalle.Rows.Add(Me.cmb_producto.SelectedValue, Me.cmb_producto.Text, Me.txt_cantidad.Text, Me.txt_precio.Text, cantidad * precio)
            Me.calcular_subtotal()
            Me.habilitar_camposPAGO()
            Me.limpiar_camposDETALLE()
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
                If MessageBox.Show("La forma de pago con " & cmb_formaPago.Text & " ya ha sido agregada." & vbCrLf & "¿Desea modificar ese ítem de la venta?",
                                "CLOTTA _ Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                    Me.txt_montoFORMAPAGO.Text = Me.dgv_formaPago.Rows(c).Cells(2).Value
                    Me.btn_agregarCUPON.Enabled = False
                    Me.cmb_formaPago.Enabled = False
                    Me.btn_eliminarFORMAPAGO.Enabled = False
                    Me.btn_modificarFORMAPAGO.Enabled = True
                Else

                End If
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
    Private Function GENERARCODIGO() As Integer

        Dim RG As New OleDbCommand
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand

        conexion.ConnectionString = SoporteBD.cadena_conexion_juan

        conexion.Open()
        cmd.Connection = conexion
        RG = New OleDbCommand("AUTOGENERARCODIGO_ventas", conexion)
        Dim PARAM As New OleDbParameter("@CODIGO", SqlDbType.Int)
        PARAM.Direction = ParameterDirection.Output
        With RG
            .CommandType = CommandType.StoredProcedure
            .Parameters.Add(PARAM)
            .ExecuteNonQuery()
            conexion.Close()
            Return .Parameters("@CODIGO").Value
        End With

    End Function

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
        Dim frmCupon As New FormCupones
        frmCupon.ShowDialog()
        Me.btn_guardarVENTA.Enabled = True

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
        Me.txt_montoFORMAPAGO.Text = Me.subtotal
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


    Private Sub btn_agregarFORMAPAGO_Click(sender As Object, e As EventArgs) Handles btn_agregarFORMAPAGO.Click

        If validar_camposFORMAPAGO() = True Then
            Dim tabla As New DataTable
            Dim sql As String = ""
            sql &= "SELECT porcentaje FROM formas_pago WHERE id_forma_pago = " & Me.cmb_formaPago.SelectedValue
            tabla = SoporteBD.leerBD_simple(sql)
            Dim porcentaje As Double = tabla.Rows(0)("porcentaje")
            Dim monto_sin_descuento As Double = Convert.ToDouble(Me.txt_montoFORMAPAGO.Text)
            Dim subtotal As Double = Me.txt_subtotalVENTA.Text

            If cmb_formaPago.SelectedValue <> 3 Then
                Me.dgv_formaPago.Rows.Add(Me.cmb_formaPago.Text, porcentaje, monto_sin_descuento, (1 - porcentaje) * monto_sin_descuento, Me.cmb_formaPago.SelectedValue)
                'Me.calcular_subtotal()
                'Me.txt_montoFORMAPAGO.Text = subtotal - monto_sin_descuento
            Else
                Me.dgv_formaPago.Rows.Add(Me.cmb_formaPago.Text, porcentaje, monto_sin_descuento, monto_sin_descuento, Me.cmb_formaPago.SelectedValue)
                'Me.calcular_subtotal()
                'Me.txt_montoFORMAPAGO.Text = subtotal - monto_sin_descuento
            End If

            'Me.btn_guardarVENTA.Enabled = True
            Me.txt_dtoVENTA.Enabled = True
            Me.btn_agregarCUPON.Visible = True
            Me.btn_agregarCUPON.Enabled = True
            Me.calcular_total_venta()

        End If

    End Sub

    Private Sub calcular_total_venta()

        Dim monto As Double
        Dim descuentos As Double
        Dim subbtotal As Double = Me.txt_subtotalVENTA.Text
        Dim c As Integer
        For c = 0 To dgv_formaPago.Rows.Count - 1
            monto = monto + Convert.ToInt32(dgv_formaPago.Rows(c).Cells("col_montoSINDTO").Value)
            descuentos = descuentos + (Convert.ToInt32(dgv_formaPago.Rows(c).Cells("col_montoSINDTO").Value) - Convert.ToInt32(dgv_formaPago.Rows(c).Cells("col_montoDTO").Value))
        Next

        Me.txt_montoFORMAPAGO.Text = subtotal - monto
        Me.txt_totalVENTA.Text = subtotal - descuentos
    End Sub


    Private Sub dgv_formaPago_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_formaPago.CellContentClick

        Me.txt_montoFORMAPAGO.Text = Me.dgv_formaPago.CurrentRow.Cells(2).Value
        Me.cmb_formaPago.SelectedValue = Me.dgv_formaPago.CurrentRow.Cells(4).Value
        Me.btn_agregarCUPON.Enabled = False
        Me.btn_agregarFORMAPAGO.Enabled = False
        Me.btn_eliminarFORMAPAGO.Enabled = True
        Me.btn_modificarFORMAPAGO.Enabled = True
        Me.cmb_formaPago.Enabled = False


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
            Me.calcular_total_venta()
        End If

        If Me.dgv_formaPago.Rows.Count = 0 Then
            Me.btn_guardarVENTA.Enabled = False
            Me.btn_agregarCUPON.Visible = False
            Me.btn_guardarVENTA.Enabled = False
        End If

        Me.btn_agregarFORMAPAGO.Enabled = True
        Me.btn_eliminarFORMAPAGO.Enabled = False
        Me.btn_modificarFORMAPAGO.Enabled = False
        Me.cmb_formaPago.Enabled = True
        Me.cmb_formaPago.SelectedIndex = -1

    End Sub

    Private Sub btn_modificarFORMAPAGO_Click(sender As Object, e As EventArgs) Handles btn_modificarFORMAPAGO.Click

        Me.dgv_formaPago.CurrentRow.Cells(2).Value = Me.txt_montoFORMAPAGO.Text

        Me.calcular_total_venta()

        Me.btn_modificarFORMAPAGO.Enabled = False
        Me.btn_eliminarFORMAPAGO.Enabled = False
        Me.btn_agregarFORMAPAGO.Enabled = True
        Me.cmb_formaPago.Enabled = True

    End Sub

    Private Sub btn_guardarVENTA_Click(sender As Object, e As EventArgs) Handles btn_guardarVENTA.Click

        SoporteBD.iniciar_conexion_con_transaccion()

        'INSERTAR VENTA
        Dim sql_insertar_venta As String = ""
        sql_insertar_venta &= "INSERT INTO ventas(id_venta,fecha_venta,hora_venta,id_usuario,numero_documento_cliente,tipo_documento_cliente) VALUES("
        sql_insertar_venta &= txt_idVENTA.Text
        sql_insertar_venta &= ", '" & txt_fecha.Text & "'"
        sql_insertar_venta &= ", '" & txt_hora.Text & "'"
        sql_insertar_venta &= ", '" & Usuario.username & "'"

        If txt_nroDocCLIENTE.Text = "" Then
            sql_insertar_venta &= ", ''"
        Else
            sql_insertar_venta &= ", '" & txt_nroDocCLIENTE.Text & "'"
        End If

        If cmb_tipoDocCLIENTE.SelectedValue = -1 Then
            sql_insertar_venta &= ",'')"
        Else
            sql_insertar_venta &= ", '" & cmb_tipoDocCLIENTE.SelectedValue & "')"
        End If

        SoporteBD.escribirBD_transaccion(sql_insertar_venta)



        'INSERTAR DETALLE DE VENTA
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
        Dim sql_insertar_formapago As String = ""
        For d = 0 To Me.dgv_formaPago.Rows.Count - 1
            sql_insertar_formapago &= "INSERT INTO ventasXformas_pago(id_venta,id_forma_pago,monto_vxfp,id_cupon,id_banco,id_entidad_crediticia) VALUES ("
            sql_insertar_formapago &= txt_idVENTA.Text
            sql_insertar_formapago &= ", " & Me.dgv_formaPago.Rows(d).Cells("col_id_formapago").Value
            sql_insertar_formapago &= ", " & Me.dgv_formaPago.Rows(d).Cells("col_montoDTO").Value
            sql_insertar_formapago &= ", " & Cupon.id_cupon
            sql_insertar_formapago &= ", " & Cupon.id_banco
            sql_insertar_formapago &= ", " & Cupon.id_entidad_crediticia & ")"
            SoporteBD.escribirBD_transaccion(sql_insertar_formapago)
            sql_insertar_formapago = ""
        Next

        MessageBox.Show("Datos almacenados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        SoporteBD.cerrar_conexion_con_transaccion()

    End Sub
End Class