Imports System.ComponentModel
Imports System.Data.OleDb

Public Class FormCompras
    'ENUMERADOR DE RESPUESTAS DE VALIDACION
    Enum respuesta_validacion
        _ok
        _error
    End Enum

    Enum estado_transaccion
        _iniciada
        _sin_iniciar
    End Enum

    Private estado_actual_transaccion As estado_transaccion = estado_transaccion._sin_iniciar

    'LOADER DE COMPRAS
    Private Sub form_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoporteGUI.tipo_form_ACTUAL = SoporteGUI.tipo_form.transaccion
        SoporteGUI.cargar_combo(cmb_fabrica, SoporteBD.leerBD_simple("SELECT * FROM fabricas"), "id_fabrica", "nombre")
        Me.cmb_fabrica.SelectedIndex = -1
        Me.limpiar_campos_detalle()
        Me.deshabilitar_campos()
        txt_id_compra.Text = Format(SoporteBD.autogenerar_codigo("AUTOGENERARCODIGO_compras"), "000")
    End Sub

    Private Sub calcular_total()
        Dim c As Integer
        Dim total As Double
        Dim parcial As Double
        For c = 0 To Me.dgv_compras.Rows.Count - 1
            parcial = Math.Round(Convert.ToDouble(Me.dgv_compras.Rows(c).Cells("col_cantidad").Value)) * Math.Round(Convert.ToDouble(Me.dgv_compras.Rows(c).Cells("col_precio").Value))
            total = total + parcial
        Next
        Me.txt_monto.Text = total
    End Sub

    'BOTON AGREGAR
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If validar_campos_detalle() Then
            'PRIMERO VERIFICA SI LAS FILAS DE LA TABLA SON NULAS
            If Me.dgv_compras.Rows.Count = 0 Then
                If Convert.ToInt32(Me.txt_cantidad.Text) > 0 Then
                    If Convert.ToDouble(Me.txt_precio.Text) > 0 Then
                        Me.dgv_compras.Rows.Add(cmb_producto.Text, Me.txt_cantidad.Text, Me.txt_precio.Text, cmb_producto.SelectedValue)
                        Me.calcular_total()
                        Me.btn_guardar.Enabled = True
                    End If
                End If
                If Convert.ToDouble(Me.txt_monto.Text) = 0 Then
                    MessageBox.Show("El precio del producto no puede ser cero.", "Gestión de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                If Convert.ToInt32(Me.txt_cantidad.Text) = 0 Then
                    MessageBox.Show("La cantidad ingresada no puede ser cero.", "Gestión de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                If producto_cargado() = False Then
                    If Convert.ToInt32(Me.txt_cantidad.Text) > 0 Then
                        If Convert.ToDouble(Me.txt_precio.Text) > 0 Then
                            Me.dgv_compras.Rows.Add(cmb_producto.Text, Me.txt_cantidad.Text, Me.txt_precio.Text, cmb_producto.SelectedValue)
                            Me.calcular_total()
                            Me.btn_guardar.Enabled = True
                        End If
                    End If

                    If Convert.ToDouble(Me.txt_monto.Text) = 0 Then
                        MessageBox.Show("El precio del producto no puede ser cero.", "Gestión de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                    If Convert.ToInt32(Me.txt_cantidad.Text) = 0 Then
                        MessageBox.Show("La cantidad ingresada no puede ser cero.", "Gestión de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                End If
            End If
            Me.limpiar_campos_detalle()
        End If
    End Sub

    Private Function validar_campos_detalle()
        Dim mensaje As String = "Faltan campos requeridos para agregar un nuevo artículo:"
        Dim flag As Boolean = True
        If Me.cmb_producto.SelectedIndex = -1 Then
            flag = False
            mensaje &= vbCrLf & "- producto"
        End If
        If Me.txt_cantidad.Text = "" Then
            flag = False
            mensaje &= vbCrLf & "- cantidad"
        End If
        If Me.txt_precio.Text = "" Then
            flag = False
            mensaje &= vbCrLf & "- precio unitario del producto comprado"
        End If
        If flag = False Then
            MessageBox.Show(mensaje, "Gestión de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return flag
    End Function

    'BOTON ELIMINAR
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If Me.dgv_compras.Rows.Count > 0 Then
            Me.dgv_compras.Rows.Remove(Me.dgv_compras.CurrentRow)
            Me.calcular_total()
        End If
        Me.cmb_producto.Enabled = True
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.Visible = False
        Me.btn_agregar.Enabled = True
        Me.btn_eliminar.Enabled = False
        Me.limpiar_campos_detalle()
    End Sub

    'FUNCION QUE DEVUELVE TRUE SI EXISTE UN ELEMENTO SELECCIONADO EN LA GRILLA
    Private Function producto_cargado()
        Dim valor As Boolean = False
        For a = 0 To Me.dgv_compras.Rows.Count - 1
            If Me.cmb_producto.SelectedValue = Me.dgv_compras.Rows(a).Cells("col_id_producto").Value Then
                MessageBox.Show("El producto '" & cmb_producto.Text & "' ya fue cargado.", "Gestión de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                valor = True
            End If
        Next
        Return valor
    End Function

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
        Me.dgv_compras.Enabled = False
        Me.btn_agregar.Enabled = False
        Me.btn_eliminar.Enabled = False
        Me.btn_nuevo_producto.Enabled = False
        Me.cmb_fabrica.Enabled = False
    End Sub

    'LIMPIAR EL CONTENIDO DE LOS CAMPOS DE LA COMPRA
    Private Sub limpiar_campos_compra()
        Me.txt_cantidad.Text = ""
        Me.txt_fecha.Text = Today
        Me.txt_hora.Text = TimeOfDay
        Me.txt_monto.Text = "0,00"
        Me.txt_precio.Text = ""
        Me.cmb_producto.Text = ""
        Me.dgv_compras.Rows.Clear()
        Me.cmb_fabrica.SelectedIndex = -1
    End Sub

    'LIMPIAR EL CONTENIDO DE LOS CAMPOS DE LOS PRODUCTOS A CARGAR DE LA COMPRA
    Private Sub limpiar_campos_detalle()
        Me.txt_cantidad.Text = ""
        Me.cmb_producto.SelectedIndex = -1
        'Me.cmb_fabrica.SelectedIndex = -1
        Me.txt_precio.Text = ""
    End Sub

    'VALIDAR CAMPOS
    Private Function validar_campos()
        If txt_cantidad.Text = "" Or txt_fecha.Text = "" Or txt_precio.Text = "" Or cmb_producto.SelectedValue = 0 Then
            MessageBox.Show("Hay campos sin completar.", "Gestión de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return respuesta_validacion._error
        End If
        Return respuesta_validacion._ok
    End Function

    'VALIDAR COMPRA
    Public Function validar_compra()
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql &= "SELECT * FROM compras WHERE id_compra = " & Me.txt_id_compra.Text
        tabla = SoporteBD.leerBD_simple(sql)

        If tabla.Rows.Count = 1 Then
            MessageBox.Show("El número de compra " & Me.txt_id_compra.Text & " ya está registrado.", "Gestión de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

    'ABRIR PRODUCTOS Y ACTUALIZAR EL COMBO DE PRODUCTOS CUANDO SE GUARDA
    Private Sub btn_nuevo_producto_Click(sender As Object, e As EventArgs) Handles btn_nuevo_producto.Click
        Using form As New FormProductos
            form.ShowDialog()
            If SoporteGUI.respuesta_ventana = Windows.Forms.DialogResult.OK Then
                SoporteGUI.cargar_combo(cmb_producto, SoporteBD.leerBD_simple("SELECT * FROM productos WHERE id_fabrica = " & Me.cmb_fabrica.SelectedValue), "id_producto", "descripcion")
            End If
        End Using
    End Sub

    Private Sub cmb_fabrica_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_fabrica.SelectionChangeCommitted
        If MessageBox.Show("¿La fábrica seleccionada es " & Me.cmb_fabrica.Text & "?", "Gestión de Compras", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.habilitar_detalle()
            Me.cmb_fabrica.Enabled = False
            Me.btn_nuevo_producto.Enabled = True
            Fabrica.id = Me.cmb_fabrica.SelectedValue
            Fabrica.nombre = Me.cmb_fabrica.Text
            SoporteGUI.cargar_combo(cmb_producto, SoporteBD.leerBD_simple("SELECT * FROM productos WHERE dado_de_baja = 0 AND id_fabrica = " & Me.cmb_fabrica.SelectedValue), "id_producto", "descripcion")
        End If
    End Sub

    Private Sub dgv_compras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_compras.CellContentClick

        Me.cmb_producto.SelectedValue = Me.dgv_compras.CurrentRow.Cells("col_id_producto").Value
        Me.txt_precio.Text = Me.dgv_compras.CurrentRow.Cells("col_precio").Value
        Me.txt_cantidad.Text = Me.dgv_compras.CurrentRow.Cells("col_cantidad").Value

        Me.cmb_producto.Enabled = False
        Me.btn_modificar.Enabled = True
        Me.btn_modificar.Visible = True
        Me.btn_agregar.Enabled = False
        Me.btn_eliminar.Enabled = True

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click

        If Math.Round(Convert.ToDouble(txt_precio.Text)) = 0 Then
            MessageBox.Show("No se admite el precio ingresado.", "Gestión de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else
            Me.dgv_compras.CurrentRow.Cells(2).Value = Me.txt_precio.Text
        End If

        If txt_cantidad.Text = 0 Then
            MessageBox.Show("No se admite la cantidad ingresada.", "Gestión de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else
            Me.dgv_compras.CurrentRow.Cells(1).Value = Me.txt_cantidad.Text
        End If

        Me.calcular_total()
        Me.cmb_producto.Enabled = True
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.Visible = False
        Me.btn_agregar.Enabled = True
        Me.btn_eliminar.Enabled = False
        Me.limpiar_campos_detalle()

    End Sub

    Private Sub deshabilitar_detalle()
        Me.cmb_producto.Enabled = False
        Me.txt_precio.Enabled = False
        Me.txt_cantidad.Enabled = False
        Me.dgv_compras.Enabled = False
        Me.btn_agregar.Enabled = False
    End Sub

    Private Sub habilitar_detalle()
        Me.cmb_producto.Enabled = True
        Me.txt_precio.Enabled = True
        Me.txt_cantidad.Enabled = True
        Me.dgv_compras.Enabled = True
        Me.btn_agregar.Enabled = True
    End Sub

    Private Sub txt_monto_TextChanged(sender As Object, e As EventArgs) Handles txt_monto.TextChanged
        If Convert.ToDouble(Me.txt_monto.Text) > 0 Then
            Me.btn_guardar.Enabled = True
        End If

        If Convert.ToDouble(Me.txt_monto.Text) = 0 Then
            Me.btn_guardar.Enabled = False
        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        If estado_actual_transaccion = estado_transaccion._iniciada Then
            If MessageBox.Show("¿Está seguro que desea cancelar la transacción actual?", "Gestión de Compras", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.Cancel Then
                Return
            End If
        End If
        estado_actual_transaccion = estado_transaccion._iniciada
        Me.limpiar_campos_compra()
        Me.deshabilitar_detalle()
        Me.cmb_fabrica.Enabled = True
        Me.txt_id_compra.Text = SoporteBD.autogenerar_codigo("AUTOGENERARCODIGO_compras")
        Me.txt_precio.Focus()
    End Sub

    Private Sub btn_guardar_Click_1(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If dgv_compras.Rows.Count > 0 Then
            SoporteBD.iniciar_conexion_con_transaccion()

            Dim sql_insertar_compra As String = ""
            sql_insertar_compra &= "INSERT INTO compras(id_compra,fecha_compra,hora_compra,monto) VALUES(" & txt_id_compra.Text
            sql_insertar_compra &= ", '" & txt_fecha.Text & "'"
            sql_insertar_compra &= ", '" & txt_hora.Text & "'"
            sql_insertar_compra &= "," & txt_monto.Text & ")"
            SoporteBD.escribirBD_transaccion(sql_insertar_compra)

            Dim sql_insertar_detalle As String = ""
            Dim tabla As New DataTable
            Dim sql As String = ""

            For c = 0 To Me.dgv_compras.Rows.Count - 1
                sql_insertar_detalle &= " INSERT INTO detalles_compras(id_compra,id_producto,cantidad,precio_unitario) VALUES (" & txt_id_compra.Text
                sql_insertar_detalle &= "," & Me.dgv_compras.Rows(c).Cells("col_id_producto").Value
                sql_insertar_detalle &= "," & Me.dgv_compras.Rows(c).Cells("col_cantidad").Value
                sql_insertar_detalle &= "," & Me.dgv_compras.Rows(c).Cells("col_precio").Value & ")"
                SoporteBD.escribirBD_transaccion(sql_insertar_detalle)
                sql_insertar_detalle = ""
            Next


            'ACTUALIZAR STOCK DE PRODUCTOS
            Dim tabla_productos As New DataTable
            Dim sql_actualizar_productos As String = ""
            For c = 0 To Me.dgv_compras.Rows.Count - 1
                sql_actualizar_productos &= "UPDATE productos SET stock = stock + " & Convert.ToInt32(Me.dgv_compras.Rows(c).Cells(1).Value)
                sql_actualizar_productos &= " WHERE id_producto = " & Me.dgv_compras.Rows(c).Cells(3).Value
            Next


            MessageBox.Show("Compra registrada.", "Gestión de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SoporteBD.cerrar_conexion_con_transaccion()
            estado_actual_transaccion = estado_transaccion._sin_iniciar
            Me.deshabilitar_campos()
        End If

        If dgv_compras.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para guardar.", "Gestión de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub


End Class
