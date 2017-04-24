Public Class FormProductos
    Dim cadena_conexion As String = "Data Source=AGUSTINA-PC;Initial Catalog=DB_CLOTTA;Integrated Security=True"
    Enum tipo_grabacion
        insertar
        modificar
    End Enum
    Enum respuesta_validacion
        _ok
        _error
    End Enum
    Dim accion As tipo_grabacion = tipo_grabacion.insertar
    Dim seleccion As String

    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_productos()
        Soporte.cargar_combo(cbo_rubro, Soporte.consultarBD("SELECT * FROM rubros"), "id_rubro", "nombre")
        Soporte.cargar_combo(cbo_fabrica, Soporte.consultarBD("SELECT * FROM fabricas"), "id_fabrica", "nombre")
    End Sub

    Private Sub limpiar_campos()
        For Each obj As Windows.Forms.Control In Me.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
            End If

            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Text = ""
            End If

            If obj.GetType().Name = "ComboBox" Then
                Dim local As ComboBox = obj
                local.SelectedValue = -1
            End If
        Next
    End Sub

    Private Function validar_datos() As respuesta_validacion
        For Each obj As Windows.Forms.Control In Me.Controls

            If obj.GetType().Name = "TextBox" Or obj.GetType().Name = "MaskedTextBox" Then
                If obj.Text = "" Then
                    MsgBox("El campo " + obj.Name + "está vacío.", MsgBoxStyle.OkOnly, "Error")
                    obj.Focus()
                    Return respuesta_validacion._error
                End If
            End If

            If obj.GetType().Name = "ComboBox" Then
                Dim local As ComboBox = obj
                If local.SelectedValue = -1 Then
                    MsgBox("El campo " + obj.Name + "está vacío.", MsgBoxStyle.OkOnly, "Error")
                    obj.Focus()
                    Return respuesta_validacion._error
                End If
            End If

        Next
        Return respuesta_validacion._ok
    End Function


    Private Function validar_producto() As respuesta_validacion
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql &= "SELECT id_producto FROM productos WHERE id_producto = " & txt_id.Text
        tabla = Soporte.consultarBD(sql)

        If tabla.Rows.Count = 1 Then
            Return respuesta_validacion._error
        End If
        Return respuesta_validacion._ok
    End Function

    Private Sub insertar()
        Dim sql As String = ""
        sql &= "INSERT INTO productos("
        sql &= "id_producto,"
        sql &= "descripcion,"
        sql &= "stock,"
        sql &= "precio_lista,"
        sql &= "id_rubro,"
        sql &= "id_fabrica)"
        sql &= " VALUES("
        sql &= "  " & Me.txt_id.Text
        sql &= "," & Me.txt_descrip.Text
        sql &= ", '" & Me.txt_stock.Text & "'"
        sql &= ", '" & Me.txt_precio.Text & "'"
        sql &= "," & Me.cbo_rubro.SelectedValue
        sql &= ", '" & Me.cbo_fabrica.SelectedValue & "')"

        Soporte.actualizarBD(sql)
        Me.cargar_productos()
        Me.txt_id.Enabled = False
        Me.txt_descrip.Enabled = False
        Me.txt_stock.Enabled = False
        Me.txt_precio.Enabled = False
        Me.cbo_rubro.Enabled = False
        Me.cbo_fabrica.Enabled = False

        MsgBox("El producto se cargó correctamente.", MessageBoxButtons.OK, "Carga de Productos")
    End Sub

    Private Sub dgv_productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_productos.CellContentClick
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= " SELECT * FROM productos "
        sql &= " WHERE id_producto = " & Me.dgv_productos.CurrentRow.Cells(0).Value

        tabla = Soporte.consultarBD(sql)

        Me.txt_id.Text = tabla.Rows(0)("id_prod")
        Me.txt_descrip.Text = tabla.Rows(0)("descrip")
        Me.txt_stock.Text = tabla.Rows(0)("stock")
        Me.txt_precio.Text = tabla.Rows(0)("precio")
        Me.cbo_rubro.SelectedValue = tabla.Rows(0)("rubro")
        Me.cbo_fabrica.SelectedValue = tabla.Rows(0)("fabrica")

        Me.accion = tipo_grabacion.modificar
        Me.txt_id.Enabled = False
        Me.txt_descrip.Enabled = False
        Me.txt_stock.Enabled = True
        Me.txt_precio.Enabled = True
        Me.cbo_rubro.Enabled = True
        Me.cbo_fabrica.Enabled = True
    End Sub

    Private Sub modificar()
        Dim sql As String = ""
        sql &= "UPDATE productos SET "
        sql &= ", descripcion = '" & Me.txt_descrip.Text & "'"
        sql &= ", stock = '" & Me.txt_stock.Text & "'"
        sql &= ", precio_lista = " & Me.txt_precio.Text
        sql &= ", id_rubro = " & Me.cbo_rubro.SelectedValue
        sql &= ", id_fabrica = " & Me.cbo_fabrica.SelectedValue
        sql &= " WHERE id_producto = " & Me.txt_id.Text

        Soporte.actualizarBD(sql)
        MsgBox("Producto modificado.", MessageBoxButtons.OK, "Éxito")
        cargar_productos()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql &= "SELECT * FROM productos"
        sql &= " WHERE id_producto = " & Me.txt_id.Text

        tabla = Soporte.consultarBD(sql)

        Dim c As Integer
        Me.dgv_productos.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_productos.Rows.Add()
            Me.dgv_productos.Rows(c).Cells(0).Value = tabla.Rows(c)("id_producto")
            Me.dgv_productos.Rows(c).Cells(1).Value = tabla.Rows(c)("descrip")
            Me.dgv_productos.Rows(c).Cells(2).Value = tabla.Rows(c)("stock")
            Me.dgv_productos.Rows(c).Cells(3).Value = tabla.Rows(c)("precio")
            Me.dgv_productos.Rows(c).Cells(4).Value = tabla.Rows(c)("id_rubro")
            Me.dgv_productos.Rows(c).Cells(5).Value = tabla.Rows(c)("id_fabrica")
        Next

        If tabla.Rows.Count = 0 Then
            MsgBox("No se encontró ningún resultado.", MsgBoxStyle.OkOnly, "Error")
            cargar_productos()
        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Me.limpiar_campos()
        Me.accion = tipo_grabacion.insertar
        Me.txt_id.Enabled = True
        Me.txt_descrip.Enabled = True
        Me.txt_stock.Enabled = True
        Me.txt_precio.Enabled = True
        Me.cbo_rubro.SelectedIndex = -1
        Me.cbo_fabrica.SelectedIndex = -1
        Me.txt_id.Focus()
        Me.cargar_productos()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If validar_datos() = respuesta_validacion._ok Then
            If accion = tipo_grabacion.insertar Then
                If validar_producto() = respuesta_validacion._ok Then
                    insertar()
                End If
            Else
                modificar()
            End If
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String = ""
        sql &= "DELETE productos WHERE id_producto = " & Me.dgv_productos.CurrentRow.Cells(0).Value

        If MessageBox.Show("¿Está seguro que quiere eliminar el producto?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Soporte.actualizarBD(sql)
            MsgBox("Se eliminó el producto.", MessageBoxButtons.OK, "Eliminación de Producto")
            cargar_productos()
        End If

        If Me.dgv_productos.CurrentCell.Selected = False Then
            MessageBox.Show("Falta seleccionar dato.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cargar_productos()
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql &= "SELECT * FROM productos"
        tabla = Soporte.consultarBD(sql)

        Dim c As Integer
        Me.dgv_productos.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_productos.Rows.Add()
            Me.dgv_productos.Rows(c).Cells(0).Value = tabla.Rows(c)("id_producto")
            Me.dgv_productos.Rows(c).Cells(1).Value = tabla.Rows(c)("descrip")
            Me.dgv_productos.Rows(c).Cells(2).Value = tabla.Rows(c)("stock")
            Me.dgv_productos.Rows(c).Cells(3).Value = tabla.Rows(c)("precio")
            Me.dgv_productos.Rows(c).Cells(4).Value = tabla.Rows(c)("id_rubro")
            Me.dgv_productos.Rows(c).Cells(5).Value = tabla.Rows(c)("id_fabrica")
        Next
        Me.txt_id.Focus()
    End Sub
End Class