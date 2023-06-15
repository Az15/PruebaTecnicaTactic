Imports Modelos
Imports Repositorios

Public Class fClientes
    'instanciamos los objetos necesarios para trabajar.
    Dim repositorio As New Rclientes
    Dim usuario As New MClientes

    Private Sub bCrear_Click(sender As Object, e As EventArgs) Handles bCrear.Click

        'Arreglamos los campos por si hay algun intento de inyeccion basica.
        repositorio.NoBasicInyeccion(tCliente)
        repositorio.NoBasicInyeccion(tCorreo)
        repositorio.NoBasicInyeccion(tTelefono)
        'Realizamos de manear rustica las validaciones
        If repositorio.ComprobacionCliente(tCliente.Text) Then
            repositorio.LimpiarCampos(tCliente, tTelefono, tCorreo, lLegajo)

            Exit Sub
        End If
        If repositorio.ComprobacionCliente(tCorreo.Text) Then
            repositorio.LimpiarCampos(tCliente, tTelefono, tCorreo, lLegajo)

            Exit Sub
        End If
        If repositorio.ComprobacionCliente(tTelefono.Text) Then
            repositorio.LimpiarCampos(tCliente, tTelefono, tCorreo, lLegajo)

            Exit Sub
        End If
        'Guardamos los datos en un objeto de usuario.
        usuario.setUserall(tCliente.Text, tTelefono.Text, tCorreo.Text)
        'Enviamos los datos a la base de datos.
        repositorio.AltaCliente(usuario)
        'Le damos un Refresh a la base de datos.
        repositorio.CargarClientes(gClientes)
        repositorio.LimpiarCampos(tCliente, tCorreo, tTelefono, lLegajo)

    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        If MessageBox.Show("¿Está seguro de que desea salir del Programa?", "Salir del Programa",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    Private Sub fUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        repositorio.CargarClientes(gClientes)
        repositorio.LimpiarCampos(tCliente, tCorreo, tTelefono, lLegajo)
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



    Private Sub gClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gClientes.CellContentClick
        FilaClick(e)
    End Sub

    Private Sub gClientes_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles gClientes.RowEnter
        FilaClick(e)
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        repositorio.buscar(tBuscar.Text, gClientes)
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        repositorio.BajaCliente(tCliente, lLegajo, gClientes)
        repositorio.CargarClientes(gClientes)
        repositorio.LimpiarCampos(tCliente, tCorreo, tTelefono, lLegajo)
    End Sub


    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(gClientes.Rows(fila).Cells(0).Value) Then
            lLegajo.Text.Replace(lLegajo.Text, "0")
            pBotones.Visible = False
            pCampos.Visible = False
            Exit Sub
        Else
            tfila = gClientes.Rows(fila).Cells(0).Value
            lLegajo.Text = tfila.ToString()
            repositorio.CargarCamposClientes(lLegajo, pBotones, pCampos, tCliente, tCorreo, tTelefono)
        End If
    End Sub

    Private Sub bCambio_Click(sender As Object, e As EventArgs) Handles bCambio.Click
        repositorio.NoBasicInyeccion(tCliente)
        repositorio.NoBasicInyeccion(tCorreo)
        repositorio.NoBasicInyeccion(tTelefono)
        repositorio.ModificacionCliente(tCliente, tCorreo, tTelefono, lLegajo.Text)
        repositorio.CargarClientes(gClientes)
        lLegajo.Text.Replace(lLegajo.Text, "0")
        repositorio.LimpiarCampos(tCliente, tTelefono, tCorreo, lLegajo)
    End Sub

    Private Sub bLimpiarCampos_Click(sender As Object, e As EventArgs) Handles bLimpiarCampos.Click
        repositorio.LimpiarCampos(tCliente, tTelefono, tCorreo, lLegajo)
    End Sub

    Private Sub tBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tBuscar.KeyPress
        If (e.KeyChar = Convert.ToChar((Keys.Enter))) Then
            bBuscar_Click(sender, e)
        End If
    End Sub

    'Para dar funcionalidad y mover los forms
    Dim m As Integer = 0, mx As Integer, mi As Integer
    Private Sub fClientes_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        m = 0
    End Sub

    Private Sub fClientes_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If m = 1 Then

            Me.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - mi)
        End If
    End Sub

    Private Sub fClientes_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        m = 1
        mx = e.X
        mi = e.Y
    End Sub

End Class