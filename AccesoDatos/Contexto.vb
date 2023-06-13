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
        Dim ar As String
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


    'Prueba Basica SQL
    Function PruebaSQL()
        Try
            con.Open()
            Console.WriteLine("Conexion Exitosa. ")
            con.Close()
        Catch ex As Exception
            Console.WriteLine("Error de conexion")
        End Try
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

    Sub CargarCampos()
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

    Sub Buscar(Tabla As String, DatoTabla1 As String, DatoTabla2 As String, DatoTabla3 As String, ByVal condicion As String, gridview As DataGridView)
        'En el form agregamos el nombre de condicion seguido de un like seguido de la condicion y despues un % para que busque el resto.
        Dim da As New SqlDataAdapter("SELECT TOP (100) PERCENT ID," & DatoTabla1 & "," & DatoTabla2 & "," & DatoTabla3 & " FROM " & Tabla & " where " & DatoTabla1 & " like '" &
                                     condicion & "%' OR Id like '" & condicion & "%'" & "ORDER BY ID", con)
        Dim ds As New DataSet
        da.Fill(ds, Tabla)
        If ds.Tables(Tabla).Rows.Count = 0 Then
        Else
            gridview.DataSource = ds.Tables(Tabla)
            gridview.Refresh()
            gridview.Visible = True
        End If

    End Sub
    Sub Filtro(tabla As String, datoTabla1 As String, datoTabla2 As String, datoTabla3 As String, ByVal condicion As String, gridview As DataGridView)
        Dim x As Integer = 0, cosa As String
        Dim daprod As New SqlDataAdapter("select * from " & tabla & " where " & datoTabla1 & " like '%" & condicion & "%' OR " & datoTabla2 &
                                         " like '%" & condicion & "%'" & "OR " & datoTabla3 & " like '%" & condicion & "%'", con)
        Dim dsprod As New DataSet
        daprod.Fill(dsprod, tabla)
        gridview.DataSource = dsprod.Tables(tabla)
        gridview.Refresh()
    End Sub
    'Esto es para safar de las inyecciones basicas.
    Sub ArreglarCampo(ByRef campo As TextBox)
        campo.Text = campo.Text.Trim.Replace("'", "").Replace("""",
        "").Replace("*", "").Replace("+", "").Replace("-", "").Replace("/",
        "").Replace(":", "").Replace("`", "").Replace("<", "").Replace(">",
        "").Replace("=", "").Replace("&", "")
    End Sub

    Sub ArreglarCampo(ByRef campo As String)
        campo = campo.Trim.Replace("'", "").Replace("""",
        "").Replace("*", "").Replace("+", "").Replace("-", "").Replace("/",
        "").Replace(":", "").Replace("`", "").Replace("<", "").Replace(">",
        "").Replace("=", "").Replace("&", "")
    End Sub

    Public Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Sub ListarDatosDistinc(datotabla As String, tabla As String)
        Dim Query As String = "Select DISTINCT " & datotabla & " from " & tabla & " "

    End Sub
End Class
