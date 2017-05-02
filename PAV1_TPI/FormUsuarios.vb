Public Class FormUsuarios
    Dim accion As tipo_grabacion = tipo_grabacion.insertar
    Dim seleccion As String

    'ENUMERACION DE TIPOS DE GRABACION
    Enum tipo_grabacion
        insertar
        modificar
    End Enum

    'ENUMERACION DE TIPOS DE RESPUESTAS DE VALIDACION
    Enum respuesta_validacion
        _ok
        _error
    End Enum

    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla_usuarios()

    End Sub

    'SUBRUTINA PARA CARGAR GRILLAS
    Private Sub cargar_grilla_usuarios()
        Dim tabla As New DataTable
        Dim sql_cargar_grilla As String = ""

        sql_cargar_grilla &= " SELECT * FROM  usuarios "
        tabla = Soporte.consultarBD(sql_cargar_grilla)

        Dim c As Integer
        Me.grilla_usuarios.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1
            Me.grilla_usuarios.Rows.Add()
            Me.grilla_usuarios.Rows(c).Cells(0).Value = tabla.Rows(c)("id_usuario")
            Me.grilla_usuarios.Rows(c).Cells(1).Value = tabla.Rows(c)("nombre")
            Me.grilla_usuarios.Rows(c).Cells(2).Value = tabla.Rows(c)("apellido")
            Me.grilla_usuarios.Rows(c).Cells(3).Value = tabla.Rows(c)("fecha_alta")
        Next
        Me.txt_id_usuario.Focus()
    End Sub

    'SUBRUTINA PARA BLANQUEAR LOS CAMPOS
    Private Sub borrar_datos()
        For Each obj As Windows.Forms.Control In Me.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
            End If

            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Text = ""
            End If
        Next
    End Sub



    'FUNCION PARA VALIDAR DATOS A GUARDAR
    Private Function validar_datos() As respuesta_validacion
        For Each obj As Windows.Forms.Control In Me.Controls
            If obj.GetType().Name = "TextBox" Or obj.GetType().Name = "MaskedTextBox" Then
                If obj.ProductName = Me.txt_nombre.Text Or obj.ProductName = Me.txt_apellido.Text Then
                    If obj.Text = "" Then
                        MsgBox("El campo " + obj.Name + "esta vacio.", MsgBoxStyle.OkOnly, "Error")
                        obj.Focus()
                        Return respuesta_validacion._error
                    End If
                    If Me.txt_contraseña1.Text <> Me.txt_contraseña2.Text Then
                        MsgBox("Error al repetir la contraseña, vuelva a ingresarla", MessageBoxButtons.OK, "Carga Usuario")
                        Me.txt_contraseña1.Text = ""
                        Me.txt_contraseña2.Text = ""
                        Me.txt_contraseña1.Focus()
                    End If
                End If
            End If


        Next
        Return respuesta_validacion._ok
    End Function

    'FUNCION PARA VALIDAR UN usuario (PARA QUE NO EXISTA)
    Private Function validar_persona() As respuesta_validacion
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql &= "SELECT id_usuario FROM usuarios WHERE id_usuario = '" & Me.txt_id_usuario.Text & "'"

        tabla = Soporte.consultarBD(sql)

        If tabla.Rows.Count = 1 Then
            Return respuesta_validacion._error
        End If

        Return respuesta_validacion._ok
    End Function
    'SUBRUTINA PARA INSERTAR DATOS
    Private Sub insertar()
        Dim sql As String = ""
        sql &= "INSERT INTO usuarios( "
        sql &= "id_usuario, "
        sql &= "nombre, "
        sql &= "apellido, "
        sql &= "contraseña, "
        sql &= "fecha_alta) "
        sql &= " VALUES ( "
        sql &= " '" & Me.txt_id_usuario.Text & "'"
        sql &= ", '" & Me.txt_nombre.Text & "'"
        sql &= ", '" & Me.txt_apellido.Text & "'"
        sql &= ", '" & Me.txt_contraseña1.Text & "'"
        sql &= ", '" & Me.txt_fecha_alta.Text & " ')"
        MsgBox("La carga del usuario fue exitosa", MessageBoxButtons.OK, "Carga Usuario")
        Soporte.actualizarBD(sql)
        Me.cargar_grilla_usuarios()
        Me.cmd_grabar.Enabled = False
        Me.txt_id_usuario.Enabled = False
        Me.txt_apellido.Enabled = False
        Me.txt_nombre.Enabled = False
        Me.txt_contraseña1.Enabled = False
        Me.txt_contraseña2.Enabled = False
        Me.txt_fecha_alta.Enabled = False
    End Sub




    'SUBRUTINA PARA MODIFICAR usuarios
    Private Sub modificar()
        Dim sql As String = ""
        sql &= " UPDATE usuarios SET "
        sql &= "id_usuario = '" & Me.txt_id_usuario.Text & "'"
        sql &= ", apellido = '" & Me.txt_apellido.Text & "'"
        sql &= ", nombre = '" & Me.txt_nombre.Text & "'"
        sql &= ", contraseña = '" & Me.txt_contraseña1.Text & "'"
        sql &= ", fecha_alta = '" & Me.txt_fecha_alta.Text & "'"
        sql &= " WHERE id_usuario= '" & Me.txt_id_usuario.Text & "'"

        Soporte.actualizarBD(sql)
        MsgBox("El usuario fue modificado", MessageBoxButtons.OK, "Exito")
        cargar_grilla_usuarios()
    End Sub


    'SUBRUTINA PARA PREGUNTAR CUANDO SE CIERRA EL FORMULARIO
    Private Sub FormUsuarios_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del formulario?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub


    'BOTON PARA BLANQUEAR NUEVO usuario
    Private Sub cmd_nuevo_Click_1(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        If MessageBox.Show("¿Está seguro que desea eliminar los datos ingresados?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.borrar_datos()
            Me.accion = tipo_grabacion.insertar
            Me.cmd_grabar.Enabled = True
            Me.txt_id_usuario.Enabled = True
            Me.txt_apellido.Enabled = True
            Me.txt_nombre.Enabled = True
            Me.txt_contraseña1.Enabled = True
            Me.txt_contraseña2.Enabled = True
            Me.txt_fecha_alta.Enabled = True
            Me.txt_fecha_alta.Text = DateTime.Now.ToString("dd/MM/yyyy")
            Me.txt_id_usuario.Focus()
            Me.cargar_grilla_usuarios()
        End If
    End Sub
    'SUBRUTINA PARA BORRAR usuarios
    Private Sub cmd_eliminar_Click_1(sender As Object, e As EventArgs) Handles cmd_eliminar.Click
        Dim sql As String = ""
        sql &= "DELETE usuarios WHERE id_usuario = '" & Me.grilla_usuarios.CurrentRow.Cells(0).Value & "'"

        If MessageBox.Show("¿Está seguro que quiere eliminar el registro?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Soporte.actualizarBD(sql)
            MsgBox("Se borraron los datos exitosamente", MessageBoxButtons.OK, "Eliminación Usuario")
            cargar_grilla_usuarios()
        End If
        If Me.grilla_usuarios.CurrentCell.Selected = False Then
            MessageBox.Show("Falta seleccionar dato en grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.cmd_grabar.Enabled = False
        Me.txt_id_usuario.Enabled = False
        Me.txt_apellido.Enabled = False
        Me.txt_nombre.Enabled = False
        Me.txt_contraseña1.Enabled = False
        Me.txt_contraseña2.Enabled = False
        Me.txt_fecha_alta.Enabled = False
        Me.cmd_eliminar.Enabled = False
    End Sub
    'BOTON GRABAR
    Private Sub cmd_grabar_Click_1(sender As Object, e As EventArgs) Handles cmd_grabar.Click
        If validar_datos() = respuesta_validacion._ok Then

            If accion = tipo_grabacion.insertar Then

                If validar_persona() = respuesta_validacion._ok Then

                    insertar()
                Else
                    MsgBox("El nombre de usuario ya existe, por favor, modificarlo", MsgBoxStyle.OkOnly, "Error")
                    Me.borrar_datos()

                End If
            Else
                modificar()
            End If
        End If
    End Sub
    'BUSCAR UN USUARIO POR SU ID_USUARIO
    Private Sub cmd_buscar_Click_1(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql &= "SELECT * FROM usuarios "
        sql &= " WHERE id_usuario = '" & Me.txt_buscar_usuario.Text & "'"

        tabla = Soporte.consultarBD(sql)

        Dim c As Integer
        Me.grilla_usuarios.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1

            Me.grilla_usuarios.Rows.Add()
            Me.grilla_usuarios.Rows(c).Cells(0).Value = tabla.Rows(c)("id_usuario")
            Me.grilla_usuarios.Rows(c).Cells(1).Value = tabla.Rows(c)("nombre")
            Me.grilla_usuarios.Rows(c).Cells(2).Value = tabla.Rows(c)("apellido")
            Me.grilla_usuarios.Rows(c).Cells(3).Value = tabla.Rows(c)("fecha_alta")


        Next

        If tabla.Rows.Count = 0 Then
            MsgBox("No se encontró ningun resultado", MsgBoxStyle.OkOnly, "Error")
            cargar_grilla_usuarios()
        End If
    End Sub
    'INTERACCION CON LA GRILLA
    Private Sub grilla_usuarios_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla_usuarios.CellContentDoubleClick
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= " SELECT * FROM usuarios "
        sql &= " WHERE id_usuario = '" & Me.grilla_usuarios.CurrentRow.Cells(0).Value & "'"

        tabla = Soporte.consultarBD(sql)

        Me.txt_id_usuario.Text = tabla.Rows(0)("id_usuario")
        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.txt_apellido.Text = tabla.Rows(0)("apellido")
        Me.txt_contraseña1.Text = tabla.Rows(0)("contraseña")
        Me.txt_fecha_alta.Text = tabla.Rows(0)("fecha_alta")
        Me.accion = tipo_grabacion.modificar
        Me.txt_id_usuario.Enabled = True
        Me.txt_apellido.Enabled = True
        Me.txt_nombre.Enabled = True
        Me.txt_fecha_alta.Enabled = False
        Me.txt_contraseña1.Enabled = True
        Me.txt_contraseña2.Enabled = True
        Me.cmd_grabar.Enabled = True
        Me.cmd_eliminar.Enabled = True
    End Sub
End Class