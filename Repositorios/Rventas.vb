Imports System.Windows.Forms
Imports AccesoDatos
Public Class Rventas
    Dim contexto As New ContextoDB
    Dim modeloventa As New Modelos.MVentas
    Dim modeloItems As New Modelos.MVentasitems

    Public Function ObtenerClientes() As DataTable
        Return contexto.ObtenerClientes()
    End Function
    Public Sub CrearVenta(idCliente As Integer, fecha As Date)
        contexto.CrearVenta(idCliente, fecha)
    End Sub

    Public Sub CrearVentaItem(idVenta As Integer, idProducto As Integer, precio As Decimal, cantidad As Integer, precioTotal As Decimal)
        contexto.CrearVentaItem(idVenta, idProducto, precio, cantidad, precioTotal)
    End Sub

    Public Sub ActualizarVenta(idVenta As Integer, fecha As Date, total As Decimal)
        contexto.ActualizarVenta(idVenta, fecha, total)
    End Sub

    Public Sub EliminarVenta(idVenta As Integer)
        contexto.EliminarVenta(idVenta)
        contexto.EliminarVentaItems(idVenta)
    End Sub

    Public Function ObtenerVentaPorCliente(idCliente As String) As DataTable
        Return contexto.ObtenerVentasPorCliente(idCliente)
    End Function

End Class
