Public Class Producto

    Private intCodigoProducto As Integer
    Public Property CodigoProducto() As Integer
        Get
            Return intCodigoProducto
        End Get
        Set(ByVal value As Integer)
            intCodigoProducto = value
        End Set
    End Property

    Private strNombre As String
    Public Property Nombre() As String
        Get
            Return strNombre
        End Get
        Set(ByVal value As String)
            strNombre = value
        End Set
    End Property

    Private strDescripcion As String
    Public Property Descripcion() As String
        Get
            Return strDescripcion
        End Get
        Set(ByVal value As String)
            strDescripcion = value
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
