<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.SideBar = New System.Windows.Forms.TableLayoutPanel()
        Me.BT_CLASS = New System.Windows.Forms.Button()
        Me.ClassIconsList = New System.Windows.Forms.ImageList(Me.components)
        Me.BT_STAT = New System.Windows.Forms.Button()
        Me.StaticIconsList = New System.Windows.Forms.ImageList(Me.components)
        Me.BT_RECH = New System.Windows.Forms.Button()
        Me.SearchIconsList = New System.Windows.Forms.ImageList(Me.components)
        Me.BT_PV = New System.Windows.Forms.Button()
        Me.PVIconsList = New System.Windows.Forms.ImageList(Me.components)
        Me.LogoPicture = New System.Windows.Forms.PictureBox()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.ProfilePane = New System.Windows.Forms.Panel()
        Me.BT_modif_mdp = New System.Windows.Forms.Button()
        Me.BT_LOGOUT = New System.Windows.Forms.Button()
        Me.mode_photo = New System.Windows.Forms.PictureBox()
        Me.LBL_MODE = New System.Windows.Forms.Label()
        Me.NavBar = New System.Windows.Forms.TableLayoutPanel()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.DetailButton = New System.Windows.Forms.Button()
        Me.RNGButton = New System.Windows.Forms.Button()
        Me.ModifButton = New System.Windows.Forms.Button()
        Me.RNButton = New System.Windows.Forms.Button()
        Me.MainContainer1 = New System.Windows.Forms.Panel()
        Me.MainContainer2 = New System.Windows.Forms.Panel()
        Me.ProgressPanel = New System.Windows.Forms.Panel()
        Me.ProgressLabel = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CancelBackgroundButton = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.logo_bleu = New System.Windows.Forms.Panel()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.SideBar.SuspendLayout()
        CType(Me.LogoPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProfilePane.SuspendLayout()
        CType(Me.mode_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBar.SuspendLayout()
        Me.ProgressPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.logo_bleu.SuspendLayout()
        Me.SuspendLayout()
        '
        'SideBar
        '
        Me.SideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.SideBar.ColumnCount = 1
        Me.SideBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.SideBar.Controls.Add(Me.BT_CLASS, 0, 1)
        Me.SideBar.Controls.Add(Me.BT_STAT, 0, 2)
        Me.SideBar.Controls.Add(Me.BT_RECH, 0, 3)
        Me.SideBar.Controls.Add(Me.BT_PV, 0, 4)
        Me.SideBar.Location = New System.Drawing.Point(0, 117)
        Me.SideBar.Margin = New System.Windows.Forms.Padding(0)
        Me.SideBar.Name = "SideBar"
        Me.SideBar.RowCount = 8
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176.0!))
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.Size = New System.Drawing.Size(185, 621)
        Me.SideBar.TabIndex = 8
        Me.SideBar.TabStop = True
        '
        'BT_CLASS
        '
        Me.BT_CLASS.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BT_CLASS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_CLASS.Dock = System.Windows.Forms.DockStyle.Left
        Me.BT_CLASS.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BT_CLASS.FlatAppearance.BorderSize = 0
        Me.BT_CLASS.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_CLASS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_CLASS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CLASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CLASS.ForeColor = System.Drawing.SystemColors.Window
        Me.BT_CLASS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_CLASS.ImageIndex = 0
        Me.BT_CLASS.ImageList = Me.ClassIconsList
        Me.BT_CLASS.Location = New System.Drawing.Point(2, 82)
        Me.BT_CLASS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BT_CLASS.MinimumSize = New System.Drawing.Size(45, 49)
        Me.BT_CLASS.Name = "BT_CLASS"
        Me.BT_CLASS.Size = New System.Drawing.Size(179, 70)
        Me.BT_CLASS.TabIndex = 2
        Me.BT_CLASS.Text = "Classement"
        Me.BT_CLASS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_CLASS.UseVisualStyleBackColor = False
        '
        'ClassIconsList
        '
        Me.ClassIconsList.ImageStream = CType(resources.GetObject("ClassIconsList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ClassIconsList.TransparentColor = System.Drawing.Color.Transparent
        Me.ClassIconsList.Images.SetKeyName(0, "line_chart_bj.png")
        Me.ClassIconsList.Images.SetKeyName(1, "line_chart.png")
        '
        'BT_STAT
        '
        Me.BT_STAT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_STAT.Dock = System.Windows.Forms.DockStyle.Left
        Me.BT_STAT.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BT_STAT.FlatAppearance.BorderSize = 0
        Me.BT_STAT.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_STAT.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_STAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_STAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_STAT.ForeColor = System.Drawing.SystemColors.Window
        Me.BT_STAT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_STAT.ImageKey = "diagram.png"
        Me.BT_STAT.ImageList = Me.StaticIconsList
        Me.BT_STAT.Location = New System.Drawing.Point(2, 156)
        Me.BT_STAT.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BT_STAT.MinimumSize = New System.Drawing.Size(45, 49)
        Me.BT_STAT.Name = "BT_STAT"
        Me.BT_STAT.Size = New System.Drawing.Size(179, 64)
        Me.BT_STAT.TabIndex = 3
        Me.BT_STAT.Text = "Statistiques"
        Me.BT_STAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_STAT.UseVisualStyleBackColor = True
        '
        'StaticIconsList
        '
        Me.StaticIconsList.ImageStream = CType(resources.GetObject("StaticIconsList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.StaticIconsList.TransparentColor = System.Drawing.Color.Transparent
        Me.StaticIconsList.Images.SetKeyName(0, "diagram.png")
        Me.StaticIconsList.Images.SetKeyName(1, "diagram_bl.png")
        '
        'BT_RECH
        '
        Me.BT_RECH.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BT_RECH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_RECH.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BT_RECH.FlatAppearance.BorderSize = 0
        Me.BT_RECH.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_RECH.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_RECH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_RECH.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_RECH.ForeColor = System.Drawing.SystemColors.Window
        Me.BT_RECH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_RECH.ImageKey = "search.png"
        Me.BT_RECH.ImageList = Me.SearchIconsList
        Me.BT_RECH.Location = New System.Drawing.Point(2, 224)
        Me.BT_RECH.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BT_RECH.MinimumSize = New System.Drawing.Size(45, 49)
        Me.BT_RECH.Name = "BT_RECH"
        Me.BT_RECH.Size = New System.Drawing.Size(179, 67)
        Me.BT_RECH.TabIndex = 4
        Me.BT_RECH.Text = "Recherche"
        Me.BT_RECH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_RECH.UseVisualStyleBackColor = False
        '
        'SearchIconsList
        '
        Me.SearchIconsList.ImageStream = CType(resources.GetObject("SearchIconsList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SearchIconsList.TransparentColor = System.Drawing.Color.Transparent
        Me.SearchIconsList.Images.SetKeyName(0, "search.png")
        Me.SearchIconsList.Images.SetKeyName(1, "search_blue.png")
        '
        'BT_PV
        '
        Me.BT_PV.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BT_PV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_PV.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BT_PV.FlatAppearance.BorderSize = 0
        Me.BT_PV.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_PV.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_PV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_PV.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_PV.ForeColor = System.Drawing.SystemColors.Window
        Me.BT_PV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_PV.ImageKey = "gantt_chart_bj.png"
        Me.BT_PV.ImageList = Me.PVIconsList
        Me.BT_PV.Location = New System.Drawing.Point(2, 295)
        Me.BT_PV.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BT_PV.MinimumSize = New System.Drawing.Size(45, 49)
        Me.BT_PV.Name = "BT_PV"
        Me.BT_PV.Size = New System.Drawing.Size(179, 64)
        Me.BT_PV.TabIndex = 5
        Me.BT_PV.Text = "           PV"
        Me.BT_PV.UseVisualStyleBackColor = False
        '
        'PVIconsList
        '
        Me.PVIconsList.ImageStream = CType(resources.GetObject("PVIconsList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.PVIconsList.TransparentColor = System.Drawing.Color.Transparent
        Me.PVIconsList.Images.SetKeyName(0, "gantt_chart_bj.png")
        Me.PVIconsList.Images.SetKeyName(1, "chart_blue.png")
        '
        'LogoPicture
        '
        Me.LogoPicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.LogoPicture.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.logo_white
        Me.LogoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LogoPicture.Location = New System.Drawing.Point(0, 569)
        Me.LogoPicture.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.LogoPicture.Name = "LogoPicture"
        Me.LogoPicture.Size = New System.Drawing.Size(185, 90)
        Me.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPicture.TabIndex = 51
        Me.LogoPicture.TabStop = False
        Me.LogoPicture.Visible = False
        '
        'MenuButton
        '
        Me.MenuButton.AutoSize = True
        Me.MenuButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.MenuButton.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.hamburger
        Me.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuButton.CausesValidation = False
        Me.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.MenuButton.FlatAppearance.BorderSize = 0
        Me.MenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuButton.ForeColor = System.Drawing.Color.Transparent
        Me.MenuButton.Location = New System.Drawing.Point(0, 0)
        Me.MenuButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MenuButton.MinimumSize = New System.Drawing.Size(45, 49)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(55, 117)
        Me.MenuButton.TabIndex = 1
        Me.MenuButton.TabStop = False
        Me.MenuButton.UseVisualStyleBackColor = False
        '
        'ProfilePane
        '
        Me.ProfilePane.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.ProfilePane.Controls.Add(Me.BT_modif_mdp)
        Me.ProfilePane.Controls.Add(Me.BT_LOGOUT)
        Me.ProfilePane.Controls.Add(Me.mode_photo)
        Me.ProfilePane.Controls.Add(Me.LBL_MODE)
        Me.ProfilePane.Dock = System.Windows.Forms.DockStyle.Right
        Me.ProfilePane.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfilePane.Location = New System.Drawing.Point(867, 0)
        Me.ProfilePane.Margin = New System.Windows.Forms.Padding(0)
        Me.ProfilePane.Name = "ProfilePane"
        Me.ProfilePane.Size = New System.Drawing.Size(151, 699)
        Me.ProfilePane.TabIndex = 1
        '
        'BT_modif_mdp
        '
        Me.BT_modif_mdp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_modif_mdp.AutoSize = True
        Me.BT_modif_mdp.BackColor = System.Drawing.Color.Transparent
        Me.BT_modif_mdp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_modif_mdp.Enabled = False
        Me.BT_modif_mdp.FlatAppearance.BorderSize = 0
        Me.BT_modif_mdp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BT_modif_mdp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BT_modif_mdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_modif_mdp.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.gear
        Me.BT_modif_mdp.Location = New System.Drawing.Point(118, 189)
        Me.BT_modif_mdp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BT_modif_mdp.Name = "BT_modif_mdp"
        Me.BT_modif_mdp.Size = New System.Drawing.Size(30, 30)
        Me.BT_modif_mdp.TabIndex = 0
        Me.BT_modif_mdp.UseVisualStyleBackColor = False
        Me.BT_modif_mdp.Visible = False
        '
        'BT_LOGOUT
        '
        Me.BT_LOGOUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_LOGOUT.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.BT_LOGOUT.FlatAppearance.BorderSize = 0
        Me.BT_LOGOUT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BT_LOGOUT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BT_LOGOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LOGOUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_LOGOUT.ForeColor = System.Drawing.Color.White
        Me.BT_LOGOUT.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.exit_picture
        Me.BT_LOGOUT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_LOGOUT.Location = New System.Drawing.Point(14, 539)
        Me.BT_LOGOUT.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BT_LOGOUT.Name = "BT_LOGOUT"
        Me.BT_LOGOUT.Size = New System.Drawing.Size(122, 101)
        Me.BT_LOGOUT.TabIndex = 3
        Me.BT_LOGOUT.Text = "Deconnecter"
        Me.BT_LOGOUT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_LOGOUT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BT_LOGOUT.UseVisualStyleBackColor = True
        '
        'mode_photo
        '
        Me.mode_photo.BackColor = System.Drawing.Color.Transparent
        Me.mode_photo.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.agent_mode
        Me.mode_photo.Location = New System.Drawing.Point(15, 77)
        Me.mode_photo.Name = "mode_photo"
        Me.mode_photo.Size = New System.Drawing.Size(120, 138)
        Me.mode_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mode_photo.TabIndex = 4
        Me.mode_photo.TabStop = False
        '
        'LBL_MODE
        '
        Me.LBL_MODE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_MODE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_MODE.ForeColor = System.Drawing.Color.White
        Me.LBL_MODE.Location = New System.Drawing.Point(1, 217)
        Me.LBL_MODE.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_MODE.Name = "LBL_MODE"
        Me.LBL_MODE.Size = New System.Drawing.Size(149, 79)
        Me.LBL_MODE.TabIndex = 5
        Me.LBL_MODE.Text = "Employée"
        Me.LBL_MODE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NavBar
        '
        Me.NavBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.NavBar.BackColor = System.Drawing.Color.Transparent
        Me.NavBar.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.Path
        Me.NavBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NavBar.ColumnCount = 8
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.NavBar.Controls.Add(Me.PrintButton, 3, 0)
        Me.NavBar.Controls.Add(Me.DetailButton, 2, 0)
        Me.NavBar.Controls.Add(Me.RNGButton, 1, 0)
        Me.NavBar.Controls.Add(Me.ModifButton, 4, 0)
        Me.NavBar.Controls.Add(Me.RNButton, 0, 0)
        Me.NavBar.Location = New System.Drawing.Point(186, 643)
        Me.NavBar.Margin = New System.Windows.Forms.Padding(0)
        Me.NavBar.MaximumSize = New System.Drawing.Size(1000, 60)
        Me.NavBar.Name = "NavBar"
        Me.NavBar.RowCount = 1
        Me.NavBar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.NavBar.Size = New System.Drawing.Size(680, 55)
        Me.NavBar.TabIndex = 2
        '
        'PrintButton
        '
        Me.PrintButton.AutoSize = True
        Me.PrintButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PrintButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintButton.Enabled = False
        Me.PrintButton.FlatAppearance.BorderSize = 0
        Me.PrintButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.PrintButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintButton.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.attestation
        Me.PrintButton.Location = New System.Drawing.Point(266, 2)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PrintButton.MinimumSize = New System.Drawing.Size(45, 49)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(77, 51)
        Me.PrintButton.TabIndex = 10
        Me.PrintButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'DetailButton
        '
        Me.DetailButton.AutoSize = True
        Me.DetailButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DetailButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailButton.Enabled = False
        Me.DetailButton.FlatAppearance.BorderSize = 0
        Me.DetailButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.DetailButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.DetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DetailButton.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.details
        Me.DetailButton.Location = New System.Drawing.Point(185, 2)
        Me.DetailButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DetailButton.MinimumSize = New System.Drawing.Size(45, 49)
        Me.DetailButton.Name = "DetailButton"
        Me.DetailButton.Size = New System.Drawing.Size(77, 51)
        Me.DetailButton.TabIndex = 6
        Me.DetailButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.DetailButton.UseVisualStyleBackColor = True
        '
        'RNGButton
        '
        Me.RNGButton.AutoSize = True
        Me.RNGButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RNGButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RNGButton.Enabled = False
        Me.RNGButton.FlatAppearance.BorderSize = 0
        Me.RNGButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.RNGButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.RNGButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RNGButton.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.rng
        Me.RNGButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RNGButton.Location = New System.Drawing.Point(104, 2)
        Me.RNGButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RNGButton.MinimumSize = New System.Drawing.Size(45, 49)
        Me.RNGButton.Name = "RNGButton"
        Me.RNGButton.Size = New System.Drawing.Size(77, 51)
        Me.RNGButton.TabIndex = 5
        Me.RNGButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RNGButton.UseVisualStyleBackColor = True
        '
        'ModifButton
        '
        Me.ModifButton.AutoSize = True
        Me.ModifButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ModifButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModifButton.Enabled = False
        Me.ModifButton.FlatAppearance.BorderSize = 0
        Me.ModifButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ModifButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ModifButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModifButton.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.modifier
        Me.ModifButton.Location = New System.Drawing.Point(347, 2)
        Me.ModifButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ModifButton.MinimumSize = New System.Drawing.Size(45, 49)
        Me.ModifButton.Name = "ModifButton"
        Me.ModifButton.Size = New System.Drawing.Size(77, 51)
        Me.ModifButton.TabIndex = 8
        Me.ModifButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ModifButton.UseVisualStyleBackColor = True
        Me.ModifButton.Visible = False
        '
        'RNButton
        '
        Me.RNButton.AutoSize = True
        Me.RNButton.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.RN
        Me.RNButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RNButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RNButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.RNButton.Enabled = False
        Me.RNButton.FlatAppearance.BorderSize = 0
        Me.RNButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.RNButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.RNButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RNButton.Location = New System.Drawing.Point(37, 2)
        Me.RNButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RNButton.MinimumSize = New System.Drawing.Size(45, 49)
        Me.RNButton.Name = "RNButton"
        Me.RNButton.Size = New System.Drawing.Size(63, 51)
        Me.RNButton.TabIndex = 3
        Me.RNButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RNButton.UseVisualStyleBackColor = True
        '
        'MainContainer1
        '
        Me.MainContainer1.BackColor = System.Drawing.Color.Transparent
        Me.MainContainer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainContainer1.Location = New System.Drawing.Point(185, 0)
        Me.MainContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.MainContainer1.Name = "MainContainer1"
        Me.MainContainer1.Size = New System.Drawing.Size(682, 640)
        Me.MainContainer1.TabIndex = 10
        Me.MainContainer1.Visible = False
        '
        'MainContainer2
        '
        Me.MainContainer2.BackColor = System.Drawing.Color.Transparent
        Me.MainContainer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainContainer2.Location = New System.Drawing.Point(185, 0)
        Me.MainContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.MainContainer2.Name = "MainContainer2"
        Me.MainContainer2.Size = New System.Drawing.Size(682, 640)
        Me.MainContainer2.TabIndex = 30
        '
        'ProgressPanel
        '
        Me.ProgressPanel.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel.Controls.Add(Me.ProgressLabel)
        Me.ProgressPanel.Controls.Add(Me.PictureBox2)
        Me.ProgressPanel.Controls.Add(Me.PictureBox1)
        Me.ProgressPanel.Controls.Add(Me.CancelBackgroundButton)
        Me.ProgressPanel.Location = New System.Drawing.Point(185, 0)
        Me.ProgressPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ProgressPanel.Name = "ProgressPanel"
        Me.ProgressPanel.Size = New System.Drawing.Size(682, 640)
        Me.ProgressPanel.TabIndex = 50
        Me.ProgressPanel.Visible = False
        '
        'ProgressLabel
        '
        Me.ProgressLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProgressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressLabel.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.layeredAssetWhite
        Me.ProgressLabel.Location = New System.Drawing.Point(290, 322)
        Me.ProgressLabel.Name = "ProgressLabel"
        Me.ProgressLabel.Size = New System.Drawing.Size(74, 26)
        Me.ProgressLabel.TabIndex = 31
        Me.ProgressLabel.Text = "0%"
        Me.ProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.logo_coloree
        Me.PictureBox2.InitialImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.Spinner
        Me.PictureBox2.Location = New System.Drawing.Point(226, 215)
        Me.PictureBox2.MaximumSize = New System.Drawing.Size(226, 206)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(226, 206)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.logo_white1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(224, 215)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(226, 206)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 206)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'CancelBackgroundButton
        '
        Me.CancelBackgroundButton.Enabled = False
        Me.CancelBackgroundButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBackgroundButton.Location = New System.Drawing.Point(272, 468)
        Me.CancelBackgroundButton.Name = "CancelBackgroundButton"
        Me.CancelBackgroundButton.Size = New System.Drawing.Size(127, 42)
        Me.CancelBackgroundButton.TabIndex = 33
        Me.CancelBackgroundButton.Text = "Cancel"
        Me.CancelBackgroundButton.UseVisualStyleBackColor = True
        Me.CancelBackgroundButton.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "dashboard.png")
        Me.ImageList1.Images.SetKeyName(1, "shapes-and-symbols.png")
        '
        'logo_bleu
        '
        Me.logo_bleu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.logo_bleu.Controls.Add(Me.HomeButton)
        Me.logo_bleu.Location = New System.Drawing.Point(54, 0)
        Me.logo_bleu.Name = "logo_bleu"
        Me.logo_bleu.Size = New System.Drawing.Size(131, 118)
        Me.logo_bleu.TabIndex = 0
        Me.logo_bleu.Visible = False
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HomeButton.CausesValidation = False
        Me.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.HomeButton.FlatAppearance.BorderSize = 0
        Me.HomeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.HomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeButton.ForeColor = System.Drawing.Color.Transparent
        Me.HomeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.HomeButton.ImageKey = "shapes-and-symbols.png"
        Me.HomeButton.ImageList = Me.ImageList1
        Me.HomeButton.Location = New System.Drawing.Point(36, 32)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(0)
        Me.HomeButton.MinimumSize = New System.Drawing.Size(25, 25)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(92, 84)
        Me.HomeButton.TabIndex = 2
        Me.HomeButton.TabStop = False
        Me.HomeButton.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "page principale"
        Me.HomeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AcceptButton = Me.MenuButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.BT_LOGOUT
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1018, 699)
        Me.Controls.Add(Me.logo_bleu)
        Me.Controls.Add(Me.LogoPicture)
        Me.Controls.Add(Me.NavBar)
        Me.Controls.Add(Me.SideBar)
        Me.Controls.Add(Me.ProfilePane)
        Me.Controls.Add(Me.MainContainer1)
        Me.Controls.Add(Me.MainContainer2)
        Me.Controls.Add(Me.ProgressPanel)
        Me.Controls.Add(Me.MenuButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(1103, 947)
        Me.MinimumSize = New System.Drawing.Size(1023, 593)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.SideBar.ResumeLayout(False)
        CType(Me.LogoPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProfilePane.ResumeLayout(False)
        Me.ProfilePane.PerformLayout()
        CType(Me.mode_photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBar.ResumeLayout(False)
        Me.NavBar.PerformLayout()
        Me.ProgressPanel.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.logo_bleu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SideBar As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ProfilePane As System.Windows.Forms.Panel
    Friend WithEvents BT_PV As System.Windows.Forms.Button
    Friend WithEvents BT_RECH As System.Windows.Forms.Button
    Friend WithEvents BT_STAT As System.Windows.Forms.Button
    Friend WithEvents BT_CLASS As System.Windows.Forms.Button
    Friend WithEvents BT_LOGOUT As System.Windows.Forms.Button
    Friend WithEvents BT_modif_mdp As System.Windows.Forms.Button
    Friend WithEvents mode_photo As System.Windows.Forms.PictureBox
    Friend WithEvents NavBar As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LBL_MODE As System.Windows.Forms.Label
    Friend WithEvents RNButton As System.Windows.Forms.Button
    Friend WithEvents RNGButton As System.Windows.Forms.Button
    Friend WithEvents DetailButton As System.Windows.Forms.Button
    Friend WithEvents ModifButton As System.Windows.Forms.Button
    Friend WithEvents MenuButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ClassIconsList As System.Windows.Forms.ImageList
    Friend WithEvents StaticIconsList As System.Windows.Forms.ImageList
    Friend WithEvents SearchIconsList As System.Windows.Forms.ImageList
    Friend WithEvents PVIconsList As System.Windows.Forms.ImageList
    Friend WithEvents MainContainer1 As System.Windows.Forms.Panel
    Friend WithEvents MainContainer2 As System.Windows.Forms.Panel
    Friend WithEvents ProgressPanel As System.Windows.Forms.Panel
    Friend WithEvents ProgressLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CancelBackgroundButton As System.Windows.Forms.Button
    Friend WithEvents LogoPicture As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents logo_bleu As System.Windows.Forms.Panel
    Friend WithEvents HomeButton As System.Windows.Forms.Button

End Class
