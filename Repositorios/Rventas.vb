Imports System.Windows.Forms
Imports AccesoDatos
Public Class Rventas
    Dim contexto As New ContextoDB
    Dim modeloventa As New Modelos.MVentas
    Dim modeloItems As New Modelos.MVentasitems
    Dim Tabla As String = "Ventas"
    Dim Dato1T1 As String = "Total"
    Dim Dato2T1IDVENTAS = "IdVenta"
    Dim tabla2 As String = "VentasItems"
    Dim Dato1T2 As String = "IdCliente"
    Dim Dato2T2 As String = "IdProducto"
    Dim Dato3T2 As String = "PrecioUnitario"
    Dim Dato4T2 As String = "Cantidad"
    Dim Dato5T2 As String = "PrecioTotal"

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

    Public Sub ActualizarVentasD(idVenta As String, total As String)
        contexto.ActualizarVentaD(idVenta, total)
    End Sub

    Public Sub EliminarVenta(idVenta As Integer)
        contexto.EliminarVentaItems(idVenta)
        contexto.EliminarVenta(idVenta)
    End Sub

    Public Function ObtenerVentaPorCliente(idCliente As String) As DataTable
        Return contexto.ObtenerVentasPorCliente(idCliente)
    End Function

    Sub MostrarHistorial(gVentas As DataGridView)
        contexto.ObtenerVentas(gVentas, Tabla)
    End Sub
    Sub MostrarDetalle(gVentas As DataGridView, lLegajo As String)
        contexto.ObtenerDetalle(gVentas, tabla2, Dato2T1IDVENTAS, lLegajo)
    End Sub

    Sub CargarCampo(lLegajo As Label, lNombre As Label, lTotal As Label)
        contexto.CargarCamposC(Tabla, Dato1T2, Dato1T1, lLegajo, lNombre, lTotal)
    End Sub
    Sub CargarCampo2(lLegajo As Label, lNombre As Label, lPrecioU As Label, tCantidad As TextBox, lPrecioTotal As Label)
        contexto.CargarCamposDetalle(tabla2, Dato2T2, Dato3T2, Dato4T2, Dato5T2,
                                     lLegajo, lNombre, lPrecioU, tCantidad, lPrecioTotal)
    End Sub

    Public Sub EliminarItemCompra(idItem As Integer)
        contexto.EliminarItemCompra(idItem)
    End Sub

    Public Sub ObtenerVentaItem(gDetalle As DataGridView, lLegajo As String)
        contexto.ObtenerVentasItems(gDetalle, lLegajo)
    End Sub

End Class
