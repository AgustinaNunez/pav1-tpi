Imports System.ComponentModel

Public Class FormLogin


    Private Sub FormLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro de que quiere salir del programa?", "Iniciar Sesión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
            Me.Close()
            SoporteBD.cerrar_conexion_con_transaccion()
            SoporteBD.desconectar()
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub btn_iniciarSesion_Click(sender As Object, e As EventArgs) Handles btn_iniciarSesion.Click
    '    Dim sql As String = ""
    '    Dim tabla As New DataTable
    '    sql &= "SELECT * FROM usuarios "
    '    sql &= " WHERE id_usuario = '" & Me.txt_nombre.Text & "'"
    '    sql &= " AND contraseña = '" & Me.txt_clave.Text & "'"

    '    If txt_nombre.Text = "" And txt_clave.Text = "" Then
    '        'MessageBox.Show("Los campos usuario y contraseña no pueden estar vacíos.", "Inicio Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Me.mostrar_mensaje(" Los campos usuario y contraseña no pueden estar vacíos.")
    '        Me.txt_nombre.Focus()
    '    Else
    '        tabla = SoporteBD.leerBD_simple(sql)

    '        If tabla.Rows.Count <= 0 Then
    '            'MessageBox.Show("Usuario o contraseña incorrectos")
    '            Me.mostrar_mensaje(" Los datos ingresados son incorrectos o no existe el usuario ingresado.")
    '            Me.limpiar_campos()
    '            Me.txt_nombre.Focus()
    '        Else
    '            'MessageBox.Show("Bienvenida " & tabla.Rows(0)("nombre") & " " & tabla.Rows(0)("apellido"), "Principal", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Usuario.login(tabla)
    '            Me.limpiar_campos()
    '            Me.txt_nombre.Focus()
    '            'Me.Hide()
    '            Usuario.form.ShowDialog()
    '        End If
    '    End If
    'End Sub

    Private Sub btn_iniciarSesion_Click(sender As Object, e As EventArgs) Handles btn_iniciarSesion.Click
        'VERIFICAR EXISTENCIA DEL USUARIO
        If Me.validar_campos() Then
            Dim sql As String = "SELECT * FROM usuarios WHERE id_usuario = " & Me.txt_nombre.Text
            Dim tabla As New DataTable
            tabla = SoporteBD.leerBD_simple(sql)
            'SI NO EXISTE EL USUARIO...
            If tabla.Rows.Count = 0 Then
                Me.mostrar_mensaje("El usuario ingresado no existe.")
            Else
                'SI EXISTE EL USUARIO...
                Dim sql2 As String = "SELECT * FROM usuarios WHERE id_usuario = " & Me.txt_nombre.Text & " AND contraseña = " & Me.txt_clave.Text & ""
                Dim tabla2 As New DataTable
                tabla2 = SoporteBD.leerBD_simple(sql2)
                'SI LA CLAVE ESTA MAL
                If tabla2.Rows.Count = 0 Then
                    Me.mostrar_mensaje("La clave ingresada es incorrecta.")
                Else
                    'SI LA CLAVE ESTA BIEN
                    Usuario.login(tabla2)
                    Me.limpiar_campos()
                    Me.txt_nombre.Focus()
                    Usuario.form.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Function validar_campos() As Boolean
        Dim mensaje As String = " No se ingresó"
        Dim flag As Boolean = True
        If Me.txt_nombre.Text = "" And Me.txt_clave.Text = "" Then
            mensaje &= " el nombre de usuario ni la clave."
            flag = False
        Else
            If Me.txt_nombre.Text = "" Then
                mensaje &= " el nombre de usuario."
                flag = False
            End If
            If Me.txt_clave.Text = "" Then
                mensaje &= " la clave de usuario."
                flag = False
            End If
        End If
        If flag = False Then
            Me.mostrar_mensaje(mensaje)
        End If
        Return flag
    End Function

    Private Sub limpiar_campos()
        Me.txt_nombre.Text = ""
        Me.txt_clave.Text = ""
    End Sub

    Private Sub mostrar_mensaje(ByVal mensaje As String)
        lbl_msj.Text = mensaje
        lbl_msj.Visible = True
    End Sub
End Class