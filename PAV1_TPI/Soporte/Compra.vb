Public Class Compra
    Dim numero_compra As Integer
    Dim descripcion_articulo As String
    Dim numero_articulo As Integer

    Public Property NumeroCompra
        Get
            numero_compra = numero_compra + 1
            Return numero_compra
        End Get
        Set(value)
            numero_compra = value
        End Set
    End Property

    Public Property DescripcionArticuloSeleccionado
        Get
            Return descripcion_articulo
        End Get
        Set(value)
            descripcion_articulo = value
        End Set
    End Property

    Public Property NumeroArticuloSeleccionado
        Get
            Return numero_articulo
        End Get
        Set(value)
            numero_articulo = value
        End Set
    End Property
End Class
