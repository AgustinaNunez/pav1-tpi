Public Class EstadisticaUsuario
    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub cargar_grafico()

        If cmb_temporadas.SelectedIndex = -1 Then
            If cmb_año.SelectedIndex = -1 Then
                Return
            End If
        End If

        If cmb_año.SelectedIndex = -1 Then
            If cmb_temporadas.SelectedIndex = -1 Then
                Return
            End If
        End If


        Dim sql As String = ""

        If cmb_año.SelectedIndex = -1 Then
            Return
        Else
            If cmb_temporadas.Text = "Otoño-Invierno" Then
                sql &= " SELECT u.id_usuario, count(*) as 'valor'"
                sql &= " FROM ventas v "
                sql &= " JOIN usuarios u on v.id_usuario = u.id_usuario"
                sql &= " WHERE v.fecha_venta BETWEEN '" & Me.cmb_año.Text & "-03-21' AND '" & Me.cmb_año.Text & "-09-21'"
                sql &= " GROUP BY u.id_usuario "
                sql &= " ORDER BY valor"

                usuariosBindingSource.DataSource = SoporteBD.leerBD_simple(sql)

                Me.ReportViewer1.RefreshReport()

            End If

            If cmb_temporadas.Text = "Primavera-Verano" Then
                sql &= " SELECT u.id_usuario, count(*) as 'valor'"
                sql &= " FROM ventas v "
                sql &= " JOIN usuarios u on v.id_usuario = u.id_usuario"
                sql &= " WHERE v.fecha_venta BETWEEN '" & Me.cmb_año.Text & "-09-21' AND '" & Convert.ToInt32(Me.cmb_año.Text) + 1 & "-03-21'"
                sql &= " GROUP BY u.id_usuario "
                sql &= " ORDER BY valor"

                usuariosBindingSource.DataSource = SoporteBD.leerBD_simple(sql)

                Me.ReportViewer1.RefreshReport()
            End If
        End If


    End Sub

    Private Sub cmb_temporadas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_temporadas.SelectedIndexChanged
        cargar_grafico()
    End Sub

    Private Sub cmb_año_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_año.SelectedIndexChanged
        cargar_grafico()
    End Sub
End Class