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

    Private Sub TxtPrecio_TextChanged(sender As Object, e As EventArgs) Handles TxtPrecio.TextChanged

    End Sub

    Private Sub TxtPrecio_Validating(sender As Object, e As CancelEventArgs) Handles TxtPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un precio")
        End If
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged

    End Sub

    Private Sub TxtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles TxtCantidad.Validating
        If Val(TxtCantidad.Text) - Int(Val(TxtCantidad.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un numero entero")
        End If
    End Sub

    Private Sub TxtProducto_MouseHover(sender As Object, e As EventArgs) Handles TxtProducto.MouseHover
        ToolTip.SetToolTip(TxtProducto, "Ingrese un Producto")
        ToolTip.ToolTipTitle = "Producto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles TxtPrecio.MouseHover
        ToolTip.SetToolTip(TxtPrecio, "Ingrese un precio")
        ToolTip.ToolTipTitle = "Precio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles TxtCantidad.MouseHover
        ToolTip.SetToolTip(TxtCantidad, "Ingrese una cantidad (Entero)")
        ToolTip.ToolTipTitle = "Cantidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        ToolTip.SetToolTip(txtDescripcion, "Ingrese una descripcion")
        ToolTip.ToolTipTitle = "Descripcion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub
End Class
