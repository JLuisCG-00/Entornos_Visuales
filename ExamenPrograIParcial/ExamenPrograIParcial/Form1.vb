Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged

    End Sub

    Private Sub TxtContra_TextChanged(sender As Object, e As EventArgs) Handles TxtContra.TextChanged

    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        usuario = TxtUsuario.Text
        contrasena = TxtContra.Text
        MessageBox.Show("Usuario admin registrado correctamente", "Registro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
        InicioDeSesion.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub
End Class
