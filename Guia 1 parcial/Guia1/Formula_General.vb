Imports System.ComponentModel

Public Class Formula_General

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click

        Dim variableA, variableB, variableC, discriminante, primerResultado, segundoResultado As Double

        If Not IsNumeric(TextBox_A.Text) Then
            MsgBox("Ingrese un valor numerico en la primer casilla", vbExclamation + vbOK, "Advertencia")
            TextBox_A.Clear()

        End If

        If Not IsNumeric(TextBox_B.Text) Then
            MsgBox("Ingrese un valor numerico en la segunda casilla", vbExclamation + vbOK, "Advertencia")
            TextBox_B.Clear()

        End If

        If Not IsNumeric(TextBox_C.Text) Then
            MsgBox("Ingrese un valor numerico en la tercer casilla", vbExclamation + vbOK, "Advertencia")
            TextBox_C.Clear()

        End If

        variableA = Val(TextBox_A.Text)
        variableB = Val(TextBox_B.Text)
        variableC = Val(TextBox_C.Text)

        discriminante = ((variableB ^ 2) - (4 * (variableA) * (variableC)))

        If discriminante < 0 Then
            MsgBox("Los valores ingresados formulan un resultado con valores imaginarios", vbOK + vbExclamation, "Advertencia")

        Else
            primerResultado = ((-1 * (variableB)) + ((discriminante) ^ (1 / 2))) / (2 * (variableA))
            segundoResultado = ((-1 * (variableB)) - ((discriminante) ^ (1 / 2))) / (2 * (variableA))
            TextBox_X1.Text = primerResultado
            TextBox_X2.Text = segundoResultado

        End If


    End Sub

    Private Sub TextBox_A_MouseHover(sender As Object, e As EventArgs) Handles TextBox_A.MouseHover
        ToolTip.SetToolTip(TextBox_A, "Ingrese un valor para (a)")
        ToolTip.ToolTipTitle = "Descripción"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox_B_MouseHover(sender As Object, e As EventArgs) Handles TextBox_B.MouseHover
        ToolTip.SetToolTip(TextBox_B, "Ingrese un valor para (b)")
        ToolTip.ToolTipTitle = "Descripción"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox_C_MouseHover(sender As Object, e As EventArgs) Handles TextBox_C.MouseHover
        ToolTip.SetToolTip(TextBox_C, "Ingrese un valor para (c)")
        ToolTip.ToolTipTitle = "Descripción"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox_A_Validating(sender As Object, e As CancelEventArgs) Handles TextBox_A.Validating

        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If

    End Sub

    Private Sub TextBox_B_Validating(sender As Object, e As CancelEventArgs) Handles TextBox_B.Validating

        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub TextBox_C_Validating(sender As Object, e As CancelEventArgs) Handles TextBox_C.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        TextBox_A.Clear()
        TextBox_B.Clear()
        TextBox_C.Clear()
        TextBox_X1.Clear()
        TextBox_X2.Clear()

    End Sub


    Private Sub Menu_Prin_Click(sender As Object, e As EventArgs) Handles Menu_Prin.Click
        Menu_Principal.Show()
        Me.Hide()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub


End Class