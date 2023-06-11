Public Class MVentasitems
    'Atributos
    Private ID As Integer
    Private IDVenta As Integer
    Private IDProducto As Integer
    Private PrecioUnitario As Double
    Private Cantidad As String
    Private PrecioTotal As Double

    'sobrecarga de constructores por si requerimos trabajar los Modelos de manera flexible.
    Public Sub New()
    End Sub

    Public Sub New(iD As Integer, iDVenta As Integer, iDProducto As Integer, precioUnitario As Double, cantidad As String, precioTotal As Double)
        Me.ID = iD
        Me.IDVenta = iDVenta
        Me.IDProducto = iDProducto
        Me.PrecioUnitario = precioUnitario
        Me.Cantidad = cantidad
        Me.PrecioTotal = precioTotal
    End Sub

    Public Sub New(iD As Integer, iDVenta As Integer, iDProducto As Integer, precioUnitario As Double,
                   cantidad As String, precioTotal As Double, iD1 As Integer, iDVenta1 As Integer,
                   iDProducto1 As Integer, precioUnitario1 As Double, cantidad1 As String,
                   precioTotal1 As Double)
        Me.New(iD, iDVenta, iDProducto, precioUnitario, cantidad, precioTotal)
        Me.ID1 = iD1
        Me.IDVenta1 = iDVenta1
        Me.IDProducto1 = iDProducto1
        Me.PrecioUnitario1 = precioUnitario1
        Me.Cantidad1 = cantidad1
        Me.PrecioTotal1 = precioTotal1
    End Sub

    'Set y Get de Atributos.
    Public Property ID1 As Integer
        Get
            Return ID
        End Get
        Set(value As Integer)
            ID = value
        End Set
    End Property

    Public Property IDVenta1 As Integer
        Get
            Return IDVenta
        End Get
        Set(value As Integer)
            IDVenta = value
        End Set
    End Property

    Public Property IDProducto1 As Integer
        Get
            Return IDProducto
        End Get
        Set(value As Integer)
            IDProducto = value
        End Set
    End Property

    Public Property PrecioUnitario1 As Double
        Get
            Return PrecioUnitario
        End Get
        Set(value As Double)
            PrecioUnitario = value
        End Set
    End Property

    Public Property Cantidad1 As String
        Get
            Return Cantidad
        End Get
        Set(value As String)
            Cantidad = value
        End Set
    End Property

    Public Property PrecioTotal1 As Double
        Get
            Return PrecioTotal
        End Get
        Set(value As Double)
            PrecioTotal = value
        End Set
    End Property


End Class
