Public Class MProductos

    Private ID As Integer
    Private Nombre As String
    Private Precio As Decimal
    Private Categoria As String

    Public Sub New()
    End Sub

    Public Sub New(iD As Integer, nombre As String, precio As Decimal, categoria As String,
                   iD1 As Integer, nombre1 As String, precio1 As Decimal, categoria1 As String)
        Me.ID = iD
        Me.Nombre = nombre
        Me.Precio = precio
        Me.Categoria = categoria
        Me.ID1 = iD1
        Me.Nombre1 = nombre1
        Me.Precio1 = precio1
        Me.Categoria1 = categoria1
    End Sub

    Public Sub New(iD As Integer, nombre As String, precio As Decimal, categoria As String)
        Me.ID = iD
        Me.Nombre = nombre
        Me.Precio = precio
        Me.Categoria = categoria
    End Sub

    Public Property ID1 As Integer
        Get
            Return ID
        End Get
        Set(value As Integer)
            ID = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property Precio1 As Decimal
        Get
            Return Precio
        End Get
        Set(value As Decimal)
            Precio = value
        End Set
    End Property

    Public Property Categoria1 As String
        Get
            Return Categoria
        End Get
        Set(value As String)
            Categoria = value
        End Set
    End Property

    Sub setUserall(ByRef Nombre, ByRef Precio, ByRef Categoria)
        Nombre1 = Nombre
        Precio1 = Precio
        Categoria1 = Categoria
    End Sub
End Class
