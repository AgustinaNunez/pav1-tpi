Public Class FormCupones_Buscar

    Private Sub FormParaBuscarCupones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SoporteGUI.cargar_combo(Me.cmb_bancoBUSCAR, SoporteBD.leerBD_simple("SELECT * FROM bancos"), "id_banco", "nombre")
        SoporteGUI.cargar_combo(Me.cmb_tarjetaBUSCAR, SoporteBD.leerBD_simple("SELECT * FROM entidades_crediticias"), "id_entidad_crediticia", "nombre")
        Me.limpiar_campos()
    End Sub
    Private Sub cargar_grilla_cupon()
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql &= "SELECT b.nombre as 'Bnombre', vxfp.id_cupon, c.numero_autorizacion_online, ec.nombre as 'ECnombre', c.precio, vxfp.id_banco,vxfp.id_cupon, c.numero_lote "
        sql &= "FROM ventasXformas_pago vxfp "
        sql &= "JOIN bancos b ON b.id_banco = vxfp.id_banco "
        sql &= "JOIN entidades_crediticias ec ON ec.id_entidad_crediticia = vxfp.id_entidad_crediticia "
        sql &= "JOIN cupon c ON c.id_cupon = vxfp.id_cupon "
        sql &= "WHERE vxfp.id_entidad_crediticia  <> 0 AND vxfp.id_banco <> 0"

        tabla = SoporteBD.leerBD_simple(sql)

        Dim c As Integer
        Me.grid1.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1
            Me.grid1.Rows.Add()
            Me.grid1.Rows(c).Cells(0).Value = tabla.Rows(c)("numero_lote")
            Me.grid1.Rows(c).Cells(1).Value = tabla.Rows(c)("numero_autorizacion_online")
            Me.grid1.Rows(c).Cells(2).Value = tabla.Rows(c)("ECnombre")
            Me.grid1.Rows(c).Cells(3).Value = tabla.Rows(c)("Bnombre")
            Me.grid1.Rows(c).Cells(4).Value = tabla.Rows(c)("precio")
            Me.grid1.Rows(c).Cells(5).Value = tabla.Rows(c)("id_banco")
            Me.grid1.Rows(c).Cells(6).Value = tabla.Rows(c)("id_cupon")
        Next
    End Sub

    Private Sub limpiar_campos()
        cmb_tarjetaBUSCAR.Text = "(Seleccionar tarjeta)"
        cmb_bancoBUSCAR.Text = "(Seleccionar banco)"
    End Sub

    Private Sub buscar(ByVal sql As String)
        Dim tabla As New DataTable
        tabla = SoporteBD.leerBD_simple(sql)

        Dim c As Integer
        Me.grid1.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1
            Me.grid1.Rows.Add()
            Me.grid1.Rows(c).Cells(0).Value = tabla.Rows(c)("numero_lote")
            Me.grid1.Rows(c).Cells(1).Value = tabla.Rows(c)("numero_autorizacion_online")
            Me.grid1.Rows(c).Cells(2).Value = tabla.Rows(c)("ECnombre")
            Me.grid1.Rows(c).Cells(3).Value = tabla.Rows(c)("Bnombre")
            Me.grid1.Rows(c).Cells(4).Value = tabla.Rows(c)("precio")
            Me.grid1.Rows(c).Cells(5).Value = tabla.Rows(c)("id_banco")
            Me.grid1.Rows(c).Cells(6).Value = tabla.Rows(c)("id_cupon")
        Next
    End Sub

    Private Sub cmb_bancoBUSCAR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_bancoBUSCAR.SelectedIndexChanged
        busqueda_general()
    End Sub

    Private Sub cmb_tarjetaBUSCAR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tarjetaBUSCAR.SelectedIndexChanged
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
                buscar &= "SELECT b.nombre as 'Bnombre', vxfp.id_cupon, c.numero_autorizacion_online, ec.nombre as 'ECnombre', c.precio, vxfp.id_banco,vxfp.id_cupon, c.numero_lote "
                buscar &= "FROM ventasXformas_pago vxfp "
                buscar &= "JOIN bancos b ON b.id_banco = vxfp.id_banco "
                buscar &= "JOIN entidades_crediticias ec ON ec.id_entidad_crediticia = vxfp.id_entidad_crediticia "
                buscar &= "JOIN cupon c ON c.id_cupon = vxfp.id_cupon"
                buscar &= " WHERE vxfp.id_entidad_crediticia = " & Me.cmb_tarjetaBUSCAR.SelectedValue
                Me.buscar(buscar)
            End If
        Else

            If cmb_tarjetaBUSCAR.SelectedIndex = 0 Then
                buscar &= "SELECT b.nombre as 'Bnombre', vxfp.id_cupon, c.numero_autorizacion_online, ec.nombre as 'ECnombre', c.precio, vxfp.id_banco,vxfp.id_cupon, c.numero_lote "
                buscar &= "FROM ventasXformas_pago vxfp "
                buscar &= "JOIN bancos b ON b.id_banco = vxfp.id_banco "
                buscar &= "JOIN entidades_crediticias ec ON ec.id_entidad_crediticia = vxfp.id_entidad_crediticia "
                buscar &= "JOIN cupon c ON c.id_cupon = vxfp.id_cupon"
                buscar &= " WHERE vxfp.id_banco = " & Me.cmb_bancoBUSCAR.SelectedValue
                Me.buscar(buscar)
            Else
                buscar &= "SELECT b.nombre as 'Bnombre', vxfp.id_cupon, c.numero_autorizacion_online, ec.nombre as 'ECnombre', c.precio, vxfp.id_banco,vxfp.id_cupon, c.numero_lote "
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
End Class