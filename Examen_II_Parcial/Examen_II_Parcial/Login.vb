Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TxtUser.Text = "mejordelmundo" And TxtContra.Text = "6baloncitos" Then
            Me.Hide()
            MenuV.Show()
        Else
            MessageBox.Show("Contraseña incorrecta", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtContra.Text = ""
            TxtUser.Text = ""
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class