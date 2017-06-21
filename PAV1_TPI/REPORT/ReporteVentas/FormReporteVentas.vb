Public Class FormReporteVentas

    Dim mes_seleccionado As Integer = 0

    Private Sub FormReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoporteGUI.cargar_combo(cmb_buscar_usuario, SoporteBD.leerBD_simple("SELECT * FROM usuarios ORDER BY nombre"), "id_usuario", "id_usuario")
    End Sub

    Private Sub cargar_grilla(ByRef sql As String)
        t_ventaBindingSource.DataSource = SoporteBD.leerBD_simple(sql)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub buscador_general()
        If cmb_buscar_usuario.SelectedIndex = -1 Then
            If cmb_año.SelectedIndex = -1 Then
                If cmb_mes.SelectedIndex = -1 Then
                    Return
                End If
            End If
            Return
        End If



        If cmb_buscar_usuario.Text = "(Seleccionar valor)" Then
            If cmb_año.SelectedIndex = -1 Then
                If cmb_mes.SelectedIndex = -1 Then
                    Dim sql As String = ""
                    sql &= " SELECT v.id_venta, convert(char(10), v.fecha_venta,103) as fecha_venta, v.id_usuario, u.nombre, u.apellido, v.total"
                    sql &= " FROM ventas v "
                    sql &= " JOIN usuarios u ON v.id_usuario = u.id_usuario "
                    Me.cargar_grilla(sql)
                Else
                    Dim sql As String = ""
                    sql &= " SELECT v.id_venta, convert(char(10), v.fecha_venta,103) as fecha_venta, v.id_usuario, u.nombre, u.apellido, v.total"
                    sql &= " FROM ventas v "
                    sql &= " JOIN usuarios u ON v.id_usuario = u.id_usuario "
                    sql &= " WHERE MONTH(v.fecha_venta) = " & mes_seleccionado
                    Me.cargar_grilla(sql)
                End If
            Else
                Dim sql As String = ""
                sql &= " SELECT v.id_venta, convert(char(10), v.fecha_venta,103) as fecha_venta, v.id_usuario, u.nombre, u.apellido, v.total"
                sql &= " FROM ventas v "
                sql &= " JOIN usuarios u ON v.id_usuario = u.id_usuario "
                sql &= " WHERE YEAR(v.fecha_venta) = " & Me.cmb_año.Text
                sql &= " AND MONTH(v.fecha_venta) = " & mes_seleccionado
                Me.cargar_grilla(sql)
            End If
        Else
            If cmb_año.SelectedIndex = -1 Then
                If cmb_mes.SelectedIndex = -1 Then
                    Dim sql As String = ""
                    sql &= " SELECT v.id_venta, convert(char(10), v.fecha_venta,103) as fecha_venta, v.id_usuario, u.nombre, u.apellido, v.total"
                    sql &= " FROM ventas v "
                    sql &= " JOIN usuarios u ON v.id_usuario = u.id_usuario "
                    sql &= " WHERE u.id_usuario = '" & Me.cmb_buscar_usuario.Text & "'"
                    Me.cargar_grilla(sql)
                End If
            Else
                Dim sql As String = ""
                sql &= " SELECT v.id_venta, convert(char(10), v.fecha_venta,103) as fecha_venta, v.id_usuario, u.nombre, u.apellido, v.total"
                sql &= " FROM ventas v "
                sql &= " JOIN usuarios u ON v.id_usuario = u.id_usuario "
                sql &= " WHERE u.id_usuario = '" & Me.cmb_buscar_usuario.Text & "'"
                sql &= " AND YEAR(v.fecha_venta) = " & Me.cmb_año.Text
                sql &= " AND MONTH(v.fecha_venta) = " & mes_seleccionado
                Me.cargar_grilla(sql)
            End If
        End If


    End Sub


    Private Sub cmb_mes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_mes.SelectedIndexChanged
        If cmb_mes.Text = "Enero" Then
            mes_seleccionado = 1
        End If

        If cmb_mes.Text = "Febrero" Then
            mes_seleccionado = 2
        End If

        If cmb_mes.Text = "Marzo" Then
            mes_seleccionado = 3
        End If

        If cmb_mes.Text = "Abril" Then
            mes_seleccionado = 4
        End If

        If cmb_mes.Text = "Mayo" Then
            mes_seleccionado = 5
        End If

        If cmb_mes.Text = "Junio" Then
            mes_seleccionado = 6
        End If

        If cmb_mes.Text = "Julio" Then
            mes_seleccionado = 7
        End If

        If cmb_mes.Text = "Agosto" Then
            mes_seleccionado = 8
        End If

        If cmb_mes.Text = "Septiembre" Then
            mes_seleccionado = 9
        End If

        If cmb_mes.Text = "Octubre" Then
            mes_seleccionado = 10
        End If

        If cmb_mes.Text = "Noviembre" Then
            mes_seleccionado = 11
        End If

        If cmb_mes.Text = "Diciembre" Then
            mes_seleccionado = 12
        End If
        buscador_general()
    End Sub

    Private Sub cmb_año_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_año.SelectedIndexChanged
        buscador_general()
    End Sub

    Private Sub cmb_buscar_usuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_buscar_usuario.SelectedIndexChanged
        buscador_general()
    End Sub
End Class