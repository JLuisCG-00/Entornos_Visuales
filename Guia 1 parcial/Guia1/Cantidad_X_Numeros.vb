Public Class Cantidad_X_Numeros

    Dim veces As Integer
    Dim numero As String
    Private Sub Button_Enviar_Click(sender As Object, e As EventArgs) Handles Button_Enviar.Click

        Dim TotalNum, residuo, pares, impares, positivos, negativos As Integer
        Dim dato, sumaTotal As Double

        Try

            If (Val(TextBox_CantValores.Text)) - Int(Val(TextBox_CantValores.Text)) = 0 And Val(TextBox_CantValores.Text) >= 0 Then
                TotalNum = Val(TextBox_CantValores.Text)
                sumaTotal = 0

                For i = 1 To TotalNum Step 1

                    dato = InputBox("Ingrese el valor #" & i, "Ingreso de datos")

                    residuo = dato Mod 2
                    ComboBox_ValoresIngesados.Items.Add(dato)

                    If residuo = 0 Then
                        pares += 1
                    Else
                        impares += 1
                    End If
                    sumaTotal += dato

                    If dato > 0 Then
                        positivos += 1

                    Else
                        negativos += 1
                    End If

                Next
                TextBox_Impar.Text = impares
                TextBox_Pares.Text = pares
                TextBox_Positivo.Text = positivos
                TextBox_Negativo.Text = negativos
                TextBox_TotalSum.Text = sumaTotal
                TextBox_TotalNum.Text = TotalNum
            Else
                MsgBox("Debe ingresar un valor entero positivo", vbExclamation + vbOK, "Advertencia")
                TextBox_CantValores.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button_Limpiar.Click
        TextBox_CantValores.Clear()
        TextBox_Pares.Clear()
        TextBox_Impar.Clear()
        TextBox_Positivo.Clear()
        TextBox_Negativo.Clear()
        TextBox_TotalSum.Clear()
        TextBox_TotalNum.Clear()
        ComboBox_ValoresIngesados.Items.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu_Principal.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

End Class