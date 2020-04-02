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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PVPage))
        Me.RechIntroPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlecheList = New System.Windows.Forms.ImageList(Me.components)
        Me.PN_FORUMRECH = New System.Windows.Forms.Panel()
        Me.RechIntroPanel.SuspendLayout()
        Me.PN_FORUMRECH.SuspendLayout()
        Me.SuspendLayout()
        '
        'RechIntroPanel
        '
        Me.RechIntroPanel.Controls.Add(Me.Label1)
        Me.RechIntroPanel.Controls.Add(Me.Label2)
        Me.RechIntroPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RechIntroPanel.Location = New System.Drawing.Point(0, 0)
        Me.RechIntroPanel.Name = "RechIntroPanel"
        Me.RechIntroPanel.Size = New System.Drawing.Size(675, 638)
        Me.RechIntroPanel.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 28.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(260, 257)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 44)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "PV Page"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(212, 350)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 31)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Will be added later !"
        '
        'FlecheList
        '
        Me.FlecheList.ImageStream = CType(resources.GetObject("FlecheList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.FlecheList.TransparentColor = System.Drawing.Color.Transparent
        Me.FlecheList.Images.SetKeyName(0, "fleche ascendant.png")
        Me.FlecheList.Images.SetKeyName(1, "fleche decendant.png")
        '
        'PN_FORUMRECH
        '
        Me.PN_FORUMRECH.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PN_FORUMRECH.AutoScroll = True
        Me.PN_FORUMRECH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PN_FORUMRECH.BackColor = System.Drawing.Color.Transparent
        Me.PN_FORUMRECH.Controls.Add(Me.RechIntroPanel)
        Me.PN_FORUMRECH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PN_FORUMRECH.Location = New System.Drawing.Point(1, 0)
        Me.PN_FORUMRECH.Margin = New System.Windows.Forms.Padding(0)
        Me.PN_FORUMRECH.Name = "PN_FORUMRECH"
        Me.PN_FORUMRECH.Size = New System.Drawing.Size(675, 638)
        Me.PN_FORUMRECH.TabIndex = 11
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RechIntroPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PN_FORUMRECH As System.Windows.Forms.Panel
    Friend WithEvents FlecheList As System.Windows.Forms.ImageList
End Class
