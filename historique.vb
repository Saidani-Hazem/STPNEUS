Public Class historique
    Private Sub btn_retourhist_Click(sender As Object, e As EventArgs) Handles btn_retourhist.Click
        HOME.Show()
        Me.Close()
    End Sub

    Private Sub historique_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtp_de.Format = DateTimePickerFormat.Custom
        dtp_de.CustomFormat = "yyyy/MM/dd"
        dtp_a.Format = DateTimePickerFormat.Custom
        dtp_a.CustomFormat = "yyyy/MM/dd"
        dtp_de.MaxDate = Date.Today
        dtp_a.MaxDate = Date.Today
    End Sub

    Private Sub dtp_de_ValueChanged(sender As Object, e As EventArgs) Handles dtp_de.ValueChanged
        dtp_a.MinDate = dtp_de.Value
    End Sub
    Private Sub btn_recherche_Click(sender As Object, e As EventArgs) Handles btn_recherche.Click
        If cmb_type.SelectedIndex = -1 Then
            MsgBox("choisir une operation 'ENTREE OU SORTIE'", MsgBoxStyle.Critical, "Erreur")
        ElseIf cmb_type.SelectedIndex = 0 Then
            If txt_ref.Text = "" Then
                AfficheEntre(dgv_hist, dtp_de.Value, dtp_a.Value)
            Else
                AfficheEntreref(dgv_hist, dtp_de.Value, dtp_a.Value, txt_ref.Text)
            End If
        ElseIf cmb_type.SelectedIndex = 1 Then
            If txt_ref.Text = "" Then
                Affichesort(dgv_hist, dtp_de.Value, dtp_a.Value)
            Else
                Affichesortref(dgv_hist, dtp_de.Value, dtp_a.Value, txt_ref.Text)
            End If
        End If
    End Sub
End Class