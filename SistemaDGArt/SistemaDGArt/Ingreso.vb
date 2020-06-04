Public Class Ingreso

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.Close()
        Inicio.Show()
    End Sub



    Private Sub InformacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionToolStripMenuItem.Click
        Me.Close()
        Informacion.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub Ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUActivo.Text = nombre
        TxtCargo2.Text = cargo


        CbmImp.Items.Add("Impuesto del 15%")
        CbmImp.Items.Add("Impuesto del 17%")
        CbmImp.Items.Add("Ninguno")


        CbmDesc.Items.Add("Tercera edad (30%)")
        CbmDesc.Items.Add("Estudiantil (10%)")
        CbmDesc.Items.Add("Nuevo cliente(25%)")
        CbmDesc.Items.Add("Cliente frecuente(15%)")
        CbmDesc.Items.Add("Compra por docena(35%)")
        CbmDesc.Items.Add("Promocion vigente(50%)")
        CbmDesc.Items.Add("Ninguno")

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
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

        itemid = CbmDesc.SelectedIndex
        itemid2 = CbmImp.SelectedIndex
        PU = TxtPrecio.Text
        Cant = TxtCantidad.Text
        'Procesos

        If TxtCantidad.Text = "" Then
            MsgBox("El campo no puede quedar en blanco, favor ingrese un numero")
        End If

        If TxtPrecio.Text = "" Then
            MsgBox("El campo no puede quedar en blanco, favor ingrese un numero")
        End If

        'Proceso de Descuento

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



        'Proceso de Impuesto

        subtotal = PU * Cant
            If itemid2 = 0 Then
                Imp = 0.15
            ElseIf itemid2 = 1 Then
                Imp = 0.17
            End If

            impuesto = subtotal * Imp
        total = subtotal + impuesto

        'Salidas
        TxtSubtotal.Text = subtotal
        TxtTotal.Text = total
        TxtDesc.Text = descuento
        TxtImp.Text = impuesto


        MessageBox.Show("Producto ingresado correctamente", "Status de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TxtId.Clear()
        TxtTipo.Clear()
        TxtPrecio.Clear()
        CbmImp.SelectedIndex = 2
        CbmDesc.SelectedIndex = 6
    End Sub
End Class