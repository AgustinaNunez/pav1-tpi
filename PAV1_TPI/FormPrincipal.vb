Public Class Frm_Principal
    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        Dim frmClientes = New FormClientes
        frmClientes.Visible = True
    End Sub

    Private Sub btn_fabricas_Click(sender As Object, e As EventArgs) Handles btn_fabricas.Click
        Dim frmFabrica = New FormFabrica
        frmFabrica.Visible = True
    End Sub


    Private Sub btn_productos_Click(sender As Object, e As EventArgs) Handles btn_productos.Click
        Dim frmProductos = New FormProductos
        frmProductos.Visible = True
    End Sub

    Private Sub btn_tarjetas_Click(sender As Object, e As EventArgs) Handles btn_tarjetas.Click
        Dim frmTarjetas = New FormTarjetas
        frmTarjetas.Visible = True
    End Sub

    Private Sub btn_usuarios_Click(sender As Object, e As EventArgs) Handles btn_usuarios.Click
        Dim frmUsuarios = New FormUsuarios
        frmUsuarios.Visible = True
    End Sub

End Class
