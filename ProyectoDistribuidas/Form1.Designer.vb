<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TxtBoxCliente = New System.Windows.Forms.TextBox()
        Me.TxtBoxNit = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBoxTotal = New System.Windows.Forms.TextBox()
        Me.Productos = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Productos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.TxtBoxTotal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtBoxCliente)
        Me.GroupBox1.Controls.Add(Me.TxtBoxNit)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 123)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encabezado Factura"
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
        'TxtBoxTotal
        '
        Me.TxtBoxTotal.Enabled = False
        Me.TxtBoxTotal.Location = New System.Drawing.Point(10, 97)
        Me.TxtBoxTotal.Name = "TxtBoxTotal"
        Me.TxtBoxTotal.Size = New System.Drawing.Size(209, 20)
        Me.TxtBoxTotal.TabIndex = 5
        '
        'Productos
        '
        Me.Productos.Controls.Add(Me.Button2)
        Me.Productos.Controls.Add(Me.Button1)
        Me.Productos.Controls.Add(Me.DataGridView1)
        Me.Productos.Location = New System.Drawing.Point(12, 142)
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(536, 226)
        Me.Productos.TabIndex = 3
        Me.Productos.TabStop = False
        Me.Productos.Text = "Productos"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoProducto, Me.NombreProducto, Me.CantidadProducto, Me.PrecioProducto, Me.Subtotal})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(419, 201)
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(420, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(420, 181)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(414, 78)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 39)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Registrar Producto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 374)
        Me.Controls.Add(Me.Productos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "v "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Productos.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtBoxCliente As TextBox
    Friend WithEvents TxtBoxNit As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TxtBoxTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Productos As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CodigoProducto As DataGridViewTextBoxColumn
    Friend WithEvents NombreProducto As DataGridViewTextBoxColumn
    Friend WithEvents CantidadProducto As DataGridViewTextBoxColumn
    Friend WithEvents PrecioProducto As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
End Class
