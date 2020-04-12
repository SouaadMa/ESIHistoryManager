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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.StatistiquesPanel = New System.Windows.Forms.Panel()
        Me.BT_NEXT = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BT_CHART = New System.Windows.Forms.Button()
        Me.CB_CHARTKIND = New System.Windows.Forms.ComboBox()
        Me.CB_SEC = New System.Windows.Forms.ComboBox()
        Me.CB_MAT = New System.Windows.Forms.ComboBox()
        Me.CB_PROMO = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.CB_GROUPE = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CB_SPECIALIT = New System.Windows.Forms.ComboBox()
        Me.CB_MOYENNE = New System.Windows.Forms.ComboBox()
        Me.StatistiquesPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatistiquesPanel
        '
        Me.StatistiquesPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.StatistiquesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StatistiquesPanel.BackColor = System.Drawing.Color.Transparent
        Me.StatistiquesPanel.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.StatistiquesPanel.Controls.Add(Me.Panel2)
        Me.StatistiquesPanel.Controls.Add(Me.BT_NEXT)
        Me.StatistiquesPanel.Controls.Add(Me.Button1)
        Me.StatistiquesPanel.Controls.Add(Me.BT_CHART)
        Me.StatistiquesPanel.Controls.Add(Me.CB_CHARTKIND)
        Me.StatistiquesPanel.Controls.Add(Me.Panel1)
        Me.StatistiquesPanel.Controls.Add(Me.Chart1)
        Me.StatistiquesPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatistiquesPanel.Location = New System.Drawing.Point(2, 1)
        Me.StatistiquesPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.StatistiquesPanel.Name = "StatistiquesPanel"
        Me.StatistiquesPanel.Size = New System.Drawing.Size(675, 638)
        Me.StatistiquesPanel.TabIndex = 12
        '
        'BT_NEXT
        '
        Me.BT_NEXT.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources._next
        Me.BT_NEXT.FlatAppearance.BorderSize = 0
        Me.BT_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_NEXT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BT_NEXT.Location = New System.Drawing.Point(618, 392)
        Me.BT_NEXT.Name = "BT_NEXT"
        Me.BT_NEXT.Size = New System.Drawing.Size(35, 35)
        Me.BT_NEXT.TabIndex = 9
        Me.BT_NEXT.Text = " "
        Me.BT_NEXT.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.prev1
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(22, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = " "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BT_CHART
        '
        Me.BT_CHART.FlatAppearance.BorderSize = 0
        Me.BT_CHART.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CHART.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BT_CHART.Location = New System.Drawing.Point(260, 596)
        Me.BT_CHART.Name = "BT_CHART"
        Me.BT_CHART.Size = New System.Drawing.Size(160, 33)
        Me.BT_CHART.TabIndex = 7
        Me.BT_CHART.Text = " "
        Me.BT_CHART.UseVisualStyleBackColor = True
        '
        'CB_CHARTKIND
        '
        Me.CB_CHARTKIND.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_CHARTKIND.FormattingEnabled = True
        Me.CB_CHARTKIND.Location = New System.Drawing.Point(260, 596)
        Me.CB_CHARTKIND.Name = "CB_CHARTKIND"
        Me.CB_CHARTKIND.Size = New System.Drawing.Size(160, 33)
        Me.CB_CHARTKIND.TabIndex = 6
        '
        'CB_SEC
        '
        Me.CB_SEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_SEC.FormattingEnabled = True
        Me.CB_SEC.Location = New System.Drawing.Point(542, 45)
        Me.CB_SEC.Name = "CB_SEC"
        Me.CB_SEC.Size = New System.Drawing.Size(120, 33)
        Me.CB_SEC.TabIndex = 5
        '
        'CB_MAT
        '
        Me.CB_MAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_MAT.FormattingEnabled = True
        Me.CB_MAT.Location = New System.Drawing.Point(403, 6)
        Me.CB_MAT.Name = "CB_MAT"
        Me.CB_MAT.Size = New System.Drawing.Size(120, 33)
        Me.CB_MAT.TabIndex = 4
        '
        'CB_PROMO
        '
        Me.CB_PROMO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_PROMO.FormattingEnabled = True
        Me.CB_PROMO.Location = New System.Drawing.Point(542, 6)
        Me.CB_PROMO.Name = "CB_PROMO"
        Me.CB_PROMO.Size = New System.Drawing.Size(120, 33)
        Me.CB_PROMO.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(10, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(294, 33)
        Me.ComboBox1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 77)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(78, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 32)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Faire des statistiques"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(84, 229)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(515, 359)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'CB_GROUPE
        '
        Me.CB_GROUPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_GROUPE.FormattingEnabled = True
        Me.CB_GROUPE.Location = New System.Drawing.Point(542, 84)
        Me.CB_GROUPE.Name = "CB_GROUPE"
        Me.CB_GROUPE.Size = New System.Drawing.Size(120, 33)
        Me.CB_GROUPE.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CB_MOYENNE)
        Me.Panel2.Controls.Add(Me.CB_SPECIALIT)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.CB_GROUPE)
        Me.Panel2.Controls.Add(Me.CB_MAT)
        Me.Panel2.Controls.Add(Me.CB_PROMO)
        Me.Panel2.Controls.Add(Me.CB_SEC)
        Me.Panel2.Location = New System.Drawing.Point(0, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(675, 132)
        Me.Panel2.TabIndex = 11
        '
        'CB_SPECIALIT
        '
        Me.CB_SPECIALIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_SPECIALIT.FormattingEnabled = True
        Me.CB_SPECIALIT.Location = New System.Drawing.Point(403, 84)
        Me.CB_SPECIALIT.Name = "CB_SPECIALIT"
        Me.CB_SPECIALIT.Size = New System.Drawing.Size(120, 33)
        Me.CB_SPECIALIT.TabIndex = 11
        '
        'CB_MOYENNE
        '
        Me.CB_MOYENNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_MOYENNE.FormattingEnabled = True
        Me.CB_MOYENNE.Location = New System.Drawing.Point(403, 45)
        Me.CB_MOYENNE.Name = "CB_MOYENNE"
        Me.CB_MOYENNE.Size = New System.Drawing.Size(120, 33)
        Me.CB_MOYENNE.TabIndex = 12
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StatistiquesPanel As System.Windows.Forms.Panel
    Friend WithEvents BT_CHART As System.Windows.Forms.Button
    Friend WithEvents CB_CHARTKIND As System.Windows.Forms.ComboBox
    Friend WithEvents CB_SEC As System.Windows.Forms.ComboBox
    Friend WithEvents CB_MAT As System.Windows.Forms.ComboBox
    Friend WithEvents CB_PROMO As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents BT_NEXT As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CB_GROUPE As System.Windows.Forms.ComboBox
    Friend WithEvents CB_MOYENNE As System.Windows.Forms.ComboBox
    Friend WithEvents CB_SPECIALIT As System.Windows.Forms.ComboBox
End Class
