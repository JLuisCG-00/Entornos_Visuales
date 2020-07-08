Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Producto
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim conexion As String
        conexion = "Data Source=DESKTOP-9JQIMLJ;Initial Catalog=Tienda;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlCommand("insert into factura.producto values(" & cboidproducto.Text & ",'" & TxtNom.Text & "', '" & TxtDescripcion.Text & "')", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Datos ingresados correctamente")

        cboidproducto.Text = ""
        TxtNom.Text = ""
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim conexion As String
        conexion = "Data Source=DESKTOP-9JQIMLJ;Initial Catalog=Tienda;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlCommand("update factura.producto set nombreProducto = '" & TxtNom.Text & "',discripcion= '" & TxtDescripcion.Text & "' where idProducto= " & cboidproducto.Text & " ", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Datos actualizados correctamente")
    End Sub

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
            MsgBox("El cliente no existe, proceda a registrarlo")
        End If
    End Sub

    Private Sub TxtNom_TextChanged(sender As Object, e As EventArgs) Handles TxtNom.TextChanged

    End Sub

    Private Sub TxtNom_Validating(sender As Object, e As CancelEventArgs) Handles TxtNom.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorP.SetError(sender, "")
        Else
            Me.ErrorP.SetError(sender, "Ingrese nombre este dato es obligatorio")
        End If
    End Sub

    Private Sub TxtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TxtDescripcion.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        Me.PictureBox1.BackColor = Color.Red
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(152, Byte), Integer))
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        MenuV.Show()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim conexion As String
        conexion = "Data Source=DESKTOP-9JQIMLJ;Initial Catalog=Tienda;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        cn.Open()

        Dim comando As New SqlCommand("delete from factura.producto where idCliente =" & cboidproducto.Text & "", cn)
        comando.ExecuteNonQuery()
        MsgBox("Se elimino correctamente")
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        cboidproducto.Text = ""
        TxtDescripcion.Text = ""
        TxtNom.Text = ""
    End Sub
End Class