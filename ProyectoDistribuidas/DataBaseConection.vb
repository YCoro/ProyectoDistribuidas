Imports Npgsql

Public Class DataBaseConection

    Private strHost As String = String.Empty
    Public Property Host() As String
        Get
            Return strHost
        End Get
        Set(ByVal value As String)
            strHost = value
        End Set
    End Property

    Private strUser As String = String.Empty
    Public Property User() As String
        Get
            Return strUser
        End Get
        Set(ByVal value As String)
            strUser = value
        End Set
    End Property

    Private strPassword As String = String.Empty
    Public Property Password() As String
        Get
            Return strPassword
        End Get
        Set(ByVal value As String)
            strPassword = value
        End Set
    End Property

    Private strDatabase As String = String.Empty
    Public Property Database() As String
        Get
            Return strDatabase
        End Get
        Set(ByVal value As String)
            strDatabase = value
        End Set
    End Property

    Private strCadenaConexion As String
    Public Property CadenaConexion() As String
        Get
            Return strCadenaConexion
        End Get
        Set(ByVal value As String)
            strCadenaConexion = value
        End Set
    End Property

    Private intCodigoBaseDatos As Integer
    Public Property CodigoBaseDatos() As Integer
        Get
            Return intCodigoBaseDatos
        End Get
        Set(ByVal value As Integer)
            intCodigoBaseDatos = value
        End Set
    End Property

    Public Sub New(ByVal strHost As String, ByVal strUser As String, ByVal strPassword As String, ByVal strDatabase As String)

        Me.Host = strHost
        Me.User = strUser
        Me.Password = strPassword
        Me.Database = strDatabase

        SubValidarDatosConexion()

        Me.CadenaConexion = FncObtenerCadenaConexion()

    End Sub


    ''' <summary>
    ''' Valida que los campos para la cadena de conexión son correctos
    ''' </summary>
    Private Sub SubValidarDatosConexion()

        If (Host = String.Empty) Then
            Throw New Exception("No se ha especificado un host")
        End If

        If (User = String.Empty) Then
            Throw New Exception("No se ha especificado un usuario")
        End If

        If (Password = String.Empty) Then
            Throw New Exception("No se ha especificado una contraseña")
        End If

        If (Database = String.Empty) Then
            Throw New Exception("No se ha especificado una base de datos")
        End If

    End Sub


    ''' <summary>
    ''' Obtiene el valor de la cadena de conexión
    ''' </summary>
    ''' <returns></returns>
    Private Function FncObtenerCadenaConexion()
        Return "Host=" + Host + ";Username=" + User + ";Password=" + Password + ";Database=" + Database
    End Function


    ''' <summary>
    ''' Obtiene el listado de productos registrados en la base de datos
    ''' </summary>
    ''' <returns></returns>
    Public Function FncObtenerProductos() As List(Of Producto)

        Dim pgConnection As New NpgsqlConnection(CadenaConexion)
        Dim pgCommand As New NpgsqlCommand()
        Dim listaProductos As New List(Of Producto)

        Try
            pgConnection.Open()
        Catch ex As Exception
            Throw ex
        End Try


        Try
            pgCommand.Connection = pgConnection
            pgCommand.CommandText = "SELECT ""CodigoProducto"", ""Nombre"", ""Descripcion"", ""Precio"" FROM ""Producto"""

            Dim reader As NpgsqlDataReader = pgCommand.ExecuteReader()
            While reader.Read()
                Dim modeloProducto As New Producto()
                modeloProducto.CodigoProducto = reader.GetInt32(0)
                modeloProducto.Nombre = reader.GetString(1)
                modeloProducto.Descripcion = reader.GetString(2)
                modeloProducto.Precio = reader.GetDouble(3)

                listaProductos.Add(modeloProducto)
            End While
        Catch ex As Exception
            pgConnection.Close()
            Throw ex

        End Try

        Return listaProductos

    End Function

    Public Function FncObtenerConexion() As NpgsqlConnection
        Return New NpgsqlConnection(CadenaConexion)
    End Function

    Public Function FncAbrirConexion(ByRef connection As NpgsqlConnection) As Boolean
        Try
            connection.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function FncCerrarConexion(ByRef connection As NpgsqlConnection) As Boolean
        connection.Close()
        Return True
    End Function

    Public Function FncIniciarTransaccion(ByRef connection As NpgsqlConnection) As NpgsqlTransaction
        Return connection.BeginTransaction()
    End Function


    Public Function FncRevertirTransaccion(ByRef transaccion As NpgsqlTransaction) As Boolean
        transaccion.Rollback()
        Return True
    End Function



    ''' <summary>
    ''' Ejecuta la transacción para registrar encabezado y detalle de una factura
    ''' </summary>
    ''' <param name="cFactura">Objeto con informacìón de la factura</param>
    ''' <param name="connection">Objeto de conexión</param>
    ''' <returns></returns>
    Public Function FncRegistrarFactura(ByRef cFactura As Factura, ByRef connection As NpgsqlConnection) As Boolean

        Dim pgCommand As New NpgsqlCommand()

        Try
            '' Registra encabezado de la factura
            pgCommand.Connection = connection
            pgCommand.CommandText = "INSERT INTO ""Factura""(""NitCliente"", ""NombreCliente"") VALUES(@Nit, @Nombre) RETURNING ""CodigoFactura"""
            pgCommand.Parameters.AddWithValue("Nit", cFactura.NitCliente)
            pgCommand.Parameters.AddWithValue("Nombre", cFactura.NombreCliente)
            cFactura.CodigoFactura = pgCommand.ExecuteScalar()


            '' Registra detalle de la factura
            For Each cDetalleFactura As DetalleFactura In cFactura.DetalleFactura
                pgCommand.CommandText = "INSERT INTO ""DetalleFactura""(""CodigoFactura"", ""CodigoProducto"", ""Precio"", ""Cantidad"") VALUES (@Factura, @Producto, @Precio, @Cantidad)"
                pgCommand.Parameters.Clear()
                pgCommand.Parameters.AddWithValue("Factura", cFactura.CodigoFactura)
                pgCommand.Parameters.AddWithValue("Producto", cDetalleFactura.CodigoProducto)
                pgCommand.Parameters.AddWithValue("Precio", cDetalleFactura.Precio)
                pgCommand.Parameters.AddWithValue("Cantidad", cDetalleFactura.Cantidad)
                pgCommand.ExecuteNonQuery()

            Next

        Catch ex As Exception

            Return False

        End Try

        Return True

    End Function

End Class
