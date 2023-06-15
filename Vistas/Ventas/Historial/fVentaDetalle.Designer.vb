<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fVentaDetalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fVentaDetalle))
        Me.gDetalle = New System.Windows.Forms.DataGridView()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.v = New System.Windows.Forms.Label()
        Me.lUnitarioL = New System.Windows.Forms.Label()
        Me.lCostoTotalL = New System.Windows.Forms.Label()
        Me.lCantidadL = New System.Windows.Forms.Label()
        Me.tUnidades = New System.Windows.Forms.TextBox()
        Me.lNombre = New System.Windows.Forms.Label()
        Me.lCostoUnidad = New System.Windows.Forms.Label()
        Me.lCostoTotal = New System.Windows.Forms.Label()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bMenuH = New System.Windows.Forms.Button()
        Me.lLegajo = New System.Windows.Forms.Label()
        CType(Me.gDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gDetalle
        '
        Me.gDetalle.BackgroundColor = System.Drawing.SystemColors.Control
        Me.gDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gDetalle.Location = New System.Drawing.Point(12, 59)
        Me.gDetalle.Name = "gDetalle"
        Me.gDetalle.ReadOnly = True
        Me.gDetalle.Size = New System.Drawing.Size(861, 245)
        Me.gDetalle.TabIndex = 0
        '
        'bSalir
        '
        Me.bSalir.ForeColor = System.Drawing.Color.DimGray
        Me.bSalir.Location = New System.Drawing.Point(911, -2)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(42, 36)
        Me.bSalir.TabIndex = 82
        Me.bSalir.Text = "X"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bMinimizar
        '
        Me.bMinimizar.ForeColor = System.Drawing.Color.DimGray
        Me.bMinimizar.Location = New System.Drawing.Point(875, -2)
        Me.bMinimizar.Name = "bMinimizar"
        Me.bMinimizar.Size = New System.Drawing.Size(37, 36)
        Me.bMinimizar.TabIndex = 81
        Me.bMinimizar.Text = "-"
        Me.bMinimizar.UseVisualStyleBackColor = True
        '
        'v
        '
        Me.v.AutoSize = True
        Me.v.Location = New System.Drawing.Point(65, 324)
        Me.v.Name = "v"
        Me.v.Size = New System.Drawing.Size(44, 13)
        Me.v.TabIndex = 84
        Me.v.Text = "Nombre"
        '
        'lUnitarioL
        '
        Me.lUnitarioL.AutoSize = True
        Me.lUnitarioL.Location = New System.Drawing.Point(166, 324)
        Me.lUnitarioL.Name = "lUnitarioL"
        Me.lUnitarioL.Size = New System.Drawing.Size(73, 13)
        Me.lUnitarioL.TabIndex = 85
        Me.lUnitarioL.Text = "Costo Unitario"
        '
        'lCostoTotalL
        '
        Me.lCostoTotalL.AutoSize = True
        Me.lCostoTotalL.Location = New System.Drawing.Point(322, 324)
        Me.lCostoTotalL.Name = "lCostoTotalL"
        Me.lCostoTotalL.Size = New System.Drawing.Size(61, 13)
        Me.lCostoTotalL.TabIndex = 86
        Me.lCostoTotalL.Text = "Costo Total"
        '
        'lCantidadL
        '
        Me.lCantidadL.AutoSize = True
        Me.lCantidadL.Location = New System.Drawing.Point(257, 324)
        Me.lCantidadL.Name = "lCantidadL"
        Me.lCantidadL.Size = New System.Drawing.Size(52, 13)
        Me.lCantidadL.TabIndex = 87
        Me.lCantidadL.Text = "Cantidad:"
        '
        'tUnidades
        '
        Me.tUnidades.Location = New System.Drawing.Point(262, 354)
        Me.tUnidades.Name = "tUnidades"
        Me.tUnidades.Size = New System.Drawing.Size(36, 20)
        Me.tUnidades.TabIndex = 88
        '
        'lNombre
        '
        Me.lNombre.AutoSize = True
        Me.lNombre.Location = New System.Drawing.Point(25, 357)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(44, 13)
        Me.lNombre.TabIndex = 89
        Me.lNombre.Text = "Nombre"
        '
        'lCostoUnidad
        '
        Me.lCostoUnidad.AutoSize = True
        Me.lCostoUnidad.Location = New System.Drawing.Point(166, 357)
        Me.lCostoUnidad.Name = "lCostoUnidad"
        Me.lCostoUnidad.Size = New System.Drawing.Size(13, 13)
        Me.lCostoUnidad.TabIndex = 90
        Me.lCostoUnidad.Text = "0"
        '
        'lCostoTotal
        '
        Me.lCostoTotal.AutoSize = True
        Me.lCostoTotal.Location = New System.Drawing.Point(323, 357)
        Me.lCostoTotal.Name = "lCostoTotal"
        Me.lCostoTotal.Size = New System.Drawing.Size(13, 13)
        Me.lCostoTotal.TabIndex = 91
        Me.lCostoTotal.Text = "0"
        '
        'bEliminar
        '
        Me.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEliminar.Location = New System.Drawing.Point(409, 319)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(75, 23)
        Me.bEliminar.TabIndex = 93
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'bMenuH
        '
        Me.bMenuH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMenuH.Location = New System.Drawing.Point(835, 377)
        Me.bMenuH.Name = "bMenuH"
        Me.bMenuH.Size = New System.Drawing.Size(105, 23)
        Me.bMenuH.TabIndex = 94
        Me.bMenuH.Text = "Volver al historial"
        Me.bMenuH.UseVisualStyleBackColor = True
        '
        'lLegajo
        '
        Me.lLegajo.AutoSize = True
        Me.lLegajo.Location = New System.Drawing.Point(9, 307)
        Me.lLegajo.Name = "lLegajo"
        Me.lLegajo.Size = New System.Drawing.Size(13, 13)
        Me.lLegajo.TabIndex = 95
        Me.lLegajo.Text = "0"
        Me.lLegajo.Visible = False
        '
        'fVentaDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 412)
        Me.Controls.Add(Me.lLegajo)
        Me.Controls.Add(Me.bMenuH)
        Me.Controls.Add(Me.bEliminar)
        Me.Controls.Add(Me.lCostoTotal)
        Me.Controls.Add(Me.lCostoUnidad)
        Me.Controls.Add(Me.lNombre)
        Me.Controls.Add(Me.tUnidades)
        Me.Controls.Add(Me.lCantidadL)
        Me.Controls.Add(Me.lCostoTotalL)
        Me.Controls.Add(Me.lUnitarioL)
        Me.Controls.Add(Me.v)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bMinimizar)
        Me.Controls.Add(Me.gDetalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fVentaDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fVentaDetalle"
        CType(Me.gDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gDetalle As DataGridView
    Friend WithEvents bSalir As Button
    Friend WithEvents bMinimizar As Button
    Friend WithEvents v As Label
    Friend WithEvents lUnitarioL As Label
    Friend WithEvents lCostoTotalL As Label
    Friend WithEvents lCantidadL As Label
    Friend WithEvents tUnidades As TextBox
    Friend WithEvents lNombre As Label
    Friend WithEvents lCostoUnidad As Label
    Friend WithEvents lCostoTotal As Label
    Friend WithEvents bEliminar As Button
    Friend WithEvents bMenuH As Button
    Friend WithEvents lLegajo As Label
End Class
