Public Class SAR

    Private Sub CheckBox_Deduccion_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Deduccion.CheckedChanged

    End Sub

    Private Sub Button_Calcular_Click(sender As Object, e As EventArgs) Handles Button_Calcular.Click

        Dim sueldo, deduccion As Double
        sueldo = Val(TextBox_Sueldo.Text)

        If TextBox_Sueldo.Text = "" Then
            MsgBox("Ingrese el monto del sueldo", vbExclamation + vbOK, "Advertencia")

        ElseIf Not IsNumeric(textbox_Sueldo.Text) Then
            MsgBox("Ingrese un valor numerico unicamente", vbExclamation + vbOK, "Advertencia")
            TextBox_Sueldo.Clear()

        ElseIf textbox_Sueldo.Text < 0 Then
            MsgBox("Ingrese un valor positivo", vbExclamation + vbOK, "Advertencia")
            TextBox_Sueldo.Clear()
        End If

        Limpiar()

        If sueldo < 16582.92 Then
            CheckBox_Excento.Checked = True
            TextBox_SueldoNeto.Text = 16582.92

        ElseIf (sueldo >= 16528.93 And sueldo <= 23536.61) Then
            CheckBox_Deduccion.Checked = True
            deduccion = sueldo * 0.15
            TextBox_SueldoNeto.Text = sueldo - (sueldo * 0.15)
            TextBox_Deduccion.Text = deduccion

        ElseIf (sueldo > 23536.62 And sueldo <= 50317.69) Then
            CheckBox_Deduccion.Checked = True
            deduccion = sueldo * 0.2
            TextBox_SueldoNeto.Text = sueldo - (sueldo * 0.2)
            TextBox_Deduccion.Text = deduccion

        ElseIf (sueldo > 50317.69) Then
            CheckBox_Deduccion.Checked = True
            deduccion = sueldo * 0.25
            TextBox_SueldoNeto.Text = sueldo - (sueldo * 0.25)
            TextBox_Deduccion.Text = deduccion
        End If

        TextBox_ImpResultado.Text = sueldo
    End Sub

    Private Sub Button_Limpiar_Click_1(sender As Object, e As EventArgs) Handles Button_Limpiar.Click
        Limpiar()
        TextBox_Sueldo.Clear()

    End Sub

    Private Sub Limpiar()
        CheckBox_Deduccion.Checked = False
        CheckBox_Excento.Checked = False
        TextBox_SueldoNeto.Clear()
        TextBox_ImpResultado.Clear()
        TextBox_Deduccion.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu_Principal.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

End Class