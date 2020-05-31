Public Class Form1
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs)

        'Inicio
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer
        Dim rest As Integer
        Dim mult As Integer
        Dim div As Double

        valor1 = Val(Txt1.Text)
        valor2 = Val(Txt2.Text)

        'Proceso
        suma = valor1 + valor2

        rest = valor1 - valor2

        mult = valor1 * valor2

        div = valor1 / valor2

        If valor2 = 0 Then
            MsgBox("No se puede dividir entre cero")
        End If

        'Salida
        TxtTotal.Text = suma
        TxtResta.Text = rest
        TxtMult.Text = mult
        TxtDiv.Text = div

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Txt1.Clear()
        Txt2.Clear()
        TxtDiv.Clear()
        TxtMult.Clear()
        TxtResta.Clear()
        TxtTotal.Clear()


    End Sub
End Class
