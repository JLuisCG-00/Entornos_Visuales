Imports System.ComponentModel

Public Class Form1
    Private Sub BtnValidar_Click(sender As Object, e As EventArgs) Handles BtnValidar.Click
        'se usara Try Catch
        'se usara ValidateChildren en el button
        'se usara Validiting en las cajas de texto

        Try
            If Me.ValidateChildren And TxtProducto.Text <> String.Empty And TxtPrecio.Text <> String.Empty And Val(TxtCantidad.Text) - Int(Val(TxtCantidad.Text)) = 0 Then
                MessageBox.Show("Datos ingresados correctamente", "Formulario Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Revise los datos", "Error en productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtProducto_TextChanged(sender As Object, e As EventArgs) Handles TxtProducto.TextChanged

    End Sub

    Private Sub TxtProducto_Validating(sender As Object, e As CancelEventArgs) Handles TxtProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
End Class
