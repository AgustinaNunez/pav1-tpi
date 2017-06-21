Public Class ReporteProductos
    Private Sub ReporteProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoporteGUI.cargar_combo(cbo_rubroBUSCAR, SoporteBD.leerBD_simple("SELECT * FROM rubros ORDER BY nombre"), "id_rubro", "nombre")
        SoporteGUI.cargar_combo(cbo_fabricaBUSCAR, SoporteBD.leerBD_simple("SELECT * FROM fabricas ORDER BY nombre"), "id_fabrica", "nombre")
        Me.cargar_productos()
        'Me.limpiar_campos()
    End Sub

    Private Sub cargar_productos()
        Dim sql As String = "SELECT p.id_producto, p.descripcion, p.stock, p.precio_venta, r.nombre AS 'nombre_rubro', f.nombre AS 'nombre_fabrica' FROM productos p"
        sql &= " JOIN rubros r ON p.id_rubro = r.id_rubro"
        sql &= " JOIN fabricas f ON p.id_fabrica = f.id_fabrica"
        sql &= " WHERE p.dado_de_baja = 0"
        Me.cargar_grilla(sql)
    End Sub

    Private Sub limpiar_campos()
        Me.cbo_fabricaBUSCAR.SelectedIndex = -1
        Me.cbo_rubroBUSCAR.SelectedIndex = -1
        Me.txt_nombre.Text = ""
    End Sub

    Private Sub cargar_grilla(ByRef sql As String)
        t_productosBindingSource.DataSource = SoporteBD.leerBD_simple(sql)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cbo_fabricaBUSCAR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_fabricaBUSCAR.SelectedIndexChanged
        buscador_general()
    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged
        If txt_nombre.Text = "" Then
            Return
        End If

        buscador_general()
    End Sub

    Private Sub buscador_general()

        'If cbo_fabricaBUSCAR.Text = "(Seleccionar valor)" Then
        '    cargar_productos()
        'End If

        'If cbo_rubroBUSCAR.Text = "(Seleccionar valor)" Then
        '    cargar_productos()
        'End If

        If txt_nombre.Text = "" Then

        End If

        If cmb_stock.SelectedIndex = -1 Then
            If cbo_fabricaBUSCAR.SelectedIndex = -1 Then
                If cbo_rubroBUSCAR.SelectedIndex = -1 Then
                    Return
                End If
            End If

            If cbo_fabricaBUSCAR.SelectedIndex = 0 Then
                If cbo_rubroBUSCAR.SelectedIndex = -1 Then
                    Return
                End If
            End If

            If cbo_rubroBUSCAR.SelectedIndex = -1 Then
                If cbo_fabricaBUSCAR.SelectedIndex = -1 Then
                    Return
                End If
            End If

            If cbo_rubroBUSCAR.SelectedIndex = 0 Then
                If cbo_fabricaBUSCAR.SelectedIndex = -1 Then
                    Return
                End If
            End If

            If cbo_rubroBUSCAR.SelectedIndex = 0 Then
                If cbo_fabricaBUSCAR.SelectedIndex = 0 Then
                    Dim sql As String = ""

                    sql &= "SELECT id_producto, descripcion, stock, precio_venta, r.nombre AS 'nombre_rubro', f.nombre AS 'nombre_fabrica', dado_de_baja"
                    sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                    If txt_nombre.Text <> "" Then
                        sql &= " WHERE descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                    End If

                    Me.cargar_grilla(sql)
                End If
            End If
        End If

        If cmb_stock.SelectedIndex = -1 Then

            If cbo_fabricaBUSCAR.SelectedIndex = 0 Then

                If cbo_rubroBUSCAR.SelectedIndex = 0 Then

                    Dim sql As String = ""

                    sql &= "SELECT id_producto, descripcion, stock, precio_venta, r.nombre AS 'nombre_rubro', f.nombre AS 'nombre_fabrica', dado_de_baja"
                    sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                    If txt_nombre.Text <> "" Then
                        sql &= " WHERE descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                    End If

                    Me.cargar_grilla(sql)

                Else
                    Dim sql As String = ""

                    sql &= "SELECT id_producto, descripcion, stock, precio_venta, r.nombre AS 'nombre_rubro', f.nombre AS 'nombre_fabrica', dado_de_baja"
                    sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                    sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                    If txt_nombre.Text <> "" Then
                        sql &= " AND descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                    End If



                    Me.cargar_grilla(sql)
                End If

            Else

                If cbo_rubroBUSCAR.Text = "(Seleccionar valor)" Then
                    Dim sql As String = ""

                    sql &= "Select id_producto, descripcion, stock, precio_venta, r.nombre As 'nombre_rubro', f.nombre AS 'nombre_fabrica', dado_de_baja"
                    sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                    sql &= " WHERE f.id_fabrica = " & Me.cbo_fabricaBUSCAR.SelectedValue
                    If txt_nombre.Text <> "" Then
                        sql &= " AND descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                    End If


                    Me.cargar_grilla(sql)

                Else
                    Dim sql As String = ""

                    sql &= "SELECT id_producto, descripcion, stock, precio_venta, r.nombre AS 'nombre_rubro', f.nombre AS 'nombre_fabrica', dado_de_baja"
                    sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                    sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                    sql &= " AND f.id_fabrica = " & Me.cbo_fabricaBUSCAR.SelectedValue
                    If txt_nombre.Text <> "" Then
                        sql &= " AND descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                    End If


                    Me.cargar_grilla(sql)

                End If

            End If

        Else

            If cmb_stock.Text = "Disponible" Then

                If cbo_fabricaBUSCAR.Text = "(Seleccionar valor)" Then
                    If cbo_rubroBUSCAR.Text = "(Seleccionar valor)" Then
                        Dim sql As String = ""

                        sql &= "SELECT id_producto, descripcion, stock, precio_venta, r.nombre AS 'nombre_rubro', f.nombre AS 'nombre_fabrica', dado_de_baja"
                        sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                        sql &= " WHERE dado_de_baja = 0"
                        sql &= " AND stock > 0"
                        If txt_nombre.Text <> "" Then
                            sql &= " AND descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                        End If


                        Me.cargar_grilla(sql)

                    Else
                        Dim sql As String = ""

                        sql &= "SELECT id_producto, descripcion, stock, precio_venta, r.nombre AS 'nombre_rubro', f.nombre AS 'nombre_fabrica', dado_de_baja"
                        sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                        sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                        sql &= " AND dado_de_baja = 0"
                        sql &= " AND stock > 0"
                        If txt_nombre.Text <> "" Then
                            sql &= " AND descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                        End If


                        Me.cargar_grilla(sql)

                    End If

                Else

                    If cbo_rubroBUSCAR.Text = "(Seleccionar valor)" Then
                        Dim sql As String = ""

                        sql &= "SELECT id_producto, descripcion, stock, precio_venta, r.nombre AS 'nombre_rubro', f.nombre AS 'nombre_fabrica', dado_de_baja"
                        sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                        sql &= " WHERE f.id_fabrica = " & Me.cbo_fabricaBUSCAR.SelectedValue
                        sql &= " AND dado_de_baja = 0"
                        sql &= " AND stock > 0"
                        If txt_nombre.Text <> "" Then
                            sql &= " AND descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                        End If


                        Me.cargar_grilla(sql)

                    Else
                        Dim sql As String = ""

                        sql &= "SELECT id_producto, descripcion, stock, precio_venta, r.nombre AS 'nombre_rubro', f.nombre AS 'nombre_fabrica', dado_de_baja"
                        sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                        sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                        sql &= " AND f.id_fabrica = " & Me.cbo_fabricaBUSCAR.SelectedValue
                        sql &= " AND dado_de_baja = 0"
                        sql &= " AND stock > 0"
                        If txt_nombre.Text <> "" Then
                            sql &= " AND descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                        End If


                        Me.cargar_grilla(sql)

                    End If

                End If

            End If

            If cmb_stock.Text = "No disponible" Then
                If cbo_fabricaBUSCAR.Text = "(Seleccionar valor)" Then
                    If cbo_rubroBUSCAR.Text = "(Seleccionar valor)" Then
                        Dim sql As String = ""

                        sql &= "SELECT id_producto, descripcion, stock, precio_venta, r.nombre AS 'nombre_rubro', f.nombre AS 'nombre_fabrica', dado_de_baja"
                        sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                        sql &= " WHERE dado_de_baja = 0"
                        sql &= " AND stock = 0"
                        If txt_nombre.Text <> "" Then
                            sql &= " AND descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                        End If


                        Me.cargar_grilla(sql)

                    Else
                        Dim sql As String = ""

                        sql &= "SELECT id_producto, descripcion, stock, precio_venta, r.nombre AS 'nombre_rubro', f.nombre AS 'nombre_fabrica', dado_de_baja"
                        sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                        sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                        sql &= " AND dado_de_baja = 0"
                        sql &= " AND stock = 0"
                        If txt_nombre.Text <> "" Then
                            sql &= " AND descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                        End If


                        Me.cargar_grilla(sql)

                    End If

                Else

                    If cbo_rubroBUSCAR.Text = "(Seleccionar valor)" Then
                        Dim sql As String = ""

                        sql &= "SELECT id_producto, descripcion, stock, precio_venta, r.nombre AS 'nombre_rubro', f.nombre AS 'nombre_fabrica', dado_de_baja"
                        sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                        sql &= " WHERE f.id_fabrica = " & Me.cbo_fabricaBUSCAR.SelectedValue
                        sql &= " AND dado_de_baja = 0"
                        sql &= " AND stock = 0"
                        If txt_nombre.Text <> "" Then
                            sql &= " AND descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                        End If


                        Me.cargar_grilla(sql)

                    Else
                        Dim sql As String = ""

                        sql &= "SELECT id_producto, descripcion, stock, precio_venta, r.nombre AS 'nombre_rubro', f.nombre AS 'nombre_fabrica', dado_de_baja"
                        sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                        sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                        sql &= " AND f.id_fabrica = " & Me.cbo_fabricaBUSCAR.SelectedValue
                        sql &= " AND dado_de_baja = 0"
                        sql &= " AND stock = 0"
                        If txt_nombre.Text <> "" Then
                            sql &= " AND descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                        End If


                        Me.cargar_grilla(sql)

                    End If

                End If

            End If

        End If

        If cmb_stock.Text = "Ambos" Then
            If cbo_fabricaBUSCAR.Text = "(Seleccionar valor)" Then
                If cbo_rubroBUSCAR.Text = "(Seleccionar valor)" Then
                    Dim sql As String = ""

                    sql &= "SELECT id_producto, descripcion, stock, precio_venta, r.nombre AS 'nombre_rubro', f.nombre AS 'nombre_fabrica', dado_de_baja"
                    sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                    sql &= " WHERE dado_de_baja = 0"
                    sql &= " AND stock >= 0"
                    If txt_nombre.Text <> "" Then
                        sql &= " AND descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                    End If


                    Me.cargar_grilla(sql)

                Else
                    Dim sql As String = ""

                    sql &= "SELECT id_producto, descripcion, stock, precio_venta, r.nombre AS 'nombre_rubro', f.nombre AS 'nombre_fabrica', dado_de_baja"
                    sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                    sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                    sql &= " AND dado_de_baja = 0"
                    sql &= " AND stock >= 0"
                    If txt_nombre.Text <> "" Then
                        sql &= " AND descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                    End If


                    Me.cargar_grilla(sql)

                End If

            Else

                If cbo_rubroBUSCAR.Text = "(Seleccionar valor)" Then
                    Dim sql As String = ""

                    sql &= "SELECT id_producto, descripcion, stock, precio_venta, r.nombre AS 'nombre_rubro', f.nombre AS 'nombre_fabrica', dado_de_baja"
                    sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                    sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                    sql &= " AND dado_de_baja = 0"
                    sql &= " AND stock >= 0"
                    If txt_nombre.Text <> "" Then
                        sql &= " AND descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                    End If


                    Me.cargar_grilla(sql)

                Else
                    Dim sql As String = ""

                    sql &= "SELECT id_producto, descripcion, stock, precio_venta, r.nombre AS 'nombre_rubro', f.nombre AS 'nombre_fabrica', dado_de_baja"
                    sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                    sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                    sql &= " AND f.id_fabrica = " & Me.cbo_fabricaBUSCAR.SelectedValue
                    sql &= " AND dado_de_baja = 0"
                    sql &= " AND stock >= 0"
                    If txt_nombre.Text <> "" Then
                        sql &= " AND descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                    End If


                    Me.cargar_grilla(sql)

                End If

            End If

        End If
    End Sub

    Private Sub cbo_rubroBUSCAR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_rubroBUSCAR.SelectedIndexChanged, cmb_stock.SelectedIndexChanged
        buscador_general()
    End Sub

    Private Sub cmb_habilitado_SelectedIndexChanged(sender As Object, e As EventArgs)
        buscador_general()
    End Sub
End Class