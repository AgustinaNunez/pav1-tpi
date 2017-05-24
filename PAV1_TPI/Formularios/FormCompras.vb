Imports System.ComponentModel
Imports System.Data.OleDb

Public Class FormCompras
    'ENUMERADOR DE RESPUESTAS DE VALIDACION
    Enum respuesta_validacion
        _ok
        _error
    End Enum

    Enum estado_transaccion
        _iniciada
        _sin_iniciar
    End Enum
    Private estado_actual_transaccion As estado_transaccion = estado_transaccion._sin_iniciar

    'LOADER DE COMPRAS
    Private Sub form_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoporteGUI.cargar_combo(cmb_fabrica, SoporteBD.leerBD_simple("SELECT * FROM fabricas"), "id_fabrica", "nombre")
        Me.limpiar_campos_detalle()
        txt_id_compra.Text = Format(SoporteBD.autogenerar_codigo("AUTOGENERARCODIGO_compras"), "000")
        'txt_fecha.Text = Date.Today
        'txt_hora.Text = TimeOfDay
    End Sub

    'BOTON NUEVO
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        If estado_actual_transaccion = estado_transaccion._iniciada Then
            If MessageBox.Show("¿Está seguro que desea cancelar la transacción actual?", "Gestión de Compras", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.Cancel Then
                Return
            End If
        End If
        estado_actual_transaccion = estado_transaccion._iniciada
        Me.limpiar_campos_compra()
        Me.habilitar_campos()

        Me.txt_id_compra.Text = SoporteBD.autogenerar_codigo("AUTOGENERARCODIGO_compras")

        Me.btn_guardar.Enabled = True
        Me.btn_agregar.Enabled = True
        Me.txt_precio.Focus()
    End Sub

    'BOTON AGREGAR
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If validar_campos_detalle() Then
            'PRIMERO VERIFICA SI LAS FILAS DE LA TABLA SON NULAS
            If Me.dgv_compras.Rows.Count = 0 Then
                Me.dgv_compras.Rows.Add(cmb_producto.Text, Me.txt_cantidad.Text, Me.txt_precio.Text, cmb_producto.SelectedValue)
                Dim total As Double = 0
                total = total + Convert.ToDouble(Me.dgv_compras.Rows(0).Cells("col_cantidad").Value * Convert.ToDouble(Me.dgv_compras.Rows(0).Cells("col_precio").Value))
                Me.txt_monto.Text = total
            Else
                If existe_en_grid() = True Then
                    Me.dgv_compras.Rows.Add(cmb_producto.Text, Me.txt_cantidad.Text, Me.txt_precio.Text, cmb_producto.SelectedValue)
                    Dim total As Double = 0
                    For c = 0 To Me.dgv_compras.Rows.Count - 1
                        total = total + Convert.ToDouble(Me.dgv_compras.Rows(c).Cells("col_cantidad").Value * Convert.ToDouble(Me.dgv_compras.Rows(c).Cells("col_precio").Value))
                    Next
                    Me.txt_monto.Text = total
                End If
            End If
            'Me.limpiar_campos_detalle()
        End If
    End Sub

    Private Function validar_campos_detalle()
        Dim mensaje As String = "Faltan campos requeridos para agregar un nuevo artículo:"
        Dim flag As Boolean = True
        If Me.cmb_producto.SelectedIndex = -1 Then
            flag = False
            mensaje &= vbCrLf & "- producto"
        End If
        If Me.txt_cantidad.Text = "" Then
            flag = False
            mensaje &= vbCrLf & "- cantidad"
        End If
        If Me.txt_precio.Text = "" Then
            flag = False
            mensaje &= vbCrLf & "- precio unitario del producto comprado"
        End If
        If flag = False Then
            MessageBox.Show(mensaje, "Gestión de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return flag
    End Function

    'BOTON ELIMINAR
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If Me.dgv_compras.Rows.Count > 0 Then
            Me.dgv_compras.Rows.Remove(Me.dgv_compras.CurrentRow)
        End If
    End Sub

    'FUNCION QUE DEVUELVE TRUE SI EXISTE UN ELEMENTO SELECCIONADO EN LA GRILLA
    Private Function existe_en_grid()
        Dim valor As Boolean = True
        For a = 0 To Me.dgv_compras.Rows.Count - 1
            If Me.cmb_producto.SelectedValue = Me.dgv_compras.Rows(a).Cells("col_id_producto").Value Then
                MsgBox("El producto '" & cmb_producto.Text & "' ya fue cargado, seleccione otro", MsgBoxStyle.OkOnly, "Error")
                valor = False
            End If
        Next
        Return valor
    End Function

    'BOTON GRABAR
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If validar_campos() = respuesta_validacion._ok Then
            If validar_compra() = respuesta_validacion._ok Then
                SoporteBD.iniciar_conexion_con_transaccion()

                Dim sql_insertar_compra As String = ""
                sql_insertar_compra &= "INSERT INTO compras(id_compra,fecha_compra,hora_compra,monto) VALUES(" & txt_id_compra.Text
                sql_insertar_compra &= ", '" & txt_fecha.Text & "'"
                sql_insertar_compra &= ", '" & txt_hora.Text & "'"
                sql_insertar_compra &= "," & txt_monto.Text & ")"
                SoporteBD.escribirBD_transaccion(sql_insertar_compra)

                Dim sql_insertar_detalle As String = ""
                Dim tabla As New DataTable
                Dim sql As String = ""

                For c = 0 To Me.dgv_compras.Rows.Count - 1
                    sql_insertar_detalle &= " INSERT INTO detalles_compras(id_compra,id_producto,cantidad,precio_unitario) VALUES (" & txt_id_compra.Text
                    sql_insertar_detalle &= "," & Me.dgv_compras.Rows(c).Cells("col_id_producto").Value
                    sql_insertar_detalle &= "," & Me.dgv_compras.Rows(c).Cells("col_cantidad").Value
                    sql_insertar_detalle &= "," & Me.dgv_compras.Rows(c).Cells("col_precio").Value & ")"
                    SoporteBD.escribirBD_transaccion(sql_insertar_detalle)
                    sql_insertar_detalle = ""
                Next

                MessageBox.Show("Datos almacenados.", "Gestión de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SoporteBD.cerrar_conexion_con_transaccion()
                Me.deshabilitar_campos()
            End If
        End If
    End Sub

    'DESHABILITAR CAMPOS
    Private Sub deshabilitar_campos()
        Me.txt_cantidad.Enabled = False
        Me.txt_fecha.Enabled = False
        Me.txt_hora.Enabled = False
        Me.txt_id_compra.Enabled = False
        Me.txt_precio.Enabled = False
        Me.txt_monto.Enabled = False
        Me.btn_guardar.Enabled = False
        Me.cmb_producto.Enabled = False
        Me.dgv_compras.Enabled = False
        Me.btn_agregar.Enabled = False
        Me.btn_eliminar.Enabled = False
        Me.cmb_fabrica.Enabled = False
    End Sub

    'HABILITAR CAMPOS
    Private Sub habilitar_campos()
        Me.txt_cantidad.Enabled = True
        'Me.txt_id_compra.Enabled = True
        'Me.txt_monto.Enabled = False
        Me.txt_precio.Enabled = True
        Me.cmb_producto.Enabled = True
        Me.dgv_compras.Enabled = True
        Me.btn_eliminar.Enabled = True
        Me.cmb_fabrica.Enabled = True
    End Sub

    'LIMPIAR EL CONTENIDO DE LOS CAMPOS DE LA COMPRA
    Private Sub limpiar_campos_compra()
        Me.txt_cantidad.Text = ""
        Me.txt_fecha.Text = Today
        Me.txt_hora.Text = TimeOfDay
        Me.txt_monto.Text = "0,00"
        Me.txt_precio.Text = ""
        Me.cmb_producto.Text = ""
        Me.dgv_compras.Rows.Clear()

    End Sub

    'LIMPIAR EL CONTENIDO DE LOS CAMPOS DE LOS PRODUCTOS A CARGAR DE LA COMPRA
    Private Sub limpiar_campos_detalle()
        Me.txt_cantidad.Text = ""
        Me.cmb_producto.SelectedIndex = -1
        Me.cmb_fabrica.SelectedIndex = -1
        Me.txt_precio.Text = ""
    End Sub

    'VALIDAR CAMPOS
    Private Function validar_campos()
        If txt_cantidad.Text = "" Or txt_fecha.Text = "" Or txt_precio.Text = "" Or cmb_producto.SelectedValue = 0 Then
            MsgBox("Alguno de los campos no fue completado", MsgBoxStyle.OkOnly, "Error")
            Return respuesta_validacion._error
        End If
        Return respuesta_validacion._ok
    End Function

    'VALIDAR COMPRA
    Public Function validar_compra()
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql &= "SELECT * FROM compras WHERE id_compra = " & Me.txt_id_compra.Text
        tabla = SoporteBD.leerBD_simple(sql)

        If tabla.Rows.Count = 1 Then
            MsgBox("El numero de compra ya existe, ingrese otro", MsgBoxStyle.OkOnly, "Error")
            Return respuesta_validacion._error
        End If
        Return respuesta_validacion._ok
    End Function

    'CIERRE FORMULARIO
    Private Sub FormCompras_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("¿Está seguro que desea salir?", "Gestión de Compras", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub


    'GENERADOR DE CODIGOS AUTOMATICOS ASCENDENTES
    'Private Function GENERARCODIGO() As Integer

    '    Dim RG As New OleDbCommand
    '    Dim conexion As New Data.OleDb.OleDbConnection
    '    Dim cmd As New Data.OleDb.OleDbCommand

    '    conexion.ConnectionString = SoporteBD.cadena_conexion_agus

    '    conexion.Open()
    '    cmd.Connection = conexion
    '    RG = New OleDbCommand("AUTOGENERARCODIGO_compras", conexion)
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


    'ABRIR PRODUCTOS Y ACTUALIZAR EL COMBO DE PRODUCTOS CUANDO SE GUARDA
    Private Sub btn_nuevo_producto_Click(sender As Object, e As EventArgs) Handles btn_nuevo_producto.Click
        'Dim frmProductos = New FormProductos
        'frmProductos.Visible = True
        Using form As New FormProductos
            If form.ShowDialog() = DialogResult.OK Then
                SoporteGUI.cargar_combo(cmb_producto, SoporteBD.leerBD_simple("SELECT * FROM productos"), "id_producto", "descripcion")
            End If
        End Using

    End Sub

    Private Sub cmb_fabrica_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_fabrica.SelectionChangeCommitted
        SoporteGUI.cargar_combo(cmb_producto, SoporteBD.leerBD_simple("SELECT * FROM productos WHERE id_fabrica = " & Me.cmb_fabrica.SelectedValue), "id_producto", "descripcion")
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
