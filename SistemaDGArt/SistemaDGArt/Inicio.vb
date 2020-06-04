Imports System.ComponentModel

Public Class Inicio
    Private Sub AgregarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarProductosToolStripMenuItem.Click
        Me.Close()
        Ingreso.Show()
    End Sub



    Private Sub InformacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionToolStripMenuItem.Click
        Me.Close()
        Informacion.Show()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        nombre = TxtNombre.Text
        cargo = TxtCargo.Text

        TxtUActivo.Text = TxtNombre.Text
        TxtCargo2.Text = TxtCargo.Text
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        If IsNumeric(TxtNombre.Text) Then
            MessageBox.Show("No puede ingresar numeros, favor ingrese su nombre", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TxtNombre_Validating(sender As Object, e As CancelEventArgs) Handles TxtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Favor ingrese su nombre, este dato es obligatorio")
        End If
    End Sub

    Private Sub TxtCargo_TextChanged(sender As Object, e As EventArgs) Handles TxtCargo.TextChanged

    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class