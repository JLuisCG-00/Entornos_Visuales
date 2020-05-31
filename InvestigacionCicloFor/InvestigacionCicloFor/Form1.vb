Public Class Form1
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles Btncalcular.Click
        'Dejar en blanco los combobox
        'Declaración de variables
        Dim num As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim mult As Integer
        Dim div As Double
        'Entrada de datos
        num = Val(Txtnumero.Text)
        'Proceso
        For i = 1 To 12 Step 1
            suma = num + i
            resta = num - i
            mult = num * i
            div = num / i

            'Salida de Información
            Cbosuma.Items.Add(num & " + " & i & " = " & suma)
            cboresta.Items.Add(num & " - " & i & " = " & resta)
            cbomultiplicacion.Items.Add(num & " * " & i & " = " & mult)
            cbodivision.Items.Add(num & " / " & i & " = " & div)

        Next
    End Sub

    Private Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        Txtnumero.Clear()
    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Me.Close()
    End Sub
End Class
