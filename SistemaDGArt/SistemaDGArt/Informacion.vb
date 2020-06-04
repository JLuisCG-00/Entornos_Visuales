Public Class Informacion
    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub AgregarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarProductoToolStripMenuItem.Click
        Me.Close()
        Ingreso.Show()
    End Sub



    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub Informacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUActivo.Text = nombre
        TxtCargo2.Text = cargo
    End Sub
End Class