Public Class Frm_Principal
    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        Dim frmClientes = New FormClientes
        frmClientes.Visible = True
    End Sub

    Private Sub btn_fabricas_Click(sender As Object, e As EventArgs) Handles btn_fabricas.Click
        Dim frmFabrica = New FormFabrica
        frmFabrica.Visible = True
    End Sub


    Private Sub btn_productos_Click(sender As Object, e As EventArgs)
        Dim frmProductos = New FormProductos
        frmProductos.Visible = True
    End Sub

    Private Sub btn_tarjetas_Click(sender As Object, e As EventArgs) Handles btn_tarjetas.Click
        Dim frmTarjetas = New FormCupon
        frmTarjetas.Visible = True
    End Sub

    Private Sub btn_usuarios_Click(sender As Object, e As EventArgs) Handles btn_usuarios.Click
        Dim frmUsuarios = New FormUsuarios
        frmUsuarios.Visible = True
    End Sub


    Private Sub btn_compras_Click(sender As Object, e As EventArgs) Handles btn_compras.Click
        Dim frmCompras = New FormCompras
        frmCompras.Visible = True
    End Sub

    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
