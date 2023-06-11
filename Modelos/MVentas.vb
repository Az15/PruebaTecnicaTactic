Public Class MVentas
    'Agregamos las propiedades de la clase. Atributos.

    Private ID As Integer
    Private IDCliente As Integer
    Private Fecha As String
    Private Correo As String

    'Realizamos un constructor vacio, uno con atributos.
    Public Sub New()
    End Sub

    Public Sub New(iD As Integer, iDCliente As Integer, fecha As String, correo As String, correo1 As String)
        Me.ID = iD
        Me.IDCliente = iDCliente
        Me.Fecha = fecha
        Me.Correo = correo
        Me.Correo1 = correo1
    End Sub

    Public Sub New(iD As Integer, iDCliente As Integer, fecha As String, correo As String,
                   iD1 As Integer, iDCliente1 As Integer, fecha1 As String, correo1 As String)
        Me.ID = iD
        Me.IDCliente = iDCliente
        Me.Fecha = fecha
        Me.Correo = correo
        Me.ID1 = iD1
        Me.IDCliente1 = iDCliente1
        Me.Fecha1 = fecha1
        Me.Correo1 = correo1
    End Sub

    'get y set.
    Public Property ID1 As Integer
        Get
            Return ID
        End Get
        Set(value As Integer)
            ID = value
        End Set
    End Property

    Public Property IDCliente1 As Integer
        Get
            Return IDCliente
        End Get
        Set(value As Integer)
            IDCliente = value
        End Set
    End Property

    Public Property Fecha1 As String
        Get
            Return Fecha
        End Get
        Set(value As String)
            Fecha = value
        End Set
    End Property

    Public Property Correo1 As String
        Get
            Return Correo
        End Get
        Set(value As String)
            Correo = value
        End Set
    End Property
End Class
