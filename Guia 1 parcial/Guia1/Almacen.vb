Public Class Almacen

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu_Principal.Show()
        Me.Hide()

    End Sub
    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Dim media, suma, venta1, venta2, venta3, venta4, venta5, venta6, venta7, venta8, venta9, venta10 As Double

        Try

            venta1 = InputBox("Ingrese las ventas obtenidas por Almacen #1", "Ingresar")
            venta2 = InputBox("Ingrese las ventas obtenidas por Almacen #2", "Ingresar")
            venta3 = InputBox("Ingrese las ventas obtenidas por Almacen #3", "Ingresar")
            venta4 = InputBox("Ingrese las ventas obtenidas por Almacen #4", "Ingresar")
            venta5 = InputBox("Ingrese las ventas obtenidas por Almacen #5", "Ingresar")
            venta6 = InputBox("Ingrese las ventas obtenidas por Almacen #6", "Ingresar")
            venta7 = InputBox("Ingrese las ventas obtenidas por Almacen #7", "Ingresar")
            venta8 = InputBox("Ingrese las ventas obtenidas por Almacen #8", "Ingresar")
            venta9 = InputBox("Ingrese las ventas obtenidas por Almacen #9", "Ingresar")
            venta10 = InputBox("Ingrese las ventas obtenidas por Almacen #10", "Ingresar")

            suma = venta1 + venta2 + venta3 + venta4 + venta5 + venta6 + venta7 + venta8 + venta9 + venta10
            media = suma / 10

            If venta1 > media Then
                ListBox_EmpresaSuperior.Items.Add("Almacen #1" & " = " & venta1)
            End If
            If venta2 > media Then
                ListBox_EmpresaSuperior.Items.Add("Almacen #2" & " = " & venta2)
            End If
            If venta3 > media Then
                ListBox_EmpresaSuperior.Items.Add("Almacen #3" & " = " & venta3)
            End If
            If venta4 > media Then
                ListBox_EmpresaSuperior.Items.Add("Almacen #4" & " = " & venta4)
            End If
            If venta5 > media Then
                ListBox_EmpresaSuperior.Items.Add("Almacen #5" & " = " & venta5)
            End If
            If venta6 > media Then
                ListBox_EmpresaSuperior.Items.Add("Almacen #6" & " = " & venta6)
            End If
            If venta7 > media Then
                ListBox_EmpresaSuperior.Items.Add("Almacen #7" & " = " & venta7)
            End If
            If venta8 > media Then
                ListBox_EmpresaSuperior.Items.Add("Almacen #8" & " = " & venta8)
            End If
            If venta9 > media Then
                ListBox_EmpresaSuperior.Items.Add("Almacen #9" & " = " & venta9)
            End If
            If venta10 > media Then
                ListBox_EmpresaSuperior.Items.Add("Almacen #10" & " = " & venta10)
            End If
            TextBox_Media.Text = media

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ButtonNuevo_Click_1(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        TextBox_Media.Clear()
        ListBox_EmpresaSuperior.Items.Clear()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub


End Class