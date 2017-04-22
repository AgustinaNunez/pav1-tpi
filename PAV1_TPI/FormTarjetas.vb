Public Class FormTarjetas

    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=(localdb)\Servidor;Integrated Security=SSPI;Initial Catalog=BD_CLOTTA"

    Private Sub FormTarjetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_combo(cmb_banco_adherido, ejecuto_sql("SELECT * FROM bancos"), "id_banco", "nombre")
        cargar_combo(cmb_entidad_crediticia, ejecuto_sql("SELECT * FROM entidades_crediticias"), "id_entidad_crediticia", "nombre")
    End Sub

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

    Private Sub cargar_combo(ByRef combo As ComboBox, tabla As DataTable, pk As String, ByVal descriptor As String)

        combo.DataSource = tabla
        combo.DisplayMember = descriptor
        combo.ValueMember = pk

    End Sub

    
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        insertar()
        Me.Close()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

End Class