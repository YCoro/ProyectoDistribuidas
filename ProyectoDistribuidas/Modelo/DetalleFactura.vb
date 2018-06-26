Public Class DetalleFactura

    Private intCodigoFactura As Integer
    Public Property CodigoFactura() As Integer
        Get
            Return intCodigoFactura
        End Get
        Set(ByVal value As Integer)
            intCodigoFactura = value
        End Set
    End Property

    Private intCodigoProducto As Integer
    Public Property CodigoProducto() As Integer
        Get
            Return intCodigoProducto
        End Get
        Set(ByVal value As Integer)
            intCodigoProducto = value
        End Set
    End Property

    Private dblPrecio As Double
    Public Property Precio() As Double
        Get
            Return dblPrecio
        End Get
        Set(ByVal value As Double)
            dblPrecio = value
        End Set
    End Property

    Private intCantidad As Integer
    Public Property Cantidad() As Integer
        Get
            Return intCantidad
        End Get
        Set(ByVal value As Integer)
            intCantidad = value
        End Set
    End Property

End Class
