<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HOME
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HOME))
        txt_recherche = New TextBox()
        mst_home = New MenuStrip()
        VENTEToolStripMenuItem = New ToolStripMenuItem()
        ACHATToolStripMenuItem = New ToolStripMenuItem()
        HISTORIQUEToolStripMenuItem = New ToolStripMenuItem()
        btn_rech = New Button()
        dgv_rech = New DataGridView()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        pb_logo = New PictureBox()
        mst_home.SuspendLayout()
        CType(dgv_rech, ComponentModel.ISupportInitialize).BeginInit()
        CType(pb_logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_recherche
        ' 
        txt_recherche.Font = New Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txt_recherche.Location = New Point(513, 299)
        txt_recherche.Name = "txt_recherche"
        txt_recherche.PlaceholderText = "Reference"
        txt_recherche.Size = New Size(329, 35)
        txt_recherche.TabIndex = 0
        ' 
        ' mst_home
        ' 
        mst_home.BackColor = Color.Yellow
        mst_home.Dock = DockStyle.None
        mst_home.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        mst_home.ImageScalingSize = New Size(20, 20)
        mst_home.Items.AddRange(New ToolStripItem() {VENTEToolStripMenuItem, ACHATToolStripMenuItem, HISTORIQUEToolStripMenuItem})
        mst_home.Location = New Point(9, 9)
        mst_home.Name = "mst_home"
        mst_home.Padding = New Padding(6, 3, 0, 3)
        mst_home.Size = New Size(313, 35)
        mst_home.TabIndex = 1
        mst_home.Text = "MenuStrip1"
        ' 
        ' VENTEToolStripMenuItem
        ' 
        VENTEToolStripMenuItem.Name = "VENTEToolStripMenuItem"
        VENTEToolStripMenuItem.Size = New Size(83, 29)
        VENTEToolStripMenuItem.Text = "VENTE"
        ' 
        ' ACHATToolStripMenuItem
        ' 
        ACHATToolStripMenuItem.Name = "ACHATToolStripMenuItem"
        ACHATToolStripMenuItem.Size = New Size(87, 29)
        ACHATToolStripMenuItem.Text = "ACHAT"
        ' 
        ' HISTORIQUEToolStripMenuItem
        ' 
        HISTORIQUEToolStripMenuItem.Name = "HISTORIQUEToolStripMenuItem"
        HISTORIQUEToolStripMenuItem.Size = New Size(135, 29)
        HISTORIQUEToolStripMenuItem.Text = "HISTORIQUE"
        ' 
        ' btn_rech
        ' 
        btn_rech.Font = New Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_rech.Image = CType(resources.GetObject("btn_rech.Image"), Image)
        btn_rech.Location = New Point(880, 283)
        btn_rech.Name = "btn_rech"
        btn_rech.Size = New Size(110, 56)
        btn_rech.TabIndex = 2
        btn_rech.UseVisualStyleBackColor = True
        ' 
        ' dgv_rech
        ' 
        dgv_rech.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        dgv_rech.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_rech.Location = New Point(231, 369)
        dgv_rech.Name = "dgv_rech"
        dgv_rech.RowHeadersWidth = 51
        dgv_rech.Size = New Size(906, 421)
        dgv_rech.TabIndex = 3
        ' 
        ' pb_logo
        ' 
        pb_logo.BackColor = Color.Transparent
        pb_logo.Image = CType(resources.GetObject("pb_logo.Image"), Image)
        pb_logo.Location = New Point(630, 21)
        pb_logo.Name = "pb_logo"
        pb_logo.Size = New Size(212, 183)
        pb_logo.TabIndex = 4
        pb_logo.TabStop = False
        ' 
        ' HOME
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(882, 853)
        Controls.Add(dgv_rech)
        Controls.Add(pb_logo)
        Controls.Add(btn_rech)
        Controls.Add(txt_recherche)
        Controls.Add(mst_home)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = mst_home
        Name = "HOME"
        StartPosition = FormStartPosition.CenterScreen
        Text = "HOME"
        mst_home.ResumeLayout(False)
        mst_home.PerformLayout()
        CType(dgv_rech, ComponentModel.ISupportInitialize).EndInit()
        CType(pb_logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_recherche As TextBox
    Friend WithEvents mst_home As MenuStrip
    Friend WithEvents VENTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ACHATToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HISTORIQUEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_rech As Button
    Friend WithEvents dgv_rech As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pb_logo As PictureBox

End Class
