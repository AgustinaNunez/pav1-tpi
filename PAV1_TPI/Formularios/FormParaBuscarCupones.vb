Public Class FormParaBuscarCupones

    Private Sub FormParaBuscarCupones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub cargar_grilla_cupon()
        Dim tabla As New DataTable
        Dim sql_cargar_grilla As String = ""
        sql_cargar_grilla &= "SELECT * FROM cupon WHERE numero_lote =" & Me.txt_buscar.Text

        tabla = SoporteBD.leerBD_simple(sql_cargar_grilla)

        Dim c As Integer
        Me.grid1.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1

            Me.grid1.Rows.Add()
            Me.grid1.Rows(c).Cells(0).Value = tabla.Rows(c)("id_cupon")
            Me.grid1.Rows(c).Cells(1).Value = tabla.Rows(c)("numero_cupon")
            Me.grid1.Rows(c).Cells(2).Value = tabla.Rows(c)("numero_autorizacion_online")

        Next
        Me.txt_buscar.Focus()
    End Sub
    ''Private Sub busquedaDinamica(ByVal id As String, ByVal dgv As DataGridView)

    ''    Try
    ''        Dim sql As String = ""
    ''        Dim tabla As New DataTable
    ''        sql &= "SELECT * FROM cupon WHERE  numero_lote like '" & id + "%" & "'"
    ''        tabla = SoporteBD.leerBD_simple(sql)
    ''        dgv.DataSource = tabla
    ''        Dim c As Integer
    ''        For c = 0 To tabla.Rows.Count - 1
    ''            Me.grid1.Rows(c).Cells(0).Value = tabla.Rows(c)("id_cupon")
    ''            Me.grid1.Rows(c).Cells(1).Value = tabla.Rows(c)("numero_lote")
    ''            Me.grid1.Rows(c).Cells(2).Value = tabla.Rows(c)("numero_autorizacion_online")
    ''            Me.txt_buscar.Focus()
    ''        Next
    ''    Catch ex As Exception
    ''        MsgBox("Error al buscar en la grilla" + ex.ToString)
    ''    End Try
    ''End Sub

    ''Private Sub txt_buscar_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
    ''    busquedaDinamica(txt_buscar.Text, grid1)
    ''End Sub
    Private Sub limpiar_campos()

        
        
        cmb_tarjetaBUSCAR.Text = "(Seleccione fábrica)"
        cmb_bancoBUSCAR.Text = "(Seleccione rubro)"


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
        sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
        Me.buscar(sql)
    End Sub
End Class