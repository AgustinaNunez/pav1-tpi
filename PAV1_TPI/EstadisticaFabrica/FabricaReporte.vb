Public Class Fabrica
    Friend WithEvents fabricaBindingSource As BindingSource
    Private components As System.ComponentModel.IContainer
    Friend WithEvents DatosFabrica As DatosFabrica
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer

    Private Sub EstadisticaFabrica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub cargar_grafico()
        Dim sql As String = ""

        If cmb_temporadas.Text = "Otoño-Invierno" Then
            'sql &= " SELECT f.nombre as 'nombre_fabrica', count(*) as 'valor' "
            'sql &= " FROM fabricas f "
            'sql &= " JOIN productos p on p.id_fabrica = f.id_fabrica "
            'sql &= " JOIN detalle_ventas dv on p.id_producto = dv.id_producto "
            'sql &= " JOIN ventas v on dv.id_venta = v.id_venta "
            'sql &= " WHERE v.fecha_venta BETWEEN '21/3/" & Me.cmb_año.Text & "' AND '21/9/" & Me.cmb_año.Text & "'"
            'sql &= " GROUP BY f.nombre "
            'sql &= " ORDER BY valor "

            sql &= " SELECT f.nombre as 'nombre_fabrica', count(*) as 'valor' "
            sql &= " FROM fabricas f "
            sql &= " JOIN productos p on p.id_fabrica = f.id_fabrica"
            sql &= " JOIN detalle_ventas dv on p.id_producto = dv.id_producto "
            sql &= " JOIN ventas v on dv.id_venta = v.id_venta "
            sql &= " WHERE v.fecha_venta BETWEEN '21/03/" & Me.cmb_año.Text & "' AND '21/09/" & Me.cmb_año.Text & "'"
            sql &= " GROUP BY f.nombre "
            sql &= " ORDER BY valor"

            fabricaBindingSource.DataSource = SoporteBD.leerBD_simple(sql)

            Me.ReportViewer1.RefreshReport()
        End If

        If cmb_temporadas.Text = "Primavera-Verano" Then
            'sql &= " SELECT f.nombre as 'nombre_fabrica', count(*) as 'valor' "
            'sql &= " FROM fabricas f "
            'sql &= " JOIN productos p on p.id_fabrica = f.id_fabrica "
            'sql &= " JOIN detalle_ventas dv on p.id_producto = dv.id_producto "
            'sql &= " JOIN ventas v on dv.id_venta = v.id_venta "
            'sql &= " WHERE v.fecha_venta BETWEEN '21/3/" & Me.cmb_año.Text & "' AND '21/9/" & Me.cmb_año.Text & "'"
            'sql &= " GROUP BY f.nombre "
            'sql &= " ORDER BY valor "

            sql &= " SELECT f.nombre as 'nombre_fabrica', count(*) as 'valor' "
            sql &= " FROM fabricas f "
            sql &= " JOIN productos p on p.id_fabrica = f.id_fabrica"
            sql &= " JOIN detalle_ventas dv on p.id_producto = dv.id_producto "
            sql &= " JOIN ventas v on dv.id_venta = v.id_venta "
            sql &= " WHERE v.fecha_venta BETWEEN '21/09/" & Me.cmb_año.Text & "' AND '21/03/" & Me.cmb_año.Text & "'"
            sql &= " GROUP BY f.nombre "
            sql &= " ORDER BY valor"

            fabricaBindingSource.DataSource = SoporteBD.leerBD_simple(sql)

            Me.ReportViewer1.RefreshReport()
        End If

    End Sub

    Private Sub cmb_año_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_año.SelectedIndexChanged
        cargar_grafico()
    End Sub

  