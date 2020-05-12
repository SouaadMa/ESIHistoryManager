<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attestation
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SortirButton = New System.Windows.Forms.Button()
        Me.DetailPanel.SuspendLayout()
        Me.TitlePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DetailPanel
        '
        Me.DetailPanel.BackColor = System.Drawing.Color.Transparent
        Me.DetailPanel.Controls.Add(Me.SortirButton)
        Me.DetailPanel.Controls.Add(Me.CrystalReportViewer1)
        Me.DetailPanel.Controls.Add(Me.TitlePanel)
        Me.DetailPanel.Location = New System.Drawing.Point(0, 0)
        Me.DetailPanel.Name = "DetailPanel"
        Me.DetailPanel.Size = New System.Drawing.Size(678, 640)
        Me.DetailPanel.TabIndex = 89
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 44)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(678, 542)
        Me.CrystalReportViewer1.TabIndex = 51
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.ParameterPanel
        Me.CrystalReportViewer1.ToolPanelWidth = 130
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.Transparent
        Me.TitlePanel.Controls.Add(Me.Label1)
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(678, 45)
        Me.TitlePanel.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(270, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 31)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Attestation"
        '
        'SortirButton
        '
        Me.SortirButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.SortirButton.FlatAppearance.BorderSize = 0
        Me.SortirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SortirButton.Font = New System.Drawing.Font("Cambria", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortirButton.ForeColor = System.Drawing.Color.White
        Me.SortirButton.Location = New System.Drawing.Point(259, 596)
        Me.SortirButton.Name = "SortirButton"
        Me.SortirButton.Size = New System.Drawing.Size(160, 33)
        Me.SortirButton.TabIndex = 52
        Me.SortirButton.Text = "Sortir"
        Me.SortirButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SortirButton.UseVisualStyleBackColor = False
        '
        'Attestation
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(678, 640)
        Me.Controls.Add(Me.DetailPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(650, 595)
        Me.Name = "Attestation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attestation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.DetailPanel.ResumeLayout(False)
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DetailPanel As System.Windows.Forms.Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TitlePanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SortirButton As System.Windows.Forms.Button
End Class
