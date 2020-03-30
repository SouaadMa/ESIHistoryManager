Public Class affichResearchResult

    Private collection_etudiant As New List(Of String)
    Private nb_page As Integer

    Private Sub affichResearchResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim tab_etudiant() As String = collection_etudiant.ToArray

        ' inisializer le form

        EtudiantPanel.Visible = True
        PN_PAGES.Visible = True
        nb_stdRech.Visible = True
        LB_INFOAFFICH.Visible = True
        LB_noresult.Visible = False
        BT_PREV.Enabled = False

        'make the nav bar desactivated

        For Each b As Control In Home.NavBar.Controls
            If b.GetType.ToString = "System.Windows.Forms.Button" Then
                b.Enabled = False
            End If
        Next

        BT_P1.BackgroundImage = My.Resources.page_num_current

        'appel a la fonction qui nous donne la collection des etudiants 
        Me.AffPanel.Dock = DockStyle.Fill   ' dock the seach form in the parent container

        ' inisializer le nombre des esist
        Me.nb_stdRech.Text = collection_etudiant.Count.ToString + " etudiants trouves"

        'inisializer le bar des pages
        If (collection_etudiant.Count Mod 7) = 0 Then
            nb_page = collection_etudiant.Count Mod 7
        Else
            nb_page = (collection_etudiant.Count Mod 7) + 1
        End If

        If nb_page = 0 Then 'if there is no result
            'PN_AFFICHRECH.Visible = False
            'PN_PAGES.Visible = False
            'nb_stdRech.Visible = False
            'LB_INFOAFFICH.Visible = False
            'LB_noresult.Visible = True
        Else
            If nb_page <= 4 Then
                BT_NEXT.Visible = False
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

        Me.BT_PREV.Visible = True
        Me.BT_P1.Text = (Me.BT_P1.Text + 4).ToString
        Me.BT_P2.Text = (Me.BT_P2.Text + 4).ToString

        If Me.BT_P2.Text > nb_page Then
            BT_P2.Visible = False
            BT_P3.Visible = False
            BT_P4.Visible = False
            BT_NEXT.Visible = False
        Else
            Me.BT_P3.Text = (Me.BT_P3.Text + 4).ToString
            If Me.BT_P3.Text > nb_page Then
                BT_P3.Visible = False
                BT_P4.Visible = False
                BT_NEXT.Visible = False
            Else
                Me.BT_P4.Text = (Me.BT_P4.Text + 4).ToString
                If Me.BT_P4.Text > nb_page Then
                    BT_P4.Visible = False
                    BT_NEXT.Visible = False
                ElseIf Me.BT_P4.Text = nb_page  Then
                    BT_NEXT.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub BT_PREV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PREV.Click
        Me.BT_P1.Text = (Me.BT_P1.Text - 4).ToString
        Me.BT_P2.Text = (Me.BT_P2.Text - 4).ToString
        Me.BT_P3.Text = (Me.BT_P3.Text - 4).ToString
        Me.BT_P4.Text = (Me.BT_P4.Text - 4).ToString
        If Me.BT_P1.Text = "1" Then
            Me.BT_PREV.Visible = False
        End If
    End Sub
    
    Private Sub TableLayoutPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TableLayoutPanel1.Click, TableLayoutPanel2.Click, TableLayoutPanel3.Click, TableLayoutPanel4.Click, TableLayoutPanel5.Click, TableLayoutPanel6.Click, TableLayoutPanel7.Click

        For Each t As TableLayoutPanel In EtudiantPanel.Controls
            DirectCast(t, TableLayoutPanel).BackgroundImage = My.Resources.background_affiche1
        Next

        DirectCast(sender, TableLayoutPanel).BackgroundImage = My.Resources.background_affiche

        For Each b As Control In Home.NavBar.Controls
            If b.GetType.ToString = "System.Windows.Forms.Button" Then
                b.Enabled = True
            End If
        Next

    End Sub

    Private Sub BT_P1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_P1.Click, BT_P2.Click, BT_P3.Click, BT_P4.Click
        For Each b As Button In PagesNumButtons.Controls
            b.BackgroundImage = My.Resources.page_num
        Next
        sender.BackgroundImage = My.Resources.page_num_current
    End Sub
End Class