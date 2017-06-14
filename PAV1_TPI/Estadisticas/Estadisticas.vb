Public Class Estadisticas
    Private Sub Estadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.ReportViewer2.RefreshReport
    End Sub

    Private Function leer_tabla(sql As String)
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = SoporteBD.cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()

        Return tabla

    End Function

    Private Sub cargar_grafico_fabricas()
        Dim sql As String = ""
        sql &= " SELECT f.nombre, SUM(dv.cantidad*dv.precio_unitario ) as 'monto'"
        sql &= " FROM fabricas f JOIN productos p ON p.id_fabrica = f.id_fabrica "
        sql &= " JOIN detalle_ventas dv ON p.id_producto = dv.id_productos"
        sql &= " GROUP BY f.nombre"

        Me.t_fabricasBindingSource.DataSource = Me.leer_tabla(sql)
        Me.ReportViewer1.RefreshReport()

    End Sub


End Class