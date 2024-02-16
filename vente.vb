Public Class vente
    Private Sub supp()
        txt_qtedisponible.Clear()
        txt_code.Clear()
        txt_marque.Clear()
        txt_reference.Clear()
        txt_type.Clear()
        txt_prixuniACHAT.Clear()
        txt_qte.Clear()
        txt_prixdevente.Clear()
    End Sub

    Private Sub btn_retourvente_Click(sender As Object, e As EventArgs) Handles btn_retourvente.Click
        HOME.Show()
        Close()
    End Sub
    Private Sub vente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        AfficheSock(dgv_pneu)
        txt_date.Text = Date.Today.ToString("dd/MMM/yyyy")
    End Sub
    Private Sub dgv_pneu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pneu.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = dgv_pneu.Rows(e.RowIndex)
            txt_code.Text = selectedRow.Cells(0).Value.ToString
            txt_reference.Text = selectedRow.Cells(1).Value.ToString
            txt_marque.Text = selectedRow.Cells(2).Value.ToString
            txt_type.Text = selectedRow.Cells(3).Value.ToString
            txt_prixuniACHAT.Text = selectedRow.Cells(5).Value.ToString
            txt_qtedisponible.Text = selectedRow.Cells(6).Value.ToString
        End If
    End Sub

    Private Sub btn_valid_Click(sender As Object, e As EventArgs) Handles btn_valid.Click
        If txt_type.Text.Length < 1 Or txt_reference.Text.Length < 1 Or txt_qte.Text = "" Or txt_prixdevente.Text = "" Then
            MsgBox("remplir tous les champs", MsgBoxStyle.Critical, "Erreur")
        Else
            Dim st As sortie
            If txt_qtedisponible.Text - txt_qte.Text < 0 Then
                MsgBox("quantite insuffisante", MsgBoxStyle.Critical, "Erreur")
            ElseIf txt_qtedisponible.Text - txt_qte.Text = 0 Then
                st.code = CODESRT()
                st.id = txt_code.Text
                st.refrence = txt_reference.Text
                st.marque = txt_marque.Text
                st.type = txt_type.Text
                st.dateS = txt_date.Text
                st.prix_U_Vente = txt_prixdevente.Text
                st.qte = txt_qte.Text
                ajoutSortie(st)
                MAJsupp(dgv_pneu, txt_code.Text)
                supp()
                AfficheSock(dgv_pneu)
                MsgBox("valider avec succès", MsgBoxStyle.Information, "Succès")
            Else
                st.code = CODESRT()
                st.id = txt_code.Text
                st.refrence = txt_reference.Text
                st.marque = txt_marque.Text
                st.type = txt_type.Text
                st.dateS = txt_date.Text
                st.prix_U_Vente = txt_prixdevente.Text
                st.qte = txt_qte.Text
                ajoutSortie(st)
                MAJ(dgv_pneu, txt_qte.Text, txt_code.Text)
                supp()
                AfficheSock(dgv_pneu)
                MsgBox("valider avec succès", MsgBoxStyle.Information, "Succès")
            End If
        End If
    End Sub

    Private Sub btn_recherche_Click_1(sender As Object, e As EventArgs) Handles btn_recherche.Click
        Dim rech = txt_rechvente.Text
        If rech = "*" Then
            AfficheSock(dgv_pneu)
        Else
            AffRT(dgv_pneu, rech)
        End If
    End Sub

    Private Sub txt_qte_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_qte.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_prixdevente_keypress(sender As Object, e As KeyPressEventArgs) Handles txt_prixdevente.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        supp()
    End Sub
End Class