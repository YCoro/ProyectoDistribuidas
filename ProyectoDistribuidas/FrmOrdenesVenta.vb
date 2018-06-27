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



    ''' <summary>
    ''' Agrega un nuevo producto al control grid de productos para la orden de venta. Primero verifica si ya existe
    ''' un producto con el mismo código, de ser asi, solo suma la cantidad.
    ''' </summary>
    ''' <param name="cNuevoProducto"></param>
    Private Sub SubAgregarProducto(cNuevoProducto As Producto)
        Dim cRegistro As DataGridViewRow = Nothing

        For Each DtGvRow As DataGridViewRow In DtGvProductos.Rows
            Dim intCodigoProducto As Integer = DtGvRow.Cells("CodigoProducto").Value
            If (intCodigoProducto = cNuevoProducto.CodigoProducto) Then
                cRegistro = DtGvRow
                Exit For
            End If
        Next

        If (cRegistro Is Nothing) Then
            DtGvProductos.Rows.Add(cNuevoProducto.CodigoProducto, cNuevoProducto.Nombre, cNuevoProducto.Cantidad, cNuevoProducto.Precio, cNuevoProducto.Cantidad * cNuevoProducto.Precio)
        Else
            cRegistro.Cells("CantidadProducto").Value = cRegistro.Cells("CantidadProducto").Value + cNuevoProducto.Cantidad
            cRegistro.Cells("Subtotal").Value = cRegistro.Cells("CantidadProducto").Value * cRegistro.Cells("PrecioProducto").Value
        End If

    End Sub



    ''' <summary>
    ''' Se encarga de eliminar el registro seleccionado en el data grid de productos.
    ''' </summary>
    Private Sub SubEliminarProductoSeleccionado()
        Dim intCodigoProducto = DtGvProductos.CurrentRow.Cells("CodigoProducto").Value

        For indice As Integer = 0 To DtGvProductos.Rows.Count - 1
            If (DtGvProductos.Rows(indice).Cells("CodigoProducto").Value = intCodigoProducto) Then
                DtGvProductos.Rows.RemoveAt(indice)
                Exit For
            End If
        Next
    End Sub



    ''' <summary>
    ''' Suma los subtotales del grid de productos y los muestra en el textbox correspondiente.
    ''' </summary>
    Private Sub SubMostrarTotal()
        Dim dblTotal As Double = 0
        For Each DtGvRow As DataGridViewRow In DtGvProductos.Rows
            dblTotal += DtGvRow.Cells("Subtotal").Value
        Next

        TxtTotal.Text = dblTotal.ToString()
    End Sub


    ''' <summary>
    ''' Obtiene los datos de formulario y realiza el intento de registro en las bases de datos configuradas
    ''' </summary>
    Private Sub SubRegistrarVenta()

        If (TxtCliente.Text.Trim.Length = 0) Then
            MessageBox.Show("Debe proporcionar un nombre de cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If (TxtNit.Text.Trim.Length = 0) Then
            MessageBox.Show("Debe proporcionar un NIT", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If (DtGvProductos.Rows.Count = 0) Then
            MessageBox.Show("Debe agregar al menos un producto", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim cFactura As New Factura()
        cFactura.NombreCliente = TxtCliente.Text
        cFactura.NitCliente = Convert.ToInt32(TxtNit.Text)



        ' Obtiene el detalle
        Dim listaDetalleFactura As New List(Of DetalleFactura)

        For Each DtGvRow As DataGridViewRow In DtGvProductos.Rows
            Dim cDetalleFactura As New DetalleFactura()
            cDetalleFactura.CodigoProducto = DtGvRow.Cells("CodigoProducto").Value
            cDetalleFactura.Cantidad = DtGvRow.Cells("CantidadProducto").Value
            cDetalleFactura.Precio = DtGvRow.Cells("PrecioProducto").Value
            listaDetalleFactura.Add(cDetalleFactura)
        Next

        cFactura.DetalleFactura = listaDetalleFactura

        If (Sistema.BDDistribuidas.FncRegistrarFactura(cFactura)) Then
            MessageBox.Show("Registro completo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            SubLimpiarFormulario()
        Else
            MessageBox.Show("No se pudo completar la operación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    ''' <summary>
    ''' Limpia los controles de formulario asociados a la venta
    ''' </summary>
    Private Sub SubLimpiarFormulario()
        DtGvProductos.Rows.Clear()
        TxtCliente.Text = String.Empty
        TxtNit.Text = String.Empty
        TxtTotal.Text = "0"
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

        If (frmSeleccionarProducto.ProductoSeleccionado IsNot Nothing) Then
            SubAgregarProducto(frmSeleccionarProducto.ProductoSeleccionado)
            SubMostrarTotal()
        End If


    End Sub


    Private Sub BtnRegistrarVenta_MouseClick(sender As Object, e As MouseEventArgs) Handles BtnRegistrarVenta.MouseClick

        SubRegistrarVenta()

    End Sub

    Private Sub BtnEliminarProducto_Click(sender As Object, e As EventArgs) Handles BtnEliminarProducto.Click
        If (DtGvProductos.CurrentRow Is Nothing) Then
            MessageBox.Show("Debe seleccionar la linea de producto a eliminar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        SubEliminarProductoSeleccionado()
        SubMostrarTotal()
    End Sub



#End Region

End Class
