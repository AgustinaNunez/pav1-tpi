Public Class Compra
    Public Shared descripcion_articulo As String
    Public Shared numero_articulo As Integer

    Public Shared Property DescripcionArticuloSeleccionado
        Get
            Return descripcion_articulo
        End Get
        Set(value)
            descripcion_articulo = value
        End Set
    End Property

    Public Shared Property NumeroArticuloSeleccionado
        Get
            Return numero_articulo
        End Get
        Set(value)
            numero_articulo = value
        End Set
    End Property
End Class
