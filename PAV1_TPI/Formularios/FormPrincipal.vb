Imports System.ComponentModel

Public Class Frm_Principal
    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        SoporteGUI.tipo_form_ACTUAL = SoporteGUI.tipo_form.abm
        Dim frmClientes = New FormClientes
        frmClientes.ShowDialog()
    End Sub

    Private Sub btn_fabricas_Click(sender As Object, e As EventArgs) Handles btn_fabricas.Click
        SoporteGUI.tipo_form_ACTUAL = SoporteGUI.tipo_form.abm
        Dim frmFabrica = New FormFabrica
        frmFabrica.ShowDialog()
    End Sub

    Private Sub btn_cupones_Click(sender As Object, e As EventArgs) Handles btn_tarjetas.Click
        SoporteGUI.tipo_form_ACTUAL = SoporteGUI.tipo_form.abm
        Dim frmCupones = New FormCupones_Buscar
        frmCupones.ShowDialog()
    End Sub

    Private Sub btn_usuarios_Click(sender As Object, e As EventArgs) Handles btn_usuarios.Click
        SoporteGUI.tipo_form_ACTUAL = SoporteGUI.tipo_form.abm
        Dim frmUsuarios = New FormUsuarios
        frmUsuarios.ShowDialog()
    End Sub

    Private Sub btn_compras_Click(sender As Object, e As EventArgs) Handles btn_compras.Click
        SoporteGUI.tipo_form_ACTUAL = SoporteGUI.tipo_form.transaccion
        Dim frmCompras = New FormCompras
        frmCompras.ShowDialog()
    End Sub

    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lbl_usuarioLogueado.Text = Usuario.nombre & " " & Usuario.apellido
    End Sub

    Private Sub btn_ventas_Click(sender As Object, e As EventArgs) Handles btn_ventas.Click
        SoporteGUI.tipo_form_ACTUAL = SoporteGUI.tipo_form.transaccion
        Dim frmVentas = New FormVentas
        frmVentas.ShowDialog()
    End Sub

    Private Sub btn_productos_Click(sender As Object, e As EventArgs) Handles btn_productos.Click
        SoporteGUI.tipo_form_ACTUAL = SoporteGUI.tipo_form.abm
        Dim frmProductos = New FormProductos
        frmProductos.Visible = True
    End Sub

    Private Sub Frm_Principal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("¿Desea cerrar la sesión antes de salir?", "CLOTTA _ Principal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            e.Cancel = False
            Usuario.logout()
            'Dim frmlogin As New FormLogin
            'frmlogin.Show()
        Else
            e.Cancel = True
        End If
    End Sub
End Class
