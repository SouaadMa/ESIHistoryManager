Public Class ClassementPage

    Public StudentList As New List(Of Etudiant)
    Public StudentTable As New DataTable()
    Public filtredTable As New DataTable()
    Private nb_page As Integer = 0
    Public CURRENT_PAGE As Integer = 1
    Public SelectedStudent As Integer = -1
    Public Shared SortDirectionAscendant As Boolean = True
    Public collectionList As New AutoCompleteStringCollection
    Public saveText As String = "1999"


    Private Sub ClassementPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' inisializer le form
        EtudiantPanel.Visible = True
        PN_PAGES.Visible = True
        NoResultLabel.Visible = False
        'ListBox.Size = ListBox.MinimumSize

        AllCheckBox.Checked = True
        LimitUpDown.Enabled = False

        SpecialiteBox.Items.AddRange({"SIQ", "SI"})

        'make the nav bar desactivated

        For Each b As Control In Home.NavBar.Controls
            If b.GetType.ToString = "System.Windows.Forms.Button" Then
                b.Enabled = False
            End If
        Next

        'appel a la fonction qui nous donne la collection des etudiants 
        Me.AffPanel.Dock = DockStyle.Fill   ' dock the seach form in the parent container
        
    End Sub

    Private Sub TableLayoutPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TableLayoutPanel7.Click, TableLayoutPanel6.Click, TableLayoutPanel5.Click, TableLayoutPanel4.Click, TableLayoutPanel3.Click, TableLayoutPanel2.Click, TableLayoutPanel1.Click

        For Each t As TableLayoutPanel In EtudiantPanel.Controls
            DirectCast(t, TableLayoutPanel).BackgroundImage = My.Resources.table_blanc
        Next

        With DirectCast(sender, TableLayoutPanel)
            .BackgroundImage = My.Resources.table_bleu
            SelectedStudent = CType(sender.Name.ToString.Chars(sender.Name.ToString.Length - 1).ToString, Integer)
            StudentList.Clear()
            StudentList.Add(New Etudiant(BDD.GetFromTable(BDD.nomTableEtudiant, New Critere(BDD.champsMATRIN, filtredTable.Rows.Item(SelectedStudent - 1 + (CURRENT_PAGE - 1) * 7)(BDD.champsMATRIN), BDD.nomTableEtudiant))))
            Console.WriteLine(SelectedStudent - 1 + (CURRENT_PAGE - 1) * 7)

        End With

        For Each b As Control In Home.NavBar.Controls
            If b.GetType.ToString = "System.Windows.Forms.Button" Then
                b.Enabled = True
            End If
        Next

    End Sub

    'Private Sub P1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    For Each b As Button In PagesButtons.Controls
    '        b.BackgroundImage = My.Resources.page_num
    '    Next

    '    If CURRENT_PAGE <> 1 Or Not CType(sender, Control).Name.Equals("PrevButton") Then
    '        If CType(sender, Control).Name.Equals("PrevButton") Or CURRENT_PAGE = nb_page Then
    '            CURRENT_PAGE -= 1
    '        Else
    '            CURRENT_PAGE += 1
    '        End If
    '    End If

    '    If CURRENT_PAGE = 1 Then
    '        PrevButton.Enabled = False
    '        MiddleButton.Enabled = True
    '        NextButton.Enabled = True
    '        PrevButton.BackgroundImage = My.Resources.page_num_current
    '    ElseIf CURRENT_PAGE = nb_page Then
    '        NextButton.BackgroundImage = My.Resources.page_num_current
    '        PrevButton.Enabled = True
    '        MiddleButton.Enabled = True
    '        NextButton.Enabled = False
    '    Else
    '        PrevButton.Enabled = True
    '        MiddleButton.Enabled = False
    '        NextButton.Enabled = True
    '        MiddleButton.BackgroundImage = My.Resources.page_num_current
    '    End If

    '    Console.WriteLine("the page is :" + CURRENT_PAGE.ToString)
    '    affich_pageResult()
    'End Sub

    Public Sub affich_pageResult()

        EtudiantPanel.Visible = True
        'inisializer le bar des pages
        If (StudentTable.Rows.Count Mod 7) = 0 Then
            nb_page = filtredTable.Rows.Count \ 7
        Else
            nb_page = (filtredTable.Rows.Count \ 7) + 1
        End If

        If nb_page <= 4 Then
            DownButton.Enabled = False
            UpButton.Enabled = False
            If nb_page <= 3 Then
                BT_P4.Visible = False
            End If
            If nb_page <= 2 Then
                BT_P3.Visible = False
            End If
            If nb_page <= 1 Then
                BT_P2.Visible = False
            End If
        End If

        'If nb_page <= 2 Then
        '    NextButton.Enabled = False
        '    If nb_page = 1 Then
        '        MiddleButton.Enabled = False
        '        PrevButton.Enabled = False
        '    End If
        'End If

        Dim i As Integer = 0
        Dim cpt As Integer = (CURRENT_PAGE - 1) * 7
        ' inisializer le nombre des esist
        Me.RechLabel.Text = "Classement (" + filtredTable.Rows.Count.ToString + ")"
        For Each ctrl As Control In EtudiantPanel.Controls
            ctrl.Visible = True
        Next
        StudentList.Clear()
        'Console.WriteLine("Called !")
        While (cpt < filtredTable.Rows.Count And i < 7)
            'StudentList.Add(New Etudiant(StudentTable.Rows.Item(cpt)))
            Dim c As Control = EtudiantPanel.Controls.Find("Label" + (i + 1).ToString + "_0", True)(0)
            If c IsNot Nothing Then
                Try
                    CType(c, Label).ForeColor = Color.Black
                    CType(c, Label).Text = (cpt + 1).ToString
                Catch ex As InvalidCastException
                    With CType(c, Label)
                        .ForeColor = Color.Red
                        CType(c, Label).Text = "Unknown"
                    End With
                End Try
            End If

            c = EtudiantPanel.Controls.Find("Label" + (i + 1).ToString + "_1", True)(0)
            If c IsNot Nothing Then
                Try
                    CType(c, Label).ForeColor = Color.Black
                    CType(c, Label).Text = filtredTable.Rows.Item(cpt)("NomEtud")
                Catch ex As InvalidCastException
                    With CType(c, Label)
                        .ForeColor = Color.Red
                        CType(c, Label).Text = "Unknown"
                    End With
                End Try
            End If

            c = EtudiantPanel.Controls.Find("Label" + (i + 1).ToString + "_2", True)(0)
            If c IsNot Nothing Then
                Try
                    CType(c, Label).ForeColor = Color.Black
                    CType(c, Label).Text = filtredTable.Rows.Item(cpt)("Prenoms")
                Catch ex As InvalidCastException
                    With CType(c, Label)
                        .ForeColor = Color.Red
                        .Text = "Unknown"
                    End With
                End Try
            End If

            c = EtudiantPanel.Controls.Find("Label" + (i + 1).ToString + "_3", True)(0)
            If c IsNot Nothing Then
                Try
                    CType(c, Label).ForeColor = Color.Black
                    CType(c, Label).Text = filtredTable.Rows.Item(cpt)("MATRIN")
                Catch ex As InvalidCastException
                    With CType(c, Label)
                        .ForeColor = Color.Red
                        .Text = "Unknown"
                    End With
                End Try
            End If

            c = EtudiantPanel.Controls.Find("Label" + (i + 1).ToString + "_4", True)(0)
            If c IsNot Nothing Then
                Try
                    CType(c, Label).ForeColor = Color.Black
                    CType(c, Label).Text = Math.Round(filtredTable.Rows.Item(cpt)("MoyClassement"), 2)
                Catch ex As InvalidCastException
                    With CType(c, Label)
                        .ForeColor = Color.Red
                        .Text = "Unknown , Unknown"
                    End With
                End Try
            End If

            c = EtudiantPanel.Controls.Find("Label" + (i + 1).ToString + "_5", True)(0)
            If c IsNot Nothing Then
                Try
                    CType(c, Label).ForeColor = Color.Black
                    CType(c, Label).Text = StudentTable.Rows.Item(cpt)(BDD.champsANNEEBAC)
                Catch ex As InvalidCastException
                    With CType(c, Label)
                        .ForeColor = Color.Red
                        .Text = "Unknown"
                    End With
                End Try
            End If

            c = EtudiantPanel.Controls.Find("Label" + (i + 1).ToString + "_6", True)(0)
            If c IsNot Nothing Then
                Try
                    CType(c, Label).ForeColor = Color.Black
                    CType(c, Label).Text = filtredTable.Rows.Item(cpt)(BDD.champsCodePromo).ToString.Substring(filtredTable.Rows.Item(cpt)(BDD.champsCodePromo).ToString.IndexOf("/") + 1, filtredTable.Rows.Item(cpt)(BDD.champsCodePromo).ToString.LastIndexOf("/") - filtredTable.Rows.Item(cpt)(BDD.champsCodePromo).ToString.IndexOf("/") - 1)
                Catch ex As InvalidCastException
                    With CType(c, Label)
                        .ForeColor = Color.Red
                        .Text = "Unknown"
                    End With
                End Try
            End If

            i += 1
            cpt += 1
        End While

        If filtredTable.Rows.Count Mod 7 <> 0 And CURRENT_PAGE = nb_page Then
            For Each ctrl As Control In EtudiantPanel.Controls
                If ctrl.GetType.ToString.Equals("System.Windows.Forms.TableLayoutPanel") Then
                    Dim endb As Integer = 8 - nb_page * 7 + filtredTable.Rows.Count
                    For ind As Integer = 7 To endb Step -1
                        If ctrl.Name.Equals("TableLayoutPanel" + ind.ToString) Then
                            ctrl.Visible = False
                        End If
                    Next

                End If
            Next
        Else
            For Each ctrl As Control In EtudiantPanel.Controls
                ctrl.Visible = True
            Next
        End If

    End Sub

    Private Sub Label1_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1_6.Click, Label1_0.Click, Label1_4.Click, Label1_3.Click, Label1_2.Click, Label1_1.Click, Label1_5.Click
        TableLayoutPanel1_Click(Label1_1.Parent, e)
    End Sub

    Private Sub Label2_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2_0.Click, Label2_4.Click, Label2_3.Click, Label2_2.Click, Label2_1.Click, Label2_5.Click, Label2_6.Click
        TableLayoutPanel1_Click(Label2_1.Parent, e)
    End Sub
    Private Sub Label3_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3_0.Click, Label3_5.Click, Label3_4.Click, Label3_3.Click, Label3_2.Click, Label3_1.Click, Label3_6.Click
        TableLayoutPanel1_Click(Label3_1.Parent, e)
    End Sub
    Private Sub Label4_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4_0.Click, Label4_5.Click, Label4_4.Click, Label4_3.Click, Label4_2.Click, Label4_1.Click, Label4_6.Click
        TableLayoutPanel1_Click(Label4_1.Parent, e)
    End Sub
    Private Sub Label5_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5_0.Click, Label5_5.Click, Label5_4.Click, Label5_3.Click, Label5_2.Click, Label5_1.Click, Label5_6.Click
        TableLayoutPanel1_Click(Label5_1.Parent, e)
    End Sub
    Private Sub Label6_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6_0.Click, Label6_5.Click, Label6_4.Click, Label6_3.Click, Label6_2.Click, Label6_1.Click, Label6_6.Click
        TableLayoutPanel1_Click(Label6_1.Parent, e)
    End Sub
    Private Sub Label17_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7_0.Click, Label7_5.Click, Label7_4.Click, Label7_3.Click, Label7_2.Click, Label7_1.Click, Label7_6.Click
        TableLayoutPanel1_Click(Label7_1.Parent, e)
    End Sub

    Private Sub TableLayoutPanel1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)  'Handles TableLayoutPanel1.Leave, TableLayoutPanel2.Leave, TableLayoutPanel3.Leave, TableLayoutPanel4.Leave, TableLayoutPanel5.Leave, TableLayoutPanel6.Leave, TableLayoutPanel7.Leave
        For Each t As TableLayoutPanel In EtudiantPanel.Controls
            t.BackgroundImage = My.Resources.table_blanc
        Next
        For Each b As Control In Home.NavBar.Controls
            If b.GetType.ToString = "System.Windows.Forms.Button" Then
                b.Enabled = False
            End If
        Next
    End Sub

    Private Sub affichResearchResult_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        'affich_pageResult()
        UpdateClassemntResult()
        Home.MainContainer1.Visible = True
        Home.ProgressPanel.Visible = False
        If StudentTable.Rows.Count > 0 Then
            watch_focusLocation(Me)
        Else
        End If
    End Sub


    Private Sub TableLayoutPanel1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        TableLayoutPanel1_Leave(sender, e)
    End Sub

    Public Sub watch_focusLocation(ByVal ctrlParent As Control)
        For Each ctrl As Control In ctrlParent.Controls
            If Not ctrl.GetType.ToString.Equals("System.Windows.Forms.TableLayoutPanel") Then
                AddHandler ctrl.MouseClick, AddressOf TableLayoutPanel1_Leave
                'Console.WriteLine(ctrl.Name)
                If (ctrl.HasChildren) Then
                    watch_focusLocation(ctrl)
                End If
            End If
        Next
    End Sub

    Private Sub SortDirectionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortDirectionButton.Click
        SortDirectionButton.ImageIndex = (SortDirectionButton.ImageIndex + 1) Mod 2
        SortDirectionAscendant = Not SortDirectionAscendant
        If SortDirectionAscendant Then
            filtredTable = Classement.SortASCCollection(StudentTable, "MoyClassement")
        Else
            filtredTable = Classement.SortDESCollection(StudentTable, "MoyClassement")
        End If
        affich_pageResult()
    End Sub

    Private Sub UpdateClassemntResult()

        If (Integer.Parse(ValueTextBox.Text) >= 1989 And Integer.Parse(ValueTextBox.Text) <= 2011) Then
            StudentTable = Classement.TraitClassement(ValueTextBox.Text)
            saveText = ValueTextBox.Text
        filtredTable = StudentTable.Copy()
        CURRENT_PAGE = 1
        'Form1.ds.Tables.Add(StudentTable.Copy())
        'Form1.Show()
        'StudentTable = Recherche.traitRechercher(crit, RechercherPage.BackgroundWorker1, New System.ComponentModel.DoWorkEventArgs(Nothing))

        Me.RechLabel.Text = "Classement (" + StudentTable.Rows.Count.ToString + ")"
        Console.WriteLine("results number is : " + StudentTable.Rows.Count.ToString)
        If (StudentTable.Rows.Count = 0) Then
            EtudiantPanel.Visible = False
            Console.WriteLine("Liste des etudiants est vide")
        Else
            BT_P1.Visible = True
            BT_P2.Visible = True
            BT_P3.Visible = True
            BT_P4.Visible = True
            UpButton.Enabled = True
            DownButton.Enabled = True

            affich_pageResult()
            Me.BT_P1.Text = "1"
            Me.BT_P2.Text = "2"
            Me.BT_P3.Text = "3"
            Me.BT_P4.Text = "4"
            BT_P1_Click(BT_P1, New EventArgs())
        End If
        SpecialiteBox.Text = ""
        AllCheckBox.Checked = True
            Console.WriteLine("pages number is : " + nb_page.ToString)
        Else
            MsgBox("Veuillez entrer une année comprise entre 1989 et 2011")
            ValueTextBox.Text = saveText

        End If


    End Sub

    Private Sub PREV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PREV.Click
        BT_NEXT.Enabled = True
        Me.ValueTextBox.Text = (Me.ValueTextBox.Text - 1).ToString
        If Me.ValueTextBox.Text = "1989" Then
            Me.BT_PREV.Enabled = False
        End If
        ValueTextBox_PreviewKeyDown(ValueTextBox, New System.Windows.Forms.PreviewKeyDownEventArgs(Keys.Enter))
    End Sub

    Private Sub NEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_NEXT.Click
        BT_PREV.Enabled = True
        Me.ValueTextBox.Text = (Me.ValueTextBox.Text + 1).ToString
        If Me.ValueTextBox.Text = "2011" Then
            Me.BT_NEXT.Enabled = False
        End If
        ValueTextBox_PreviewKeyDown(ValueTextBox, New System.Windows.Forms.PreviewKeyDownEventArgs(Keys.Enter))
    End Sub

    Private Sub PromoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromoButton.Click
        ValueTextBox_Click(ValueTextBox, e)
    End Sub

    Private Sub EtudiantPanel_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EtudiantPanel.VisibleChanged
        NoResultLabel.Visible = Not EtudiantPanel.Visible
        Panel1.Visible = EtudiantPanel.Visible
        CritTableLayoutPanel.Visible = EtudiantPanel.Visible
        ClassmentCritPanel.Visible = EtudiantPanel.Visible
        'LimitDomain.Visible = EtudiantPanel.Visible
    End Sub

    'Private Sub ValueTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValueTextBox.Leave, ValueTextBox.Validated, ValueTextBox.LostFocus, ValueTextBox.KeyPress
    '    ValueTextBox.ForeColor = Color.White
    '    ValueTextBox.BackColor = Color.FromArgb(0, 64, 104)
    '    Console.WriteLine(e.GetType.ToString)
    '    GetClassemntResult()
    'End Sub

    Private Sub ValueTextBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValueTextBox.Click, ValueTextBox.MouseDoubleClick
        ValueTextBox.AutoCompleteCustomSource = collectionList
        ValueTextBox.BackColor = Color.White
        ValueTextBox.ForeColor = Color.FromArgb(0, 64, 104)
    End Sub

    'Private Sub ValueTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ValueTextBox.KeyPress

    'End Sub

    Private Sub ValueTextBox_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles ValueTextBox.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            ValueTextBox.ForeColor = Color.White
            ValueTextBox.BackColor = Color.FromArgb(0, 64, 104)
            Console.WriteLine(e.ToString)
            UpdateClassemntResult()
            Me.ActiveControl = Nothing
        End If
    End Sub

    Private Sub ValueTextBox_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ValueTextBox.MouseDoubleClick, ValueTextBox.Click

    End Sub

    Private Sub PromoBox_TextUpdate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecialiteBox.TextUpdate
        Dim Box As ComboBox = CType(sender, ComboBox)
        If Box.Text = "" Then
            Me.FilterButton.Enabled = False
        End If
    End Sub

    Private Sub NiveauBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecialiteBox.SelectedIndexChanged

        If Not SpecialiteBox.Text.Equals("") Or Not AllCheckBox.Checked Then
            Me.FilterButton.Enabled = True
        Else
            Me.FilterButton.Enabled = False
        End If
    End Sub

    Private Sub LimitUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimitUpDown.ValueChanged
        AllCheckBox.Checked = False
        NiveauBox_SelectedIndexChanged(SpecialiteBox, New EventArgs())
    End Sub

    Private Sub AllCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllCheckBox.CheckedChanged
        LimitUpDown.Enabled = Not AllCheckBox.Checked
        NiveauBox_SelectedIndexChanged(SpecialiteBox, New EventArgs())
    End Sub

    Private Sub FilterButton_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterButton.EnabledChanged
        FilterButton.BackColor = IIf(FilterButton.Enabled, Color.FromArgb(0, 64, 104), Color.FromArgb(169, 119, 113))
    End Sub

    Private Sub filterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterButton.Click
        Dim crit As New List(Of Critere)
        crit.Add(New Critere(BDD.champsOption, SpecialiteBox.Text))
        'crit.Add(New Critere(BDD.champsAnnee, ValueTextBox.Text.Substring(2, 2)))

        If Not SpecialiteBox.Text.Equals("") Then
            filtredTable = Classement.FilterDataTableBy(StudentTable, New Critere(BDD.champsOption, SpecialiteBox.Text))
        End If

        If Not AllCheckBox.Checked Then
            filtredTable = Classement.LimitRows(filtredTable, LimitUpDown.Value)
        End If

        'affich_pageResult()
        CURRENT_PAGE = 1
        BT_P1_Click(BT_P1, New EventArgs())
    End Sub

    Private Sub DownButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownButton.Click

        Me.UpButton.Enabled = True
        'Me.BT_PREV.Enabled = True
        Me.BT_P1.Text = (Me.BT_P1.Text + 4).ToString
        Me.BT_P2.Text = (Me.BT_P2.Text + 4).ToString

        If Me.BT_P2.Text > nb_page Then
            BT_P2.Visible = False
            BT_P3.Visible = False
            BT_P4.Visible = False
            DownButton.Enabled = False
        Else
            Me.BT_P3.Text = (Me.BT_P3.Text + 4).ToString
            If Me.BT_P3.Text > nb_page Then
                BT_P3.Visible = False
                BT_P4.Visible = False
                DownButton.Enabled = False
            Else
                Me.BT_P4.Text = (Me.BT_P4.Text + 4).ToString
                If Me.BT_P4.Text > nb_page Then
                    BT_P4.Visible = False
                    DownButton.Enabled = False
                ElseIf Me.BT_P4.Text = nb_page Then
                    DownButton.Enabled = False
                End If
            End If
        End If
        BT_P1_Click(BT_P1, e)
    End Sub

    Private Sub UpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpButton.Click
        BT_P1.Visible = True
        BT_P2.Visible = True
        BT_P3.Visible = True
        BT_P4.Visible = True
        DownButton.Enabled = True

        If Me.BT_P1.Text = "1" Then
            Me.UpButton.Enabled = False
        Else
            Me.BT_P1.Text = (Me.BT_P1.Text - 4).ToString
            Me.BT_P2.Text = (Me.BT_P1.Text + 1).ToString
            Me.BT_P3.Text = (Me.BT_P1.Text + 2).ToString
            Me.BT_P4.Text = (Me.BT_P1.Text + 3).ToString
        End If

        BT_P1_Click(BT_P1, e)
    End Sub

    Private Sub BT_P1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_P1.Click, BT_P4.Click, BT_P3.Click, BT_P2.Click ', PrevButton.Click, NextButton.Click, MiddleButton.Click
        For Each b As Button In PagesNumButtons.Controls
            b.BackgroundImage = My.Resources.page_num
        Next
        sender.BackgroundImage = My.Resources.page_num_current
        CURRENT_PAGE = CType(CType(sender, Button).Text, Integer)
        affich_pageResult()
    End Sub

End Class