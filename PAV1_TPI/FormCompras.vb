Imports System.ComponentModel

Public Class FormCompras

    'VARIABLES QUE YA CONOCEMOS
    Dim conexion As New Data.OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand

    'NUEVAS VARIABLES QUE SE AGREGAN PARA LAS TRANSACCIONES
    Dim configuracion_conexion As tipo_conexion = tipo_conexion.simple
    Dim control_transaccion As resultado_transaccion = resultado_transaccion._ok
    Dim transaccion As OleDb.OleDbTransaction

    'ENUMERACION DE TIPOS DE CONEXION
    Enum tipo_conexion
        simple
        transaccion
    End Enum

    'ENUMERACION DE RESULTADOS DE TRANSACCIONES
    Enum resultado_transaccion
        _ok
        _error
    End Enum

    'ENUMERAODR DE RESPUESTAS DE VALIDACION
    Enum respuesta_validacion
        _ok
        _error
    End Enum

    'LOADER DE COMPRAS
    Private Sub form_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Soporte.cargar_combo(cmb_producto, Soporte.leerBD("SELECT * FROM productos"), "id_producto", "descripcion")
        'txt_fecha.Text = Date.Today
        'txt_hora.Text = TimeOfDay
    End Sub

    'SUBRUTINA PARA CONECTAR MEDIANTE UNA TRANSACCION A LA BD
    Public Sub conectar()
        If conexion.State.ToString <> "Open" Then
            conexion.ConnectionString = Soporte.cadena_conexion_agus
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            If configuracion_conexion = tipo_conexion.transaccion Then
                Me.transaccion = Me.conexion.BeginTransaction()
                Me.cmd.Transaction = Me.transaccion
                Me.control_transaccion = resultado_transaccion._ok
            End If
        End If
    End Sub

    'SUBRUTINA PARA DESCONECTAR LA BD MEDIANTE TRANSACCION
    Private Sub desconectar()
        If configuracion_conexion = tipo_conexion.simple Then
            Me.conexion.Close()
        End If

    End Sub

    'SUBRUTINA INICIADORA DE TRANSACCIONES
    Private Sub iniciar_conexion_con_transaccion()
        Me.control_transaccion = resultado_transaccion._ok
        Me.configuracion_conexion = tipo_conexion.transaccion
    End Sub

    'SUBRUTINA PARA CERRAR TRANSACCIONES
    Private Sub cerrar_conexion_con_transaccion()
        If Me.configuracion_conexion = tipo_conexion.transaccion Then
            If Me.control_transaccion = resultado_transaccion._ok Then
                Me.transaccion.Commit()
            Else
                Me.transaccion.Rollback()
            End If
            Me.configuracion_conexion = tipo_conexion.simple
            Me.desconectar()
        End If

    End Sub


    'FUNCION QUE DEVUELVE UNA TABLA USANDO TRANSACCIONES
    Private Function consulta_transaccion_bd(ByVal sql As String)
        Dim tabla As New DataTable
        cmd.CommandText = sql
        Me.conectar()
        Try
            tabla.Load(cmd.ExecuteReader())
        Catch ex As Exception
            Me.control_transaccion = resultado_transaccion._error
            MessageBox.Show("Error SQL: " + ex.Message + Chr(13) + " en la consulta " + Chr(13) + sql)
        End Try
        Me.desconectar()
        Return tabla
    End Function



    'SUBRUTINA QUE GRABA,BORRA O MODIFICA MEDIANTE TRANSACCIONES
    Private Sub ejecutar_transaccion_bd(ByVal sql As String)
        Me.conectar()
        Me.cmd.CommandText = sql
        Try
            Me.cmd.ExecuteNonQuery()
        Catch ex As Exception
            Me.control_transaccion = resultado_transaccion._error
            MessageBox.Show("Error SQL: " + ex.Message + Chr(13) + " en la consulta " + Chr(13) + sql)
        End Try
        Me.desconectar()
    End Sub



    'BOTON AGREGAR
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Me.grid_compras.Rows.Add(cmb_producto.Text, Me.txt_cantidad.Text, Me.txt_precio.Text, cmb_producto.SelectedValue)
        Dim total As Double = 0
        For c = 0 To Me.grid_compras.Rows.Count - 1
            total = total + Convert.ToDouble(Me.grid_compras.Rows(c).Cells("col_cantidad").Value * Convert.ToDouble(Me.grid_compras.Rows(c).Cells("col_precio").Value))
        Next
        Me.txt_monto.Text = total
        Me.txt_hora.Text = TimeOfDay
    End Sub



    'BOTON NUEVO
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Me.txt_cantidad.Text = ""
        Me.txt_fecha.Text = Today
        Me.txt_hora.Text = TimeOfDay
        Me.txt_id_compra.Text = ""
        Me.txt_monto.Text = "0,00"
        Me.txt_precio.Text = ""
        Me.cmb_producto.Text = ""

        Me.txt_cantidad.Enabled = True
        'Me.txt_fecha.Enabled = True
        Me.txt_id_compra.Enabled = True
        Me.txt_monto.Enabled = False
        Me.txt_precio.Enabled = True
        Me.txt_hora.Enabled = False
        Me.cmb_producto.Enabled = True
        Me.grid_compras.Enabled = True
        Me.btn_guardar.Enabled = True
        Me.btn_agregar.Enabled = True

        Me.txt_id_compra.Focus()
    End Sub


    'BOTON GRABAR
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If validar_campos() = respuesta_validacion._ok Then
            If validar_compra() = respuesta_validacion._ok Then
                Me.iniciar_conexion_con_transaccion()

                Dim sql_insertar_compra As String = ""

                sql_insertar_compra &= "INSERT INTO compras(id_compra,fecha_compra,hora_compra,monto) VALUES(" & txt_id_compra.Text
                sql_insertar_compra &= ", '" & txt_fecha.Text & "'"
                sql_insertar_compra &= ", '" & txt_hora.Text & "'"
                sql_insertar_compra &= "," & txt_monto.Text & ")"

                Me.ejecutar_transaccion_bd(sql_insertar_compra)

                Dim sql_insertar_detalle As String = ""
                Dim tabla As New DataTable
                Dim sql As String = ""

                For c = 0 To Me.grid_compras.Rows.Count - 1
                    sql_insertar_detalle &= " INSERT INTO detalles_compras(id_compra,id_producto,cantidad,precio_unitario) VALUES (" & txt_id_compra.Text
                    sql_insertar_detalle &= "," & Me.grid_compras.Rows(c).Cells("col_id_producto").Value
                    sql_insertar_detalle &= "," & Me.grid_compras.Rows(c).Cells("col_cantidad").Value
                    sql_insertar_detalle &= "," & Me.grid_compras.Rows(c).Cells("col_precio").Value & ")"
                    Me.ejecutar_transaccion_bd(sql_insertar_detalle)
                Next

                sql &= "SELECT * FROM detalles_compras WHERE id_compra = " & Me.txt_id_compra.Text
                tabla = Soporte.leerBD(sql)
                If tabla.Rows.Count >= 1 Then
                    MsgBox("Datos almacenados", MsgBoxStyle.OkOnly, "Carga Correcta")
                End If

                Me.cerrar_conexion_con_transaccion()

                Me.txt_cantidad.Enabled = False
                Me.txt_fecha.Enabled = False
                Me.txt_hora.Enabled = False
                Me.txt_id_compra.Enabled = False
                Me.txt_precio.Enabled = False
                Me.txt_monto.Enabled = False
                Me.btn_guardar.Enabled = False
                Me.cmb_producto.Enabled = False
                Me.grid_compras.Enabled = False
                Me.btn_agregar.Enabled = False
            End If
        End If
    End Sub


    'VALIDAR CAMPOS
    Public Function validar_campos()
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

        tabla = Soporte.leerBD(sql)

        If tabla.Rows.Count = 1 Then
            MsgBox("El numero de compra ya existe, ingrese otro", MsgBoxStyle.OkOnly, "Error")
            Return respuesta_validacion._error
        End If

        Return respuesta_validacion._ok
    End Function

    Private Sub FormCompras_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("¿Está seguro que desea salir?", "Gestión de Compras", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class