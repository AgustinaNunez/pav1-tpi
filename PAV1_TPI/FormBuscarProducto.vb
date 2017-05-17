Public Class FormBuscarProducto
    Private producto_seleccionado As String
    Private precio As Double
    Private flag As Boolean = False

    Private Sub FormBuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_productos()
        Soporte.cargar_combo(cbo_rubroBUSCAR, Soporte.leerBD("SELECT * FROM rubros"), "id_rubro", "nombre")
        Soporte.cargar_combo(cbo_fabricaBUSCAR, Soporte.leerBD("SELECT * FROM fabricas"), "id_fabrica", "nombre")
        Me.limpiar_campos()
    End Sub

    Private Sub limpiar_campos()
        Me.txt_idBUSCAR.Text = ""
        cbo_fabricaBUSCAR.Text = "(Seleccione fábrica)"
        cbo_rubroBUSCAR.Text = "(Seleccione rubro)"
        Me.cargar_producto_seleccionado()
    End Sub

    Private Sub cargar_producto_seleccionado()
        If Me.dgv_productos.Rows.Count > 0 Then
            lbl_producto.Text = " Artículo " & Me.dgv_productos.CurrentRow.Cells(0).Value & " " & Me.dgv_productos.CurrentRow.Cells(1).Value
            producto_seleccionado = lbl_producto.Text
            precio = Me.dgv_productos.CurrentRow.Cells(3).Value
        Else
            lbl_producto.Text = " No se ha seleccionado ningún producto."
        End If
    End Sub

    Private Sub cargar_productos()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT p.id_producto, p.descripcion, p.stock, p.precio_lista, r.nombre AS n_rubro, f.nombre AS n_fabrica FROM productos p "
        sql &= "JOIN rubros r ON p.id_rubro = r.id_rubro "
        sql &= "JOIN fabricas f ON p.id_fabrica = f.id_fabrica"
        tabla = Soporte.leerBD(sql)

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

    Public Property _ProductoSeleccionado() As String
        Get
            Return producto_seleccionado
        End Get
        Set(value As String)
            producto_seleccionado = value
        End Set
    End Property
    Public Property _Precio() As Double
        Get
            Return precio
        End Get
        Set(value As Double)
            precio = value
        End Set
    End Property
    Public Property _EstaCargado() As Boolean
        Get
            Return flag
        End Get
        Set(value As Boolean)
            flag = value
        End Set
    End Property

    Private Sub dgv_productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_productos.CellContentClick, dgv_productos.CellDoubleClick
        Me.cargar_producto_seleccionado()
    End Sub

    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        Me.cargar_producto_seleccionado()
        flag = True
        Me.Close()
    End Sub
End Class