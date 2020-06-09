Public Class Calculadora
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim CambioSigno As Double
    Dim BotonOperacion As Boolean

    Public Sub EvaluaRestriccionParaIngresar()
        If BotonOperacion = True Then 'Si se invoco "RealizarOperacion"
            TextBox_Result.Text = "" 'Se limpia la caja de texto
            BotonOperacion = False 'Bandera=false 
        ElseIf TextBox_Result.Text = "0" Then 'Si en la caja de texto hay 0
            TextBox_Result.Text = "" 'Entonces no hay nada y al ingresar algo este desaparece
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EvaluaRestriccionParaIngresar()
        TextBox_Result.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EvaluaRestriccionParaIngresar()
        TextBox_Result.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        EvaluaRestriccionParaIngresar()
        TextBox_Result.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        EvaluaRestriccionParaIngresar()
        TextBox_Result.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        EvaluaRestriccionParaIngresar()
        TextBox_Result.Text &= "9"
    End Sub
    Private Sub ButtonMENU_Click(sender As Object, e As EventArgs) Handles ButtonMENU.Click
        Menu_Principal.Show()
        Me.Hide()

    End Sub

    Private Sub ButtonSALIR_Click(sender As Object, e As EventArgs) Handles ButtonSALIR.Click
        End
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Result.TextChanged
        TextBox2.Text = TextBox_Result.Text
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        EvaluaRestriccionParaIngresar()
        TextBox_Result.Text &= "0"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        EvaluaRestriccionParaIngresar()
        TextBox_Result.Text &= "1"
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        EvaluaRestriccionParaIngresar()
        TextBox_Result.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EvaluaRestriccionParaIngresar()
        TextBox_Result.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EvaluaRestriccionParaIngresar()
        TextBox_Result.Text &= "4"
    End Sub



    Private Sub ButtonIgual_Click(sender As Object, e As EventArgs) Handles ButtonIgual.Click
        RealizarOperacion()
        Operacion = ""
    End Sub

    Private Sub ButtonSuma_Click(sender As Object, e As EventArgs) Handles ButtonSuma.Click
        RealizarOperacion()
        Operacion = "+"
    End Sub

    Private Sub ButtonResta_Click(sender As Object, e As EventArgs) Handles ButtonResta.Click
        RealizarOperacion()
        Operacion = "-"
    End Sub

    Private Sub ButtonMulti_Click(sender As Object, e As EventArgs) Handles ButtonMulti.Click
        RealizarOperacion()
        Operacion = "*"
    End Sub

    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        RealizarOperacion()
        Operacion = "/"
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        TextBox_Result.Text = "0"
        valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Private Sub ButtonCambioSig_Click(sender As Object, e As EventArgs) Handles ButtonCambioSig.Click
        CambioSigno = Val(TextBox_Result.Text) * -1
        TextBox_Result.Text = CambioSigno
    End Sub

    Public Sub RealizarOperacion()
        BotonOperacion = True
        valor2 = Val(TextBox_Result.Text) 'Valor2 = lo que haya en la caja de texto
        If ValorResultado IsNot Nothing Then 'Si ValorRsultado no esta vacio
            Select Case operacion 'Se elije un case dependiendo del operador selecionado
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                    TextBox_Result.Text = ValorResultado & " +"
                Case "-"
                    ValorResultado -= valor2
                Case "*"
                    ValorResultado *= valor2
                Case "/"
                    ValorResultado = ValorResultado / valor2

            End Select
            TextBox_Result.Text = ValorResultado 'La caja de texto mostrara el resultado
        Else
            ValorResultado = valor2 'Si ValorResultado esta vacio, ValorResultado = Valor2
        End If

    End Sub

    Private Sub ButtonPunto_Click(sender As Object, e As EventArgs) Handles ButtonPunto.Click
        EvaluaRestriccionParaIngresar()
        If InStr(TextBox_Result.Text, ".", CompareMethod.Text) = 0 Then
            TextBox_Result.Text &= "."
        End If
    End Sub

End Class