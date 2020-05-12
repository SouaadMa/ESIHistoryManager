<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RN
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
        Me.DetailPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BT_LOAD = New System.Windows.Forms.Button()
        Me.CB_ANNEE = New System.Windows.Forms.ComboBox()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.BT_SORTIR = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DetailPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TitlePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DetailPanel
        '
        Me.DetailPanel.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.DetailPanel.Controls.Add(Me.Panel1)
        Me.DetailPanel.Location = New System.Drawing.Point(0, 0)
        Me.DetailPanel.Name = "DetailPanel"
        Me.DetailPanel.Size = New System.Drawing.Size(678, 640)
        Me.DetailPanel.TabIndex = 87
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CrystalReportViewer1)
        Me.Panel1.Controls.Add(Me.BT_LOAD)
        Me.Panel1.Controls.Add(Me.CB_ANNEE)
        Me.Panel1.Controls.Add(Me.TitlePanel)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 640)
        Me.Panel1.TabIndex = 88
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(175, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Annee d'etude :"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 107)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(676, 487)
        Me.CrystalReportViewer1.TabIndex = 49
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ToolPanelWidth = 100
        '
        'BT_LOAD
        '
        Me.BT_LOAD.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BT_LOAD.FlatAppearance.BorderSize = 0
        Me.BT_LOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LOAD.Font = New System.Drawing.Font("Cambria", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_LOAD.ForeColor = System.Drawing.Color.White
        Me.BT_LOAD.Location = New System.Drawing.Point(387, 600)
        Me.BT_LOAD.Name = "BT_LOAD"
        Me.BT_LOAD.Size = New System.Drawing.Size(160, 33)
        Me.BT_LOAD.TabIndex = 47
        Me.BT_LOAD.Text = "Afficher"
        Me.BT_LOAD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_LOAD.UseVisualStyleBackColor = False
        '
        'CB_ANNEE
        '
        Me.CB_ANNEE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_ANNEE.FormattingEnabled = True
        Me.CB_ANNEE.Location = New System.Drawing.Point(302, 75)
        Me.CB_ANNEE.Name = "CB_ANNEE"
        Me.CB_ANNEE.Size = New System.Drawing.Size(160, 21)
        Me.CB_ANNEE.TabIndex = 48
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.Transparent
        Me.TitlePanel.Controls.Add(Me.BT_SORTIR)
        Me.TitlePanel.Controls.Add(Me.Label2)
        Me.TitlePanel.Controls.Add(Me.Label1)
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(678, 69)
        Me.TitlePanel.TabIndex = 0
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
        Me.BT_SORTIR.Location = New System.Drawing.Point(622, 11)
        Me.BT_SORTIR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 100)
        Me.BT_SORTIR.Name = "BT_SORTIR"
        Me.BT_SORTIR.Size = New System.Drawing.Size(45, 45)
        Me.BT_SORTIR.TabIndex = 43
        Me.BT_SORTIR.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(217, 269)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 31)
        Me.Label2.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(232, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 31)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Relevé de note"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cambria", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(140, 600)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 33)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Sortir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RN
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(678, 640)
        Me.Controls.Add(Me.DetailPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 595)
        Me.Name = "RN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.DetailPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DetailPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BT_LOAD As System.Windows.Forms.Button
    Friend WithEvents CB_ANNEE As System.Windows.Forms.ComboBox
    Friend WithEvents TitlePanel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BT_SORTIR As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
