Imports System.ComponentModel
Imports System.Data.OleDb
Public Class FormProductos
    Enum tipo_grabacion
        insertar
        modificar
        ninguna
    End Enum
    Enum respuesta_validacion
        _ok
        _error
    End Enum
    Enum estado_producto
        _habilitado
        _deshabilitado
        _no_existe
    End Enum
    Dim accion As tipo_grabacion = tipo_grabacion.ninguna
    Dim seleccion As String


    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_productos()
        Me.limpiar_campos()
        SoporteGUI.cargar_combo(cbo_rubro, SoporteBD.leerBD_simple("SELECT * FROM rubros ORDER BY nombre"), "id_rubro", "nombre")
        SoporteGUI.cargar_combo(cbo_fabrica, SoporteBD.leerBD_simple("SELECT * FROM fabricas ORDER BY nombre"), "id_fabrica", "nombre")
        SoporteGUI.cargar_combo(cbo_rubroBUSCAR, SoporteBD.leerBD_simple("SELECT * FROM rubros ORDER BY nombre"), "id_rubro", "nombre")
        SoporteGUI.cargar_combo(cbo_fabricaBUSCAR, SoporteBD.leerBD_simple("SELECT * FROM fabricas ORDER BY nombre"), "id_fabrica", "nombre")


        If SoporteGUI.tipo_form_ACTUAL = SoporteGUI.tipo_form.abm Then
            Me.btn_nuevo.Enabled = True
        Else
            gb_busqueda.Visible = False
            SoporteGUI.cargar_combo(cbo_fabrica, SoporteBD.leerBD_simple("SELECT * FROM fabricas WHERE id_fabrica = " & Fabrica.id & " ORDER BY nombre"), "id_fabrica", "nombre")
            cbo_fabrica.SelectedValue = Fabrica.id
            Me.cbo_fabrica.Text = Fabrica.nombre
            Me.cargar_productosTRANSACCION()
        End If
        'Me.txt_id.Text = Format(GENERARCODIGO, "000")
    End Sub

    Private Sub cargar_productosTRANSACCION()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT p.id_producto, p.descripcion, p.stock, p.precio_lista, r.nombre AS n_rubro, f.nombre AS n_fabrica, p.dado_de_baja FROM productos p"
        sql &= " JOIN rubros r ON p.id_rubro = r.id_rubro"
        sql &= " JOIN fabricas f ON p.id_fabrica = f.id_fabrica"
        sql &= " WHERE p.dado_de_baja = 0 AND p.id_fabrica = " & Fabrica.id
        tabla = SoporteBD.leerBD_simple(sql)
        Me.cargar_grilla(tabla)
    End Sub

    Private Sub limpiar_campos()
        txt_id.Text = ""
        txt_descrip.Text = ""
        txt_precio.Text = ""
        txt_stock.Text = ""
        cbo_fabrica.SelectedIndex = -1
        cbo_rubro.SelectedIndex = -1
        'cbo_fabricaBUSCAR.SelectedIndex = 0
        'cbo_rubroBUSCAR.SelectedIndex = 0
        lbl_msj.Text = ""
        Me.ocultar_lblERROR()
        lbl_msj.Visible = False
    End Sub

    Private Function validar_campos() As respuesta_validacion
        lbl_msj.Visible = False
        Me.ocultar_lblERROR()
        Dim rdo = respuesta_validacion._ok
        If cbo_fabrica.SelectedIndex = -1 Then
            lbl_fabricaERROR.Visible = True
            cbo_fabrica.Focus()
            rdo = respuesta_validacion._error
        End If
        If cbo_rubro.SelectedIndex = -1 Then
            lbl_rubroERROR.Visible = True
            cbo_rubro.Focus()
            rdo = respuesta_validacion._error
        End If
        If txt_precio.Text = "" Then
            lbl_precioERROR.Visible = True
            txt_precio.Focus()
            rdo = respuesta_validacion._error
        End If
        If txt_descrip.Text = "" Then
            lbl_descripcionERROR.Visible = True
            txt_id.Focus()
            rdo = respuesta_validacion._error
        End If
        Return rdo
    End Function

    Private Sub ocultar_lblERROR()
        lbl_precioERROR.Visible = False
        lbl_rubroERROR.Visible = False
        lbl_fabricaERROR.Visible = False
    End Sub

    Private Function validar_producto() As estado_producto
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql &= "SELECT id_producto, dado_de_baja FROM productos WHERE id_producto = " & txt_id.Text
        tabla = SoporteBD.leerBD_simple(sql)

        If tabla.Rows.Count = 1 Then
            If tabla.Rows(0)("dado_de_baja") = 1 Then
                Return estado_producto._deshabilitado
            Else
                Return estado_producto._habilitado
            End If
        End If
        Return estado_producto._no_existe
    End Function

    Private Sub habilitar_producto()
        'ACTUALIZACION DEL ESTADO DE BAJA DEL PRODUCTO EN LA BD
        Dim sql2 As String = "UPDATE productos SET dado_de_baja = 0 WHERE id_producto = " & Me.txt_id.Text
        SoporteBD.escribirBD_simple(sql2)
    End Sub

    Private Sub cargar_campos(ByVal sql As String)
        Dim tabla As New DataTable
        tabla = SoporteBD.leerBD_simple(sql)

        Me.txt_id.Text = tabla.Rows(0)("id_producto")
        Me.txt_descrip.Text = tabla.Rows(0)("descripcion")
        Me.txt_stock.Text = tabla.Rows(0)("stock")
        Me.txt_precio.Text = tabla.Rows(0)("precio_lista")
        Me.cbo_rubro.SelectedValue = tabla.Rows(0)("id_rubro")
        Me.cbo_fabrica.SelectedValue = tabla.Rows(0)("id_fabrica")


        Me.accion = tipo_grabacion.modificar
        Me.habilitar_campos()
        Me.btn_guardar.Enabled = True
        If Me.dgv_productos.CurrentRow.Cells("stock").Value = 0 Then
            Me.btn_eliminar.Enabled = True
        End If

    End Sub

    Private Sub insertar()
        Dim sql As String = ""
        sql &= "INSERT INTO productos(id_producto, descripcion, stock, precio_lista, id_rubro, id_fabrica, dado_de_baja)"
        sql &= " VALUES("
        sql &= Me.txt_id.Text
        sql &= ", '" & Me.txt_descrip.Text & "'"
        sql &= ", 0"
        sql &= ", '" & Me.txt_precio.Text & "'"
        sql &= "," & Me.cbo_rubro.SelectedValue
        sql &= ", '" & Me.cbo_fabrica.SelectedValue & "'"
        sql &= ", 0)"

        SoporteBD.escribirBD_simple(sql)
        Me.cargar_productos()
        Me.deshabilitar_campos()
        Me.btn_guardar.Enabled = False
    End Sub

    Private Sub deshabilitar_campos()
        Me.txt_id.Enabled = False
        Me.txt_descrip.Enabled = False
        Me.txt_stock.Enabled = False
        Me.txt_precio.Enabled = False
        Me.cbo_rubro.Enabled = False
        Me.cbo_fabrica.Enabled = False
    End Sub

    Private Sub dgv_productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_productos.CellContentClick, dgv_productos.CellContentDoubleClick, dgv_productos.CellDoubleClick
        Dim sql As String = "SELECT * FROM productos "
        sql &= " WHERE id_producto = " & Me.dgv_productos.CurrentRow.Cells(0).Value
        Me.cargar_campos(sql)
    End Sub

    Private Sub modificar()
        Dim sql As String = ""
        sql &= "UPDATE productos SET "
        sql &= "descripcion = '" & Me.txt_descrip.Text & "'"
        sql &= ", stock = " & Me.txt_stock.Text
        sql &= ", precio_lista = " & Me.txt_precio.Text
        sql &= ", id_rubro = " & Me.cbo_rubro.SelectedValue
        sql &= ", id_fabrica = " & Me.cbo_fabrica.SelectedValue
        sql &= " WHERE id_producto = " & Me.txt_id.Text

        SoporteBD.escribirBD_simple(sql)
        cargar_productos()
        MessageBox.Show("El producto fue modificado exitosamente.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.btn_guardar.Enabled = False
        Me.btn_eliminar.Enabled = False
        Me.deshabilitar_campos()
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        If SoporteGUI.tipo_form_ACTUAL = SoporteGUI.tipo_form.transaccion Then
            Me.limpiar_campos()
            Me.habilitar_campos()
            Me.cbo_fabrica.SelectedValue = Fabrica.id
            Me.lbl_fabrica.Enabled = False
            Me.cbo_fabrica.Enabled = False
            Me.lbl_stock.Enabled = True
            Me.txt_stock.Enabled = False
            Me.accion = tipo_grabacion.insertar
            Me.txt_id.Text = SoporteBD.autogenerar_codigo("AUTOGENERARCODIGO_productos")
            Me.txt_descrip.Focus()
            Me.cargar_productosTRANSACCION()
            Me.btn_guardar.Enabled = True
            Me.btn_eliminar.Enabled = False
        Else
            Me.limpiar_campos()
            Me.habilitar_campos()
            Me.lbl_fabrica.Enabled = True
            Me.cbo_fabrica.Enabled = True
            Me.lbl_stock.Enabled = True
            Me.txt_stock.Enabled = False
            Me.accion = tipo_grabacion.insertar

            Me.txt_id.Text = SoporteBD.autogenerar_codigo("AUTOGENERARCODIGO_productos")

            Me.txt_descrip.Focus()
            Me.btn_guardar.Enabled = True
            Me.btn_eliminar.Enabled = False
        End If
        
    End Sub

    Private Sub habilitar_campos()
        Me.txt_descrip.Enabled = True
        Me.txt_precio.Enabled = True
        Me.cbo_rubro.Enabled = True
        Me.cbo_fabrica.Enabled = True

        Me.lbl_id.Enabled = True
        Me.lbl_descripcion.Enabled = True
        Me.lbl_precio.Enabled = True
        Me.lbl_stock.Enabled = True
        Me.lbl_rubro.Enabled = True
        Me.lbl_fabrica.Enabled = True
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        If MessageBox.Show("¿Está seguro de cancelar el producto " & Me.txt_descrip.Text & " ?", "Error", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            Dim sql As String = ""
            sql &= "UPDATE productos SET dado_de_baja = 1 WHERE id_producto = " & Me.txt_id.Text
            SoporteBD.leerBD_simple(sql)
            deshabilitar_campos()
            Me.btn_eliminar.Enabled = False
            Me.btn_guardar.Enabled = False
        End If

        If Me.dgv_productos.CurrentCell.Selected = False Then
            lbl_msj.Text = " Falta seleccionar dato."
        End If


    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If accion = tipo_grabacion.ninguna Then
            lbl_msj.Text = " No hay cambios para guardar."
            lbl_msj.Visible = True
            Return
        End If
        If validar_campos() = respuesta_validacion._ok Then
            If accion = tipo_grabacion.insertar Then
                Select Case validar_producto()
                    Case estado_producto._no_existe
                        insertar()
                        SoporteGUI.respuesta_ventana = Windows.Forms.DialogResult.OK
                        Dim id_prod As String = txt_id.Text
                        Me.limpiar_campos()
                        lbl_msj.Text = " El producto " & id_prod & " se cargó correctamente."
                        lbl_msj.Visible = True
                    Case estado_producto._habilitado
                        MessageBox.Show("El producto ya existe, por favor, modificarlo.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case estado_producto._deshabilitado
                        If MessageBox.Show("El producto con Id." & Me.txt_id.Text & " está registrado como producto eliminado." & vbCrLf & "¿Desea habilitarlo?", "Productos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                            Me.habilitar_producto()
                            Me.cargar_campos(" SELECT * FROM productos WHERE id_producto = " & Me.txt_id.Text)
                        End If
                End Select
            Else
                modificar()
                Dim id_prod As String = txt_id.Text
                Me.limpiar_campos()
                lbl_msj.Text = " El producto " & id_prod & " se modificó correctamente."
                lbl_msj.Visible = True
            End If
        Else
            lbl_msj.Text = " Faltan campos obligatorios."
            lbl_msj.Visible = True
        End If
    End Sub

    Private Sub cargar_productos()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT p.id_producto, p.descripcion, p.stock, p.precio_lista, r.nombre AS n_rubro, f.nombre AS n_fabrica, p.dado_de_baja FROM productos p"
        sql &= " JOIN rubros r ON p.id_rubro = r.id_rubro"
        sql &= " JOIN fabricas f ON p.id_fabrica = f.id_fabrica"
        sql &= " WHERE p.dado_de_baja = 0"
        tabla = SoporteBD.leerBD_simple(sql)
        Me.cargar_grilla(tabla)
    End Sub

    Private Sub cargar_grilla(ByRef tabla As DataTable)
        Dim c As Integer
        Me.dgv_productos.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_productos.Rows.Add()
            Me.dgv_productos.Rows(c).Cells(0).Value = tabla.Rows(c)("id_producto")
            Me.dgv_productos.Rows(c).Cells(1).Value = tabla.Rows(c)("descripcion")
            Me.dgv_productos.Rows(c).Cells(2).Value = tabla.Rows(c)("stock")
            Me.dgv_productos.Rows(c).Cells(3).Value = tabla.Rows(c)("precio_lista")
            Me.dgv_productos.Rows(c).Cells(4).Value = tabla.Rows(c)("n_rubro")
            Me.dgv_productos.Rows(c).Cells(5).Value = tabla.Rows(c)("n_fabrica")
            Me.dgv_productos.Rows(c).Cells(6).Value = tabla.Rows(c)("dado_de_baja")
        Next
    End Sub

    Private Sub buscar(ByVal sql As String)
        'Me.limpiar_campos()
        Dim tabla As New DataTable
        tabla = SoporteBD.leerBD_simple(sql)
        Me.cargar_grilla(tabla)
        If tabla.Rows.Count = 0 Then
            'MsgBox("No se encontraron resultados", MsgBoxStyle.OkOnly, "Error")
            lbl_msj.Text = "No se encontraron resultados."
            lbl_msj.Visible = True
            txt_idBUSCAR.Text = ""
            txt_idBUSCAR.Focus()
            cargar_productos()
        End If
    End Sub

    Private Sub cmb_habilitado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_habilitado.SelectedIndexChanged
        buscador_general()
    End Sub


    Private Sub cbo_rubroBUSCAR_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_rubroBUSCAR.SelectedValueChanged
        buscador_general()
    End Sub


    Private Sub cbo_fabricaBUSCAR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_fabricaBUSCAR.SelectedIndexChanged
        buscador_general()
    End Sub


    Private Sub txt_idBUSCAR_TextChanged(sender As Object, e As EventArgs) Handles txt_idBUSCAR.TextChanged
        If txt_idBUSCAR.Text = "" Then
            Me.cargar_productos()
            Return
        End If

        buscador_general()

    End Sub

    Private Sub buscador_general()

        If txt_idBUSCAR.Text = "" Then

        End If

        If cmb_habilitado.SelectedIndex = -1 Then
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
                    Return
                End If
            End If
        End If

        If cmb_habilitado.SelectedIndex = -1 Then

            If cbo_fabricaBUSCAR.SelectedIndex = 0 Then

                If cbo_rubroBUSCAR.SelectedIndex = 0 Then

                    Dim sql As String = ""
                    Dim tabla As New DataTable
                    sql &= "SELECT id_producto, descripcion, stock, precio_lista, r.nombre AS 'n_rubro', f.nombre AS 'n_fabrica', dado_de_baja"
                    sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                    If txt_idBUSCAR.Text <> "" Then
                        sql &= " WHERE id_producto = " & Me.txt_idBUSCAR.Text
                    End If

                    tabla = SoporteBD.leerBD_simple(sql)

                    Me.cargar_grilla(tabla)

                Else
                    Dim sql As String = ""
                    Dim tabla As New DataTable
                    sql &= "SELECT id_producto, descripcion, stock, precio_lista, r.nombre AS 'n_rubro', f.nombre AS 'n_fabrica', dado_de_baja"
                    sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                    sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                    If txt_idBUSCAR.Text <> "" Then
                        sql &= " AND id_producto = " & Me.txt_idBUSCAR.Text
                    End If

                    tabla = SoporteBD.leerBD_simple(sql)

                    Me.cargar_grilla(tabla)
                End If

            Else

                If cbo_rubroBUSCAR.Text = "(Seleccionar valor)" Then
                    Dim sql As String = ""
                    Dim tabla As New DataTable
                    sql &= "SELECT id_producto, descripcion, stock, precio_lista, r.nombre AS 'n_rubro', f.nombre AS 'n_fabrica', dado_de_baja"
                    sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                    sql &= " WHERE f.id_fabrica = " & Me.cbo_fabricaBUSCAR.SelectedValue
                    If txt_idBUSCAR.Text <> "" Then
                        sql &= " AND id_producto = " & Me.txt_idBUSCAR.Text
                    End If
                    tabla = SoporteBD.leerBD_simple(sql)

                    Me.cargar_grilla(tabla)

                Else
                    Dim sql As String = ""
                    Dim tabla As New DataTable
                    sql &= "SELECT id_producto, descripcion, stock, precio_lista, r.nombre AS 'n_rubro', f.nombre AS 'n_fabrica', dado_de_baja"
                    sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                    sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                    sql &= " AND f.id_fabrica = " & Me.cbo_fabricaBUSCAR.SelectedValue
                    If txt_idBUSCAR.Text <> "" Then
                        sql &= " AND id_producto = " & Me.txt_idBUSCAR.Text
                    End If
                    tabla = SoporteBD.leerBD_simple(sql)

                    Me.cargar_grilla(tabla)

                End If

            End If

        Else

            If cmb_habilitado.Text = "Si" Then

                If cbo_fabricaBUSCAR.Text = "(Seleccionar valor)" Then
                    If cbo_rubroBUSCAR.Text = "(Seleccionar valor)" Then
                        Dim sql As String = ""
                        Dim tabla As New DataTable
                        sql &= "SELECT id_producto, descripcion, stock, precio_lista, r.nombre AS 'n_rubro', f.nombre AS 'n_fabrica', dado_de_baja"
                        sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                        sql &= " WHERE dado_de_baja = 0"
                        If txt_idBUSCAR.Text <> "" Then
                            sql &= " AND id_producto = " & Me.txt_idBUSCAR.Text
                        End If
                        tabla = SoporteBD.leerBD_simple(sql)

                        Me.cargar_grilla(tabla)

                    Else
                        Dim sql As String = ""
                        Dim tabla As New DataTable
                        sql &= "SELECT id_producto, descripcion, stock, precio_lista, r.nombre AS 'n_rubro', f.nombre AS 'n_fabrica', dado_de_baja"
                        sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                        sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                        sql &= " AND dado_de_baja = 0"
                        If txt_idBUSCAR.Text <> "" Then
                            sql &= " AND id_producto = " & Me.txt_idBUSCAR.Text
                        End If
                        tabla = SoporteBD.leerBD_simple(sql)

                        Me.cargar_grilla(tabla)

                    End If

                Else

                    If cbo_rubroBUSCAR.Text = "(Seleccionar valor)" Then
                        Dim sql As String = ""
                        Dim tabla As New DataTable
                        sql &= "SELECT id_producto, descripcion, stock, precio_lista, r.nombre AS 'n_rubro', f.nombre AS 'n_fabrica', dado_de_baja"
                        sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                        sql &= " WHERE f.id_fabrica = " & Me.cbo_fabricaBUSCAR.SelectedValue
                        sql &= " AND dado_de_baja = 0"
                        If txt_idBUSCAR.Text <> "" Then
                            sql &= " AND id_producto = " & Me.txt_idBUSCAR.Text
                        End If
                        tabla = SoporteBD.leerBD_simple(sql)

                        Me.cargar_grilla(tabla)

                    Else
                        Dim sql As String = ""
                        Dim tabla As New DataTable
                        sql &= "SELECT id_producto, descripcion, stock, precio_lista, r.nombre AS 'n_rubro', f.nombre AS 'n_fabrica', dado_de_baja"
                        sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                        sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                        sql &= " AND f.id_fabrica = " & Me.cbo_fabricaBUSCAR.SelectedValue
                        sql &= " AND dado_de_baja = 0"
                        If txt_idBUSCAR.Text <> "" Then
                            sql &= " AND id_producto = " & Me.txt_idBUSCAR.Text
                        End If
                        tabla = SoporteBD.leerBD_simple(sql)

                        Me.cargar_grilla(tabla)

                    End If

                End If

            End If

            If cmb_habilitado.Text = "No" Then
                If cbo_fabricaBUSCAR.Text = "(Seleccionar valor)" Then
                    If cbo_rubroBUSCAR.Text = "(Seleccionar valor)" Then
                        Dim sql As String = ""
                        Dim tabla As New DataTable
                        sql &= "SELECT id_producto, descripcion, stock, precio_lista, r.nombre AS 'n_rubro', f.nombre AS 'n_fabrica', dado_de_baja"
                        sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                        sql &= " WHERE dado_de_baja = 1"
                        If txt_idBUSCAR.Text <> "" Then
                            sql &= " AND id_producto = " & Me.txt_idBUSCAR.Text
                        End If
                        tabla = SoporteBD.leerBD_simple(sql)

                        Me.cargar_grilla(tabla)

                    Else
                        Dim sql As String = ""
                        Dim tabla As New DataTable
                        sql &= "SELECT id_producto, descripcion, stock, precio_lista, r.nombre AS 'n_rubro', f.nombre AS 'n_fabrica', dado_de_baja"
                        sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                        sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                        sql &= " AND dado_de_baja = 1"
                        If txt_idBUSCAR.Text <> "" Then
                            sql &= " AND id_producto = " & Me.txt_idBUSCAR.Text
                        End If
                        tabla = SoporteBD.leerBD_simple(sql)

                        Me.cargar_grilla(tabla)

                    End If

                Else

                    If cbo_rubroBUSCAR.Text = "(Seleccionar valor)" Then
                        Dim sql As String = ""
                        Dim tabla As New DataTable
                        sql &= "SELECT id_producto, descripcion, stock, precio_lista, r.nombre AS 'n_rubro', f.nombre AS 'n_fabrica', dado_de_baja"
                        sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                        sql &= " WHERE f.id_fabrica = " & Me.cbo_fabricaBUSCAR.SelectedValue
                        sql &= " AND dado_de_baja = 1"
                        If txt_idBUSCAR.Text <> "" Then
                            sql &= " AND id_producto = " & Me.txt_idBUSCAR.Text
                        End If
                        tabla = SoporteBD.leerBD_simple(sql)

                        Me.cargar_grilla(tabla)

                    Else
                        Dim sql As String = ""
                        Dim tabla As New DataTable
                        sql &= "SELECT id_producto, descripcion, stock, precio_lista, r.nombre AS 'n_rubro', f.nombre AS 'n_fabrica', dado_de_baja"
                        sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                        sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                        sql &= " AND f.id_fabrica = " & Me.cbo_fabricaBUSCAR.SelectedValue
                        sql &= " AND dado_de_baja = 1"
                        If txt_idBUSCAR.Text <> "" Then
                            sql &= " AND id_producto = " & Me.txt_idBUSCAR.Text
                        End If
                        tabla = SoporteBD.leerBD_simple(sql)

                        Me.cargar_grilla(tabla)

                    End If

                End If

            End If

        End If

        If cmb_habilitado.Text = "Ambos" Then
            If cbo_fabricaBUSCAR.Text = "(Seleccionar valor)" Then
                If cbo_rubroBUSCAR.Text = "(Seleccionar valor)" Then
                    Dim sql As String = ""
                    Dim tabla As New DataTable
                    sql &= "SELECT id_producto, descripcion, stock, precio_lista, r.nombre AS 'n_rubro', f.nombre AS 'n_fabrica', dado_de_baja"
                    sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                    sql &= " WHERE dado_de_baja in (0,1)"
                    If txt_idBUSCAR.Text <> "" Then
                        sql &= " AND id_producto = " & Me.txt_idBUSCAR.Text
                    End If
                    tabla = SoporteBD.leerBD_simple(sql)

                    Me.cargar_grilla(tabla)

                Else
                    Dim sql As String = ""
                    Dim tabla As New DataTable
                    sql &= "SELECT id_producto, descripcion, stock, precio_lista, r.nombre AS 'n_rubro', f.nombre AS 'n_fabrica', dado_de_baja"
                    sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                    sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                    sql &= " AND dado_de_baja in (0,1)"
                    If txt_idBUSCAR.Text <> "" Then
                        sql &= " AND id_producto = " & Me.txt_idBUSCAR.Text
                    End If
                    tabla = SoporteBD.leerBD_simple(sql)

                    Me.cargar_grilla(tabla)

                End If

            Else

                If cbo_rubroBUSCAR.Text = "(Seleccionar valor)" Then
                    Dim sql As String = ""
                    Dim tabla As New DataTable
                    sql &= "SELECT id_producto, descripcion, stock, precio_lista, r.nombre AS 'n_rubro', f.nombre AS 'n_fabrica', dado_de_baja"
                    sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                    sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                    sql &= " AND dado_de_baja in (0,1)"
                    If txt_idBUSCAR.Text <> "" Then
                        sql &= " AND id_producto = " & Me.txt_idBUSCAR.Text
                    End If
                    tabla = SoporteBD.leerBD_simple(sql)

                    Me.cargar_grilla(tabla)

                Else
                    Dim sql As String = ""
                    Dim tabla As New DataTable
                    sql &= "SELECT id_producto, descripcion, stock, precio_lista, r.nombre AS 'n_rubro', f.nombre AS 'n_fabrica', dado_de_baja"
                    sql &= " FROM productos p JOIN rubros r ON r.id_rubro = p.id_rubro JOIN fabricas f ON f.id_fabrica = p.id_fabrica "
                    sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
                    sql &= " AND f.id_fabrica = " & Me.cbo_fabricaBUSCAR.SelectedValue
                    sql &= " AND dado_de_baja in (0,1)"
                    If txt_idBUSCAR.Text <> "" Then
                        sql &= " AND id_producto = " & Me.txt_idBUSCAR.Text
                    End If
                    tabla = SoporteBD.leerBD_simple(sql)

                    Me.cargar_grilla(tabla)

                End If

            End If

        End If
    End Sub

    Private Sub cbo_rubroBUSCAR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_rubroBUSCAR.SelectedIndexChanged
        buscador_general()
    End Sub

End Class