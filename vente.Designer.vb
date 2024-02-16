<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vente))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btn_retourvente = New Button()
        dgv_pneu = New DataGridView()
        txt_rechvente = New TextBox()
        btn_recherche = New Button()
        txt_date = New TextBox()
        lbl_date = New Label()
        lbl_qte = New Label()
        lbl_prixU = New Label()
        lbl_type = New Label()
        lbl_marque = New Label()
        lbl_reference = New Label()
        txt_qte = New TextBox()
        txt_prixuniACHAT = New TextBox()
        txt_marque = New TextBox()
        txt_reference = New TextBox()
        txt_type = New TextBox()
        btn_valid = New Button()
        lbl_vente = New Label()
        txt_prixdevente = New TextBox()
        lbl_prixvente = New Label()
        txt_code = New TextBox()
        lbl_code = New Label()
        txt_qtedisponible = New TextBox()
        btn_annuler = New Button()
        CType(dgv_pneu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_retourvente
        ' 
        btn_retourvente.Image = CType(resources.GetObject("btn_retourvente.Image"), Image)
        btn_retourvente.Location = New Point(40, 40)
        btn_retourvente.Name = "btn_retourvente"
        btn_retourvente.Size = New Size(75, 80)
        btn_retourvente.TabIndex = 0
        btn_retourvente.UseVisualStyleBackColor = True
        ' 
        ' dgv_pneu
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgv_pneu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgv_pneu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_pneu.Location = New Point(119, 285)
        dgv_pneu.Name = "dgv_pneu"
        dgv_pneu.RowHeadersWidth = 51
        dgv_pneu.Size = New Size(864, 620)
        dgv_pneu.TabIndex = 1
        ' 
        ' txt_rechvente
        ' 
        txt_rechvente.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_rechvente.Location = New Point(327, 216)
        txt_rechvente.Name = "txt_rechvente"
        txt_rechvente.Size = New Size(297, 32)
        txt_rechvente.TabIndex = 2
        ' 
        ' btn_recherche
        ' 
        btn_recherche.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btn_recherche.Location = New Point(673, 213)
        btn_recherche.Name = "btn_recherche"
        btn_recherche.Size = New Size(115, 44)
        btn_recherche.TabIndex = 3
        btn_recherche.Text = "recherche"
        btn_recherche.UseVisualStyleBackColor = True
        ' 
        ' txt_date
        ' 
        txt_date.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        txt_date.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_date.Location = New Point(1224, 509)
        txt_date.Name = "txt_date"
        txt_date.ReadOnly = True
        txt_date.Size = New Size(257, 32)
        txt_date.TabIndex = 27
        ' 
        ' lbl_date
        ' 
        lbl_date.AutoSize = True
        lbl_date.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_date.Location = New Point(1112, 515)
        lbl_date.Name = "lbl_date"
        lbl_date.Size = New Size(58, 23)
        lbl_date.TabIndex = 26
        lbl_date.Text = "Date :"
        ' 
        ' lbl_qte
        ' 
        lbl_qte.AutoSize = True
        lbl_qte.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_qte.Location = New Point(1080, 724)
        lbl_qte.Name = "lbl_qte"
        lbl_qte.Size = New Size(95, 23)
        lbl_qte.TabIndex = 25
        lbl_qte.Text = "Quantite : "
        ' 
        ' lbl_prixU
        ' 
        lbl_prixU.AutoSize = True
        lbl_prixU.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_prixU.Location = New Point(1050, 623)
        lbl_prixU.Name = "lbl_prixU"
        lbl_prixU.Size = New Size(148, 23)
        lbl_prixU.TabIndex = 24
        lbl_prixU.Text = "Prix UNI ACHAT :"
        ' 
        ' lbl_type
        ' 
        lbl_type.AutoSize = True
        lbl_type.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_type.Location = New Point(1112, 563)
        lbl_type.Name = "lbl_type"
        lbl_type.Size = New Size(63, 23)
        lbl_type.TabIndex = 23
        lbl_type.Text = "Type : "
        ' 
        ' lbl_marque
        ' 
        lbl_marque.AutoSize = True
        lbl_marque.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_marque.Location = New Point(1111, 407)
        lbl_marque.Name = "lbl_marque"
        lbl_marque.Size = New Size(87, 23)
        lbl_marque.TabIndex = 22
        lbl_marque.Text = "Marque : "
        ' 
        ' lbl_reference
        ' 
        lbl_reference.AutoSize = True
        lbl_reference.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_reference.Location = New Point(1111, 461)
        lbl_reference.Name = "lbl_reference"
        lbl_reference.Size = New Size(104, 23)
        lbl_reference.TabIndex = 21
        lbl_reference.Text = "Reference : "
        ' 
        ' txt_qte
        ' 
        txt_qte.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_qte.Location = New Point(1224, 719)
        txt_qte.Name = "txt_qte"
        txt_qte.Size = New Size(257, 32)
        txt_qte.TabIndex = 19
        ' 
        ' txt_prixuniACHAT
        ' 
        txt_prixuniACHAT.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        txt_prixuniACHAT.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_prixuniACHAT.Location = New Point(1224, 617)
        txt_prixuniACHAT.Name = "txt_prixuniACHAT"
        txt_prixuniACHAT.ReadOnly = True
        txt_prixuniACHAT.Size = New Size(257, 32)
        txt_prixuniACHAT.TabIndex = 18
        ' 
        ' txt_marque
        ' 
        txt_marque.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        txt_marque.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_marque.Location = New Point(1224, 401)
        txt_marque.Name = "txt_marque"
        txt_marque.ReadOnly = True
        txt_marque.Size = New Size(257, 32)
        txt_marque.TabIndex = 17
        ' 
        ' txt_reference
        ' 
        txt_reference.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        txt_reference.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_reference.Location = New Point(1224, 456)
        txt_reference.Name = "txt_reference"
        txt_reference.ReadOnly = True
        txt_reference.Size = New Size(257, 32)
        txt_reference.TabIndex = 16
        ' 
        ' txt_type
        ' 
        txt_type.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        txt_type.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_type.Location = New Point(1224, 563)
        txt_type.Name = "txt_type"
        txt_type.ReadOnly = True
        txt_type.Size = New Size(257, 32)
        txt_type.TabIndex = 28
        ' 
        ' btn_valid
        ' 
        btn_valid.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btn_valid.Location = New Point(1385, 877)
        btn_valid.Name = "btn_valid"
        btn_valid.Size = New Size(113, 37)
        btn_valid.TabIndex = 29
        btn_valid.Text = "valider"
        btn_valid.UseVisualStyleBackColor = True
        ' 
        ' lbl_vente
        ' 
        lbl_vente.AutoSize = True
        lbl_vente.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_vente.ForeColor = Color.ForestGreen
        lbl_vente.Location = New Point(1263, 247)
        lbl_vente.Name = "lbl_vente"
        lbl_vente.Size = New Size(159, 45)
        lbl_vente.TabIndex = 30
        lbl_vente.Text = "VENTE"
        ' 
        ' txt_prixdevente
        ' 
        txt_prixdevente.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_prixdevente.Location = New Point(1224, 771)
        txt_prixdevente.Name = "txt_prixdevente"
        txt_prixdevente.Size = New Size(257, 32)
        txt_prixdevente.TabIndex = 31
        ' 
        ' lbl_prixvente
        ' 
        lbl_prixvente.AutoSize = True
        lbl_prixvente.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_prixvente.Location = New Point(1050, 776)
        lbl_prixvente.Name = "lbl_prixvente"
        lbl_prixvente.Size = New Size(143, 23)
        lbl_prixvente.TabIndex = 32
        lbl_prixvente.Text = "PrixUNI VENTE : "
        ' 
        ' txt_code
        ' 
        txt_code.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        txt_code.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_code.Location = New Point(1224, 352)
        txt_code.Name = "txt_code"
        txt_code.ReadOnly = True
        txt_code.Size = New Size(257, 32)
        txt_code.TabIndex = 33
        ' 
        ' lbl_code
        ' 
        lbl_code.AutoSize = True
        lbl_code.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_code.Location = New Point(1112, 357)
        lbl_code.Name = "lbl_code"
        lbl_code.Size = New Size(56, 23)
        lbl_code.TabIndex = 34
        lbl_code.Text = "Code:"
        ' 
        ' txt_qtedisponible
        ' 
        txt_qtedisponible.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_qtedisponible.Location = New Point(1222, 275)
        txt_qtedisponible.Name = "txt_qtedisponible"
        txt_qtedisponible.ReadOnly = True
        txt_qtedisponible.Size = New Size(259, 32)
        txt_qtedisponible.TabIndex = 35
        txt_qtedisponible.Visible = False
        ' 
        ' btn_annuler
        ' 
        btn_annuler.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btn_annuler.Location = New Point(1250, 879)
        btn_annuler.Name = "btn_annuler"
        btn_annuler.Size = New Size(113, 37)
        btn_annuler.TabIndex = 36
        btn_annuler.Text = "annuler"
        btn_annuler.UseVisualStyleBackColor = True
        ' 
        ' vente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(1422, 853)
        Controls.Add(lbl_vente)
        Controls.Add(dgv_pneu)
        Controls.Add(btn_annuler)
        Controls.Add(txt_qtedisponible)
        Controls.Add(lbl_code)
        Controls.Add(txt_code)
        Controls.Add(lbl_prixvente)
        Controls.Add(txt_prixdevente)
        Controls.Add(btn_valid)
        Controls.Add(txt_type)
        Controls.Add(txt_date)
        Controls.Add(lbl_date)
        Controls.Add(lbl_qte)
        Controls.Add(lbl_prixU)
        Controls.Add(lbl_type)
        Controls.Add(lbl_marque)
        Controls.Add(lbl_reference)
        Controls.Add(txt_qte)
        Controls.Add(txt_prixuniACHAT)
        Controls.Add(txt_marque)
        Controls.Add(txt_reference)
        Controls.Add(btn_recherche)
        Controls.Add(txt_rechvente)
        Controls.Add(btn_retourvente)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "vente"
        StartPosition = FormStartPosition.Manual
        Text = "vente"
        CType(dgv_pneu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_retourvente As Button
    Friend WithEvents dgv_pneu As DataGridView
    Friend WithEvents txt_rechvente As TextBox
    Friend WithEvents btn_recherche As Button
    Friend WithEvents txt_date As TextBox
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_qte As Label
    Friend WithEvents lbl_prixU As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_marque As Label
    Friend WithEvents lbl_reference As Label
    Friend WithEvents txt_qte As TextBox
    Friend WithEvents txt_prixuniACHAT As TextBox
    Friend WithEvents txt_marque As TextBox
    Friend WithEvents txt_reference As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents btn_valid As Button
    Friend WithEvents lbl_vente As Label
    Friend WithEvents txt_prixdevente As TextBox
    Friend WithEvents lbl_prixvente As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents lbl_code As Label
    Friend WithEvents txt_qtedisponible As TextBox
    Friend WithEvents btn_annuler As Button
End Class
