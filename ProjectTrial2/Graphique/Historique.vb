Public Class Historique

    Dim esistselect As Etudiant ' letudiant selection f affichresult

    Public Sub New(ByVal e As Etudiant)

        ' This call is required by the designer.
        InitializeComponent()
        esistselect = e
        ' Add any initialization after the InitializeComponent() call.

    End Sub

  



    Private Sub BT_SORTIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SORTIR.Click
        Me.Close()
        'Home.f.Show()
        Home.MainContainer2.Visible = False
        Home.MainContainer1.Visible = True
    End Sub

    

    Private Sub Historique_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'initialiser annee
        'initialiser de promo
        For Each cr As String In InfosGenerales.promo
            CB_ANNEE.Items.Add(cr)
        Next

        'initialiser generale
        CB_ANNEE.SelectedIndex = 0

        'initialiser les camps de etudiant
        LB_NOM.Text = esistselect.GetInfoChamps("NomEtud")
        LB_DATENAIS.Text = esistselect.GetInfoChamps("DateNais")
        LB_MATRIN.Text = esistselect.GetInfoChamps("MATRIN")
        LB_PRENOM.Text = esistselect.GetInfoChamps("Prenoms")


    End Sub

    Private Sub BT_NEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_NEXT.Click
        CB_ANNEE.SelectedIndex = CB_ANNEE.SelectedIndex + 1
        If CB_ANNEE.SelectedIndex = 4 Then
            BT_NEXT.Enabled = False
        End If
    End Sub

    Private Sub BT_PREV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PREV.Click
        CB_ANNEE.SelectedIndex = CB_ANNEE.SelectedIndex - 1
        If CB_ANNEE.SelectedIndex = 0 Then
            BT_PREV.Enabled = False
        End If
    End Sub

    Private Sub BT_ANNEE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ANNEE.Click
        BT_ANNEE.Visible = False
        CB_ANNEE.Visible = True

    End Sub

    Private Sub CB_ANNEE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_ANNEE.SelectedIndexChanged
        If CB_ANNEE.SelectedIndex = 0 Then
            BT_PREV.Enabled = False
        ElseIf CB_ANNEE.SelectedIndex = 4 Then
            BT_NEXT.Enabled = False
        Else
            BT_NEXT.Enabled = True
            BT_PREV.Enabled = True
        End If
        BT_ANNEE.Text = CB_ANNEE.Text

    End Sub
End Class