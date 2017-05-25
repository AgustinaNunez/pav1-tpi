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
        sql &= "SELECT cupon.id_cupon, cupon.numero_lote, cupon.numero_autorizacion_online, bancos.id_banco, bancos.nombre, ventasXformas_pago.id_venta, ventasXformas_pago.id_forma_pago, "
        sql &= " ventasXformas_pago.id_cupon, entidades_crediticias.id_entidad_crediticia, entidades_crediticias.nombre As nombre_entidad, ventasXformas_pago.id_banco, "
        sql &= " ventasXformas_pago.id_entidad_crediticia AS id_entidad"
        sql &= " FROM bancos b INNER JOIN"
        sql &= " ventasXformas_pago ON bancos.id_banco = ventasXformas_pago.id_banco INNER JOIN"
        sql &= " cupon ON ventasXformas_pago.id_cupon = cupon.id_cupon INNER JOIN"
        sql &= " entidades_crediticias ON ventasXformas_pago.id_entidad_crediticia = entidades_crediticias.id_entidad_crediticia"

        tabla = SoporteBD.leerBD_simple(sql)

        Dim c As Integer
        Me.grid1.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1
            Me.grid1.Rows.Add()
            Me.grid1.Rows(c).Cells(0).Value = tabla.Rows(c)("id_cupon")
            Me.grid1.Rows(c).Cells(1).Value = tabla.Rows(c)("numero_cupon")
            Me.grid1.Rows(c).Cells(2).Value = tabla.Rows(c)("numero_autorizacion_online")
            Me.grid1.Rows(c).Cells(3).Value = tabla.Rows(c)("id_cupon")
            Me.grid1.Rows(c).Cells(4).Value = tabla.Rows(c)("id_cupon")
            Me.grid1.Rows(c).Cells(5).Value = tabla.Rows(c)("id_cupon")
            Me.grid1.Rows(c).Cells(6).Value = tabla.Rows(c)("id_cupon")
            Me.grid1.Rows(c).Cells(7).Value = tabla.Rows(c)("id_cupon")
        Next
    End Sub

    Private Sub limpiar_campos()
        cmb_tarjetaBUSCAR.Text = "(seleccione tarjeta)"
        cmb_bancoBUSCAR.Text = "(seleccione banco)"
    End Sub

    Private Sub buscar(ByVal sql As String)
        Me.limpiar_campos()
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

        If tabla.Rows.Count = 0 Then
            MsgBox("No se encontraron resultados", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
    'PARA BUSCAR POR COMBOS




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
End Class