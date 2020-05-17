<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RN
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RN))
        Me.DetailPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.AdresseLabel = New System.Windows.Forms.Label()
        Me.PromoLabel = New System.Windows.Forms.Label()
        Me.Matricule = New System.Windows.Forms.Label()
        Me.PrenomLabel = New System.Windows.Forms.Label()
        Me.NomLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BT_LOAD = New System.Windows.Forms.Button()
        Me.CB_ANNEE = New System.Windows.Forms.ComboBox()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.BT_SORTIR = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NoResultPanel = New System.Windows.Forms.Panel()
        Me.NoResultLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.AvertToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ImprTotalLabel = New System.Windows.Forms.Label()
        Me.BilanLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.DetailPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TitlePanel.SuspendLayout()
        Me.NoResultPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DetailPanel
        '
        Me.DetailPanel.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.DetailPanel.Controls.Add(Me.Panel1)
        Me.DetailPanel.Location = New System.Drawing.Point(0, 0)
        Me.DetailPanel.Name = "DetailPanel"
        Me.DetailPanel.Size = New System.Drawing.Size(678, 640)
        Me.DetailPanel.TabIndex = 87
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.TableLayoutPanel8)
        Me.Panel1.Controls.Add(Me.ImprTotalLabel)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.BT_LOAD)
        Me.Panel1.Controls.Add(Me.CB_ANNEE)
        Me.Panel1.Controls.Add(Me.TitlePanel)
        Me.Panel1.Controls.Add(Me.NoResultPanel)
        Me.Panel1.Controls.Add(Me.CrystalReportViewer1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(679, 640)
        Me.Panel1.TabIndex = 88
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel8.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.table_blanc1
        Me.TableLayoutPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel8.ColumnCount = 5
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15152!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15152!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.12121!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.47475!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101!))
        Me.TableLayoutPanel8.Controls.Add(Me.AdresseLabel, 3, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.PromoLabel, 4, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Matricule, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.PrenomLabel, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.NomLabel, 0, 0)
        Me.TableLayoutPanel8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TableLayoutPanel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TableLayoutPanel8.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(9, 56)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(661, 43)
        Me.TableLayoutPanel8.TabIndex = 53
        '
        'AdresseLabel
        '
        Me.AdresseLabel.AutoEllipsis = True
        Me.AdresseLabel.AutoSize = True
        Me.AdresseLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdresseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.AdresseLabel.Location = New System.Drawing.Point(282, 2)
        Me.AdresseLabel.Name = "AdresseLabel"
        Me.AdresseLabel.Size = New System.Drawing.Size(305, 39)
        Me.AdresseLabel.TabIndex = 4
        Me.AdresseLabel.Text = "Adresse"
        Me.AdresseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PromoLabel
        '
        Me.PromoLabel.AutoEllipsis = True
        Me.PromoLabel.AutoSize = True
        Me.PromoLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PromoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PromoLabel.Location = New System.Drawing.Point(593, 2)
        Me.PromoLabel.Name = "PromoLabel"
        Me.PromoLabel.Size = New System.Drawing.Size(63, 39)
        Me.PromoLabel.TabIndex = 3
        Me.PromoLabel.Text = "Promo"
        Me.PromoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Matricule
        '
        Me.Matricule.AutoEllipsis = True
        Me.Matricule.AutoSize = True
        Me.Matricule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Matricule.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Matricule.Location = New System.Drawing.Point(203, 2)
        Me.Matricule.Name = "Matricule"
        Me.Matricule.Size = New System.Drawing.Size(73, 39)
        Me.Matricule.TabIndex = 2
        Me.Matricule.Text = "Matrin"
        Me.Matricule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrenomLabel
        '
        Me.PrenomLabel.AutoEllipsis = True
        Me.PrenomLabel.AutoSize = True
        Me.PrenomLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrenomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PrenomLabel.Location = New System.Drawing.Point(104, 2)
        Me.PrenomLabel.Name = "PrenomLabel"
        Me.PrenomLabel.Size = New System.Drawing.Size(93, 39)
        Me.PrenomLabel.TabIndex = 1
        Me.PrenomLabel.Text = "Prénom"
        Me.PrenomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NomLabel
        '
        Me.NomLabel.AutoEllipsis = True
        Me.NomLabel.AutoSize = True
        Me.NomLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.NomLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NomLabel.Location = New System.Drawing.Point(5, 2)
        Me.NomLabel.Name = "NomLabel"
        Me.NomLabel.Size = New System.Drawing.Size(93, 39)
        Me.NomLabel.TabIndex = 0
        Me.NomLabel.Text = "Nom"
        Me.NomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Année d'étude "
        '
        'BT_LOAD
        '
        Me.BT_LOAD.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BT_LOAD.FlatAppearance.BorderSize = 0
        Me.BT_LOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LOAD.Font = New System.Drawing.Font("Cambria", 12.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_LOAD.ForeColor = System.Drawing.Color.White
        Me.BT_LOAD.Location = New System.Drawing.Point(478, 112)
        Me.BT_LOAD.Name = "BT_LOAD"
        Me.BT_LOAD.Size = New System.Drawing.Size(80, 27)
        Me.BT_LOAD.TabIndex = 47
        Me.BT_LOAD.Text = "Afficher"
        Me.BT_LOAD.UseVisualStyleBackColor = False
        '
        'CB_ANNEE
        '
        Me.CB_ANNEE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_ANNEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ANNEE.FormattingEnabled = True
        Me.CB_ANNEE.Location = New System.Drawing.Point(131, 114)
        Me.CB_ANNEE.Name = "CB_ANNEE"
        Me.CB_ANNEE.Size = New System.Drawing.Size(333, 24)
        Me.CB_ANNEE.TabIndex = 48
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.Transparent
        Me.TitlePanel.Controls.Add(Me.BilanLinkLabel)
        Me.TitlePanel.Controls.Add(Me.BT_SORTIR)
        Me.TitlePanel.Controls.Add(Me.Label2)
        Me.TitlePanel.Controls.Add(Me.Label1)
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(679, 52)
        Me.TitlePanel.TabIndex = 0
        '
        'BT_SORTIR
        '
        Me.BT_SORTIR.BackColor = System.Drawing.Color.Transparent
        Me.BT_SORTIR.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.arrows
        Me.BT_SORTIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_SORTIR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_SORTIR.FlatAppearance.BorderSize = 0
        Me.BT_SORTIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SORTIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_SORTIR.ForeColor = System.Drawing.Color.White
        Me.BT_SORTIR.Location = New System.Drawing.Point(31, 2)
        Me.BT_SORTIR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 100)
        Me.BT_SORTIR.Name = "BT_SORTIR"
        Me.BT_SORTIR.Size = New System.Drawing.Size(45, 46)
        Me.BT_SORTIR.TabIndex = 43
        Me.BT_SORTIR.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(217, 269)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 31)
        Me.Label2.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(232, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 31)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Relevé de note"
        '
        'NoResultPanel
        '
        Me.NoResultPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.NoResultPanel.Controls.Add(Me.NoResultLabel)
        Me.NoResultPanel.Controls.Add(Me.Label3)
        Me.NoResultPanel.Controls.Add(Me.PictureBox1)
        Me.NoResultPanel.Location = New System.Drawing.Point(0, 151)
        Me.NoResultPanel.Name = "NoResultPanel"
        Me.NoResultPanel.Size = New System.Drawing.Size(680, 489)
        Me.NoResultPanel.TabIndex = 88
        Me.NoResultPanel.Visible = False
        '
        'NoResultLabel
        '
        Me.NoResultLabel.Font = New System.Drawing.Font("Bahnschrift", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoResultLabel.Location = New System.Drawing.Point(19, 328)
        Me.NoResultLabel.Name = "NoResultLabel"
        Me.NoResultLabel.Size = New System.Drawing.Size(649, 98)
        Me.NoResultLabel.TabIndex = 3
        Me.NoResultLabel.Text = "Quelques informations manquent dans l'historique de cet étudiant , veuillez les r" & _
            "emplir et recharger la base de données à nouveau."
        Me.NoResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(643, 52)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Impossible d'afficher le relevé de note"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.missed
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(224, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(231, 268)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 151)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(679, 489)
        Me.CrystalReportViewer1.TabIndex = 49
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ToolPanelWidth = 100
        '
        'AvertToolTip
        '
        Me.AvertToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.AvertToolTip.ToolTipTitle = "Avertissement"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 500
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'ImprTotalLabel
        '
        Me.ImprTotalLabel.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImprTotalLabel.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.alert1
        Me.ImprTotalLabel.Location = New System.Drawing.Point(574, 115)
        Me.ImprTotalLabel.Name = "ImprTotalLabel"
        Me.ImprTotalLabel.Size = New System.Drawing.Size(20, 20)
        Me.ImprTotalLabel.TabIndex = 52
        Me.ImprTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ImprTotalLabel.Visible = False
        '
        'BilanLinkLabel
        '
        Me.BilanLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BilanLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BilanLinkLabel.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.alert1
        Me.BilanLinkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BilanLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.BilanLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BilanLinkLabel.Location = New System.Drawing.Point(443, 18)
        Me.BilanLinkLabel.Name = "BilanLinkLabel"
        Me.BilanLinkLabel.Size = New System.Drawing.Size(199, 22)
        Me.BilanLinkLabel.TabIndex = 44
        Me.BilanLinkLabel.TabStop = True
        Me.BilanLinkLabel.Text = "Voir le bilan detaillé"
        Me.BilanLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BilanLinkLabel.Visible = False
        Me.BilanLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(113, Byte), Integer))
        '
        'RN
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(681, 640)
        Me.Controls.Add(Me.DetailPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 595)
        Me.Name = "RN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.DetailPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.NoResultPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DetailPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BT_LOAD As System.Windows.Forms.Button
    Friend WithEvents CB_ANNEE As System.Windows.Forms.ComboBox
    Friend WithEvents TitlePanel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BT_SORTIR As System.Windows.Forms.Button
    Friend WithEvents AvertToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AdresseLabel As System.Windows.Forms.Label
    Friend WithEvents PromoLabel As System.Windows.Forms.Label
    Friend WithEvents Matricule As System.Windows.Forms.Label
    Friend WithEvents PrenomLabel As System.Windows.Forms.Label
    Friend WithEvents NomLabel As System.Windows.Forms.Label
    Friend WithEvents NoResultPanel As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NoResultLabel As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ImprTotalLabel As System.Windows.Forms.Label
    Friend WithEvents BilanLinkLabel As System.Windows.Forms.LinkLabel
End Class
