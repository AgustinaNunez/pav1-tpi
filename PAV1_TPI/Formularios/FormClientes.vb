Public Class FormClientes

    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=(local)\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=BD_CLOTTA"
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

    'LOADER DEL FORM
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SoporteGUI.tipo_form_ACTUAL = SoporteGUI.tipo_form.transaccion Then
            Me.btn_seleccionar.Visible = True
        End If
        cargar_grilla_cliente()
        SoporteGUI.cargar_combo(cmb_tipo_documento_cliente_carga, SoporteBD.leerBD_simple("SELECT * FROM tipo_documento"), "id_tipo_documento", "nombre_tipo_documento")
        SoporteGUI.cargar_combo(cmb_tipo_documento_cliente_busqueda, SoporteBD.leerBD_simple("SELECT * FROM tipo_documento"), "id_tipo_documento", "nombre_tipo_documento")
        Me.limpiar_campos()
    End Sub

    'SUBRUTINA PARA CARGAR GRILLAS
    Private Sub cargar_grilla_cliente()
        Dim tabla As New DataTable
        Dim sql_cargar_grilla As String = ""
        sql_cargar_grilla &= "SELECT * FROM clientes c "
        sql_cargar_grilla &= "JOIN tipo_documento td ON c.tipo_documento = td.id_tipo_documento"
        tabla = SoporteBD.leerBD_simple(sql_cargar_grilla)

        Dim c As Integer
        Me.dgv_clientes.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_clientes.Rows.Add()
            Me.dgv_clientes.Rows(c).Cells(0).Value = tabla.Rows(c)("apellido_cliente")
            Me.dgv_clientes.Rows(c).Cells(1).Value = tabla.Rows(c)("nombre_cliente")
            Me.dgv_clientes.Rows(c).Cells(2).Value = tabla.Rows(c)("nombre_tipo_documento")
            Me.dgv_clientes.Rows(c).Cells(3).Value = tabla.Rows(c)("numero_documento")
            Me.dgv_clientes.Rows(c).Cells(4).Value = tabla.Rows(c)("e_mail_cliente")
            Me.dgv_clientes.Rows(c).Cells(5).Value = tabla.Rows(c)("telefono_cliente")
        Next
        Me.txt_apellido_cliente_carga.Focus()
    End Sub

    'SUBRUTINA PARA BLANQUEAR LOS CAMPOS
    Private Sub limpiar_campos()
        For Each obj As Windows.Forms.Control In Me.Controls
            Me.txt_apellido_cliente_carga.Text = ""
            Me.txt_nombre_cliente_carga.Text = ""
            Me.txt_numero_documento_carga.Text = ""
            Me.txt_numero_documento_cliente_busqueda.Text = ""
            Me.txt_email_cliente_cliente_carga.Text = ""
            Me.cmb_tipo_documento_cliente_carga.SelectedIndex = -1
            Me.cmb_tipo_documento_cliente_busqueda.SelectedIndex = -1
            Me.txt_telefono_cliente_carga.Text = ""
            Me.ocultar_lblERROR()
            Me.lbl_msj.Visible = False
        Next
    End Sub

    'BOTON PARA BLANQUEAR NUEVO CLIENTE
    Private Sub btn_nuevo_cliente_carga_Click(sender As Object, e As EventArgs) Handles btn_nuevo_cliente_carga.Click
        'If MessageBox.Show("¿Está seguro que desea eliminar los datos ingresados?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
        Me.limpiar_campos()
        Me.accion = tipo_grabacion.insertar
        Me.btn_guardar_cliente_carga.Enabled = True
        Me.txt_apellido_cliente_carga.Enabled = True
        Me.txt_nombre_cliente_carga.Enabled = True
        Me.txt_numero_documento_carga.Enabled = True
        Me.cmb_tipo_documento_cliente_carga.Enabled = True
        Me.txt_email_cliente_cliente_carga.Enabled = True
        Me.txt_telefono_cliente_carga.Enabled = True
        Me.txt_apellido_cliente_carga.Focus()
        Me.cargar_grilla_cliente()
        ' End If
    End Sub


    'FUNCION PARA VALIDAR DATOS INGRESADOS
    Private Function validar_datos() As respuesta_validacion
        Me.ocultar_lblERROR()
        Dim rdo = respuesta_validacion._ok
        Dim cadena As String = "Los siguientes campos están vacíos:"
        If txt_apellido_cliente_carga.Text = "" Then
            lbl_apellidoERROR.Visible = True
            txt_apellido_cliente_carga.Focus()
            rdo = respuesta_validacion._error
            cadena &= " Apellido;"
        End If
        If txt_nombre_cliente_carga.Text = "" Then
            lbl_nombreERROR.Visible = True
            txt_nombre_cliente_carga.Focus()
            rdo = respuesta_validacion._error
            cadena &= " Nombre;"
            'MsgBox("El nombre no fue ingresado", MsgBoxStyle.OkOnly, "Error")
        End If

        If cmb_tipo_documento_cliente_carga.Text = "" Then
            lbl_tipodocERROR.Visible = True
            cmb_tipo_documento_cliente_carga.Focus()
            rdo = respuesta_validacion._error
            cadena &= " Tipo de Documento;"
            'MsgBox("El tipo de documento no fue ingresado", MsgBoxStyle.OkOnly, "Error")
        End If

        If txt_numero_documento_carga.Text = "" Then
            lbl_documentoERROR.Visible = True
            txt_numero_documento_carga.Focus()
            rdo = respuesta_validacion._error
            cadena &= " Número de Documento;"
            'MsgBox("El numero de documento no fue ingresado", MsgBoxStyle.OkOnly, "Error")
        End If

        If txt_apellido_cliente_carga.Text = "" Or txt_nombre_cliente_carga.Text = "" Or cmb_tipo_documento_cliente_carga.Text = "" Or txt_numero_documento_carga.Text = "" Then
            MsgBox(cadena, MsgBoxStyle.OkCancel, "Error")
        End If

        Return rdo

    End Function


    'SUBRUTINA PARA OCULTAR LOS LABELS X
    Private Sub ocultar_lblERROR()
        lbl_apellidoERROR.Visible = False
        lbl_documentoERROR.Visible = False
        lbl_nombreERROR.Visible = False
        lbl_tipodocERROR.Visible = False

    End Sub

    'FUNCION PARA VALIDAR UNA PERSONA (PARA QUE NO EXISTA)
    Private Function validar_persona() As respuesta_validacion
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql &= "SELECT numero_documento, tipo_documento FROM clientes WHERE numero_documento = " & Me.txt_numero_documento_carga.Text
        sql &= " AND tipo_documento = " & Me.cmb_tipo_documento_cliente_carga.SelectedValue

        tabla = SoporteBD.leerBD_simple(sql)

        If tabla.Rows.Count = 1 Then
            MsgBox("La combinacion de tipo y numero de docuento ya existe", MsgBoxStyle.OkOnly, "Error")
            Return respuesta_validacion._error
        End If

        Return respuesta_validacion._ok
    End Function

    'SUBRUTINA PARA GUARDAR INFORMACION A LA BD
    Private Sub btn_guardar_cliente_carga_Click(sender As Object, e As EventArgs) Handles btn_guardar_cliente_carga.Click
        If validar_datos() = respuesta_validacion._ok Then
            If accion = tipo_grabacion.insertar Then
                If validar_persona() = respuesta_validacion._ok Then
                    insertar()
                    'Me.limpiar_campos()
                End If
            Else
                modificar()
            End If
            Me.limpiar_campos()
        End If
    End Sub

    'SUBRUTINA PARA INSERTAR DATOS
    Private Sub insertar()
        Dim sql As String = ""
        sql &= "INSERT INTO clientes("
        sql &= "numero_documento,"
        sql &= "tipo_documento,"
        sql &= "nombre_cliente,"
        sql &= "apellido_cliente,"
        sql &= "telefono_cliente,"
        sql &= "e_mail_cliente)"
        sql &= " VALUES("
        sql &= "'" & Me.txt_numero_documento_carga.Text & "'"
        sql &= "," & Me.cmb_tipo_documento_cliente_carga.SelectedValue
        sql &= ",'" & Me.txt_nombre_cliente_carga.Text & "'"
        sql &= ",'" & Me.txt_apellido_cliente_carga.Text & "'"

        If txt_telefono_cliente_carga.Text = "" Then
            sql &= ",0"
        Else
            sql &= "," & Me.txt_telefono_cliente_carga.Text
        End If

        If txt_email_cliente_cliente_carga.Text = "" Then
            sql &= ",'')"
        Else
            sql &= ",'" & Me.txt_email_cliente_cliente_carga.Text & "')"
        End If



        SoporteBD.escribirBD_simple(sql)
        Me.cargar_grilla_cliente()
        Me.btn_guardar_cliente_carga.Enabled = False
        Me.txt_apellido_cliente_carga.Enabled = False
        Me.txt_nombre_cliente_carga.Enabled = False
        Me.txt_numero_documento_carga.Enabled = False
        Me.cmb_tipo_documento_cliente_carga.Enabled = False
        Me.txt_email_cliente_cliente_carga.Enabled = False
        Me.txt_telefono_cliente_carga.Enabled = False

        'MsgBox("La carga del cliente fue exitosa", MessageBoxButtons.OK, "Carga Cliente")
    End Sub

    'SUBRUTINA PARA INTERACCION DE GRILLA
    Private Sub grid_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick, dgv_clientes.CellContentDoubleClick
        If SoporteGUI.tipo_form_ACTUAL = SoporteGUI.tipo_form.transaccion Then
            Me.btn_seleccionar.Enabled = True
        End If
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql &= " SELECT * FROM clientes "
        sql &= " WHERE numero_documento = '" & Me.dgv_clientes.CurrentRow.Cells(3).Value & "'"

        tabla = SoporteBD.leerBD_simple(sql)

        Me.txt_apellido_cliente_carga.Text = tabla.Rows(0)("apellido_cliente")
        Me.txt_nombre_cliente_carga.Text = tabla.Rows(0)("nombre_cliente")
        Me.cmb_tipo_documento_cliente_carga.SelectedValue = tabla.Rows(0)("tipo_documento")
        Me.txt_numero_documento_carga.Text = tabla.Rows(0)("numero_documento")

        If tabla.Rows(0)("e_mail_cliente") = "0" Then
            Me.txt_email_cliente_cliente_carga.Text = ""
        Else
            Me.txt_email_cliente_cliente_carga.Text = tabla.Rows(0)("e_mail_cliente")
        End If

        If tabla.Rows(0)("telefono_cliente") = "0" Then
            Me.txt_telefono_cliente_carga.Text = ""
        Else
            Me.txt_telefono_cliente_carga.Text = tabla.Rows(0)("telefono_cliente")
        End If


        Me.accion = tipo_grabacion.modificar
        Me.txt_apellido_cliente_carga.Enabled = True
        Me.txt_nombre_cliente_carga.Enabled = True
        Me.txt_numero_documento_carga.Enabled = False
        Me.cmb_tipo_documento_cliente_carga.Enabled = False
        Me.txt_email_cliente_cliente_carga.Enabled = True
        Me.txt_telefono_cliente_carga.Enabled = True
        Me.btn_guardar_cliente_carga.Enabled = True
        Me.btn_eliminar_cliente_carga.Enabled = True
    End Sub

    'SUBRUTINA PARA MODIFICAR CLIENTES
    Private Sub modificar()
        Dim sql As String = ""
        sql &= "UPDATE clientes SET "
        sql &= "apellido_cliente = '" & Me.txt_apellido_cliente_carga.Text & "'"
        sql &= ", nombre_cliente = '" & Me.txt_nombre_cliente_carga.Text & "'"
        sql &= ", e_mail_cliente = '" & Me.txt_email_cliente_cliente_carga.Text & "'"
        sql &= ", telefono_cliente = " & Me.txt_telefono_cliente_carga.Text
        sql &= " WHERE numero_documento = '" & Me.txt_numero_documento_carga.Text & "'"

        SoporteBD.escribirBD_simple(sql)
        'MsgBox("El cliente fue modificado", MessageBoxButtons.OK, "Exito")
        cargar_grilla_cliente()
        txt_apellido_cliente_carga.Enabled = False
        txt_email_cliente_cliente_carga.Enabled = False
        txt_nombre_cliente_carga.Enabled = False
        txt_telefono_cliente_carga.Enabled = False
        btn_eliminar_cliente_carga.Enabled = False
        btn_guardar_cliente_carga.Enabled = False
    End Sub

    'SUBRUTINA PARA BORRAR CLIENTES
    Private Sub btn_eliminar_cliente_carga_Click(sender As Object, e As EventArgs) Handles btn_eliminar_cliente_carga.Click
        Dim sql As String = ""
        sql &= "DELETE clientes WHERE numero_documento = '" & Me.dgv_clientes.CurrentRow.Cells(3).Value & "'"

        If MessageBox.Show("¿Está seguro que quiere eliminar el registro?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            SoporteBD.escribirBD_simple(sql)
            MsgBox("Se borraron los datos exitosamente", MessageBoxButtons.OK, "Eliminación Cliente")
            cargar_grilla_cliente()
        End If

        Me.btn_guardar_cliente_carga.Enabled = False
        Me.btn_eliminar_cliente_carga.Enabled = False
        Me.txt_apellido_cliente_carga.Enabled = False
        Me.txt_email_cliente_cliente_carga.Enabled = False
        Me.txt_nombre_cliente_carga.Enabled = False
        Me.txt_telefono_cliente_carga.Enabled = False


    End Sub


    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        Dim sql As String = ""
        sql &= "SELECT * FROM clientes c JOIN tipo_documento td ON c.tipo_documento = td.id_tipo_documento "
        sql &= " WHERE td.nombre_tipo_documento = '" & Me.cmb_tipo_documento_cliente_carga.Text & "'"
        sql &= " AND c.numero_documento LIKE '%" & Me.txt_numero_documento_carga.Text & "%'"
        Dim tabla As New DataTable
        tabla = SoporteBD.leerBD_simple(sql)

        If tabla.Rows.Count = 0 Then
            Me.limpiar_campos()
            'Me.cargar_grilla_cliente()
            Return
        End If

        If Me.validar_campos() Then
            Cliente.apellido = txt_apellido_cliente_carga.Text
            Cliente.nombre = txt_nombre_cliente_carga.Text
            Cliente.nro_doc = txt_numero_documento_carga.Text
            Cliente.tipo_doc = cmb_tipo_documento_cliente_carga.SelectedValue
            SoporteGUI.flag = True
            Me.Dispose()

        End If
    End Sub

    Private Function validar_campos()
        Dim flag As Boolean = True
        Dim mensaje As String = "Hay campos obligatorios sin completar:"
        If Me.txt_apellido_cliente_carga.Text = "" Then
            mensaje &= vbCrLf & "- apellido"
            flag = False
        End If
        If Me.txt_nombre_cliente_carga.Text = "" Then
            mensaje &= vbCrLf & "- nombre"
            flag = False
        End If
        If Me.cmb_tipo_documento_cliente_carga.SelectedIndex = -1 Then
            mensaje &= vbCrLf & "- tipo documento"
            flag = False
        End If
        If Me.txt_numero_documento_carga.Text = "" Then
            mensaje &= vbCrLf & "- número documento"
            flag = False
        End If
        If flag = False Then
            MessageBox.Show(mensaje, "CLOTTA _ Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return flag
    End Function

    Private Sub txt_numero_documento_cliente_busqueda_TextChanged(sender As Object, e As EventArgs) Handles txt_numero_documento_cliente_busqueda.TextChanged
        If txt_numero_documento_cliente_busqueda.Text = "" Then
            Me.cargar_grilla_cliente()
            Return
        Else
            Dim sql As String = ""
            sql &= "SELECT * FROM clientes c JOIN tipo_documento td ON c.tipo_documento = td.id_tipo_documento "
            sql &= " WHERE td.nombre_tipo_documento = '" & Me.cmb_tipo_documento_cliente_busqueda.Text & "'"
            sql &= " AND c.numero_documento LIKE '%" & Me.txt_numero_documento_cliente_busqueda.Text & "%'"
            Dim tabla As New DataTable
            tabla = SoporteBD.leerBD_simple(sql)

            Dim c As Integer
            Me.dgv_clientes.Rows.Clear()
            For c = 0 To tabla.Rows.Count - 1
                Me.dgv_clientes.Rows.Add()
                Me.dgv_clientes.Rows(c).Cells(0).Value = tabla.Rows(c)("apellido_cliente")
                Me.dgv_clientes.Rows(c).Cells(1).Value = tabla.Rows(c)("nombre_cliente")
                Me.dgv_clientes.Rows(c).Cells(2).Value = tabla.Rows(c)("nombre_tipo_documento")
                Me.dgv_clientes.Rows(c).Cells(3).Value = tabla.Rows(c)("numero_documento")
                Me.dgv_clientes.Rows(c).Cells(4).Value = tabla.Rows(c)("e_mail_cliente")
                Me.dgv_clientes.Rows(c).Cells(5).Value = tabla.Rows(c)("telefono_cliente")
            Next

        End If
    End Sub
End Class