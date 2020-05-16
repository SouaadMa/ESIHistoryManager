<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chargement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chargement))
        Me.ChargementLabel = New System.Windows.Forms.Label()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ChargementPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RechargComplLabel = New System.Windows.Forms.Label()
        Me.RechargementButton = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CompletLabel = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChargementButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ProgressPanel = New System.Windows.Forms.Panel()
        Me.ProgressLabel = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ChargBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.TitlePanel.SuspendLayout()
        Me.ChargementPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ProgressPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChargementLabel
        '
        Me.ChargementLabel.AutoSize = True
        Me.ChargementLabel.BackColor = System.Drawing.Color.Transparent
        Me.ChargementLabel.Font = New System.Drawing.Font("Times New Roman", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChargementLabel.ForeColor = System.Drawing.Color.SteelBlue
        Me.ChargementLabel.Location = New System.Drawing.Point(263, 16)
        Me.ChargementLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ChargementLabel.Name = "ChargementLabel"
        Me.ChargementLabel.Size = New System.Drawing.Size(154, 31)
        Me.ChargementLabel.TabIndex = 12
        Me.ChargementLabel.Text = "Chargement"
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.Transparent
        Me.TitlePanel.Controls.Add(Me.Label6)
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(701, 42)
        Me.TitlePanel.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 21.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(165, 3)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(327, 32)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Gestion de base de données"
        '
        'ChargementPanel
        '
        Me.ChargementPanel.BackColor = System.Drawing.Color.Transparent
        Me.ChargementPanel.Controls.Add(Me.Panel1)
        Me.ChargementPanel.Controls.Add(Me.ProgressPanel)
        Me.ChargementPanel.Controls.Add(Me.TitlePanel)
        Me.ChargementPanel.Location = New System.Drawing.Point(0, 0)
        Me.ChargementPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ChargementPanel.Name = "ChargementPanel"
        Me.ChargementPanel.Size = New System.Drawing.Size(701, 668)
        Me.ChargementPanel.TabIndex = 87
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RechargComplLabel)
        Me.Panel1.Controls.Add(Me.RechargementButton)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ChargementLabel)
        Me.Panel1.Controls.Add(Me.CompletLabel)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ChargementButton)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(701, 627)
        Me.Panel1.TabIndex = 35
        '
        'RechargComplLabel
        '
        Me.RechargComplLabel.AutoSize = True
        Me.RechargComplLabel.BackColor = System.Drawing.Color.Transparent
        Me.RechargComplLabel.Font = New System.Drawing.Font("Times New Roman", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RechargComplLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.RechargComplLabel.Location = New System.Drawing.Point(157, 568)
        Me.RechargComplLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RechargComplLabel.Name = "RechargComplLabel"
        Me.RechargComplLabel.Size = New System.Drawing.Size(386, 23)
        Me.RechargComplLabel.TabIndex = 38
        Me.RechargComplLabel.Text = "La base de donné a été rechargée avec succès"
        Me.RechargComplLabel.Visible = False
        '
        'RechargementButton
        '
        Me.RechargementButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.RechargementButton.FlatAppearance.BorderSize = 0
        Me.RechargementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RechargementButton.Font = New System.Drawing.Font("Cambria", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RechargementButton.ForeColor = System.Drawing.Color.White
        Me.RechargementButton.Location = New System.Drawing.Point(269, 498)
        Me.RechargementButton.Name = "RechargementButton"
        Me.RechargementButton.Size = New System.Drawing.Size(160, 36)
        Me.RechargementButton.TabIndex = 31
        Me.RechargementButton.Text = "Rechargement"
        Me.RechargementButton.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.ImageIndex = 0
        Me.Button8.ImageList = Me.ImageList1
        Me.Button8.Location = New System.Drawing.Point(592, 263)
        Me.Button8.Margin = New System.Windows.Forms.Padding(0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(22, 22)
        Me.Button8.TabIndex = 36
        Me.Button8.UseVisualStyleBackColor = True
        Me.Button8.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "more.png")
        Me.ImageList1.Images.SetKeyName(1, "shapes-and-symbols.png")
        '
        'Button7
        '
        Me.Button7.ImageIndex = 0
        Me.Button7.ImageList = Me.ImageList1
        Me.Button7.Location = New System.Drawing.Point(592, 207)
        Me.Button7.Margin = New System.Windows.Forms.Padding(0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(22, 22)
        Me.Button7.TabIndex = 35
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'Button6
        '
        Me.Button6.ImageIndex = 0
        Me.Button6.ImageList = Me.ImageList1
        Me.Button6.Location = New System.Drawing.Point(592, 151)
        Me.Button6.Margin = New System.Windows.Forms.Padding(0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(22, 22)
        Me.Button6.TabIndex = 34
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'Button5
        '
        Me.Button5.ImageIndex = 0
        Me.Button5.ImageList = Me.ImageList1
        Me.Button5.Location = New System.Drawing.Point(592, 93)
        Me.Button5.Margin = New System.Windows.Forms.Padding(0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(22, 22)
        Me.Button5.TabIndex = 33
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(257, 439)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 31)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Rechargement"
        '
        'CompletLabel
        '
        Me.CompletLabel.AutoSize = True
        Me.CompletLabel.BackColor = System.Drawing.Color.Transparent
        Me.CompletLabel.Font = New System.Drawing.Font("Times New Roman", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompletLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.CompletLabel.Location = New System.Drawing.Point(167, 363)
        Me.CompletLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CompletLabel.Name = "CompletLabel"
        Me.CompletLabel.Size = New System.Drawing.Size(343, 23)
        Me.CompletLabel.TabIndex = 13
        Me.CompletLabel.Text = "Le chargement est completé avec succès"
        Me.CompletLabel.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button4.Location = New System.Drawing.Point(248, 253)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(385, 44)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Cliquez pour choisir le fichier"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button3.Location = New System.Drawing.Point(248, 196)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(385, 44)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Cliquez pour choisir le fichier"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button2.Location = New System.Drawing.Point(248, 139)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(385, 44)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Cliquez pour choisir le fichier"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(62, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(165, 29)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "La table Rattrapage"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(62, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(165, 29)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "La table Matière"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(62, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(165, 29)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "La table Note"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(62, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(165, 29)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "La table Inscrit"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChargementButton
        '
        Me.ChargementButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ChargementButton.FlatAppearance.BorderSize = 0
        Me.ChargementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChargementButton.Font = New System.Drawing.Font("Cambria", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChargementButton.ForeColor = System.Drawing.Color.White
        Me.ChargementButton.Location = New System.Drawing.Point(269, 314)
        Me.ChargementButton.Name = "ChargementButton"
        Me.ChargementButton.Size = New System.Drawing.Size(160, 36)
        Me.ChargementButton.TabIndex = 22
        Me.ChargementButton.Text = "Chargement"
        Me.ChargementButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.ImageKey = "more.png"
        Me.Button1.Location = New System.Drawing.Point(248, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.Button1.Size = New System.Drawing.Size(385, 44)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Cliquez pour choisir le fichier"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(701, 627)
        Me.ShapeContainer1.TabIndex = 37
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 15
        Me.LineShape1.X2 = 687
        Me.LineShape1.Y1 = 407
        Me.LineShape1.Y2 = 407
        '
        'ProgressPanel
        '
        Me.ProgressPanel.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel.Controls.Add(Me.ProgressLabel)
        Me.ProgressPanel.Controls.Add(Me.PictureBox2)
        Me.ProgressPanel.Controls.Add(Me.PictureBox1)
        Me.ProgressPanel.Location = New System.Drawing.Point(0, 41)
        Me.ProgressPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ProgressPanel.Name = "ProgressPanel"
        Me.ProgressPanel.Size = New System.Drawing.Size(701, 627)
        Me.ProgressPanel.TabIndex = 51
        Me.ProgressPanel.Visible = False
        '
        'ProgressLabel
        '
        Me.ProgressLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProgressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressLabel.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.layeredAssetWhite
        Me.ProgressLabel.Location = New System.Drawing.Point(294, 308)
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
        Me.PictureBox2.Location = New System.Drawing.Point(228, 201)
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
        Me.PictureBox1.Location = New System.Drawing.Point(228, 201)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(226, 206)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 206)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "excel file |*.xlsx"
        '
        'ChargBackgroundWorker
        '
        Me.ChargBackgroundWorker.WorkerReportsProgress = True
        Me.ChargBackgroundWorker.WorkerSupportsCancellation = True
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Chargement
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(704, 671)
        Me.Controls.Add(Me.ChargementPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(650, 595)
        Me.Name = "Chargement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de base de données"
        Me.TopMost = True
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.ChargementPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ProgressPanel.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChargementLabel As System.Windows.Forms.Label
    Friend WithEvents TitlePanel As System.Windows.Forms.Panel
    Friend WithEvents ChargementPanel As System.Windows.Forms.Panel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ChargementButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RechargementButton As System.Windows.Forms.Button
    Friend WithEvents CompletLabel As System.Windows.Forms.Label
    Friend WithEvents ProgressPanel As System.Windows.Forms.Panel
    Friend WithEvents ProgressLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ChargBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RechargComplLabel As System.Windows.Forms.Label
End Class
