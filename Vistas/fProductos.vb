Imports Repositorios.Rproductos
Imports Modelos
Public Class fProductos
    Dim repositorio As New Repositorios.Rproductos
    Dim producto As New MProductos
    Private Sub bCrear_Click(sender As Object, e As EventArgs) Handles bCrear.Click

        'Arreglamos los campos por si hay algun intento de inyeccion basica.
        repositorio.NoBasicInyeccion(tNombre)
        repositorio.NoBasicInyeccion(tCategoria)
        repositorio.NoBasicInyeccion(tPrecio)
        'Realizamos de manera rustica las validaciones
        If repositorio.ComprobacionProducto(tNombre.Text) Then
            repositorio.LimpiarCampos(tNombre, tPrecio, tCategoria, lLegajo)
            Exit Sub
        End If
        'Guardamos los datos en un objeto de usuario.
        producto.setUserall(tNombre.Text, tPrecio.Text, tCategoria.Text)
        'Enviamos los datos a la base de datos.
        repositorio.AltaProducto(producto)
        repositorio.CargarFiltro(cbFiltro)
        'Le damos un Refresh a la base de datos.
        repositorio.CargarProductos(gProductos)
        repositorio.LimpiarCampos(tNombre, tPrecio, tCategoria, lLegajo)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        If MessageBox.Show("¿Está seguro de que desea salir del Programa?", "Salir del Programa",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then Application.Exit()
    End Sub

    Private Sub fUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        repositorio.CargarFiltro(cbFiltro)
        repositorio.CargarProductos(gProductos)
        repositorio.LimpiarCampos(tNombre, tPrecio, tCategoria, lLegajo)
    End Sub

    Private Sub bMenu_Click(sender As Object, e As EventArgs) Handles bMenu.Click
        Dim resultado As DialogResult = MessageBox.Show("Esta seguro que desea salir al Menu", "Menu",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resultado = DialogResult.Yes Then
            My.Forms.fInicio.Visible = True
            Me.Visible = False
        End If
    End Sub

    Private Sub bMinimizar_Click(sender As Object, e As EventArgs) Handles bMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub gProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gProductos.CellContentClick
        FilaClick(e)
    End Sub

    Private Sub gProductos_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles gProductos.RowEnter
        FilaClick(e)
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        repositorio.buscar(tBuscar.Text, gProductos)
        repositorio.LimpiarCampos(tNombre, tPrecio, tCategoria, lLegajo)
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        repositorio.BajaCliente(tNombre, lLegajo, gProductos)
        repositorio.CargarProductos(gProductos)
        repositorio.LimpiarCampos(tNombre, tPrecio, tCategoria, lLegajo)
    End Sub


    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(gProductos.Rows(fila).Cells(0).Value) Then
            pBotones.Visible = False
            pCampos.Visible = False
            repositorio.LimpiarCampos(tNombre, tPrecio, tCategoria, lLegajo)
            Exit Sub
        Else
            tfila = gProductos.Rows(fila).Cells(0).Value
            lLegajo.Text = tfila.ToString()
            repositorio.CargarCamposProductos(lLegajo, pBotones, pCampos, tNombre, tPrecio, tCategoria)
        End If
    End Sub

    Private Sub bCambio_Click(sender As Object, e As EventArgs) Handles bCambio.Click
        repositorio.NoBasicInyeccion(tNombre)
        repositorio.NoBasicInyeccion(tCategoria)
        repositorio.NoBasicInyeccion(tPrecio)
        repositorio.ModificacionProducto(tNombre, tCategoria, tPrecio, lLegajo.Text)
        repositorio.CargarProductos(gProductos)
        lLegajo.Text.Replace(lLegajo.Text, "0")
        repositorio.LimpiarCampos(tNombre, tPrecio, tCategoria, lLegajo)
    End Sub

    'Private Sub bLimpiarCampos_Click(sender As Object, e As EventArgs) Handles bLimpiarCampos.Click
    '    repositorio.LimpiarCampos(tNombre, tPrecio, tCategoria)
    'End Sub

    Private Sub tBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tBuscar.KeyPress
        If (e.KeyChar = Convert.ToChar((Keys.Enter))) Then
            bBuscar_Click(sender, e)
        End If
    End Sub

    Private Sub cbFiltro_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbFiltro.SelectedValueChanged
        repositorio.buscar(cbFiltro.Text, gProductos)
        bQuitarFiltro.Visible = True
        repositorio.LimpiarCampos(tNombre, tPrecio, tCategoria, lLegajo)
    End Sub

    Private Sub bQuitarFiltro_Click(sender As Object, e As EventArgs) Handles bQuitarFiltro.Click
        repositorio.CargarProductos(gProductos)
        repositorio.LimpiarCampos(tNombre, tPrecio, tCategoria, lLegajo)
    End Sub
End Class