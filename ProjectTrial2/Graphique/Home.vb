Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class Home

    Public _ModeConnexion As Boolean = Login.AdminButton.Checked        'the boolean to determine the connected profile type 
    Public f As Form    ' the form that will be shown in the middle of the page for the side bar operations
    Public h As Form    ' the form that will be shown in the middle of the page for the nav bar operations
    Public Shared alarm As System.Threading.Timer
    Public Shared x As Integer = 0



    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'initialize the home page componants
        Me.Size = New System.Drawing.Size(1025, 728)
        Me.MinimumSize = New System.Drawing.Size(1023, 700)
        Me.MaximumSize = New System.Drawing.Size(1024, 1000)
        'PN_BIENVENUE.Location = New System.Drawing.Point(71, 3)
        LogoPicture.Visible = False
        logo_bleu.Visible = False
        MenuButton.Location = New System.Drawing.Point(0, 0) 'initialize the hamburger button to the top left corner

        SideBar.Width = 55          'initialize the side bar
        SideBar.Enabled = False
        SideBar.Enabled = False

        NavBar.Width = 800                      ' initialize the nav bar
        NavBar.Location = New System.Drawing.Point(61, 639)

        Dim RNTip As ToolTip = New ToolTip()
        RNTip.SetToolTip(RNButton, "Relevé de Note")

        Dim RNGTip As ToolTip = New ToolTip()
        RNGTip.SetToolTip(RNGButton, "Relevé de Note générale")

        Dim DetailTip As ToolTip = New ToolTip()
        DetailTip.SetToolTip(DetailButton, "Détails")

        Dim CertificatTip As ToolTip = New ToolTip()
        CertificatTip.SetToolTip(PrintButton, "Attestation")

        Dim ModifTip As ToolTip = New ToolTip()
        ModifTip.SetToolTip(ModifButton, "Modifier")

        If _ModeConnexion Then                  ' initialize th profile  bar according to the selected mode
            Me.mode_photo.Image = My.Resources.admin_mode
            BT_modif_mdp.Visible = True
            BT_modif_mdp.Enabled = True
            With LBL_MODE
                .Text = "Administrateur"
            End With

            With ModifButton        ' initialize the modif button according to the mode
                .Visible = True
            End With

        End If

        With Me.MainContainer1
            .Location = New System.Drawing.Point(60, 0)
            .Width += 125
        End With
        HomeButton_Click(HomeButton, New System.EventArgs())
        MenuButton_Click(MenuButton, New MouseEventArgs(MouseButtons.Middle, 1, 15, 15, 1))

        Login.Close()    ' close the login page 

    End Sub

    Private Sub HomeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeButton.Click
        If Not f Is Nothing Then
            f.Close()
        End If
        f = New PrincipalPage()         ' assign the search form to  the f form
        f.TopLevel = False
        f.TopMost = True
        f.WindowState = FormWindowState.Normal
        Me.MainContainer1.Controls.Add(f)        ' add the controlers of the searche page to the main form f 
        f.Show()                                ' show the form f in the middle of the home page
        Me.MainContainer1.Visible = True
        MainContainer1.Controls.Item(0).Anchor = AnchorStyles.Left
        'If MainContainer1.Width > 700 Then
        '    maincontainer_sizechanged(MainContainer1, New EventArgs())
        'End If

        'Me.MainContainer.Width = 680            ' adjust its appearance

        'Login.Close()    ' close the login page 
    End Sub



    Private Sub BT_LOGOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_LOGOUT.Click

        Me.Close()
    End Sub


    Private Sub Home_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' handle the closing event of the home page by showing the confirmation alert
        Dim dialog As DialogResult
        dialog = MsgBox("Voulez-vous quitter la session ?", MessageBoxButtons.YesNo, "Quitter la session")
        If (dialog = Windows.Forms.DialogResult.No) Then
            e.Cancel = True
        Else
            Login.Infosgenerale.Save()
            If Not f Is Nothing Then
                f.Close()
            End If
            If Not h Is Nothing Then
                h.Close()
            End If
            Login.Show()
        End If
    End Sub

    Public Sub MenuButton_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuButton.MouseClick
        ' handle the meunubutton click ( slide the side bar)

        logo_bleu.Visible = Not logo_bleu.Visible
        SideBar.Enabled = True
        NavBar.Width = 677
        NavBar.Location = New System.Drawing.Point(190, 639)

        If logo_bleu.Visible Then

            SideBar.Width = 185
            NavBar.Width = 677
            NavBar.Location = New System.Drawing.Point(188, 639)
            'Me.PN_BIENVENUE.Location = New System.Drawing.Point(160, 4)
            LogoPicture.Visible = True
            With Me.MainContainer1
                .Location = New System.Drawing.Point(185, 1)
                .Width = 682
                'If .Controls.Count > 0 Then
                '    .Controls.Item(0).Scale(New System.Drawing.SizeF(1 / 1.2, 1))
                '    .Controls.Item(0).Anchor = AnchorStyles.None
                '    .Controls.Item(0).Dock = DockStyle.Fill
                '    Console.Write(.Controls.Item(0).Name)
                'End If
            End With
            With Me.MainContainer2
                .Location = New System.Drawing.Point(185, 1)
                .Width = 682

                'If .Controls.Count > 0 Then
                '    .Controls.Item(0).Scale(New System.Drawing.SizeF(1 / 1.2, 1))
                '    .Controls.Item(0).Anchor = AnchorStyles.None
                '    .Controls.Item(0).Dock = DockStyle.Fill
                '    Console.Write(.Controls.Item(0).Name)
                'End If
            End With
        Else
            LogoPicture.Visible = False
            SideBar.Width = 55
            NavBar.Width = 800
            NavBar.Location = New System.Drawing.Point(61, 639)
            'Me.PN_BIENVENUE.Location = New System.Drawing.Point(95, 4)
            With Me.MainContainer1
                .Location = New System.Drawing.Point(60, 1)
                .Width += 125
                'If .Controls.Count > 0 Then
                '    .Controls.Item(0).Scale(New System.Drawing.SizeF(1.2, 1))
                '    .Controls.Item(0).Anchor = AnchorStyles.None
                '    .Controls.Item(0).Dock = DockStyle.Fill
                '    Console.Write(.Controls.Item(0).Name)
                'End If
            End With
            With Me.MainContainer2
                .Location = New System.Drawing.Point(60, 1)
                .Width += 125
                'If .Controls.Count > 0 Then
                '    .Controls.Item(0).Scale(New System.Drawing.SizeF(1.2, 1))
                '    .Controls.Item(0).Anchor = AnchorStyles.None
                '    .Controls.Item(0).Dock = DockStyle.Fill
                '    Console.Write(.Controls.Item(0).Name)
                'End If
            End With

        End If


    End Sub

    Private Sub BT_CLASS_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BT_CLASS.MouseClick
        ' handle the classemnt button appearance

        For Each b As Button In Me.SideBar.Controls
            b.BackColor = Color.FromArgb(255, 0, 64, 104)
            b.ForeColor = Color.LavenderBlush
            b.Font = New Font(b.Font, FontStyle.Regular)
            b.ImageIndex = 0
        Next

        With BT_CLASS
            .BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
            .ForeColor = Color.Black
            .Font = New Font(.Font, FontStyle.Bold)
            .ImageIndex = 1
        End With

        'With BT_CLASS
        '.BackColor = Color.FromArgb(255, 0, 64, 104)
        '.ForeColor = Color.LavenderBlush
        '.Font = New Font(.Font, FontStyle.Regular)
        '.Image = My.Resources.line_chart_bl
        'End With
        'With BT_STAT
        '.BackColor = Color.FromArgb(255, 0, 64, 104)
        '.ForeColor = Color.LavenderBlush
        '.Font = New Font(.Font, FontStyle.Regular)
        'End With
        'With BT_RECH
        '.BackColor = Color.FromArgb(255, 0, 64, 104)
        '.ForeColor = Color.LavenderBlush
        '.Font = New Font(.Font, FontStyle.Regular)
        'End With
        'With BT_PV
        '.BackColor = Color.FromArgb(255, 0, 64, 104)
        '.ForeColor = Color.LavenderBlush
        '.Font = New Font(.Font, FontStyle.Regular)
        'End With

    End Sub

    Private Sub BT_STAT_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BT_STAT.MouseClick
        ' handle the statistiques button appearance

        For Each b As Button In Me.SideBar.Controls
            b.BackColor = Color.FromArgb(255, 0, 64, 104)
            b.ForeColor = Color.LavenderBlush
            b.Font = New Font(b.Font, FontStyle.Regular)
            b.ImageIndex = 0
        Next

        With BT_STAT
            .BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
            .ForeColor = Color.Black
            .Font = New Font(.Font, FontStyle.Bold)
            .ImageIndex = 1
        End With

    End Sub

    Private Sub BT_RECH_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BT_RECH.MouseClick
        ' handle the search button appearance

        For Each b As Button In Me.SideBar.Controls
            b.BackColor = Color.FromArgb(255, 0, 64, 104)
            b.ForeColor = Color.LavenderBlush
            b.Font = New Font(b.Font, FontStyle.Regular)
            b.ImageIndex = 0
        Next

        With BT_RECH
            .BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
            .ForeColor = Color.Black
            .Font = New Font(.Font, FontStyle.Bold)
            .ImageIndex = 1
        End With

    End Sub

    Private Sub BT_PV_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BT_PV.MouseClick
        ' handle the PV button appearance
        For Each b As Button In Me.SideBar.Controls
            b.BackColor = Color.FromArgb(255, 0, 64, 104)
            b.ForeColor = Color.LavenderBlush
            b.Font = New Font(b.Font, FontStyle.Regular)
            b.ImageIndex = 0
        Next

        With BT_PV
            .BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
            .ForeColor = Color.Black
            .Font = New Font(.Font, FontStyle.Bold)
            .ImageIndex = 1
        End With

    End Sub



    'handling the appearnce of the search form

    Private Sub BT_RECH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_RECH.Click

        'Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
        If Not f Is Nothing Then
            f.Close()
        End If
        f = New RechercherPage()         ' assign the search form to  the f form
        f.TopLevel = False
        f.TopMost = True
        f.WindowState = FormWindowState.Normal
        Me.MainContainer1.Controls.Add(f)        ' add the controlers of the searche page to the main form f 
        f.Show()                                ' show the form f in the middle of the home page
        Me.MainContainer1.Visible = True
        'Me.MainContainer.Width = 680            ' adjust its appearance

    End Sub

    Private Sub BT_modif_mdp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_modif_mdp.Click
        modifpassword.Show()
    End Sub

    Private Sub maincontainer_sizechanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainContainer1.SizeChanged
        If MainContainer1.Width < 700 Then
            With MainContainer1
                If .Controls.Count > 0 Then
                    .Controls.Item(0).Scale(New System.Drawing.SizeF(1 / 1.2, 1))
                    .Controls.Item(0).Anchor = AnchorStyles.None
                    .Controls.Item(0).Dock = DockStyle.Fill
                    'Console.Write(.Controls.Item(0).Name + " sized little")
                End If
            End With
        Else
            With MainContainer1
                If .Controls.Count > 0 Then
                    .Controls.Item(0).Scale(New System.Drawing.SizeF(1.2, 1))
                    .Controls.Item(0).Anchor = AnchorStyles.None
                    .Controls.Item(0).Dock = DockStyle.Fill
                    'Console.Write(.Controls.Item(0).Name + "sized big")
                End If
            End With
        End If
    End Sub
    Private Sub maincontainer2_sizechanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainContainer2.SizeChanged
        If MainContainer2.Width < 700 Then
            With MainContainer2
                If .Controls.Count > 0 Then
                    .Controls.Item(0).Scale(New System.Drawing.SizeF(1 / 1.2, 1))
                    .Controls.Item(0).Anchor = AnchorStyles.None
                    .Controls.Item(0).Dock = DockStyle.Fill
                    'Console.Write(.Controls.Item(0).Name + " sized little")
                End If
            End With
        Else
            With MainContainer2
                If .Controls.Count > 0 Then
                    .Controls.Item(0).Scale(New System.Drawing.SizeF(1.2, 1))
                    .Controls.Item(0).Anchor = AnchorStyles.None
                    .Controls.Item(0).Dock = DockStyle.Fill
                    'Console.Write(.Controls.Item(0).Name + "sized big")
                End If
            End With
        End If
    End Sub

    Private Sub MainContainer_ControlAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles MainContainer1.ControlAdded
        If MainContainer1.Width > 800 Then
            With MainContainer1
                If .Controls.Count > 0 Then
                    .Controls.Item(0).Scale(New System.Drawing.SizeF(1.2, 1))
                    .Controls.Item(0).Anchor = AnchorStyles.None
                    .Controls.Item(0).Dock = DockStyle.Fill
                    'Console.Write(.Controls.Item(0).Name + "added ")
                End If
            End With
        End If
    End Sub

    Private Sub MainContainer2_ControlAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles MainContainer2.ControlAdded
        If MainContainer2.Width > 800 Then
            With MainContainer2
                If .Controls.Count > 0 Then
                    .Controls.Item(0).Scale(New System.Drawing.SizeF(1.2, 1))
                    .Controls.Item(0).Anchor = AnchorStyles.None
                    .Controls.Item(0).Dock = DockStyle.Fill
                    'Console.Write(.Controls.Item(0).Name + "added ")
                End If
            End With
        End If
    End Sub

    Private Sub BT_CLASS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CLASS.Click
        'Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
        If Not f Is Nothing Then
            f.Close()
        End If
        f = New ClassementPage()         ' assign the search form to  the f form
        f.TopLevel = False
        f.TopMost = True
        f.WindowState = FormWindowState.Normal
        Me.MainContainer1.Controls.Add(f)        ' add the controlers of the searche page to the main form f 
        f.Show()                                ' show the form f in the middle of the home page
        Me.MainContainer1.Visible = True
        'If MainContainer1.Width > 700 Then
        '    maincontainer_sizechanged(MainContainer1, New EventArgs())
        'End If

        'Me.MainContainer.Width = 680            ' adjust its appearance
    End Sub

    Private Sub BT_STAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_STAT.Click
        'Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
        If Not f Is Nothing Then
            f.Close()
        End If
        Me.ProgressPanel.Visible = False
        MainContainer1.Visible = True
        f = New StatistiquePage()         ' assign the search form to  the f form
        f.TopLevel = False
        f.TopMost = True
        f.WindowState = FormWindowState.Normal
        Me.MainContainer1.Controls.Add(f)        ' add the controlers of the searche page to the main form f 
        f.Show()                                ' show the form f in the middle of the home page
        Me.MainContainer1.Visible = True
        'If MainContainer1.Width > 700 Then
        '    maincontainer_sizechanged(MainContainer1, New EventArgs())
        'End If
        'Me.MainContainer.Width = 680            ' adjust its appearance
    End Sub

    Private Sub BT_PV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PV.Click
        'Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
        If Not f Is Nothing Then
            f.Close()
        End If
        f = New PVPage()         ' assign the search form to  the f form
        f.TopLevel = False
        f.TopMost = True
        f.WindowState = FormWindowState.Normal
        Me.MainContainer1.Controls.Add(f)        ' add the controlers of the searche page to the main form f 
        f.Show()                                ' show the form f in the middle of the home page
        Me.MainContainer1.Visible = True
        'If MainContainer1.Width > 700 Then
        '    maincontainer_sizechanged(MainContainer1, New EventArgs())
        'End If
        'Me.MainContainer.Width = 680            ' adjust its appearance
    End Sub

    Private Sub DetailButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailButton.Click
            'Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
            
        If f.GetType.ToString.Equals("EsistHistoryManagement_v1.affichResearchResult") Or f.GetType.ToString.Equals("EsistHistoryManagement_v1.ClassementPage") Then
            If Not f Is Nothing Then
                'f.Hide()
                MainContainer1.Visible = False
            End If
            If Not h Is Nothing Then
                'f.Hide()
                h.Close()
            End If
            h = New details(CTypeDynamic(f, f.GetType()).StudentList.Item(0))        ' assign the search form to  the f form
        Else
            If Not f Is Nothing Then
                'f.Hide()
                MainContainer1.Visible = False
            End If
            If Not h Is Nothing Then
                'f.Hide()
                h.Close()
            End If
            h = New details(CTypeDynamic(f, f.GetType()).esistselect)
        End If
        h.TopLevel = False
        h.TopMost = True
        h.WindowState = FormWindowState.Normal
        Me.MainContainer2.Controls.Add(h)        ' add the controlers of the searche page to the main form f 
        h.Show()                                ' show the form f in the middle of the home page
        Me.MainContainer2.Visible = True
        Me.MainContainer1.Visible = False
        'Me.MainContainer1.Width = 680            ' adjust its appearance

    End Sub

    Private Sub ModifButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifButton.Click
        If f.GetType.ToString.Equals("EsistHistoryManagement_v1.affichResearchResult") Or f.GetType.ToString.Equals("EsistHistoryManagement_v1.ClassementPage") Then
            'Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
            If Not f Is Nothing Then
                'f.Hide()
                MainContainer1.Visible = False
            End If
            If Not h Is Nothing Then
                'f.Hide()
                h.Close()
            End If
            h = New modifier(CTypeDynamic(f, f.GetType()).StudentList.Item(0))        ' assign the search form to  the f form
        Else
            If Not f Is Nothing Then
                'f.Hide()
                MainContainer1.Visible = False
            End If
            If Not h Is Nothing Then
                'f.Hide()
                h.Close()
            End If
            h = New modifier(CTypeDynamic(f, f.GetType()).esistselect)
        End If
        h.TopLevel = False
        h.TopMost = True
        h.WindowState = FormWindowState.Normal
        Me.MainContainer2.Controls.Add(h)        ' add the controlers of the searche page to the main form f 
        h.Show()                                ' show the form f in the middle of the home page
        Me.MainContainer2.Visible = True
        Me.MainContainer1.Visible = False
        'Me.MainContainer1.Width = 680            ' adjust its appearance

        'End If
    End Sub

    Private Sub RNButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RNButton.Click
        If f.GetType.ToString.Equals("EsistHistoryManagement_v1.affichResearchResult") Or f.GetType.ToString.Equals("EsistHistoryManagement_v1.ClassementPage") Then
            'Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
            If Not f Is Nothing Then
                'f.Hide()
                MainContainer1.Visible = False
            End If
            If Not h Is Nothing Then
                'f.Hide()
                h.Close()
            End If
            h = New RN(CTypeDynamic(f, f.GetType()).StudentList.Item(0))         ' assign the search form to  the f form
        Else
            If Not f Is Nothing Then
                'f.Hide()
                MainContainer1.Visible = False
            End If
            If Not h Is Nothing Then
                'f.Hide()
                h.Close()
            End If
            h = New RN(CTypeDynamic(f, f.GetType()).esistselect)
        End If
        h.TopLevel = False
        h.TopMost = True
        h.WindowState = FormWindowState.Normal
        Me.MainContainer2.Controls.Add(h)        ' add the controlers of the searche page to the main form f 
        h.Show()                                ' show the form f in the middle of the home page
        Me.MainContainer2.Visible = True
        Me.MainContainer1.Visible = False
        'Me.MainContainer1.Width = 680            ' adjust its appearance

        'End If
    End Sub

    Private Sub RNGButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RNGButton.Click
        If f.GetType.ToString.Equals("EsistHistoryManagement_v1.affichResearchResult") Or f.GetType.ToString.Equals("EsistHistoryManagement_v1.ClassementPage") Then
            'Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
            If Not f Is Nothing Then
                'f.Hide()
                MainContainer1.Visible = False
            End If
            If Not h Is Nothing Then
                'f.Hide()
                h.Close()
            End If
            h = New RNGPage(CTypeDynamic(f, f.GetType()).StudentList.Item(0))         ' assign the search form to  the f form
        Else
            If Not f Is Nothing Then
                'f.Hide()
                MainContainer1.Visible = False
            End If
            If Not h Is Nothing Then
                'f.Hide()
                h.Close()
            End If
            h = New RNGPage(CTypeDynamic(f, f.GetType()).esistselect)
        End If
        h.TopLevel = False
        h.TopMost = True
        h.WindowState = FormWindowState.Normal
        Me.MainContainer2.Controls.Add(h)        ' add the controlers of the searche page to the main form f 
        h.Show()                                ' show the form f in the middle of the home page
        Me.MainContainer2.Visible = True
        Me.MainContainer1.Visible = False
        'Me.MainContainer1.Width = 680            ' adjust its appearance

        'End If
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        If f.GetType.ToString.Equals("EsistHistoryManagement_v1.affichResearchResult") Or f.GetType.ToString.Equals("EsistHistoryManagement_v1.ClassementPage") Then
            'Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
            If Not f Is Nothing Then
                'f.Hide()
                MainContainer1.Visible = False
            End If
            If Not h Is Nothing Then
                'f.Hide()
                h.Close()
            End If
            h = New Attestation(CTypeDynamic(f, f.GetType()).StudentList.Item(0))         ' assign the search form to  the f form
        Else
            If Not f Is Nothing Then
                'f.Hide()
                MainContainer1.Visible = False
            End If
            If Not h Is Nothing Then
                'f.Hide()
                h.Close()
            End If
            h = New Attestation(CTypeDynamic(f, f.GetType()).esistselect)
        End If
        h.TopLevel = False
        h.TopMost = True
        h.WindowState = FormWindowState.Normal
        Me.MainContainer2.Controls.Add(h)        ' add the controlers of the searche page to the main form f 
        h.Show()                                ' show the form f in the middle of the home page
        Me.MainContainer2.Visible = True
        Me.MainContainer1.Visible = False
        'Me.MainContainer1.Width = 680            ' adjust its appearance

        'End If
    End Sub

    Private Sub ProgressPanel_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressPanel.VisibleChanged

        If Not ProgressPanel.Visible Then
            x = 0
        Else
            ProgressLabel.Text = "0%"
            Home.alarm = New System.Threading.Timer(AddressOf alarm_Tick_1, Nothing, 0, 2)
        End If

    End Sub

    Private Sub alarm_Tick_1(ByVal state As Object)
        x += 5
        If x > 100 Then
            alarm.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite)
            x = 0
        Else
            Me.Invoke(New MethodInvoker(AddressOf UpdateLabels))
        End If
    End Sub
    Private Sub UpdateLabels()
        ProgressLabel.Text = x.ToString + "%"
        PictureBox2.Size = New System.Drawing.Size(226, (x * (PictureBox2.MaximumSize.Height)) \ 100)
    End Sub

    'Private Sub BT_CERT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If f.GetType.ToString.Equals("EsistHistoryManagement_v1.affichResearchResult") Or f.GetType.ToString.Equals("EsistHistoryManagement_v1.ClassementPage") Then
    '        'Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
    '        If Not f Is Nothing Then
    '            'f.Hide()
    '            MainContainer1.Visible = False
    '        End If

    '        h = New Attestation(CType(f, affichResearchResult).StudentList.Item(0))        ' assign the search form to  the f form
    '        h.TopLevel = False
    '        h.TopMost = True
    '        h.WindowState = FormWindowState.Normal
    '        Me.MainContainer2.Controls.Add(h)        ' add the controlers of the searche page to the main form f 
    '        h.Show()                                ' show the form f in the middle of the home page
    '        Me.MainContainer2.Visible = True
    '        Me.MainContainer1.Visible = False
    '        'Me.MainContainer1.Width = 680            ' adjust its appearance

    '    End If
    'End Sub

End Class


'Private Sub HistoryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    If f.GetType.ToString.Equals("EsistHistoryManagement_v1.affichResearchResult") Or f.GetType.ToString.Equals("EsistHistoryManagement_v1.ClassementPage") Then
'        Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
'        If Not f Is Nothing Then
'            'f.Hide()
'            MainContainer1.Visible = False
'        End If

'        h = New Historique(CType(f, affichResearchResult).StudentList.Item(0))        ' assign the search form to  the f form
'        h.TopLevel = False
'        h.TopMost = True
'        h.WindowState = FormWindowState.Normal
'        Me.MainContainer2.Controls.Add(h)        ' add the controlers of the searche page to the main form f 
'        h.Show()                                ' show the form f in the middle of the home page
'        Me.MainContainer2.Visible = True
'        Me.MainContainer1.Visible = False
'        'Me.MainContainer1.Width = 680            ' adjust its appearance

'    End If
'End Sub



'RechButtons.Location = New Point(25, SplitContainer2.Panel2.ClientRectangle.Bottom)