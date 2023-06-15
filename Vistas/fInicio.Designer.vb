<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fInicio))
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bVentas = New System.Windows.Forms.Button()
        Me.bProductos = New System.Windows.Forms.Button()
        Me.bUsuarioABM = New System.Windows.Forms.Button()
        Me.bHistorial = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bMinimizar
        '
        Me.bMinimizar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMinimizar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bMinimizar.Location = New System.Drawing.Point(234, -1)
        Me.bMinimizar.Name = "bMinimizar"
        Me.bMinimizar.Size = New System.Drawing.Size(40, 32)
        Me.bMinimizar.TabIndex = 11
        Me.bMinimizar.Text = "-"
        Me.bMinimizar.UseVisualStyleBackColor = False
        '
        'bSalir
        '
        Me.bSalir.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bSalir.Location = New System.Drawing.Point(271, -1)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(40, 32)
        Me.bSalir.TabIndex = 10
        Me.bSalir.Text = "x"
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'bVentas
        '
        Me.bVentas.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bVentas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bVentas.Location = New System.Drawing.Point(48, 254)
        Me.bVentas.Name = "bVentas"
        Me.bVentas.Size = New System.Drawing.Size(217, 67)
        Me.bVentas.TabIndex = 9
        Me.bVentas.Text = "Ventas"
        Me.bVentas.UseVisualStyleBackColor = False
        '
        'bProductos
        '
        Me.bProductos.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bProductos.Location = New System.Drawing.Point(48, 159)
        Me.bProductos.Name = "bProductos"
        Me.bProductos.Size = New System.Drawing.Size(217, 63)
        Me.bProductos.TabIndex = 8
        Me.bProductos.Text = "Productos"
        Me.bProductos.UseVisualStyleBackColor = False
        '
        'bUsuarioABM
        '
        Me.bUsuarioABM.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bUsuarioABM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bUsuarioABM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bUsuarioABM.Location = New System.Drawing.Point(48, 72)
        Me.bUsuarioABM.Name = "bUsuarioABM"
        Me.bUsuarioABM.Size = New System.Drawing.Size(217, 66)
        Me.bUsuarioABM.TabIndex = 7
        Me.bUsuarioABM.Text = "Usuarios"
        Me.bUsuarioABM.UseVisualStyleBackColor = False
        '
        'bHistorial
        '
        Me.bHistorial.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bHistorial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bHistorial.Location = New System.Drawing.Point(48, 344)
        Me.bHistorial.Name = "bHistorial"
        Me.bHistorial.Size = New System.Drawing.Size(217, 67)
        Me.bHistorial.TabIndex = 12
        Me.bHistorial.Text = "Historial de Ventas"
        Me.bHistorial.UseVisualStyleBackColor = False
        '
        'fInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(310, 450)
        Me.Controls.Add(Me.bHistorial)
        Me.Controls.Add(Me.bMinimizar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bVentas)
        Me.Controls.Add(Me.bProductos)
        Me.Controls.Add(Me.bUsuarioABM)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fInicio"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bMinimizar As Button
    Friend WithEvents bSalir As Button
    Friend WithEvents bVentas As Button
    Friend WithEvents bProductos As Button
    Friend WithEvents bUsuarioABM As Button
    Friend WithEvents bHistorial As Button
End Class
