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
        Me.ChargementLabel = New System.Windows.Forms.Label()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.ChargementPanel = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChargementButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.RechargementButton = New System.Windows.Forms.Button()
        Me.TitlePanel.SuspendLayout()
        Me.ChargementPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChargementLabel
        '
        Me.ChargementLabel.AutoSize = True
        Me.ChargementLabel.BackColor = System.Drawing.Color.Transparent
        Me.ChargementLabel.Font = New System.Drawing.Font("Times New Roman", 23.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChargementLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ChargementLabel.Location = New System.Drawing.Point(254, 5)
        Me.ChargementLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ChargementLabel.Name = "ChargementLabel"
        Me.ChargementLabel.Size = New System.Drawing.Size(175, 36)
        Me.ChargementLabel.TabIndex = 12
        Me.ChargementLabel.Text = "Chargement"
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.Transparent
        Me.TitlePanel.Controls.Add(Me.ChargementLabel)
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(683, 46)
        Me.TitlePanel.TabIndex = 0
        '
        'ChargementPanel
        '
        Me.ChargementPanel.BackColor = System.Drawing.Color.Transparent
        Me.ChargementPanel.Controls.Add(Me.RechargementButton)
        Me.ChargementPanel.Controls.Add(Me.Button4)
        Me.ChargementPanel.Controls.Add(Me.Button3)
        Me.ChargementPanel.Controls.Add(Me.Button2)
        Me.ChargementPanel.Controls.Add(Me.Label4)
        Me.ChargementPanel.Controls.Add(Me.Label3)
        Me.ChargementPanel.Controls.Add(Me.Label2)
        Me.ChargementPanel.Controls.Add(Me.Label1)
        Me.ChargementPanel.Controls.Add(Me.ChargementButton)
        Me.ChargementPanel.Controls.Add(Me.Button1)
        Me.ChargementPanel.Controls.Add(Me.TitlePanel)
        Me.ChargementPanel.Location = New System.Drawing.Point(0, 0)
        Me.ChargementPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ChargementPanel.Name = "ChargementPanel"
        Me.ChargementPanel.Size = New System.Drawing.Size(683, 650)
        Me.ChargementPanel.TabIndex = 87
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button4.Location = New System.Drawing.Point(248, 378)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(385, 54)
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
        Me.Button3.Location = New System.Drawing.Point(248, 281)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(385, 54)
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
        Me.Button2.Location = New System.Drawing.Point(248, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(385, 54)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Cliquez pour choisir le fichier"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(49, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(165, 32)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "La table Rattrapage"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(49, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(165, 32)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "La table Matière"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(49, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(165, 32)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "La table Note"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(49, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(165, 32)
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
        Me.ChargementButton.Location = New System.Drawing.Point(416, 567)
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
        Me.Button1.Location = New System.Drawing.Point(248, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(385, 54)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Cliquez pour choisir le fichier"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "excel file |*.xlsx"
        '
        'RechargementButton
        '
        Me.RechargementButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.RechargementButton.FlatAppearance.BorderSize = 0
        Me.RechargementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RechargementButton.Font = New System.Drawing.Font("Cambria", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RechargementButton.ForeColor = System.Drawing.Color.White
        Me.RechargementButton.Location = New System.Drawing.Point(80, 567)
        Me.RechargementButton.Name = "RechargementButton"
        Me.RechargementButton.Size = New System.Drawing.Size(160, 36)
        Me.RechargementButton.TabIndex = 31
        Me.RechargementButton.Text = "Rechargement"
        Me.RechargementButton.UseVisualStyleBackColor = False
        '
        'Chargement
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(684, 651)
        Me.Controls.Add(Me.ChargementPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimumSize = New System.Drawing.Size(650, 595)
        Me.Name = "Chargement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.ChargementPanel.ResumeLayout(False)
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
End Class
