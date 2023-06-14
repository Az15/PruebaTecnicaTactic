﻿Imports Repositorios

Public Class fInicio
    Dim repos As New Rclientes
    Private Sub bUsuarioABM_Click(sender As Object, e As EventArgs) Handles bUsuarioABM.Click
        Me.Visible = False
        My.Forms.fClientes.Visible = True
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        If MessageBox.Show("¿Está seguro de que desea salir del Programa?", "Salir del Programa",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    Private Sub fInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        repos.pruebasql()
    End Sub

    Private Sub bProductos_Click(sender As Object, e As EventArgs) Handles bProductos.Click
        Me.Visible = False
        My.Forms.fProductos.Visible = True
    End Sub

    Private Sub bVentas_Click(sender As Object, e As EventArgs) Handles bVentas.Click
        Me.Visible = False
        My.Forms.fInicioVenta.Visible = True
    End Sub
End Class
