<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrincipalPage
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
        Me.PN_BIENVENUE = New System.Windows.Forms.Panel()
        Me.Help_Button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PN_BIENVENUE.SuspendLayout()
        Me.SuspendLayout()
        '
        'PN_BIENVENUE
        '
        Me.PN_BIENVENUE.BackColor = System.Drawing.Color.Transparent
        Me.PN_BIENVENUE.Controls.Add(Me.Help_Button)
        Me.PN_BIENVENUE.Controls.Add(Me.Button1)
        Me.PN_BIENVENUE.Controls.Add(Me.Label8)
        Me.PN_BIENVENUE.Controls.Add(Me.Label7)
        Me.PN_BIENVENUE.Controls.Add(Me.Label4)
        Me.PN_BIENVENUE.Controls.Add(Me.Label3)
        Me.PN_BIENVENUE.Location = New System.Drawing.Point(0, 0)
        Me.PN_BIENVENUE.Margin = New System.Windows.Forms.Padding(2)
        Me.PN_BIENVENUE.Name = "PN_BIENVENUE"
        Me.PN_BIENVENUE.Size = New System.Drawing.Size(680, 640)
        Me.PN_BIENVENUE.TabIndex = 12
        '
        'Help_Button
        '
        Me.Help_Button.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.commerce_and_shopping
        Me.Help_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Help_Button.FlatAppearance.BorderSize = 0
        Me.Help_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Help_Button.Location = New System.Drawing.Point(427, 469)
        Me.Help_Button.Name = "Help_Button"
        Me.Help_Button.Size = New System.Drawing.Size(50, 50)
        Me.Help_Button.TabIndex = 9
        Me.Help_Button.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.multimedia
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(202, 463)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 62)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(104, 374)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(373, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "il existe un guide en ligne, vous pouvez le consulter *__*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(84, 328)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(283, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Nouveau en Esist History Manager ?"
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 237)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(495, 76)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "         Un outil de gestion du cursus des anciens étudiants de l’ESI durant leur" & _
            " parcours universitaire ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "il sert a l’obtention de données sur l’historique i" & _
            "ndividuel ou par promotion."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(74, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(315, 78)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Bienvenue à" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Esist History Manager"
        '
        'PrincipalPage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(680, 640)
        Me.Controls.Add(Me.PN_BIENVENUE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(680, 595)
        Me.Name = "PrincipalPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.PN_BIENVENUE.ResumeLayout(False)
        Me.PN_BIENVENUE.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PN_BIENVENUE As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Help_Button As System.Windows.Forms.Button
End Class
