<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PVPage
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
        Me.RechIntroPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PN_FORUMRECH = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AffichButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PromoBox = New System.Windows.Forms.ComboBox()
        Me.NiveauBox = New System.Windows.Forms.ComboBox()
        Me.SpecialiteBox = New System.Windows.Forms.ComboBox()
        Me.RechIntroPanel.SuspendLayout()
        Me.PN_FORUMRECH.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RechIntroPanel
        '
        Me.RechIntroPanel.Controls.Add(Me.Label1)
        Me.RechIntroPanel.Location = New System.Drawing.Point(0, 0)
        Me.RechIntroPanel.Name = "RechIntroPanel"
        Me.RechIntroPanel.Size = New System.Drawing.Size(675, 50)
        Me.RechIntroPanel.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 28.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(299, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 44)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "PV"
        '
        'PN_FORUMRECH
        '
        Me.PN_FORUMRECH.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PN_FORUMRECH.AutoScroll = True
        Me.PN_FORUMRECH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PN_FORUMRECH.BackColor = System.Drawing.Color.Transparent
        Me.PN_FORUMRECH.Controls.Add(Me.Panel2)
        Me.PN_FORUMRECH.Controls.Add(Me.Panel1)
        Me.PN_FORUMRECH.Controls.Add(Me.RechIntroPanel)
        Me.PN_FORUMRECH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PN_FORUMRECH.Location = New System.Drawing.Point(1, 0)
        Me.PN_FORUMRECH.Margin = New System.Windows.Forms.Padding(0)
        Me.PN_FORUMRECH.Name = "PN_FORUMRECH"
        Me.PN_FORUMRECH.Size = New System.Drawing.Size(675, 638)
        Me.PN_FORUMRECH.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.Panel2.Location = New System.Drawing.Point(0, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(675, 531)
        Me.Panel2.TabIndex = 48
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(675, 531)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AffichButton)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ComboBox4)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PromoBox)
        Me.Panel1.Controls.Add(Me.NiveauBox)
        Me.Panel1.Controls.Add(Me.SpecialiteBox)
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 57)
        Me.Panel1.TabIndex = 47
        '
        'AffichButton
        '
        Me.AffichButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.AffichButton.FlatAppearance.BorderSize = 0
        Me.AffichButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AffichButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AffichButton.Location = New System.Drawing.Point(529, 17)
        Me.AffichButton.Name = "AffichButton"
        Me.AffichButton.Size = New System.Drawing.Size(91, 28)
        Me.AffichButton.TabIndex = 0
        Me.AffichButton.Text = "Afficher"
        Me.AffichButton.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(369, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Limite D'affichage"
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(373, 29)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(30, 0, 50, 0)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(119, 26)
        Me.ComboBox4.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(275, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Specialite"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(199, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Niveau"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Promotion"
        '
        'PromoBox
        '
        Me.PromoBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromoBox.FormattingEnabled = True
        Me.PromoBox.Location = New System.Drawing.Point(99, 29)
        Me.PromoBox.Margin = New System.Windows.Forms.Padding(30, 0, 50, 0)
        Me.PromoBox.Name = "PromoBox"
        Me.PromoBox.Size = New System.Drawing.Size(75, 26)
        Me.PromoBox.Sorted = True
        Me.PromoBox.TabIndex = 0
        '
        'NiveauBox
        '
        Me.NiveauBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NiveauBox.FormattingEnabled = True
        Me.NiveauBox.Location = New System.Drawing.Point(201, 29)
        Me.NiveauBox.Margin = New System.Windows.Forms.Padding(30, 0, 50, 0)
        Me.NiveauBox.Name = "NiveauBox"
        Me.NiveauBox.Size = New System.Drawing.Size(50, 26)
        Me.NiveauBox.TabIndex = 1
        '
        'SpecialiteBox
        '
        Me.SpecialiteBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialiteBox.FormattingEnabled = True
        Me.SpecialiteBox.Location = New System.Drawing.Point(278, 29)
        Me.SpecialiteBox.Margin = New System.Windows.Forms.Padding(30, 0, 50, 0)
        Me.SpecialiteBox.Name = "SpecialiteBox"
        Me.SpecialiteBox.Size = New System.Drawing.Size(68, 26)
        Me.SpecialiteBox.TabIndex = 2
        '
        'PVPage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(678, 640)
        Me.Controls.Add(Me.PN_FORUMRECH)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 595)
        Me.Name = "PVPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.RechIntroPanel.ResumeLayout(False)
        Me.RechIntroPanel.PerformLayout()
        Me.PN_FORUMRECH.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RechIntroPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PN_FORUMRECH As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PromoBox As System.Windows.Forms.ComboBox
    Friend WithEvents NiveauBox As System.Windows.Forms.ComboBox
    Friend WithEvents SpecialiteBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents AffichButton As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    'Friend WithEvents Cryst12 As EsistHistoryManagement_v1.PvReport1

End Class
