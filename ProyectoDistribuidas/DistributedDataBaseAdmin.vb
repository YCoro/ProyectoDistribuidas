Imports Npgsql

Public Class DistributedDataBaseAdmin

    Private listaBaseDatos As New List(Of DataBaseConection)
    Private cBaseDatosDisponible As DataBaseConection
    Private intCodigoActual As Integer = 0
    Private blnTransaccionCorrecta As Boolean = False

#Region "Estructuras"

    Private Structure pgConexion
        Public blnExitoso As Boolean
        Public pgConnection As NpgsqlConnection
        Public pgTransaction As NpgsqlTransaction
    End Structure


#End Region

#Region "Funciones"

    ''' <summary>
    ''' Devuelve cuantas bases de datos estan guardadas en memoria
    ''' </summary>
    ''' <returns></returns>
    Public Function FncContarBaseDatos()
        Return listaBaseDatos.Count
    End Function


    ''' <summary>
    ''' Obtiene el listado de bases de datos
    ''' </summary>
    ''' <returns></returns>
    Public Function FncObtenerBaseDatos() As List(Of DataBaseConection)
        Return listaBaseDatos
    End Function


#End Region


#Region "Procedimientos"

    ''' <summary>
    ''' Agrega una conexiòn de base de datos a la lista de bases de datos
    ''' </summary>
    ''' <param name="cNodoDB"></param>
    Public Sub SubAgregarNodo(ByRef cNodoDB As DataBaseConection)
        cNodoDB.CodigoBaseDatos = intCodigoActual + 1
        listaBaseDatos.Add(cNodoDB)
        intCodigoActual += 1
    End Sub



    ''' <summary>
    ''' Elimina una conexion de base de datos de la lista de bases de datos
    ''' </summary>
    ''' <param name="dbNode"></param>
    Public Sub SubEliminarNodo(intCodigoBaseDatos As Integer)
        For indice As Integer = 0 To listaBaseDatos.Count - 1
            If (intCodigoBaseDatos = listaBaseDatos(indice).CodigoBaseDatos) Then
                listaBaseDatos.RemoveAt(indice)
                Return
            End If
        Next
    End Sub



    ''' <summary>
    ''' Consulta los productos registrados de la base de datos que se encuentre disponible
    ''' </summary>
    Public Function FncObtenerProductos() As List(Of Producto)
        Dim cBaseDatos = cBaseDatosDisponible
        Dim listaProductos As List(Of Producto)
        Dim intIndice = 0

        If (cBaseDatos IsNot Nothing) Then
            GoTo EjecucionQuery
        End If

SeleccionarOtraDB:

        If (intIndice < listaBaseDatos.Count) Then
            cBaseDatos = listaBaseDatos(intIndice)
            intIndice += 1
        Else
            Return Nothing
        End If


EjecucionQuery:
        Try
            listaProductos = cBaseDatos.FncObtenerProductos()
        Catch ex As Exception
            GoTo SeleccionarOtraDB
        End Try

        Return listaProductos
    End Function



    ''' <summary>
    ''' Registra encabezado y factura en las bases de datos distribuidas
    ''' </summary>
    ''' <param name="cFactura"></param>
    ''' <returns></returns>
    Public Function FncRegistrarFactura(ByVal cFactura As Factura) As Boolean
        blnTransaccionCorrecta = True
        Dim transaccionDistribuida(listaBaseDatos.Count - 1) As Task(Of pgConexion)
        Dim indice As Integer = 0

        '' Ejecuta hilos para operar las transacciones en cada base de datos
        For Each cBaseDatos As DataBaseConection In listaBaseDatos
            transaccionDistribuida(indice) = Task(Of pgConexion).Factory.StartNew(Function() FncRegistrarFacturaTask(cFactura, cBaseDatos))
            indice += 1
        Next

        '' Espera el resultado de todas las transacciones
        Task.WaitAll(transaccionDistribuida)

        Dim blnTransaccionesExitosas As Boolean = True

        '' Verifica que todos hayan devuelto el objeto transacción
        For indice = 0 To transaccionDistribuida.Count - 1
            Dim structConexion As pgConexion = transaccionDistribuida(indice).Result

            If (structConexion.pgConnection Is Nothing Or structConexion.pgTransaction Is Nothing) Then
                blnTransaccionesExitosas = False
                Exit For
            End If
        Next


        '' Commit o RollBack
        For indice = 0 To transaccionDistribuida.Count - 1
            Dim structConexion As pgConexion = transaccionDistribuida(indice).Result

            If (blnTransaccionesExitosas And structConexion.pgTransaction IsNot Nothing) Then
                structConexion.pgTransaction.Commit()
            ElseIf structConexion.pgTransaction IsNot Nothing Then
                structConexion.pgTransaction.Rollback()
            End If

            If (structConexion.pgConnection IsNot Nothing) Then
                structConexion.pgConnection.Close()
            End If

        Next

        Return blnTransaccionesExitosas
    End Function



    ''' <summary>
    ''' Abre la conexión con la base de datos, opera la transacción y devuelve el objeto que controla la transacción
    ''' </summary>
    ''' <param name="cFactura"></param>
    ''' <param name="cBaseDatos"></param>
    ''' <returns></returns>
    Private Function FncRegistrarFacturaTask(ByRef cFactura As Factura, ByRef cBaseDatos As DataBaseConection) As pgConexion
        Dim pgTransaccion As NpgsqlTransaction
        Dim structConexion As New pgConexion
        structConexion.blnExitoso = False
        Dim pgConnection = cBaseDatos.FncObtenerConexion()

        structConexion.pgConnection = pgConnection

        ' Validar que se abre la conexión
        If (Not cBaseDatos.FncAbrirConexion(pgConnection)) Then
            Return structConexion
        End If

        ' Se inicia la transaccion y 
        Try
            pgTransaccion = cBaseDatos.FncIniciarTransaccion(pgConnection)
            structConexion.pgTransaction = pgTransaccion
            If Not cBaseDatos.FncRegistrarFactura(cFactura, pgConnection) Then
                Return structConexion
            End If
        Catch ex As Exception
            Return structConexion
        End Try

        structConexion.blnExitoso = True
        Return structConexion
    End Function

#End Region


End Class


