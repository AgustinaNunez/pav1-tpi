Public Class FormReporteVentas
    Private Sub FormReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SoporteGUI.cargar_combo(cmb_buscar_usuario, SoporteBD.leerBD_simple("SELECT * FROM usuarios ORDER BY nombre"), "id_usuario", "id_usuario")
        Me.cargar_ventas()
    End Sub

    Private Sub cargar_ventas()
        Dim sql As String = ""
        sql &= " SELECT ventas.id_venta, convert(char(10), ventas.fecha_venta,103) as fecha_venta, ventas.id_usuario, usuarios.id_usuario AS Expr1, ventas.total"
        sql &= " From    ventas INNER JOIN "
        sql &= "   usuarios ON ventas.id_usuario = usuarios.id_usuario"
        Me.cargar_grilla(sql)
    End Sub

    Private Sub limpiar_campos()
        Me.cmb_buscar_usuario.SelectedIndex = -1

    End Sub

    Private Sub cargar_grilla(ByRef sql As String)
        t_ventaBindingSource.DataSource = SoporteBD.leerBD_simple(sql)
        Me.ReportViewer1.RefreshReport()
    End Sub



    Private Sub buscador_general()
        If cmb_buscar_usuario.SelectedIndex = 0 Then

            Me.cargar_ventas()

        Else
            Dim sql As String = ""
            sql &= " SELECT ventas.id_venta, convert(char(10), ventas.fecha_venta,103) as fecha_venta, ventas.id_usuario, usuarios.id_usuario AS Expr1, ventas.total"
            sql &= " From      ventas INNER JOIN "
            sql &= "  usuarios ON ventas.id_usuario = usuarios.id_usuario"
            sql &= " WHERE id_usuario = " & Me.cmb_buscar_usuario.SelectedValue

            Me.cargar_grilla(sql)
        End If


    End Sub

    Private Sub cmb_buscar_usuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_buscar_usuario.SelectedIndexChanged
        Me.buscador_general()
    End Sub
End Class