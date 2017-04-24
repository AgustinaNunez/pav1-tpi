Public Class FormFabrica

    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=(localdb)\Servidor;Integrated Security=SSPI;Initial Catalog=BD_CLOTTA"
    Dim accion As tipo_grabacion = tipo_grabacion.insertar
    Dim seleccion As String


    Enum tipo_grabacion
        insertar
        modificar
    End Enum

    Enum respuesta_validacion
        _ok
        _error
    End Enum



    Private Sub FormFabrica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla_fabrica()

    End Sub





    Private Sub cargar_grilla_fabrica()
        Dim tabla As New DataTable
        Dim sql_cargar_grilla As String = ""

        sql_cargar_grilla &= " SELECT nombre"
        sql_cargar_grilla &= ", telefono"
        sql_cargar_grilla &= ", id_fabrica"
        sql_cargar_grilla &= " FROM fabricas "

        tabla = ejecuto_sql(sql_cargar_grilla)

        Dim c As Integer
        Me.Grilla_Fabrica.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1

            Me.Grilla_Fabrica.Rows.Add()
            Me.Grilla_Fabrica.Rows(c).Cells(0).Value = tabla.Rows(c)("nombre")
            Me.Grilla_Fabrica.Rows(c).Cells(1).Value = tabla.Rows(c)("telefono")
            Me.Grilla_Fabrica.Rows(c).Cells(2).Value = tabla.Rows(c)("id_fabrica")
        Next

        Me.txt_nombre_fabrica.Focus()
    End Sub

    Private Function leo_tabla(ByRef nombre_tabla As String) As Data.DataTable
        Return Me.ejecuto_sql("SELECT * FROM " + nombre_tabla)
    End Function


    Private Function ejecuto_sql(ByVal sql As String)

        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()
        Return tabla
    End Function


    Private Sub grabar_borrar(ByRef sql As String)
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        conexion.Close()

    End Sub

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


    Private Sub btn_nueva_fabrica_Click(sender As Object, e As EventArgs) Handles btn_nueva_fabrica.Click
        Me.borrar_datos()
        Me.accion = tipo_grabacion.insertar
        Me.btn_guardar_fabrica.Enabled = True
        Me.txt_nombre_fabrica.Enabled = True
        Me.txt_telefono_fabrica.Enabled = True

    End Sub

    Private Function validar_datos() As respuesta_validacion
        For Each obj As Windows.Forms.Control In Me.Controls
            If obj.GetType().Name = "TextBox" Or obj.GetType().Name = "MaskedTextBox" Then

                If obj.Text = "" Then
                    MsgBox("El campo " + obj.Name + " está vacio.", MsgBoxStyle.OkOnly, "Error")
                    obj.Focus()
                    Return respuesta_validacion._error
                End If


            End If

        Next
        Return respuesta_validacion._ok

    End Function


    Private Function validar_fabrica() As respuesta_validacion
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql &= " SELECT * FROM fabricas WHERE nombre = '" & Me.txt_nombre_fabrica.Text & "'"

        tabla = ejecuto_sql(sql)

        If tabla.Rows.Count = 1 Then
            Return respuesta_validacion._error

        End If

        Return respuesta_validacion._ok

    End Function



    Private Sub btn_guardar_fabrica_Click(sender As Object, e As EventArgs) Handles btn_guardar_fabrica.Click
        If validar_datos() = respuesta_validacion._ok Then

            If accion = tipo_grabacion.insertar Then

                If validar_fabrica() = respuesta_validacion._ok Then
                    insertar()
                Else
                    MsgBox("El nombre de la fabrica ya existe, por favor, modificarlo", MsgBoxStyle.OkOnly, "Error")
                End If


            Else
                modificar()

            End If
        End If

    End Sub

    Private Sub insertar()
        Dim sql As String = ""
        Randomize()
        Dim aleatorio As Integer
        aleatorio = Rnd() * 10

        sql &= "INSERT INTO fabricas("
        sql &= "id_fabrica,"
        sql &= "nombre,"
        sql &= "telefono)"
        sql &= " VALUES( "
        sql &= aleatorio
        sql &= ", '" & Me.txt_nombre_fabrica.Text & "'"
        sql &= ", " & Me.txt_telefono_fabrica.Text & ")"

        grabar_borrar(sql)
        Me.cargar_grilla_fabrica()
        Me.btn_guardar_fabrica.Enabled = False
        Me.txt_nombre_fabrica.Enabled = False
        Me.txt_telefono_fabrica.Enabled = False

        MsgBox("La carga de la fábrica fue exitosa", MessageBoxButtons.OK, "Cargar Fabrica")

    End Sub



    Private Sub Grilla_Fabrica_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Fabrica.CellContentDoubleClick

        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= " SELECT * FROM fabricas "
        sql &= " WHERE nombre = '" & Me.Grilla_Fabrica.CurrentRow.Cells(0).Value & "'"

        tabla = Me.ejecuto_sql(sql)


        Me.txt_nombre_fabrica.Text = tabla.Rows(0)("nombre")
        Me.txt_telefono_fabrica.Text = tabla.Rows(0)("telefono")

        Me.accion = tipo_grabacion.modificar
        Me.txt_nombre_fabrica.Enabled = True
        Me.txt_telefono_fabrica.Enabled = True
        Me.btn_guardar_fabrica.Enabled = True



    End Sub

    Private Sub modificar()
        Dim sql As String = ""

        sql &= "UPDATE fabricas SET "
        sql &= "nombre = '" & Me.txt_nombre_fabrica.Text & "'"
        sql &= ", telefono = " & Me.txt_telefono_fabrica.Text

        grabar_borrar(sql)
        MsgBox("La fabrica fue modificada exitosamente ", MessageBoxButtons.OK, "Exito")
        cargar_grilla_fabrica()

    End Sub


    Private Sub btn_eliminar_fabrica_Click(sender As Object, e As EventArgs) Handles btn_eliminar_fabrica.Click
        Dim sql As String = ""

        sql &= "DELETE FROM fabricas WHERE nombre = '" & Me.Grilla_Fabrica.CurrentRow.Cells(0).Value & "'"

        If MessageBox.Show("¿Está seguro que quiere eliminar el registro ?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.grabar_borrar(sql)
            MsgBox("Se borraron los datos exitosamente", MessageBoxButtons.OK, "Eliminación de Fabrica")
            cargar_grilla_fabrica()

        End If

        'If Me.Grilla_Fabrica.CurrentCell.Selected = False Then
        '    MessageBox.Show("Falta sereccionar dato en grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'End If


    End Sub

    



End Class