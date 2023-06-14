<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fCarritoFinal
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
        Me.dCarrito = New System.Windows.Forms.DataGridView()
        Me.bSeguirComprando = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bEnviarVenta = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.lTot = New System.Windows.Forms.Label()
        Me.lTotal = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dCarrito
        '
        Me.dCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dCarrito.Location = New System.Drawing.Point(38, 41)
        Me.dCarrito.Name = "dCarrito"
        Me.dCarrito.Size = New System.Drawing.Size(534, 294)
        Me.dCarrito.TabIndex = 0
        '
        'bSeguirComprando
        '
        Me.bSeguirComprando.Location = New System.Drawing.Point(12, 377)
        Me.bSeguirComprando.Name = "bSeguirComprando"
        Me.bSeguirComprando.Size = New System.Drawing.Size(120, 23)
        Me.bSeguirComprando.TabIndex = 1
        Me.bSeguirComprando.Text = "Seguir Comprando"
        Me.bSeguirComprando.UseVisualStyleBackColor = True
        '
        'bCancelar
        '
        Me.bCancelar.Location = New System.Drawing.Point(329, 377)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(134, 23)
        Me.bCancelar.TabIndex = 2
        Me.bCancelar.Text = "Cancelar Pedido"
        Me.bCancelar.UseVisualStyleBackColor = True
        '
        'bEnviarVenta
        '
        Me.bEnviarVenta.Location = New System.Drawing.Point(670, 377)
        Me.bEnviarVenta.Name = "bEnviarVenta"
        Me.bEnviarVenta.Size = New System.Drawing.Size(109, 23)
        Me.bEnviarVenta.TabIndex = 3
        Me.bEnviarVenta.Text = "Reservar/Comprar"
        Me.bEnviarVenta.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(817, 36)
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'bSalir
        '
        Me.bSalir.ForeColor = System.Drawing.Color.DimGray
        Me.bSalir.Location = New System.Drawing.Point(773, -1)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(42, 36)
        Me.bSalir.TabIndex = 80
        Me.bSalir.Text = "X"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bMinimizar
        '
        Me.bMinimizar.ForeColor = System.Drawing.Color.DimGray
        Me.bMinimizar.Location = New System.Drawing.Point(740, -1)
        Me.bMinimizar.Name = "bMinimizar"
        Me.bMinimizar.Size = New System.Drawing.Size(37, 36)
        Me.bMinimizar.TabIndex = 79
        Me.bMinimizar.Text = "-"
        Me.bMinimizar.UseVisualStyleBackColor = True
        '
        'lTot
        '
        Me.lTot.AutoSize = True
        Me.lTot.Location = New System.Drawing.Point(701, 322)
        Me.lTot.Name = "lTot"
        Me.lTot.Size = New System.Drawing.Size(45, 13)
        Me.lTot.TabIndex = 81
        Me.lTot.Text = "TOTAL:"
        '
        'lTotal
        '
        Me.lTotal.AutoSize = True
        Me.lTotal.ForeColor = System.Drawing.Color.DarkGreen
        Me.lTotal.Location = New System.Drawing.Point(742, 322)
        Me.lTotal.Name = "lTotal"
        Me.lTotal.Size = New System.Drawing.Size(66, 13)
        Me.lTotal.TabIndex = 82
        Me.lTotal.Text = "Totalcompra"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(690, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 83
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(574, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Seleccione el Cliente:"
        '
        'fCarrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lTotal)
        Me.Controls.Add(Me.lTot)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bMinimizar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bEnviarVenta)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bSeguirComprando)
        Me.Controls.Add(Me.dCarrito)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fCarrito"
        Me.Text = "fCarrito"
        CType(Me.dCarrito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dCarrito As DataGridView
    Friend WithEvents bSeguirComprando As Button
    Friend WithEvents bCancelar As Button
    Friend WithEvents bEnviarVenta As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bSalir As Button
    Friend WithEvents bMinimizar As Button
    Friend WithEvents lTot As Label
    Protected Friend WithEvents lTotal As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
End Class
