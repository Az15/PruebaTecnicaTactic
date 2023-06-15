Public Class fVentaDetalle
    Dim repositorioventa As New Repositorios.Rventas

    Private Sub fVentaDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        repositorioventa.ObtenerVentaItem(gDetalle, My.Forms.fVentasHistorial.lLegajo.Text)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Application.Exit()
    End Sub

    Private Sub bMenuH_Click(sender As Object, e As EventArgs) Handles bMenuH.Click
        repositorioventa.MostrarHistorial(My.Forms.fVentasHistorial.gHistoricoVentas)
        Me.Close()
        My.Forms.fVentasHistorial.Visible = True

    End Sub

    Private Sub gDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gDetalle.CellContentClick
        FilaClick(e)
    End Sub

    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String
        If IsNothing(gDetalle.Rows(fila).Cells(0).Value) Then
            Exit Sub
        Else
            tfila = gDetalle.Rows(fila).Cells(0).Value
            lLegajo.Text = tfila.ToString()
            repositorioventa.CargarCampo2(lLegajo, lNombre, lCostoUnidad, tUnidades, lCostoTotal)

        End If
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        repositorioventa.EliminarItemCompra(lLegajo.Text)
        repositorioventa.MostrarDetalle(gDetalle, My.Forms.fVentasHistorial.lLegajo.Text)
        Dim TotalNuevo = Double.Parse(My.Forms.fVentasHistorial.lTotal.Text) - Double.Parse(lCostoTotal.Text)
        My.Forms.fVentasHistorial.lTotal.Text = TotalNuevo
        repositorioventa.ActualizarVentasD(My.Forms.fVentasHistorial.lLegajo.Text, TotalNuevo)
        LimpiarCampos()
    End Sub


    Sub LimpiarCampos()
        lCostoTotal.Text = ""
        lLegajo.Text = ""
        lNombre.Text = ""
        lCostoUnidad.Text = ""
        tUnidades.Text = ""
    End Sub

    Private Sub bMinimizar_Click(sender As Object, e As EventArgs) Handles bMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class