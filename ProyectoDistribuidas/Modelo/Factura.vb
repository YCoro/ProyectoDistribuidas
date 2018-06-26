Public Class Factura

    Private intCodigoFactura As Integer
    Public Property CodigoFactura() As Integer
        Get
            Return intCodigoFactura
        End Get
        Set(ByVal value As Integer)
            intCodigoFactura = value
        End Set
    End Property


    Private intNitCliente As Integer
    Public Property NitCliente() As Integer
        Get
            Return intNitCliente
        End Get
        Set(ByVal value As Integer)
            intNitCliente = value
        End Set
    End Property


    Private strNombreCliente As String
    Public Property NombreCliente() As String
        Get
            Return strNombreCliente
        End Get
        Set(ByVal value As String)
            strNombreCliente = value
        End Set
    End Property

    Private dateFechaHora As DateTime
    Public Property FechaHora() As DateTime
        Get
            Return dateFechaHora
        End Get
        Set(ByVal value As DateTime)
            dateFechaHora = value
        End Set
    End Property


    Private listaDetalleFactura As List(Of DetalleFactura)
    Public Property DetalleFactura() As List(Of DetalleFactura)
        Get
            Return listaDetalleFactura
        End Get
        Set(ByVal value As List(Of DetalleFactura))
            listaDetalleFactura = value
        End Set
    End Property

End Class
