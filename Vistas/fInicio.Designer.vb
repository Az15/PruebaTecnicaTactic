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
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bUsuarioABM = New System.Windows.Forms.Button()
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
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(48, 314)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(217, 72)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Ventas"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(48, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(217, 72)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Productos"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'bUsuarioABM
        '
        Me.bUsuarioABM.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bUsuarioABM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bUsuarioABM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bUsuarioABM.Location = New System.Drawing.Point(48, 90)
        Me.bUsuarioABM.Name = "bUsuarioABM"
        Me.bUsuarioABM.Size = New System.Drawing.Size(217, 72)
        Me.bUsuarioABM.TabIndex = 7
        Me.bUsuarioABM.Text = "Usuarios"
        Me.bUsuarioABM.UseVisualStyleBackColor = False
        '
        'fInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(310, 450)
        Me.Controls.Add(Me.bMinimizar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bUsuarioABM)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fInicio"
        Me.Text = "fInicio"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bMinimizar As Button
    Friend WithEvents bSalir As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bUsuarioABM As Button
End Class
