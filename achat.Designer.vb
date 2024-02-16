<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class achat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(achat))
        btn_retourachat = New Button()
        txt_reference = New TextBox()
        txt_marque = New TextBox()
        txt_prixuni = New TextBox()
        txt_qte = New TextBox()
        cmb_marque = New ComboBox()
        lbl_reference = New Label()
        lbl_marque = New Label()
        lbl_type = New Label()
        lbl_prixU = New Label()
        lbl_qte = New Label()
        lbl_date = New Label()
        txt_date = New TextBox()
        btn_ajouter = New Button()
        lbl_achat = New Label()
        txt_code = New TextBox()
        lbl_no = New Label()
        btn_annuler = New Button()
        SuspendLayout()
        ' 
        ' btn_retourachat
        ' 
        btn_retourachat.Image = CType(resources.GetObject("btn_retourachat.Image"), Image)
        btn_retourachat.Location = New Point(40, 40)
        btn_retourachat.Name = "btn_retourachat"
        btn_retourachat.Size = New Size(75, 80)
        btn_retourachat.TabIndex = 0
        btn_retourachat.UseVisualStyleBackColor = True
        ' 
        ' txt_reference
        ' 
        txt_reference.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_reference.Location = New Point(456, 445)
        txt_reference.MaxLength = 25
        txt_reference.Name = "txt_reference"
        txt_reference.Size = New Size(287, 32)
        txt_reference.TabIndex = 1
        ' 
        ' txt_marque
        ' 
        txt_marque.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_marque.Location = New Point(456, 565)
        txt_marque.MaxLength = 25
        txt_marque.Name = "txt_marque"
        txt_marque.Size = New Size(287, 32)
        txt_marque.TabIndex = 2
        ' 
        ' txt_prixuni
        ' 
        txt_prixuni.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_prixuni.Location = New Point(1042, 565)
        txt_prixuni.MaxLength = 14
        txt_prixuni.Name = "txt_prixuni"
        txt_prixuni.Size = New Size(287, 32)
        txt_prixuni.TabIndex = 4
        ' 
        ' txt_qte
        ' 
        txt_qte.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_qte.Location = New Point(1042, 675)
        txt_qte.MaxLength = 5
        txt_qte.Name = "txt_qte"
        txt_qte.Size = New Size(287, 32)
        txt_qte.TabIndex = 5
        ' 
        ' cmb_marque
        ' 
        cmb_marque.DisplayMember = "Normal"
        cmb_marque.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cmb_marque.FormattingEnabled = True
        cmb_marque.Items.AddRange(New Object() {"Normal", "Runflat"})
        cmb_marque.Location = New Point(456, 679)
        cmb_marque.Name = "cmb_marque"
        cmb_marque.Size = New Size(287, 32)
        cmb_marque.TabIndex = 6
        cmb_marque.ValueMember = "Normal"
        ' 
        ' lbl_reference
        ' 
        lbl_reference.AutoSize = True
        lbl_reference.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_reference.Location = New Point(329, 448)
        lbl_reference.Name = "lbl_reference"
        lbl_reference.Size = New Size(104, 23)
        lbl_reference.TabIndex = 8
        lbl_reference.Text = "Reference : "
        ' 
        ' lbl_marque
        ' 
        lbl_marque.AutoSize = True
        lbl_marque.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_marque.Location = New Point(329, 575)
        lbl_marque.Name = "lbl_marque"
        lbl_marque.Size = New Size(87, 23)
        lbl_marque.TabIndex = 10
        lbl_marque.Text = "Marque : "
        ' 
        ' lbl_type
        ' 
        lbl_type.AutoSize = True
        lbl_type.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_type.Location = New Point(329, 684)
        lbl_type.Name = "lbl_type"
        lbl_type.Size = New Size(63, 23)
        lbl_type.TabIndex = 11
        lbl_type.Text = "Type : "
        ' 
        ' lbl_prixU
        ' 
        lbl_prixU.AutoSize = True
        lbl_prixU.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_prixU.Location = New Point(902, 571)
        lbl_prixU.Name = "lbl_prixU"
        lbl_prixU.Size = New Size(120, 23)
        lbl_prixU.TabIndex = 12
        lbl_prixU.Text = "Prix Unitaire :"
        ' 
        ' lbl_qte
        ' 
        lbl_qte.AutoSize = True
        lbl_qte.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_qte.Location = New Point(902, 680)
        lbl_qte.Name = "lbl_qte"
        lbl_qte.Size = New Size(95, 23)
        lbl_qte.TabIndex = 13
        lbl_qte.Text = "Quantite : "
        ' 
        ' lbl_date
        ' 
        lbl_date.AutoSize = True
        lbl_date.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_date.Location = New Point(912, 453)
        lbl_date.Name = "lbl_date"
        lbl_date.Size = New Size(58, 23)
        lbl_date.TabIndex = 14
        lbl_date.Text = "Date :"
        ' 
        ' txt_date
        ' 
        txt_date.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_date.Location = New Point(1042, 448)
        txt_date.Name = "txt_date"
        txt_date.ReadOnly = True
        txt_date.Size = New Size(287, 32)
        txt_date.TabIndex = 15
        ' 
        ' btn_ajouter
        ' 
        btn_ajouter.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btn_ajouter.Location = New Point(1181, 792)
        btn_ajouter.Name = "btn_ajouter"
        btn_ajouter.Size = New Size(150, 41)
        btn_ajouter.TabIndex = 16
        btn_ajouter.Text = "Ajouter"
        btn_ajouter.UseVisualStyleBackColor = True
        ' 
        ' lbl_achat
        ' 
        lbl_achat.AutoSize = True
        lbl_achat.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_achat.ForeColor = Color.Red
        lbl_achat.Location = New Point(793, 235)
        lbl_achat.Name = "lbl_achat"
        lbl_achat.Size = New Size(162, 45)
        lbl_achat.TabIndex = 17
        lbl_achat.Text = "ACHAT"
        ' 
        ' txt_code
        ' 
        txt_code.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_code.Location = New Point(1209, 296)
        txt_code.Name = "txt_code"
        txt_code.ReadOnly = True
        txt_code.Size = New Size(121, 32)
        txt_code.TabIndex = 18
        ' 
        ' lbl_no
        ' 
        lbl_no.AutoSize = True
        lbl_no.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_no.Location = New Point(1133, 301)
        lbl_no.Name = "lbl_no"
        lbl_no.Size = New Size(56, 23)
        lbl_no.TabIndex = 19
        lbl_no.Text = "NUM:"
        ' 
        ' btn_annuler
        ' 
        btn_annuler.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btn_annuler.Location = New Point(1002, 792)
        btn_annuler.Name = "btn_annuler"
        btn_annuler.Size = New Size(150, 41)
        btn_annuler.TabIndex = 21
        btn_annuler.Text = "Annuler"
        btn_annuler.UseVisualStyleBackColor = True
        ' 
        ' achat
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(1422, 853)
        Controls.Add(btn_annuler)
        Controls.Add(lbl_no)
        Controls.Add(txt_code)
        Controls.Add(lbl_achat)
        Controls.Add(btn_ajouter)
        Controls.Add(txt_date)
        Controls.Add(lbl_date)
        Controls.Add(lbl_qte)
        Controls.Add(lbl_prixU)
        Controls.Add(lbl_type)
        Controls.Add(lbl_marque)
        Controls.Add(lbl_reference)
        Controls.Add(btn_retourachat)
        Controls.Add(cmb_marque)
        Controls.Add(txt_qte)
        Controls.Add(txt_prixuni)
        Controls.Add(txt_marque)
        Controls.Add(txt_reference)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "achat"
        StartPosition = FormStartPosition.Manual
        Text = "achat"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_retourachat As Button
    Friend WithEvents txt_reference As TextBox
    Friend WithEvents txt_marque As TextBox
    Friend WithEvents txt_prixuni As TextBox
    Friend WithEvents txt_qte As TextBox
    Friend WithEvents cmb_marque As ComboBox
    Friend WithEvents lbl_reference As Label
    Friend WithEvents lbl_marque As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_prixU As Label
    Friend WithEvents lbl_qte As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents txt_date As TextBox
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents lbl_achat As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents lbl_no As Label
    Friend WithEvents btn_annuler As Button
End Class
