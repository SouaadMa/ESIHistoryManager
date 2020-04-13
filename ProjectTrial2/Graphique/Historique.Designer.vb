<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historique
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
        Me.BT_SORTIR = New System.Windows.Forms.Button()
        Me.DetailPanel = New System.Windows.Forms.Panel()
        Me.TPN_HISTO = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LB_SPECOMPLET = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LB_DECRANG = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LB_MATRIN = New System.Windows.Forms.Label()
        Me.LB_DATENAIS = New System.Windows.Forms.Label()
        Me.LB_PRENOM = New System.Windows.Forms.Label()
        Me.LB_NOM = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BT_ANNEE = New System.Windows.Forms.Button()
        Me.CB_ANNEE = New System.Windows.Forms.ComboBox()
        Me.BT_PREV = New System.Windows.Forms.Button()
        Me.BT_NEXT = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DetailPanel.SuspendLayout()
        Me.TPN_HISTO.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BT_SORTIR
        '
        Me.BT_SORTIR.BackColor = System.Drawing.Color.Transparent
        Me.BT_SORTIR.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.sortiropp1
        Me.BT_SORTIR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_SORTIR.FlatAppearance.BorderSize = 0
        Me.BT_SORTIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SORTIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_SORTIR.ForeColor = System.Drawing.Color.White
        Me.BT_SORTIR.Location = New System.Drawing.Point(608, 5)
        Me.BT_SORTIR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 100)
        Me.BT_SORTIR.Name = "BT_SORTIR"
        Me.BT_SORTIR.Size = New System.Drawing.Size(45, 45)
        Me.BT_SORTIR.TabIndex = 41
        Me.BT_SORTIR.UseVisualStyleBackColor = False
        '
        'DetailPanel
        '
        Me.DetailPanel.BackColor = System.Drawing.Color.Transparent
        Me.DetailPanel.Controls.Add(Me.TPN_HISTO)
        Me.DetailPanel.Controls.Add(Me.Panel2)
        Me.DetailPanel.Controls.Add(Me.BT_ANNEE)
        Me.DetailPanel.Controls.Add(Me.CB_ANNEE)
        Me.DetailPanel.Controls.Add(Me.BT_PREV)
        Me.DetailPanel.Controls.Add(Me.BT_NEXT)
        Me.DetailPanel.Controls.Add(Me.Panel1)
        Me.DetailPanel.Location = New System.Drawing.Point(0, 0)
        Me.DetailPanel.Name = "DetailPanel"
        Me.DetailPanel.Size = New System.Drawing.Size(678, 640)
        Me.DetailPanel.TabIndex = 87
        '
        'TPN_HISTO
        '
        Me.TPN_HISTO.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.histoback1
        Me.TPN_HISTO.ColumnCount = 1
        Me.TPN_HISTO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TPN_HISTO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TPN_HISTO.Controls.Add(Me.Panel3, 0, 0)
        Me.TPN_HISTO.Controls.Add(Me.Panel4, 0, 2)
        Me.TPN_HISTO.Location = New System.Drawing.Point(52, 150)
        Me.TPN_HISTO.Name = "TPN_HISTO"
        Me.TPN_HISTO.RowCount = 3
        Me.TPN_HISTO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.22444!))
        Me.TPN_HISTO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.77556!))
        Me.TPN_HISTO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TPN_HISTO.Size = New System.Drawing.Size(575, 440)
        Me.TPN_HISTO.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LB_SPECOMPLET)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(569, 34)
        Me.Panel3.TabIndex = 0
        '
        'LB_SPECOMPLET
        '
        Me.LB_SPECOMPLET.AutoSize = True
        Me.LB_SPECOMPLET.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_SPECOMPLET.Location = New System.Drawing.Point(147, 7)
        Me.LB_SPECOMPLET.Name = "LB_SPECOMPLET"
        Me.LB_SPECOMPLET.Size = New System.Drawing.Size(274, 20)
        Me.LB_SPECOMPLET.TabIndex = 4
        Me.LB_SPECOMPLET.Text = "Nom annee d'etude plus specialite"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.LB_DECRANG)
        Me.Panel4.Location = New System.Drawing.Point(3, 402)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(569, 35)
        Me.Panel4.TabIndex = 1
        '
        'LB_DECRANG
        '
        Me.LB_DECRANG.AutoSize = True
        Me.LB_DECRANG.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_DECRANG.Location = New System.Drawing.Point(222, 6)
        Me.LB_DECRANG.Name = "LB_DECRANG"
        Me.LB_DECRANG.Size = New System.Drawing.Size(124, 20)
        Me.LB_DECRANG.TabIndex = 5
        Me.LB_DECRANG.Text = "decision +rang"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LB_MATRIN)
        Me.Panel2.Controls.Add(Me.LB_DATENAIS)
        Me.Panel2.Controls.Add(Me.LB_PRENOM)
        Me.Panel2.Controls.Add(Me.LB_NOM)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(678, 88)
        Me.Panel2.TabIndex = 47
        '
        'LB_MATRIN
        '
        Me.LB_MATRIN.AutoSize = True
        Me.LB_MATRIN.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_MATRIN.Location = New System.Drawing.Point(474, 55)
        Me.LB_MATRIN.Name = "LB_MATRIN"
        Me.LB_MATRIN.Size = New System.Drawing.Size(87, 20)
        Me.LB_MATRIN.TabIndex = 7
        Me.LB_MATRIN.Text = "Matricule "
        '
        'LB_DATENAIS
        '
        Me.LB_DATENAIS.AutoSize = True
        Me.LB_DATENAIS.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_DATENAIS.Location = New System.Drawing.Point(205, 55)
        Me.LB_DATENAIS.Name = "LB_DATENAIS"
        Me.LB_DATENAIS.Size = New System.Drawing.Size(152, 20)
        Me.LB_DATENAIS.TabIndex = 6
        Me.LB_DATENAIS.Text = "Date de naissance "
        '
        'LB_PRENOM
        '
        Me.LB_PRENOM.AutoSize = True
        Me.LB_PRENOM.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_PRENOM.Location = New System.Drawing.Point(474, 15)
        Me.LB_PRENOM.Name = "LB_PRENOM"
        Me.LB_PRENOM.Size = New System.Drawing.Size(75, 20)
        Me.LB_PRENOM.TabIndex = 5
        Me.LB_PRENOM.Text = "Prenom "
        '
        'LB_NOM
        '
        Me.LB_NOM.AutoSize = True
        Me.LB_NOM.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_NOM.Location = New System.Drawing.Point(205, 15)
        Me.LB_NOM.Name = "LB_NOM"
        Me.LB_NOM.Size = New System.Drawing.Size(50, 20)
        Me.LB_NOM.TabIndex = 4
        Me.LB_NOM.Text = "Nom "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(379, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Matricule :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Date de naissance :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(379, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Prenom :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nom :"
        '
        'BT_ANNEE
        '
        Me.BT_ANNEE.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BT_ANNEE.FlatAppearance.BorderSize = 0
        Me.BT_ANNEE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_ANNEE.Font = New System.Drawing.Font("Cambria", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ANNEE.ForeColor = System.Drawing.Color.White
        Me.BT_ANNEE.Location = New System.Drawing.Point(258, 595)
        Me.BT_ANNEE.Name = "BT_ANNEE"
        Me.BT_ANNEE.Size = New System.Drawing.Size(160, 33)
        Me.BT_ANNEE.TabIndex = 45
        Me.BT_ANNEE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_ANNEE.UseVisualStyleBackColor = False
        '
        'CB_ANNEE
        '
        Me.CB_ANNEE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_ANNEE.FormattingEnabled = True
        Me.CB_ANNEE.Location = New System.Drawing.Point(259, 599)
        Me.CB_ANNEE.Name = "CB_ANNEE"
        Me.CB_ANNEE.Size = New System.Drawing.Size(160, 24)
        Me.CB_ANNEE.TabIndex = 46
        '
        'BT_PREV
        '
        Me.BT_PREV.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.prev1
        Me.BT_PREV.FlatAppearance.BorderSize = 0
        Me.BT_PREV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_PREV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BT_PREV.Location = New System.Drawing.Point(12, 354)
        Me.BT_PREV.Name = "BT_PREV"
        Me.BT_PREV.Size = New System.Drawing.Size(35, 35)
        Me.BT_PREV.TabIndex = 44
        Me.BT_PREV.Text = " "
        Me.BT_PREV.UseVisualStyleBackColor = True
        '
        'BT_NEXT
        '
        Me.BT_NEXT.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources._next
        Me.BT_NEXT.FlatAppearance.BorderSize = 0
        Me.BT_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_NEXT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BT_NEXT.Location = New System.Drawing.Point(632, 354)
        Me.BT_NEXT.Name = "BT_NEXT"
        Me.BT_NEXT.Size = New System.Drawing.Size(35, 35)
        Me.BT_NEXT.TabIndex = 43
        Me.BT_NEXT.Text = " "
        Me.BT_NEXT.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BT_SORTIR)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 55)
        Me.Panel1.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(150, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 32)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Historique de l'etudiant"
        '
        'Historique
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(678, 640)
        Me.Controls.Add(Me.DetailPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 595)
        Me.Name = "Historique"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.DetailPanel.ResumeLayout(False)
        Me.TPN_HISTO.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BT_SORTIR As System.Windows.Forms.Button
    Friend WithEvents DetailPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BT_NEXT As System.Windows.Forms.Button
    Friend WithEvents BT_PREV As System.Windows.Forms.Button
    Friend WithEvents BT_ANNEE As System.Windows.Forms.Button
    Friend WithEvents CB_ANNEE As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TPN_HISTO As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LB_SPECOMPLET As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LB_DECRANG As System.Windows.Forms.Label
    Friend WithEvents LB_MATRIN As System.Windows.Forms.Label
    Friend WithEvents LB_DATENAIS As System.Windows.Forms.Label
    Friend WithEvents LB_PRENOM As System.Windows.Forms.Label
    Friend WithEvents LB_NOM As System.Windows.Forms.Label
End Class
