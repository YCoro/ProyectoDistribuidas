<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeleccionarProducto
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
        Me.DtGvProductos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CodigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtBoxCodigoProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAgregarProducto = New System.Windows.Forms.Button()
        CType(Me.DtGvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtGvProductos
        '
        Me.DtGvProductos.AllowUserToAddRows = False
        Me.DtGvProductos.AllowUserToDeleteRows = False
        Me.DtGvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtGvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoProducto, Me.Nombre, Me.Descripcion, Me.Precio})
        Me.DtGvProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DtGvProductos.Location = New System.Drawing.Point(3, 16)
        Me.DtGvProductos.Name = "DtGvProductos"
        Me.DtGvProductos.ReadOnly = True
        Me.DtGvProductos.Size = New System.Drawing.Size(518, 340)
        Me.DtGvProductos.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtGvProductos)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 359)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'CodigoProducto
        '
        Me.CodigoProducto.HeaderText = "CodigoProducto"
        Me.CodigoProducto.Name = "CodigoProducto"
        Me.CodigoProducto.ReadOnly = True
        Me.CodigoProducto.Visible = False
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 125
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 250
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'TxtBoxCodigoProducto
        '
        Me.TxtBoxCodigoProducto.Location = New System.Drawing.Point(12, 25)
        Me.TxtBoxCodigoProducto.Name = "TxtBoxCodigoProducto"
        Me.TxtBoxCodigoProducto.Size = New System.Drawing.Size(150, 20)
        Me.TxtBoxCodigoProducto.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Còdigo Producto"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(168, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(172, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cantidad"
        '
        'BtnAgregarProducto
        '
        Me.BtnAgregarProducto.Location = New System.Drawing.Point(371, 9)
        Me.BtnAgregarProducto.Name = "BtnAgregarProducto"
        Me.BtnAgregarProducto.Size = New System.Drawing.Size(142, 36)
        Me.BtnAgregarProducto.TabIndex = 6
        Me.BtnAgregarProducto.Text = "Agregar"
        Me.BtnAgregarProducto.UseVisualStyleBackColor = True
        '
        'FrmSeleccionarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 408)
        Me.Controls.Add(Me.BtnAgregarProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBoxCodigoProducto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmSeleccionarProducto"
        Me.Text = "Seleccionar Producto"
        CType(Me.DtGvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtGvProductos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CodigoProducto As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents TxtBoxCodigoProducto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAgregarProducto As Button
End Class
