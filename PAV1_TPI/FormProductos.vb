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
    Dim accion As tipo_grabacion = tipo_grabacion.ninguna
    Dim seleccion As String

    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_productos()
        Soporte.cargar_combo(cbo_rubro, Soporte.leerBD_simple("SELECT * FROM rubros"), "id_rubro", "nombre")
        Soporte.cargar_combo(cbo_rubroBUSCAR, Soporte.leerBD_simple("SELECT * FROM rubros"), "id_rubro", "nombre")
        Soporte.cargar_combo(cbo_fabrica, Soporte.leerBD_simple("SELECT * FROM fabricas"), "id_fabrica", "nombre")
        Soporte.cargar_combo(cbo_fabricaBUSCAR, Soporte.leerBD_simple("SELECT * FROM fabricas"), "id_fabrica", "nombre")
        Me.limpiar_campos()
    End Sub

    Private Sub limpiar_campos()
        txt_id.Text = ""
        txt_descrip.Text = ""
        txt_precio.Text = ""
        txt_stock.Text = ""
        cbo_fabrica.Text = "(Seleccione fábrica)"
        cbo_rubro.Text = "(Seleccione rubro)"
        cbo_fabricaBUSCAR.Text = "(Seleccione fábrica)"
        cbo_rubroBUSCAR.Text = "(Seleccione rubro)"
        lbl_msj.Text = ""
        Me.ocultar_lblERROR()
        lbl_msj.Visible = False
    End Sub

    Private Function validar_campos() As respuesta_validacion
        lbl_msj.Visible = False
        Me.ocultar_lblERROR()
        Dim rdo = respuesta_validacion._ok
        If cbo_fabrica.Text = "(Seleccione fábrica)" Then
            lbl_fabricaERROR.Visible = True
            cbo_fabrica.Focus()
            rdo = respuesta_validacion._error
            'MsgBox("La fabrica no fue ingresada", MsgBoxStyle.OkOnly, "Error")
        End If
        If cbo_rubro.Text = "(Seleccione rubro)" Then
            lbl_rubroERROR.Visible = True
            cbo_rubro.Focus()
            rdo = respuesta_validacion._error
            'MsgBox("El rubro no fue ingresado", MsgBoxStyle.OkOnly, "Error")
        End If
        If txt_precio.Text = "" Then
            lbl_precioERROR.Visible = True
            txt_precio.Focus()
            rdo = respuesta_validacion._error
            'MsgBox("El precio no fue ingresado", MsgBoxStyle.OkOnly, "Error")
        End If
        If txt_descrip.Text = "" Then
            lbl_descripcionERROR.Visible = True
            txt_id.Focus()
            rdo = respuesta_validacion._error
            'MsgBox("El id no fue ingresado", MsgBoxStyle.OkOnly, "Error")
        End If
        If txt_id.Text = "" Then
            lbl_idERROR.Visible = True
            txt_id.Focus()
            rdo = respuesta_validacion._error
            'MsgBox("El id no fue ingresado", MsgBoxStyle.OkOnly, "Error")
        End If
        Return rdo
    End Function

    Private Sub ocultar_lblERROR()
        lbl_idERROR.Visible = False
        lbl_precioERROR.Visible = False
        lbl_rubroERROR.Visible = False
        lbl_fabricaERROR.Visible = False
    End Sub

    Private Function validar_producto() As respuesta_validacion
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql &= "SELECT id_producto FROM productos WHERE id_producto = " & txt_id.Text
        tabla = Soporte.leerBD_simple(sql)

        If tabla.Rows.Count = 1 Then
            Return respuesta_validacion._error
        End If
        Return respuesta_validacion._ok
    End Function

    Private Sub insertar()
        Dim sql As String = ""
        sql &= "INSERT INTO productos(id_producto, descripcion, stock, precio_lista, id_rubro, id_fabrica)"
        sql &= " VALUES("
        sql &= Me.txt_id.Text
        sql &= ", '" & Me.txt_descrip.Text & "'"
        sql &= ", '" & Me.txt_stock.Text & "'"
        sql &= ", '" & Me.txt_precio.Text & "'"
        sql &= "," & Me.cbo_rubro.SelectedValue
        sql &= ", '" & Me.cbo_fabrica.SelectedValue & "')"

        Soporte.escribirBD_simple(sql)
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
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= " SELECT * FROM productos "
        sql &= " WHERE id_producto = " & Me.dgv_productos.CurrentRow.Cells(0).Value
        tabla = Soporte.leerBD_simple(sql)

        Me.txt_id.Text = tabla.Rows(0)("id_producto")
        Me.txt_descrip.Text = tabla.Rows(0)("descripcion")
        Me.txt_stock.Text = tabla.Rows(0)("stock")
        Me.txt_precio.Text = tabla.Rows(0)("precio_lista")
        Me.cbo_rubro.SelectedValue = tabla.Rows(0)("id_rubro")
        Me.cbo_fabrica.SelectedValue = tabla.Rows(0)("id_fabrica")

        Me.accion = tipo_grabacion.modificar
        Me.habilitar_campos()
        Me.btn_guardar.Enabled = True
        Me.btn_eliminar.Enabled = True
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

        Soporte.escribirBD_simple(sql)
        cargar_productos()
        MsgBox("El producto fue modificado exitosamente ", MessageBoxButtons.OK, "Exito")
        Me.btn_guardar.Enabled = False
        Me.btn_eliminar.Enabled = False
        Me.deshabilitar_campos()
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Me.limpiar_campos()
        Me.habilitar_campos()
        Me.accion = tipo_grabacion.insertar

        Me.txt_id.Focus()
        Me.cargar_productos()
        Me.btn_guardar.Enabled = True
        Me.btn_eliminar.Enabled = False
    End Sub

    Private Sub habilitar_campos()
        Me.txt_id.Enabled = True
        Me.txt_descrip.Enabled = True
        Me.txt_stock.Enabled = True
        Me.txt_precio.Enabled = True
        Me.cbo_rubro.Enabled = True
        Me.cbo_fabrica.Enabled = True

        Me.lbl_id.Enabled = True
        Me.lbl_descripcion.Enabled = True
        Me.lbl_stock.Enabled = True
        Me.lbl_precio.Enabled = True
        Me.lbl_stock.Enabled = True
        Me.lbl_rubro.Enabled = True
        Me.lbl_fabrica.Enabled = True
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String = ""
        sql &= "DELETE productos WHERE id_producto = " & Me.dgv_productos.CurrentRow.Cells(0).Value

        If MessageBox.Show("¿Está seguro que quiere eliminar el producto " & Me.dgv_productos.CurrentRow.Cells(0).Value & "?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Soporte.escribirBD_simple(sql)
            'MsgBox("Se eliminó el producto.", MessageBoxButtons.OK, "Eliminación de Producto")
            Dim id_prod As String = txt_id.Text
            Me.limpiar_campos()
            lbl_msj.Text = " Se eliminó el producto " & id_prod & "."
            lbl_msj.Visible = True
            cargar_productos()
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
                If validar_producto() = respuesta_validacion._ok Then
                    insertar()
                    'MsgBox("La carga del producto fue exitosa", MessageBoxButtons.OK, "Cargar Producto")
                    Dim id_prod As String = txt_id.Text
                    Me.limpiar_campos()
                    lbl_msj.Text = " El producto " & id_prod & " se cargó correctamente."
                    lbl_msj.Visible = True
                Else
                    MessageBox.Show("El producto ya existe, por favor, modificarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

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
        Dim sql As String = "SELECT p.id_producto, p.descripcion, p.stock, p.precio_lista, r.nombre AS n_rubro, f.nombre AS n_fabrica FROM productos p "
        sql &= "JOIN rubros r ON p.id_rubro = r.id_rubro "
        sql &= "JOIN fabricas f ON p.id_fabrica = f.id_fabrica"
        tabla = Soporte.leerBD_simple(sql)

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
        Next
        'Me.txt_id.Focus()
    End Sub

    Private Sub buscar(ByVal sql As String)
        Me.limpiar_campos()
        Dim tabla As New DataTable
        tabla = Soporte.leerBD_simple(sql)

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
        Next

        If tabla.Rows.Count = 0 Then
            'MsgBox("No se encontraron resultados", MsgBoxStyle.OkOnly, "Error")
            lbl_msj.Text = "No se encontraron resultados."
            lbl_msj.Visible = True
            txt_idBUSCAR.Text = ""
            txt_idBUSCAR.Focus()
            cargar_productos()
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscarID.Click
        If txt_idBUSCAR.Text = "" Then
            Me.cargar_productos()
            MsgBox("No existe valor de búsqueda", MsgBoxStyle.OkOnly, "Error")
            Return
        End If
        Dim sql As String = "SELECT p.id_producto, p.descripcion, p.stock, p.precio_lista, r.nombre AS n_rubro, f.nombre AS n_fabrica FROM productos p"
        sql &= " JOIN rubros r ON p.id_rubro = r.id_rubro"
        sql &= " JOIN fabricas f ON p.id_fabrica = f.id_fabrica"
        sql &= " WHERE p.id_producto = " & Me.txt_idBUSCAR.Text
        Me.buscar(sql)
    End Sub

    Private Sub btn_buscarRUBRO_Click(sender As Object, e As EventArgs) Handles btn_buscarRUBRO.Click
        If cbo_rubroBUSCAR.Text = "(Seleccione rubro)" Then
            Me.cargar_productos()
            MsgBox("No existe valor de búsqueda", MsgBoxStyle.OkOnly, "Error")
            Return
        End If
        Dim sql As String = "SELECT p.id_producto, p.descripcion, p.stock, p.precio_lista, r.nombre AS n_rubro, f.nombre AS n_fabrica FROM productos p"
        sql &= " JOIN rubros r ON p.id_rubro = r.id_rubro"
        sql &= " JOIN fabricas f ON p.id_fabrica = f.id_fabrica"
        sql &= " WHERE r.id_rubro = " & Me.cbo_rubroBUSCAR.SelectedValue
        Me.buscar(sql)
    End Sub

    Private Sub btn_buscarFABRICA_Click(sender As Object, e As EventArgs) Handles btn_buscarFABRICA.Click
        If cbo_fabricaBUSCAR.Text = "(Seleccione fábrica)" Then
            Me.cargar_productos()
            MsgBox("No existe valor de búsqueda", MsgBoxStyle.OkOnly, "Error")
            Return
        End If
        Dim sql As String = "SELECT p.id_producto, p.descripcion, p.stock, p.precio_lista, r.nombre AS n_rubro, f.nombre AS n_fabrica FROM productos p"
        sql &= " JOIN rubros r ON p.id_rubro = r.id_rubro"
        sql &= " JOIN fabricas f ON p.id_fabrica = f.id_fabrica"
        sql &= " WHERE f.id_fabrica = " & Me.cbo_fabricaBUSCAR.SelectedValue
        Me.buscar(sql)
    End Sub

    Private Sub FormFabrica_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
            DialogResult = DialogResult.OK
        Else
            e.Cancel = True
        End If
    End Sub


End Class