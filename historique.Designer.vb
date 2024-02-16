<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class historique
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(historique))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btn_retourhist = New Button()
        dgv_hist = New DataGridView()
        cmb_type = New ComboBox()
        lbl_histo = New Label()
        dtp_de = New DateTimePicker()
        dtp_a = New DateTimePicker()
        btn_recherche = New Button()
        lbl_de = New Label()
        lbl_a = New Label()
        txt_ref = New TextBox()
        lbl_ref = New Label()
        CType(dgv_hist, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_retourhist
        ' 
        btn_retourhist.Image = CType(resources.GetObject("btn_retourhist.Image"), Image)
        btn_retourhist.Location = New Point(40, 40)
        btn_retourhist.Name = "btn_retourhist"
        btn_retourhist.Size = New Size(75, 80)
        btn_retourhist.TabIndex = 0
        btn_retourhist.UseVisualStyleBackColor = True
        ' 
        ' dgv_hist
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgv_hist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgv_hist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_hist.Location = New Point(280, 440)
        dgv_hist.Name = "dgv_hist"
        dgv_hist.RowHeadersWidth = 51
        dgv_hist.Size = New Size(1136, 523)
        dgv_hist.TabIndex = 1
        ' 
        ' cmb_type
        ' 
        cmb_type.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        cmb_type.FormattingEnabled = True
        cmb_type.Items.AddRange(New Object() {"Entree", "Sortie"})
        cmb_type.Location = New Point(280, 366)
        cmb_type.Name = "cmb_type"
        cmb_type.Size = New Size(226, 31)
        cmb_type.TabIndex = 7
        ' 
        ' lbl_histo
        ' 
        lbl_histo.AutoSize = True
        lbl_histo.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_histo.ForeColor = Color.Black
        lbl_histo.Location = New Point(718, 195)
        lbl_histo.Name = "lbl_histo"
        lbl_histo.Size = New Size(278, 45)
        lbl_histo.TabIndex = 31
        lbl_histo.Text = "HISTORIQUE"
        ' 
        ' dtp_de
        ' 
        dtp_de.Font = New Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        dtp_de.Location = New Point(863, 366)
        dtp_de.Name = "dtp_de"
        dtp_de.Size = New Size(171, 28)
        dtp_de.TabIndex = 32
        ' 
        ' dtp_a
        ' 
        dtp_a.Font = New Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        dtp_a.Location = New Point(1089, 367)
        dtp_a.Name = "dtp_a"
        dtp_a.Size = New Size(171, 28)
        dtp_a.TabIndex = 33
        ' 
        ' btn_recherche
        ' 
        btn_recherche.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btn_recherche.Location = New Point(1280, 363)
        btn_recherche.Name = "btn_recherche"
        btn_recherche.Size = New Size(136, 35)
        btn_recherche.TabIndex = 34
        btn_recherche.Text = "recherche"
        btn_recherche.UseVisualStyleBackColor = True
        ' 
        ' lbl_de
        ' 
        lbl_de.AutoSize = True
        lbl_de.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_de.Location = New Point(820, 369)
        lbl_de.Name = "lbl_de"
        lbl_de.Size = New Size(37, 23)
        lbl_de.TabIndex = 35
        lbl_de.Text = "DE:"
        ' 
        ' lbl_a
        ' 
        lbl_a.AutoSize = True
        lbl_a.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_a.Location = New Point(1056, 370)
        lbl_a.Name = "lbl_a"
        lbl_a.Size = New Size(27, 23)
        lbl_a.TabIndex = 36
        lbl_a.Text = "A:"
        ' 
        ' txt_ref
        ' 
        txt_ref.Font = New Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        txt_ref.Location = New Point(598, 366)
        txt_ref.Name = "txt_ref"
        txt_ref.Size = New Size(195, 28)
        txt_ref.TabIndex = 37
        ' 
        ' lbl_ref
        ' 
        lbl_ref.AutoSize = True
        lbl_ref.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_ref.Location = New Point(548, 368)
        lbl_ref.Name = "lbl_ref"
        lbl_ref.Size = New Size(44, 23)
        lbl_ref.TabIndex = 38
        lbl_ref.Text = "REF:"
        ' 
        ' historique
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(1422, 853)
        Controls.Add(lbl_ref)
        Controls.Add(txt_ref)
        Controls.Add(lbl_a)
        Controls.Add(lbl_de)
        Controls.Add(btn_recherche)
        Controls.Add(dtp_a)
        Controls.Add(dtp_de)
        Controls.Add(lbl_histo)
        Controls.Add(cmb_type)
        Controls.Add(dgv_hist)
        Controls.Add(btn_retourhist)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "historique"
        StartPosition = FormStartPosition.Manual
        Text = "historique"
        CType(dgv_hist, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_retourhist As Button
    Friend WithEvents dgv_hist As DataGridView
    Friend WithEvents cmb_type As ComboBox
    Friend WithEvents lbl_histo As Label
    Friend WithEvents dtp_de As DateTimePicker
    Friend WithEvents dtp_a As DateTimePicker
    Friend WithEvents btn_recherche As Button
    Friend WithEvents lbl_de As Label
    Friend WithEvents lbl_a As Label
    Friend WithEvents txt_ref As TextBox
    Friend WithEvents lbl_ref As Label
End Class
