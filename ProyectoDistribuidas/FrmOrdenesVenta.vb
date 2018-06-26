Public Class FrmOrdenesVenta

#Region "Procedimientos"

    ''' <summary>
    ''' Agrega una nueva configuración de base de datos al sistema.
    ''' </summary>
    Private Sub SubAgregarConfiguracion()
        If (TxtHost.Text.Trim.Length = 0) Then
            MessageBox.Show("No se ha ingresado un valor adecuado para HOST", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If (TxtUsuario.Text.Trim.Length = 0) Then
            MessageBox.Show("No se ha ingresado un valor adecuado para USUARIO", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If (TxtContrasena.Text.Trim.Length = 0) Then
            MessageBox.Show("No se ha ingresado un valor adecuado para CONTRASEÑA", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If (TxtBaseDatos.Text.Trim.Length = 0) Then
            MessageBox.Show("No se ha ingresado un valor adecuado para BASE DATOS", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim cBaseDatos As New DataBaseConection(TxtHost.Text, TxtUsuario.Text, TxtContrasena.Text, TxtBaseDatos.Text)
        Sistema.BDDistribuidas.SubAgregarNodo(cBaseDatos)

        SubDesplegarConfiguraciones()

    End Sub



    ''' <summary>
    ''' Despliega las configuraciones guardadas en el sistema en el control gridview
    ''' </summary>
    Private Sub SubDesplegarConfiguraciones()
        DtGvConfiguraciones.Rows.Clear()

        For Each cBaseDatos As DataBaseConection In Sistema.BDDistribuidas.FncObtenerBaseDatos()
            With cBaseDatos
                DtGvConfiguraciones.Rows.Add(.CodigoBaseDatos, .Host, .User, .Password, .Database)
            End With
        Next

    End Sub

    ''' <summary>
    ''' Limpia los controles donde se ingresan los datos de la configuración
    ''' </summary>
    Private Sub SubLimpiarControles()
        TxtHost.Text = String.Empty
        TxtUsuario.Text = String.Empty
        TxtContrasena.Text = String.Empty
        TxtBaseDatos.Text = String.Empty
    End Sub


#End Region


#Region "Eventos"


    Private Sub BtnAgregarConfiguracion_Click_1(sender As Object, e As EventArgs) Handles BtnAgregarConfiguracion.Click
        SubAgregarConfiguracion()
        SubLimpiarControles()
    End Sub

    Private Sub BtnEliminarConfiguracion_Click(sender As Object, e As EventArgs) Handles BtnEliminarConfiguracion.Click
        If (DtGvConfiguraciones.CurrentRow Is Nothing) Then
            MessageBox.Show("No se ha ingresado un valor adecuado para BASE DATOS", Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Sistema.BDDistribuidas.SubEliminarNodo(DtGvConfiguraciones.CurrentRow.Cells("Codigo").Value)

        SubDesplegarConfiguraciones()

    End Sub


    Private Sub FrmOrdenesVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SubDesplegarConfiguraciones()
    End Sub


    Private Sub BtnAgregarProducto_Click(sender As Object, e As EventArgs) Handles BtnAgregarProducto.Click
        Dim frmSeleccionarProducto As New FrmSeleccionarProducto()
        frmSeleccionarProducto.ShowDialog()
    End Sub


    Private Sub BtnRegistrarVenta_MouseClick(sender As Object, e As MouseEventArgs) Handles BtnRegistrarVenta.MouseClick

        Dim cFactura As New Factura()
        cFactura.NombreCliente = "Yadder Aceituno"
        cFactura.NitCliente = 92471560

        Dim listaDetalleFactura As New List(Of DetalleFactura)

        Dim cDetalleFactura As New DetalleFactura()
        cDetalleFactura.CodigoProducto = 1
        cDetalleFactura.Cantidad = 5
        cDetalleFactura.Precio = 34.5
        listaDetalleFactura.Add(cDetalleFactura)

        cDetalleFactura = New DetalleFactura()
        cDetalleFactura.CodigoProducto = 2
        cDetalleFactura.Cantidad = 4
        cDetalleFactura.Precio = 11
        listaDetalleFactura.Add(cDetalleFactura)

        cFactura.DetalleFactura = listaDetalleFactura

        Sistema.BDDistribuidas.FncRegistrarFactura(cFactura)


    End Sub



#End Region

End Class
