﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BT_SORTIR = New System.Windows.Forms.Button()
        Me.DetailPanel = New System.Windows.Forms.Panel()
        Me.TitlePanel.SuspendLayout()
        Me.DetailPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(281, 183)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 31)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "RN Page"
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.Transparent
        Me.TitlePanel.Controls.Add(Me.Label2)
        Me.TitlePanel.Controls.Add(Me.Label1)
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(678, 483)
        Me.TitlePanel.TabIndex = 0
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
        Me.Label2.Size = New System.Drawing.Size(245, 31)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Will be added later !"
        '
        'BT_SORTIR
        '
        Me.BT_SORTIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BT_SORTIR.FlatAppearance.BorderSize = 0
        Me.BT_SORTIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SORTIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_SORTIR.ForeColor = System.Drawing.Color.White
        Me.BT_SORTIR.Location = New System.Drawing.Point(32, 554)
        Me.BT_SORTIR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 100)
        Me.BT_SORTIR.Name = "BT_SORTIR"
        Me.BT_SORTIR.Size = New System.Drawing.Size(150, 37)
        Me.BT_SORTIR.TabIndex = 41
        Me.BT_SORTIR.Text = "Sortir"
        Me.BT_SORTIR.UseVisualStyleBackColor = False
        '
        'DetailPanel
        '
        Me.DetailPanel.Controls.Add(Me.TitlePanel)
        Me.DetailPanel.Controls.Add(Me.BT_SORTIR)
        Me.DetailPanel.Location = New System.Drawing.Point(0, 0)
        Me.DetailPanel.Name = "DetailPanel"
        Me.DetailPanel.Size = New System.Drawing.Size(678, 640)
        Me.DetailPanel.TabIndex = 87
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
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        Me.DetailPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TitlePanel As System.Windows.Forms.Panel
    Friend WithEvents BT_SORTIR As System.Windows.Forms.Button
    Friend WithEvents DetailPanel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
