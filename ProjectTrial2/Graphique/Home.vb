Public Class Home

    Public _ModeConnexion As Boolean = Login.AdminButton.Checked        'the boolean to determine the connected profile type 
    'Public loading As Integer = 0
    Public f As Form    ' the form that will be shown in the middle of the page for the side bar operations
    Public h As Form    ' the form that will be shown in the middle of the page for the nav bar operations


    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'initialize the home page componants
        Me.Size = New System.Drawing.Size(1024, 728)
        Me.MinimumSize = New System.Drawing.Size(1023, 700)
        Me.MaximumSize = New System.Drawing.Size(1400, 1000)
        PN_BIENVENUE.Location = New System.Drawing.Point(71, 3)

        MenuButton.Location = New System.Drawing.Point(0, 0) 'initialize the hamburger button to the top left corner

        SideBar.Width = 55          'initialize the side bar
        SideBar.Enabled = False
        SideBar.Enabled = False

        NavBar.Width = 795                      ' initialize the nav bar
        NavBar.Location = New System.Drawing.Point(58, 639)

        If _ModeConnexion Then                  ' initialize th profile  bar according to the selected mode
            Me.mode_photo.Image = My.Resources.admin_mode
            BT_modif_mdp.Visible = True
            BT_modif_mdp.Enabled = True
            With LBL_MODE
                .Text = "Agent administarteur"
                .TextAlign = ContentAlignment.MiddleCenter
            End With

            With ModifButton        ' initialize the modif button according to the mode
                .Visible = True
            End With

        End If

        Login.Close()    ' close the login page 

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
            If Not f Is Nothing Then
                f.Close()
            End If
            If Not h Is Nothing Then
                h.Close()
            End If
            Login.Show()
        End If
    End Sub

    Private Sub MenuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButton.Click
        ' handle the meunubutton click ( slide the side bar)

        logo_bleu.Visible = Not logo_bleu.Visible
        SideBar.Enabled = True
        NavBar.Width = 666
        NavBar.Location = New System.Drawing.Point(190, 639)

        If logo_bleu.Visible Then

            SideBar.Width = 185
            NavBar.Width = 675
            NavBar.Location = New System.Drawing.Point(188, 639)
            Me.PN_BIENVENUE.Location = New System.Drawing.Point(160, 4)
            
            With Me.MainContainer1
                .Location = New System.Drawing.Point(185, 1)
                .Width = 680
                'If .Controls.Count > 0 Then
                '    .Controls.Item(0).Scale(New System.Drawing.SizeF(1 / 1.2, 1))
                '    .Controls.Item(0).Anchor = AnchorStyles.None
                '    .Controls.Item(0).Dock = DockStyle.Fill
                '    Console.Write(.Controls.Item(0).Name)
                'End If
            End With
            With Me.MainContainer2
                .Location = New System.Drawing.Point(185, 1)
                .Width = 680
                'If .Controls.Count > 0 Then
                '    .Controls.Item(0).Scale(New System.Drawing.SizeF(1 / 1.2, 1))
                '    .Controls.Item(0).Anchor = AnchorStyles.None
                '    .Controls.Item(0).Dock = DockStyle.Fill
                '    Console.Write(.Controls.Item(0).Name)
                'End If
            End With
        Else

            SideBar.Width = 55
            NavBar.Width = 800
            NavBar.Location = New System.Drawing.Point(61, 639)
            Me.PN_BIENVENUE.Location = New System.Drawing.Point(95, 4)
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

    'handle the appearence of help button when hovering
    Private Sub HelpButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Help_Button.MouseHover
        Help_Button.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)

    End Sub

    'handle the appearence of help button when leaving
    Private Sub HelpButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Help_Button.MouseLeave
        Help_Button.BackColor = Color.Transparent
    End Sub

    'handling the appearnce of the search form

    Private Sub BT_RECH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_RECH.Click

        Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
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
        If MainContainer1.Width = 680 Then
            With MainContainer1
                If .Controls.Count > 0 Then
                    .Controls.Item(0).Scale(New System.Drawing.SizeF(1 / 1.2, 1))
                    .Controls.Item(0).Anchor = AnchorStyles.None
                    .Controls.Item(0).Dock = DockStyle.Fill
                    Console.Write(.Controls.Item(0).Name + " sized little")
                End If
            End With
        Else
            With MainContainer1
                If .Controls.Count > 0 Then
                    .Controls.Item(0).Scale(New System.Drawing.SizeF(1.2, 1))
                    .Controls.Item(0).Anchor = AnchorStyles.None
                    .Controls.Item(0).Dock = DockStyle.Fill
                    Console.Write(.Controls.Item(0).Name + "sized big")
                End If
            End With
        End If
    End Sub
    Private Sub maincontainer2_sizechanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainContainer2.SizeChanged
        If MainContainer2.Width = 680 Then
            With MainContainer2
                If .Controls.Count > 0 Then
                    .Controls.Item(0).Scale(New System.Drawing.SizeF(1 / 1.2, 1))
                    .Controls.Item(0).Anchor = AnchorStyles.None
                    .Controls.Item(0).Dock = DockStyle.Fill
                    Console.Write(.Controls.Item(0).Name + " sized little")
                End If
            End With
        Else
            With MainContainer2
                If .Controls.Count > 0 Then
                    .Controls.Item(0).Scale(New System.Drawing.SizeF(1.2, 1))
                    .Controls.Item(0).Anchor = AnchorStyles.None
                    .Controls.Item(0).Dock = DockStyle.Fill
                    Console.Write(.Controls.Item(0).Name + "sized big")
                End If
            End With
        End If
    End Sub

    Private Sub MainContainer_ControlAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles MainContainer1.ControlAdded
        If MainContainer1.Width = 805 Then
            With MainContainer1
                If .Controls.Count > 0 Then
                    .Controls.Item(0).Scale(New System.Drawing.SizeF(1.2, 1))
                    .Controls.Item(0).Anchor = AnchorStyles.None
                    .Controls.Item(0).Dock = DockStyle.Fill
                    Console.Write(.Controls.Item(0).Name + "added ")
                End If
            End With
        End If
    End Sub

    Private Sub MainContainer2_ControlAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles MainContainer2.ControlAdded
        If MainContainer2.Width = 805 Then
            With MainContainer2
                If .Controls.Count > 0 Then
                    .Controls.Item(0).Scale(New System.Drawing.SizeF(1.2, 1))
                    .Controls.Item(0).Anchor = AnchorStyles.None
                    .Controls.Item(0).Dock = DockStyle.Fill
                    Console.Write(.Controls.Item(0).Name + "added ")
                End If
            End With
        End If
    End Sub

    Private Sub BT_CLASS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CLASS.Click
        Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
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
        'Me.MainContainer.Width = 680            ' adjust its appearance
    End Sub

    Private Sub BT_STAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_STAT.Click
        Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
        If Not f Is Nothing Then
            f.Close()
        End If
        RechercherPage.Panel1.Visible = False
        MainContainer1.Visible = True
        f = New StatistiquePage()         ' assign the search form to  the f form
        f.TopLevel = False
        f.TopMost = True
        f.WindowState = FormWindowState.Normal
        Me.MainContainer1.Controls.Add(f)        ' add the controlers of the searche page to the main form f 
        f.Show()                                ' show the form f in the middle of the home page
        Me.MainContainer1.Visible = True
        'Me.MainContainer.Width = 680            ' adjust its appearance
    End Sub

    Private Sub BT_PV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PV.Click
        Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
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
        'Me.MainContainer.Width = 680            ' adjust its appearance
    End Sub

    Private Sub DetailButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailButton.Click
        If f.GetType.ToString.Equals("EsistHistoryManagement_v1.affichResearchResult") Then
            Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
            If Not f Is Nothing Then
                'f.Hide()
                MainContainer1.Visible = False
            End If

            h = New details(CType(f, affichResearchResult).StudentList.Item(CType(f, affichResearchResult).SelectedStudent - 1 + (CType(f, affichResearchResult).CURRENT_PAGE - 1) * 7))         ' assign the search form to  the f form
            h.TopLevel = False
            h.TopMost = True
            h.WindowState = FormWindowState.Normal
            Me.MainContainer2.Controls.Add(h)        ' add the controlers of the searche page to the main form f 
            h.Show()                                ' show the form f in the middle of the home page
            Me.MainContainer2.Visible = True
            Me.MainContainer1.Visible = False
            'Me.MainContainer1.Width = 680            ' adjust its appearance

        End If
    End Sub

    Private Sub ModifButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifButton.Click
        'If f.GetType.ToString.Equals("EsistHistoryManagement_v1.affichResearchResult") Then
        '    Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
        '    If Not f Is Nothing Then
        '        f.Close()
        '    End If

        '    f = New modifier(affichResearchResult.StudentList.Item(affichResearchResult.SelectedStudent - 1 + (affichResearchResult.CURRENT_PAGE - 1) * 7))         ' assign the search form to  the f form
        '    f.TopLevel = False
        '    f.TopMost = True
        '    f.WindowState = FormWindowState.Normal
        '    Me.MainContainer1.Controls.Add(f)        ' add the controlers of the searche page to the main form f 
        '    f.Show()                                ' show the form f in the middle of the home page
        '    Me.MainContainer1.Visible = True
        '    Me.MainContainer1.Width = 680            ' adjust its appearance
        'End If
    End Sub

    Private Sub RNButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RNButton.Click
        If f.GetType.ToString.Equals("EsistHistoryManagement_v1.affichResearchResult") Then
            Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
            If Not f Is Nothing Then
                'f.Hide()
                MainContainer1.Visible = False
            End If

            h = New RN(CType(f, affichResearchResult).StudentList.Item(CType(f, affichResearchResult).SelectedStudent - 1 + (CType(f, affichResearchResult).CURRENT_PAGE - 1) * 7))         ' assign the search form to  the f form
            h.TopLevel = False
            h.TopMost = True
            h.WindowState = FormWindowState.Normal
            Me.MainContainer2.Controls.Add(h)        ' add the controlers of the searche page to the main form f 
            h.Show()                                ' show the form f in the middle of the home page
            Me.MainContainer2.Visible = True
            Me.MainContainer1.Visible = False
            'Me.MainContainer1.Width = 680            ' adjust its appearance

        End If
    End Sub

    Private Sub RNGButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RNGButton.Click
        If f.GetType.ToString.Equals("EsistHistoryManagement_v1.affichResearchResult") Then
            Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
            If Not f Is Nothing Then
                'f.Hide()
                MainContainer1.Visible = False
            End If

            h = New RNG(CType(f, affichResearchResult).StudentList.Item(CType(f, affichResearchResult).SelectedStudent - 1 + (CType(f, affichResearchResult).CURRENT_PAGE - 1) * 7))         ' assign the search form to  the f form
            h.TopLevel = False
            h.TopMost = True
            h.WindowState = FormWindowState.Normal
            Me.MainContainer2.Controls.Add(h)        ' add the controlers of the searche page to the main form f 
            h.Show()                                ' show the form f in the middle of the home page
            Me.MainContainer2.Visible = True
            Me.MainContainer1.Visible = False
            'Me.MainContainer1.Width = 680            ' adjust its appearance

        End If
    End Sub

    Private Sub HistoryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryButton.Click
        If f.GetType.ToString.Equals("EsistHistoryManagement_v1.affichResearchResult") Then
            Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
            If Not f Is Nothing Then
                'f.Hide()
                MainContainer1.Visible = False
            End If

            h = New Historique(CType(f, affichResearchResult).StudentList.Item(CType(f, affichResearchResult).SelectedStudent - 1 + (CType(f, affichResearchResult).CURRENT_PAGE - 1) * 7))         ' assign the search form to  the f form
            h.TopLevel = False
            h.TopMost = True
            h.WindowState = FormWindowState.Normal
            Me.MainContainer2.Controls.Add(h)        ' add the controlers of the searche page to the main form f 
            h.Show()                                ' show the form f in the middle of the home page
            Me.MainContainer2.Visible = True
            Me.MainContainer1.Visible = False
            'Me.MainContainer1.Width = 680            ' adjust its appearance

        End If
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        If f.GetType.ToString.Equals("EsistHistoryManagement_v1.affichResearchResult") Then
            Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
            If Not f Is Nothing Then
                'f.Hide()
                MainContainer1.Visible = False
            End If

            h = New Imprimer(CType(f, affichResearchResult).StudentList.Item(CType(f, affichResearchResult).SelectedStudent - 1 + (CType(f, affichResearchResult).CURRENT_PAGE - 1) * 7))         ' assign the search form to  the f form
            h.TopLevel = False
            h.TopMost = True
            h.WindowState = FormWindowState.Normal
            Me.MainContainer2.Controls.Add(h)        ' add the controlers of the searche page to the main form f 
            h.Show()                                ' show the form f in the middle of the home page
            Me.MainContainer2.Visible = True
            Me.MainContainer1.Visible = False
            'Me.MainContainer1.Width = 680            ' adjust its appearance

        End If
    End Sub

    
End Class





'RechButtons.Location = New Point(25, SplitContainer2.Panel2.ClientRectangle.Bottom)