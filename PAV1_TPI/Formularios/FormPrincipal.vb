Imports System.ComponentModel

Public Class Frm_Principal
    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        Dim frmClientes = New FormClientes
        frmClientes.ShowDialog()
    End Sub

    Private Sub btn_fabricas_Click(sender As Object, e As EventArgs) Handles btn_fabricas.Click
        Dim frmFabrica = New FormFabrica
        frmFabrica.ShowDialog()
    End Sub

    Private Sub btn_cupones_Click(sender As Object, e As EventArgs)
        Dim frmCupones = New FormCupones_Buscar
        frmCupones.ShowDialog()
    End Sub

    Private Sub btn_usuarios_Click(sender As Object, e As EventArgs) Handles btn_usuarios.Click
        Dim frmUsuarios = New FormUsuarios
        frmUsuarios.ShowDialog()
    End Sub

    Private Sub btn_compras_Click(sender As Object, e As EventArgs) Handles btn_compras.Click
        Dim frmCompras = New FormCompras
        frmCompras.ShowDialog()
    End Sub

    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoporteGUI.tipo_form_ACTUAL = SoporteGUI.tipo_form.abm
        Me.lbl_usuarioLogueado.Text = Usuario.nombre & " " & Usuario.apellido
    End Sub

    Private Sub btn_ventas_Click(sender As Object, e As EventArgs) Handles btn_ventas.Click
        Dim frmVentas = New FormVentas
        frmVentas.ShowDialog()
    End Sub

    Private Sub btn_productos_Click(sender As Object, e As EventArgs) Handles btn_productos.Click
        Dim frmProductos = New FormProductos
        frmProductos.Visible = True
    End Sub

    Private Sub Frm_Principal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("¿Desea cerrar la sesión antes de salir?", "Principal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            e.Cancel = False
            Usuario.logout()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btn_productosINFORME_Click(sender As Object, e As EventArgs) Handles btn_productosINFORME.Click
        Dim frm As New ReporteProductos
        frm.ShowDialog()
    End Sub

    Private Sub btn_cuponesINFORME_Click(sender As Object, e As EventArgs) Handles btn_cuponesINFORME.Click
        Dim frm As New ReporteCupones
        frm.ShowDialog()
    End Sub

    Private Sub btn_informe_ventas_Click(sender As Object, e As EventArgs) Handles btn_informe_ventas.Click
        Dim frm As New FormReporteVentas
        frm.ShowDialog()
    End Sub

    Private Sub btn_estadisticas_fabrica_Click(sender As Object, e As EventArgs) Handles btn_estadisticas_fabrica.Click
        Dim frm As New EstadisticaFabrica
        frm.ShowDialog()
    End Sub

    Private Sub btn_estadisticas_usuario_Click(sender As Object, e As EventArgs) Handles btn_estadisticas_usuario.Click
        Dim frm As New EstadisticaUsuario
        frm.ShowDialog()
    End Sub
End Class
