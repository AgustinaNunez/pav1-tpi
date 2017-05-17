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


    'LOADER DE COMPRAS
    Private Sub form_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Soporte.cargar_combo(cmb_producto, Soporte.leerBD("SELECT * FROM productos"), "id_producto", "descripcion")
        txt_fecha.Text = Date.Today
        txt_hora.Text = TimeOfDay
    End Sub



    'SUBRUTINA PARA CONECTAR MEDIANTE UNA TRANSACCION A LA BD
    Public Sub conectar()
        If Me.conexion.ConnectionString <> "Open" Then
            conexion.ConnectionString = Soporte.cadena_conexion_juan
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            If configuracion_conexion = tipo_conexion.transaccion Then
                Me.transaccion = Me.conexion.BeginTransaction
                Me.cmd.Transaction = Me.transaccion
                Me.control_transaccion = resultado_transaccion._ok
            End If
        End If
    End Sub



    'SUBRUTINA PARA DESCONECTAR LA BD MEDIANTE TRANSACCION
    Private Sub desconectar()
        Me.conexion.Close()
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
        End If
        Me.configuracion_conexion = tipo_conexion.simple
        Me.desconectar()
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
        Me.grid_compras.Rows.Add(cmb_producto.SelectedValue, Me.txt_cantidad.Text, Me.txt_precio.Text)
        Dim total As Double = 0
        For c = 0 To Me.grid_compras.Rows.Count - 1
            total = total + Convert.ToDouble(Me.grid_compras.Rows(c).Cells("col_cantidad").Value * Convert.ToDouble(Me.grid_compras.Rows(c).Cells("col_precio").Value))
        Next
        Me.txt_monto.Text = total
    End Sub



    'BOTON GRABAR
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        Me.iniciar_conexion_con_transaccion()

        Dim insertar_factura As String = ""
        Dim c As Integer
        Dim total As Double

        For c = 0 To Me.grid_compras.Rows.Count - 1
            total = total + Convert.ToDouble(Me.grid_compras.Rows(c).Cells("col_cantidad").Value * Convert.ToDouble(Me.grid_compras.Rows(c).Cells("col_precio").Value))

        Next

        Dim sql_insertar_compra As String = ""

        sql_insertar_compra &= "INSERT INTO compras(id_compra,fecha_compra,hora_compra,monto) VALUES(" & txt_id_compra.Text
        sql_insertar_compra &= ", '" & txt_fecha.Text & "'"
        sql_insertar_compra &= ", '" & txt_hora.Text & "'"
        sql_insertar_compra &= "," & total & ")"

        Me.ejecutar_transaccion_bd(sql_insertar_compra)

        Dim sql_insertar_detalle As String = ""

        For c = 0 To Me.grid_compras.Rows.Count - 1
            sql_insertar_detalle &= "INSERT INTO detalles_compras(id_compra,id_producto,cantidad,precio_unitario) VALUES (" & txt_id_compra.Text
            sql_insertar_detalle &= "," & Me.grid_compras.Rows(c).Cells("col_producto").Value
            sql_insertar_detalle &= "," & Me.grid_compras.Rows(c).Cells("col_cantidad").Value
            sql_insertar_detalle &= "," & Me.grid_compras.Rows(c).Cells("col_precio").Value & ")"
            Me.ejecutar_transaccion_bd(sql_insertar_detalle)
        Next

        Me.cerrar_conexion_con_transaccion()

        MsgBox("Datos almacenados", MsgBoxStyle.OkOnly, "Carga Correcta")

    End Sub



    'BOTON SALIR
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

End Class