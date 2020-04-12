Public Class ClassementPage

    Public StudentList As New List(Of Etudiant)
    Public StudentTable As DataTable
    Private nb_page As Integer = 0
    Public CURRENT_PAGE As Integer = 1
    Public SelectedStudent As Integer = -1
    Public Shared SortDirectionAscendant As Boolean = True


    Private Sub ClassementPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' inisializer le form
        EtudiantPanel.Visible = True
        PN_PAGES.Visible = True
        NoResultLabel.Visible = False
        BT_PREV.Enabled = False
        ListBox.Size = ListBox.MinimumSize

        ClassementModeBox.Items.Add("Promotion")
        ClassementModeBox.Items.Add("Specialite")
        ClassementModeBox.Items.Add("Niveau")
        ClassementModeBox.Items.Add("Section")
        ClassementModeBox.Items.Add("Groupe")

        ClassementModeBox.SelectedIndex = 0

        For i = InfosGenerales.firstYear To InfosGenerales.lastYear
            Me.ListBox.Items.Add(i.ToString)
        Next

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
            StudentList.Add(New Etudiant(StudentTable.Rows.Item(SelectedStudent - 1 + (CURRENT_PAGE - 1) * 7)))
            Console.WriteLine(SelectedStudent - 1 + (CURRENT_PAGE - 1) * 7)

        End With

        For Each b As Control In Home.NavBar.Controls
            If b.GetType.ToString = "System.Windows.Forms.Button" Then
                b.Enabled = True
            End If
        Next

    End Sub

    Private Sub BT_P1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrevButton.Click, NextButton.Click, MiddleButton.Click
        For Each b As Button In PagesButtons.Controls
            b.BackgroundImage = My.Resources.page_num
        Next

        If CURRENT_PAGE <> 1 Or Not CType(sender, Control).Name.Equals("PrevButton") Then
            If CType(sender, Control).Name.Equals("PrevButton") Or CURRENT_PAGE = nb_page Then
                CURRENT_PAGE -= 1
            Else
                CURRENT_PAGE += 1
            End If
        End If

        If CURRENT_PAGE = 1 Then
            PrevButton.Enabled = False
            MiddleButton.Enabled = True
            NextButton.Enabled = True
            PrevButton.BackgroundImage = My.Resources.page_num_current
        ElseIf CURRENT_PAGE = nb_page Then
            NextButton.BackgroundImage = My.Resources.page_num_current
            PrevButton.Enabled = True
            MiddleButton.Enabled = True
            NextButton.Enabled = False
        Else
            PrevButton.Enabled = True
            MiddleButton.Enabled = False
            NextButton.Enabled = True
            MiddleButton.BackgroundImage = My.Resources.page_num_current
        End If

        Console.WriteLine("the page is :" + CURRENT_PAGE.ToString)
        affich_pageResult()
    End Sub

    Private Sub ClassemntModeBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles ClassementModeBox.SelectedIndexChanged  ', SortModeBox.TextUpdate, SortModeBox.TextChanged, SortModeBox.SelectionChangeCommitted, SortModeBox.SelectedValueChanged, SortModeBox.Leave, SortModeBox.DropDownClosed
        Dim l As DataTable = New DataTable()

        Select Case ClassementModeBox.SelectedIndex
            Case 0
                If SortDirectionAscendant Then
                    l = Classement.SortASCCollection(StudentTable, "MATRIN")
                Else
                    l = Classement.SortDESCollection(StudentTable, "MATRIN")
                End If
            Case 1
                If SortDirectionAscendant Then
                    l = Classement.SortASCCollection(StudentTable, "NomEtud")
                Else
                    l = Classement.SortDESCollection(StudentTable, "NomEtud")
                End If
            Case 2
                If SortDirectionAscendant Then
                    l = Classement.SortASCCollection(StudentTable, "Prenoms")
                Else
                    l = Classement.SortDESCollection(StudentTable, "Prenoms")
                End If
            Case 3
                If SortDirectionAscendant Then
                    l = Classement.SortASCCollection(StudentTable, "ANNEEBAC")
                Else
                    l = Classement.SortDESCollection(StudentTable, "ANNEEBAC")
                End If
        End Select
        StudentTable = l
        GetClassemntResult()
    End Sub

    Public Sub affich_pageResult()
        Dim i As Integer = 0
        Dim cpt As Integer = (CURRENT_PAGE - 1) * 7
        ' inisializer le nombre des esist
        Me.RechLabel.Text = "Classement (" + StudentTable.Rows.Count.ToString + ")"
        For Each ctrl As Control In EtudiantPanel.Controls
            ctrl.Visible = True
        Next
        StudentList.Clear()
        'Console.WriteLine("Called !")
        While (cpt < StudentTable.Rows.Count And i < 7)
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
                    CType(c, Label).Text = StudentTable.Rows.Item(cpt)("NomEtud")
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
                    CType(c, Label).Text = StudentTable.Rows.Item(cpt)("Prenoms")
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
                    CType(c, Label).Text = StudentTable.Rows.Item(cpt)("MATRIN")
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
                    CType(c, Label).Text = StudentTable.Rows.Item(cpt)("MOYBAC")
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
                    CType(c, Label).Text = StudentTable.Rows.Item(cpt)("ANNEEBAC")
                Catch ex As InvalidCastException
                    With CType(c, Label)
                        .ForeColor = Color.Red
                        .Text = "Unknown"
                    End With
                End Try
            End If

            'c = EtudiantPanel.Controls.Find("Label" + (i + 1).ToString + "_6", True)(0)
            'If c IsNot Nothing Then
            '    Try
            '        CType(c, Label).ForeColor = Color.Black
            '        CType(c, Label).Text = StudentTable.Rows.Item(cpt)("SPECIALITE")
            '    Catch ex As InvalidCastException
            '        With CType(c, Label)
            '            .ForeColor = Color.Red
            '            .Text = "Unknown"
            '        End With
            '    End Try
            'End If

            i += 1
            cpt += 1
        End While

        If StudentTable.Rows.Count Mod 7 <> 0 And CURRENT_PAGE = nb_page Then
            For Each ctrl As Control In EtudiantPanel.Controls
                If ctrl.GetType.ToString.Equals("System.Windows.Forms.TableLayoutPanel") Then
                    Dim endb As Integer = 8 - nb_page * 7 + StudentTable.Rows.Count
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
        GetClassemntResult()
        Home.MainContainer1.Visible = True
        Home.ProgressPanel.Visible = False
        If StudentTable.Rows.Count > 0 Then
            ClassementModeBox.SelectedIndex = 0
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
            StudentTable = Classement.SortASCCollection(StudentTable, "MOYBAC")
        Else
            StudentTable = Classement.SortDESCollection(StudentTable, "MOYBAC")
        End If
        affich_pageResult()
    End Sub

    Private Sub GetClassemntResult()
        Dim crit As New List(Of Critere)
        crit.Add(New Critere("ANNEEBAC", PromoButton.Text))
        StudentTable = Recherche.traitRechercher(crit, RechercherPage.BackgroundWorker1, New System.ComponentModel.DoWorkEventArgs(Nothing))

        Console.WriteLine("results number is : " + StudentTable.Rows.Count.ToString)
        If (StudentTable.Rows.Count = 0) Then
            EtudiantPanel.Visible = False
            PN_PAGES.Visible = False
            NoResultLabel.Visible = True
            ClassementModeBox.Visible = False
            Console.WriteLine("Liste des etudiants est vide")
        Else
            StudentTable = Classement.SortASCCollection(StudentTable, "MOYBAC")
            'inisializer le bar des pages
            If (StudentTable.Rows.Count Mod 7) = 0 Then
                nb_page = StudentTable.Rows.Count \ 7
            Else
                nb_page = (StudentTable.Rows.Count \ 7) + 1
            End If

            BT_P1_Click(PrevButton, New EventArgs())
            If nb_page <= 2 Then
                NextButton.Enabled = False
                If nb_page = 1 Then
                    MiddleButton.Enabled = False
                    PrevButton.Enabled = False
                End If
            End If
        End If
        Console.WriteLine("pages number is : " + nb_page.ToString)
    End Sub

    Private Sub BT_PREV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PREV.Click
        BT_NEXT.Enabled = True
        If Me.PromoButton.Text = "1990" Then
            Me.BT_PREV.Enabled = False
        Else
            Me.PromoButton.Text = (Me.PromoButton.Text - 1).ToString
        End If
        GetClassemntResult()
    End Sub

    Private Sub BT_NEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_NEXT.Click
        BT_PREV.Enabled = True
        If Me.PromoButton.Text = "2011" Then
            Me.BT_NEXT.Enabled = False
        Else
            Me.PromoButton.Text = (Me.PromoButton.Text + 1).ToString
        End If
        GetClassemntResult()
    End Sub


End Class