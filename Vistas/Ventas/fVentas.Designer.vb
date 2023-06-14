<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fVentas
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
        Me.bVolver = New System.Windows.Forms.Button()
        Me.pPedidoTotal = New System.Windows.Forms.Panel()
        Me.lPedidoTotal = New System.Windows.Forms.Label()
        Me.bFinalizarCompra = New System.Windows.Forms.Button()
        Me.pFiltros = New System.Windows.Forms.Panel()
        Me.bQuitarFiltros = New System.Windows.Forms.Button()
        Me.lCategorias = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.pCampos = New System.Windows.Forms.Panel()
        Me.bAgregarCarrito = New System.Windows.Forms.Button()
        Me.lCantidad = New System.Windows.Forms.Label()
        Me.lCantProd = New System.Windows.Forms.ListBox()
        Me.tNombre = New System.Windows.Forms.TextBox()
        Me.lCategoria = New System.Windows.Forms.Label()
        Me.lPrecio = New System.Windows.Forms.Label()
        Me.lNombre = New System.Windows.Forms.Label()
        Me.tCategoria = New System.Windows.Forms.TextBox()
        Me.tPrecio = New System.Windows.Forms.TextBox()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.gVentas = New System.Windows.Forms.DataGridView()
        Me.lBusque = New System.Windows.Forms.Label()
        Me.tBuscar = New System.Windows.Forms.TextBox()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pPedidoTotal.SuspendLayout()
        Me.pFiltros.SuspendLayout()
        Me.pCampos.SuspendLayout()
        CType(Me.gVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bVolver
        '
        Me.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bVolver.ForeColor = System.Drawing.Color.Black
        Me.bVolver.Location = New System.Drawing.Point(14, 450)
        Me.bVolver.Name = "bVolver"
        Me.bVolver.Size = New System.Drawing.Size(143, 39)
        Me.bVolver.TabIndex = 82
        Me.bVolver.Text = "Volver al Menu"
        Me.bVolver.UseVisualStyleBackColor = True
        '
        'pPedidoTotal
        '
        Me.pPedidoTotal.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pPedidoTotal.Controls.Add(Me.lPedidoTotal)
        Me.pPedidoTotal.Location = New System.Drawing.Point(535, 344)
        Me.pPedidoTotal.Name = "pPedidoTotal"
        Me.pPedidoTotal.Size = New System.Drawing.Size(341, 91)
        Me.pPedidoTotal.TabIndex = 81
        '
        'lPedidoTotal
        '
        Me.lPedidoTotal.AutoSize = True
        Me.lPedidoTotal.Location = New System.Drawing.Point(9, 16)
        Me.lPedidoTotal.Name = "lPedidoTotal"
        Me.lPedidoTotal.Size = New System.Drawing.Size(64, 13)
        Me.lPedidoTotal.TabIndex = 0
        Me.lPedidoTotal.Text = "PedidoTotal"
        '
        'bFinalizarCompra
        '
        Me.bFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bFinalizarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bFinalizarCompra.ForeColor = System.Drawing.Color.Black
        Me.bFinalizarCompra.Location = New System.Drawing.Point(733, 450)
        Me.bFinalizarCompra.Name = "bFinalizarCompra"
        Me.bFinalizarCompra.Size = New System.Drawing.Size(143, 39)
        Me.bFinalizarCompra.TabIndex = 80
        Me.bFinalizarCompra.Text = "Finalizar Compra"
        Me.bFinalizarCompra.UseVisualStyleBackColor = True
        '
        'pFiltros
        '
        Me.pFiltros.Controls.Add(Me.bQuitarFiltros)
        Me.pFiltros.Controls.Add(Me.lCategorias)
        Me.pFiltros.Controls.Add(Me.Label1)
        Me.pFiltros.Location = New System.Drawing.Point(535, 39)
        Me.pFiltros.Name = "pFiltros"
        Me.pFiltros.Size = New System.Drawing.Size(341, 69)
        Me.pFiltros.TabIndex = 79
        '
        'bQuitarFiltros
        '
        Me.bQuitarFiltros.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.bQuitarFiltros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bQuitarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bQuitarFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.bQuitarFiltros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bQuitarFiltros.Location = New System.Drawing.Point(123, 34)
        Me.bQuitarFiltros.Name = "bQuitarFiltros"
        Me.bQuitarFiltros.Size = New System.Drawing.Size(111, 22)
        Me.bQuitarFiltros.TabIndex = 70
        Me.bQuitarFiltros.Text = "Quitar Filtros"
        Me.bQuitarFiltros.UseVisualStyleBackColor = False
        '
        'lCategorias
        '
        Me.lCategorias.FormattingEnabled = True
        Me.lCategorias.Location = New System.Drawing.Point(90, 11)
        Me.lCategorias.Name = "lCategorias"
        Me.lCategorias.Size = New System.Drawing.Size(169, 17)
        Me.lCategorias.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Filtrar por:"
        '
        'bSalir
        '
        Me.bSalir.ForeColor = System.Drawing.Color.DimGray
        Me.bSalir.Location = New System.Drawing.Point(847, -1)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(42, 36)
        Me.bSalir.TabIndex = 78
        Me.bSalir.Text = "X"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'pCampos
        '
        Me.pCampos.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pCampos.Controls.Add(Me.bAgregarCarrito)
        Me.pCampos.Controls.Add(Me.lCantidad)
        Me.pCampos.Controls.Add(Me.lCantProd)
        Me.pCampos.Controls.Add(Me.tNombre)
        Me.pCampos.Controls.Add(Me.lCategoria)
        Me.pCampos.Controls.Add(Me.lPrecio)
        Me.pCampos.Controls.Add(Me.lNombre)
        Me.pCampos.Controls.Add(Me.tCategoria)
        Me.pCampos.Controls.Add(Me.tPrecio)
        Me.pCampos.Location = New System.Drawing.Point(535, 129)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(341, 204)
        Me.pCampos.TabIndex = 77
        '
        'bAgregarCarrito
        '
        Me.bAgregarCarrito.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.bAgregarCarrito.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.bAgregarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregarCarrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bAgregarCarrito.ForeColor = System.Drawing.Color.Black
        Me.bAgregarCarrito.Location = New System.Drawing.Point(109, 171)
        Me.bAgregarCarrito.Name = "bAgregarCarrito"
        Me.bAgregarCarrito.Size = New System.Drawing.Size(136, 30)
        Me.bAgregarCarrito.TabIndex = 27
        Me.bAgregarCarrito.Text = "Agregar al Carrito"
        Me.bAgregarCarrito.UseVisualStyleBackColor = False
        '
        'lCantidad
        '
        Me.lCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lCantidad.Location = New System.Drawing.Point(3, 13)
        Me.lCantidad.Name = "lCantidad"
        Me.lCantidad.Size = New System.Drawing.Size(143, 26)
        Me.lCantidad.TabIndex = 26
        Me.lCantidad.Text = "Seleccione Cantidad:"
        '
        'lCantProd
        '
        Me.lCantProd.FormattingEnabled = True
        Me.lCantProd.Location = New System.Drawing.Point(183, 13)
        Me.lCantProd.Name = "lCantProd"
        Me.lCantProd.Size = New System.Drawing.Size(143, 17)
        Me.lCantProd.TabIndex = 25
        '
        'tNombre
        '
        Me.tNombre.Location = New System.Drawing.Point(183, 48)
        Me.tNombre.Name = "tNombre"
        Me.tNombre.ReadOnly = True
        Me.tNombre.Size = New System.Drawing.Size(143, 20)
        Me.tNombre.TabIndex = 24
        '
        'lCategoria
        '
        Me.lCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lCategoria.Location = New System.Drawing.Point(9, 117)
        Me.lCategoria.Name = "lCategoria"
        Me.lCategoria.Size = New System.Drawing.Size(100, 20)
        Me.lCategoria.TabIndex = 14
        Me.lCategoria.Text = "Categoria:"
        '
        'lPrecio
        '
        Me.lPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lPrecio.Location = New System.Drawing.Point(8, 81)
        Me.lPrecio.Name = "lPrecio"
        Me.lPrecio.Size = New System.Drawing.Size(100, 23)
        Me.lPrecio.TabIndex = 13
        Me.lPrecio.Text = "Precio:"
        '
        'lNombre
        '
        Me.lNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lNombre.Location = New System.Drawing.Point(8, 49)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(100, 23)
        Me.lNombre.TabIndex = 12
        Me.lNombre.Text = "Nombre:"
        '
        'tCategoria
        '
        Me.tCategoria.Location = New System.Drawing.Point(183, 117)
        Me.tCategoria.Name = "tCategoria"
        Me.tCategoria.ReadOnly = True
        Me.tCategoria.Size = New System.Drawing.Size(143, 20)
        Me.tCategoria.TabIndex = 6
        '
        'tPrecio
        '
        Me.tPrecio.Location = New System.Drawing.Point(183, 80)
        Me.tPrecio.Name = "tPrecio"
        Me.tPrecio.ReadOnly = True
        Me.tPrecio.Size = New System.Drawing.Size(143, 20)
        Me.tPrecio.TabIndex = 0
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bBuscar.Location = New System.Drawing.Point(437, 38)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(75, 35)
        Me.bBuscar.TabIndex = 76
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'gVentas
        '
        Me.gVentas.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gVentas.Location = New System.Drawing.Point(14, 80)
        Me.gVentas.Name = "gVentas"
        Me.gVentas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver
        Me.gVentas.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gVentas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.gVentas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gVentas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.gVentas.Size = New System.Drawing.Size(515, 355)
        Me.gVentas.TabIndex = 75
        '
        'lBusque
        '
        Me.lBusque.AutoSize = True
        Me.lBusque.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lBusque.Location = New System.Drawing.Point(11, 48)
        Me.lBusque.Name = "lBusque"
        Me.lBusque.Size = New System.Drawing.Size(142, 17)
        Me.lBusque.TabIndex = 74
        Me.lBusque.Text = "Nombre/Id Producto: "
        '
        'tBuscar
        '
        Me.tBuscar.Location = New System.Drawing.Point(159, 47)
        Me.tBuscar.Name = "tBuscar"
        Me.tBuscar.Size = New System.Drawing.Size(261, 20)
        Me.tBuscar.TabIndex = 73
        '
        'bMinimizar
        '
        Me.bMinimizar.ForeColor = System.Drawing.Color.DimGray
        Me.bMinimizar.Location = New System.Drawing.Point(814, -1)
        Me.bMinimizar.Name = "bMinimizar"
        Me.bMinimizar.Size = New System.Drawing.Size(37, 36)
        Me.bMinimizar.TabIndex = 72
        Me.bMinimizar.Text = "-"
        Me.bMinimizar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(890, 36)
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'fVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 498)
        Me.Controls.Add(Me.bVolver)
        Me.Controls.Add(Me.pPedidoTotal)
        Me.Controls.Add(Me.bFinalizarCompra)
        Me.Controls.Add(Me.pFiltros)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.pCampos)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.gVentas)
        Me.Controls.Add(Me.lBusque)
        Me.Controls.Add(Me.tBuscar)
        Me.Controls.Add(Me.bMinimizar)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fVentas"
        Me.Text = "fVentas"
        Me.pPedidoTotal.ResumeLayout(False)
        Me.pPedidoTotal.PerformLayout()
        Me.pFiltros.ResumeLayout(False)
        Me.pFiltros.PerformLayout()
        Me.pCampos.ResumeLayout(False)
        Me.pCampos.PerformLayout()
        CType(Me.gVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bVolver As Button
    Friend WithEvents pPedidoTotal As Panel
    Friend WithEvents lPedidoTotal As Label
    Friend WithEvents bFinalizarCompra As Button
    Friend WithEvents pFiltros As Panel
    Friend WithEvents bQuitarFiltros As Button
    Friend WithEvents lCategorias As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bSalir As Button
    Friend WithEvents pCampos As Panel
    Friend WithEvents bAgregarCarrito As Button
    Friend WithEvents lCantidad As Label
    Friend WithEvents lCantProd As ListBox
    Friend WithEvents tNombre As TextBox
    Friend WithEvents lCategoria As Label
    Friend WithEvents lPrecio As Label
    Friend WithEvents lNombre As Label
    Friend WithEvents tCategoria As TextBox
    Friend WithEvents tPrecio As TextBox
    Friend WithEvents bBuscar As Button
    Friend WithEvents gVentas As DataGridView
    Friend WithEvents lBusque As Label
    Friend WithEvents tBuscar As TextBox
    Friend WithEvents bMinimizar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
