Public Class FormCupones_Buscar

    Private Sub FormParaBuscarCupones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla_cupon()
        SoporteGUI.cargar_combo(Me.cmb_bancoBUSCAR, SoporteBD.leerBD_simple("SELECT * FROM bancos"), "id_banco", "nombre")
        SoporteGUI.cargar_combo(Me.cmb_tarjetaBUSCAR, SoporteBD.leerBD_simple("SELECT * FROM entidades_crediticias"), "id_entidad_crediticia", "nombre")
        Me.limpiar_campos()
    End Sub
    Private Sub cargar_grilla_cupon()
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql &= "SELECT * FROM ventasXformas_pago vxfp "
        sql &= "JOIN bancos b ON b.id_banco = vxfp.id_banco "
        sql &= "JOIN entidades_crediticias ec ON ec.id_entidad_crediticia = vxfp.id_entidad_crediticia "
        sql &= "JOIN cupon c ON c.id_cupon = vxfp.id_cupon "

        tabla = SoporteBD.leerBD_simple(sql)

        Dim c As Integer
        Me.grid1.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1
            Me.grid1.Rows.Add()
            Me.grid1.Rows(c).Cells(0).Value = tabla.Rows(c)("c.numero_lote")
            Me.grid1.Rows(c).Cells(1).Value = tabla.Rows(c)("c.numero_autorizacion_online")
            Me.grid1.Rows(c).Cells(2).Value = tabla.Rows(c)("ec.nombre")
            Me.grid1.Rows(c).Cells(3).Value = tabla.Rows(c)("b.nombre")
            Me.grid1.Rows(c).Cells(4).Value = tabla.Rows(c)("c.precio")
            Me.grid1.Rows(c).Cells(5).Value = tabla.Rows(c)("vxfp.id_banco")
            Me.grid1.Rows(c).Cells(6).Value = tabla.Rows(c)("vxfp.id_cupon")
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
            Me.grid1.Rows(c).Cells(0).Value = tabla.Rows(c)("id_cupon")
            Me.grid1.Rows(c).Cells(1).Value = tabla.Rows(c)("numero_lote")
            Me.grid1.Rows(c).Cells(2).Value = tabla.Rows(c)("numero_autorizacion_online")
        Next
        Me.cargar_grilla_cupon()
    End Sub

    Private Sub btn_buscarBANCO_Click(sender As Object, e As EventArgs) Handles btn_buscarBANCO.Click
        If cmb_bancoBUSCAR.Text = "(Seleccione Banco)" Then
            Me.cargar_grilla_cupon()
            MsgBox("No existe valor de búsqueda", MsgBoxStyle.OkOnly, "Error")
            Return
        End If
        Dim sql As String = "SELECT p.id_cupon, p.numero_lote, r.nombre AS n_rubro, f.nombre AS n_fabrica FROM productos p"
        sql &= " JOIN rubros r ON p.id_rubro = r.id_rubro"
        sql &= " JOIN fabricas f ON p.id_fabrica = f.id_fabrica"
        'sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
        Me.buscar(sql)
    End Sub

    Private Sub cmb_bancoBUSCAR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_bancoBUSCAR.SelectedIndexChanged
        busqueda_general()
    End Sub

    Private Sub cmb_tarjetaBUSCAR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tarjetaBUSCAR.SelectedIndexChanged
        busqueda_general()
    End Sub

    Private Sub busqueda_general()

        If cmb_bancoBUSCAR.SelectedIndex = -1 Then
            If cmb_tarjetaBUSCAR.SelectedIndex = -1 Then
                Return
            Else
                Return
            End If
        Else
            Return
        End If

        If cmb_bancoBUSCAR.SelectedIndex = 0 Then
            If cmb_tarjetaBUSCAR.SelectedIndex = 0 Then
                Dim buscar As String = ""
                buscar &= "SELECT p.id_cupon, p.numero_lote, r.nombre AS n_rubro, f.nombre AS n_fabrica FROM productos p"
                buscar &= " JOIN rubros r ON p.id_rubro = r.id_rubro"
                buscar &= " JOIN fabricas f ON p.id_fabrica = f.id_fabrica"
                Me.buscar(buscar)
            Else
                Dim buscar As String = ""
                buscar &= "SELECT p.id_cupon, p.numero_lote, r.nombre AS n_rubro, f.nombre AS n_fabrica FROM productos p"
                buscar &= " JOIN rubros r ON p.id_rubro = r.id_rubro"
                buscar &= " JOIN fabricas f ON p.id_fabrica = f.id_fabrica"
                buscar &= " JOIN ventasXformas_pago vxfp ON vxfp.id_cupon = p.id_cupon"
                buscar &= " WHERE vxfp.id_banco = " & Me.cmb_bancoBUSCAR.SelectedValue
                Me.buscar(buscar)
            End If
        Else

            If cmb_tarjetaBUSCAR.SelectedIndex = 0 Then
                Dim buscar As String = ""
                buscar &= "SELECT p.id_cupon, p.numero_lote, r.nombre AS n_rubro, f.nombre AS n_fabrica FROM productos p"
                buscar &= " JOIN rubros r ON p.id_rubro = r.id_rubro"
                buscar &= " JOIN fabricas f ON p.id_fabrica = f.id_fabrica"
                buscar &= " JOIN ventasXformas_pago vxfp ON vxfp.id_cupon = p.id_cupon"
                buscar &= " WHERE vxfp.id_entidad_crediticia = " & Me.cmb_tarjetaBUSCAR.SelectedValue
                Me.buscar(buscar)
            Else
                Dim buscar As String = ""
                buscar &= "SELECT p.id_cupon, p.numero_lote, r.nombre AS n_rubro, f.nombre AS n_fabrica FROM productos p"
                buscar &= " JOIN rubros r ON p.id_rubro = r.id_rubro"
                buscar &= " JOIN fabricas f ON p.id_fabrica = f.id_fabrica"
                buscar &= " JOIN ventasXformas_pago vxfp ON vxfp.id_cupon = p.id_cupon"
                buscar &= " WHERE vxfp.id_entidad_crediticia = " & Me.cmb_tarjetaBUSCAR.SelectedValue
                buscar &= " AND vxfp.id_banco = " & Me.cmb_bancoBUSCAR.SelectedValue
                Me.buscar(buscar)
            End If

        End If
    End Sub
End Class