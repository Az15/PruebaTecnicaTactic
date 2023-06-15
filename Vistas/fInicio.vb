Imports Repositorios

Public Class fInicio
    Dim repos As New Rclientes
    Dim repos2 As New Rventas
    Private Sub bUsuarioABM_Click(sender As Object, e As EventArgs) Handles bUsuarioABM.Click
        Me.Visible = False
        My.Forms.fClientes.Visible = True
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        If MessageBox.Show("¿Está seguro de que desea salir del Programa?", "Salir del Programa",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    Private Sub fInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        repos.pruebasql()
    End Sub

    Private Sub bProductos_Click(sender As Object, e As EventArgs) Handles bProductos.Click
        Me.Visible = False
        My.Forms.fProductos.Visible = True
    End Sub

    Private Sub bVentas_Click(sender As Object, e As EventArgs) Handles bVentas.Click
        Me.Visible = False
        My.Forms.fVentas.cbClientes.Text = ""
        My.Forms.fVentas.Visible = True
    End Sub

    Private Sub bHistorial_Click(sender As Object, e As EventArgs) Handles bHistorial.Click
        Me.Visible = False
        My.Forms.fVentasHistorial.Visible = True
        repos2.MostrarHistorial(My.Forms.fVentasHistorial.gHistoricoVentas)
    End Sub

    Private Sub bMinimizar_Click(sender As Object, e As EventArgs) Handles bMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Para dar funcionalidad y mover los forms
    Dim m As Integer = 0, mx As Integer, mi As Integer
    Private Sub fInicio_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        m = 0
    End Sub

    Private Sub fInicio_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If m = 1 Then
            Me.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - mi)
        End If
    End Sub

    Private Sub fInicio_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        m = 1
        mx = e.X
        mi = e.Y
    End Sub
End Class
