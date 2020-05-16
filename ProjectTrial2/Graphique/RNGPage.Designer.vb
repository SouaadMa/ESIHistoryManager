<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RNGPage
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
        Me.DetailPanel = New System.Windows.Forms.Panel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SortirButton = New System.Windows.Forms.Button()
        Me.ImprTotalLabel = New System.Windows.Forms.Label()
        Me.AvertToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.AdresseLabel = New System.Windows.Forms.Label()
        Me.PromoLabel = New System.Windows.Forms.Label()
        Me.Matricule = New System.Windows.Forms.Label()
        Me.PrenomLabel = New System.Windows.Forms.Label()
        Me.NomLabel = New System.Windows.Forms.Label()
        Me.DetailPanel.SuspendLayout()
        Me.TitlePanel.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'DetailPanel
        '
        Me.DetailPanel.BackColor = System.Drawing.Color.Transparent
        Me.DetailPanel.Controls.Add(Me.TableLayoutPanel8)
        Me.DetailPanel.Controls.Add(Me.CrystalReportViewer1)
        Me.DetailPanel.Controls.Add(Me.TitlePanel)
        Me.DetailPanel.Location = New System.Drawing.Point(0, 0)
        Me.DetailPanel.Name = "DetailPanel"
        Me.DetailPanel.Size = New System.Drawing.Size(678, 640)
        Me.DetailPanel.TabIndex = 88
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 111)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(678, 529)
        Me.CrystalReportViewer1.TabIndex = 51
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ToolPanelWidth = 100
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.Transparent
        Me.TitlePanel.Controls.Add(Me.ImprTotalLabel)
        Me.TitlePanel.Controls.Add(Me.SortirButton)
        Me.TitlePanel.Controls.Add(Me.Label1)
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(678, 61)
        Me.TitlePanel.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(205, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 31)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Relevé de note globale"
        '
        'SortirButton
        '
        Me.SortirButton.BackColor = System.Drawing.Color.Transparent
        Me.SortirButton.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.arrows
        Me.SortirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SortirButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SortirButton.FlatAppearance.BorderSize = 0
        Me.SortirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SortirButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortirButton.ForeColor = System.Drawing.Color.White
        Me.SortirButton.Location = New System.Drawing.Point(42, 7)
        Me.SortirButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 100)
        Me.SortirButton.Name = "SortirButton"
        Me.SortirButton.Size = New System.Drawing.Size(45, 46)
        Me.SortirButton.TabIndex = 44
        Me.SortirButton.UseVisualStyleBackColor = False
        '
        'ImprTotalLabel
        '
        Me.ImprTotalLabel.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImprTotalLabel.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.alert1
        Me.ImprTotalLabel.Location = New System.Drawing.Point(505, 14)
        Me.ImprTotalLabel.Name = "ImprTotalLabel"
        Me.ImprTotalLabel.Size = New System.Drawing.Size(33, 34)
        Me.ImprTotalLabel.TabIndex = 53
        Me.ImprTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ImprTotalLabel.Visible = False
        '
        'AvertToolTip
        '
        Me.AvertToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.AvertToolTip.ToolTipTitle = "Avertissement"
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
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(5, 61)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(661, 44)
        Me.TableLayoutPanel8.TabIndex = 54
        '
        'AdresseLabel
        '
        Me.AdresseLabel.AutoEllipsis = True
        Me.AdresseLabel.AutoSize = True
        Me.AdresseLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdresseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.AdresseLabel.Location = New System.Drawing.Point(282, 2)
        Me.AdresseLabel.Name = "AdresseLabel"
        Me.AdresseLabel.Size = New System.Drawing.Size(305, 40)
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
        Me.PromoLabel.Size = New System.Drawing.Size(63, 40)
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
        Me.Matricule.Size = New System.Drawing.Size(73, 40)
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
        Me.PrenomLabel.Size = New System.Drawing.Size(93, 40)
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
        Me.NomLabel.Size = New System.Drawing.Size(93, 40)
        Me.NomLabel.TabIndex = 0
        Me.NomLabel.Text = "Nom"
        Me.NomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RNGPage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(678, 640)
        Me.Controls.Add(Me.DetailPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 595)
        Me.Name = "RNGPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.DetailPanel.ResumeLayout(False)
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DetailPanel As System.Windows.Forms.Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TitlePanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SortirButton As System.Windows.Forms.Button
    Friend WithEvents ImprTotalLabel As System.Windows.Forms.Label
    Friend WithEvents AvertToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AdresseLabel As System.Windows.Forms.Label
    Friend WithEvents PromoLabel As System.Windows.Forms.Label
    Friend WithEvents Matricule As System.Windows.Forms.Label
    Friend WithEvents PrenomLabel As System.Windows.Forms.Label
    Friend WithEvents NomLabel As System.Windows.Forms.Label
End Class
