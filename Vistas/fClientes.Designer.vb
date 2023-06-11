<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fClientes))
        Me.lLegajo = New System.Windows.Forms.Label()
        Me.bCrear = New System.Windows.Forms.Button()
        Me.pBotones = New System.Windows.Forms.Panel()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bCambio = New System.Windows.Forms.Button()
        Me.pCampos = New System.Windows.Forms.Panel()
        Me.tTelefono = New System.Windows.Forms.TextBox()
        Me.lCorreo = New System.Windows.Forms.Label()
        Me.lTelefono = New System.Windows.Forms.Label()
        Me.lCliente = New System.Windows.Forms.Label()
        Me.tCorreo = New System.Windows.Forms.TextBox()
        Me.tCliente = New System.Windows.Forms.TextBox()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.gClientes = New System.Windows.Forms.DataGridView()
        Me.lBusque = New System.Windows.Forms.Label()
        Me.tBuscar = New System.Windows.Forms.TextBox()
        Me.bMenu = New System.Windows.Forms.Button()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bLimpiarCampos = New System.Windows.Forms.Button()
        Me.pBotones.SuspendLayout()
        Me.pCampos.SuspendLayout()
        CType(Me.gClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lLegajo
        '
        Me.lLegajo.AutoSize = True
        Me.lLegajo.Location = New System.Drawing.Point(826, 67)
        Me.lLegajo.Name = "lLegajo"
        Me.lLegajo.Size = New System.Drawing.Size(13, 13)
        Me.lLegajo.TabIndex = 63
        Me.lLegajo.Text = "0"
        '
        'bCrear
        '
        Me.bCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCrear.ForeColor = System.Drawing.Color.White
        Me.bCrear.Location = New System.Drawing.Point(646, 306)
        Me.bCrear.Name = "bCrear"
        Me.bCrear.Size = New System.Drawing.Size(75, 37)
        Me.bCrear.TabIndex = 56
        Me.bCrear.Text = "Crear Cliente"
        Me.bCrear.UseVisualStyleBackColor = True
        '
        'pBotones
        '
        Me.pBotones.BackColor = System.Drawing.Color.Transparent
        Me.pBotones.Controls.Add(Me.bEliminar)
        Me.pBotones.Controls.Add(Me.bCambio)
        Me.pBotones.Location = New System.Drawing.Point(515, 297)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(329, 52)
        Me.pBotones.TabIndex = 62
        '
        'bEliminar
        '
        Me.bEliminar.BackColor = System.Drawing.Color.Transparent
        Me.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEliminar.ForeColor = System.Drawing.Color.White
        Me.bEliminar.Location = New System.Drawing.Point(224, 8)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(75, 37)
        Me.bEliminar.TabIndex = 2
        Me.bEliminar.Text = "Eliminar Cliente"
        Me.bEliminar.UseVisualStyleBackColor = False
        '
        'bCambio
        '
        Me.bCambio.BackColor = System.Drawing.Color.Transparent
        Me.bCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCambio.ForeColor = System.Drawing.Color.White
        Me.bCambio.Location = New System.Drawing.Point(26, 8)
        Me.bCambio.Name = "bCambio"
        Me.bCambio.Size = New System.Drawing.Size(75, 37)
        Me.bCambio.TabIndex = 0
        Me.bCambio.Text = "Aceptar Cambios"
        Me.bCambio.UseVisualStyleBackColor = False
        '
        'pCampos
        '
        Me.pCampos.BackColor = System.Drawing.Color.Transparent
        Me.pCampos.Controls.Add(Me.tTelefono)
        Me.pCampos.Controls.Add(Me.lCorreo)
        Me.pCampos.Controls.Add(Me.lTelefono)
        Me.pCampos.Controls.Add(Me.lCliente)
        Me.pCampos.Controls.Add(Me.tCorreo)
        Me.pCampos.Controls.Add(Me.tCliente)
        Me.pCampos.Location = New System.Drawing.Point(515, 91)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(329, 179)
        Me.pCampos.TabIndex = 61
        '
        'tTelefono
        '
        Me.tTelefono.Location = New System.Drawing.Point(178, 65)
        Me.tTelefono.Name = "tTelefono"
        Me.tTelefono.Size = New System.Drawing.Size(150, 20)
        Me.tTelefono.TabIndex = 24
        '
        'lCorreo
        '
        Me.lCorreo.ForeColor = System.Drawing.Color.White
        Me.lCorreo.Location = New System.Drawing.Point(3, 113)
        Me.lCorreo.Name = "lCorreo"
        Me.lCorreo.Size = New System.Drawing.Size(100, 20)
        Me.lCorreo.TabIndex = 14
        Me.lCorreo.Text = "Correo:"
        '
        'lTelefono
        '
        Me.lTelefono.ForeColor = System.Drawing.Color.White
        Me.lTelefono.Location = New System.Drawing.Point(1, 65)
        Me.lTelefono.Name = "lTelefono"
        Me.lTelefono.Size = New System.Drawing.Size(100, 23)
        Me.lTelefono.TabIndex = 13
        Me.lTelefono.Text = "Telefono:"
        '
        'lCliente
        '
        Me.lCliente.ForeColor = System.Drawing.Color.White
        Me.lCliente.Location = New System.Drawing.Point(3, 18)
        Me.lCliente.Name = "lCliente"
        Me.lCliente.Size = New System.Drawing.Size(118, 23)
        Me.lCliente.TabIndex = 12
        Me.lCliente.Text = "Nombre de cliente:"
        '
        'tCorreo
        '
        Me.tCorreo.Location = New System.Drawing.Point(178, 113)
        Me.tCorreo.Name = "tCorreo"
        Me.tCorreo.Size = New System.Drawing.Size(150, 20)
        Me.tCorreo.TabIndex = 6
        '
        'tCliente
        '
        Me.tCliente.Location = New System.Drawing.Point(178, 18)
        Me.tCliente.Name = "tCliente"
        Me.tCliente.Size = New System.Drawing.Size(150, 20)
        Me.tCliente.TabIndex = 0
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.Color.Gray
        Me.bBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBuscar.ForeColor = System.Drawing.Color.White
        Me.bBuscar.Location = New System.Drawing.Point(315, 58)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(75, 23)
        Me.bBuscar.TabIndex = 60
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'gClientes
        '
        Me.gClientes.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.gClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gClientes.DefaultCellStyle = DataGridViewCellStyle2
        Me.gClientes.EnableHeadersVisualStyles = False
        Me.gClientes.GridColor = System.Drawing.Color.Gainsboro
        Me.gClientes.Location = New System.Drawing.Point(12, 91)
        Me.gClientes.Name = "gClientes"
        Me.gClientes.ReadOnly = True
        Me.gClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gClientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black
        Me.gClientes.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.gClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray
        Me.gClientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.gClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gClientes.Size = New System.Drawing.Size(471, 258)
        Me.gClientes.TabIndex = 59
        '
        'lBusque
        '
        Me.lBusque.AutoSize = True
        Me.lBusque.BackColor = System.Drawing.Color.Transparent
        Me.lBusque.ForeColor = System.Drawing.Color.White
        Me.lBusque.Location = New System.Drawing.Point(13, 63)
        Me.lBusque.Name = "lBusque"
        Me.lBusque.Size = New System.Drawing.Size(51, 13)
        Me.lBusque.TabIndex = 58
        Me.lBusque.Text = "Usuarios:"
        '
        'tBuscar
        '
        Me.tBuscar.Location = New System.Drawing.Point(89, 60)
        Me.tBuscar.Name = "tBuscar"
        Me.tBuscar.Size = New System.Drawing.Size(220, 20)
        Me.tBuscar.TabIndex = 57
        '
        'bMenu
        '
        Me.bMenu.BackColor = System.Drawing.Color.Gray
        Me.bMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMenu.ForeColor = System.Drawing.Color.White
        Me.bMenu.Location = New System.Drawing.Point(408, 48)
        Me.bMenu.Name = "bMenu"
        Me.bMenu.Size = New System.Drawing.Size(75, 37)
        Me.bMenu.TabIndex = 55
        Me.bMenu.Text = "Volver Al Menu"
        Me.bMenu.UseVisualStyleBackColor = False
        '
        'bMinimizar
        '
        Me.bMinimizar.BackColor = System.Drawing.Color.Gray
        Me.bMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMinimizar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bMinimizar.Location = New System.Drawing.Point(785, 0)
        Me.bMinimizar.Name = "bMinimizar"
        Me.bMinimizar.Size = New System.Drawing.Size(36, 38)
        Me.bMinimizar.TabIndex = 54
        Me.bMinimizar.Text = "-"
        Me.bMinimizar.UseVisualStyleBackColor = False
        '
        'bSalir
        '
        Me.bSalir.BackColor = System.Drawing.Color.Gray
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bSalir.Location = New System.Drawing.Point(821, 0)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(36, 38)
        Me.bSalir.TabIndex = 53
        Me.bSalir.Text = "X"
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(860, 38)
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'bLimpiarCampos
        '
        Me.bLimpiarCampos.BackColor = System.Drawing.Color.Gray
        Me.bLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiarCampos.ForeColor = System.Drawing.Color.White
        Me.bLimpiarCampos.Location = New System.Drawing.Point(515, 67)
        Me.bLimpiarCampos.Name = "bLimpiarCampos"
        Me.bLimpiarCampos.Size = New System.Drawing.Size(101, 21)
        Me.bLimpiarCampos.TabIndex = 64
        Me.bLimpiarCampos.Text = "Limpiar Campos"
        Me.bLimpiarCampos.UseVisualStyleBackColor = False
        '
        'fClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(859, 374)
        Me.Controls.Add(Me.bLimpiarCampos)
        Me.Controls.Add(Me.lLegajo)
        Me.Controls.Add(Me.bCrear)
        Me.Controls.Add(Me.pBotones)
        Me.Controls.Add(Me.pCampos)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.gClientes)
        Me.Controls.Add(Me.lBusque)
        Me.Controls.Add(Me.tBuscar)
        Me.Controls.Add(Me.bMenu)
        Me.Controls.Add(Me.bMinimizar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fUsuarios"
        Me.pBotones.ResumeLayout(False)
        Me.pCampos.ResumeLayout(False)
        Me.pCampos.PerformLayout()
        CType(Me.gClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lLegajo As Label
    Friend WithEvents bCrear As Button
    Friend WithEvents pBotones As Panel
    Friend WithEvents bEliminar As Button
    Friend WithEvents bCambio As Button
    Friend WithEvents pCampos As Panel
    Friend WithEvents tTelefono As TextBox
    Friend WithEvents lCorreo As Label
    Friend WithEvents lTelefono As Label
    Friend WithEvents lCliente As Label
    Friend WithEvents tCorreo As TextBox
    Friend WithEvents tCliente As TextBox
    Friend WithEvents bBuscar As Button
    Friend WithEvents gClientes As DataGridView
    Friend WithEvents lBusque As Label
    Friend WithEvents tBuscar As TextBox
    Friend WithEvents bMenu As Button
    Friend WithEvents bMinimizar As Button
    Friend WithEvents bSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bLimpiarCampos As Button
End Class
