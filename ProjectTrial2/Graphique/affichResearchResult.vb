Public Class affichResearchResult

    Public Shared StudentList As New List(Of Etudiant)
    Private nb_page As Integer = 0
    Public Shared CURRENT_PAGE As Integer = 1
    Public Shared SelectedStudent As Integer = -1

    Public Sub New(ByVal CritList)

        ' This call is required by the designer.
        InitializeComponent()
        StudentList = Recherche.traitRechercher(CritList)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub affichResearchResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim tab_etudiant() As String = collection_etudiant.ToArray

        ' inisializer le form
        'Console.WriteLine("loaded :" + Me.GetType.ToString)
        EtudiantPanel.Visible = True
        PN_PAGES.Visible = True
        LB_INFOAFFICH.Visible = True
        NoResultLabel.Visible = False
        BT_PREV.Enabled = False

        SortModeBox.Items.Add("Matricule")
        SortModeBox.Items.Add("Nom")
        SortModeBox.Items.Add("Prenom")
        SortModeBox.Items.Add("Promo")

        SortModeBox.SelectedIndex = 0

        'make the nav bar desactivated

        For Each b As Control In Home.NavBar.Controls
            If b.GetType.ToString = "System.Windows.Forms.Button" Then
                b.Enabled = False
            End If
        Next

        BT_P1.BackgroundImage = My.Resources.page_num_current

        'appel a la fonction qui nous donne la collection des etudiants 
        Me.AffPanel.Dock = DockStyle.Fill   ' dock the seach form in the parent container

        Classement.SortCollection(StudentList, "MATRIN")

        Console.WriteLine("results number is : " + StudentList.Count.ToString)
        If (StudentList.Count = 0) Then
            EtudiantPanel.Visible = False
            'AffPanel.Visible = False
            PN_PAGES.Visible = False
            LB_INFOAFFICH.Visible = False
            NoResultLabel.Visible = True
            SortModeBox.Visible = False
            triLabel.Visible = False
            Console.WriteLine("Liste des etudiants est vide")
        Else
            'affich_pageResult()
            SortModeBox_SelectedIndexChanged(SortModeBox, New EventArgs())


            'Console.Write(student.GetInfoChamps("NomEtud"))
            'Console.Write(student.GetInfoChamps("Prenoms"))
            'Console.Write(student.GetInfoChamps("MATRIN"))
            'Console.Write(student.GetInfoChamps("ADRESSE"))
            'Console.Write(student.GetInfoChamps("VILLE"))
            'Console.Write(student.GetInfoChamps("WILAYA"))
            'Console.Write(student.GetInfoChamps("ANNEEBAC"))
            'Console.WriteLine()
            'Console.WriteLine()
        End If

        ' inisializer le nombre des esist
        Me.RechLabel.Text += "(" + StudentList.Count.ToString + ")"

        'inisializer le bar des pages
        If (StudentList.Count Mod 7) = 0 Then
            nb_page = StudentList.Count \ 7
        Else
            nb_page = (StudentList.Count \ 7) + 1
        End If

        Console.WriteLine("pages number is : " + nb_page.ToString)

        If nb_page = 0 Then 'if there is no result

        Else
            If nb_page <= 4 Then
                BT_NEXT.Enabled = False
                BT_PREV.Enabled = False
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


            'inisializer le tab de laffichage 


        End If

    End Sub


    Private Sub BT_NEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_NEXT.Click

        Me.BT_PREV.Enabled = True
        'Me.BT_PREV.Enabled = True
        Me.BT_P1.Text = (Me.BT_P1.Text + 4).ToString
        Me.BT_P2.Text = (Me.BT_P2.Text + 4).ToString

        If Me.BT_P2.Text > nb_page Then
            BT_P2.Visible = False
            BT_P3.Visible = False
            BT_P4.Visible = False
            BT_NEXT.Enabled = False
        Else
            Me.BT_P3.Text = (Me.BT_P3.Text + 4).ToString
            If Me.BT_P3.Text > nb_page Then
                BT_P3.Visible = False
                BT_P4.Visible = False
                BT_NEXT.Enabled = False
            Else
                Me.BT_P4.Text = (Me.BT_P4.Text + 4).ToString
                If Me.BT_P4.Text > nb_page Then
                    BT_P4.Visible = False
                    BT_NEXT.Enabled = False
                ElseIf Me.BT_P4.Text = nb_page Then
                    BT_NEXT.Enabled = False
                End If
            End If
        End If
        BT_P1_Click(BT_P1, e)
    End Sub

    Private Sub BT_PREV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PREV.Click
        BT_P1.Visible = True
        BT_P2.Visible = True
        BT_P3.Visible = True
        BT_P4.Visible = True
        BT_NEXT.Enabled = True

        If Me.BT_P1.Text = "1" Then
            Me.BT_PREV.Enabled = False
        Else
            Me.BT_P1.Text = (Me.BT_P1.Text - 4).ToString
            Me.BT_P2.Text = (Me.BT_P1.Text + 1).ToString
            Me.BT_P3.Text = (Me.BT_P1.Text + 2).ToString
            Me.BT_P4.Text = (Me.BT_P1.Text + 3).ToString
        End If

        BT_P1_Click(BT_P1, e)
    End Sub

    Private Sub TableLayoutPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TableLayoutPanel1.Click, TableLayoutPanel2.Click, TableLayoutPanel3.Click, TableLayoutPanel4.Click, TableLayoutPanel5.Click, TableLayoutPanel6.Click, TableLayoutPanel7.Click

        For Each t As TableLayoutPanel In EtudiantPanel.Controls
            DirectCast(t, TableLayoutPanel).BackgroundImage = My.Resources.table_blanc
        Next

        With DirectCast(sender, TableLayoutPanel)
            .BackgroundImage = My.Resources.table_bleu
            SelectedStudent = CType(sender.Name.ToString.Chars(sender.Name.ToString.Length - 1).ToString, Integer)

            Console.WriteLine(SelectedStudent - 1 + (CURRENT_PAGE - 1) * 7)

        End With

        For Each b As Control In Home.NavBar.Controls
            If b.GetType.ToString = "System.Windows.Forms.Button" Then
                b.Enabled = True
            End If
        Next

    End Sub

    Private Sub BT_P1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_P1.Click, BT_P4.Click, BT_P3.Click, BT_P2.Click
        For Each b As Button In PagesNumButtons.Controls
            b.BackgroundImage = My.Resources.page_num
        Next
        sender.BackgroundImage = My.Resources.page_num_current
        CURRENT_PAGE = CType(CType(sender, Button).Text, Integer)
        affich_pageResult()
    End Sub


    Private Sub SortModeBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortModeBox.SelectedIndexChanged ', SortModeBox.TextUpdate, SortModeBox.TextChanged, SortModeBox.SelectionChangeCommitted, SortModeBox.SelectedValueChanged, SortModeBox.Leave, SortModeBox.DropDownClosed
        Dim l As List(Of Etudiant)
        Select Case SortModeBox.SelectedIndex
            Case 0
                l = Classement.SortCollection(StudentList, "MATRIN")
                StudentList = l
                affich_pageResult()
            Case 1
                l = Classement.SortCollection(StudentList, "NomEtud")
                StudentList = l
                affich_pageResult()
            Case 2
                l = Classement.SortCollection(StudentList, "Prenoms")
                StudentList = l
                affich_pageResult()
            Case 3
                l = Classement.SortCollection(StudentList, "ANNEEBAC")
                StudentList = l
                affich_pageResult()
        End Select

        'Console.WriteLine("sorted by : " + SortModeBox.SelectedIndex.ToString)
        'For Each student In StudentList
        '    Console.Write(student.GetInfoChamps("NomEtud"))
        '    Console.Write(student.GetInfoChamps("Prenoms"))
        '    Console.Write(student.GetInfoChamps("MATRIN"))
        '    Console.Write(student.GetInfoChamps("ADRESSE"))
        '    Console.Write(student.GetInfoChamps("VILLE"))
        '    Console.Write(student.GetInfoChamps("WILAYA"))
        '    Console.Write(student.GetInfoChamps("ANNEEBAC"))
        '    Console.WriteLine()
        'Next
        'Console.Write(student.GetInfoChamps("NomEtud"))
        'Console.Write(student.GetInfoChamps("Prenoms"))
        'Console.Write(student.GetInfoChamps("MATRIN"))
        'Console.Write(student.GetInfoChamps("ADRESSE"))
        'Console.Write(student.GetInfoChamps("VILLE"))
        'Console.Write(student.GetInfoChamps("WILAYA"))
        'Console.Write(student.GetInfoChamps("ANNEEBAC"))
        'Console.WriteLine()
        'Console.WriteLine()

    End Sub

    Public Sub affich_pageResult()
        Dim i As Integer = 0
        Dim cpt As Integer = (CURRENT_PAGE - 1) * 7
        While cpt < StudentList.Count And i < 7
            i = 0
            While cpt < StudentList.Count And i < 7
                Dim c As Control = EtudiantPanel.Controls.Find("Label" + (i + 1).ToString + "_1", True)(0)
                If c IsNot Nothing Then
                    CType(c, Label).Text = StudentList.Item(cpt).GetInfoChamps("NomEtud")
                End If

                c = EtudiantPanel.Controls.Find("Label" + (i + 1).ToString + "_2", True)(0)
                If c IsNot Nothing Then
                    CType(c, Label).Text = StudentList.Item(cpt).GetInfoChamps("Prenoms")
                End If

                c = EtudiantPanel.Controls.Find("Label" + (i + 1).ToString + "_3", True)(0)
                If c IsNot Nothing Then
                    CType(c, Label).Text = StudentList.Item(cpt).GetInfoChamps("MATRIN")
                End If

                c = EtudiantPanel.Controls.Find("Label" + (i + 1).ToString + "_4", True)(0)
                If c IsNot Nothing Then
                    CType(c, Label).Text = StudentList.Item(cpt).GetInfoChamps("ADRESSE") + StudentList.Item(i).GetInfoChamps("VILLE") + StudentList.Item(i).GetInfoChamps("WILAYA")
                End If

                c = EtudiantPanel.Controls.Find("Label" + (i + 1).ToString + "_5", True)(0)
                If c IsNot Nothing Then
                    CType(c, Label).Text = StudentList.Item(cpt).GetInfoChamps("ANNEEBAC")
                End If

                i += 1
                cpt += 1
            End While
        End While
        If StudentList.Count Mod 7 <> 0 And CURRENT_PAGE = nb_page Then
            For Each ctrl As Control In EtudiantPanel.Controls
                If ctrl.GetType.ToString.Equals("System.Windows.Forms.TableLayoutPanel") Then
                    Dim endb As Integer = 8 - nb_page * 7 + StudentList.Count
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

    Private Sub Label1_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1_1.Click, Label1_2.Click, Label1_3.Click, Label1_4.Click, Label1_5.Click
        TableLayoutPanel1_Click(Label1_1.Parent, e)
    End Sub

    Private Sub Label2_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2_1.Click, Label2_2.Click, Label2_3.Click, Label2_4.Click, Label2_5.Click
        TableLayoutPanel1_Click(Label2_1.Parent, e)
    End Sub
    Private Sub Label3_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3_1.Click, Label3_2.Click, Label3_3.Click, Label3_4.Click, Label3_5.Click
        TableLayoutPanel1_Click(Label3_1.Parent, e)
    End Sub
    Private Sub Label4_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4_1.Click, Label4_2.Click, Label4_3.Click, Label4_4.Click, Label4_5.Click
        TableLayoutPanel1_Click(Label4_1.Parent, e)
    End Sub
    Private Sub Label5_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5_1.Click, Label5_2.Click, Label5_3.Click, Label5_4.Click, Label5_5.Click
        TableLayoutPanel1_Click(Label5_1.Parent, e)
    End Sub
    Private Sub Label6_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6_1.Click, Label6_2.Click, Label6_3.Click, Label6_4.Click, Label6_5.Click
        TableLayoutPanel1_Click(Label6_1.Parent, e)
    End Sub
    Private Sub Label17_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7_1.Click, Label7_2.Click, Label7_3.Click, Label7_4.Click, Label7_5.Click
        TableLayoutPanel1_Click(Label7_1.Parent, e)
    End Sub

    Private Sub TableLayoutPanel1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)  'Handles TableLayoutPanel1.Leave, TableLayoutPanel2.Leave, TableLayoutPanel3.Leave, TableLayoutPanel4.Leave, TableLayoutPanel5.Leave, TableLayoutPanel6.Leave, TableLayoutPanel7.Leave
        'For Each ctrl As Control In DirectCast(sender, TableLayoutPanel).Controls
        '    OnLeave(New EventArgs())
        'Next
        'If Not sender.GetType.ToString.Equals("System.Windows.Forms.TableLayoutPanel") Then
        For Each t As TableLayoutPanel In EtudiantPanel.Controls
            t.BackgroundImage = My.Resources.table_blanc
        Next
        For Each b As Control In Home.NavBar.Controls
            If b.GetType.ToString = "System.Windows.Forms.Button" Then
                b.Enabled = False
            End If
        Next
        'End If
    End Sub

    Private Sub affichResearchResult_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        affich_pageResult()
        If StudentList.Count > 0 Then
            watch_focusLocation(Me)
        End If
    End Sub

    Private Sub BT_P1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If BT_P1.Text = "1" Then
            BT_PREV.Enabled = False
        End If
        If Not BT_P4.Visible Or BT_P4.Text = nb_page.ToString Then
            BT_NEXT.Enabled = False
        End If
    End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    affichResearchResult_Shown(Me, New EventArgs())
    '    'affich_pageResult()
    '    Timer1.Enabled = False
    '    Home.PictureBox1.Visible = False
    'End Sub

    Private Sub TableLayoutPanel1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TableLayoutPanel1.LostFocus, TableLayoutPanel2.LostFocus, TableLayoutPanel3.LostFocus, TableLayoutPanel4.LostFocus, TableLayoutPanel5.LostFocus, TableLayoutPanel6.LostFocus, TableLayoutPanel7.LostFocus
        TableLayoutPanel1_Leave(sender, e)
    End Sub

    Public Sub watch_focusLocation(ByVal ctrlParent As Control)
        For Each ctrl As Control In ctrlParent.Controls
            If Not ctrl.GetType.ToString.Equals("System.Windows.Forms.TableLayoutPanel") Then
                AddHandler ctrl.MouseClick, AddressOf TableLayoutPanel1_Leave
                Console.WriteLine(ctrl.Name)
                If (ctrl.HasChildren) Then
                    watch_focusLocation(ctrl)
                End If
            End If
        Next

    End Sub

End Class