Public Class affichResearchResult

    Private collection_etudiant As New List(Of Etudiant)


    Private Sub affichResearchResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'appel a la fonction qui nous donne la collection des etudiants 


        ' inisializer le nombre des esist
        Me.nb_stdRech.Text = collection_etudiant.Count.ToString

        'inisializer le bar des pages


        'inializer le tab de laffichage 





    End Sub

   
    Private Sub BT_NEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_NEXT.Click
        Me.BT_P1.Text = (Me.BT_P1.Text + 4).ToString
        Me.BT_P2.Text = (Me.BT_P2.Text + 4).ToString
        If Me.BT_P2.Text > Me.nb_stdRech.Text Then
            BT_P2.Visible = False
            BT_P3.Visible = False
            BT_P4.Visible = False
            BT_NEXT.Visible = False

        Else
            Me.BT_P3.Text = (Me.BT_P3.Text + 4).ToString
            If Me.BT_P3.Text > Me.nb_stdRech.Text Then
                BT_P3.Visible = False
                BT_P4.Visible = False
                BT_NEXT.Visible = False
            Else
                Me.BT_P4.Text = (Me.BT_P4.Text + 4).ToString
                If Me.BT_P4.Text > Me.nb_stdRech.Text Then
                    BT_P4.Visible = False
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
End Class