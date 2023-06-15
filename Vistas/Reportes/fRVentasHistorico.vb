Public Class fRVentasHistorico
    Private Sub fRVentasHistorico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsReportes.ventasHistorico' Puede moverla o quitarla según sea necesario.
        Me.ventasHistoricoTableAdapter.Fill(Me.DsReportes.ventasHistorico)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub bVolver_Click(sender As Object, e As EventArgs) Handles bVolver.Click
        Me.Close()
        My.Forms.fVentasHistorial.Visible = True
    End Sub
    'Para dar funcionalidad y mover los forms
    Dim m As Integer = 0, mx As Integer, mi As Integer
    Private Sub fRVentasHistorico_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        m = 0
    End Sub

    Private Sub fRVentasHistorico_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If m = 1 Then

            Me.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - mi)
        End If
    End Sub

    Private Sub fRVentasHistorico_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        m = 1
        mx = e.X
        mi = e.Y
    End Sub

    Private Sub bMinimizar_Click(sender As Object, e As EventArgs) Handles bMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        If MessageBox.Show("¿Está seguro de que desea salir del Programa?", "Salir del Programa",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then Application.Exit()
    End Sub
End Class