Imports Repositorios

Public Class fVentasHistorial
    Dim repositoriovENTAS As New Rventas
    Private Sub fVentasHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        repositoriovENTAS.MostrarHistorial(gHistoricoVentas)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Application.Exit()
    End Sub

    Private Sub bMenu_Click(sender As Object, e As EventArgs) Handles bMenu.Click
        Me.Visible = False
        My.Forms.fInicio.Visible = True
    End Sub

    Private Sub gHistoricoVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gHistoricoVentas.CellContentClick
        FilaClick(e)
    End Sub


    Private Sub bEliminarVenta_Click(sender As Object, e As EventArgs) Handles bEliminarVenta.Click
        repositoriovENTAS.EliminarVenta(lLegajo.Text)
        repositoriovENTAS.MostrarHistorial(gHistoricoVentas)

    End Sub

    Private Sub bDetalleVenta_Click(sender As Object, e As EventArgs) Handles bDetalleVenta.Click
        Me.Visible = False
        My.Forms.fVentaDetalle.Visible = True
        repositoriovENTAS.MostrarDetalle(My.Forms.fVentaDetalle.gDetalle, lLegajo.Text)
    End Sub


    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(gHistoricoVentas.Rows(fila).Cells(0).Value) Then
            Exit Sub
        Else
            tfila = gHistoricoVentas.Rows(fila).Cells(0).Value
            lLegajo.Text = tfila.ToString()
            repositoriovENTAS.CargarCampo(lLegajo, lNombre, lTotal)

        End If
    End Sub

    Private Sub bReportes_Click(sender As Object, e As EventArgs) Handles bReportes.Click
        My.Forms.fVentasHistorial.Visible = False
        My.Forms.fRVentasHistorico.Visible = True
    End Sub

    Private Sub bMinimizar_Click(sender As Object, e As EventArgs) Handles bMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Para dar funcionalidad y mover los forms
    Dim m As Integer = 0, mx As Integer, mi As Integer
    Private Sub fVentasHistorial_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        m = 0
    End Sub

    Private Sub fVentasHistorial_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If m = 1 Then

            Me.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - mi)
        End If
    End Sub

    Private Sub fVentasHistorial_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        m = 1
        mx = e.X
        mi = e.Y
    End Sub
End Class