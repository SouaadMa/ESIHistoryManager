<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RechercherPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RechercherPage))
        Me.RechIntroPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RechButtons = New System.Windows.Forms.Panel()
        Me.worningrech = New System.Windows.Forms.Label()
        Me.BT_LANCERRECH = New System.Windows.Forms.Button()
        Me.generalesGroupBox = New System.Windows.Forms.GroupBox()
        Me.CB_ANNEE = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_MERE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_PERE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IMG_ALERTMTB = New System.Windows.Forms.PictureBox()
        Me.IMG_ALERTMAT = New System.Windows.Forms.PictureBox()
        Me.LB_MATRICUL = New System.Windows.Forms.Label()
        Me.TXT_MATRICUL = New System.Windows.Forms.TextBox()
        Me.TXT_MATRICULB = New System.Windows.Forms.TextBox()
        Me.TXT_PRENOMA = New System.Windows.Forms.TextBox()
        Me.TXT_NOMA = New System.Windows.Forms.TextBox()
        Me.LB_NOMA = New System.Windows.Forms.Label()
        Me.TXT_PRENOM = New System.Windows.Forms.TextBox()
        Me.LB_PRENOMA = New System.Windows.Forms.Label()
        Me.TXT_NOM = New System.Windows.Forms.TextBox()
        Me.LB_SEXE = New System.Windows.Forms.Label()
        Me.DTP_DATEN = New System.Windows.Forms.DateTimePicker()
        Me.CB_SEXE = New System.Windows.Forms.ComboBox()
        Me.LB_DATEN = New System.Windows.Forms.Label()
        Me.LB_MATRICULB = New System.Windows.Forms.Label()
        Me.FlecheList = New System.Windows.Forms.ImageList(Me.components)
        Me.SpliterMain = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ResidenceLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LB_WILAYA = New System.Windows.Forms.Label()
        Me.LB_WILAYANA = New System.Windows.Forms.Label()
        Me.CB_WILAYAN = New System.Windows.Forms.ComboBox()
        Me.CB_WILAYANA = New System.Windows.Forms.ComboBox()
        Me.CB_WILAYA = New System.Windows.Forms.ComboBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.BACLabel = New System.Windows.Forms.Label()
        Me.IMG_ALERTMOY = New System.Windows.Forms.PictureBox()
        Me.CB_ANNEEB = New System.Windows.Forms.ComboBox()
        Me.LB_SERI = New System.Windows.Forms.Label()
        Me.TXT_MOYBAC = New System.Windows.Forms.TextBox()
        Me.LB_WILAYAB = New System.Windows.Forms.Label()
        Me.CB_SERI = New System.Windows.Forms.ComboBox()
        Me.LB_MOYBAC = New System.Windows.Forms.Label()
        Me.CB_WILAYAB = New System.Windows.Forms.ComboBox()
        Me.LB_ANNEEB = New System.Windows.Forms.Label()
        Me.PN_FORUMRECH = New System.Windows.Forms.Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TXT_NOMA_ALERT = New System.Windows.Forms.PictureBox()
        Me.TXT_PRENOM_ALERT = New System.Windows.Forms.PictureBox()
        Me.TXT_PRENOMA_ALERT = New System.Windows.Forms.PictureBox()
        Me.TXT_NOM_ALERT = New System.Windows.Forms.PictureBox()
        Me.AvertToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.RechIntroPanel.SuspendLayout()
        Me.RechButtons.SuspendLayout()
        Me.generalesGroupBox.SuspendLayout()
        CType(Me.IMG_ALERTMTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMG_ALERTMAT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpliterMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SpliterMain.Panel1.SuspendLayout()
        Me.SpliterMain.Panel2.SuspendLayout()
        Me.SpliterMain.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.IMG_ALERTMOY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PN_FORUMRECH.SuspendLayout()
        CType(Me.TXT_NOMA_ALERT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_PRENOM_ALERT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_PRENOMA_ALERT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_NOM_ALERT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RechIntroPanel
        '
        Me.RechIntroPanel.Controls.Add(Me.Label1)
        Me.RechIntroPanel.Location = New System.Drawing.Point(32, 3)
        Me.RechIntroPanel.Name = "RechIntroPanel"
        Me.RechIntroPanel.Size = New System.Drawing.Size(600, 47)
        Me.RechIntroPanel.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(140, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 34)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Formulaire de recherche"
        '
        'RechButtons
        '
        Me.RechButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RechButtons.Controls.Add(Me.worningrech)
        Me.RechButtons.Controls.Add(Me.BT_LANCERRECH)
        Me.RechButtons.Location = New System.Drawing.Point(24, 1005)
        Me.RechButtons.MinimumSize = New System.Drawing.Size(610, 0)
        Me.RechButtons.Name = "RechButtons"
        Me.RechButtons.Size = New System.Drawing.Size(610, 91)
        Me.RechButtons.TabIndex = 44
        '
        'worningrech
        '
        Me.worningrech.AutoSize = True
        Me.worningrech.BackColor = System.Drawing.Color.Transparent
        Me.worningrech.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.worningrech.ForeColor = System.Drawing.Color.Maroon
        Me.worningrech.Location = New System.Drawing.Point(13, 10)
        Me.worningrech.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.worningrech.Name = "worningrech"
        Me.worningrech.Size = New System.Drawing.Size(322, 18)
        Me.worningrech.TabIndex = 41
        Me.worningrech.Text = "Vous devez remplir au moins un champs !"
        Me.worningrech.Visible = False
        '
        'BT_LANCERRECH
        '
        Me.BT_LANCERRECH.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BT_LANCERRECH.FlatAppearance.BorderSize = 0
        Me.BT_LANCERRECH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LANCERRECH.ForeColor = System.Drawing.Color.LightGray
        Me.BT_LANCERRECH.Location = New System.Drawing.Point(380, 0)
        Me.BT_LANCERRECH.Margin = New System.Windows.Forms.Padding(2, 2, 2, 100)
        Me.BT_LANCERRECH.Name = "BT_LANCERRECH"
        Me.BT_LANCERRECH.Size = New System.Drawing.Size(150, 37)
        Me.BT_LANCERRECH.TabIndex = 40
        Me.BT_LANCERRECH.Text = "Rechercher"
        Me.BT_LANCERRECH.UseVisualStyleBackColor = False
        '
        'generalesGroupBox
        '
        Me.generalesGroupBox.Controls.Add(Me.TXT_NOM_ALERT)
        Me.generalesGroupBox.Controls.Add(Me.TXT_PRENOMA_ALERT)
        Me.generalesGroupBox.Controls.Add(Me.TXT_PRENOM_ALERT)
        Me.generalesGroupBox.Controls.Add(Me.TXT_NOMA_ALERT)
        Me.generalesGroupBox.Controls.Add(Me.CB_ANNEE)
        Me.generalesGroupBox.Controls.Add(Me.Label7)
        Me.generalesGroupBox.Controls.Add(Me.TXT_MERE)
        Me.generalesGroupBox.Controls.Add(Me.Label5)
        Me.generalesGroupBox.Controls.Add(Me.TXT_PERE)
        Me.generalesGroupBox.Controls.Add(Me.Label4)
        Me.generalesGroupBox.Controls.Add(Me.Label3)
        Me.generalesGroupBox.Controls.Add(Me.Label2)
        Me.generalesGroupBox.Controls.Add(Me.IMG_ALERTMTB)
        Me.generalesGroupBox.Controls.Add(Me.IMG_ALERTMAT)
        Me.generalesGroupBox.Controls.Add(Me.LB_MATRICUL)
        Me.generalesGroupBox.Controls.Add(Me.TXT_MATRICUL)
        Me.generalesGroupBox.Controls.Add(Me.TXT_MATRICULB)
        Me.generalesGroupBox.Controls.Add(Me.TXT_PRENOMA)
        Me.generalesGroupBox.Controls.Add(Me.TXT_NOMA)
        Me.generalesGroupBox.Controls.Add(Me.LB_NOMA)
        Me.generalesGroupBox.Controls.Add(Me.TXT_PRENOM)
        Me.generalesGroupBox.Controls.Add(Me.LB_PRENOMA)
        Me.generalesGroupBox.Controls.Add(Me.TXT_NOM)
        Me.generalesGroupBox.Controls.Add(Me.LB_SEXE)
        Me.generalesGroupBox.Controls.Add(Me.DTP_DATEN)
        Me.generalesGroupBox.Controls.Add(Me.CB_SEXE)
        Me.generalesGroupBox.Controls.Add(Me.LB_DATEN)
        Me.generalesGroupBox.Controls.Add(Me.LB_MATRICULB)
        Me.generalesGroupBox.Location = New System.Drawing.Point(18, 56)
        Me.generalesGroupBox.Name = "generalesGroupBox"
        Me.generalesGroupBox.Size = New System.Drawing.Size(620, 528)
        Me.generalesGroupBox.TabIndex = 45
        Me.generalesGroupBox.TabStop = False
        Me.generalesGroupBox.Text = "Généralités"
        '
        'CB_ANNEE
        '
        Me.CB_ANNEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ANNEE.FormattingEnabled = True
        Me.CB_ANNEE.Location = New System.Drawing.Point(249, 479)
        Me.CB_ANNEE.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_ANNEE.Name = "CB_ANNEE"
        Me.CB_ANNEE.Size = New System.Drawing.Size(264, 28)
        Me.CB_ANNEE.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(61, 484)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 17)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Année d'entrée"
        '
        'TXT_MERE
        '
        Me.TXT_MERE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MERE.Location = New System.Drawing.Point(249, 439)
        Me.TXT_MERE.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_MERE.Name = "TXT_MERE"
        Me.TXT_MERE.Size = New System.Drawing.Size(264, 26)
        Me.TXT_MERE.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 444)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 17)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Nom de la mère"
        '
        'TXT_PERE
        '
        Me.TXT_PERE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PERE.Location = New System.Drawing.Point(249, 388)
        Me.TXT_PERE.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_PERE.Name = "TXT_PERE"
        Me.TXT_PERE.Size = New System.Drawing.Size(264, 26)
        Me.TXT_PERE.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 393)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Nom du Père"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 168)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Nom en Arabe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 212)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 17)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Prénom en Français"
        '
        'IMG_ALERTMTB
        '
        Me.IMG_ALERTMTB.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.alert1
        Me.IMG_ALERTMTB.Location = New System.Drawing.Point(518, 71)
        Me.IMG_ALERTMTB.Name = "IMG_ALERTMTB"
        Me.IMG_ALERTMTB.Size = New System.Drawing.Size(30, 30)
        Me.IMG_ALERTMTB.TabIndex = 38
        Me.IMG_ALERTMTB.TabStop = False
        Me.IMG_ALERTMTB.Visible = False
        '
        'IMG_ALERTMAT
        '
        Me.IMG_ALERTMAT.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.alert1
        Me.IMG_ALERTMAT.Location = New System.Drawing.Point(518, 27)
        Me.IMG_ALERTMAT.Name = "IMG_ALERTMAT"
        Me.IMG_ALERTMAT.Size = New System.Drawing.Size(30, 30)
        Me.IMG_ALERTMAT.TabIndex = 37
        Me.IMG_ALERTMAT.TabStop = False
        Me.IMG_ALERTMAT.Visible = False
        '
        'LB_MATRICUL
        '
        Me.LB_MATRICUL.AutoSize = True
        Me.LB_MATRICUL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_MATRICUL.Location = New System.Drawing.Point(61, 36)
        Me.LB_MATRICUL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_MATRICUL.Name = "LB_MATRICUL"
        Me.LB_MATRICUL.Size = New System.Drawing.Size(65, 17)
        Me.LB_MATRICUL.TabIndex = 20
        Me.LB_MATRICUL.Text = "Matricule"
        '
        'TXT_MATRICUL
        '
        Me.TXT_MATRICUL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MATRICUL.Location = New System.Drawing.Point(249, 31)
        Me.TXT_MATRICUL.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_MATRICUL.Name = "TXT_MATRICUL"
        Me.TXT_MATRICUL.Size = New System.Drawing.Size(264, 26)
        Me.TXT_MATRICUL.TabIndex = 0
        '
        'TXT_MATRICULB
        '
        Me.TXT_MATRICULB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MATRICULB.Location = New System.Drawing.Point(249, 75)
        Me.TXT_MATRICULB.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_MATRICULB.Name = "TXT_MATRICULB"
        Me.TXT_MATRICULB.Size = New System.Drawing.Size(264, 26)
        Me.TXT_MATRICULB.TabIndex = 1
        '
        'TXT_PRENOMA
        '
        Me.TXT_PRENOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PRENOMA.Location = New System.Drawing.Point(249, 251)
        Me.TXT_PRENOMA.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_PRENOMA.Name = "TXT_PRENOMA"
        Me.TXT_PRENOMA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_PRENOMA.Size = New System.Drawing.Size(264, 26)
        Me.TXT_PRENOMA.TabIndex = 8
        '
        'TXT_NOMA
        '
        Me.TXT_NOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOMA.Location = New System.Drawing.Point(249, 163)
        Me.TXT_NOMA.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_NOMA.Name = "TXT_NOMA"
        Me.TXT_NOMA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_NOMA.Size = New System.Drawing.Size(264, 26)
        Me.TXT_NOMA.TabIndex = 9
        '
        'LB_NOMA
        '
        Me.LB_NOMA.AutoSize = True
        Me.LB_NOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_NOMA.Location = New System.Drawing.Point(61, 124)
        Me.LB_NOMA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_NOMA.Name = "LB_NOMA"
        Me.LB_NOMA.Size = New System.Drawing.Size(115, 17)
        Me.LB_NOMA.TabIndex = 32
        Me.LB_NOMA.Text = "Nom en Français"
        '
        'TXT_PRENOM
        '
        Me.TXT_PRENOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PRENOM.Location = New System.Drawing.Point(249, 207)
        Me.TXT_PRENOM.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_PRENOM.Name = "TXT_PRENOM"
        Me.TXT_PRENOM.Size = New System.Drawing.Size(264, 26)
        Me.TXT_PRENOM.TabIndex = 10
        '
        'LB_PRENOMA
        '
        Me.LB_PRENOMA.AutoSize = True
        Me.LB_PRENOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_PRENOMA.Location = New System.Drawing.Point(61, 256)
        Me.LB_PRENOMA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_PRENOMA.Name = "LB_PRENOMA"
        Me.LB_PRENOMA.Size = New System.Drawing.Size(119, 17)
        Me.LB_PRENOMA.TabIndex = 31
        Me.LB_PRENOMA.Text = "Prénom en Arabe"
        '
        'TXT_NOM
        '
        Me.TXT_NOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOM.Location = New System.Drawing.Point(249, 119)
        Me.TXT_NOM.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_NOM.Name = "TXT_NOM"
        Me.TXT_NOM.Size = New System.Drawing.Size(264, 26)
        Me.TXT_NOM.TabIndex = 11
        '
        'LB_SEXE
        '
        Me.LB_SEXE.AutoSize = True
        Me.LB_SEXE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_SEXE.Location = New System.Drawing.Point(72, 344)
        Me.LB_SEXE.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_SEXE.Name = "LB_SEXE"
        Me.LB_SEXE.Size = New System.Drawing.Size(39, 17)
        Me.LB_SEXE.TabIndex = 30
        Me.LB_SEXE.Text = "Sexe"
        '
        'DTP_DATEN
        '
        Me.DTP_DATEN.Checked = False
        Me.DTP_DATEN.CustomFormat = "dd/mm/yyyy"
        Me.DTP_DATEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_DATEN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_DATEN.Location = New System.Drawing.Point(249, 295)
        Me.DTP_DATEN.Margin = New System.Windows.Forms.Padding(2)
        Me.DTP_DATEN.Name = "DTP_DATEN"
        Me.DTP_DATEN.Size = New System.Drawing.Size(264, 26)
        Me.DTP_DATEN.TabIndex = 12
        '
        'CB_SEXE
        '
        Me.CB_SEXE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_SEXE.FormattingEnabled = True
        Me.CB_SEXE.Location = New System.Drawing.Point(249, 339)
        Me.CB_SEXE.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_SEXE.Name = "CB_SEXE"
        Me.CB_SEXE.Size = New System.Drawing.Size(154, 28)
        Me.CB_SEXE.TabIndex = 13
        '
        'LB_DATEN
        '
        Me.LB_DATEN.AutoSize = True
        Me.LB_DATEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_DATEN.Location = New System.Drawing.Point(61, 300)
        Me.LB_DATEN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_DATEN.Name = "LB_DATEN"
        Me.LB_DATEN.Size = New System.Drawing.Size(126, 17)
        Me.LB_DATEN.TabIndex = 25
        Me.LB_DATEN.Text = "Date de naissance"
        '
        'LB_MATRICULB
        '
        Me.LB_MATRICULB.AutoSize = True
        Me.LB_MATRICULB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_MATRICULB.Location = New System.Drawing.Point(61, 80)
        Me.LB_MATRICULB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_MATRICULB.Name = "LB_MATRICULB"
        Me.LB_MATRICULB.Size = New System.Drawing.Size(116, 17)
        Me.LB_MATRICULB.TabIndex = 21
        Me.LB_MATRICULB.Text = "Matricule de BAC"
        '
        'FlecheList
        '
        Me.FlecheList.ImageStream = CType(resources.GetObject("FlecheList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.FlecheList.TransparentColor = System.Drawing.Color.Transparent
        Me.FlecheList.Images.SetKeyName(0, "fleche ascendant.png")
        Me.FlecheList.Images.SetKeyName(1, "fleche decendant.png")
        '
        'SpliterMain
        '
        Me.SpliterMain.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton
        Me.SpliterMain.BackColor = System.Drawing.Color.Transparent
        Me.SpliterMain.Location = New System.Drawing.Point(21, 587)
        Me.SpliterMain.Name = "SpliterMain"
        Me.SpliterMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SpliterMain.Panel1
        '
        Me.SpliterMain.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SpliterMain.Panel2
        '
        Me.SpliterMain.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SpliterMain.Panel2MinSize = 0
        Me.SpliterMain.Size = New System.Drawing.Size(615, 418)
        Me.SpliterMain.SplitterDistance = 189
        Me.SpliterMain.TabIndex = 43
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ResidenceLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LB_WILAYA)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LB_WILAYANA)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CB_WILAYAN)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CB_WILAYANA)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CB_WILAYA)
        Me.SplitContainer1.Panel2MinSize = 0
        Me.SplitContainer1.Size = New System.Drawing.Size(615, 285)
        Me.SplitContainer1.SplitterDistance = 35
        Me.SplitContainer1.TabIndex = 54
        '
        'ResidenceLabel
        '
        Me.ResidenceLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResidenceLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ResidenceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ResidenceLabel.ImageIndex = 0
        Me.ResidenceLabel.ImageList = Me.FlecheList
        Me.ResidenceLabel.Location = New System.Drawing.Point(0, 0)
        Me.ResidenceLabel.Name = "ResidenceLabel"
        Me.ResidenceLabel.Size = New System.Drawing.Size(615, 35)
        Me.ResidenceLabel.TabIndex = 0
        Me.ResidenceLabel.Text = "     Informations sur la résidence"
        Me.ResidenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 21)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(210, 17)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Code de la Wilaya de naissance"
        '
        'LB_WILAYA
        '
        Me.LB_WILAYA.AutoSize = True
        Me.LB_WILAYA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_WILAYA.Location = New System.Drawing.Point(34, 115)
        Me.LB_WILAYA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_WILAYA.Name = "LB_WILAYA"
        Me.LB_WILAYA.Size = New System.Drawing.Size(103, 17)
        Me.LB_WILAYA.TabIndex = 68
        Me.LB_WILAYA.Text = "Wilaya actuelle"
        '
        'LB_WILAYANA
        '
        Me.LB_WILAYANA.AutoSize = True
        Me.LB_WILAYANA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_WILAYANA.Location = New System.Drawing.Point(34, 63)
        Me.LB_WILAYANA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_WILAYANA.Name = "LB_WILAYANA"
        Me.LB_WILAYANA.Size = New System.Drawing.Size(200, 17)
        Me.LB_WILAYANA.TabIndex = 65
        Me.LB_WILAYANA.Text = "Wilaya de naissance en Arabe"
        '
        'CB_WILAYAN
        '
        Me.CB_WILAYAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_WILAYAN.FormattingEnabled = True
        Me.CB_WILAYAN.Location = New System.Drawing.Point(254, 14)
        Me.CB_WILAYAN.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_WILAYAN.Name = "CB_WILAYAN"
        Me.CB_WILAYAN.Size = New System.Drawing.Size(264, 28)
        Me.CB_WILAYAN.TabIndex = 59
        '
        'CB_WILAYANA
        '
        Me.CB_WILAYANA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_WILAYANA.FormattingEnabled = True
        Me.CB_WILAYANA.Location = New System.Drawing.Point(254, 63)
        Me.CB_WILAYANA.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_WILAYANA.Name = "CB_WILAYANA"
        Me.CB_WILAYANA.Size = New System.Drawing.Size(264, 28)
        Me.CB_WILAYANA.TabIndex = 60
        '
        'CB_WILAYA
        '
        Me.CB_WILAYA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_WILAYA.FormattingEnabled = True
        Me.CB_WILAYA.Location = New System.Drawing.Point(254, 110)
        Me.CB_WILAYA.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_WILAYA.Name = "CB_WILAYA"
        Me.CB_WILAYA.Size = New System.Drawing.Size(264, 28)
        Me.CB_WILAYA.TabIndex = 61
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.BACLabel)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.IMG_ALERTMOY)
        Me.SplitContainer2.Panel2.Controls.Add(Me.CB_ANNEEB)
        Me.SplitContainer2.Panel2.Controls.Add(Me.LB_SERI)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TXT_MOYBAC)
        Me.SplitContainer2.Panel2.Controls.Add(Me.LB_WILAYAB)
        Me.SplitContainer2.Panel2.Controls.Add(Me.CB_SERI)
        Me.SplitContainer2.Panel2.Controls.Add(Me.LB_MOYBAC)
        Me.SplitContainer2.Panel2.Controls.Add(Me.CB_WILAYAB)
        Me.SplitContainer2.Panel2.Controls.Add(Me.LB_ANNEEB)
        Me.SplitContainer2.Panel2MinSize = 0
        Me.SplitContainer2.Size = New System.Drawing.Size(615, 222)
        Me.SplitContainer2.SplitterDistance = 25
        Me.SplitContainer2.TabIndex = 48
        '
        'BACLabel
        '
        Me.BACLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.BACLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BACLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.BACLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BACLabel.ImageIndex = 0
        Me.BACLabel.ImageList = Me.FlecheList
        Me.BACLabel.Location = New System.Drawing.Point(0, 0)
        Me.BACLabel.Name = "BACLabel"
        Me.BACLabel.Size = New System.Drawing.Size(615, 30)
        Me.BACLabel.TabIndex = 1
        Me.BACLabel.Text = "     Informations sur le BAC"
        Me.BACLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IMG_ALERTMOY
        '
        Me.IMG_ALERTMOY.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.alert1
        Me.IMG_ALERTMOY.Location = New System.Drawing.Point(534, 54)
        Me.IMG_ALERTMOY.Name = "IMG_ALERTMOY"
        Me.IMG_ALERTMOY.Size = New System.Drawing.Size(30, 30)
        Me.IMG_ALERTMOY.TabIndex = 48
        Me.IMG_ALERTMOY.TabStop = False
        Me.IMG_ALERTMOY.Visible = False
        '
        'CB_ANNEEB
        '
        Me.CB_ANNEEB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ANNEEB.FormattingEnabled = True
        Me.CB_ANNEEB.Location = New System.Drawing.Point(254, 148)
        Me.CB_ANNEEB.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_ANNEEB.Name = "CB_ANNEEB"
        Me.CB_ANNEEB.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CB_ANNEEB.Size = New System.Drawing.Size(264, 28)
        Me.CB_ANNEEB.TabIndex = 42
        '
        'LB_SERI
        '
        Me.LB_SERI.AutoSize = True
        Me.LB_SERI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_SERI.Location = New System.Drawing.Point(34, 103)
        Me.LB_SERI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_SERI.Name = "LB_SERI"
        Me.LB_SERI.Size = New System.Drawing.Size(92, 17)
        Me.LB_SERI.TabIndex = 47
        Me.LB_SERI.Text = "Série de BAC"
        '
        'TXT_MOYBAC
        '
        Me.TXT_MOYBAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MOYBAC.Location = New System.Drawing.Point(254, 58)
        Me.TXT_MOYBAC.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_MOYBAC.Name = "TXT_MOYBAC"
        Me.TXT_MOYBAC.Size = New System.Drawing.Size(264, 26)
        Me.TXT_MOYBAC.TabIndex = 40
        '
        'LB_WILAYAB
        '
        Me.LB_WILAYAB.AutoSize = True
        Me.LB_WILAYAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_WILAYAB.Location = New System.Drawing.Point(34, 13)
        Me.LB_WILAYAB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_WILAYAB.Name = "LB_WILAYAB"
        Me.LB_WILAYAB.Size = New System.Drawing.Size(101, 17)
        Me.LB_WILAYAB.TabIndex = 46
        Me.LB_WILAYAB.Text = "Wilaya de BAC"
        '
        'CB_SERI
        '
        Me.CB_SERI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_SERI.FormattingEnabled = True
        Me.CB_SERI.Location = New System.Drawing.Point(254, 103)
        Me.CB_SERI.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_SERI.Name = "CB_SERI"
        Me.CB_SERI.Size = New System.Drawing.Size(264, 28)
        Me.CB_SERI.TabIndex = 41
        '
        'LB_MOYBAC
        '
        Me.LB_MOYBAC.AutoSize = True
        Me.LB_MOYBAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_MOYBAC.Location = New System.Drawing.Point(34, 58)
        Me.LB_MOYBAC.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_MOYBAC.Name = "LB_MOYBAC"
        Me.LB_MOYBAC.Size = New System.Drawing.Size(117, 17)
        Me.LB_MOYBAC.TabIndex = 45
        Me.LB_MOYBAC.Text = "Moyenne de BAC"
        '
        'CB_WILAYAB
        '
        Me.CB_WILAYAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_WILAYAB.FormattingEnabled = True
        Me.CB_WILAYAB.Location = New System.Drawing.Point(254, 13)
        Me.CB_WILAYAB.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_WILAYAB.Name = "CB_WILAYAB"
        Me.CB_WILAYAB.Size = New System.Drawing.Size(264, 28)
        Me.CB_WILAYAB.TabIndex = 43
        '
        'LB_ANNEEB
        '
        Me.LB_ANNEEB.AutoSize = True
        Me.LB_ANNEEB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ANNEEB.Location = New System.Drawing.Point(34, 148)
        Me.LB_ANNEEB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_ANNEEB.Name = "LB_ANNEEB"
        Me.LB_ANNEEB.Size = New System.Drawing.Size(100, 17)
        Me.LB_ANNEEB.TabIndex = 44
        Me.LB_ANNEEB.Text = "Année de BAC"
        '
        'PN_FORUMRECH
        '
        Me.PN_FORUMRECH.AutoScroll = True
        Me.PN_FORUMRECH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PN_FORUMRECH.BackColor = System.Drawing.Color.Transparent
        Me.PN_FORUMRECH.Controls.Add(Me.RechIntroPanel)
        Me.PN_FORUMRECH.Controls.Add(Me.RechButtons)
        Me.PN_FORUMRECH.Controls.Add(Me.generalesGroupBox)
        Me.PN_FORUMRECH.Controls.Add(Me.SpliterMain)
        Me.PN_FORUMRECH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PN_FORUMRECH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PN_FORUMRECH.Location = New System.Drawing.Point(0, 0)
        Me.PN_FORUMRECH.Margin = New System.Windows.Forms.Padding(0)
        Me.PN_FORUMRECH.Name = "PN_FORUMRECH"
        Me.PN_FORUMRECH.Size = New System.Drawing.Size(679, 640)
        Me.PN_FORUMRECH.TabIndex = 11
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'TXT_NOMA_ALERT
        '
        Me.TXT_NOMA_ALERT.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.alert1
        Me.TXT_NOMA_ALERT.Location = New System.Drawing.Point(518, 159)
        Me.TXT_NOMA_ALERT.Name = "TXT_NOMA_ALERT"
        Me.TXT_NOMA_ALERT.Size = New System.Drawing.Size(30, 30)
        Me.TXT_NOMA_ALERT.TabIndex = 47
        Me.TXT_NOMA_ALERT.TabStop = False
        Me.TXT_NOMA_ALERT.Visible = False
        '
        'TXT_PRENOM_ALERT
        '
        Me.TXT_PRENOM_ALERT.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.alert1
        Me.TXT_PRENOM_ALERT.Location = New System.Drawing.Point(518, 203)
        Me.TXT_PRENOM_ALERT.Name = "TXT_PRENOM_ALERT"
        Me.TXT_PRENOM_ALERT.Size = New System.Drawing.Size(30, 30)
        Me.TXT_PRENOM_ALERT.TabIndex = 48
        Me.TXT_PRENOM_ALERT.TabStop = False
        Me.TXT_PRENOM_ALERT.Visible = False
        '
        'TXT_PRENOMA_ALERT
        '
        Me.TXT_PRENOMA_ALERT.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.alert1
        Me.TXT_PRENOMA_ALERT.Location = New System.Drawing.Point(518, 249)
        Me.TXT_PRENOMA_ALERT.Name = "TXT_PRENOMA_ALERT"
        Me.TXT_PRENOMA_ALERT.Size = New System.Drawing.Size(30, 30)
        Me.TXT_PRENOMA_ALERT.TabIndex = 49
        Me.TXT_PRENOMA_ALERT.TabStop = False
        Me.TXT_PRENOMA_ALERT.Visible = False
        '
        'TXT_NOM_ALERT
        '
        Me.TXT_NOM_ALERT.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.alert1
        Me.TXT_NOM_ALERT.Location = New System.Drawing.Point(518, 115)
        Me.TXT_NOM_ALERT.Name = "TXT_NOM_ALERT"
        Me.TXT_NOM_ALERT.Size = New System.Drawing.Size(30, 30)
        Me.TXT_NOM_ALERT.TabIndex = 50
        Me.TXT_NOM_ALERT.TabStop = False
        Me.TXT_NOM_ALERT.Visible = False
        '
        'RechercherPage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(679, 640)
        Me.Controls.Add(Me.PN_FORUMRECH)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 595)
        Me.Name = "RechercherPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.RechIntroPanel.ResumeLayout(False)
        Me.RechIntroPanel.PerformLayout()
        Me.RechButtons.ResumeLayout(False)
        Me.RechButtons.PerformLayout()
        Me.generalesGroupBox.ResumeLayout(False)
        Me.generalesGroupBox.PerformLayout()
        CType(Me.IMG_ALERTMTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMG_ALERTMAT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SpliterMain.Panel1.ResumeLayout(False)
        Me.SpliterMain.Panel2.ResumeLayout(False)
        CType(Me.SpliterMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SpliterMain.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.IMG_ALERTMOY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PN_FORUMRECH.ResumeLayout(False)
        CType(Me.TXT_NOMA_ALERT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_PRENOM_ALERT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_PRENOMA_ALERT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_NOM_ALERT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RechIntroPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RechButtons As System.Windows.Forms.Panel
    Friend WithEvents BT_LANCERRECH As System.Windows.Forms.Button
    Friend WithEvents generalesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents LB_MATRICUL As System.Windows.Forms.Label
    Friend WithEvents TXT_MATRICUL As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MATRICULB As System.Windows.Forms.TextBox
    Friend WithEvents TXT_PRENOMA As System.Windows.Forms.TextBox
    Friend WithEvents TXT_NOMA As System.Windows.Forms.TextBox
    Friend WithEvents LB_NOMA As System.Windows.Forms.Label
    Friend WithEvents TXT_PRENOM As System.Windows.Forms.TextBox
    Friend WithEvents LB_PRENOMA As System.Windows.Forms.Label
    Friend WithEvents TXT_NOM As System.Windows.Forms.TextBox
    Friend WithEvents LB_SEXE As System.Windows.Forms.Label
    Friend WithEvents DTP_DATEN As System.Windows.Forms.DateTimePicker
    Friend WithEvents CB_SEXE As System.Windows.Forms.ComboBox
    Friend WithEvents LB_DATEN As System.Windows.Forms.Label
    Friend WithEvents LB_MATRICULB As System.Windows.Forms.Label
    Friend WithEvents SpliterMain As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ResidenceLabel As System.Windows.Forms.Label
    Friend WithEvents LB_WILAYA As System.Windows.Forms.Label
    Friend WithEvents LB_WILAYANA As System.Windows.Forms.Label
    Friend WithEvents CB_WILAYAN As System.Windows.Forms.ComboBox
    Friend WithEvents CB_WILAYANA As System.Windows.Forms.ComboBox
    Friend WithEvents CB_WILAYA As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents BACLabel As System.Windows.Forms.Label
    Friend WithEvents CB_ANNEEB As System.Windows.Forms.ComboBox
    Friend WithEvents LB_SERI As System.Windows.Forms.Label
    Friend WithEvents TXT_MOYBAC As System.Windows.Forms.TextBox
    Friend WithEvents LB_WILAYAB As System.Windows.Forms.Label
    Friend WithEvents CB_SERI As System.Windows.Forms.ComboBox
    Friend WithEvents LB_MOYBAC As System.Windows.Forms.Label
    Friend WithEvents CB_WILAYAB As System.Windows.Forms.ComboBox
    Friend WithEvents LB_ANNEEB As System.Windows.Forms.Label
    Friend WithEvents PN_FORUMRECH As System.Windows.Forms.Panel
    Friend WithEvents FlecheList As System.Windows.Forms.ImageList
    Friend WithEvents worningrech As System.Windows.Forms.Label
    Friend WithEvents IMG_ALERTMAT As System.Windows.Forms.PictureBox
    Friend WithEvents IMG_ALERTMTB As System.Windows.Forms.PictureBox
    Friend WithEvents IMG_ALERTMOY As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT_MERE As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_PERE As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CB_ANNEE As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXT_NOM_ALERT As System.Windows.Forms.PictureBox
    Friend WithEvents TXT_PRENOMA_ALERT As System.Windows.Forms.PictureBox
    Friend WithEvents TXT_PRENOM_ALERT As System.Windows.Forms.PictureBox
    Friend WithEvents TXT_NOMA_ALERT As System.Windows.Forms.PictureBox
    Friend WithEvents AvertToolTip As System.Windows.Forms.ToolTip
End Class
