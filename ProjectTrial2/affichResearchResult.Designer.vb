<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class affichResearchResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(affichResearchResult))
        Me.LB_INFOAFFICH = New System.Windows.Forms.Label()
        Me.nb_stdRech = New System.Windows.Forms.Label()
        Me.RechLabel = New System.Windows.Forms.Label()
        Me.PN_AFFICHRECH = New System.Windows.Forms.Panel()
        Me.PN_PAGES = New System.Windows.Forms.Panel()
        Me.BT_NEXT = New System.Windows.Forms.Button()
        Me.BT_P4 = New System.Windows.Forms.Button()
        Me.BT_P3 = New System.Windows.Forms.Button()
        Me.BT_P2 = New System.Windows.Forms.Button()
        Me.BT_P1 = New System.Windows.Forms.Button()
        Me.BT_PREV = New System.Windows.Forms.Button()
        Me.LB_noresult = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AffPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.PN_AFFICHRECH.SuspendLayout()
        Me.PN_PAGES.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.AffPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LB_INFOAFFICH
        '
        Me.LB_INFOAFFICH.AutoSize = True
        Me.LB_INFOAFFICH.BackColor = System.Drawing.Color.Transparent
        Me.LB_INFOAFFICH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_INFOAFFICH.ForeColor = System.Drawing.Color.Maroon
        Me.LB_INFOAFFICH.Location = New System.Drawing.Point(41, 72)
        Me.LB_INFOAFFICH.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_INFOAFFICH.Name = "LB_INFOAFFICH"
        Me.LB_INFOAFFICH.Size = New System.Drawing.Size(418, 17)
        Me.LB_INFOAFFICH.TabIndex = 21
        Me.LB_INFOAFFICH.Text = "Vous pouvez selectionner un etudiant puis l'operation associee   "
        '
        'nb_stdRech
        '
        Me.nb_stdRech.AutoSize = True
        Me.nb_stdRech.BackColor = System.Drawing.Color.Transparent
        Me.nb_stdRech.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nb_stdRech.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.nb_stdRech.Location = New System.Drawing.Point(463, 51)
        Me.nb_stdRech.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nb_stdRech.Name = "nb_stdRech"
        Me.nb_stdRech.Size = New System.Drawing.Size(145, 19)
        Me.nb_stdRech.TabIndex = 20
        Me.nb_stdRech.Text = "nombre des resultats"
        '
        'RechLabel
        '
        Me.RechLabel.AutoSize = True
        Me.RechLabel.BackColor = System.Drawing.Color.Transparent
        Me.RechLabel.Font = New System.Drawing.Font("Times New Roman", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RechLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.RechLabel.Location = New System.Drawing.Point(200, 10)
        Me.RechLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RechLabel.Name = "RechLabel"
        Me.RechLabel.Size = New System.Drawing.Size(283, 34)
        Me.RechLabel.TabIndex = 18
        Me.RechLabel.Text = "Resultat de recherche"
        '
        'PN_AFFICHRECH
        '
        Me.PN_AFFICHRECH.BackColor = System.Drawing.Color.Transparent
        Me.PN_AFFICHRECH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PN_AFFICHRECH.Controls.Add(Me.TableLayoutPanel7)
        Me.PN_AFFICHRECH.Controls.Add(Me.TableLayoutPanel6)
        Me.PN_AFFICHRECH.Controls.Add(Me.TableLayoutPanel5)
        Me.PN_AFFICHRECH.Controls.Add(Me.TableLayoutPanel4)
        Me.PN_AFFICHRECH.Controls.Add(Me.TableLayoutPanel3)
        Me.PN_AFFICHRECH.Controls.Add(Me.TableLayoutPanel2)
        Me.PN_AFFICHRECH.Controls.Add(Me.TableLayoutPanel1)
        Me.PN_AFFICHRECH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PN_AFFICHRECH.Location = New System.Drawing.Point(10, 106)
        Me.PN_AFFICHRECH.Margin = New System.Windows.Forms.Padding(0)
        Me.PN_AFFICHRECH.Name = "PN_AFFICHRECH"
        Me.PN_AFFICHRECH.Size = New System.Drawing.Size(655, 471)
        Me.PN_AFFICHRECH.TabIndex = 24
        '
        'PN_PAGES
        '
        Me.PN_PAGES.AutoSize = True
        Me.PN_PAGES.BackColor = System.Drawing.Color.Transparent
        Me.PN_PAGES.Controls.Add(Me.BT_NEXT)
        Me.PN_PAGES.Controls.Add(Me.BT_P4)
        Me.PN_PAGES.Controls.Add(Me.BT_P3)
        Me.PN_PAGES.Controls.Add(Me.BT_P2)
        Me.PN_PAGES.Controls.Add(Me.BT_P1)
        Me.PN_PAGES.Controls.Add(Me.BT_PREV)
        Me.PN_PAGES.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PN_PAGES.Location = New System.Drawing.Point(10, 577)
        Me.PN_PAGES.Margin = New System.Windows.Forms.Padding(0)
        Me.PN_PAGES.Name = "PN_PAGES"
        Me.PN_PAGES.Padding = New System.Windows.Forms.Padding(15, 8, 15, 15)
        Me.PN_PAGES.Size = New System.Drawing.Size(655, 61)
        Me.PN_PAGES.TabIndex = 25
        '
        'BT_NEXT
        '
        Me.BT_NEXT.AutoSize = True
        Me.BT_NEXT.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.next1
        Me.BT_NEXT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_NEXT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_NEXT.FlatAppearance.BorderSize = 0
        Me.BT_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_NEXT.Location = New System.Drawing.Point(211, 10)
        Me.BT_NEXT.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_NEXT.Name = "BT_NEXT"
        Me.BT_NEXT.Size = New System.Drawing.Size(36, 34)
        Me.BT_NEXT.TabIndex = 5
        Me.BT_NEXT.UseVisualStyleBackColor = True
        '
        'BT_P4
        '
        Me.BT_P4.AutoSize = True
        Me.BT_P4.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.page_num
        Me.BT_P4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_P4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_P4.FlatAppearance.BorderSize = 0
        Me.BT_P4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_P4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_P4.ForeColor = System.Drawing.Color.White
        Me.BT_P4.Location = New System.Drawing.Point(178, 12)
        Me.BT_P4.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_P4.Name = "BT_P4"
        Me.BT_P4.Size = New System.Drawing.Size(33, 30)
        Me.BT_P4.TabIndex = 4
        Me.BT_P4.Text = "4"
        Me.BT_P4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BT_P4.UseVisualStyleBackColor = True
        '
        'BT_P3
        '
        Me.BT_P3.AutoSize = True
        Me.BT_P3.BackgroundImage = CType(resources.GetObject("BT_P3.BackgroundImage"), System.Drawing.Image)
        Me.BT_P3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_P3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_P3.FlatAppearance.BorderSize = 0
        Me.BT_P3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_P3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_P3.ForeColor = System.Drawing.Color.White
        Me.BT_P3.Location = New System.Drawing.Point(145, 12)
        Me.BT_P3.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_P3.Name = "BT_P3"
        Me.BT_P3.Size = New System.Drawing.Size(33, 30)
        Me.BT_P3.TabIndex = 3
        Me.BT_P3.Text = "3"
        Me.BT_P3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BT_P3.UseVisualStyleBackColor = True
        '
        'BT_P2
        '
        Me.BT_P2.AutoSize = True
        Me.BT_P2.BackgroundImage = CType(resources.GetObject("BT_P2.BackgroundImage"), System.Drawing.Image)
        Me.BT_P2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_P2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_P2.FlatAppearance.BorderSize = 0
        Me.BT_P2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_P2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_P2.ForeColor = System.Drawing.Color.White
        Me.BT_P2.Location = New System.Drawing.Point(112, 12)
        Me.BT_P2.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_P2.Name = "BT_P2"
        Me.BT_P2.Size = New System.Drawing.Size(33, 30)
        Me.BT_P2.TabIndex = 2
        Me.BT_P2.Text = "2"
        Me.BT_P2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BT_P2.UseVisualStyleBackColor = True
        '
        'BT_P1
        '
        Me.BT_P1.AutoSize = True
        Me.BT_P1.BackgroundImage = CType(resources.GetObject("BT_P1.BackgroundImage"), System.Drawing.Image)
        Me.BT_P1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_P1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_P1.FlatAppearance.BorderSize = 0
        Me.BT_P1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_P1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_P1.ForeColor = System.Drawing.Color.White
        Me.BT_P1.Location = New System.Drawing.Point(79, 12)
        Me.BT_P1.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_P1.Name = "BT_P1"
        Me.BT_P1.Size = New System.Drawing.Size(33, 30)
        Me.BT_P1.TabIndex = 1
        Me.BT_P1.Text = "1"
        Me.BT_P1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BT_P1.UseVisualStyleBackColor = True
        '
        'BT_PREV
        '
        Me.BT_PREV.AutoSize = True
        Me.BT_PREV.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.prev4
        Me.BT_PREV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_PREV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_PREV.FlatAppearance.BorderSize = 0
        Me.BT_PREV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_PREV.Location = New System.Drawing.Point(43, 10)
        Me.BT_PREV.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_PREV.Name = "BT_PREV"
        Me.BT_PREV.Size = New System.Drawing.Size(36, 34)
        Me.BT_PREV.TabIndex = 0
        Me.BT_PREV.UseVisualStyleBackColor = True
        '
        'LB_noresult
        '
        Me.LB_noresult.AutoSize = True
        Me.LB_noresult.BackColor = System.Drawing.Color.Transparent
        Me.LB_noresult.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_noresult.ForeColor = System.Drawing.Color.Maroon
        Me.LB_noresult.Location = New System.Drawing.Point(59, 80)
        Me.LB_noresult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_noresult.Name = "LB_noresult"
        Me.LB_noresult.Size = New System.Drawing.Size(538, 17)
        Me.LB_noresult.TabIndex = 26
        Me.LB_noresult.Text = "Aucun message ne correspond à votre recherche ! ressayer de nouveau "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LB_INFOAFFICH)
        Me.Panel1.Controls.Add(Me.nb_stdRech)
        Me.Panel1.Controls.Add(Me.LB_noresult)
        Me.Panel1.Controls.Add(Me.RechLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(655, 106)
        Me.Panel1.TabIndex = 27
        '
        'AffPanel
        '
        Me.AffPanel.BackColor = System.Drawing.Color.Transparent
        Me.AffPanel.Controls.Add(Me.PN_AFFICHRECH)
        Me.AffPanel.Controls.Add(Me.PN_PAGES)
        Me.AffPanel.Controls.Add(Me.Panel1)
        Me.AffPanel.Location = New System.Drawing.Point(1, 0)
        Me.AffPanel.Name = "AffPanel"
        Me.AffPanel.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.AffPanel.Size = New System.Drawing.Size(675, 638)
        Me.AffPanel.TabIndex = 27
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background_affiche1
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(653, 67)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background_affiche1
        Me.TableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(1, 68)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(653, 67)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background_affiche1
        Me.TableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(1, 135)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(653, 67)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background_affiche1
        Me.TableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TableLayoutPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TableLayoutPanel4.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(1, 202)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(653, 67)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background_affiche1
        Me.TableLayoutPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel5.ColumnCount = 5
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TableLayoutPanel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TableLayoutPanel5.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(1, 269)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(653, 67)
        Me.TableLayoutPanel5.TabIndex = 4
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background_affiche1
        Me.TableLayoutPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel6.ColumnCount = 5
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TableLayoutPanel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TableLayoutPanel6.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(1, 336)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(653, 67)
        Me.TableLayoutPanel6.TabIndex = 5
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background_affiche1
        Me.TableLayoutPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel7.ColumnCount = 5
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TableLayoutPanel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TableLayoutPanel7.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(1, 403)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(653, 67)
        Me.TableLayoutPanel7.TabIndex = 6
        '
        'affichResearchResult
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(678, 640)
        Me.Controls.Add(Me.AffPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "affichResearchResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.PN_AFFICHRECH.ResumeLayout(False)
        Me.PN_PAGES.ResumeLayout(False)
        Me.PN_PAGES.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.AffPanel.ResumeLayout(False)
        Me.AffPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LB_INFOAFFICH As System.Windows.Forms.Label
    Friend WithEvents nb_stdRech As System.Windows.Forms.Label
    Friend WithEvents RechLabel As System.Windows.Forms.Label
    Friend WithEvents PN_AFFICHRECH As System.Windows.Forms.Panel
    Friend WithEvents PN_PAGES As System.Windows.Forms.Panel
    Friend WithEvents BT_NEXT As System.Windows.Forms.Button
    Friend WithEvents BT_P4 As System.Windows.Forms.Button
    Friend WithEvents BT_P3 As System.Windows.Forms.Button
    Friend WithEvents BT_P2 As System.Windows.Forms.Button
    Friend WithEvents BT_P1 As System.Windows.Forms.Button
    Friend WithEvents BT_PREV As System.Windows.Forms.Button
    Friend WithEvents LB_noresult As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AffPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
End Class
