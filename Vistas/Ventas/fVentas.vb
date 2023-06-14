Imports Repositorios

Public Class fVentas
    Dim RepositorioVentas As New Rventas
    Dim RepositorioProductos As New Rproductos
    Private idClienteSeleccionado As Integer
    Private idVentaActual As Integer
    Private idProducto As String
    Private totalVenta As Decimal
    Private Sub bVolver_Click(sender As Object, e As EventArgs) Handles bVolver.Click
        Dim resultado As DialogResult = MessageBox.Show("Esta seguro que desea salir al Menu", "Menu",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resultado = DialogResult.Yes Then
            My.Forms.fInicio.Visible = True
            Me.Visible = False
        End If
    End Sub


    Private Sub fVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar clientes en el ComboBox
        cbClientes.DisplayMember = "Cliente"
        cbClientes.ValueMember = "Id"
        cbClientes.DataSource = RepositorioVentas.ObtenerClientes()
        RepositorioProductos.CargarProductos(gVentas)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Application.Exit()
    End Sub

    Private Sub bMinimizar_Click(sender As Object, e As EventArgs) Handles bMinimizar.Click
    End Sub

    Private Sub bAgregarCarrito_Click(sender As Object, e As EventArgs) Handles bAgregarCarrito.Click
        ' Verificar que se haya seleccionado un cliente
        If cbClientes.SelectedItem IsNot Nothing Then
            ' Verificar que se haya seleccionado un producto


            Dim idProductoTemporal As Integer = Convert.ToInt32(idProducto)
            Dim precioUnitario As Decimal = Convert.ToDecimal(tPrecio.Text)
                Dim cantidad As Integer = Convert.ToInt32(tCantidad.Text)
                Dim precioTotal As Decimal = precioUnitario * cantidad

                ' Crear una nueva venta si no hay una venta actual en curso
                If idVentaActual = 0 Then
                    idClienteSeleccionado = Convert.ToInt32(cbClientes.SelectedValue)
                    idVentaActual = CrearVenta()
                End If

            ' Agregar el producto a la venta actual
            RepositorioVentas.CrearVentaItem(idVentaActual, idProductoTemporal, precioUnitario, cantidad, precioTotal)
            totalVenta += precioTotal

            ' Mostrar el total de la venta actual
            lTotalaAgregar.Text = totalVenta.ToString()


        Else
            MessageBox.Show("Por favor, seleccione un cliente.")
        End If
    End Sub

    Private Sub bFinalizarCompra_Click(sender As Object, e As EventArgs) Handles bFinalizarCompra.Click
        If idVentaActual <> 0 Then
            Dim fechaVenta As Date = Date.Today
            RepositorioVentas.ActualizarVenta(idVentaActual, fechaVenta, totalVenta)
            MessageBox.Show("La venta se ha registrado correctamente.")

            ' Reiniciar variables y limpiar el formulario
            idVentaActual = 0
            idClienteSeleccionado = 0
            totalVenta = 0
            lTextoPedido.Text = ""
            LimpiarFormulario()
        End If
    End Sub

    Private Sub gVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gVentas.CellContentClick
        FilaClick(e)
    End Sub

    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(gVentas.Rows(fila).Cells(0).Value) Then
            RepositorioProductos.LimpiarCamposV(tNombre, tPrecio)
            Exit Sub
        Else
            tfila = gVentas.Rows(fila).Cells(0).Value
            idProducto = tfila.ToString()
            RepositorioProductos.CargarCamposProductosV(idProducto, tNombre, tPrecio)
        End If
    End Sub
    Private Function CrearVenta() As Integer
        Dim fechaVenta As Date = Date.Today

        ' Crear una nueva venta en la base de datos
        RepositorioVentas.CrearVenta(idClienteSeleccionado, fechaVenta)

        ' Obtener el ID de la venta recién creada
        Dim dataTable As DataTable = RepositorioVentas.ObtenerVentaPorCliente(idClienteSeleccionado)
        Dim idVenta As Integer = Convert.ToInt32(dataTable.Rows(dataTable.Rows.Count - 1)("Id"))
        Return idVenta
    End Function
    Private Sub LimpiarFormulario()
        gVentas.ClearSelection()
    End Sub
End Class