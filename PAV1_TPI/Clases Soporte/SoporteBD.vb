Imports System.Data.OleDb
Public Class SoporteBD

    Public Shared cadena_conexion_juan As String = "Provider=SQLNCLI11;Data Source=(localdb)\Servidor;Integrated Security=SSPI;Initial Catalog=BD_CLOTTA"
    'Public Shared cadena_conexion_agus As String = "Provider=SQLNCLI11;Data Source=AGUSTINA-PC;Integrated Security=SSPI;Initial Catalog=BD_CLOTTA"
    'Public Shared cadena_conexion_georgi As String = "Provider=SQLNCLI10;Data Source=(local)\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=BD_CLOTTA"
    'Public Shared cadena_conexion_brian As String = "Provider=SQLNCLI11;Data Source=(local)\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=BD_CLOTTA"
    Public Shared cadena_conexion As String = cadena_conexion_juan

    'VARIABLES QUE YA CONOCEMOS
    Public Shared conexion As New Data.OleDb.OleDbConnection
    Public Shared cmd As New OleDb.OleDbCommand

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

    'NUEVAS VARIABLES QUE SE AGREGAN PARA LAS TRANSACCIONES
    Public Shared configuracion_conexion As tipo_conexion = tipo_conexion.simple
    Public Shared control_transaccion As resultado_transaccion = resultado_transaccion._ok
    Public Shared transaccion As OleDb.OleDbTransaction

    Public Shared Function leerBD_simple(ByVal sql As String)
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New DataTable
        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()
        Return tabla
    End Function

    Public Shared Sub escribirBD_simple(ByVal sql As String)
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Shared Function autogenerar_codigo(ByVal origen As String) As Integer
        Dim RG As New OleDbCommand
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        conexion.ConnectionString = SoporteBD.cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        RG = New OleDbCommand(origen, conexion)
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

    'SUBRUTINA PARA CONECTAR MEDIANTE UNA TRANSACCION A LA BD
    Public Shared Sub conectar()
        If conexion.State.ToString <> "Open" Then
            conexion.ConnectionString = SoporteBD.cadena_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            If configuracion_conexion = tipo_conexion.transaccion Then
                transaccion = conexion.BeginTransaction()
                cmd.Transaction = transaccion
                control_transaccion = resultado_transaccion._ok
            End If
        End If
    End Sub

    'SUBRUTINA PARA DESCONECTAR LA BD MEDIANTE TRANSACCION
    Public Shared Sub desconectar()
        If configuracion_conexion = tipo_conexion.simple Then
            conexion.Close()
        End If
    End Sub

    'SUBRUTINA INICIADORA DE TRANSACCIONES
    Public Shared Sub iniciar_conexion_con_transaccion()
        control_transaccion = resultado_transaccion._ok
        configuracion_conexion = tipo_conexion.transaccion
    End Sub

    'SUBRUTINA PARA CERRAR TRANSACCIONES
    Public Shared Sub cerrar_conexion_con_transaccion()
        If configuracion_conexion = tipo_conexion.transaccion Then
            If control_transaccion = resultado_transaccion._ok Then
                transaccion.Commit()
            Else
                transaccion.Rollback()
            End If
            configuracion_conexion = tipo_conexion.simple
            desconectar()
        End If
    End Sub

    'FUNCION QUE DEVUELVE UNA TABLA USANDO TRANSACCIONES
    Public Shared Function leerBD_transaccion(ByVal sql As String)
        Dim tabla As New DataTable
        cmd.CommandText = sql
        conectar()
        Try
            tabla.Load(cmd.ExecuteReader())
        Catch ex As Exception
            control_transaccion = resultado_transaccion._error
            MessageBox.Show("Error SQL: " + ex.Message + Chr(13) + " en la consulta " + Chr(13) + sql)
        End Try
        desconectar()
        Return tabla
    End Function

    'SUBRUTINA QUE GRABA,BORRA O MODIFICA MEDIANTE TRANSACCIONES
    Public Shared Sub escribirBD_transaccion(ByVal sql As String)
        conectar()
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            control_transaccion = resultado_transaccion._error
            MessageBox.Show("Error SQL: " + ex.Message + Chr(13) + " en la consulta " + Chr(13) + sql)
        End Try
        desconectar()
    End Sub


End Class
