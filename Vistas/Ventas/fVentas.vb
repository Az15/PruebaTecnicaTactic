Public Class fVentas
    Private Sub bVolver_Click(sender As Object, e As EventArgs) Handles bVolver.Click
        Dim resultado As DialogResult = MessageBox.Show("Esta seguro que desea salir al Menu", "Menu",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resultado = DialogResult.Yes Then
            My.Forms.fInicio.Visible = True
            Me.Visible = False
        End If
    End Sub
End Class