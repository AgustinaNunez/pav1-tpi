Public Class FormLogin

    Private Sub bnt_ingresar_Click(sender As Object, e As EventArgs) Handles bnt_ingresar.Click
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql &= "SELECT * FROM usuarios "
        sql &= " WHERE id_usuario = '" & Me.txt_nombre.Text & "'"
        sql &= " AND contraseña = '" & Me.txt_contraseña2.Text & "'"

        If txt_nombre.Text = "" And txt_contraseña2.Text = "" Then
            MsgBox("Los campos usuario y contraseña no pueden estar vacios")
            Me.txt_nombre.Focus()

        Else
            tabla = Soporte.leerBD_simple(sql)

            If tabla.Rows.Count <= 0 Then
                MessageBox.Show("Usuario o contraseña incorrectos")
            Else
                MessageBox.Show("BIENVENIDO")
                Me.Hide()
                Frm_Principal.Show()


            End If


        End If
    End Sub

    Private Sub FormLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
            DialogResult = DialogResult.OK
        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        txt_nombre.Text = ""
        txt_contraseña2.Text = ""
    End Sub
End Class