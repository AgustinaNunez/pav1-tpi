Imports System.ComponentModel

Public Class FormLogin


    Private Sub FormLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro de que quiere salir del programa?", "Iniciar Sesión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
            Me.Close()
            Me.Dispose()
        Else
            e.Cancel = True

        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_iniciarSesion_Click(sender As Object, e As EventArgs) Handles btn_iniciarSesion.Click
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql &= "SELECT * FROM usuarios "
        sql &= " WHERE id_usuario = '" & Me.txt_nombre.Text & "'"
        sql &= " AND contraseña = '" & Me.txt_clave.Text & "'"

        If txt_nombre.Text = "" And txt_clave.Text = "" Then
            'MessageBox.Show("Los campos usuario y contraseña no pueden estar vacíos.", "Inicio Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.mostrar_mensaje(" Los campos usuario y contraseña no pueden estar vacíos.")
            Me.txt_nombre.Focus()
        Else
            tabla = SoporteBD.leerBD_simple(sql)

            If tabla.Rows.Count <= 0 Then
                'MessageBox.Show("Usuario o contraseña incorrectos")
                Me.mostrar_mensaje(" Los datos ingresados son incorrectos o no existe el usuario ingresado.")
                Me.txt_nombre.Text = ""
                Me.txt_clave.Text = ""
                Me.txt_nombre.Focus()
            Else
                'MessageBox.Show("Bienvenida " & tabla.Rows(0)("nombre") & " " & tabla.Rows(0)("apellido"), "Principal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Usuario.login(tabla)
                Me.Hide()
                Frm_Principal.Show()
            End If
        End If
    End Sub

    Private Sub mostrar_mensaje(ByVal mensaje As String)
        lbl_msj.Text = mensaje
        lbl_msj.Visible = True
    End Sub
End Class