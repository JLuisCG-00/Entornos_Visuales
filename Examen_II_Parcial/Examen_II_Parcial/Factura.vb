Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Factura
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim conexion As String
        conexion = "Data Source=DESKTOP-9JQIMLJ;Initial Catalog=Tienda;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("select*from factura.producto where idProducto=" & cboidproducto.Text & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            TxtNom.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            TxtDescripcion.Text = ds.Tables("datos").Rows(0).Item(2).ToString
        Else
            MsgBox("El producto no existe no existe, proceda a registrarlo")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As String
        conexion = "Data Source=DESKTOP-9JQIMLJ;Initial Catalog=Tienda;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("select*from factura.cliente where idCliente=" & cboidcliente.Text & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            TextBox1.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            TxtApellido.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            TxtDireccion.Text = ds.Tables("datos").Rows(0).Item(3).ToString
        Else
            MsgBox("El cliente no existe, proceda a registrarlo")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim precio As Integer
        Dim cantidad As Integer

        precio = TxtPrecioP.Text
        cantidad = TxtCantidad.Text

        DGdtatos.Rows.Add(TxtNom.Text, TxtNom.Text, TxtCantidad.Text, TxtPrecioP.Text, TxtFecha.Text)

        TxtTotalP.Text = precio * cantidad

        Dim conexion As String
        conexion = "Data Source=DESKTOP-9JQIMLJ;Initial Catalog=Tienda;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlCommand("insert into factura.Venta values(" & CboIdVenta.Text & ",'" & TxtFecha.Text & "', '" & TxtPrecioP.Text & "', '" & TxtCantidad.Text & "', '" & cboidcliente.Text & "', '" & cboidproducto.Text & "')", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Datos ingresados correctamente")
    End Sub


    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorP.SetError(sender, "")
        Else
            Me.ErrorP.SetError(sender, "Ingrese nombre este dato es obligatorio")
        End If
    End Sub

    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged

    End Sub

    Private Sub TxtApellido_Validating(sender As Object, e As CancelEventArgs) Handles TxtApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorP.SetError(sender, "")
        Else
            Me.ErrorP.SetError(sender, "Ingrese apellido este dato es obligatorio")
        End If
    End Sub


    Private Sub TxtDireccion_Validating(sender As Object, e As CancelEventArgs) Handles TxtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorP.SetError(sender, "")
        Else
            Me.ErrorP.SetError(sender, "Ingrese direccion este dato es obligatorio")
        End If
    End Sub

    Private Sub TxtNom_TextChanged(sender As Object, e As EventArgs) Handles TxtNom.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorP.SetError(sender, "")
        Else
            Me.ErrorP.SetError(sender, "Ingrese nombre este dato es obligatorio")
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        Me.PictureBox1.BackColor = Color.Red
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(152, Byte), Integer))
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        MenuV.Show()
    End Sub
End Class