Public Class HOME

    Private Sub HOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim x As Integer = CInt((Me.Width - txt_recherche.Width) / 2)
        Dim y As Integer = CInt((Me.Height - txt_recherche.Height) * 0.32)
        txt_recherche.Location = New Point(x * 0.92, y)
        btn_rech.Location = New Point(x * 1.48, y * 0.99)
        dgv_rech.Location = New Point(x * 0.56, y * 1.2)
        pb_logo.Location = New Point(x * 1.07, y * 0.42)
    End Sub

    Private Sub VENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENTEToolStripMenuItem.Click
        login.Show()
        choix = 1
    End Sub
    Private Sub ACHATToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACHATToolStripMenuItem.Click
        login.Show()
        choix = 2
    End Sub
    Private Sub HISTORIQUEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HISTORIQUEToolStripMenuItem.Click
        login.Show()
        choix = 3
    End Sub
    Private Sub btn_rech_Click(sender As Object, e As EventArgs) Handles btn_rech.Click
        Dim ref As String = txt_recherche.Text
        If ref = "*" Then
            AfficheSock(dgv_rech)
        Else
            AffRT(dgv_rech, ref)
        End If
    End Sub


End Class
