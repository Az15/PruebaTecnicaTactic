Imports Repositorios

Public Class fInicioVenta
    Private repositorio As New Rventas
    Private Sub fInicioVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        repositorio.MostrarClientes(gListaClientes)
    End Sub

    Private Sub gListaClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gListaClientes.CellContentClick
        FilaClick(e)

    End Sub

    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String
        If IsNothing(gListaClientes.Rows(fila).Cells(0).Value) Then
            Exit Sub
        Else
            tfila = gListaClientes.Rows(fila).Cells(0).Value
            lLegajo.Text = tfila.ToString()
            repositorio.LlenarCampos(lLegajo, lClienteSelect)
            lClienteSelect.Visible = True
        End If
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Application.Exit()
    End Sub

    Private Sub bVolver_Click(sender As Object, e As EventArgs) Handles bVolver.Click
        Dim resultado As DialogResult = MessageBox.Show("Esta seguro que desea salir al Menu", "Menu",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resultado = DialogResult.Yes Then
            My.Forms.fInicio.Visible = True
            Me.Visible = False
        End If
    End Sub
End Class