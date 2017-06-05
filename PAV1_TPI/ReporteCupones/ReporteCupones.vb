Public Class ReporteCupones
    Private Sub ReporteCupones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla_cupon()
        SoporteGUI.cargar_combo(Me.cmb_bancoBUSCAR, SoporteBD.leerBD_simple("SELECT * FROM bancos"), "id_banco", "nombre")
        SoporteGUI.cargar_combo(Me.cmb_tarjetaBUSCAR, SoporteBD.leerBD_simple("SELECT * FROM entidades_crediticias"), "id_entidad_crediticia", "nombre")
    End Sub

    Private Sub cargar_grilla_cupon()
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql &= "SELECT b.nombre as 'nombre_banco', c.id_cupon, c.numero_autorizacion_online, ec.nombre as 'nombre_entidad', "
        sql &= "c.precio, vxfp.id_banco, vxfp.id_cupon, c.numero_lote, ec.id_entidad_crediticia "
        sql &= "FROM ventasXformas_pago vxfp "
        sql &= "JOIN bancos b ON b.id_banco = vxfp.id_banco "
        sql &= "JOIN entidades_crediticias ec ON ec.id_entidad_crediticia = vxfp.id_entidad_crediticia "
        sql &= "JOIN cupon c ON c.id_cupon = vxfp.id_cupon "
        'sql &= "WHERE vxfp.id_entidad_crediticia  <> 0 AND vxfp.id_banco <> 0"

        t_cuponBindingSource.DataSource = SoporteBD.leerBD_simple(sql)
        Me.ReportCupon.RefreshReport()
    End Sub

    Private Sub cmb_banco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_bancoBUSCAR.SelectedIndexChanged
        busqueda_general()
    End Sub

    Private Sub cmb_tarjeta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tarjetaBUSCAR.SelectedIndexChanged
        busqueda_general()
    End Sub

    Private Sub busqueda_general()

        Dim buscar As String = ""

        If cmb_bancoBUSCAR.SelectedIndex = 0 Then
            If cmb_tarjetaBUSCAR.SelectedIndex = -1 Then
                Return
            End If
        End If


        If cmb_bancoBUSCAR.SelectedIndex = 0 Then
            If cmb_tarjetaBUSCAR.SelectedIndex = 0 Then
                Me.cargar_grilla_cupon()
            Else
                buscar &= "SELECT b.nombre as 'nombre_banco', c.id_cupon, c.numero_autorizacion_online, ec.nombre as 'nombre_entidad', "
                buscar &= "c.precio, vxfp.id_banco, vxfp.id_cupon, c.numero_lote, ec.id_entidad_crediticia "
                buscar &= "FROM ventasXformas_pago vxfp "
                buscar &= "JOIN bancos b ON b.id_banco = vxfp.id_banco "
                buscar &= "JOIN entidades_crediticias ec ON ec.id_entidad_crediticia = vxfp.id_entidad_crediticia "
                buscar &= "JOIN cupon c ON c.id_cupon = vxfp.id_cupon"
                buscar &= " WHERE vxfp.id_entidad_crediticia = " & Me.cmb_tarjetaBUSCAR.SelectedValue
                Me.buscar(buscar)
            End If
        Else

            If cmb_tarjetaBUSCAR.SelectedIndex = 0 Then
                buscar &= "SELECT b.nombre as 'nombre_banco', c.id_cupon, c.numero_autorizacion_online, ec.nombre as 'nombre_entidad', "
                buscar &= "c.precio, vxfp.id_banco, vxfp.id_cupon, c.numero_lote, ec.id_entidad_crediticia "
                buscar &= "FROM ventasXformas_pago vxfp "
                buscar &= "JOIN bancos b ON b.id_banco = vxfp.id_banco "
                buscar &= "JOIN entidades_crediticias ec ON ec.id_entidad_crediticia = vxfp.id_entidad_crediticia "
                buscar &= "JOIN cupon c ON c.id_cupon = vxfp.id_cupon"
                buscar &= " WHERE vxfp.id_banco = " & Me.cmb_bancoBUSCAR.SelectedValue
                Me.buscar(buscar)
            Else
                buscar &= "SELECT b.nombre as 'nombre_banco', c.id_cupon, c.numero_autorizacion_online, ec.nombre as 'nombre_entidad', "
                buscar &= "c.precio, vxfp.id_banco, vxfp.id_cupon, c.numero_lote, ec.id_entidad_crediticia "
                buscar &= "FROM ventasXformas_pago vxfp "
                buscar &= "JOIN bancos b ON b.id_banco = vxfp.id_banco "
                buscar &= "JOIN entidades_crediticias ec ON ec.id_entidad_crediticia = vxfp.id_entidad_crediticia "
                buscar &= "JOIN cupon c ON c.id_cupon = vxfp.id_cupon"
                buscar &= " WHERE vxfp.id_entidad_crediticia = " & Me.cmb_tarjetaBUSCAR.SelectedValue
                buscar &= " AND vxfp.id_banco = " & Me.cmb_bancoBUSCAR.SelectedValue
                Me.buscar(buscar)
            End If

        End If
    End Sub

    Private Sub buscar(ByVal sql As String)
        t_cuponBindingSource.DataSource = SoporteBD.leerBD_simple(sql)
        Me.ReportCupon.RefreshReport()
    End Sub

End Class