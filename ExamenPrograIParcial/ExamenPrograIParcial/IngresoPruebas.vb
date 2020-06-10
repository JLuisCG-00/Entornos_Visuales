Public Class IngresoPruebas
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TxtResult.TextChanged

    End Sub

    Private Sub CbmMunicipio_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        MessageBox.Show("¿Seguro que desea salir?", "Confirmacion de salida", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        End
    End Sub

    Private Sub IngresoPruebas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CbmDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbmDepartamento.SelectedIndexChanged

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim cont As Integer
        Dim totalacti As Integer


        LbNombre.Items.Add(TxtNombre.Text)
        LbResultado.Items.Add(TxtResult.Text)
        If CheckActivo.Checked = True Then
            LbEstado.Items.Add(CheckActivo.Text)
        End If

        If CheckActivo.Checked = True Then
            cont += 1
            totalacti = cont
        End If
        TxtActi.Text = totalacti
        LbMun.Items.Add(TxtMunicipio.Text)
        LbEdad.Items.Add(TxtEdad.Text)
    End Sub

    Private Sub TxtDescrip_TextChanged(sender As Object, e As EventArgs) Handles TxtDescrip.TextChanged

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtDescrip.Clear()
        TxtEdad.Clear()
        TxtMunicipio.Clear()
        TxtNombre.Clear()
        TxtMunicipio.Clear()
        TxtResult.Clear()
        CbmDepartamento.Text = ""
        CheckActivo.Checked = False
        CheckRecup.Checked = False
        CheckMuerto.Checked = False
    End Sub

    Private Sub CheckActivo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckActivo.CheckedChanged
        If CheckActivo.Checked = True Then
            CheckMuerto.Enabled = False
            CheckRecup.Enabled = False
        Else
            CheckMuerto.Enabled = True
            CheckRecup.Enabled = True
        End If
    End Sub

    Private Sub CheckRecup_CheckedChanged(sender As Object, e As EventArgs) Handles CheckRecup.CheckedChanged
        If CheckRecup.Checked = True Then
            CheckMuerto.Enabled = False
            CheckActivo.Enabled = False
        Else
            CheckMuerto.Enabled = True
            CheckActivo.Enabled = True
        End If
    End Sub

    Private Sub CheckMuerto_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMuerto.CheckedChanged
        If CheckMuerto.Checked = True Then
            CheckActivo.Enabled = False
            CheckRecup.Enabled = False
        Else
            CheckActivo.Enabled = True
            CheckRecup.Enabled = True
        End If
    End Sub
End Class