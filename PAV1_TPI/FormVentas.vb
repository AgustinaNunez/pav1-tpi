Public Class FormVentas
    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Soporte.cargar_combo(cmb_tipoDocCLIENTE, Soporte.leerBD_simple("SELECT * FROM tipo_documento"), "id_tipo_documento", "nombre_tipo_documento")
        Soporte.cargar_combo(cmb_producto, Soporte.leerBD_simple("SELECT * FROM productos"), "id_producto", "descripcion")
        Me.limpiar_camposVENTA()
        Me.limpiar_camposCLIENTE()
        Me.limpiar_camposDETALLE()
        Me.limpiar_camposFORMAPAGO()
    End Sub

    Private Sub btn_nuevaVENTA_Click(sender As Object, e As EventArgs) Handles btn_nuevaVENTA.Click
        Me.habilitar_campos()
    End Sub

    Private Sub limpiar_camposDETALLE()
        Me.cmb_producto.SelectedIndex = -1
        Me.txt_precio.Text = "0,00"
        Me.txt_cantidad.Text = "0"
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

    Private Sub habilitar_campos()
        'CLIENTE
        Me.cmb_tipoDocCLIENTE.Enabled = True
        Me.txt_nroDocCLIENTE.Enabled = True
        Me.btn_buscarCLIENTE.Enabled = True
        'DETALLE
        Me.cmb_producto.Enabled = True
        Me.txt_cantidad.Enabled = True
        Me.btn_agregarDETALLE.Enabled = True
    End Sub
End Class