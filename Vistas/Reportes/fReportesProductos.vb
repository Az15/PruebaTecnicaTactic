Public Class fReportesProductos
    Private Sub fReportesProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsReportes.productos' Puede moverla o quitarla según sea necesario.
        Me.productosTableAdapter.Fill(Me.DsReportes.productos)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub bMinimizar_Click(sender As Object, e As EventArgs) Handles bMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        If MessageBox.Show("¿Está seguro de que desea salir del Programa?", "Salir del Programa",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then Application.Exit()
    End Sub

    Private Sub bVolver_Click(sender As Object, e As EventArgs) Handles bVolver.Click
        Me.Close()
        My.Forms.fProductos.Visible = True
    End Sub
End Class