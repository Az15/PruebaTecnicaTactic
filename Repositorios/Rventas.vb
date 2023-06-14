Imports System.Windows.Forms
Imports AccesoDatos
Public Class Rventas
    Dim contexto As New ContextoDB
    Dim modeloventa As New Modelos.MVentas
    Dim modeloItems As New Modelos.MVentasitems

    Sub MostrarClientes(gvercliente As DataGridView)
        contexto.ShowOneColGrid("clientes", "Cliente", gvercliente)
    End Sub
    Sub LlenarCampos(lLegajo As Label, lClienteSel As Label)
        contexto.CargarVenta("clientes", lLegajo, lClienteSel, "cliente")
    End Sub

End Class
