Public Class MClientes
    'Agregamos las propiedades de la clase. Atributos.
    Private _iD As Integer
    Private _cliente As String
    Private _telefono As String
    Private _correo As String

    'agregamos los constructores.
    Public Sub New()
    End Sub

    Public Sub New(iD As Integer, cliente As String, telefono As String, correo As String)
        _iD = iD
        _cliente = cliente
        _telefono = telefono
        _correo = correo
    End Sub


    Public Property ID As Integer
        Get
            Return _iD
        End Get
        Set(value As Integer)
            _iD = value
        End Set
    End Property

    Public Property Cliente As String
        Get
            Return _cliente
        End Get
        Set(value As String)
            _cliente = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Function setUserall(ByRef cliente, ByRef telefono, ByRef correo)
        _cliente = cliente
        _correo = correo
        _telefono = telefono
    End Function

End Class
