﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatistiquePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatistiquePage))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.StatistiquesPanel = New System.Windows.Forms.Panel()
        Me.ANNEEAlert = New System.Windows.Forms.PictureBox()
        Me.SPECIALITEAlert = New System.Windows.Forms.PictureBox()
        Me.NIVEAUAlert = New System.Windows.Forms.PictureBox()
        Me.GroupeSpliter = New System.Windows.Forms.SplitContainer()
        Me.GROUPELabel = New System.Windows.Forms.Label()
        Me.arrowsList = New System.Windows.Forms.ImageList(Me.components)
        Me.CHB_GROUPE = New System.Windows.Forms.CheckedListBox()
        Me.SectionSpliter = New System.Windows.Forms.SplitContainer()
        Me.SECTIONLabel = New System.Windows.Forms.Label()
        Me.CHB_SECTION = New System.Windows.Forms.CheckedListBox()
        Me.AnneeSpliter = New System.Windows.Forms.SplitContainer()
        Me.ANNEELabel = New System.Windows.Forms.Label()
        Me.CHB_ANNEE = New System.Windows.Forms.CheckedListBox()
        Me.SpecialiteSpliter = New System.Windows.Forms.SplitContainer()
        Me.SPECIALITELabel = New System.Windows.Forms.Label()
        Me.CHB_SPECIALITE = New System.Windows.Forms.CheckedListBox()
        Me.NiveauSpliter = New System.Windows.Forms.SplitContainer()
        Me.NIVEAULabel = New System.Windows.Forms.Label()
        Me.CHB_NIVEAU = New System.Windows.Forms.CheckedListBox()
        Me.CritLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CB_CRITERE = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBo5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChartPanel = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BT_CHARTLOAD = New System.Windows.Forms.Button()
        Me.BT_PREV = New System.Windows.Forms.Button()
        Me.BT_NEXT = New System.Windows.Forms.Button()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.MatiereSpliter = New System.Windows.Forms.SplitContainer()
        Me.MatiereLabel = New System.Windows.Forms.Label()
        Me.CHB_MAT = New System.Windows.Forms.CheckedListBox()
        Me.SexeSpliter = New System.Windows.Forms.SplitContainer()
        Me.SexeLabel = New System.Windows.Forms.Label()
        Me.CHB_SEXE = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SeuilLabel = New System.Windows.Forms.Label()
        Me.TXT_MOYSEUIL = New System.Windows.Forms.TextBox()
        Me.MoyenneAlert = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_CHARTKIND = New System.Windows.Forms.ComboBox()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.NIVEAUAvertTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SPECIALITEAvertTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ANNEEAvertTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MoyenneAvertTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatistiquesPanel.SuspendLayout()
        CType(Me.ANNEEAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPECIALITEAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NIVEAUAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupeSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupeSpliter.Panel1.SuspendLayout()
        Me.GroupeSpliter.Panel2.SuspendLayout()
        Me.GroupeSpliter.SuspendLayout()
        CType(Me.SectionSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SectionSpliter.Panel1.SuspendLayout()
        Me.SectionSpliter.Panel2.SuspendLayout()
        Me.SectionSpliter.SuspendLayout()
        CType(Me.AnneeSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnneeSpliter.Panel1.SuspendLayout()
        Me.AnneeSpliter.Panel2.SuspendLayout()
        Me.AnneeSpliter.SuspendLayout()
        CType(Me.SpecialiteSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SpecialiteSpliter.Panel1.SuspendLayout()
        Me.SpecialiteSpliter.Panel2.SuspendLayout()
        Me.SpecialiteSpliter.SuspendLayout()
        CType(Me.NiveauSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NiveauSpliter.Panel1.SuspendLayout()
        Me.NiveauSpliter.Panel2.SuspendLayout()
        Me.NiveauSpliter.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ChartPanel.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        CType(Me.MatiereSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MatiereSpliter.Panel1.SuspendLayout()
        Me.MatiereSpliter.Panel2.SuspendLayout()
        Me.MatiereSpliter.SuspendLayout()
        CType(Me.SexeSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SexeSpliter.Panel1.SuspendLayout()
        Me.SexeSpliter.Panel2.SuspendLayout()
        Me.SexeSpliter.SuspendLayout()
        CType(Me.MoyenneAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatistiquesPanel
        '
        Me.StatistiquesPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.StatistiquesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StatistiquesPanel.BackColor = System.Drawing.Color.Transparent
        Me.StatistiquesPanel.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.StatistiquesPanel.Controls.Add(Me.ANNEEAlert)
        Me.StatistiquesPanel.Controls.Add(Me.SPECIALITEAlert)
        Me.StatistiquesPanel.Controls.Add(Me.NIVEAUAlert)
        Me.StatistiquesPanel.Controls.Add(Me.GroupeSpliter)
        Me.StatistiquesPanel.Controls.Add(Me.SectionSpliter)
        Me.StatistiquesPanel.Controls.Add(Me.AnneeSpliter)
        Me.StatistiquesPanel.Controls.Add(Me.SpecialiteSpliter)
        Me.StatistiquesPanel.Controls.Add(Me.NiveauSpliter)
        Me.StatistiquesPanel.Controls.Add(Me.CritLabel)
        Me.StatistiquesPanel.Controls.Add(Me.MenuStrip1)
        Me.StatistiquesPanel.Controls.Add(Me.ChartPanel)
        Me.StatistiquesPanel.Controls.Add(Me.TitlePanel)
        Me.StatistiquesPanel.Controls.Add(Me.SeuilLabel)
        Me.StatistiquesPanel.Controls.Add(Me.TXT_MOYSEUIL)
        Me.StatistiquesPanel.Controls.Add(Me.MoyenneAlert)
        Me.StatistiquesPanel.Controls.Add(Me.Label2)
        Me.StatistiquesPanel.Controls.Add(Me.CB_CHARTKIND)
        Me.StatistiquesPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatistiquesPanel.Location = New System.Drawing.Point(0, 0)
        Me.StatistiquesPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.StatistiquesPanel.Name = "StatistiquesPanel"
        Me.StatistiquesPanel.Size = New System.Drawing.Size(678, 640)
        Me.StatistiquesPanel.TabIndex = 12
        '
        'ANNEEAlert
        '
        Me.ANNEEAlert.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.alert1
        Me.ANNEEAlert.Location = New System.Drawing.Point(275, 90)
        Me.ANNEEAlert.Name = "ANNEEAlert"
        Me.ANNEEAlert.Size = New System.Drawing.Size(30, 30)
        Me.ANNEEAlert.TabIndex = 64
        Me.ANNEEAlert.TabStop = False
        Me.ANNEEAlert.Visible = False
        '
        'SPECIALITEAlert
        '
        Me.SPECIALITEAlert.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.alert1
        Me.SPECIALITEAlert.Location = New System.Drawing.Point(140, 90)
        Me.SPECIALITEAlert.Name = "SPECIALITEAlert"
        Me.SPECIALITEAlert.Size = New System.Drawing.Size(30, 30)
        Me.SPECIALITEAlert.TabIndex = 63
        Me.SPECIALITEAlert.TabStop = False
        Me.SPECIALITEAlert.Visible = False
        '
        'NIVEAUAlert
        '
        Me.NIVEAUAlert.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.alert1
        Me.NIVEAUAlert.Location = New System.Drawing.Point(5, 91)
        Me.NIVEAUAlert.Name = "NIVEAUAlert"
        Me.NIVEAUAlert.Size = New System.Drawing.Size(30, 30)
        Me.NIVEAUAlert.TabIndex = 61
        Me.NIVEAUAlert.TabStop = False
        Me.NIVEAUAlert.Visible = False
        '
        'GroupeSpliter
        '
        Me.GroupeSpliter.Location = New System.Drawing.Point(576, 91)
        Me.GroupeSpliter.Name = "GroupeSpliter"
        Me.GroupeSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'GroupeSpliter.Panel1
        '
        Me.GroupeSpliter.Panel1.Controls.Add(Me.GROUPELabel)
        Me.GroupeSpliter.Panel1MinSize = 20
        '
        'GroupeSpliter.Panel2
        '
        Me.GroupeSpliter.Panel2.Controls.Add(Me.CHB_GROUPE)
        Me.GroupeSpliter.Panel2MinSize = 0
        Me.GroupeSpliter.Size = New System.Drawing.Size(98, 54)
        Me.GroupeSpliter.SplitterDistance = 25
        Me.GroupeSpliter.SplitterWidth = 1
        Me.GroupeSpliter.TabIndex = 60
        '
        'GROUPELabel
        '
        Me.GROUPELabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GROUPELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GROUPELabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GROUPELabel.ImageKey = "back.png"
        Me.GROUPELabel.ImageList = Me.arrowsList
        Me.GROUPELabel.Location = New System.Drawing.Point(3, -1)
        Me.GROUPELabel.Name = "GROUPELabel"
        Me.GROUPELabel.Size = New System.Drawing.Size(79, 17)
        Me.GROUPELabel.TabIndex = 50
        Me.GROUPELabel.Text = "Groupe"
        '
        'arrowsList
        '
        Me.arrowsList.ImageStream = CType(resources.GetObject("arrowsList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.arrowsList.TransparentColor = System.Drawing.Color.Transparent
        Me.arrowsList.Images.SetKeyName(0, "back.png")
        Me.arrowsList.Images.SetKeyName(1, "down-arrow.png")
        '
        'CHB_GROUPE
        '
        Me.CHB_GROUPE.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CHB_GROUPE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CHB_GROUPE.CheckOnClick = True
        Me.CHB_GROUPE.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHB_GROUPE.FormattingEnabled = True
        Me.CHB_GROUPE.Location = New System.Drawing.Point(0, -4)
        Me.CHB_GROUPE.Margin = New System.Windows.Forms.Padding(0)
        Me.CHB_GROUPE.Name = "CHB_GROUPE"
        Me.CHB_GROUPE.Size = New System.Drawing.Size(95, 2)
        Me.CHB_GROUPE.Sorted = True
        Me.CHB_GROUPE.TabIndex = 49
        Me.CHB_GROUPE.ThreeDCheckBoxes = True
        '
        'SectionSpliter
        '
        Me.SectionSpliter.Location = New System.Drawing.Point(441, 91)
        Me.SectionSpliter.Name = "SectionSpliter"
        Me.SectionSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SectionSpliter.Panel1
        '
        Me.SectionSpliter.Panel1.Controls.Add(Me.SECTIONLabel)
        Me.SectionSpliter.Panel1MinSize = 20
        '
        'SectionSpliter.Panel2
        '
        Me.SectionSpliter.Panel2.Controls.Add(Me.CHB_SECTION)
        Me.SectionSpliter.Panel2MinSize = 0
        Me.SectionSpliter.Size = New System.Drawing.Size(98, 54)
        Me.SectionSpliter.SplitterDistance = 25
        Me.SectionSpliter.SplitterWidth = 1
        Me.SectionSpliter.TabIndex = 59
        '
        'SECTIONLabel
        '
        Me.SECTIONLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SECTIONLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SECTIONLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SECTIONLabel.ImageKey = "back.png"
        Me.SECTIONLabel.ImageList = Me.arrowsList
        Me.SECTIONLabel.Location = New System.Drawing.Point(3, -1)
        Me.SECTIONLabel.Name = "SECTIONLabel"
        Me.SECTIONLabel.Size = New System.Drawing.Size(82, 17)
        Me.SECTIONLabel.TabIndex = 50
        Me.SECTIONLabel.Text = "Section"
        '
        'CHB_SECTION
        '
        Me.CHB_SECTION.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CHB_SECTION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CHB_SECTION.CheckOnClick = True
        Me.CHB_SECTION.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHB_SECTION.FormattingEnabled = True
        Me.CHB_SECTION.Location = New System.Drawing.Point(0, -4)
        Me.CHB_SECTION.Margin = New System.Windows.Forms.Padding(0)
        Me.CHB_SECTION.Name = "CHB_SECTION"
        Me.CHB_SECTION.Size = New System.Drawing.Size(95, 2)
        Me.CHB_SECTION.Sorted = True
        Me.CHB_SECTION.TabIndex = 49
        Me.CHB_SECTION.ThreeDCheckBoxes = True
        '
        'AnneeSpliter
        '
        Me.AnneeSpliter.Location = New System.Drawing.Point(306, 91)
        Me.AnneeSpliter.Name = "AnneeSpliter"
        Me.AnneeSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'AnneeSpliter.Panel1
        '
        Me.AnneeSpliter.Panel1.Controls.Add(Me.ANNEELabel)
        Me.AnneeSpliter.Panel1MinSize = 20
        '
        'AnneeSpliter.Panel2
        '
        Me.AnneeSpliter.Panel2.Controls.Add(Me.CHB_ANNEE)
        Me.AnneeSpliter.Panel2MinSize = 0
        Me.AnneeSpliter.Size = New System.Drawing.Size(98, 54)
        Me.AnneeSpliter.SplitterDistance = 25
        Me.AnneeSpliter.SplitterWidth = 1
        Me.AnneeSpliter.TabIndex = 58
        '
        'ANNEELabel
        '
        Me.ANNEELabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ANNEELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ANNEELabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ANNEELabel.ImageKey = "back.png"
        Me.ANNEELabel.ImageList = Me.arrowsList
        Me.ANNEELabel.Location = New System.Drawing.Point(3, -1)
        Me.ANNEELabel.Name = "ANNEELabel"
        Me.ANNEELabel.Size = New System.Drawing.Size(72, 17)
        Me.ANNEELabel.TabIndex = 50
        Me.ANNEELabel.Text = "Annee"
        '
        'CHB_ANNEE
        '
        Me.CHB_ANNEE.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CHB_ANNEE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CHB_ANNEE.CheckOnClick = True
        Me.CHB_ANNEE.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHB_ANNEE.FormattingEnabled = True
        Me.CHB_ANNEE.Location = New System.Drawing.Point(0, -4)
        Me.CHB_ANNEE.Margin = New System.Windows.Forms.Padding(0)
        Me.CHB_ANNEE.Name = "CHB_ANNEE"
        Me.CHB_ANNEE.Size = New System.Drawing.Size(95, 2)
        Me.CHB_ANNEE.Sorted = True
        Me.CHB_ANNEE.TabIndex = 49
        Me.CHB_ANNEE.ThreeDCheckBoxes = True
        '
        'SpecialiteSpliter
        '
        Me.SpecialiteSpliter.Location = New System.Drawing.Point(171, 91)
        Me.SpecialiteSpliter.Name = "SpecialiteSpliter"
        Me.SpecialiteSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SpecialiteSpliter.Panel1
        '
        Me.SpecialiteSpliter.Panel1.Controls.Add(Me.SPECIALITELabel)
        Me.SpecialiteSpliter.Panel1MinSize = 20
        '
        'SpecialiteSpliter.Panel2
        '
        Me.SpecialiteSpliter.Panel2.Controls.Add(Me.CHB_SPECIALITE)
        Me.SpecialiteSpliter.Panel2MinSize = 0
        Me.SpecialiteSpliter.Size = New System.Drawing.Size(98, 54)
        Me.SpecialiteSpliter.SplitterDistance = 25
        Me.SpecialiteSpliter.SplitterWidth = 1
        Me.SpecialiteSpliter.TabIndex = 57
        '
        'SPECIALITELabel
        '
        Me.SPECIALITELabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SPECIALITELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SPECIALITELabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SPECIALITELabel.ImageKey = "back.png"
        Me.SPECIALITELabel.ImageList = Me.arrowsList
        Me.SPECIALITELabel.Location = New System.Drawing.Point(3, -1)
        Me.SPECIALITELabel.Name = "SPECIALITELabel"
        Me.SPECIALITELabel.Size = New System.Drawing.Size(95, 17)
        Me.SPECIALITELabel.TabIndex = 50
        Me.SPECIALITELabel.Text = "Specialite"
        '
        'CHB_SPECIALITE
        '
        Me.CHB_SPECIALITE.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CHB_SPECIALITE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CHB_SPECIALITE.CheckOnClick = True
        Me.CHB_SPECIALITE.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHB_SPECIALITE.FormattingEnabled = True
        Me.CHB_SPECIALITE.Location = New System.Drawing.Point(0, -4)
        Me.CHB_SPECIALITE.Margin = New System.Windows.Forms.Padding(0)
        Me.CHB_SPECIALITE.Name = "CHB_SPECIALITE"
        Me.CHB_SPECIALITE.Size = New System.Drawing.Size(95, 2)
        Me.CHB_SPECIALITE.Sorted = True
        Me.CHB_SPECIALITE.TabIndex = 49
        Me.CHB_SPECIALITE.ThreeDCheckBoxes = True
        '
        'NiveauSpliter
        '
        Me.NiveauSpliter.Location = New System.Drawing.Point(36, 91)
        Me.NiveauSpliter.Name = "NiveauSpliter"
        Me.NiveauSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'NiveauSpliter.Panel1
        '
        Me.NiveauSpliter.Panel1.Controls.Add(Me.NIVEAULabel)
        Me.NiveauSpliter.Panel1MinSize = 20
        '
        'NiveauSpliter.Panel2
        '
        Me.NiveauSpliter.Panel2.Controls.Add(Me.CHB_NIVEAU)
        Me.NiveauSpliter.Panel2MinSize = 0
        Me.NiveauSpliter.Size = New System.Drawing.Size(98, 54)
        Me.NiveauSpliter.SplitterDistance = 25
        Me.NiveauSpliter.SplitterWidth = 1
        Me.NiveauSpliter.TabIndex = 56
        '
        'NIVEAULabel
        '
        Me.NIVEAULabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NIVEAULabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NIVEAULabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NIVEAULabel.ImageKey = "back.png"
        Me.NIVEAULabel.ImageList = Me.arrowsList
        Me.NIVEAULabel.Location = New System.Drawing.Point(3, 3)
        Me.NIVEAULabel.Name = "NIVEAULabel"
        Me.NIVEAULabel.Size = New System.Drawing.Size(77, 17)
        Me.NIVEAULabel.TabIndex = 50
        Me.NIVEAULabel.Text = "Niveau"
        '
        'CHB_NIVEAU
        '
        Me.CHB_NIVEAU.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CHB_NIVEAU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CHB_NIVEAU.CheckOnClick = True
        Me.CHB_NIVEAU.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHB_NIVEAU.FormattingEnabled = True
        Me.CHB_NIVEAU.Location = New System.Drawing.Point(0, 0)
        Me.CHB_NIVEAU.Margin = New System.Windows.Forms.Padding(0)
        Me.CHB_NIVEAU.Name = "CHB_NIVEAU"
        Me.CHB_NIVEAU.Size = New System.Drawing.Size(95, 2)
        Me.CHB_NIVEAU.Sorted = True
        Me.CHB_NIVEAU.TabIndex = 49
        Me.CHB_NIVEAU.ThreeDCheckBoxes = True
        '
        'CritLabel
        '
        Me.CritLabel.AutoSize = True
        Me.CritLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CritLabel.Location = New System.Drawing.Point(77, 52)
        Me.CritLabel.Name = "CritLabel"
        Me.CritLabel.Size = New System.Drawing.Size(176, 17)
        Me.CritLabel.TabIndex = 41
        Me.CritLabel.Text = "Critere des statistiques"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CB_CRITERE})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(265, 45)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(305, 26)
        Me.MenuStrip1.TabIndex = 51
        Me.MenuStrip1.Text = "Criteres"
        '
        'CB_CRITERE
        '
        Me.CB_CRITERE.AutoSize = False
        Me.CB_CRITERE.Checked = True
        Me.CB_CRITERE.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CB_CRITERE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CB_CRITERE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripItem1, Me.ToolStripSeparator12, Me.ToolStripItem2, Me.ToolStripItem3, Me.ToolStripItem4, Me.ToolStripSeparator13, Me.ToolStripItem6})
        Me.CB_CRITERE.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.CB_CRITERE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CB_CRITERE.Name = "CB_CRITERE"
        Me.CB_CRITERE.Padding = New System.Windows.Forms.Padding(0)
        Me.CB_CRITERE.Size = New System.Drawing.Size(305, 26)
        Me.CB_CRITERE.Text = "choisir un critère"
        Me.CB_CRITERE.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripItem1
        '
        Me.ToolStripItem1.CheckOnClick = True
        Me.ToolStripItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripComboBo5})
        Me.ToolStripItem1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripItem1.Name = "ToolStripItem1"
        Me.ToolStripItem1.Size = New System.Drawing.Size(304, 24)
        Me.ToolStripItem1.Text = "Nombre des étudiants par"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.CheckOnClick = True
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 24)
        Me.ToolStripMenuItem1.Text = "Décision"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.CheckOnClick = True
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(143, 24)
        Me.ToolStripMenuItem2.Text = "Sexe"
        '
        'ToolStripComboBo5
        '
        Me.ToolStripComboBo5.CheckOnClick = True
        Me.ToolStripComboBo5.Name = "ToolStripComboBo5"
        Me.ToolStripComboBo5.Size = New System.Drawing.Size(143, 24)
        Me.ToolStripComboBo5.Text = "Spécialité"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(301, 6)
        '
        'ToolStripItem2
        '
        Me.ToolStripItem2.CheckOnClick = True
        Me.ToolStripItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8})
        Me.ToolStripItem2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripItem2.Name = "ToolStripItem2"
        Me.ToolStripItem2.Size = New System.Drawing.Size(304, 24)
        Me.ToolStripItem2.Text = "Taux de Réussite par"
        Me.ToolStripItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.CheckOnClick = True
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(130, 24)
        Me.ToolStripMenuItem6.Text = "Matière"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.CheckOnClick = True
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(130, 24)
        Me.ToolStripMenuItem7.Text = "Niveau"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.CheckOnClick = True
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(130, 24)
        Me.ToolStripMenuItem8.Text = "Groupe"
        '
        'ToolStripItem3
        '
        Me.ToolStripItem3.CheckOnClick = True
        Me.ToolStripItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11})
        Me.ToolStripItem3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripItem3.Name = "ToolStripItem3"
        Me.ToolStripItem3.Size = New System.Drawing.Size(304, 24)
        Me.ToolStripItem3.Text = "Taux d'Echec par"
        Me.ToolStripItem3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.CheckOnClick = True
        Me.ToolStripMenuItem9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(130, 24)
        Me.ToolStripMenuItem9.Text = "Matière"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.CheckOnClick = True
        Me.ToolStripMenuItem10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(130, 24)
        Me.ToolStripMenuItem10.Text = "Niveau"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.CheckOnClick = True
        Me.ToolStripMenuItem11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(130, 24)
        Me.ToolStripMenuItem11.Text = "Groupe"
        '
        'ToolStripItem4
        '
        Me.ToolStripItem4.CheckOnClick = True
        Me.ToolStripItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem16, Me.ToolStripMenuItem17})
        Me.ToolStripItem4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripItem4.Name = "ToolStripItem4"
        Me.ToolStripItem4.Size = New System.Drawing.Size(304, 24)
        Me.ToolStripItem4.Text = "Taux d'Abondance et Maladie par"
        Me.ToolStripItem4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.CheckOnClick = True
        Me.ToolStripMenuItem16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(128, 24)
        Me.ToolStripMenuItem16.Text = "Niveau"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.CheckOnClick = True
        Me.ToolStripMenuItem17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(128, 24)
        Me.ToolStripMenuItem17.Text = "Groupe"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(301, 6)
        '
        'ToolStripItem6
        '
        Me.ToolStripItem6.CheckOnClick = True
        Me.ToolStripItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.ToolStripItem6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripItem6.Name = "ToolStripItem6"
        Me.ToolStripItem6.Size = New System.Drawing.Size(304, 24)
        Me.ToolStripItem6.Text = "Moyenne Seuil par"
        Me.ToolStripItem6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.CheckOnClick = True
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(128, 24)
        Me.ToolStripMenuItem3.Text = "Niveau"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.CheckOnClick = True
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(128, 24)
        Me.ToolStripMenuItem4.Text = "Groupe"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.CheckOnClick = True
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(128, 24)
        Me.ToolStripMenuItem5.Text = "Section"
        '
        'ChartPanel
        '
        Me.ChartPanel.Controls.Add(Me.Chart1)
        Me.ChartPanel.Controls.Add(Me.BT_CHARTLOAD)
        Me.ChartPanel.Controls.Add(Me.BT_PREV)
        Me.ChartPanel.Controls.Add(Me.BT_NEXT)
        Me.ChartPanel.Location = New System.Drawing.Point(0, 177)
        Me.ChartPanel.Name = "ChartPanel"
        Me.ChartPanel.Size = New System.Drawing.Size(678, 463)
        Me.ChartPanel.TabIndex = 53
        '
        'Chart1
        '
        Me.Chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Me.Chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX.Title = "x"
        ChartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.Title = "y"
        ChartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic)
        ChartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Silver
        ChartArea1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled
        ChartArea1.Name = "ChartArea4"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.BorderColor = System.Drawing.Color.Silver
        Legend1.BorderWidth = 2
        Legend1.IsEquallySpacedItems = True
        Legend1.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line
        Legend1.Name = "Legend1"
        Legend1.Title = "légende"
        Legend1.TitleBackColor = System.Drawing.Color.Gainsboro
        Legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickLine
        Legend1.TitleSeparatorColor = System.Drawing.Color.DarkGray
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(53, 1)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(0)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))}
        Series1.BorderWidth = 8
        Series1.ChartArea = "ChartArea4"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.YValuesPerPoint = 4
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(572, 411)
        Me.Chart1.SuppressExceptions = True
        Me.Chart1.TabIndex = 12
        Title1.DockedToChartArea = "ChartArea4"
        Title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Title1.IsDockedInsideChartArea = False
        Title1.Name = "Title1"
        Title1.Text = "chart1"
        Me.Chart1.Titles.Add(Title1)
        '
        'BT_CHARTLOAD
        '
        Me.BT_CHARTLOAD.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BT_CHARTLOAD.FlatAppearance.BorderSize = 0
        Me.BT_CHARTLOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CHARTLOAD.Font = New System.Drawing.Font("Cambria", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CHARTLOAD.ForeColor = System.Drawing.Color.White
        Me.BT_CHARTLOAD.Location = New System.Drawing.Point(259, 421)
        Me.BT_CHARTLOAD.Name = "BT_CHARTLOAD"
        Me.BT_CHARTLOAD.Size = New System.Drawing.Size(160, 33)
        Me.BT_CHARTLOAD.TabIndex = 7
        Me.BT_CHARTLOAD.Text = "Afficher"
        Me.BT_CHARTLOAD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_CHARTLOAD.UseVisualStyleBackColor = False
        '
        'BT_PREV
        '
        Me.BT_PREV.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.prev1
        Me.BT_PREV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_PREV.FlatAppearance.BorderSize = 0
        Me.BT_PREV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_PREV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BT_PREV.Location = New System.Drawing.Point(10, 183)
        Me.BT_PREV.Name = "BT_PREV"
        Me.BT_PREV.Size = New System.Drawing.Size(35, 35)
        Me.BT_PREV.TabIndex = 8
        Me.BT_PREV.Text = " "
        Me.BT_PREV.UseVisualStyleBackColor = True
        '
        'BT_NEXT
        '
        Me.BT_NEXT.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources._next
        Me.BT_NEXT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_NEXT.FlatAppearance.BorderSize = 0
        Me.BT_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_NEXT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BT_NEXT.Location = New System.Drawing.Point(633, 183)
        Me.BT_NEXT.Name = "BT_NEXT"
        Me.BT_NEXT.Size = New System.Drawing.Size(35, 35)
        Me.BT_NEXT.TabIndex = 9
        Me.BT_NEXT.Text = " "
        Me.BT_NEXT.UseVisualStyleBackColor = True
        '
        'TitlePanel
        '
        Me.TitlePanel.Controls.Add(Me.MatiereSpliter)
        Me.TitlePanel.Controls.Add(Me.SexeSpliter)
        Me.TitlePanel.Controls.Add(Me.Label1)
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(678, 38)
        Me.TitlePanel.TabIndex = 1
        '
        'MatiereSpliter
        '
        Me.MatiereSpliter.Location = New System.Drawing.Point(103, 3)
        Me.MatiereSpliter.Name = "MatiereSpliter"
        Me.MatiereSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'MatiereSpliter.Panel1
        '
        Me.MatiereSpliter.Panel1.Controls.Add(Me.MatiereLabel)
        Me.MatiereSpliter.Panel1MinSize = 20
        '
        'MatiereSpliter.Panel2
        '
        Me.MatiereSpliter.Panel2.Controls.Add(Me.CHB_MAT)
        Me.MatiereSpliter.Panel2MinSize = 0
        Me.MatiereSpliter.Size = New System.Drawing.Size(12, 54)
        Me.MatiereSpliter.SplitterDistance = 25
        Me.MatiereSpliter.SplitterWidth = 1
        Me.MatiereSpliter.TabIndex = 55
        Me.MatiereSpliter.Visible = False
        '
        'MatiereLabel
        '
        Me.MatiereLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MatiereLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatiereLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MatiereLabel.ImageKey = "back.png"
        Me.MatiereLabel.ImageList = Me.arrowsList
        Me.MatiereLabel.Location = New System.Drawing.Point(3, 3)
        Me.MatiereLabel.Name = "MatiereLabel"
        Me.MatiereLabel.Size = New System.Drawing.Size(83, 17)
        Me.MatiereLabel.TabIndex = 50
        Me.MatiereLabel.Text = "Matiere"
        '
        'CHB_MAT
        '
        Me.CHB_MAT.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CHB_MAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CHB_MAT.CheckOnClick = True
        Me.CHB_MAT.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHB_MAT.FormattingEnabled = True
        Me.CHB_MAT.Location = New System.Drawing.Point(0, 0)
        Me.CHB_MAT.Margin = New System.Windows.Forms.Padding(0)
        Me.CHB_MAT.Name = "CHB_MAT"
        Me.CHB_MAT.Size = New System.Drawing.Size(95, 2)
        Me.CHB_MAT.Sorted = True
        Me.CHB_MAT.TabIndex = 49
        Me.CHB_MAT.ThreeDCheckBoxes = True
        '
        'SexeSpliter
        '
        Me.SexeSpliter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SexeSpliter.IsSplitterFixed = True
        Me.SexeSpliter.Location = New System.Drawing.Point(103, 3)
        Me.SexeSpliter.Name = "SexeSpliter"
        Me.SexeSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SexeSpliter.Panel1
        '
        Me.SexeSpliter.Panel1.Controls.Add(Me.SexeLabel)
        Me.SexeSpliter.Panel1MinSize = 21
        '
        'SexeSpliter.Panel2
        '
        Me.SexeSpliter.Panel2.Controls.Add(Me.CHB_SEXE)
        Me.SexeSpliter.Panel2Collapsed = True
        Me.SexeSpliter.Panel2MinSize = 0
        Me.SexeSpliter.Size = New System.Drawing.Size(12, 50)
        Me.SexeSpliter.SplitterDistance = 25
        Me.SexeSpliter.SplitterWidth = 1
        Me.SexeSpliter.TabIndex = 54
        Me.SexeSpliter.Visible = False
        '
        'SexeLabel
        '
        Me.SexeLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SexeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SexeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SexeLabel.ImageKey = "back.png"
        Me.SexeLabel.ImageList = Me.arrowsList
        Me.SexeLabel.Location = New System.Drawing.Point(3, 3)
        Me.SexeLabel.Name = "SexeLabel"
        Me.SexeLabel.Size = New System.Drawing.Size(69, 17)
        Me.SexeLabel.TabIndex = 50
        Me.SexeLabel.Text = "Sexe"
        '
        'CHB_SEXE
        '
        Me.CHB_SEXE.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CHB_SEXE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CHB_SEXE.CheckOnClick = True
        Me.CHB_SEXE.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHB_SEXE.FormattingEnabled = True
        Me.CHB_SEXE.Location = New System.Drawing.Point(0, 0)
        Me.CHB_SEXE.Margin = New System.Windows.Forms.Padding(0)
        Me.CHB_SEXE.Name = "CHB_SEXE"
        Me.CHB_SEXE.Size = New System.Drawing.Size(95, 2)
        Me.CHB_SEXE.Sorted = True
        Me.CHB_SEXE.TabIndex = 49
        Me.CHB_SEXE.ThreeDCheckBoxes = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(266, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Statistiques"
        '
        'SeuilLabel
        '
        Me.SeuilLabel.AutoSize = True
        Me.SeuilLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeuilLabel.Location = New System.Drawing.Point(371, 125)
        Me.SeuilLabel.Name = "SeuilLabel"
        Me.SeuilLabel.Size = New System.Drawing.Size(135, 17)
        Me.SeuilLabel.TabIndex = 48
        Me.SeuilLabel.Text = "Moyenne de seuil"
        '
        'TXT_MOYSEUIL
        '
        Me.TXT_MOYSEUIL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_MOYSEUIL.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MOYSEUIL.Location = New System.Drawing.Point(366, 146)
        Me.TXT_MOYSEUIL.Name = "TXT_MOYSEUIL"
        Me.TXT_MOYSEUIL.Size = New System.Drawing.Size(159, 19)
        Me.TXT_MOYSEUIL.TabIndex = 39
        Me.TXT_MOYSEUIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MoyenneAlert
        '
        Me.MoyenneAlert.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.alert1
        Me.MoyenneAlert.Location = New System.Drawing.Point(330, 133)
        Me.MoyenneAlert.Name = "MoyenneAlert"
        Me.MoyenneAlert.Size = New System.Drawing.Size(30, 30)
        Me.MoyenneAlert.TabIndex = 68
        Me.MoyenneAlert.TabStop = False
        Me.MoyenneAlert.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 17)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Type du graphe"
        '
        'CB_CHARTKIND
        '
        Me.CB_CHARTKIND.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_CHARTKIND.FormattingEnabled = True
        Me.CB_CHARTKIND.Location = New System.Drawing.Point(112, 145)
        Me.CB_CHARTKIND.Name = "CB_CHARTKIND"
        Me.CB_CHARTKIND.Size = New System.Drawing.Size(157, 26)
        Me.CB_CHARTKIND.TabIndex = 13
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.CustomizeToolStripMenuItem.Text = "&Customize"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.Image = CType(resources.GetObject("NewToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.NewToolStripMenuItem1.Text = "&New"
        '
        'OpenToolStripMenuItem1
        '
        Me.OpenToolStripMenuItem1.Image = CType(resources.GetObject("OpenToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1"
        Me.OpenToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.OpenToolStripMenuItem1.Text = "&Open"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 6)
        '
        'SaveToolStripMenuItem1
        '
        Me.SaveToolStripMenuItem1.Image = CType(resources.GetObject("SaveToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.SaveToolStripMenuItem1.Text = "&Save"
        '
        'SaveAsToolStripMenuItem1
        '
        Me.SaveAsToolStripMenuItem1.Name = "SaveAsToolStripMenuItem1"
        Me.SaveAsToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.SaveAsToolStripMenuItem1.Text = "Save &As"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 6)
        '
        'PrintToolStripMenuItem1
        '
        Me.PrintToolStripMenuItem1.Image = CType(resources.GetObject("PrintToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem1.Name = "PrintToolStripMenuItem1"
        Me.PrintToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.PrintToolStripMenuItem1.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem1
        '
        Me.PrintPreviewToolStripMenuItem1.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem1.Name = "PrintPreviewToolStripMenuItem1"
        Me.PrintPreviewToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.PrintPreviewToolStripMenuItem1.Text = "Print Pre&view"
        '
        'toolStripSeparator8
        '
        Me.toolStripSeparator8.Name = "toolStripSeparator8"
        Me.toolStripSeparator8.Size = New System.Drawing.Size(6, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.ExitToolStripMenuItem1.Text = "E&xit"
        '
        'UndoToolStripMenuItem1
        '
        Me.UndoToolStripMenuItem1.Name = "UndoToolStripMenuItem1"
        Me.UndoToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.UndoToolStripMenuItem1.Text = "&Undo"
        '
        'RedoToolStripMenuItem1
        '
        Me.RedoToolStripMenuItem1.Name = "RedoToolStripMenuItem1"
        Me.RedoToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.RedoToolStripMenuItem1.Text = "&Redo"
        '
        'toolStripSeparator9
        '
        Me.toolStripSeparator9.Name = "toolStripSeparator9"
        Me.toolStripSeparator9.Size = New System.Drawing.Size(6, 6)
        '
        'CutToolStripMenuItem1
        '
        Me.CutToolStripMenuItem1.Image = CType(resources.GetObject("CutToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem1.Name = "CutToolStripMenuItem1"
        Me.CutToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.CutToolStripMenuItem1.Text = "Cu&t"
        '
        'CopyToolStripMenuItem1
        '
        Me.CopyToolStripMenuItem1.Image = CType(resources.GetObject("CopyToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1"
        Me.CopyToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.CopyToolStripMenuItem1.Text = "&Copy"
        '
        'PasteToolStripMenuItem1
        '
        Me.PasteToolStripMenuItem1.Image = CType(resources.GetObject("PasteToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1"
        Me.PasteToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.PasteToolStripMenuItem1.Text = "&Paste"
        '
        'toolStripSeparator10
        '
        Me.toolStripSeparator10.Name = "toolStripSeparator10"
        Me.toolStripSeparator10.Size = New System.Drawing.Size(6, 6)
        '
        'SelectAllToolStripMenuItem1
        '
        Me.SelectAllToolStripMenuItem1.Name = "SelectAllToolStripMenuItem1"
        Me.SelectAllToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.SelectAllToolStripMenuItem1.Text = "Select &All"
        '
        'CustomizeToolStripMenuItem1
        '
        Me.CustomizeToolStripMenuItem1.Name = "CustomizeToolStripMenuItem1"
        Me.CustomizeToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.CustomizeToolStripMenuItem1.Text = "&Customize"
        '
        'OptionsToolStripMenuItem1
        '
        Me.OptionsToolStripMenuItem1.Name = "OptionsToolStripMenuItem1"
        Me.OptionsToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.OptionsToolStripMenuItem1.Text = "&Options"
        '
        'ContentsToolStripMenuItem1
        '
        Me.ContentsToolStripMenuItem1.Name = "ContentsToolStripMenuItem1"
        Me.ContentsToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.ContentsToolStripMenuItem1.Text = "&Contents"
        '
        'IndexToolStripMenuItem1
        '
        Me.IndexToolStripMenuItem1.Name = "IndexToolStripMenuItem1"
        Me.IndexToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.IndexToolStripMenuItem1.Text = "&Index"
        '
        'SearchToolStripMenuItem1
        '
        Me.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1"
        Me.SearchToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.SearchToolStripMenuItem1.Text = "&Search"
        '
        'toolStripSeparator11
        '
        Me.toolStripSeparator11.Name = "toolStripSeparator11"
        Me.toolStripSeparator11.Size = New System.Drawing.Size(6, 6)
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        Me.AboutToolStripMenuItem1.Text = "&About..."
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'NIVEAUAvertTip
        '
        '
        'StatistiquePage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(678, 640)
        Me.Controls.Add(Me.StatistiquesPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 595)
        Me.Name = "StatistiquePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.StatistiquesPanel.ResumeLayout(False)
        Me.StatistiquesPanel.PerformLayout()
        CType(Me.ANNEEAlert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPECIALITEAlert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NIVEAUAlert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupeSpliter.Panel1.ResumeLayout(False)
        Me.GroupeSpliter.Panel2.ResumeLayout(False)
        CType(Me.GroupeSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupeSpliter.ResumeLayout(False)
        Me.SectionSpliter.Panel1.ResumeLayout(False)
        Me.SectionSpliter.Panel2.ResumeLayout(False)
        CType(Me.SectionSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SectionSpliter.ResumeLayout(False)
        Me.AnneeSpliter.Panel1.ResumeLayout(False)
        Me.AnneeSpliter.Panel2.ResumeLayout(False)
        CType(Me.AnneeSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnneeSpliter.ResumeLayout(False)
        Me.SpecialiteSpliter.Panel1.ResumeLayout(False)
        Me.SpecialiteSpliter.Panel2.ResumeLayout(False)
        CType(Me.SpecialiteSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SpecialiteSpliter.ResumeLayout(False)
        Me.NiveauSpliter.Panel1.ResumeLayout(False)
        Me.NiveauSpliter.Panel2.ResumeLayout(False)
        CType(Me.NiveauSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NiveauSpliter.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ChartPanel.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.MatiereSpliter.Panel1.ResumeLayout(False)
        Me.MatiereSpliter.Panel2.ResumeLayout(False)
        CType(Me.MatiereSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MatiereSpliter.ResumeLayout(False)
        Me.SexeSpliter.Panel1.ResumeLayout(False)
        Me.SexeSpliter.Panel2.ResumeLayout(False)
        CType(Me.SexeSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SexeSpliter.ResumeLayout(False)
        CType(Me.MoyenneAlert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StatistiquesPanel As System.Windows.Forms.Panel
    Friend WithEvents BT_CHARTLOAD As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BT_NEXT As System.Windows.Forms.Button
    Friend WithEvents BT_PREV As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CB_CHARTKIND As System.Windows.Forms.ComboBox
    Friend WithEvents SexeLabel As System.Windows.Forms.Label
    Friend WithEvents CHB_SEXE As System.Windows.Forms.CheckedListBox
    Friend WithEvents SeuilLabel As System.Windows.Forms.Label
    Friend WithEvents CritLabel As System.Windows.Forms.Label
    Friend WithEvents TXT_MOYSEUIL As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CB_CRITERE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBo5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SexeSpliter As System.Windows.Forms.SplitContainer
    Friend WithEvents arrowsList As System.Windows.Forms.ImageList
    Friend WithEvents MatiereSpliter As System.Windows.Forms.SplitContainer
    Friend WithEvents MatiereLabel As System.Windows.Forms.Label
    Friend WithEvents CHB_MAT As System.Windows.Forms.CheckedListBox
    Friend WithEvents NiveauSpliter As System.Windows.Forms.SplitContainer
    Friend WithEvents NIVEAULabel As System.Windows.Forms.Label
    Friend WithEvents CHB_NIVEAU As System.Windows.Forms.CheckedListBox
    Friend WithEvents ChartPanel As System.Windows.Forms.Panel
    Friend WithEvents TitlePanel As System.Windows.Forms.Panel
    Friend WithEvents SpecialiteSpliter As System.Windows.Forms.SplitContainer
    Friend WithEvents SPECIALITELabel As System.Windows.Forms.Label
    Friend WithEvents CHB_SPECIALITE As System.Windows.Forms.CheckedListBox
    Friend WithEvents AnneeSpliter As System.Windows.Forms.SplitContainer
    Friend WithEvents ANNEELabel As System.Windows.Forms.Label
    Friend WithEvents CHB_ANNEE As System.Windows.Forms.CheckedListBox
    Friend WithEvents SectionSpliter As System.Windows.Forms.SplitContainer
    Friend WithEvents SECTIONLabel As System.Windows.Forms.Label
    Friend WithEvents CHB_SECTION As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupeSpliter As System.Windows.Forms.SplitContainer
    Friend WithEvents GROUPELabel As System.Windows.Forms.Label
    Friend WithEvents CHB_GROUPE As System.Windows.Forms.CheckedListBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents MoyenneAlert As System.Windows.Forms.PictureBox
    Friend WithEvents ANNEEAlert As System.Windows.Forms.PictureBox
    Friend WithEvents SPECIALITEAlert As System.Windows.Forms.PictureBox
    Friend WithEvents NIVEAUAlert As System.Windows.Forms.PictureBox
    Friend WithEvents NIVEAUAvertTip As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SPECIALITEAvertTip As System.Windows.Forms.ToolTip
    Friend WithEvents ANNEEAvertTip As System.Windows.Forms.ToolTip
    Friend WithEvents MoyenneAvertTip As System.Windows.Forms.ToolTip
End Class
