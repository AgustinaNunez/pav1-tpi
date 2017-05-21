Imports System.ComponentModel
Imports System.Data.OleDb
Public Class FormVentas
    Dim hay_articulos_cargados As Boolean = False
    Dim subtotal As Double = 0
    Dim total As Double = 0

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
        Me.habilitar_camposVENTA()
        Me.limpiar_camposVENTA()
        Me.limpiar_camposCLIENTE()
        Me.limpiar_camposDETALLE()
        Me.limpiar_camposFORMAPAGO()
        Me.txt_nroDocCLIENTE.Focus()
        Me.txt_idVENTA.Text = Me.GENERARCODIGO()
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
        'Me.cmb_tipoDocCLIENTE.SelectedIndex = -1
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
            If validar_camposARTICULO() Then
                Me.dgv_detalle.Rows.Add(Me.cmb_producto.SelectedValue, Me.cmb_producto.SelectedText, Me.txt_cantidad.Text, Me.txt_precio.Text)
                Dim cantidad As Integer = Convert.ToInt32(Me.txt_cantidad.Text)
                Dim precio As Integer = Convert.ToDouble(Me.txt_precio.Text)
                subtotal = Me.subtotal + (cantidad * precio)
                Me.txt_subtotalVENTA.Text = Me.subtotal
                Me.txt_totalVENTA.Text = Me.subtotal

                Me.limpiar_camposDETALLE()
            End If
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

    Private Function articulo_ya_cargado()
        Dim c As Integer
        For c = 0 To Me.dgv_detalle.Rows.Count - 1
            If Me.dgv_detalle.Rows(c).Cells(0).Value = Me.cmb_producto.SelectedValue Then
                If MessageBox.Show("El artículo " & Articulo.nombre & " ya ha sido agregado a la venta." & vbCrLf & "¿Desea modificar ese ítem de la venta?",
                                "CLOTTA _ Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                    Me.txt_cantidad.Text = Me.dgv_detalle.Rows(c).Cells(2).Value
                    Me.btn_modificarARTICULO.Enabled = True
                    Me.txt_cantidad.Focus()
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
            frmClientes.Visible = True
            'Me.txt_nombreCLIENTE.Text = Cliente.apellido & ", " & Cliente.nombre
            Return
        End If

        Dim sql As String = ""
        sql &= "SELECT * FROM clientes c JOIN tipo_documento td ON c.tipo_documento = td.id_tipo_documento "
        sql &= " WHERE td.nombre_tipo_documento = '" & Me.cmb_tipoDocCLIENTE.Text & "'"
        sql &= " AND c.numero_documento = " & Me.txt_nroDocCLIENTE.Text
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
        End If
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
        frmCupon.Visible = True
    End Sub

    ''' <summary>
    '''             ESTO HAY QUE CAMBIAR PORQUE ESTO SERIA SI ES ABM Y ES TRANSACCION
    ''' </summary>
    Private Sub btn_modificarARTICULO_Click(sender As Object, e As EventArgs) Handles btn_modificarARTICULO.Click
        Dim sql As String = ""
        sql &= "UPDATE detalle_ventas SET"
        sql &= " precio_unitario = " & Me.txt_precio.Text
        sql &= ", cantidad = " & Me.txt_cantidad.Text
        sql &= " WHERE id_venta = " & Me.txt_idVENTA.Text
        sql &= " AND id_producto = " & Me.cmb_producto.SelectedValue

        SoporteBD.escribirBD_simple(sql)
        cargar_DETALLE()
        Me.btn_modificarARTICULO.Enabled = False
        Me.btn_eliminarDETALLE.Enabled = False
        'Me.deshabilitar_camposDETALLE()
    End Sub

    ''' <summary>
    '''             ESTO HAY QUE CAMBIAR PORQUE ESTO SERIA SI ES ABM Y ES TRANSACCION
    ''' </summary>
    Private Sub cargar_DETALLE()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT dv.id_producto, p.descripcion, dv.cantidad, dv.precio_unitario FROM detalle_ventas dv"
        sql &= " JOIN productos p ON dv.id_producto = p.id_producto"
        tabla = SoporteBD.leerBD_simple(sql)

        Dim c As Integer
        Me.dgv_detalle.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_detalle.Rows.Add()
            Me.dgv_detalle.Rows(c).Cells(0).Value = tabla.Rows(c)("id_producto")
            Me.dgv_detalle.Rows(c).Cells(1).Value = tabla.Rows(c)("descripcion")
            Me.dgv_detalle.Rows(c).Cells(2).Value = tabla.Rows(c)("cantidad")
            Me.dgv_detalle.Rows(c).Cells(3).Value = tabla.Rows(c)("precio_unitario")
        Next
    End Sub

    Private Sub cmb_producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_producto.SelectedIndexChanged

    End Sub

    Private Sub dgv_detalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_detalle.CellContentClick

    End Sub
End Class