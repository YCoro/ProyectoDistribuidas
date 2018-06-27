Public Class FrmSeleccionarProducto

    Private cProductoSeleccionado As Producto
    Public Property ProductoSeleccionado() As Producto
        Get
            Return cProductoSeleccionado
        End Get
        Set(ByVal value As Producto)
            cProductoSeleccionado = value
        End Set
    End Property


#Region "Procedimientos"

    ''' <summary>
    ''' Se encarga de consultar los registros hacia las bases de datos distribuidas, luego despliega los datos en el gridview.
    ''' </summary>
    Private Sub SubCargarProductos()

        DtGvProductos.Rows.Clear()

        ' Verifica si hay bases de datos configuradas
        If (Sistema.BDDistribuidas.FncContarBaseDatos() = 0) Then
            MessageBox.Show("No se han configurado bases de datos, no se pueden obtener los datos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        ' Consulta los registros
        Dim listaProductos As List(Of Producto) = Sistema.BDDistribuidas.FncObtenerProductos()
        If (listaProductos Is Nothing) Then
            MessageBox.Show("No se han podido obtener los registros de productos.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        If (listaProductos.Count = 0) Then
            MessageBox.Show("No existen productos registrados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        For Each cProducto As Producto In listaProductos
            With cProducto
                DtGvProductos.Rows.Add(.CodigoProducto, .Nombre, .Descripcion, .Precio)
            End With
        Next

    End Sub


#End Region

#Region "Eventos"
    Private Sub FrmSeleccionarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SubCargarProductos()
    End Sub


    Private Sub BtnAgregarProducto_Click(sender As Object, e As EventArgs) Handles BtnAgregarProducto.Click
        If (DtGvProductos.CurrentRow IsNot Nothing) Then

            If (Not IsNumeric(TxtCantidad.Text)) Then
                MessageBox.Show("No se ha ingresado un valor válido en el campo cantidad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim intCantidad As Integer = Convert.ToInt32(TxtCantidad.Text)

            If (intCantidad <= 0) Then
                MessageBox.Show("Se debe ingresar un valor positivo en la cantidad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            cProductoSeleccionado = New Producto()
            cProductoSeleccionado.Cantidad = intCantidad
            cProductoSeleccionado.CodigoProducto = DtGvProductos.CurrentRow.Cells("CodigoProducto").Value
            cProductoSeleccionado.Nombre = DtGvProductos.CurrentRow.Cells("Nombre").Value
            cProductoSeleccionado.Descripcion = DtGvProductos.CurrentRow.Cells("Descripcion").Value
            cProductoSeleccionado.Precio = DtGvProductos.CurrentRow.Cells("Precio").Value

            Me.Close()

        Else
            MessageBox.Show("Debe seleccionar un producto", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

#End Region




End Class