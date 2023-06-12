<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fProductos))
        Me.bMenu = New System.Windows.Forms.Button()
        Me.lLegajo = New System.Windows.Forms.Label()
        Me.bCrear = New System.Windows.Forms.Button()
        Me.pBotones = New System.Windows.Forms.Panel()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bCambio = New System.Windows.Forms.Button()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.gProductos = New System.Windows.Forms.DataGridView()
        Me.lBusque = New System.Windows.Forms.Label()
        Me.tBuscar = New System.Windows.Forms.TextBox()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tPrecio = New System.Windows.Forms.TextBox()
        Me.tCategoria = New System.Windows.Forms.TextBox()
        Me.lNombre = New System.Windows.Forms.Label()
        Me.lPrecio = New System.Windows.Forms.Label()
        Me.lCuit = New System.Windows.Forms.Label()
        Me.tNombre = New System.Windows.Forms.TextBox()
        Me.pCampos = New System.Windows.Forms.Panel()
        Me.pBotones.SuspendLayout()
        CType(Me.gProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCampos.SuspendLayout()
        Me.SuspendLayout()
        '
        'bMenu
        '
        Me.bMenu.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.bMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMenu.Location = New System.Drawing.Point(441, 41)
        Me.bMenu.Name = "bMenu"
        Me.bMenu.Size = New System.Drawing.Size(85, 45)
        Me.bMenu.TabIndex = 55
        Me.bMenu.Text = "Volver Al Menu"
        Me.bMenu.UseVisualStyleBackColor = False
        '
        'lLegajo
        '
        Me.lLegajo.AutoSize = True
        Me.lLegajo.Location = New System.Drawing.Point(916, 73)
        Me.lLegajo.Name = "lLegajo"
        Me.lLegajo.Size = New System.Drawing.Size(13, 13)
        Me.lLegajo.TabIndex = 54
        Me.lLegajo.Text = "0"
        '
        'bCrear
        '
        Me.bCrear.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.bCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCrear.Location = New System.Drawing.Point(719, 274)
        Me.bCrear.Name = "bCrear"
        Me.bCrear.Size = New System.Drawing.Size(87, 37)
        Me.bCrear.TabIndex = 45
        Me.bCrear.Text = "Crear Cliente"
        Me.bCrear.UseVisualStyleBackColor = False
        '
        'pBotones
        '
        Me.pBotones.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pBotones.Controls.Add(Me.bEliminar)
        Me.pBotones.Controls.Add(Me.bCambio)
        Me.pBotones.Location = New System.Drawing.Point(590, 267)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(341, 52)
        Me.pBotones.TabIndex = 52
        '
        'bEliminar
        '
        Me.bEliminar.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEliminar.Location = New System.Drawing.Point(227, 8)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(75, 37)
        Me.bEliminar.TabIndex = 2
        Me.bEliminar.Text = "Eliminar Cliente"
        Me.bEliminar.UseVisualStyleBackColor = False
        '
        'bCambio
        '
        Me.bCambio.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.bCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCambio.Location = New System.Drawing.Point(26, 8)
        Me.bCambio.Name = "bCambio"
        Me.bCambio.Size = New System.Drawing.Size(75, 37)
        Me.bCambio.TabIndex = 0
        Me.bCambio.Text = "Aceptar Cambios"
        Me.bCambio.UseVisualStyleBackColor = False
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.bBuscar.Location = New System.Drawing.Point(360, 61)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(75, 23)
        Me.bBuscar.TabIndex = 51
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'gProductos
        '
        Me.gProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gProductos.Location = New System.Drawing.Point(11, 89)
        Me.gProductos.Name = "gProductos"
        Me.gProductos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver
        Me.gProductos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gProductos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.gProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gProductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.gProductos.Size = New System.Drawing.Size(515, 250)
        Me.gProductos.TabIndex = 50
        '
        'lBusque
        '
        Me.lBusque.AutoSize = True
        Me.lBusque.Location = New System.Drawing.Point(8, 66)
        Me.lBusque.Name = "lBusque"
        Me.lBusque.Size = New System.Drawing.Size(110, 13)
        Me.lBusque.TabIndex = 49
        Me.lBusque.Text = "Nombre/Id Producto: "
        '
        'tBuscar
        '
        Me.tBuscar.Location = New System.Drawing.Point(122, 63)
        Me.tBuscar.Name = "tBuscar"
        Me.tBuscar.Size = New System.Drawing.Size(232, 20)
        Me.tBuscar.TabIndex = 48
        '
        'bMinimizar
        '
        Me.bMinimizar.ForeColor = System.Drawing.Color.DimGray
        Me.bMinimizar.Location = New System.Drawing.Point(886, -1)
        Me.bMinimizar.Name = "bMinimizar"
        Me.bMinimizar.Size = New System.Drawing.Size(37, 36)
        Me.bMinimizar.TabIndex = 47
        Me.bMinimizar.Text = "-"
        Me.bMinimizar.UseVisualStyleBackColor = True
        '
        'bSalir
        '
        Me.bSalir.ForeColor = System.Drawing.Color.DimGray
        Me.bSalir.Location = New System.Drawing.Point(919, -1)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(42, 36)
        Me.bSalir.TabIndex = 46
        Me.bSalir.Text = "X"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.Location = New System.Drawing.Point(-7, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(981, 36)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'tPrecio
        '
        Me.tPrecio.Location = New System.Drawing.Point(177, 42)
        Me.tPrecio.Name = "tPrecio"
        Me.tPrecio.Size = New System.Drawing.Size(151, 20)
        Me.tPrecio.TabIndex = 0
        '
        'tCategoria
        '
        Me.tCategoria.Location = New System.Drawing.Point(178, 76)
        Me.tCategoria.Name = "tCategoria"
        Me.tCategoria.Size = New System.Drawing.Size(151, 20)
        Me.tCategoria.TabIndex = 6
        '
        'lNombre
        '
        Me.lNombre.Location = New System.Drawing.Point(2, 11)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(100, 23)
        Me.lNombre.TabIndex = 12
        Me.lNombre.Text = "Nombre:"
        '
        'lPrecio
        '
        Me.lPrecio.Location = New System.Drawing.Point(2, 43)
        Me.lPrecio.Name = "lPrecio"
        Me.lPrecio.Size = New System.Drawing.Size(100, 23)
        Me.lPrecio.TabIndex = 13
        Me.lPrecio.Text = "Precio:"
        '
        'lCuit
        '
        Me.lCuit.Location = New System.Drawing.Point(3, 79)
        Me.lCuit.Name = "lCuit"
        Me.lCuit.Size = New System.Drawing.Size(100, 20)
        Me.lCuit.TabIndex = 14
        Me.lCuit.Text = "Categoria: "
        '
        'tNombre
        '
        Me.tNombre.Location = New System.Drawing.Point(177, 8)
        Me.tNombre.Name = "tNombre"
        Me.tNombre.Size = New System.Drawing.Size(151, 20)
        Me.tNombre.TabIndex = 24
        '
        'pCampos
        '
        Me.pCampos.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pCampos.Controls.Add(Me.tNombre)
        Me.pCampos.Controls.Add(Me.lCuit)
        Me.pCampos.Controls.Add(Me.lPrecio)
        Me.pCampos.Controls.Add(Me.lNombre)
        Me.pCampos.Controls.Add(Me.tCategoria)
        Me.pCampos.Controls.Add(Me.tPrecio)
        Me.pCampos.Location = New System.Drawing.Point(590, 99)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(341, 135)
        Me.pCampos.TabIndex = 53
        '
        'fProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 386)
        Me.Controls.Add(Me.bMenu)
        Me.Controls.Add(Me.lLegajo)
        Me.Controls.Add(Me.bCrear)
        Me.Controls.Add(Me.pCampos)
        Me.Controls.Add(Me.pBotones)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.gProductos)
        Me.Controls.Add(Me.lBusque)
        Me.Controls.Add(Me.tBuscar)
        Me.Controls.Add(Me.bMinimizar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fProductos"
        Me.Opacity = 0.96R
        Me.ShowInTaskbar = False
        Me.Text = "fProductos"
        Me.pBotones.ResumeLayout(False)
        CType(Me.gProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCampos.ResumeLayout(False)
        Me.pCampos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bMenu As Button
    Friend WithEvents lLegajo As Label
    Friend WithEvents bCrear As Button
    Friend WithEvents pBotones As Panel
    Friend WithEvents bEliminar As Button
    Friend WithEvents bCambio As Button
    Friend WithEvents bBuscar As Button
    Friend WithEvents gProductos As DataGridView
    Friend WithEvents lBusque As Label
    Friend WithEvents tBuscar As TextBox
    Friend WithEvents bMinimizar As Button
    Friend WithEvents bSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tPrecio As TextBox
    Friend WithEvents tCategoria As TextBox
    Friend WithEvents lNombre As Label
    Friend WithEvents lPrecio As Label
    Friend WithEvents lCuit As Label
    Friend WithEvents tNombre As TextBox
    Friend WithEvents pCampos As Panel
End Class
