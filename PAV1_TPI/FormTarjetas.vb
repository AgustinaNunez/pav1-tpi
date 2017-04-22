Public Class FormTarjetas

    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=(localdb)\Servidor;Integrated Security=SSPI;Initial Catalog=BD_CLOTTA"

    Enum respuesta_validacion
        _error
        _ok
    End Enum

    Private Sub FormTarjetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_combo(cmb_banco_adherido, ejecuto_sql("SELECT * FROM bancos"), "id_banco", "nombre")
        cargar_combo(cmb_entidad_crediticia, ejecuto_sql("SELECT * FROM entidades_crediticias"), "id_entidad_crediticia", "nombre")
        Me.txt_numero_tarjeta.Focus()
    End Sub


    'SUBRUTINA PARA INSERTAR TARJETAS A LA BD
    Private Sub insertar()

        Dim sql As String = ""

        sql &= "INSERT INTO tarjetas( "
        sql &= "id_tarjeta, "
        sql &= "apellido_nombre_tarjeta,"
        sql &= "fecha_vencimiento,"
        sql &= "id_banco,"
        sql &= "id_entidad_crediticia)"
        sql &= "VALUES("
        sql &= txt_numero_tarjeta.Text
        sql &= ", '" & txt_nombre.Text & "'"
        sql &= ", '" & txt_fecha_vencimiento.Text & "'"
        sql &= ", " & cmb_banco_adherido.SelectedValue
        sql &= ", " & cmb_entidad_crediticia.SelectedValue
        sql &= ") "

        Me.ejecuto_sql(sql)


    End Sub


    'EJECUTO SQL
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


    'GRABAR EN BD
    Private Sub grabar_en_bd(ByVal sql As String)

        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        conexion.Close()

    End Sub


    'CARGA DE COMBOS
    Private Sub cargar_combo(ByRef combo As ComboBox, tabla As DataTable, pk As String, ByVal descriptor As String)

        combo.DataSource = tabla
        combo.DisplayMember = descriptor
        combo.ValueMember = pk

    End Sub


    'SUBRUTINA PARA VALIDAR DATOS INGRESADOS
    Private Function validar_datos() As respuesta_validacion

        For Each obj As Windows.Forms.Control In Me.Controls

            If obj.GetType().Name = "TextBox" Or obj.GetType().Name = "MaskedTextBox" Then

                If obj.Text = "" Then

                    MsgBox("El campo " + obj.Name + " está vacio.", MsgBoxStyle.OkOnly, "Error")
                    obj.Focus()
                    Return respuesta_validacion._error

                End If

            End If

            If obj.GetType().Name = "ComboBox" Then

                Dim local As ComboBox = obj

                If local.SelectedValue = -1 Then

                    MsgBox("El campo " + obj.Name + " está vacio.", MsgBoxStyle.OkOnly, "Error")
                    obj.Focus()
                    Return respuesta_validacion._error

                End If

            End If

        Next

        Return respuesta_validacion._ok

    End Function



    'BOTON ACEPTAR
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click

        If validar_datos() = respuesta_validacion._ok Then

            If MessageBox.Show("¿Los datos ingresados son correctos?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

                insertar()

                MsgBox("¡Datos ingresados!", MessageBoxButtons.OK)

                Me.Close()

            End If

        End If
       
    End Sub


    'BOTON CANCELAR
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click

        If MessageBox.Show("¿Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

            Me.Close()

        End If

    End Sub




End Class