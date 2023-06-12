Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports AccesoDatos
Imports Modelos
Imports Modelos.MClientes

Public Class Rclientes
    'Instanciamos el contexto para trabajar con las querys de manera correcta.
    Dim contexto As New ContextoDB
    'Declaramos las variables relacionadas a los datos de tabla.
    Private tabla As String = "clientes"
    Private dato1 As String = "Cliente"
    Private dato2 As String = "Correo"
    Private dato3 As String = "Telefono"
    Private comprobacion As Boolean

    'FUNCIONES Y VOID DE ALTA,BAJA Y MODIFICACION. Tambien Ver/Mostrar.
    '---------------------------------------------------------------------------------------------------------------------

    'Como se solicito creamos las querys de insertar, ver, eliminar y crear.
    Sub AltaCliente(mcliente As MClientes)
        Dim errores As String = "", en As String = vbCrLf
        If mcliente.Cliente.Trim.Length < 1 Then
            errores &= "Debe completar el Nombre del cliente." & en
        End If
        If mcliente.Correo.Trim.Length < 1 Then
            errores &= "Debe ingresar un correo." & en
        End If
        If mcliente.Telefono.Trim.Length < 1 Then
            errores &= "Debe ingresar un numero de contacto." & en
        End If
        If IsNumeric(mcliente.Telefono) Then
        Else
            errores &= "Debe ingresar numeros y no caracteres." & en
        End If
        If MailValido(mcliente.Correo) = False Then
            errores &= "Debe ingresar Email Valido." & en
        End If
        If errores.Length > 0 Then
            MsgBox("Hubo errores, por favor verifique y corrija antes de intentar de nuevo:" & en & en & errores)
            Exit Sub
        End If
        Dim Query = "INSERT INTO clientes (Cliente, Telefono, Correo) VALUES ('" & mcliente.Cliente + "', '" & mcliente.Telefono & "', '" & mcliente.Correo & "');"
        contexto.SQL_Accion(Query)
    End Sub
    'Utilizamos el SQLAccion para enviar la consulta de delete.
    Sub BajaCliente(tCliente As TextBox, lLegajo As Label, gridCliente As DataGridView)
        If MessageBox.Show("Está por ELIMINAR definitivamente al Cliente: " & tCliente.Text.Trim.ToUpper & ", Está SEGURO?",
                           "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                           MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        '-------------------------------------------------------------------------------------------------------------------'
        If contexto.SQL_Accion("delete from pruebademo.dbo.Clientes  where  ID =" & Val(lLegajo.Text)) = False Then
            MsgBox("Hubo un error al intentar borrar al Cliente, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        Else
            buscar(" ID =" & Val(lLegajo.Text), gridCliente)
            MsgBox("El Cliente fue ELIMINADO de la base de datos.")
            lLegajo.Text.Replace(lLegajo.Text, "0")
            contexto.ShowGrid(tabla, gridCliente)

        End If
    End Sub
    'Realizamos una comprobacion rapida de campos.
    Sub ModificacionCliente(tCliente As TextBox, tCorreo As TextBox, tTelefono As TextBox, lLegajo As String)
        Dim errores As String = "", en As String = vbCrLf
        If tCliente.Text.Trim.Length < 1 Then
            errores &= "Debe completar el Nombre del cliente." & en
        End If
        If tCorreo.Text.Trim.Length < 1 Then
            errores &= "Debe ingresar un correo." & en
        End If
        If tTelefono.Text.Trim.Length < 1 Then
            errores &= "Debe ingresar un numero de contacto." & en
        End If
        If IsNumeric(tTelefono.Text) Then
        Else
            errores &= "Debe ingresar numeros y no caracteres." & en
        End If
        ' ArreglarCampo(tCorreo)
        If MailValido(tCorreo.Text) = False Then
            errores &= "Debe ingresar Email Valido." & en
        Else

        End If

        If errores.Length > 0 Then
            MsgBox("Hubo errores, por favor verifique y corrija antes de intentar de nuevo:" & en & en & errores)
            Exit Sub
        End If

        If contexto.SQL_Accion("UPDATE pruebademo.dbo.Clientes SET Cliente='" & tCliente.Text.Trim.ToUpper.Replace("'", "´") &
                   "', Telefono='" & tTelefono.Text.Trim.ToUpper.Replace("'", "´") & "', Correo='" & tCorreo.Text.Trim.Replace("'", "´") & "'" &
                   " WHERE ID=" & VNum(lLegajo)) = True Then
            MsgBox("Cambios realizados correctamente.")
        Else
            MsgBox("Se produjo un error al querer guardar los datos del cliente, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        End If
    End Sub


    'Cargamos el nombre de la tabla y solo solicitamos el grid en el que queremos impactar los datos.
    Sub CargarClientes(gClientes As DataGridView)
        contexto.ShowGrid(tabla, gClientes)
    End Sub

    'Con el objeto contexto utilizamos un select para enviar los datos de tabla al gridview.
    Sub buscar(ByVal condicion As String, gridview As DataGridView)
        contexto.Buscar(tabla, dato1, dato2, dato3, condicion, gridview)
    End Sub

    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    'Con esta realizamos las pruebas a la base de datos.
    Sub pruebasql()
        contexto.PruebaSQL()
    End Sub

    'Con esta Sub vamos a cargar los datos en relacion al formulario mismo y los texbox y labels correspondientes.
    Sub CargarCamposClientes(lLegajo As Label, pBotones As Panel, pCampos As Panel, tCliente As TextBox,
                             tCorreo As TextBox, tTelefono As TextBox)

        contexto.CargarCampos(tabla, dato1, dato2, dato3, lLegajo, pBotones, pCampos, tCliente, tCorreo, tTelefono)
    End Sub


    'Este es particular del formulario.
    Sub LimpiarCampos(tCliente As TextBox, tCorreo As TextBox, tTelefono As TextBox)
        tCliente.Text = ""
        tCorreo.Text = ""
        tTelefono.Text = ""
    End Sub
    'Para limpiar un campo en particular.
    Sub LimpiarCampos(tdato As TextBox)
        tdato.Text = ""
    End Sub
    'revisamos que los datos de la tabla no esten repetidos.
    Function ComprobacionCliente(campocliente As String) As Boolean
        Dim datotabla
        For dt1 = 1 To 3 Step 1
            If dt1 = 1 Then
                datotabla = dato1
                'Cliente
            ElseIf dt1 = 2 Then
                datotabla = dato2
                'Correo
            ElseIf dt1 = 3 Then
                datotabla = dato3
                'Telefono
            End If
            'Realiza una validacion en todos los campos dependiendo el estado del ciclo.
            If contexto.YaExisteSQL("select * from clientes where " & datotabla & "='" & campocliente & "'") Then
                MessageBox.Show("Usted esta ingresando un " & datotabla & " que corresponde a un cliente ya dado de alta.", "Ya existe Cliente ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                comprobacion = True
                'Cerramos el For, con la condicion para que no valide el nuevo cliente
                dt1 = 3
            Else
                comprobacion = False
            End If

        Next
        Return comprobacion
    End Function

    Sub NoBasicInyeccion(campo As TextBox)
        contexto.ArreglarCampo(campo)
    End Sub
    Function VNum(ByVal NTexto As String) As Decimal
        Return CDec(Val(NTexto.Trim.Replace(",", ".")))
    End Function

    Function ArreglarCampo(campo As TextBox)
        contexto.ArreglarCampo(campo)
    End Function

    Function MailValido(campo As String) As Boolean
        Return contexto.ValidateEmail(campo)
    End Function

End Class
