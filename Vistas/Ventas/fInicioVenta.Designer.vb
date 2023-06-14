<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fInicioVenta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gListaClientes = New System.Windows.Forms.DataGridView()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.lCli = New System.Windows.Forms.Label()
        Me.bInicioVenta = New System.Windows.Forms.Button()
        Me.lClienteSelect = New System.Windows.Forms.Label()
        Me.lLegajo = New System.Windows.Forms.Label()
        Me.bVolver = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Seleccione el Cliente:"
        '
        'bMinimizar
        '
        Me.bMinimizar.ForeColor = System.Drawing.Color.DimGray
        Me.bMinimizar.Location = New System.Drawing.Point(336, -1)
        Me.bMinimizar.Name = "bMinimizar"
        Me.bMinimizar.Size = New System.Drawing.Size(37, 36)
        Me.bMinimizar.TabIndex = 90
        Me.bMinimizar.Text = "-"
        Me.bMinimizar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(461, 36)
        Me.PictureBox1.TabIndex = 89
        Me.PictureBox1.TabStop = False
        '
        'gListaClientes
        '
        Me.gListaClientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.gListaClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gListaClientes.ColumnHeadersVisible = False
        Me.gListaClientes.GridColor = System.Drawing.SystemColors.Control
        Me.gListaClientes.Location = New System.Drawing.Point(15, 76)
        Me.gListaClientes.Name = "gListaClientes"
        Me.gListaClientes.ReadOnly = True
        Me.gListaClientes.RowHeadersVisible = False
        Me.gListaClientes.Size = New System.Drawing.Size(244, 294)
        Me.gListaClientes.TabIndex = 85
        '
        'bSalir
        '
        Me.bSalir.ForeColor = System.Drawing.Color.DimGray
        Me.bSalir.Location = New System.Drawing.Point(372, -1)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(42, 36)
        Me.bSalir.TabIndex = 95
        Me.bSalir.Text = "X"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'lCli
        '
        Me.lCli.AutoSize = True
        Me.lCli.Location = New System.Drawing.Point(265, 76)
        Me.lCli.Name = "lCli"
        Me.lCli.Size = New System.Drawing.Size(107, 13)
        Me.lCli.TabIndex = 96
        Me.lCli.Text = "cliente seleccionado:"
        '
        'bInicioVenta
        '
        Me.bInicioVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bInicioVenta.Location = New System.Drawing.Point(268, 141)
        Me.bInicioVenta.Name = "bInicioVenta"
        Me.bInicioVenta.Size = New System.Drawing.Size(75, 23)
        Me.bInicioVenta.TabIndex = 97
        Me.bInicioVenta.Text = "Iniciar Venta"
        Me.bInicioVenta.UseVisualStyleBackColor = False
        '
        'lClienteSelect
        '
        Me.lClienteSelect.AutoSize = True
        Me.lClienteSelect.ForeColor = System.Drawing.Color.Green
        Me.lClienteSelect.Location = New System.Drawing.Point(265, 98)
        Me.lClienteSelect.Name = "lClienteSelect"
        Me.lClienteSelect.Size = New System.Drawing.Size(41, 13)
        Me.lClienteSelect.TabIndex = 98
        Me.lClienteSelect.Text = "Prueba"
        Me.lClienteSelect.Visible = False
        '
        'lLegajo
        '
        Me.lLegajo.AutoSize = True
        Me.lLegajo.Location = New System.Drawing.Point(379, 76)
        Me.lLegajo.Name = "lLegajo"
        Me.lLegajo.Size = New System.Drawing.Size(13, 13)
        Me.lLegajo.TabIndex = 99
        Me.lLegajo.Text = "0"
        Me.lLegajo.Visible = False
        '
        'bVolver
        '
        Me.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bVolver.Location = New System.Drawing.Point(265, 179)
        Me.bVolver.Name = "bVolver"
        Me.bVolver.Size = New System.Drawing.Size(89, 23)
        Me.bVolver.TabIndex = 100
        Me.bVolver.Text = "Volver al Menu"
        Me.bVolver.UseVisualStyleBackColor = False
        '
        'fInicioVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 381)
        Me.Controls.Add(Me.bVolver)
        Me.Controls.Add(Me.lLegajo)
        Me.Controls.Add(Me.lClienteSelect)
        Me.Controls.Add(Me.bInicioVenta)
        Me.Controls.Add(Me.lCli)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bMinimizar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gListaClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fInicioVenta"
        Me.Text = "fInicioVenta"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gListaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents bMinimizar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gListaClientes As DataGridView
    Friend WithEvents bSalir As Button
    Friend WithEvents lCli As Label
    Friend WithEvents bInicioVenta As Button
    Friend WithEvents lClienteSelect As Label
    Friend WithEvents lLegajo As Label
    Friend WithEvents bVolver As Button
End Class
