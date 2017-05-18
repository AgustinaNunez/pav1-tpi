Imports System.ComponentModel

Public Class FormCompras
    'ENUMERADOR DE RESPUESTAS DE VALIDACION
    Enum respuesta_validacion
        _ok
        _error
    End Enum

    'LOADER DE COMPRAS
    Private Sub form_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Soporte.cargar_combo(cmb_producto, Soporte.leerBD_simple("SELECT * FROM productos"), "id_producto", "descripcion")
        Me.limpiar_campos_detalle()
        'txt_fecha.Text = Date.Today
        'txt_hora.Text = TimeOfDay
    End Sub

    'BOTON NUEVO
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Me.limpiar_campos_compra()
        Me.habilitar_campos()

        Me.btn_guardar.Enabled = True
        Me.btn_agregar.Enabled = True
        Me.txt_id_compra.Focus()
    End Sub

    'BOTON AGREGAR
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        'PRIMERO VERIFICA SI LAS FILAS DE LA TABLA SON NULAS
        If Me.grid_compras.Rows.Count = 0 Then
            Me.grid_compras.Rows.Add(cmb_producto.Text, Me.txt_cantidad.Text, Me.txt_precio.Text, cmb_producto.SelectedValue)
            Dim total As Double = 0
            total = total + Convert.ToDouble(Me.grid_compras.Rows(0).Cells("col_cantidad").Value * Convert.ToDouble(Me.grid_compras.Rows(0).Cells("col_precio").Value))
            Me.txt_monto.Text = total
        Else
            If existe_en_grid() = True Then
                Me.grid_compras.Rows.Add(cmb_producto.Text, Me.txt_cantidad.Text, Me.txt_precio.Text, cmb_producto.SelectedValue)
                Dim total As Double = 0
                For c = 0 To Me.grid_compras.Rows.Count - 1
                    total = total + Convert.ToDouble(Me.grid_compras.Rows(c).Cells("col_cantidad").Value * Convert.ToDouble(Me.grid_compras.Rows(c).Cells("col_precio").Value))
                Next
                Me.txt_monto.Text = total
            End If
        End If
        Me.limpiar_campos_detalle()
    End Sub

    'FUNCION QUE DEVUELVE TRUE SI EXISTE UN ELEMENTO SELECCIONADO EN LA GRILLA
    Private Function existe_en_grid()
        Dim valor As Boolean = True
        For a = 0 To Me.grid_compras.Rows.Count - 1
            If Me.cmb_producto.SelectedValue = Me.grid_compras.Rows(a).Cells("col_id_producto").Value Then
                MsgBox("El producto '" & cmb_producto.Text & "' ya fue cargado, seleccione otro", MsgBoxStyle.OkOnly, "Error")
                valor = False
            End If
        Next
        Return valor
    End Function

    'BOTON GRABAR
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If validar_campos() = respuesta_validacion._ok Then
            If validar_compra() = respuesta_validacion._ok Then
                Soporte.iniciar_conexion_con_transaccion()

                Dim sql_insertar_compra As String = ""
                sql_insertar_compra &= "INSERT INTO compras(id_compra,fecha_compra,hora_compra,monto) VALUES(" & txt_id_compra.Text
                sql_insertar_compra &= ", '" & txt_fecha.Text & "'"
                sql_insertar_compra &= ", '" & txt_hora.Text & "'"
                sql_insertar_compra &= "," & txt_monto.Text & ")"
                Soporte.escribirBD_transaccion(sql_insertar_compra)

                Dim sql_insertar_detalle As String = ""
                Dim tabla As New DataTable
                Dim sql As String = ""

                For c = 0 To Me.grid_compras.Rows.Count - 1
                    sql_insertar_detalle &= " INSERT INTO detalles_compras(id_compra,id_producto,cantidad,precio_unitario) VALUES (" & txt_id_compra.Text
                    sql_insertar_detalle &= "," & Me.grid_compras.Rows(c).Cells("col_id_producto").Value
                    sql_insertar_detalle &= "," & Me.grid_compras.Rows(c).Cells("col_cantidad").Value
                    sql_insertar_detalle &= "," & Me.grid_compras.Rows(c).Cells("col_precio").Value & ")"
                    Soporte.escribirBD_transaccion(sql_insertar_detalle)
                    sql_insertar_detalle = ""
                Next

                MsgBox("Datos almacenados", MsgBoxStyle.OkOnly, "Carga Correcta")
                Soporte.cerrar_conexion_con_transaccion()
                Me.deshabilitar_campos()
            End If
        End If
    End Sub

    'DESHABILITAR CAMPOS
    Private Sub deshabilitar_campos()
        Me.txt_cantidad.Enabled = False
        Me.txt_fecha.Enabled = False
        Me.txt_hora.Enabled = False
        Me.txt_id_compra.Enabled = False
        Me.txt_precio.Enabled = False
        Me.txt_monto.Enabled = False
        Me.btn_guardar.Enabled = False
        Me.cmb_producto.Enabled = False
        Me.grid_compras.Enabled = False
        Me.btn_agregar.Enabled = False
    End Sub

    'HABILITAR CAMPOS
    Private Sub habilitar_campos()
        Me.txt_cantidad.Enabled = True
        'Me.txt_id_compra.Enabled = True
        'Me.txt_monto.Enabled = False
        Me.txt_precio.Enabled = True
        Me.cmb_producto.Enabled = True
        Me.grid_compras.Enabled = True
    End Sub

    'LIMPIAR EL CONTENIDO DE LOS CAMPOS DE LA COMPRA
    Private Sub limpiar_campos_compra()
        Me.txt_cantidad.Text = ""
        Me.txt_fecha.Text = Today
        Me.txt_hora.Text = TimeOfDay
        'Me.txt_id_compra.Text = ""
        Me.txt_monto.Text = "0,00"
        Me.txt_precio.Text = ""
        Me.cmb_producto.Text = ""
    End Sub

    'LIMPIAR EL CONTENIDO DE LOS CAMPOS DE LOS PRODUCTOS A CARGAR DE LA COMPRA
    Private Sub limpiar_campos_detalle()
        Me.txt_cantidad.Text = ""
        Me.cmb_producto.SelectedIndex = -1
        Me.txt_precio.Text = ""
    End Sub

    'VALIDAR CAMPOS
    Private Function validar_campos()
        If txt_cantidad.Text = "" Or txt_fecha.Text = "" Or txt_precio.Text = "" Or cmb_producto.SelectedValue = 0 Then
            MsgBox("Alguno de los campos no fue completado", MsgBoxStyle.OkOnly, "Error")
            Return respuesta_validacion._error
        End If
        Return respuesta_validacion._ok
    End Function

    'VALIDAR COMPRA
    Public Function validar_compra()
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql &= "SELECT * FROM compras WHERE id_compra = " & Me.txt_id_compra.Text
        tabla = Soporte.leerBD_simple(sql)

        If tabla.Rows.Count = 1 Then
            MsgBox("El numero de compra ya existe, ingrese otro", MsgBoxStyle.OkOnly, "Error")
            Return respuesta_validacion._error
        End If
        Return respuesta_validacion._ok
    End Function

    'CIERRE FORMULARIO
    Private Sub FormCompras_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("¿Está seguro que desea salir?", "Gestión de Compras", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

End Class