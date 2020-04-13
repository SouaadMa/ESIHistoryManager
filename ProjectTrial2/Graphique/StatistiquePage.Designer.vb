<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.StatistiquesPanel = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CHB_ANNEE = New System.Windows.Forms.CheckedListBox()
        Me.TXT_MOYSEUIL = New System.Windows.Forms.TextBox()
        Me.CHB_PROMO = New System.Windows.Forms.CheckedListBox()
        Me.CHB_SECTION = New System.Windows.Forms.CheckedListBox()
        Me.CHB_GROUPE = New System.Windows.Forms.CheckedListBox()
        Me.CHB_MAT = New System.Windows.Forms.CheckedListBox()
        Me.CHB_SPECIALITE = New System.Windows.Forms.CheckedListBox()
        Me.CB_CRITERE = New System.Windows.Forms.ComboBox()
        Me.BT_NEXT = New System.Windows.Forms.Button()
        Me.BT_PREV = New System.Windows.Forms.Button()
        Me.BT_CHARTLOAD = New System.Windows.Forms.Button()
        Me.CB_CHARTKIND = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatistiquesPanel.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatistiquesPanel
        '
        Me.StatistiquesPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.StatistiquesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StatistiquesPanel.BackColor = System.Drawing.Color.Transparent
        Me.StatistiquesPanel.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.StatistiquesPanel.Controls.Add(Me.Chart1)
        Me.StatistiquesPanel.Controls.Add(Me.Panel2)
        Me.StatistiquesPanel.Controls.Add(Me.BT_NEXT)
        Me.StatistiquesPanel.Controls.Add(Me.BT_PREV)
        Me.StatistiquesPanel.Controls.Add(Me.BT_CHARTLOAD)
        Me.StatistiquesPanel.Controls.Add(Me.CB_CHARTKIND)
        Me.StatistiquesPanel.Controls.Add(Me.Panel1)
        Me.StatistiquesPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatistiquesPanel.Location = New System.Drawing.Point(0, 0)
        Me.StatistiquesPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.StatistiquesPanel.Name = "StatistiquesPanel"
        Me.StatistiquesPanel.Size = New System.Drawing.Size(678, 640)
        Me.StatistiquesPanel.TabIndex = 12
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BackImage = "C:\Users\hadia\Desktop\projet 2CP\chart back.png"
        ChartArea8.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea8)
        Legend8.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend8)
        Me.Chart1.Location = New System.Drawing.Point(104, 248)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(470, 320)
        Me.Chart1.TabIndex = 12
        Me.Chart1.Text = "Chart1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.CHB_ANNEE)
        Me.Panel2.Controls.Add(Me.TXT_MOYSEUIL)
        Me.Panel2.Controls.Add(Me.CHB_PROMO)
        Me.Panel2.Controls.Add(Me.CHB_SECTION)
        Me.Panel2.Controls.Add(Me.CHB_GROUPE)
        Me.Panel2.Controls.Add(Me.CHB_MAT)
        Me.Panel2.Controls.Add(Me.CHB_SPECIALITE)
        Me.Panel2.Controls.Add(Me.CB_CRITERE)
        Me.Panel2.Location = New System.Drawing.Point(0, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(675, 176)
        Me.Panel2.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(288, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 20)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Moyenne de seuil"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(491, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 20)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Groupe"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 20)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Annee d'etude"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(491, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Promo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(288, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Matiere"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(288, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Specialite"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(491, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Section"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Critere des statistiques"
        '
        'CHB_ANNEE
        '
        Me.CHB_ANNEE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CHB_ANNEE.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHB_ANNEE.FormattingEnabled = True
        Me.CHB_ANNEE.Location = New System.Drawing.Point(34, 101)
        Me.CHB_ANNEE.Name = "CHB_ANNEE"
        Me.CHB_ANNEE.Size = New System.Drawing.Size(161, 26)
        Me.CHB_ANNEE.Sorted = True
        Me.CHB_ANNEE.TabIndex = 21
        '
        'TXT_MOYSEUIL
        '
        Me.TXT_MOYSEUIL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_MOYSEUIL.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MOYSEUIL.Location = New System.Drawing.Point(292, 142)
        Me.TXT_MOYSEUIL.Name = "TXT_MOYSEUIL"
        Me.TXT_MOYSEUIL.Size = New System.Drawing.Size(150, 24)
        Me.TXT_MOYSEUIL.TabIndex = 20
        '
        'CHB_PROMO
        '
        Me.CHB_PROMO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CHB_PROMO.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHB_PROMO.FormattingEnabled = True
        Me.CHB_PROMO.Location = New System.Drawing.Point(495, 28)
        Me.CHB_PROMO.Name = "CHB_PROMO"
        Me.CHB_PROMO.Size = New System.Drawing.Size(150, 26)
        Me.CHB_PROMO.Sorted = True
        Me.CHB_PROMO.TabIndex = 19
        '
        'CHB_SECTION
        '
        Me.CHB_SECTION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CHB_SECTION.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHB_SECTION.FormattingEnabled = True
        Me.CHB_SECTION.Location = New System.Drawing.Point(495, 84)
        Me.CHB_SECTION.Name = "CHB_SECTION"
        Me.CHB_SECTION.Size = New System.Drawing.Size(150, 26)
        Me.CHB_SECTION.Sorted = True
        Me.CHB_SECTION.TabIndex = 18
        '
        'CHB_GROUPE
        '
        Me.CHB_GROUPE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CHB_GROUPE.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHB_GROUPE.FormattingEnabled = True
        Me.CHB_GROUPE.Location = New System.Drawing.Point(495, 140)
        Me.CHB_GROUPE.Name = "CHB_GROUPE"
        Me.CHB_GROUPE.Size = New System.Drawing.Size(150, 26)
        Me.CHB_GROUPE.Sorted = True
        Me.CHB_GROUPE.TabIndex = 17
        '
        'CHB_MAT
        '
        Me.CHB_MAT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CHB_MAT.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHB_MAT.FormattingEnabled = True
        Me.CHB_MAT.Location = New System.Drawing.Point(292, 28)
        Me.CHB_MAT.Name = "CHB_MAT"
        Me.CHB_MAT.Size = New System.Drawing.Size(150, 26)
        Me.CHB_MAT.Sorted = True
        Me.CHB_MAT.TabIndex = 16
        '
        'CHB_SPECIALITE
        '
        Me.CHB_SPECIALITE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CHB_SPECIALITE.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHB_SPECIALITE.FormattingEnabled = True
        Me.CHB_SPECIALITE.Location = New System.Drawing.Point(292, 84)
        Me.CHB_SPECIALITE.Name = "CHB_SPECIALITE"
        Me.CHB_SPECIALITE.Size = New System.Drawing.Size(150, 26)
        Me.CHB_SPECIALITE.Sorted = True
        Me.CHB_SPECIALITE.TabIndex = 14
        '
        'CB_CRITERE
        '
        Me.CB_CRITERE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_CRITERE.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_CRITERE.FormattingEnabled = True
        Me.CB_CRITERE.Location = New System.Drawing.Point(34, 28)
        Me.CB_CRITERE.Name = "CB_CRITERE"
        Me.CB_CRITERE.Size = New System.Drawing.Size(235, 31)
        Me.CB_CRITERE.TabIndex = 2
        '
        'BT_NEXT
        '
        Me.BT_NEXT.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources._next
        Me.BT_NEXT.FlatAppearance.BorderSize = 0
        Me.BT_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_NEXT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BT_NEXT.Location = New System.Drawing.Point(610, 392)
        Me.BT_NEXT.Name = "BT_NEXT"
        Me.BT_NEXT.Size = New System.Drawing.Size(35, 35)
        Me.BT_NEXT.TabIndex = 9
        Me.BT_NEXT.Text = " "
        Me.BT_NEXT.UseVisualStyleBackColor = True
        '
        'BT_PREV
        '
        Me.BT_PREV.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.prev1
        Me.BT_PREV.FlatAppearance.BorderSize = 0
        Me.BT_PREV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_PREV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BT_PREV.Location = New System.Drawing.Point(33, 392)
        Me.BT_PREV.Name = "BT_PREV"
        Me.BT_PREV.Size = New System.Drawing.Size(35, 35)
        Me.BT_PREV.TabIndex = 8
        Me.BT_PREV.Text = " "
        Me.BT_PREV.UseVisualStyleBackColor = True
        '
        'BT_CHARTLOAD
        '
        Me.BT_CHARTLOAD.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BT_CHARTLOAD.FlatAppearance.BorderSize = 0
        Me.BT_CHARTLOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CHARTLOAD.Font = New System.Drawing.Font("Cambria", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CHARTLOAD.ForeColor = System.Drawing.Color.White
        Me.BT_CHARTLOAD.Location = New System.Drawing.Point(259, 584)
        Me.BT_CHARTLOAD.Name = "BT_CHARTLOAD"
        Me.BT_CHARTLOAD.Size = New System.Drawing.Size(160, 33)
        Me.BT_CHARTLOAD.TabIndex = 7
        Me.BT_CHARTLOAD.Text = " Load "
        Me.BT_CHARTLOAD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_CHARTLOAD.UseVisualStyleBackColor = False
        '
        'CB_CHARTKIND
        '
        Me.CB_CHARTKIND.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_CHARTKIND.FormattingEnabled = True
        Me.CB_CHARTKIND.Location = New System.Drawing.Point(259, 584)
        Me.CB_CHARTKIND.Name = "CB_CHARTKIND"
        Me.CB_CHARTKIND.Size = New System.Drawing.Size(160, 33)
        Me.CB_CHARTKIND.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 55)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(211, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 32)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Faire des statistiques"
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
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StatistiquesPanel As System.Windows.Forms.Panel
    Friend WithEvents BT_CHARTLOAD As System.Windows.Forms.Button
    Friend WithEvents CB_CHARTKIND As System.Windows.Forms.ComboBox
    Friend WithEvents CB_CRITERE As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BT_NEXT As System.Windows.Forms.Button
    Friend WithEvents BT_PREV As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents CHB_PROMO As System.Windows.Forms.CheckedListBox
    Friend WithEvents CHB_SECTION As System.Windows.Forms.CheckedListBox
    Friend WithEvents CHB_GROUPE As System.Windows.Forms.CheckedListBox
    Friend WithEvents CHB_MAT As System.Windows.Forms.CheckedListBox
    Friend WithEvents CHB_SPECIALITE As System.Windows.Forms.CheckedListBox
    Friend WithEvents TXT_MOYSEUIL As System.Windows.Forms.TextBox
    Friend WithEvents CHB_ANNEE As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
