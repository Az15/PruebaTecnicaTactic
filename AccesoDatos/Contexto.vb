Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ContextoDB

    Public connectionstring As String = ConfigurationManager.ConnectionStrings(ConfigurationManager.AppSettings("Conexion")).ToString()
    Dim con As New SqlConnection(connectionstring)


    Function SQL_Accion(ByVal Sql_de_accion As String) As Boolean
        'Ejecuta la consulta de accion 'sql_de_accion' abriendo la conexion automaticamente
        'se da cuenta si es de insert, update o delete, porque mira dentro de la sentencia que se le pasa
        'devuelve true si se pudo hacer, y false si hubo algún error
        Dim adapter As New SqlDataAdapter, salida As Boolean = True
        Try
            con.Open()
            If Sql_de_accion.ToUpper.IndexOf("INSERT") Then
                'MsgBox(Sql_de_accion)
                adapter.InsertCommand = New SqlCommand(Sql_de_accion, con)
                adapter.InsertCommand.ExecuteNonQuery()
            Else
                If Sql_de_accion.ToUpper.IndexOf("UPDATE") Then
                    adapter.UpdateCommand = New SqlCommand(Sql_de_accion, con)
                    adapter.UpdateCommand.ExecuteNonQuery()
                Else
                    If Sql_de_accion.ToUpper.IndexOf("DELETE") Then
                        adapter.DeleteCommand = New SqlCommand(Sql_de_accion, con)
                        adapter.DeleteCommand.ExecuteNonQuery()
                    Else
                        'esta mal la sintaxis porque no hay ni insert, ni delete ni update
                        salida = False
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            salida = False
        End Try
        con.Close()
        Return salida
    End Function

    Function YaExisteSQL(ByVal sql As String) As Boolean
        'se le pasa un select de sql que en teoria busca algo, por ejemplo un numero de cheque, si hay registros la fun devuelve 
        'true, estilo "el cheque ya existe", si no esta, devuelve false
        Dim da1 As New SqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "afidesc")
        If ds1.Tables("afidesc").Rows.Count < 1 Then
            Return False
        Else
            Return True
        End If
    End Function

    'Hacemos una sobrecarga de Subs para utilizarla dependiendo la necesidad.
    Sub CargarCampos(Tabla As String, Datotabla1 As String, Datotabla2 As String, Datotabla3 As String,
                     lLegajo As Label, pBotones As Panel, pCampos As Panel, tDato1 As TextBox,
                     tDato2 As TextBox, tDato3 As TextBox)

        If Val(lLegajo.Text) = 0 Then
            pBotones.Visible = False
            pCampos.Visible = False

            Exit Sub
        Else
            pBotones.Visible = True
            pCampos.Visible = True
            Dim da As New SqlDataAdapter("SELECT upper(ltrim(rtrim(isnull(" & Datotabla1 & ",'****')))) as " & Datotabla1 & ", upper(ltrim(rtrim(isnull(" & Datotabla2 & ",'****')))) as " & Datotabla2 & ",ltrim(rtrim(isnull(" & Datotabla3 & ",''))) as " & Datotabla3 & " from " & Tabla & " where ID=" & Val(lLegajo.Text), con)
            Dim ds As New DataSet
            da.Fill(ds, Tabla)
            tDato1.Text = ds.Tables(Tabla).Rows(0)(Datotabla1)
            tDato2.Text = ds.Tables(Tabla).Rows(0)(Datotabla2)
            tDato3.Text = ds.Tables(Tabla).Rows(0)(Datotabla3)
        End If
    End Sub


    Sub CargarCamposV(Tabla As String, Datotabla1 As String, Datotabla2 As String, Datotabla3 As String,
                     IdProducto As String, tDato1 As TextBox,
                     tDato2 As TextBox)

        If Val(IdProducto) = 0 Then
            Console.WriteLine("Error relacionado al legajo seleccionado")
            Exit Sub
        Else
            Dim da As New SqlDataAdapter("SELECT upper(ltrim(rtrim(isnull(" & Datotabla1 & ",'****')))) as " & Datotabla1 & ", upper(ltrim(rtrim(isnull(" & Datotabla2 & ",'****')))) as " & Datotabla2 & " from " & Tabla & " where ID=" & Val(IdProducto), con)
            Dim ds As New DataSet
            da.Fill(ds, Tabla)
            tDato1.Text = ds.Tables(Tabla).Rows(0)(Datotabla1)
            tDato2.Text = ds.Tables(Tabla).Rows(0)(Datotabla2)
        End If
    End Sub


    'Enviar los datos de la base de datos a la grilla
    Sub ShowGrid(tabla As String, DataGrid As DataGridView)

        Dim da As New SqlDataAdapter("SELECT * from " & tabla & " order by Id", con)
        Dim ds As New DataSet
        da.Fill(ds, tabla)

        If ds.Tables(tabla).Rows.Count = 0 Then
            DataGrid.Visible = False

        Else

            DataGrid.DataSource = ds.Tables(tabla)
            DataGrid.Refresh()
            DataGrid.ClearSelection()
            DataGrid.Visible = True
        End If
    End Sub


    'Filtra por un solo dato de tabla.
    Sub Buscar(Tabla As String, DatoTabla1 As String, DatoTabla2 As String, DatoTabla3 As String, ByVal condicion As String, gridview As DataGridView)
        'En el form agregamos el nombre de condicion seguido de un like seguido de la condicion y despues un % para que busque el resto.
        Dim da As New SqlDataAdapter("Select TOP (100) PERCENT ID," & DatoTabla1 & "," & DatoTabla2 & "," & DatoTabla3 & " FROM " & Tabla & " where " & DatoTabla1 & " Like '%" & condicion & "%' OR " & DatoTabla2 &
                                         " like '%" & condicion & "%'" & "OR " & DatoTabla3 & " like '%" & condicion & "%'" & "ORDER BY ID", con)
        Dim ds As New DataSet
        da.Fill(ds, Tabla)
        If ds.Tables(Tabla).Rows.Count = 0 Then
        Else
            gridview.DataSource = ds.Tables(Tabla)
            gridview.Refresh()
            gridview.Visible = True
        End If

    End Sub

    '--------------------------------------------------------------------------------------
    'Esto es para safar de las inyecciones basicas.
    Sub ArreglarCampo(ByRef campo As TextBox)
        campo.Text = campo.Text.Trim.Replace("'", "").Replace("""",
        "").Replace("*", "").Replace("+", "").Replace("-", "").Replace("/",
        "").Replace(":", "").Replace("`", "").Replace("<", "").Replace(">",
        "").Replace("=", "").Replace("&", "")
    End Sub
    '--------------------------------------------------------------------------------------


    'Validacion de Email para asegurar que cumpla todas las necesidades
    Public Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    'Filtro para Tipo de Producto.
    Sub ListarDatosDistinc(datotabla As String, tabla As String, comboBox As ComboBox)
        Dim Query As String = "Select DISTINCT " & datotabla & " from " & tabla
        Dim Command As New SqlCommand(Query, con)
        Dim Datatable As New DataTable()

        Try
            con.Open()
            Datatable.Load(Command.ExecuteReader())
            comboBox.DisplayMember = datotabla
            comboBox.ValueMember = datotabla
            comboBox.DataSource = Datatable
            con.Close()
        Catch ex As Exception

        End Try


    End Sub

    'Funciones Solo para ventas
    '--------------------------------------------------------------------------------------------------


    'Con esta funcion vamos a levantar en ventas en un combobox
    Public Function ObtenerClientes() As DataTable
        Dim query As String = "SELECT Id, Cliente FROM Clientes"
        Dim dataTable As New DataTable()
        Using command As New SqlCommand(query, con)
            con.Open()
            Using adapter As New SqlDataAdapter(command)
                adapter.Fill(dataTable)
            End Using
            con.Close()
        End Using
        Return dataTable
    End Function


    Public Sub CrearVenta(idCliente As Integer, fecha As Date)
        Dim query As String = "INSERT INTO Ventas (IdCliente, Fecha) VALUES (@IdCliente, @Fecha)"
        Using command As New SqlCommand(query, con)
            command.Parameters.AddWithValue("@IdCliente", idCliente)
            command.Parameters.AddWithValue("@Fecha", fecha)
            con.Open()
            command.ExecuteNonQuery()
            con.Close()
        End Using

    End Sub
    Public Sub CrearVentaItem(idVenta As Integer, idProducto As Integer, precio As Decimal, cantidad As Integer, precioTotal As Decimal)
        Dim query As String = "INSERT INTO VentasItems (IdVenta, IdProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@IdVenta, @IdProducto, @Precio, @Cantidad, @PrecioTotal)"
        Using command As New SqlCommand(query, con)
            command.Parameters.AddWithValue("@IdVenta", idVenta)
            command.Parameters.AddWithValue("@IdProducto", idProducto)
            command.Parameters.AddWithValue("@Precio", precio)
            command.Parameters.AddWithValue("@Cantidad", cantidad)
            command.Parameters.AddWithValue("@PrecioTotal", precioTotal)
            con.Open()
            command.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

    Public Sub ActualizarVenta(idVenta As Integer, fecha As Date, total As Decimal)
        Dim query As String = "UPDATE Ventas SET Fecha = @Fecha, Total = @Total WHERE Id = @IdVenta"
        Using command As New SqlCommand(query, con)
            command.Parameters.AddWithValue("@Fecha", fecha)
            command.Parameters.AddWithValue("@Total", total)
            command.Parameters.AddWithValue("@IdVenta", idVenta)
            con.Open()
            command.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

    Public Sub ActualizarVentaD(idVenta As Integer, total As Decimal)
        Dim query As String = "UPDATE Ventas SET Total = @Total WHERE Id = @IdVenta"
        Using command As New SqlCommand(query, con)
            command.Parameters.AddWithValue("@Total", total)
            command.Parameters.AddWithValue("@IdVenta", idVenta)
            con.Open()
            command.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

    Public Sub EliminarVenta(idVenta As Integer)
        Dim query As String = "DELETE FROM Ventas WHERE Id = @IdVenta"
        Using command As New SqlCommand(query, con)
            command.Parameters.AddWithValue("@IdVenta", idVenta)
            con.Open()
            command.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

    Public Sub EliminarVentaItems(idVenta As Integer)
        Dim query As String = "DELETE FROM VentasItems WHERE IdVenta = @IdVenta"
        Using command As New SqlCommand(query, con)
            command.Parameters.AddWithValue("@IdVenta", idVenta)
            con.Open()
            command.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

    Public Function ObtenerVentasPorCliente(idCliente As Integer) As DataTable
        Dim query As String = "SELECT Id, Fecha, Total FROM Ventas WHERE IdCliente = @IdCliente"
        Dim dataTable As New DataTable()
        Using command As New SqlCommand(query, con)
            command.Parameters.AddWithValue("@IdCliente", idCliente)
            con.Open()
            Using adapter As New SqlDataAdapter(command)
                adapter.Fill(dataTable)
            End Using
            con.Close()
        End Using
        Return dataTable
    End Function

    Sub ObtenerVentas(gVentas As DataGridView, tabla As String)
        Dim query As String = "SELECT * FROM " & tabla & " Order By Id"
        Dim da As New SqlDataAdapter(query, con)
        Dim ds As New DataSet
        da.Fill(ds, tabla)
        If ds.Tables(tabla).Rows.Count = 0 Then
            gVentas.Visible = False
        Else
            gVentas.DataSource = ds.Tables(tabla)
            gVentas.Refresh()
            gVentas.Visible = True
        End If
    End Sub
    'Error a solucionar con detalles.
    Sub ObtenerDetalle(gDetalle As DataGridView, tabla As String,where As String, id As String)
        Dim query As String = "SELECT * FROM " & tabla & " where " & where & "= " & id
        Dim da As New SqlDataAdapter(query, con)
        Dim ds As New DataSet
        da.Fill(ds, where)
        If ds.Tables(where).Rows.Count = 0 Then
            gDetalle.Visible = False
        Else
            gDetalle.DataSource = ds.Tables(where)
            gDetalle.Refresh()
            gDetalle.Visible = True
        End If
    End Sub


    Sub CargarCamposC(Tabla As String, Datotabla1 As String, Datotabla2 As String,
                      lLegajo As Label, tDato1 As Label, tDato2 As Label)
        If Val(lLegajo.Text) = 0 Then
            Exit Sub
        Else
            Dim da As New SqlDataAdapter("SELECT upper(ltrim(rtrim(isnull(" & Datotabla1 & ",'****')))) as " & Datotabla1 &
                        " ,upper(ltrim(rtrim(isnull(" & Datotabla2 & ",'****')))) as " & Datotabla2 &
                        " FROM " & Tabla & " where ID=" & Val(lLegajo.Text), con)

            Dim ds As New DataSet
            da.Fill(ds, Tabla)
            tDato1.Text = ds.Tables(Tabla).Rows(0)(Datotabla1)
            tDato2.Text = ds.Tables(Tabla).Rows(0)(Datotabla2)
            Dim da2 As New SqlDataAdapter("Select cliente from clientes where ID= " & Val(tDato1.Text), con)
            Dim ds2 As New DataSet
            da2.Fill(ds2, "Clientes")
            tDato1.Text = ds2.Tables("Clientes").Rows(0)("cliente")


        End If
    End Sub
    Public Sub EliminarItemCompra(idItem As Integer)
        Dim query As String = "DELETE FROM VentasItems WHERE Id = @IdItem"
        Using command As New SqlCommand(query, con)
            command.Parameters.AddWithValue("@IdItem", idItem)
            con.Open()
            command.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub
    Sub ObtenerVentasItems(gVentasDetalle As DataGridView, lLegajo As String)
        Dim query As String = "SELECT * FROM VentasItems where IdVenta= " & lLegajo & ""
        Dim da As New SqlDataAdapter(query, con)
        Dim ds As New DataSet
        da.Fill(ds, "Ventas")
        If ds.Tables("Ventas").Rows.Count = 0 Then
            gVentasDetalle.Visible = False
        Else
            gVentasDetalle.DataSource = ds.Tables("Ventas")
            gVentasDetalle.Refresh()
            gVentasDetalle.Visible = True
        End If
    End Sub

    Sub CargarCamposDetalle(Tabla As String, Datotabla1 As String, Datotabla2 As String, Datotabla3 As String, Datotabla4 As String,
                            lLegajo As Label, tDato1 As Label, lDato2 As Label, tDato3 As TextBox, lDato4 As Label)
        If Val(lLegajo.Text) = 0 Then
            Exit Sub
        Else
            Dim da As New SqlDataAdapter("SELECT upper(ltrim(rtrim(isnull(" & Datotabla1 & ",'****')))) as " & Datotabla1 & "," &
                                          "upper(ltrim(rtrim(isnull(" & Datotabla2 & ",'****')))) as " & Datotabla2 & "," &
                                         "upper(ltrim(rtrim(isnull(" & Datotabla3 & ",'****')))) as " & Datotabla3 & "," &
                                         "upper(ltrim(rtrim(isnull(" & Datotabla4 & ",'****')))) as " & Datotabla4 &
                                         " FROM " & Tabla & " where ID= " & Val(lLegajo.Text), con)
            Dim ds As New DataSet
            da.Fill(ds, Tabla)
            tDato1.Text = ds.Tables(Tabla).Rows(0)(Datotabla1)
            lDato2.Text = ds.Tables(Tabla).Rows(0)(Datotabla2)
            tDato3.Text = ds.Tables(Tabla).Rows(0)(Datotabla3)
            lDato4.Text = ds.Tables(Tabla).Rows(0)(Datotabla4)
            Dim da2 As New SqlDataAdapter("Select Nombre from Productos where ID= " & Val(tDato1.Text), con)
            Dim ds2 As New DataSet
            da2.Fill(ds2, "productos")
            tDato1.Text = ds2.Tables("Productos").Rows(0)("Nombre")
        End If
    End Sub

End Class
