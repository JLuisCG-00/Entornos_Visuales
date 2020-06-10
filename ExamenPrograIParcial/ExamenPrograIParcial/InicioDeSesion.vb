Public Class InicioDeSesion
    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged

    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        If TxtUsuario.Text = usuario Then
            LblVeriUs.Text = "Usuario correcto"
        Else
            MessageBox.Show("El usuario ingresado no es admin", "Error de inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtUsuario.Text = ""
        End If

        If TxtContra.Text = contrasena Then
            LblVeriUs.Text = "Usuario correcto"
        Else
            MessageBox.Show("La contraseña ingresada no es correcta", "Error de inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtContra.Text = ""
        End If

        Me.Close()
        IngresoPruebas.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub
End Class