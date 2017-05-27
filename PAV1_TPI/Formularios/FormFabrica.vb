Imports System.Data.OleDb

Public Class FormFabrica

    Dim accion As tipo_grabacion = tipo_grabacion.insertar
    Dim seleccion As String
    Dim MA As New SoporteBD

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
        txt_codigo_fabrica.Text = Format(SoporteBD.autogenerar_codigo("AUTOGENERARCODIGO"), "000")
    End Sub

    Private Sub cargar_grilla_fabrica()
        Dim tabla As New DataTable
        Dim sql_cargar_grilla As String = " SELECT nombre, telefono, id_fabrica FROM fabricas WHERE id_fabrica <> 0"
        tabla = SoporteBD.leerBD_simple(sql_cargar_grilla)

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
        Return SoporteBD.leerBD_simple("SELECT * FROM " + nombre_tabla)
    End Function

    Private Sub borrar_datos()
        For Each obj As Windows.Forms.Control In Me.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
            End If
            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Text = ""
            End If
            Me.ocultar_lblERROR()
        Next
    End Sub

    Private Sub btn_nueva_fabrica_Click(sender As Object, e As EventArgs) Handles btn_nueva_fabrica.Click
        Me.borrar_datos()
        Me.txt_codigo_fabrica.Text = SoporteBD.autogenerar_codigo("AUTOGENERARCODIGO")
        Me.accion = tipo_grabacion.insertar
        Me.btn_guardar_fabrica.Enabled = True
        Me.txt_nombre_fabrica.Enabled = True
        Me.txt_telefono_fabrica.Enabled = True
    End Sub

    Private Sub ocultar_lblERROR()
        lbl_nombreERROR.Visible = False
        lbl_telefonoERROR.Visible = False

    End Sub

    Private Function validar_datos() As respuesta_validacion
        Me.ocultar_lblERROR()
        Dim rdo = respuesta_validacion._ok

        If txt_nombre_fabrica.Text = "" Then
            lbl_nombreERROR.Visible = True
            txt_nombre_fabrica.Focus()
            rdo = respuesta_validacion._error
            MsgBox("El nombre no fue ingresado", MsgBoxStyle.OkOnly, "Error")
        End If

        If txt_telefono_fabrica.Text = "" Then
            lbl_telefonoERROR.Visible = True
            txt_telefono_fabrica.Focus()
            rdo = respuesta_validacion._error
            MsgBox("El telefono no fue ingresado", MsgBoxStyle.OkOnly, "Error")
        End If

        Return rdo
    End Function

    Private Function validar_fabrica() As respuesta_validacion
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql &= " SELECT * FROM fabricas WHERE nombre = '" & Me.txt_nombre_fabrica.Text & "'"

        tabla = SoporteBD.leerBD_simple(sql)

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


        sql &= "INSERT INTO fabricas("
        sql &= "id_fabrica,"
        sql &= "nombre,"
        sql &= "telefono)"
        sql &= " VALUES( "
        sql &= SoporteBD.autogenerar_codigo("fabricas")
        sql &= ", '" & Me.txt_nombre_fabrica.Text & "'"
        sql &= ", " & Me.txt_telefono_fabrica.Text & ")"

        SoporteBD.escribirBD_simple(sql)
        Me.cargar_grilla_fabrica()
        Me.btn_guardar_fabrica.Enabled = False
        Me.txt_nombre_fabrica.Enabled = False
        Me.txt_telefono_fabrica.Enabled = False
        Me.btn_eliminar_fabrica.Enabled = False

        MsgBox("La carga de la fábrica fue exitosa", MessageBoxButtons.OK, "Cargar Fabrica")



    End Sub

    Private Sub Grilla_Fabrica_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Fabrica.CellContentDoubleClick

        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= " SELECT * FROM fabricas "
        sql &= " WHERE id_fabrica = " & Me.Grilla_Fabrica.CurrentRow.Cells(2).Value

        tabla = SoporteBD.leerBD_simple(sql)


        Me.txt_nombre_fabrica.Text = tabla.Rows(0)("nombre")
        Me.txt_telefono_fabrica.Text = tabla.Rows(0)("telefono")
        Me.txt_codigo_fabrica.Text = tabla.Rows(0)("id_fabrica")

        Me.accion = tipo_grabacion.modificar
        Me.txt_nombre_fabrica.Enabled = True
        Me.txt_telefono_fabrica.Enabled = True
        Me.btn_guardar_fabrica.Enabled = True
        Me.btn_eliminar_fabrica.Enabled = True



    End Sub

    Private Sub modificar()
        Dim sql As String = ""


        sql &= "UPDATE fabricas SET "
        sql &= " nombre = '" & Me.txt_nombre_fabrica.Text & "'"
        sql &= ", telefono = " & Me.txt_telefono_fabrica.Text
        sql &= "WHERE id_fabrica = " & Me.txt_codigo_fabrica.Text

        SoporteBD.leerBD_simple(sql)
        MsgBox("La fabrica fue modificada exitosamente ", MessageBoxButtons.OK, "Exito")
        cargar_grilla_fabrica()

        Me.btn_eliminar_fabrica.Enabled = False
        Me.btn_guardar_fabrica.Enabled = False

    End Sub

    Private Sub btn_eliminar_fabrica_Click(sender As Object, e As EventArgs) Handles btn_eliminar_fabrica.Click
        Dim sql As String = ""

        sql &= "DELETE FROM fabricas WHERE nombre = '" & Me.Grilla_Fabrica.CurrentRow.Cells(0).Value & "'"

        If MessageBox.Show("¿Está seguro que quiere eliminar el registro ?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            SoporteBD.escribirBD_simple(sql)
            MsgBox("Se borraron los datos exitosamente", MessageBoxButtons.OK, "Eliminación de Fabrica")
            cargar_grilla_fabrica()
            Me.txt_nombre_fabrica.Enabled = False
            Me.txt_telefono_fabrica.Enabled = False
            Me.btn_eliminar_fabrica.Enabled = False
            Me.btn_guardar_fabrica.Enabled = False
        End If

    End Sub

    Private Sub txt_bucar_fabrica_TextChanged(sender As Object, e As EventArgs) Handles txt_bucar_fabrica.TextChanged
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql &= " SELECT * FROM fabricas WHERE nombre LIKE '%" & Me.txt_bucar_fabrica.Text & "%' AND id_fabrica <> 0"
        tabla = SoporteBD.leerBD_simple(sql)

        Dim c As Integer
        Me.Grilla_Fabrica.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1

            Me.Grilla_Fabrica.Rows.Add()
            Me.Grilla_Fabrica.Rows(c).Cells(0).Value = tabla.Rows(c)("nombre")
            Me.Grilla_Fabrica.Rows(c).Cells(1).Value = tabla.Rows(c)("telefono")
            Me.Grilla_Fabrica.Rows(c).Cells(2).Value = tabla.Rows(c)("id_fabrica")
        Next

    End Sub
End Class