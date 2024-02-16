<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        txt_pass = New TextBox()
        btn_connection = New Button()
        btn_ann = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_pass
        ' 
        txt_pass.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        txt_pass.Location = New Point(291, 77)
        txt_pass.Margin = New Padding(3, 2, 3, 2)
        txt_pass.Name = "txt_pass"
        txt_pass.PasswordChar = "*"c
        txt_pass.PlaceholderText = "mot de passe"
        txt_pass.Size = New Size(304, 32)
        txt_pass.TabIndex = 1
        ' 
        ' btn_connection
        ' 
        btn_connection.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold)
        btn_connection.Location = New Point(479, 154)
        btn_connection.Margin = New Padding(3, 2, 3, 2)
        btn_connection.Name = "btn_connection"
        btn_connection.Size = New Size(116, 36)
        btn_connection.TabIndex = 17
        btn_connection.Text = "valider"
        btn_connection.UseVisualStyleBackColor = True
        ' 
        ' btn_ann
        ' 
        btn_ann.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold)
        btn_ann.Location = New Point(336, 154)
        btn_ann.Margin = New Padding(3, 2, 3, 2)
        btn_ann.Name = "btn_ann"
        btn_ann.Size = New Size(107, 36)
        btn_ann.TabIndex = 18
        btn_ann.Text = "annuler"
        btn_ann.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(65, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(149, 150)
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(673, 226)
        Controls.Add(PictureBox1)
        Controls.Add(btn_ann)
        Controls.Add(btn_connection)
        Controls.Add(txt_pass)
        Font = New Font("Microsoft Sans Serif", 7.8F)
        Margin = New Padding(3, 2, 3, 2)
        Name = "login"
        Text = "login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents btn_connection As Button
    Friend WithEvents btn_ann As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
