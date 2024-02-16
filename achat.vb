Public Class achat

    Public Sub supp()
        txt_marque.Clear()
        txt_prixuni.Clear()
        txt_qte.Clear()
        txt_reference.Clear()
    End Sub

    Private Sub btn_retourachat_Click(sender As Object, e As EventArgs) Handles btn_retourachat.Click
        HOME.Show()
        Me.Close()
    End Sub
    Private Sub achat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        txt_date.Text = Date.Today.ToString("dd/MMM/yyyy")
        txt_code.Text = CODE()
    End Sub
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        If txt_reference.Text = "" Or txt_marque.Text = "" Or cmb_marque.SelectedIndex = -1 Or txt_prixuni.Text = "" Or txt_qte.Text = "" Then
            MsgBox("remplir tous les champs", MsgBoxStyle.Critical, "Erreur")
        Else
            Dim ach As pneu
            ach.refrence = txt_reference.Text
            ach.marque = txt_marque.Text.ToUpper()
            ach.type = cmb_marque.SelectedItem
            ach.dateE = txt_date.Text
            ach.prixu = txt_prixuni.Text
            ach.qte = txt_qte.Text
            ajoutPN(ach)
            Dim en As entree
            en.code = CODE()
            en.id = CODEACH()
            en.refrence = txt_reference.Text
            en.marque = txt_marque.Text.ToUpper()
            en.type = cmb_marque.SelectedItem
            en.dateE = txt_date.Text
            en.prix_U_ACHAT = txt_prixuni.Text
            en.qte = txt_qte.Text
            ajoutAchat(en)
            MsgBox("ajoutee avec succes", MsgBoxStyle.Information, "Succès")
            supp()
            txt_code.Text = CODE()
        End If
    End Sub
    Private Sub txt_prixuni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_prixuni.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_qte_keyPress(sender As Object, e As KeyPressEventArgs) Handles txt_qte.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_marque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_marque.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        supp()
    End Sub


End Class