Module affichage
    Public choix As Integer
    Function verif()
        Dim pass As String = login.txt_pass.Text
        If pass = "open" Or pass = "changeme" Then
            If choix = 1 Then
                vente.Show()
                login.Close()
            ElseIf choix = 2 Then
                achat.Show()
                login.Close()
            ElseIf choix = 3 Then
                historique.Show()
                login.Close()
            End If
            HOME.Hide()
        Else
            MsgBox("verifier votre mot de passe", MsgBoxStyle.Critical, "Erreur")
        End If
        Return 0
    End Function
End Module