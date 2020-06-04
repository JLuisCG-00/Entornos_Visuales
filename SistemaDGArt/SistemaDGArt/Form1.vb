Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 5
            LblCarga.Text = "Cargando Sistema " & ProgressBar1.Value & " %"
        Else
            Timer1.Enabled = False
            Me.Hide()
            Inicio.Show()
        End If
    End Sub
End Class
