<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassementPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClassementPage))
        Me.FlecheList = New System.Windows.Forms.ImageList(Me.components)
        Me.AffPanel = New System.Windows.Forms.Panel()
        Me.EtudiantPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7_5 = New System.Windows.Forms.Label()
        Me.Label7_4 = New System.Windows.Forms.Label()
        Me.Label7_3 = New System.Windows.Forms.Label()
        Me.Label7_2 = New System.Windows.Forms.Label()
        Me.Label7_1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6_5 = New System.Windows.Forms.Label()
        Me.Label6_4 = New System.Windows.Forms.Label()
        Me.Label6_3 = New System.Windows.Forms.Label()
        Me.Label6_2 = New System.Windows.Forms.Label()
        Me.Label6_1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5_4 = New System.Windows.Forms.Label()
        Me.Label5_5 = New System.Windows.Forms.Label()
        Me.Label5_3 = New System.Windows.Forms.Label()
        Me.Label5_2 = New System.Windows.Forms.Label()
        Me.Label5_1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4_4 = New System.Windows.Forms.Label()
        Me.Label4_5 = New System.Windows.Forms.Label()
        Me.Label4_3 = New System.Windows.Forms.Label()
        Me.Label4_2 = New System.Windows.Forms.Label()
        Me.Label4_1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3_5 = New System.Windows.Forms.Label()
        Me.Label3_4 = New System.Windows.Forms.Label()
        Me.Label3_3 = New System.Windows.Forms.Label()
        Me.Label3_2 = New System.Windows.Forms.Label()
        Me.Label3_1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2_5 = New System.Windows.Forms.Label()
        Me.Label2_4 = New System.Windows.Forms.Label()
        Me.Label2_3 = New System.Windows.Forms.Label()
        Me.Label2_2 = New System.Windows.Forms.Label()
        Me.Label2_1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1_4 = New System.Windows.Forms.Label()
        Me.Label1_5 = New System.Windows.Forms.Label()
        Me.Label1_3 = New System.Windows.Forms.Label()
        Me.Label1_2 = New System.Windows.Forms.Label()
        Me.Label1_1 = New System.Windows.Forms.Label()
        Me.PN_PAGES = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BT_PREV = New System.Windows.Forms.Button()
        Me.BT_NEXT = New System.Windows.Forms.Button()
        Me.IntroPanel = New System.Windows.Forms.Panel()
        Me.LB_INFOAFFICH = New System.Windows.Forms.Label()
        Me.RechLabel = New System.Windows.Forms.Label()
        Me.NoResultLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.PromoButton = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AffPanel.SuspendLayout()
        Me.EtudiantPanel.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PN_PAGES.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.IntroPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ShapeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlecheList
        '
        Me.FlecheList.ImageStream = CType(resources.GetObject("FlecheList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.FlecheList.TransparentColor = System.Drawing.Color.Transparent
        Me.FlecheList.Images.SetKeyName(0, "fleche ascendant.png")
        Me.FlecheList.Images.SetKeyName(1, "fleche decendant.png")
        '
        'AffPanel
        '
        Me.AffPanel.BackColor = System.Drawing.Color.Transparent
        Me.AffPanel.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.AffPanel.Controls.Add(Me.EtudiantPanel)
        Me.AffPanel.Controls.Add(Me.PN_PAGES)
        Me.AffPanel.Controls.Add(Me.IntroPanel)
        Me.AffPanel.Controls.Add(Me.NoResultLabel)
        Me.AffPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AffPanel.Location = New System.Drawing.Point(0, 0)
        Me.AffPanel.Name = "AffPanel"
        Me.AffPanel.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.AffPanel.Size = New System.Drawing.Size(678, 640)
        Me.AffPanel.TabIndex = 28
        '
        'EtudiantPanel
        '
        Me.EtudiantPanel.BackColor = System.Drawing.Color.Transparent
        Me.EtudiantPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EtudiantPanel.Controls.Add(Me.TableLayoutPanel7)
        Me.EtudiantPanel.Controls.Add(Me.TableLayoutPanel6)
        Me.EtudiantPanel.Controls.Add(Me.TableLayoutPanel5)
        Me.EtudiantPanel.Controls.Add(Me.TableLayoutPanel4)
        Me.EtudiantPanel.Controls.Add(Me.TableLayoutPanel3)
        Me.EtudiantPanel.Controls.Add(Me.TableLayoutPanel2)
        Me.EtudiantPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.EtudiantPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EtudiantPanel.Location = New System.Drawing.Point(10, 76)
        Me.EtudiantPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.EtudiantPanel.Name = "EtudiantPanel"
        Me.EtudiantPanel.Size = New System.Drawing.Size(658, 473)
        Me.EtudiantPanel.TabIndex = 24
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackgroundImage = CType(resources.GetObject("TableLayoutPanel7.BackgroundImage"), System.Drawing.Image)
        Me.TableLayoutPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel7.ColumnCount = 6
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label7_5, 5, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label7_4, 4, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label7_3, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label7_2, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label7_1, 1, 0)
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
        'Label7_5
        '
        Me.Label7_5.AutoEllipsis = True
        Me.Label7_5.AutoSize = True
        Me.Label7_5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7_5.Location = New System.Drawing.Point(533, 2)
        Me.Label7_5.Name = "Label7_5"
        Me.Label7_5.Size = New System.Drawing.Size(115, 63)
        Me.Label7_5.TabIndex = 5
        Me.Label7_5.Text = "adresseLabel"
        Me.Label7_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7_4
        '
        Me.Label7_4.AutoEllipsis = True
        Me.Label7_4.AutoSize = True
        Me.Label7_4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7_4.Location = New System.Drawing.Point(417, 2)
        Me.Label7_4.Name = "Label7_4"
        Me.Label7_4.Size = New System.Drawing.Size(110, 63)
        Me.Label7_4.TabIndex = 4
        Me.Label7_4.Text = "MoyenneLabel"
        Me.Label7_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7_3
        '
        Me.Label7_3.AutoEllipsis = True
        Me.Label7_3.AutoSize = True
        Me.Label7_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7_3.Location = New System.Drawing.Point(301, 2)
        Me.Label7_3.Name = "Label7_3"
        Me.Label7_3.Size = New System.Drawing.Size(110, 63)
        Me.Label7_3.TabIndex = 3
        Me.Label7_3.Text = "MaticuleLabel"
        Me.Label7_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7_2
        '
        Me.Label7_2.AutoEllipsis = True
        Me.Label7_2.AutoSize = True
        Me.Label7_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7_2.Location = New System.Drawing.Point(185, 2)
        Me.Label7_2.Name = "Label7_2"
        Me.Label7_2.Size = New System.Drawing.Size(110, 63)
        Me.Label7_2.TabIndex = 2
        Me.Label7_2.Text = "PrenomLabel"
        Me.Label7_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7_1
        '
        Me.Label7_1.AutoEllipsis = True
        Me.Label7_1.AutoSize = True
        Me.Label7_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7_1.Location = New System.Drawing.Point(69, 2)
        Me.Label7_1.Name = "Label7_1"
        Me.Label7_1.Size = New System.Drawing.Size(110, 63)
        Me.Label7_1.TabIndex = 1
        Me.Label7_1.Text = "NameLabel"
        Me.Label7_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.table_blanc1
        Me.TableLayoutPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel6.ColumnCount = 6
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label6_5, 5, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label6_4, 4, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label6_3, 3, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label6_2, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label6_1, 1, 0)
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
        'Label6_5
        '
        Me.Label6_5.AutoEllipsis = True
        Me.Label6_5.AutoSize = True
        Me.Label6_5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6_5.Location = New System.Drawing.Point(533, 2)
        Me.Label6_5.Name = "Label6_5"
        Me.Label6_5.Size = New System.Drawing.Size(115, 63)
        Me.Label6_5.TabIndex = 5
        Me.Label6_5.Text = "adresseLabel"
        Me.Label6_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6_4
        '
        Me.Label6_4.AutoEllipsis = True
        Me.Label6_4.AutoSize = True
        Me.Label6_4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6_4.Location = New System.Drawing.Point(417, 2)
        Me.Label6_4.Name = "Label6_4"
        Me.Label6_4.Size = New System.Drawing.Size(110, 63)
        Me.Label6_4.TabIndex = 4
        Me.Label6_4.Text = "MoyenneLabel"
        Me.Label6_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6_3
        '
        Me.Label6_3.AutoEllipsis = True
        Me.Label6_3.AutoSize = True
        Me.Label6_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6_3.Location = New System.Drawing.Point(301, 2)
        Me.Label6_3.Name = "Label6_3"
        Me.Label6_3.Size = New System.Drawing.Size(110, 63)
        Me.Label6_3.TabIndex = 3
        Me.Label6_3.Text = "MaticuleLabel"
        Me.Label6_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6_2
        '
        Me.Label6_2.AutoEllipsis = True
        Me.Label6_2.AutoSize = True
        Me.Label6_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6_2.Location = New System.Drawing.Point(185, 2)
        Me.Label6_2.Name = "Label6_2"
        Me.Label6_2.Size = New System.Drawing.Size(110, 63)
        Me.Label6_2.TabIndex = 2
        Me.Label6_2.Text = "PrenomLabel"
        Me.Label6_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6_1
        '
        Me.Label6_1.AutoEllipsis = True
        Me.Label6_1.AutoSize = True
        Me.Label6_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6_1.Location = New System.Drawing.Point(69, 2)
        Me.Label6_1.Name = "Label6_1"
        Me.Label6_1.Size = New System.Drawing.Size(110, 63)
        Me.Label6_1.TabIndex = 1
        Me.Label6_1.Text = "NameLabel"
        Me.Label6_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.table_blanc1
        Me.TableLayoutPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel5.ColumnCount = 6
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label5_4, 4, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label5_5, 5, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label5_3, 3, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label5_2, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label5_1, 1, 0)
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
        'Label5_4
        '
        Me.Label5_4.AutoEllipsis = True
        Me.Label5_4.AutoSize = True
        Me.Label5_4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5_4.Location = New System.Drawing.Point(417, 2)
        Me.Label5_4.Name = "Label5_4"
        Me.Label5_4.Size = New System.Drawing.Size(110, 63)
        Me.Label5_4.TabIndex = 5
        Me.Label5_4.Text = "MoyenneLabel"
        Me.Label5_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5_5
        '
        Me.Label5_5.AutoEllipsis = True
        Me.Label5_5.AutoSize = True
        Me.Label5_5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5_5.Location = New System.Drawing.Point(533, 2)
        Me.Label5_5.Name = "Label5_5"
        Me.Label5_5.Size = New System.Drawing.Size(115, 63)
        Me.Label5_5.TabIndex = 4
        Me.Label5_5.Text = "adresseLabel"
        Me.Label5_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5_3
        '
        Me.Label5_3.AutoEllipsis = True
        Me.Label5_3.AutoSize = True
        Me.Label5_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5_3.Location = New System.Drawing.Point(301, 2)
        Me.Label5_3.Name = "Label5_3"
        Me.Label5_3.Size = New System.Drawing.Size(110, 63)
        Me.Label5_3.TabIndex = 3
        Me.Label5_3.Text = "MaticuleLabel"
        Me.Label5_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5_2
        '
        Me.Label5_2.AutoEllipsis = True
        Me.Label5_2.AutoSize = True
        Me.Label5_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5_2.Location = New System.Drawing.Point(185, 2)
        Me.Label5_2.Name = "Label5_2"
        Me.Label5_2.Size = New System.Drawing.Size(110, 63)
        Me.Label5_2.TabIndex = 2
        Me.Label5_2.Text = "PrenomLabel"
        Me.Label5_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5_1
        '
        Me.Label5_1.AutoEllipsis = True
        Me.Label5_1.AutoSize = True
        Me.Label5_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5_1.Location = New System.Drawing.Point(69, 2)
        Me.Label5_1.Name = "Label5_1"
        Me.Label5_1.Size = New System.Drawing.Size(110, 63)
        Me.Label5_1.TabIndex = 1
        Me.Label5_1.Text = "NameLabel"
        Me.Label5_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.table_blanc1
        Me.TableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel4.ColumnCount = 6
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4_4, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4_5, 5, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4_3, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4_2, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4_1, 1, 0)
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
        'Label4_4
        '
        Me.Label4_4.AutoEllipsis = True
        Me.Label4_4.AutoSize = True
        Me.Label4_4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4_4.Location = New System.Drawing.Point(417, 2)
        Me.Label4_4.Name = "Label4_4"
        Me.Label4_4.Size = New System.Drawing.Size(110, 63)
        Me.Label4_4.TabIndex = 5
        Me.Label4_4.Text = "MoyenneLabel"
        Me.Label4_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4_5
        '
        Me.Label4_5.AutoEllipsis = True
        Me.Label4_5.AutoSize = True
        Me.Label4_5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4_5.Location = New System.Drawing.Point(533, 2)
        Me.Label4_5.Name = "Label4_5"
        Me.Label4_5.Size = New System.Drawing.Size(115, 63)
        Me.Label4_5.TabIndex = 4
        Me.Label4_5.Text = "adresseLabel"
        Me.Label4_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4_3
        '
        Me.Label4_3.AutoEllipsis = True
        Me.Label4_3.AutoSize = True
        Me.Label4_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4_3.Location = New System.Drawing.Point(301, 2)
        Me.Label4_3.Name = "Label4_3"
        Me.Label4_3.Size = New System.Drawing.Size(110, 63)
        Me.Label4_3.TabIndex = 3
        Me.Label4_3.Text = "MaticuleLabel"
        Me.Label4_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4_2
        '
        Me.Label4_2.AutoEllipsis = True
        Me.Label4_2.AutoSize = True
        Me.Label4_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4_2.Location = New System.Drawing.Point(185, 2)
        Me.Label4_2.Name = "Label4_2"
        Me.Label4_2.Size = New System.Drawing.Size(110, 63)
        Me.Label4_2.TabIndex = 2
        Me.Label4_2.Text = "PrenomLabel"
        Me.Label4_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4_1
        '
        Me.Label4_1.AutoEllipsis = True
        Me.Label4_1.AutoSize = True
        Me.Label4_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4_1.Location = New System.Drawing.Point(69, 2)
        Me.Label4_1.Name = "Label4_1"
        Me.Label4_1.Size = New System.Drawing.Size(110, 63)
        Me.Label4_1.TabIndex = 1
        Me.Label4_1.Text = "NameLabel"
        Me.Label4_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.table_blanc1
        Me.TableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3_5, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3_4, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3_3, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3_2, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3_1, 1, 0)
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
        'Label3_5
        '
        Me.Label3_5.AutoEllipsis = True
        Me.Label3_5.AutoSize = True
        Me.Label3_5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3_5.Location = New System.Drawing.Point(533, 2)
        Me.Label3_5.Name = "Label3_5"
        Me.Label3_5.Size = New System.Drawing.Size(115, 63)
        Me.Label3_5.TabIndex = 5
        Me.Label3_5.Text = "adresseLabel"
        Me.Label3_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3_4
        '
        Me.Label3_4.AutoEllipsis = True
        Me.Label3_4.AutoSize = True
        Me.Label3_4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3_4.Location = New System.Drawing.Point(417, 2)
        Me.Label3_4.Name = "Label3_4"
        Me.Label3_4.Size = New System.Drawing.Size(110, 63)
        Me.Label3_4.TabIndex = 4
        Me.Label3_4.Text = "MoyenneLabel"
        Me.Label3_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3_3
        '
        Me.Label3_3.AutoEllipsis = True
        Me.Label3_3.AutoSize = True
        Me.Label3_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3_3.Location = New System.Drawing.Point(301, 2)
        Me.Label3_3.Name = "Label3_3"
        Me.Label3_3.Size = New System.Drawing.Size(110, 63)
        Me.Label3_3.TabIndex = 3
        Me.Label3_3.Text = "MaticuleLabel"
        Me.Label3_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3_2
        '
        Me.Label3_2.AutoEllipsis = True
        Me.Label3_2.AutoSize = True
        Me.Label3_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3_2.Location = New System.Drawing.Point(185, 2)
        Me.Label3_2.Name = "Label3_2"
        Me.Label3_2.Size = New System.Drawing.Size(110, 63)
        Me.Label3_2.TabIndex = 2
        Me.Label3_2.Text = "PrenomLabel"
        Me.Label3_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3_1
        '
        Me.Label3_1.AutoEllipsis = True
        Me.Label3_1.AutoSize = True
        Me.Label3_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3_1.Location = New System.Drawing.Point(69, 2)
        Me.Label3_1.Name = "Label3_1"
        Me.Label3_1.Size = New System.Drawing.Size(110, 63)
        Me.Label3_1.TabIndex = 1
        Me.Label3_1.Text = "NameLabel"
        Me.Label3_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.table_blanc1
        Me.TableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2_4, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2_3, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2_2, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2_1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 5, 0)
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
        'Label2_5
        '
        Me.Label2_5.AutoEllipsis = True
        Me.Label2_5.AutoSize = True
        Me.Label2_5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2_5.Location = New System.Drawing.Point(632, 2)
        Me.Label2_5.Name = "Label2_5"
        Me.Label2_5.Size = New System.Drawing.Size(16, 63)
        Me.Label2_5.TabIndex = 5
        Me.Label2_5.Text = "adresseLabel"
        Me.Label2_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_4
        '
        Me.Label2_4.AutoEllipsis = True
        Me.Label2_4.AutoSize = True
        Me.Label2_4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2_4.Location = New System.Drawing.Point(417, 2)
        Me.Label2_4.Name = "Label2_4"
        Me.Label2_4.Size = New System.Drawing.Size(110, 63)
        Me.Label2_4.TabIndex = 4
        Me.Label2_4.Text = "MoyenneLabel"
        Me.Label2_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_3
        '
        Me.Label2_3.AutoEllipsis = True
        Me.Label2_3.AutoSize = True
        Me.Label2_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2_3.Location = New System.Drawing.Point(301, 2)
        Me.Label2_3.Name = "Label2_3"
        Me.Label2_3.Size = New System.Drawing.Size(110, 63)
        Me.Label2_3.TabIndex = 3
        Me.Label2_3.Text = "MaticuleLabel"
        Me.Label2_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_2
        '
        Me.Label2_2.AutoEllipsis = True
        Me.Label2_2.AutoSize = True
        Me.Label2_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2_2.Location = New System.Drawing.Point(185, 2)
        Me.Label2_2.Name = "Label2_2"
        Me.Label2_2.Size = New System.Drawing.Size(110, 63)
        Me.Label2_2.TabIndex = 2
        Me.Label2_2.Text = "PrenomLabel"
        Me.Label2_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2_1
        '
        Me.Label2_1.AutoEllipsis = True
        Me.Label2_1.AutoSize = True
        Me.Label2_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2_1.Location = New System.Drawing.Point(69, 2)
        Me.Label2_1.Name = "Label2_1"
        Me.Label2_1.Size = New System.Drawing.Size(110, 63)
        Me.Label2_1.TabIndex = 1
        Me.Label2_1.Text = "NameLabel"
        Me.Label2_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.table_blanc1
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1_4, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1_3, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1_2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1_1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1_5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 5, 0)
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
        'Label1_4
        '
        Me.Label1_4.AutoEllipsis = True
        Me.Label1_4.AutoSize = True
        Me.Label1_4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1_4.Location = New System.Drawing.Point(417, 2)
        Me.Label1_4.Name = "Label1_4"
        Me.Label1_4.Size = New System.Drawing.Size(110, 63)
        Me.Label1_4.TabIndex = 4
        Me.Label1_4.Text = "MoyenneLabel"
        Me.Label1_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1_5
        '
        Me.Label1_5.AutoEllipsis = True
        Me.Label1_5.AutoSize = True
        Me.Label1_5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1_5.Location = New System.Drawing.Point(5, 2)
        Me.Label1_5.Name = "Label1_5"
        Me.Label1_5.Size = New System.Drawing.Size(58, 63)
        Me.Label1_5.TabIndex = 3
        Me.Label1_5.Text = "RankingLabel"
        Me.Label1_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1_3
        '
        Me.Label1_3.AutoEllipsis = True
        Me.Label1_3.AutoSize = True
        Me.Label1_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1_3.Location = New System.Drawing.Point(301, 2)
        Me.Label1_3.Name = "Label1_3"
        Me.Label1_3.Size = New System.Drawing.Size(110, 63)
        Me.Label1_3.TabIndex = 2
        Me.Label1_3.Text = "MaticuleLabel"
        Me.Label1_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1_2
        '
        Me.Label1_2.AutoEllipsis = True
        Me.Label1_2.AutoSize = True
        Me.Label1_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1_2.Location = New System.Drawing.Point(185, 2)
        Me.Label1_2.Name = "Label1_2"
        Me.Label1_2.Size = New System.Drawing.Size(110, 63)
        Me.Label1_2.TabIndex = 1
        Me.Label1_2.Text = "PrenomLabel"
        Me.Label1_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1_1
        '
        Me.Label1_1.AutoEllipsis = True
        Me.Label1_1.AutoSize = True
        Me.Label1_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1_1.Location = New System.Drawing.Point(69, 2)
        Me.Label1_1.Name = "Label1_1"
        Me.Label1_1.Size = New System.Drawing.Size(110, 63)
        Me.Label1_1.TabIndex = 0
        Me.Label1_1.Text = "NameLabel"
        Me.Label1_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PN_PAGES
        '
        Me.PN_PAGES.BackColor = System.Drawing.Color.Transparent
        Me.PN_PAGES.Controls.Add(Me.Panel2)
        Me.PN_PAGES.Controls.Add(Me.Panel1)
        Me.PN_PAGES.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PN_PAGES.Location = New System.Drawing.Point(10, 549)
        Me.PN_PAGES.Margin = New System.Windows.Forms.Padding(0)
        Me.PN_PAGES.Name = "PN_PAGES"
        Me.PN_PAGES.Padding = New System.Windows.Forms.Padding(15, 8, 15, 15)
        Me.PN_PAGES.Size = New System.Drawing.Size(658, 91)
        Me.PN_PAGES.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BT_NEXT)
        Me.Panel1.Controls.Add(Me.BT_PREV)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(242, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 41)
        Me.Panel1.TabIndex = 9
        '
        'BT_PREV
        '
        Me.BT_PREV.AutoSize = True
        Me.BT_PREV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_PREV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_PREV.Dock = System.Windows.Forms.DockStyle.Left
        Me.BT_PREV.FlatAppearance.BorderSize = 0
        Me.BT_PREV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_PREV.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.prev2
        Me.BT_PREV.Location = New System.Drawing.Point(0, 0)
        Me.BT_PREV.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_PREV.Name = "BT_PREV"
        Me.BT_PREV.Size = New System.Drawing.Size(36, 41)
        Me.BT_PREV.TabIndex = 0
        Me.BT_PREV.UseVisualStyleBackColor = True
        '
        'BT_NEXT
        '
        Me.BT_NEXT.AutoSize = True
        Me.BT_NEXT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BT_NEXT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_NEXT.FlatAppearance.BorderSize = 0
        Me.BT_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_NEXT.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.next1
        Me.BT_NEXT.Location = New System.Drawing.Point(120, 0)
        Me.BT_NEXT.Margin = New System.Windows.Forms.Padding(0)
        Me.BT_NEXT.Name = "BT_NEXT"
        Me.BT_NEXT.Size = New System.Drawing.Size(36, 42)
        Me.BT_NEXT.TabIndex = 5
        Me.BT_NEXT.UseVisualStyleBackColor = True
        '
        'IntroPanel
        '
        Me.IntroPanel.Controls.Add(Me.LB_INFOAFFICH)
        Me.IntroPanel.Controls.Add(Me.RechLabel)
        Me.IntroPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.IntroPanel.Location = New System.Drawing.Point(10, 0)
        Me.IntroPanel.Name = "IntroPanel"
        Me.IntroPanel.Size = New System.Drawing.Size(658, 76)
        Me.IntroPanel.TabIndex = 27
        '
        'LB_INFOAFFICH
        '
        Me.LB_INFOAFFICH.AutoSize = True
        Me.LB_INFOAFFICH.BackColor = System.Drawing.Color.Transparent
        Me.LB_INFOAFFICH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_INFOAFFICH.ForeColor = System.Drawing.Color.Maroon
        Me.LB_INFOAFFICH.Location = New System.Drawing.Point(120, 47)
        Me.LB_INFOAFFICH.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_INFOAFFICH.Name = "LB_INFOAFFICH"
        Me.LB_INFOAFFICH.Size = New System.Drawing.Size(418, 17)
        Me.LB_INFOAFFICH.TabIndex = 21
        Me.LB_INFOAFFICH.Text = "Vous pouvez selectionner un etudiant puis l'operation associee   "
        '
        'RechLabel
        '
        Me.RechLabel.AutoSize = True
        Me.RechLabel.BackColor = System.Drawing.Color.Transparent
        Me.RechLabel.Font = New System.Drawing.Font("Times New Roman", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RechLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.RechLabel.Location = New System.Drawing.Point(236, 3)
        Me.RechLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RechLabel.Name = "RechLabel"
        Me.RechLabel.Size = New System.Drawing.Size(157, 34)
        Me.RechLabel.TabIndex = 18
        Me.RechLabel.Text = "Classement"
        '
        'NoResultLabel
        '
        Me.NoResultLabel.AutoEllipsis = True
        Me.NoResultLabel.BackColor = System.Drawing.Color.White
        Me.NoResultLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoResultLabel.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.Asset_2
        Me.NoResultLabel.Location = New System.Drawing.Point(12, 105)
        Me.NoResultLabel.Name = "NoResultLabel"
        Me.NoResultLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 30)
        Me.NoResultLabel.Size = New System.Drawing.Size(655, 477)
        Me.NoResultLabel.TabIndex = 28
        Me.NoResultLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Location = New System.Drawing.Point(523, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(102, 34)
        Me.Panel2.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(2, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "1"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(36, 2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "2"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(70, 2)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(30, 30)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "3"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button4.UseVisualStyleBackColor = True
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.RectangleShape1.CornerRadius = 17
        Me.RectangleShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(39, 3)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RectangleShape1.Size = New System.Drawing.Size(80, 35)
        '
        'PromoButton
        '
        Me.PromoButton.AutoSize = True
        Me.PromoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PromoButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PromoButton.FlatAppearance.BorderSize = 0
        Me.PromoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PromoButton.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromoButton.ForeColor = System.Drawing.Color.White
        Me.PromoButton.Location = New System.Drawing.Point(46, 7)
        Me.PromoButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PromoButton.Name = "PromoButton"
        Me.PromoButton.Size = New System.Drawing.Size(66, 29)
        Me.PromoButton.TabIndex = 8
        Me.PromoButton.Text = "2000"
        Me.PromoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.PromoButton.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Controls.Add(Me.PromoButton)
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(160, 41)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(533, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 63)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NameLabel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(533, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 63)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "adresseLabel"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(5, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 63)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "RankingLabel"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(5, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 63)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "RankingLabel"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoEllipsis = True
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(5, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 63)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "RankingLabel"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoEllipsis = True
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(5, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 63)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "RankingLabel"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoEllipsis = True
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(5, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 63)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "RankingLabel"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoEllipsis = True
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(5, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 63)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "RankingLabel"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClassementPage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(678, 640)
        Me.Controls.Add(Me.AffPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 595)
        Me.Name = "ClassementPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.AffPanel.ResumeLayout(False)
        Me.EtudiantPanel.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.PN_PAGES.ResumeLayout(False)
        Me.PN_PAGES.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.IntroPanel.ResumeLayout(False)
        Me.IntroPanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ShapeContainer1.ResumeLayout(False)
        Me.ShapeContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlecheList As System.Windows.Forms.ImageList
    Friend WithEvents AffPanel As System.Windows.Forms.Panel
    Friend WithEvents EtudiantPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7_5 As System.Windows.Forms.Label
    Friend WithEvents Label7_4 As System.Windows.Forms.Label
    Friend WithEvents Label7_3 As System.Windows.Forms.Label
    Friend WithEvents Label7_2 As System.Windows.Forms.Label
    Friend WithEvents Label7_1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6_5 As System.Windows.Forms.Label
    Friend WithEvents Label6_4 As System.Windows.Forms.Label
    Friend WithEvents Label6_3 As System.Windows.Forms.Label
    Friend WithEvents Label6_2 As System.Windows.Forms.Label
    Friend WithEvents Label6_1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5_4 As System.Windows.Forms.Label
    Friend WithEvents Label5_5 As System.Windows.Forms.Label
    Friend WithEvents Label5_3 As System.Windows.Forms.Label
    Friend WithEvents Label5_2 As System.Windows.Forms.Label
    Friend WithEvents Label5_1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4_4 As System.Windows.Forms.Label
    Friend WithEvents Label4_5 As System.Windows.Forms.Label
    Friend WithEvents Label4_3 As System.Windows.Forms.Label
    Friend WithEvents Label4_2 As System.Windows.Forms.Label
    Friend WithEvents Label4_1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3_5 As System.Windows.Forms.Label
    Friend WithEvents Label3_4 As System.Windows.Forms.Label
    Friend WithEvents Label3_3 As System.Windows.Forms.Label
    Friend WithEvents Label3_2 As System.Windows.Forms.Label
    Friend WithEvents Label3_1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2_5 As System.Windows.Forms.Label
    Friend WithEvents Label2_4 As System.Windows.Forms.Label
    Friend WithEvents Label2_3 As System.Windows.Forms.Label
    Friend WithEvents Label2_2 As System.Windows.Forms.Label
    Friend WithEvents Label2_1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1_4 As System.Windows.Forms.Label
    Friend WithEvents Label1_5 As System.Windows.Forms.Label
    Friend WithEvents Label1_3 As System.Windows.Forms.Label
    Friend WithEvents Label1_2 As System.Windows.Forms.Label
    Friend WithEvents Label1_1 As System.Windows.Forms.Label
    Friend WithEvents PN_PAGES As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BT_PREV As System.Windows.Forms.Button
    Friend WithEvents BT_NEXT As System.Windows.Forms.Button
    Friend WithEvents IntroPanel As System.Windows.Forms.Panel
    Friend WithEvents LB_INFOAFFICH As System.Windows.Forms.Label
    Friend WithEvents RechLabel As System.Windows.Forms.Label
    Friend WithEvents NoResultLabel As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents PromoButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
