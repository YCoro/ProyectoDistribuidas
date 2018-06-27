Public Class Sistema

    Public Shared BDDistribuidas As New DistributedDataBaseAdmin()

    Public Shared Sub SubRegistrarOperacion(ByVal strHost As String, ByVal strBaseDatos As String, ByVal strOperacion As String)
        Dim file As New System.IO.StreamWriter("transacciones.csv", True)
        file.WriteLine(System.DateTime.Now.ToString() + ", " + strHost + ", " + strBaseDatos + ", " + strOperacion)
        file.Close()
    End Sub

End Class
