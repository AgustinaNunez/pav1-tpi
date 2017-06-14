Public Class EstadisticaUsuario
    Private Sub EstadisticaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grafico()
    End Sub

    Private Sub cargar_grafico()
        Dim sql As String = ""

        If cmb_temporadas.Text = "Otoño-Invierno" Then
            sql &= " SELECT u.id_usuario, count(*) as 'valor'"
            sql &= " FROM ventas v "
            sql &= " JOIN usuarios u on v.id_usuario = u.id_usuario"
            sql &= " WHERE v.fecha_venta BETWEEN '21/3/" & Me.cmb_año.Text & "' AND '21/9/" & Me.cmb_año.Text & "'"
            sql &= " GROUP BY u.id_usuario "
            sql &= " ORDER BY valor"

            'binding source choto

            Me.ReportViewer1.RefreshReport()

        End If

        If cmb_temporadas.Text = "Primavera-Verano" Then
            sql &= " SELECT u.id_usuario, count(*) as 'valor'"
            sql &= " FROM ventas v "
            sql &= " JOIN usuarios u on v.id_usuario = u.id_usuario"
            sql &= " WHERE v.fecha_venta BETWEEN '21/9/" & Me.cmb_año.Text & "' AND '21/3/" & Me.cmb_año.Text & "'"
            sql &= " GROUP BY u.id_usuario "
            sql &= " ORDER BY valor"

            'binding source choto

            Me.ReportViewer1.RefreshReport()
        End If

    End Sub

    Private Sub cmb_temporadas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_temporadas.SelectedIndexChanged
        cargar_grafico()
    End Sub

    Private Sub cmb_año_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_año.SelectedIndexChanged
        cargar_grafico()
    End Sub
End Class