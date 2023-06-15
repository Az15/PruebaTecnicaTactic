<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fVentasHistorial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fVentasHistorial))
        Me.gHistoricoVentas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bEliminarVenta = New System.Windows.Forms.Button()
        Me.bDetalleVenta = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.bMenu = New System.Windows.Forms.Button()
        Me.lLegajo = New System.Windows.Forms.Label()
        Me.ltNombre = New System.Windows.Forms.Label()
        Me.lNombre = New System.Windows.Forms.Label()
        Me.bReportes = New System.Windows.Forms.Button()
        Me.lTotal = New System.Windows.Forms.Label()
        Me.ltotalL = New System.Windows.Forms.Label()
        CType(Me.gHistoricoVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gHistoricoVentas
        '
        Me.gHistoricoVentas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.gHistoricoVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gHistoricoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gHistoricoVentas.GridColor = System.Drawing.SystemColors.Control
        Me.gHistoricoVentas.Location = New System.Drawing.Point(52, 54)
        Me.gHistoricoVentas.Name = "gHistoricoVentas"
        Me.gHistoricoVentas.ReadOnly = True
        Me.gHistoricoVentas.Size = New System.Drawing.Size(373, 324)
        Me.gHistoricoVentas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Aca cargamos el historial"
        '
        'bEliminarVenta
        '
        Me.bEliminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEliminarVenta.Location = New System.Drawing.Point(457, 139)
        Me.bEliminarVenta.Name = "bEliminarVenta"
        Me.bEliminarVenta.Size = New System.Drawing.Size(106, 23)
        Me.bEliminarVenta.TabIndex = 2
        Me.bEliminarVenta.Text = "Eliminar Venta"
        Me.bEliminarVenta.UseVisualStyleBackColor = True
        '
        'bDetalleVenta
        '
        Me.bDetalleVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDetalleVenta.Location = New System.Drawing.Point(580, 139)
        Me.bDetalleVenta.Name = "bDetalleVenta"
        Me.bDetalleVenta.Size = New System.Drawing.Size(90, 23)
        Me.bDetalleVenta.TabIndex = 3
        Me.bDetalleVenta.Text = "Ver Detalle"
        Me.bDetalleVenta.UseVisualStyleBackColor = True
        '
        'bSalir
        '
        Me.bSalir.ForeColor = System.Drawing.Color.DimGray
        Me.bSalir.Location = New System.Drawing.Point(759, -1)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(42, 36)
        Me.bSalir.TabIndex = 80
        Me.bSalir.Text = "X"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bMinimizar
        '
        Me.bMinimizar.ForeColor = System.Drawing.Color.DimGray
        Me.bMinimizar.Location = New System.Drawing.Point(723, -1)
        Me.bMinimizar.Name = "bMinimizar"
        Me.bMinimizar.Size = New System.Drawing.Size(37, 36)
        Me.bMinimizar.TabIndex = 79
        Me.bMinimizar.Text = "-"
        Me.bMinimizar.UseVisualStyleBackColor = True
        '
        'bMenu
        '
        Me.bMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMenu.Location = New System.Drawing.Point(694, 352)
        Me.bMenu.Name = "bMenu"
        Me.bMenu.Size = New System.Drawing.Size(94, 26)
        Me.bMenu.TabIndex = 81
        Me.bMenu.Text = "Volver al Menu"
        Me.bMenu.UseVisualStyleBackColor = True
        '
        'lLegajo
        '
        Me.lLegajo.AutoSize = True
        Me.lLegajo.Location = New System.Drawing.Point(689, 54)
        Me.lLegajo.Name = "lLegajo"
        Me.lLegajo.Size = New System.Drawing.Size(13, 13)
        Me.lLegajo.TabIndex = 82
        Me.lLegajo.Text = "0"
        '
        'ltNombre
        '
        Me.ltNombre.AutoSize = True
        Me.ltNombre.Location = New System.Drawing.Point(454, 85)
        Me.ltNombre.Name = "ltNombre"
        Me.ltNombre.Size = New System.Drawing.Size(141, 13)
        Me.ltNombre.TabIndex = 83
        Me.ltNombre.Text = "Compra Asociada al cliente: "
        '
        'lNombre
        '
        Me.lNombre.AutoSize = True
        Me.lNombre.Location = New System.Drawing.Point(602, 85)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(46, 13)
        Me.lNombre.TabIndex = 84
        Me.lNombre.Text = "lNombre"
        '
        'bReportes
        '
        Me.bReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bReportes.Location = New System.Drawing.Point(476, 352)
        Me.bReportes.Name = "bReportes"
        Me.bReportes.Size = New System.Drawing.Size(106, 26)
        Me.bReportes.TabIndex = 85
        Me.bReportes.Text = "Ver Reportes"
        Me.bReportes.UseVisualStyleBackColor = True
        '
        'lTotal
        '
        Me.lTotal.AutoSize = True
        Me.lTotal.Location = New System.Drawing.Point(602, 108)
        Me.lTotal.Name = "lTotal"
        Me.lTotal.Size = New System.Drawing.Size(13, 13)
        Me.lTotal.TabIndex = 87
        Me.lTotal.Text = "0"
        '
        'ltotalL
        '
        Me.ltotalL.AutoSize = True
        Me.ltotalL.Location = New System.Drawing.Point(454, 108)
        Me.ltotalL.Name = "ltotalL"
        Me.ltotalL.Size = New System.Drawing.Size(141, 13)
        Me.ltotalL.TabIndex = 86
        Me.ltotalL.Text = "Compra Asociada al cliente: "
        '
        'fVentasHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 398)
        Me.Controls.Add(Me.lTotal)
        Me.Controls.Add(Me.ltotalL)
        Me.Controls.Add(Me.bReportes)
        Me.Controls.Add(Me.lNombre)
        Me.Controls.Add(Me.ltNombre)
        Me.Controls.Add(Me.lLegajo)
        Me.Controls.Add(Me.bMenu)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bMinimizar)
        Me.Controls.Add(Me.bDetalleVenta)
        Me.Controls.Add(Me.bEliminarVenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gHistoricoVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fVentasHistorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fVentasHistorial"
        CType(Me.gHistoricoVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gHistoricoVentas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents bEliminarVenta As Button
    Friend WithEvents bDetalleVenta As Button
    Friend WithEvents bSalir As Button
    Friend WithEvents bMinimizar As Button
    Friend WithEvents bMenu As Button
    Friend WithEvents lLegajo As Label
    Friend WithEvents ltNombre As Label
    Friend WithEvents lNombre As Label
    Friend WithEvents bReportes As Button
    Friend WithEvents lTotal As Label
    Friend WithEvents ltotalL As Label
End Class
