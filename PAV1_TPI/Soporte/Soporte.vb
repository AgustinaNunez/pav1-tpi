﻿Imports System.Data.OleDb
Public Class Soporte
    'Shared cadena_conexion_agus As String = "Provider=SQLNCLI11;Data Source=AGUSTINA-PC;Integrated Security=SSPI;Initial Catalog=DB_CLOTTA"
    Public Shared cadena_conexion_juan As String = "Provider=SQLNCLI11;Data Source=(localdb)\Servidor;Integrated Security=SSPI;Initial Catalog=BD_CLOTTA"
    'Shared cadena_conexion_gio As String = ""
    'Shared cadena_conexion_brian As String = ""

    Public Shared Function consultarBD(ByVal sql As String)
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = cadena_conexion_juan
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()
        Return tabla
    End Function

    Public Shared Sub actualizarBD(ByVal sql As String)
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = cadena_conexion_juan
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Shared Sub cargar_combo(ByRef combo As ComboBox, tabla As DataTable, pk As String, ByVal descriptor As String)
        combo.DataSource = tabla
        combo.DisplayMember = descriptor
        combo.ValueMember = pk
    End Sub



   

End Class