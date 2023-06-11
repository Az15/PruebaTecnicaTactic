Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports AccesoDatos
Imports Modelos
Public Class Rproductos
    Dim contexto As New ContextoDB
    Dim con As New SqlConnection(contexto.connectionstring)

End Class
