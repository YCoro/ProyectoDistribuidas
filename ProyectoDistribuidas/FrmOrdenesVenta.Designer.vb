<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrdenesVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnRegistrarVenta = New System.Windows.Forms.Button()
        Me.TxtBoxTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBoxCliente = New System.Windows.Forms.TextBox()
        Me.TxtBoxNit = New System.Windows.Forms.TextBox()
        Me.Productos = New System.Windows.Forms.GroupBox()
        Me.BtnEliminarProducto = New System.Windows.Forms.Button()
        Me.BtnAgregarProducto = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnEliminarConfiguracion = New System.Windows.Forms.Button()
        Me.BtnAgregarConfiguracion = New System.Windows.Forms.Button()
        Me.TxtBaseDatos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtHost = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DtGvConfiguraciones = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Host = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contrasena = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaseDatos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Productos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DtGvConfiguraciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(629, 459)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Productos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(621, 433)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ventas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnRegistrarVenta)
        Me.GroupBox1.Controls.Add(Me.TxtBoxTotal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtBoxCliente)
        Me.GroupBox1.Controls.Add(Me.TxtBoxNit)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 123)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encabezado Factura"
        '
        'BtnRegistrarVenta
        '
        Me.BtnRegistrarVenta.Location = New System.Drawing.Point(492, 84)
        Me.BtnRegistrarVenta.Name = "BtnRegistrarVenta"
        Me.BtnRegistrarVenta.Size = New System.Drawing.Size(116, 39)
        Me.BtnRegistrarVenta.TabIndex = 3
        Me.BtnRegistrarVenta.Text = "Registrar Venta"
        Me.BtnRegistrarVenta.UseVisualStyleBackColor = True
        '
        'TxtBoxTotal
        '
        Me.TxtBoxTotal.Enabled = False
        Me.TxtBoxTotal.Location = New System.Drawing.Point(10, 97)
        Me.TxtBoxTotal.Name = "TxtBoxTotal"
        Me.TxtBoxTotal.Size = New System.Drawing.Size(209, 20)
        Me.TxtBoxTotal.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(318, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NIT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre Cliente"
        '
        'TxtBoxCliente
        '
        Me.TxtBoxCliente.Location = New System.Drawing.Point(10, 42)
        Me.TxtBoxCliente.Name = "TxtBoxCliente"
        Me.TxtBoxCliente.Size = New System.Drawing.Size(305, 20)
        Me.TxtBoxCliente.TabIndex = 0
        '
        'TxtBoxNit
        '
        Me.TxtBoxNit.Location = New System.Drawing.Point(321, 42)
        Me.TxtBoxNit.Name = "TxtBoxNit"
        Me.TxtBoxNit.Size = New System.Drawing.Size(209, 20)
        Me.TxtBoxNit.TabIndex = 1
        '
        'Productos
        '
        Me.Productos.Controls.Add(Me.BtnEliminarProducto)
        Me.Productos.Controls.Add(Me.BtnAgregarProducto)
        Me.Productos.Controls.Add(Me.DataGridView1)
        Me.Productos.Location = New System.Drawing.Point(4, 129)
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(614, 301)
        Me.Productos.TabIndex = 4
        Me.Productos.TabStop = False
        Me.Productos.Text = "Productos"
        '
        'BtnEliminarProducto
        '
        Me.BtnEliminarProducto.Location = New System.Drawing.Point(495, 255)
        Me.BtnEliminarProducto.Name = "BtnEliminarProducto"
        Me.BtnEliminarProducto.Size = New System.Drawing.Size(116, 39)
        Me.BtnEliminarProducto.TabIndex = 2
        Me.BtnEliminarProducto.Text = "Eliminar"
        Me.BtnEliminarProducto.UseVisualStyleBackColor = True
        '
        'BtnAgregarProducto
        '
        Me.BtnAgregarProducto.Location = New System.Drawing.Point(495, 210)
        Me.BtnAgregarProducto.Name = "BtnAgregarProducto"
        Me.BtnAgregarProducto.Size = New System.Drawing.Size(116, 39)
        Me.BtnAgregarProducto.TabIndex = 1
        Me.BtnAgregarProducto.Text = "Agregar"
        Me.BtnAgregarProducto.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoProducto, Me.NombreProducto, Me.CantidadProducto, Me.PrecioProducto, Me.Subtotal})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(489, 275)
        Me.DataGridView1.TabIndex = 0
        '
        'CodigoProducto
        '
        Me.CodigoProducto.HeaderText = "CodigoProducto"
        Me.CodigoProducto.Name = "CodigoProducto"
        Me.CodigoProducto.ReadOnly = True
        Me.CodigoProducto.Visible = False
        '
        'NombreProducto
        '
        Me.NombreProducto.HeaderText = "Producto"
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.ReadOnly = True
        Me.NombreProducto.Width = 150
        '
        'CantidadProducto
        '
        Me.CantidadProducto.HeaderText = "Cantidad"
        Me.CantidadProducto.Name = "CantidadProducto"
        Me.CantidadProducto.ReadOnly = True
        Me.CantidadProducto.Width = 75
        '
        'PrecioProducto
        '
        Me.PrecioProducto.HeaderText = "Precio"
        Me.PrecioProducto.Name = "PrecioProducto"
        Me.PrecioProducto.ReadOnly = True
        Me.PrecioProducto.Width = 75
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Width = 75
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnEliminarConfiguracion)
        Me.TabPage2.Controls.Add(Me.BtnAgregarConfiguracion)
        Me.TabPage2.Controls.Add(Me.TxtBaseDatos)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TxtContrasena)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.TxtUsuario)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.TxtHost)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(621, 433)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Configuración"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnEliminarConfiguracion
        '
        Me.BtnEliminarConfiguracion.Location = New System.Drawing.Point(426, 59)
        Me.BtnEliminarConfiguracion.Name = "BtnEliminarConfiguracion"
        Me.BtnEliminarConfiguracion.Size = New System.Drawing.Size(194, 48)
        Me.BtnEliminarConfiguracion.TabIndex = 21
        Me.BtnEliminarConfiguracion.Text = "Eliminar"
        Me.BtnEliminarConfiguracion.UseVisualStyleBackColor = True
        '
        'BtnAgregarConfiguracion
        '
        Me.BtnAgregarConfiguracion.Location = New System.Drawing.Point(426, 7)
        Me.BtnAgregarConfiguracion.Name = "BtnAgregarConfiguracion"
        Me.BtnAgregarConfiguracion.Size = New System.Drawing.Size(194, 48)
        Me.BtnAgregarConfiguracion.TabIndex = 20
        Me.BtnAgregarConfiguracion.Text = "Agregar"
        Me.BtnAgregarConfiguracion.UseVisualStyleBackColor = True
        '
        'TxtBaseDatos
        '
        Me.TxtBaseDatos.Location = New System.Drawing.Point(106, 87)
        Me.TxtBaseDatos.Name = "TxtBaseDatos"
        Me.TxtBaseDatos.Size = New System.Drawing.Size(173, 20)
        Me.TxtBaseDatos.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Base Datos"
        '
        'TxtContrasena
        '
        Me.TxtContrasena.Location = New System.Drawing.Point(106, 61)
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.Size = New System.Drawing.Size(173, 20)
        Me.TxtContrasena.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Contraseña"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(106, 35)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(173, 20)
        Me.TxtUsuario.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Usuario"
        '
        'TxtHost
        '
        Me.TxtHost.Location = New System.Drawing.Point(106, 9)
        Me.TxtHost.Name = "TxtHost"
        Me.TxtHost.Size = New System.Drawing.Size(173, 20)
        Me.TxtHost.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Host"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DtGvConfiguraciones)
        Me.GroupBox2.Location = New System.Drawing.Point(-4, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(629, 324)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bases Datos Distribuidas"
        '
        'DtGvConfiguraciones
        '
        Me.DtGvConfiguraciones.AllowUserToAddRows = False
        Me.DtGvConfiguraciones.AllowUserToDeleteRows = False
        Me.DtGvConfiguraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtGvConfiguraciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Host, Me.Usuario, Me.Contrasena, Me.BaseDatos})
        Me.DtGvConfiguraciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DtGvConfiguraciones.Location = New System.Drawing.Point(3, 16)
        Me.DtGvConfiguraciones.MultiSelect = False
        Me.DtGvConfiguraciones.Name = "DtGvConfiguraciones"
        Me.DtGvConfiguraciones.ReadOnly = True
        Me.DtGvConfiguraciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtGvConfiguraciones.Size = New System.Drawing.Size(623, 305)
        Me.DtGvConfiguraciones.TabIndex = 0
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Visible = False
        '
        'Host
        '
        Me.Host.HeaderText = "Host"
        Me.Host.Name = "Host"
        Me.Host.ReadOnly = True
        Me.Host.Width = 130
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        Me.Usuario.Width = 130
        '
        'Contrasena
        '
        Me.Contrasena.HeaderText = "Contrasena"
        Me.Contrasena.Name = "Contrasena"
        Me.Contrasena.ReadOnly = True
        Me.Contrasena.Width = 130
        '
        'BaseDatos
        '
        Me.BaseDatos.HeaderText = "Base de Datos"
        Me.BaseDatos.Name = "BaseDatos"
        Me.BaseDatos.ReadOnly = True
        Me.BaseDatos.Width = 130
        '
        'FrmOrdenesVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 458)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmOrdenesVenta"
        Me.Text = "Ventas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Productos.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DtGvConfiguraciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnRegistrarVenta As Button
    Friend WithEvents TxtBoxTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxCliente As TextBox
    Friend WithEvents TxtBoxNit As TextBox
    Friend WithEvents Productos As GroupBox
    Friend WithEvents BtnEliminarProducto As Button
    Friend WithEvents BtnAgregarProducto As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CodigoProducto As DataGridViewTextBoxColumn
    Friend WithEvents NombreProducto As DataGridViewTextBoxColumn
    Friend WithEvents CantidadProducto As DataGridViewTextBoxColumn
    Friend WithEvents PrecioProducto As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnEliminarConfiguracion As Button
    Friend WithEvents BtnAgregarConfiguracion As Button
    Friend WithEvents TxtBaseDatos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtHost As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DtGvConfiguraciones As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Host As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Contrasena As DataGridViewTextBoxColumn
    Friend WithEvents BaseDatos As DataGridViewTextBoxColumn
End Class
