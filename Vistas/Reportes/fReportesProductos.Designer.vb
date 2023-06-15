<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fReportesProductos
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.productosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsReportes = New Vistas.DsReportes()
        Me.productosTableAdapter = New Vistas.DsReportesTableAdapters.productosTableAdapter()
        Me.bMinimizar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bVolver = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.productosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'productosBindingSource
        '
        Me.productosBindingSource.DataMember = "productos"
        Me.productosBindingSource.DataSource = Me.DsReportes
        '
        'DsReportes
        '
        Me.DsReportes.DataSetName = "DsReportes"
        Me.DsReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'productosTableAdapter
        '
        Me.productosTableAdapter.ClearBeforeFill = True
        '
        'bMinimizar
        '
        Me.bMinimizar.ForeColor = System.Drawing.Color.DimGray
        Me.bMinimizar.Location = New System.Drawing.Point(726, -2)
        Me.bMinimizar.Name = "bMinimizar"
        Me.bMinimizar.Size = New System.Drawing.Size(37, 36)
        Me.bMinimizar.TabIndex = 54
        Me.bMinimizar.Text = "-"
        Me.bMinimizar.UseVisualStyleBackColor = True
        '
        'bSalir
        '
        Me.bSalir.ForeColor = System.Drawing.Color.DimGray
        Me.bSalir.Location = New System.Drawing.Point(759, -2)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(42, 36)
        Me.bSalir.TabIndex = 53
        Me.bSalir.Text = "X"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(801, 36)
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'bVolver
        '
        Me.bVolver.Location = New System.Drawing.Point(672, 424)
        Me.bVolver.Name = "bVolver"
        Me.bVolver.Size = New System.Drawing.Size(116, 23)
        Me.bVolver.TabIndex = 51
        Me.bVolver.Text = "Volver a Productos"
        Me.bVolver.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DsProductos"
        ReportDataSource1.Value = Me.productosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Vistas.RPproductos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 50)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 357)
        Me.ReportViewer1.TabIndex = 50
        '
        'fReportesProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.bMinimizar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bVolver)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fReportesProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fReportesProductos"
        CType(Me.productosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents productosBindingSource As BindingSource
    Friend WithEvents DsReportes As DsReportes
    Friend WithEvents productosTableAdapter As DsReportesTableAdapters.productosTableAdapter
    Friend WithEvents bMinimizar As Button
    Friend WithEvents bSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bVolver As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
