Public Class FormReporteVentas
    Private Sub FormReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SoporteGUI.cargar_combo(cmb_buscar_usuario, SoporteBD.leerBD_simple("SELECT * FROM usuarios ORDER BY nombre"), "id_usuario", "id_usuario")
    End Sub

    Private Sub cargar_grilla(ByRef sql As String)
        t_ventaBindingSource.DataSource = SoporteBD.leerBD_simple(sql)
        Me.ReportViewer1.RefreshReport()
    End Sub



    Private Sub buscador_general()
        If cmb_buscar_usuario.SelectedIndex = -1 Then
            Return
        Else
            Dim sql As String = ""
            sql &= " SELECT v.id_venta, convert(char(10), v.fecha_venta,103) as fecha_venta, v.id_usuario, u.nombre, u.apellido, v.total"
            sql &= " FROM ventas v "
            sql &= " JOIN usuarios u ON v.id_usuario = u.id_usuario "
            sql &= " WHERE u.id_usuario = '" & Me.cmb_buscar_usuario.Text & "'"

            Me.cargar_grilla(sql)
        End If


    End Sub

    Private Sub cmb_buscar_usuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_buscar_usuario.SelectedIndexChanged
        Me.buscador_general()
    End Sub


End Class