<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modifier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modifier))
        Me.BT_SORTIR = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BT_INSCRIP = New System.Windows.Forms.RadioButton()
        Me.BT_GRP = New System.Windows.Forms.RadioButton()
        Me.BT_GENERALINFO = New System.Windows.Forms.RadioButton()
        Me.BT_INFOBAC = New System.Windows.Forms.RadioButton()
        Me.BT_INFORESIDENCE = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.P_GENERALITE = New System.Windows.Forms.TabPage()
        Me.P_RESIDENCE = New System.Windows.Forms.TabPage()
        Me.P_BAC = New System.Windows.Forms.TabPage()
        Me.P_INSCRIPTION = New System.Windows.Forms.TabPage()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BT_SORTIR
        '
        Me.BT_SORTIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BT_SORTIR.FlatAppearance.BorderSize = 0
        Me.BT_SORTIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SORTIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_SORTIR.ForeColor = System.Drawing.Color.White
        Me.BT_SORTIR.Location = New System.Drawing.Point(29, 596)
        Me.BT_SORTIR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 100)
        Me.BT_SORTIR.Name = "BT_SORTIR"
        Me.BT_SORTIR.Size = New System.Drawing.Size(150, 37)
        Me.BT_SORTIR.TabIndex = 45
        Me.BT_SORTIR.Text = "Sortir"
        Me.BT_SORTIR.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.BT_INSCRIP)
        Me.Panel3.Controls.Add(Me.BT_GRP)
        Me.Panel3.Controls.Add(Me.BT_GENERALINFO)
        Me.Panel3.Controls.Add(Me.BT_INFOBAC)
        Me.Panel3.Controls.Add(Me.BT_INFORESIDENCE)
        Me.Panel3.Location = New System.Drawing.Point(0, 73)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(221, 512)
        Me.Panel3.TabIndex = 43
        '
        'BT_INSCRIP
        '
        Me.BT_INSCRIP.Appearance = System.Windows.Forms.Appearance.Button
        Me.BT_INSCRIP.AutoSize = True
        Me.BT_INSCRIP.BackColor = System.Drawing.Color.Transparent
        Me.BT_INSCRIP.BackgroundImage = CType(resources.GetObject("BT_INSCRIP.BackgroundImage"), System.Drawing.Image)
        Me.BT_INSCRIP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_INSCRIP.FlatAppearance.BorderSize = 0
        Me.BT_INSCRIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_INSCRIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_INSCRIP.ForeColor = System.Drawing.Color.Gray
        Me.BT_INSCRIP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_INSCRIP.Location = New System.Drawing.Point(0, 164)
        Me.BT_INSCRIP.Name = "BT_INSCRIP"
        Me.BT_INSCRIP.Size = New System.Drawing.Size(214, 27)
        Me.BT_INSCRIP.TabIndex = 7
        Me.BT_INSCRIP.Text = "Informations de l'inscrption"
        Me.BT_INSCRIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BT_INSCRIP.UseVisualStyleBackColor = False
        '
        'BT_GRP
        '
        Me.BT_GRP.Appearance = System.Windows.Forms.Appearance.Button
        Me.BT_GRP.AutoSize = True
        Me.BT_GRP.BackColor = System.Drawing.Color.Transparent
        Me.BT_GRP.BackgroundImage = CType(resources.GetObject("BT_GRP.BackgroundImage"), System.Drawing.Image)
        Me.BT_GRP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_GRP.FlatAppearance.BorderSize = 0
        Me.BT_GRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_GRP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_GRP.ForeColor = System.Drawing.Color.Gray
        Me.BT_GRP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_GRP.Location = New System.Drawing.Point(0, 124)
        Me.BT_GRP.Name = "BT_GRP"
        Me.BT_GRP.Size = New System.Drawing.Size(216, 27)
        Me.BT_GRP.TabIndex = 6
        Me.BT_GRP.Text = "Informations du groupe      "
        Me.BT_GRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BT_GRP.UseVisualStyleBackColor = False
        '
        'BT_GENERALINFO
        '
        Me.BT_GENERALINFO.Appearance = System.Windows.Forms.Appearance.Button
        Me.BT_GENERALINFO.AutoSize = True
        Me.BT_GENERALINFO.BackColor = System.Drawing.Color.Transparent
        Me.BT_GENERALINFO.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.backBTcheked
        Me.BT_GENERALINFO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_GENERALINFO.FlatAppearance.BorderSize = 0
        Me.BT_GENERALINFO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_GENERALINFO.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_GENERALINFO.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BT_GENERALINFO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_GENERALINFO.Location = New System.Drawing.Point(0, 3)
        Me.BT_GENERALINFO.Name = "BT_GENERALINFO"
        Me.BT_GENERALINFO.Size = New System.Drawing.Size(224, 27)
        Me.BT_GENERALINFO.TabIndex = 3
        Me.BT_GENERALINFO.Text = "Generalite                          "
        Me.BT_GENERALINFO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BT_GENERALINFO.UseVisualStyleBackColor = False
        '
        'BT_INFOBAC
        '
        Me.BT_INFOBAC.Appearance = System.Windows.Forms.Appearance.Button
        Me.BT_INFOBAC.AutoSize = True
        Me.BT_INFOBAC.BackColor = System.Drawing.Color.Transparent
        Me.BT_INFOBAC.BackgroundImage = CType(resources.GetObject("BT_INFOBAC.BackgroundImage"), System.Drawing.Image)
        Me.BT_INFOBAC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_INFOBAC.FlatAppearance.BorderSize = 0
        Me.BT_INFOBAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_INFOBAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_INFOBAC.ForeColor = System.Drawing.Color.Gray
        Me.BT_INFOBAC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_INFOBAC.Location = New System.Drawing.Point(0, 83)
        Me.BT_INFOBAC.Name = "BT_INFOBAC"
        Me.BT_INFOBAC.Size = New System.Drawing.Size(215, 27)
        Me.BT_INFOBAC.TabIndex = 4
        Me.BT_INFOBAC.Text = "Informations du BAC          "
        Me.BT_INFOBAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BT_INFOBAC.UseVisualStyleBackColor = False
        '
        'BT_INFORESIDENCE
        '
        Me.BT_INFORESIDENCE.Appearance = System.Windows.Forms.Appearance.Button
        Me.BT_INFORESIDENCE.AutoSize = True
        Me.BT_INFORESIDENCE.BackColor = System.Drawing.Color.Transparent
        Me.BT_INFORESIDENCE.BackgroundImage = CType(resources.GetObject("BT_INFORESIDENCE.BackgroundImage"), System.Drawing.Image)
        Me.BT_INFORESIDENCE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_INFORESIDENCE.FlatAppearance.BorderSize = 0
        Me.BT_INFORESIDENCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_INFORESIDENCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_INFORESIDENCE.ForeColor = System.Drawing.Color.Gray
        Me.BT_INFORESIDENCE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_INFORESIDENCE.Location = New System.Drawing.Point(0, 42)
        Me.BT_INFORESIDENCE.Name = "BT_INFORESIDENCE"
        Me.BT_INFORESIDENCE.Size = New System.Drawing.Size(224, 27)
        Me.BT_INFORESIDENCE.TabIndex = 5
        Me.BT_INFORESIDENCE.Text = "Informations de la residence"
        Me.BT_INFORESIDENCE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BT_INFORESIDENCE.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 69)
        Me.Panel1.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(64, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(537, 38)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Modifer les informations de l'etudiant"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.P_GENERALITE)
        Me.TabControl1.Controls.Add(Me.P_RESIDENCE)
        Me.TabControl1.Controls.Add(Me.P_BAC)
        Me.TabControl1.Controls.Add(Me.P_INSCRIPTION)
        Me.TabControl1.Location = New System.Drawing.Point(218, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(458, 569)
        Me.TabControl1.TabIndex = 46
        '
        'P_GENERALITE
        '
        Me.P_GENERALITE.BackColor = System.Drawing.Color.Transparent
        Me.P_GENERALITE.Location = New System.Drawing.Point(4, 28)
        Me.P_GENERALITE.Name = "P_GENERALITE"
        Me.P_GENERALITE.Padding = New System.Windows.Forms.Padding(3)
        Me.P_GENERALITE.Size = New System.Drawing.Size(450, 537)
        Me.P_GENERALITE.TabIndex = 0
        Me.P_GENERALITE.Text = "P_GENERALITE"
        '
        'P_RESIDENCE
        '
        Me.P_RESIDENCE.Location = New System.Drawing.Point(4, 28)
        Me.P_RESIDENCE.Name = "P_RESIDENCE"
        Me.P_RESIDENCE.Padding = New System.Windows.Forms.Padding(3)
        Me.P_RESIDENCE.Size = New System.Drawing.Size(450, 537)
        Me.P_RESIDENCE.TabIndex = 1
        Me.P_RESIDENCE.Text = "P_RESIDENCE"
        Me.P_RESIDENCE.UseVisualStyleBackColor = True
        '
        'P_BAC
        '
        Me.P_BAC.Location = New System.Drawing.Point(4, 28)
        Me.P_BAC.Name = "P_BAC"
        Me.P_BAC.Size = New System.Drawing.Size(450, 537)
        Me.P_BAC.TabIndex = 2
        Me.P_BAC.Text = "P_BAC"
        Me.P_BAC.UseVisualStyleBackColor = True
        '
        'P_INSCRIPTION
        '
        Me.P_INSCRIPTION.Location = New System.Drawing.Point(4, 28)
        Me.P_INSCRIPTION.Name = "P_INSCRIPTION"
        Me.P_INSCRIPTION.Size = New System.Drawing.Size(450, 537)
        Me.P_INSCRIPTION.TabIndex = 3
        Me.P_INSCRIPTION.Text = "P_INSCRIPTION"
        Me.P_INSCRIPTION.UseVisualStyleBackColor = True
        '
        'modifier
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(678, 640)
        Me.Controls.Add(Me.BT_SORTIR)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 595)
        Me.Name = "modifier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BT_SORTIR As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BT_GENERALINFO As System.Windows.Forms.RadioButton
    Friend WithEvents BT_INFOBAC As System.Windows.Forms.RadioButton
    Friend WithEvents BT_INFORESIDENCE As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BT_INSCRIP As System.Windows.Forms.RadioButton
    Friend WithEvents BT_GRP As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents P_GENERALITE As System.Windows.Forms.TabPage
    Friend WithEvents P_RESIDENCE As System.Windows.Forms.TabPage
    Friend WithEvents P_BAC As System.Windows.Forms.TabPage
    Friend WithEvents P_INSCRIPTION As System.Windows.Forms.TabPage
End Class
