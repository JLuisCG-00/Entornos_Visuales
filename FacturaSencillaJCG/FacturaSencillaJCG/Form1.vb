Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Agregando descuentos al ComboBox de Descuentos
        CBDesc.Items.Add("Tercera edad (30%)")
        CBDesc.Items.Add("Estudiantil (10%)")
        CBDesc.Items.Add("Nuevo cliente(25%)")
        CBDesc.Items.Add("Cliente frecuente(15%)")
        CBDesc.Items.Add("Compra por docena(35%)")
        CBDesc.Items.Add("Promocion vigente(50%)")

        CBDesc.Enabled = False

        'Agregando impuestos al ComboBox de Impuestos
        CBiva.Items.Add("Impuesto del 15%")
        CBiva.Items.Add("Impuesto del 17%")

        CBiva.Enabled = False


    End Sub

    Private Sub ChekDesc_CheckedChanged(sender As Object, e As EventArgs) Handles ChekDesc.CheckedChanged
        If ChekDesc.Enabled = True Then
            CBDesc.Enabled = True
        End If

        If ChekDesc.Enabled = True Then
            CBiva.Enabled = False
        End If

        If ChekDesc.Checked = True Then
            ChekImp.Enabled = False
        Else
            ChekImp.Enabled = True
        End If

    End Sub

    Private Sub CBAiva_CheckedChanged(sender As Object, e As EventArgs) Handles ChekImp.CheckedChanged
        If ChekImp.Enabled = True Then
            CBiva.Enabled = True
        End If

        If ChekImp.Enabled = True Then
            CBDesc.Enabled = False
        End If

        If ChekImp.Checked = True Then
            ChekDesc.Enabled = False
        Else
            ChekDesc.Enabled = True
        End If
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim PU As Integer
        Dim Cant As Integer
        Dim subtotal As Double
        Dim descuento As Double
        Dim total As Integer
        Dim Desc As Double
        Dim Imp As Double
        Dim itemid As Integer
        Dim itemid2 As Integer
        Dim impuesto As Double

        itemid = CBDesc.SelectedIndex
        itemid2 = CBiva.SelectedIndex
        PU = TxtPU.Text
        Cant = TxtCantidad.Text
        'Procesos

        If TxtCantidad.Text = "" Then
            MsgBox("El campo no puede quedar en blanco, favor ingrese un numero")
        End If

        If TxtPU.Text = "" Then
            MsgBox("El campo no puede quedar en blanco, favor ingrese un numero")
        End If

        'Proceso de Descuento
        If ChekDesc.Checked = Enabled Then
            subtotal = PU * Cant
            If itemid = 0 Then
                Desc = 0.3
            ElseIf itemid = 1 Then
                Desc = 0.1
            ElseIf itemid = 2 Then
                Desc = 0.25
            ElseIf itemid = 3 Then
                Desc = 0.15
            ElseIf itemid = 4 Then
                Desc = 0.35
            ElseIf itemid = 5 Then
                Desc = 0.5
            End If
            descuento = subtotal * Desc
            total = subtotal - descuento
        End If


        'Proceso de Impuesto
        If ChekImp.Checked = Enabled Then
            subtotal = PU * Cant
            If itemid2 = 0 Then
                Imp = 0.15
            ElseIf itemid2 = 1 Then
                Imp = 0.17
            End If

            impuesto = subtotal * Imp
            total = subtotal + impuesto
        End If

        'Salidas
        TxtSubtotal.Text = subtotal
        TxtTotal.Text = total
        TxtDesc.Text = descuento
        TxtImp.Text = impuesto
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        MsgBox("Muchas gracias por usar este programa, presiona cualquier tecla para salir")
        End
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtCantidad.Text = "0"
        TxtDesc.Text = ""
        TxtPU.Text = "0"
        TxtSubtotal.Text = ""
        TxtTotal.Text = ""
    End Sub

    Private Sub CBDesc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBDesc.SelectedIndexChanged

    End Sub

    Private Sub TxtPU_TextChanged(sender As Object, e As EventArgs) Handles TxtPU.TextChanged
        If Not IsNumeric(TxtPU.Text) Then
            MsgBox("El valor ingresado es incorrecto, favor ingresar solo numeros.")
            TxtPU.Text = "0"
        End If

        If TxtPU.Text < 0 Then
            MsgBox("Solo se permiten numero positivos, favor corregir")
            TxtPU.Text = "0"
        End If
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged
        If Not IsNumeric(TxtCantidad.Text) Then
            MsgBox("El valor ingresado es incorrecto, favor ingresar solo numeros.")
            TxtCantidad.Text = "0"
        End If

        If TxtCantidad.Text < 0 Then
            MsgBox("Solo se permiten numero positivos, favor corregir")
            TxtCantidad.Text = "0"
        End If
    End Sub

    Private Sub TxtTotal_TextChanged(sender As Object, e As EventArgs) Handles TxtTotal.TextChanged
        'Validacion de boton nuevo
        If IsNumeric(TxtTotal.Text) Then
            BtnNuevo.Enabled = True
        End If
    End Sub
End Class
