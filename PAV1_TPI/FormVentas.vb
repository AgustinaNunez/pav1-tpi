Public Class FormVentas
    Dim hay_articulos_cargados As Boolean = False

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Soporte.cargar_combo(cmb_tipoDocCLIENTE, Soporte.leerBD_simple("SELECT * FROM tipo_documento"), "id_tipo_documento", "nombre_tipo_documento")
        Soporte.cargar_combo(cmb_producto, Soporte.leerBD_simple("SELECT * FROM productos"), "id_producto", "descripcion")
        Me.limpiar_camposVENTA()
        Me.limpiar_camposCLIENTE()
        Me.limpiar_camposDETALLE()
        Me.limpiar_camposFORMAPAGO()
    End Sub

    Private Sub btn_nuevaVENTA_Click(sender As Object, e As EventArgs) Handles btn_nuevaVENTA.Click
        Me.habilitar_camposVENTA()
        Me.limpiar_camposVENTA()
        Me.limpiar_camposCLIENTE()
        Me.limpiar_camposDETALLE()
        Me.limpiar_camposFORMAPAGO()
        Me.txt_nroDocCLIENTE.Focus()
    End Sub

    Private Sub limpiar_camposDETALLE()
        Me.cmb_producto.SelectedIndex = -1
        Me.txt_precio.Text = "0,00"
        Me.txt_cantidad.Text = "1"
    End Sub

    Private Sub limpiar_camposFORMAPAGO()
        Me.cmb_formaPago.SelectedIndex = -1
        Me.txt_montoFORMAPAGO.Text = "0,00"
    End Sub

    Private Sub limpiar_camposVENTA()
        Me.txt_idVENTA.Text = "000000"
        Me.txt_fecha.Text = Today
        Me.txt_hora.Text = TimeOfDay
        Me.txt_subtotalVENTA.Text = "0,00"
        Me.txt_dtoVENTA.Text = "0,00"
        Me.txt_totalVENTA.Text = "0,00"
    End Sub

    Private Sub limpiar_camposCLIENTE()
        'Me.cmb_tipoDocCLIENTE.SelectedIndex = -1
        Me.txt_nroDocCLIENTE.Text = ""
        Me.txt_nombreCLIENTE.Text = ""
    End Sub

    Private Sub habilitar_camposVENTA()
        'CLIENTE
        Me.cmb_tipoDocCLIENTE.Enabled = True
        Me.txt_nroDocCLIENTE.Enabled = True
        Me.btn_buscarCLIENTE.Enabled = True
        'DETALLE
        Me.cmb_producto.Enabled = True
        Me.txt_cantidad.Enabled = True
        Me.btn_agregarDETALLE.Enabled = True
    End Sub

    Private Sub habilitar_camposPAGO()
        'FORMA_PAGO
        Me.cmb_formaPago.Enabled = True
        Me.txt_montoFORMAPAGO.Enabled = True
        Me.btn_agregarFORMAPAGO.Enabled = True
    End Sub

    Private Sub btn_agregarDETALLE_Click(sender As Object, e As EventArgs) Handles btn_agregarDETALLE.Click
        If Me.hay_articulos_cargados = False Then
            Me.hay_articulos_cargados = True
            Me.habilitar_camposPAGO()
        End If

    End Sub

    Private Sub btn_buscarCLIENTE_Click(sender As Object, e As EventArgs) Handles btn_buscarCLIENTE.Click
        If Me.txt_nroDocCLIENTE.Text = "" Then
            'MessageBox.Show("Falta ingresar el número de documento.", "Gestión de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Me.txt_nroDocCLIENTE.Focus()
            Dim frmClientes = New FormClientes
            frmClientes.Visible = True
            Return
        End If

        Dim sql As String = ""
        sql &= "SELECT * FROM clientes c JOIN tipo_documento td ON c.tipo_documento = td.id_tipo_documento "
        sql &= " WHERE td.nombre_tipo_documento = '" & Me.cmb_tipoDocCLIENTE.Text & "'"
        sql &= " AND c.numero_documento = " & Me.txt_nroDocCLIENTE.Text
        Dim tabla As New DataTable
        tabla = Soporte.leerBD_simple(sql)

        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No se encontró el cliente con " & Me.cmb_tipoDocCLIENTE.SelectedText & Me.txt_nroDocCLIENTE.Text & ".", "Gestión de Ventas",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txt_nroDocCLIENTE.Text = ""
            Me.txt_nroDocCLIENTE.Focus()
            Return
        End If

        Me.txt_nombreCLIENTE.Text = tabla.Rows(0)("apellido_cliente") & ", " & tabla.Rows(0)("nombre_cliente")
    End Sub
End Class