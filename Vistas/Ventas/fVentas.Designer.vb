﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fVentas))
        Me.bVolver = New System.Windows.Forms.Button()
        Me.pPedidoTotal = New System.Windows.Forms.Panel()
        Me.lTotalaAgregar = New System.Windows.Forms.Label()
        Me.lTextoPedido = New System.Windows.Forms.Label()
        Me.bFinalizarCompra = New System.Windows.Forms.Button()
        Me.pFiltros = New System.Windows.Forms.Panel()
        Me.bQuitarFiltros = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.pCampos = New System.Windows.Forms.Panel()
        Me.tCantidad = New System.Windows.Forms.TextBox()
        Me.bAgregarCarrito = New System.Windows.Forms.Button()
        Me.lCantidad = New System.Windows.Forms.Label()
        Me.tNombre = New System.Windows.Forms.TextBox()
        Me.lPrecio = New System.Windows.Forms.Label()
        Me.lNombre = New System.Windows.Forms.Label()
        Me.tPrecio = New System.Windows.Forms.TextBox()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.gVentas = New System.Windows.Forms.DataGridView()
        Me.lBusque = New System.Windows.Forms.Label()
        Me.tBuscar = New System.Windows.Forms.TextBox()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lSeleccionCliente = New System.Windows.Forms.Label()
        Me.cbClientes = New System.Windows.Forms.ComboBox()
        Me.cbFiltroCompra = New System.Windows.Forms.ComboBox()
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
        Me.bVolver.Location = New System.Drawing.Point(14, 486)
        Me.bVolver.Name = "bVolver"
        Me.bVolver.Size = New System.Drawing.Size(143, 39)
        Me.bVolver.TabIndex = 82
        Me.bVolver.Text = "Volver al Menu"
        Me.bVolver.UseVisualStyleBackColor = True
        '
        'pPedidoTotal
        '
        Me.pPedidoTotal.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pPedidoTotal.Controls.Add(Me.lTotalaAgregar)
        Me.pPedidoTotal.Controls.Add(Me.lTextoPedido)
        Me.pPedidoTotal.Location = New System.Drawing.Point(535, 376)
        Me.pPedidoTotal.Name = "pPedidoTotal"
        Me.pPedidoTotal.Size = New System.Drawing.Size(341, 91)
        Me.pPedidoTotal.TabIndex = 81
        '
        'lTotalaAgregar
        '
        Me.lTotalaAgregar.AutoSize = True
        Me.lTotalaAgregar.Font = New System.Drawing.Font("Cambria", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTotalaAgregar.ForeColor = System.Drawing.Color.Green
        Me.lTotalaAgregar.Location = New System.Drawing.Point(115, 15)
        Me.lTotalaAgregar.Name = "lTotalaAgregar"
        Me.lTotalaAgregar.Size = New System.Drawing.Size(0, 43)
        Me.lTotalaAgregar.TabIndex = 1
        '
        'lTextoPedido
        '
        Me.lTextoPedido.AutoSize = True
        Me.lTextoPedido.ForeColor = System.Drawing.Color.DarkGreen
        Me.lTextoPedido.Location = New System.Drawing.Point(14, 15)
        Me.lTextoPedido.Name = "lTextoPedido"
        Me.lTextoPedido.Size = New System.Drawing.Size(70, 13)
        Me.lTextoPedido.TabIndex = 0
        Me.lTextoPedido.Text = "Pedido Total:"
        '
        'bFinalizarCompra
        '
        Me.bFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bFinalizarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bFinalizarCompra.ForeColor = System.Drawing.Color.Black
        Me.bFinalizarCompra.Location = New System.Drawing.Point(733, 486)
        Me.bFinalizarCompra.Name = "bFinalizarCompra"
        Me.bFinalizarCompra.Size = New System.Drawing.Size(143, 39)
        Me.bFinalizarCompra.TabIndex = 80
        Me.bFinalizarCompra.Text = "Finalizar Compra"
        Me.bFinalizarCompra.UseVisualStyleBackColor = True
        '
        'pFiltros
        '
        Me.pFiltros.Controls.Add(Me.cbFiltroCompra)
        Me.pFiltros.Controls.Add(Me.bQuitarFiltros)
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
        Me.bQuitarFiltros.Location = New System.Drawing.Point(109, 34)
        Me.bQuitarFiltros.Name = "bQuitarFiltros"
        Me.bQuitarFiltros.Size = New System.Drawing.Size(111, 22)
        Me.bQuitarFiltros.TabIndex = 70
        Me.bQuitarFiltros.Text = "Quitar Filtros"
        Me.bQuitarFiltros.UseVisualStyleBackColor = False
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
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.ForeColor = System.Drawing.Color.DimGray
        Me.bSalir.Location = New System.Drawing.Point(869, -1)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(42, 36)
        Me.bSalir.TabIndex = 78
        Me.bSalir.Text = "X"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'pCampos
        '
        Me.pCampos.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pCampos.Controls.Add(Me.tCantidad)
        Me.pCampos.Controls.Add(Me.bAgregarCarrito)
        Me.pCampos.Controls.Add(Me.lCantidad)
        Me.pCampos.Controls.Add(Me.tNombre)
        Me.pCampos.Controls.Add(Me.lPrecio)
        Me.pCampos.Controls.Add(Me.lNombre)
        Me.pCampos.Controls.Add(Me.tPrecio)
        Me.pCampos.Location = New System.Drawing.Point(535, 129)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(341, 204)
        Me.pCampos.TabIndex = 77
        '
        'tCantidad
        '
        Me.tCantidad.Location = New System.Drawing.Point(183, 71)
        Me.tCantidad.Name = "tCantidad"
        Me.tCantidad.Size = New System.Drawing.Size(100, 20)
        Me.tCantidad.TabIndex = 28
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
        Me.lCantidad.Location = New System.Drawing.Point(3, 72)
        Me.lCantidad.Name = "lCantidad"
        Me.lCantidad.Size = New System.Drawing.Size(143, 26)
        Me.lCantidad.TabIndex = 26
        Me.lCantidad.Text = "Seleccione Cantidad:"
        '
        'tNombre
        '
        Me.tNombre.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tNombre.Location = New System.Drawing.Point(183, 107)
        Me.tNombre.Name = "tNombre"
        Me.tNombre.ReadOnly = True
        Me.tNombre.Size = New System.Drawing.Size(143, 13)
        Me.tNombre.TabIndex = 24
        '
        'lPrecio
        '
        Me.lPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lPrecio.Location = New System.Drawing.Point(8, 140)
        Me.lPrecio.Name = "lPrecio"
        Me.lPrecio.Size = New System.Drawing.Size(100, 23)
        Me.lPrecio.TabIndex = 13
        Me.lPrecio.Text = "Precio:"
        '
        'lNombre
        '
        Me.lNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lNombre.Location = New System.Drawing.Point(8, 108)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(100, 23)
        Me.lNombre.TabIndex = 12
        Me.lNombre.Text = "Nombre:"
        '
        'tPrecio
        '
        Me.tPrecio.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tPrecio.Location = New System.Drawing.Point(183, 139)
        Me.tPrecio.Name = "tPrecio"
        Me.tPrecio.ReadOnly = True
        Me.tPrecio.Size = New System.Drawing.Size(143, 13)
        Me.tPrecio.TabIndex = 0
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bBuscar.Location = New System.Drawing.Point(426, 88)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(75, 27)
        Me.bBuscar.TabIndex = 76
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'gVentas
        '
        Me.gVentas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.gVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gVentas.Location = New System.Drawing.Point(14, 129)
        Me.gVentas.Name = "gVentas"
        Me.gVentas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver
        Me.gVentas.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gVentas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.gVentas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gVentas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.gVentas.Size = New System.Drawing.Size(515, 338)
        Me.gVentas.TabIndex = 75
        '
        'lBusque
        '
        Me.lBusque.AutoSize = True
        Me.lBusque.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lBusque.Location = New System.Drawing.Point(11, 94)
        Me.lBusque.Name = "lBusque"
        Me.lBusque.Size = New System.Drawing.Size(142, 17)
        Me.lBusque.TabIndex = 74
        Me.lBusque.Text = "Nombre/Id Producto: "
        '
        'tBuscar
        '
        Me.tBuscar.Location = New System.Drawing.Point(159, 94)
        Me.tBuscar.Name = "tBuscar"
        Me.tBuscar.Size = New System.Drawing.Size(261, 20)
        Me.tBuscar.TabIndex = 73
        '
        'bMinimizar
        '
        Me.bMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMinimizar.ForeColor = System.Drawing.Color.DimGray
        Me.bMinimizar.Location = New System.Drawing.Point(829, -1)
        Me.bMinimizar.Name = "bMinimizar"
        Me.bMinimizar.Size = New System.Drawing.Size(41, 36)
        Me.bMinimizar.TabIndex = 72
        Me.bMinimizar.Text = "-"
        Me.bMinimizar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(912, 36)
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'lSeleccionCliente
        '
        Me.lSeleccionCliente.AutoSize = True
        Me.lSeleccionCliente.Location = New System.Drawing.Point(14, 50)
        Me.lSeleccionCliente.Name = "lSeleccionCliente"
        Me.lSeleccionCliente.Size = New System.Drawing.Size(125, 13)
        Me.lSeleccionCliente.TabIndex = 83
        Me.lSeleccionCliente.Text = "SELECCIONE CLIENTE:"
        '
        'cbClientes
        '
        Me.cbClientes.FormattingEnabled = True
        Me.cbClientes.Location = New System.Drawing.Point(145, 46)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(187, 21)
        Me.cbClientes.TabIndex = 84
        '
        'cbFiltroCompra
        '
        Me.cbFiltroCompra.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbFiltroCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFiltroCompra.FormattingEnabled = True
        Me.cbFiltroCompra.Location = New System.Drawing.Point(90, 7)
        Me.cbFiltroCompra.Name = "cbFiltroCompra"
        Me.cbFiltroCompra.Size = New System.Drawing.Size(144, 21)
        Me.cbFiltroCompra.TabIndex = 85
        '
        'fVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 549)
        Me.Controls.Add(Me.cbClientes)
        Me.Controls.Add(Me.lSeleccionCliente)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents lTextoPedido As Label
    Friend WithEvents bFinalizarCompra As Button
    Friend WithEvents pFiltros As Panel
    Friend WithEvents bQuitarFiltros As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents bSalir As Button
    Friend WithEvents pCampos As Panel
    Friend WithEvents bAgregarCarrito As Button
    Friend WithEvents lCantidad As Label
    Friend WithEvents tNombre As TextBox
    Friend WithEvents lPrecio As Label
    Friend WithEvents lNombre As Label
    Friend WithEvents tPrecio As TextBox
    Friend WithEvents bBuscar As Button
    Friend WithEvents gVentas As DataGridView
    Friend WithEvents lBusque As Label
    Friend WithEvents tBuscar As TextBox
    Friend WithEvents bMinimizar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lTotalaAgregar As Label
    Friend WithEvents lSeleccionCliente As Label
    Friend WithEvents cbClientes As ComboBox
    Friend WithEvents tCantidad As TextBox
    Friend WithEvents cbFiltroCompra As ComboBox
End Class
