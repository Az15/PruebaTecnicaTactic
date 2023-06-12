Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports AccesoDatos
Imports Modelos
Public Class Rproductos

    Dim contexto As New ContextoDB

    Private tabla As String = "productos"
    Private dato1 As String = "Nombre"
    Private dato2 As String = "Precio"
    Private dato3 As String = "Categoria"
    Private comprobacion As Boolean

    'FUNCIONES Y VOID DE ALTA,BAJA Y MODIFICACION. Tambien Ver/Mostrar.
    '---------------------------------------------------------------------------------------------------------------------

    'Como se solicito creamos las querys de insertar, ver, eliminar y crear.
    Sub AltaProducto(mProductos As MProductos)
        Dim errores As String = "", en As String = vbCrLf
        If mProductos.Nombre1.Trim.Length < 1 Then
            errores &= "Debe completar el Nombre." & en
        End If
        If mProductos.Categoria1.Trim.Length < 1 Then
            errores &= "Debe ingresar una categoria valida." & en
        End If
        If mProductos.Precio1 < 1 Then
            errores &= "Debe ingresar un numero de Precio." & en
        End If
        If IsNumeric(mProductos.Precio1) Then
        Else
            errores &= "Debe ingresar un valor numerico para el precio." & en
        End If

        If errores.Length > 0 Then
            MsgBox("Hubo errores, por favor verifique y corrija antes de intentar de nuevo:" & en & en & errores)
            Exit Sub
        End If
        Dim Query = "INSERT INTO productos (Nombre, Precio, Categoria) VALUES ('" & mProductos.Nombre1 + "', '" & mProductos.Precio1 & "', '" & mProductos.Categoria1 & "');"
        contexto.SQL_Accion(Query)
    End Sub


    'Utilizamos el SQLAccion para enviar la consulta de delete.
    Sub BajaCliente(tNombre As TextBox, lLegajo As Label, gridProductos As DataGridView)
        If MessageBox.Show("Está por eliminar el producto: " & tNombre.Text.Trim.ToUpper & ", Está SEGURO?",
                           "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                           MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        '-------------------------------------------------------------------------------------------------------------------'
        If contexto.SQL_Accion("delete from pruebademo.dbo.Productos  where  ID =" & Val(lLegajo.Text)) = False Then
            MsgBox("Hubo un error al intentar borrar el producto, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        Else
            buscar(" ID =" & Val(lLegajo.Text), gridProductos)
            MsgBox("El producto fue ELIMINADO de la base de datos.")
            lLegajo.Text.Replace(lLegajo.Text, "0")
            contexto.ShowGrid(tabla, gridProductos)

        End If
    End Sub


    'Realizamos una comprobacion rapida de campos.
    Sub ModificacionProducto(tNombre As TextBox, tCategoria As TextBox, tPrecio As TextBox, lLegajo As String)
        Dim errores As String = "", en As String = vbCrLf
        If tNombre.Text.Trim.Length < 1 Then
            errores &= "Debe completar el Nombre." & en
        End If
        If tCategoria.Text.Trim.Length < 1 Then
            errores &= "Debe ingresar una categoria." & en
        End If
        If tPrecio.Text < 1 Then
            errores &= "Debe ingresar un valor al producto." & en
        End If
        If IsNumeric(tPrecio.Text) Then
        Else
            errores &= "Debe ingresar numeros y no caracteres." & en
        End If

        If errores.Length > 0 Then
            MsgBox("Hubo errores, por favor verifique y corrija antes de intentar de nuevo:" & en & en & errores)
            Exit Sub
        End If
        tPrecio.Text = tPrecio.Text.Trim.ToUpper.Replace("'", "´")
        Dim Precio = Convert.ToDecimal(tPrecio.Text)
        If contexto.SQL_Accion("UPDATE pruebademo.dbo.Productos SET Nombre='" & tNombre.Text.Trim.ToUpper.Replace("'", "´") &
                   "', Precio='" & Precio & "', Categoria='" & tCategoria.Text.Trim.Replace("'", "´") & "'" &
                   " WHERE ID=" & VNum(lLegajo)) = True Then
            MsgBox("Cambios realizados correctamente.")
        Else
            MsgBox("Se produjo un error al querer guardar los datos de un producto, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        End If
    End Sub


    'Cargamos el nombre de la tabla y solo solicitamos el grid en el que queremos impactar los datos.
    Sub CargarProductos(gProductos As DataGridView)
        contexto.ShowGrid(tabla, gProductos)
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
    Sub CargarCamposProductos(lLegajo As Label, pBotones As Panel, pCampos As Panel, tNombre As TextBox,
                             tPrecio As TextBox, tCategoria As TextBox)

        contexto.CargarCampos(tabla, dato1, dato2, dato3, lLegajo, pBotones, pCampos, tNombre, tPrecio, tCategoria)
    End Sub


    'Este es particular del formulario.
    Sub LimpiarCampos(tNombre As TextBox, tPrecio As TextBox, tCategoria As TextBox)
        tNombre.Text = ""
        tPrecio.Text = ""
        tCategoria.Text = ""
    End Sub
    'Para limpiar un campo en particular.
    Sub LimpiarCampos(tdato As TextBox)
        tdato.Text = ""
    End Sub
    'revisamos que los datos de la tabla no esten repetidos.
    Function ComprobacionProducto(campocliente As String) As Boolean

        'Realiza una validacion en todos los campos dependiendo el estado del ciclo.
        If contexto.YaExisteSQL("select * from productos where " & dato1 & "='" & campocliente & "'") Then
            MessageBox.Show("Usted esta ingresando un " & dato1 & " que corresponde a un producto ya dado de alta.", "Ya existe Cliente ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            comprobacion = True
            'Cerramos el For, con la condicion para que no valide el nuevo cliente         
        Else
            comprobacion = False
            End If


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
End Class
