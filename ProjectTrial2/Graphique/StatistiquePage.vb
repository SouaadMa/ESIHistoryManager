Public Class StatistiquePage


    Private chart_kind() As String = {"Spline", "bar", "column", "piedoughnut"}
    Private critere() As String = {"Réussite & Echec", "Répartition"}



    Private Sub BT_CHARTLOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CHARTLOAD.Click
        'exchange betwen boutton and combobox
        BT_CHARTLOAD.Visible = False
        CB_CHARTKIND.Visible = True

        'collection des criteres




    End Sub

    Private Sub StatistiquePage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'initializer box chart kind 
        For Each kind As String In chart_kind
            CB_CHARTKIND.Items.Add(kind)
        Next
        CB_CHARTKIND.SelectedIndex = 0

        'initializer boutton chart kind 
        BT_CHARTLOAD.Visible = True
        CB_CHARTKIND.Visible = False

        'initialiser specialte
        For Each spe As String In InfosGenerales.specialite
            CHB_SPECIALITE.Items.Add(spe)
        Next

        'initialiser lannee
        For Each ans As String In InfosGenerales.Annee
            CHB_ANNEE.Items.Add(ans)
        Next

        'initialiser de critere
        For Each cr As String In critere
            CB_CRITERE.Items.Add(cr)
        Next

        'initialiser de matiere
        For Each cr As String In Login.Infosgenerale.matiere
            CHB_MAT.Items.Add(cr)
        Next

        'initialiser de groupe
        For Each cr As String In Login.Infosgenerale.groupe
            CHB_GROUPE.Items.Add(cr)
        Next

        'initialiser de section
        For Each cr As String In Login.Infosgenerale.section
            CHB_SECTION.Items.Add(cr)
        Next

        'initialiser de promo
        For Each cr As String In InfosGenerales.promo
            CHB_PROMO.Items.Add(cr)
        Next

        BT_PREV.Enabled = False
        'initialiser le chart



    End Sub

    Private Sub BT_NEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_NEXT.Click
        CB_CHARTKIND.SelectedIndex = CB_CHARTKIND.SelectedIndex + 1
        If CB_CHARTKIND.SelectedIndex = 3 Then
            BT_NEXT.Enabled = False
        End If
    End Sub

    Private Sub BT_PREV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PREV.Click
        CB_CHARTKIND.SelectedIndex = CB_CHARTKIND.SelectedIndex - 1
        If CB_CHARTKIND.SelectedIndex = 0 Then
            BT_PREV.Enabled = False
        End If
    End Sub

    Private Sub CB_CHARTKIND_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_CHARTKIND.SelectedIndexChanged
        If CB_CHARTKIND.SelectedIndex = 0 Then
            BT_PREV.Enabled = False
        ElseIf CB_CHARTKIND.SelectedIndex = 3 Then
            BT_NEXT.Enabled = False
        Else
            BT_NEXT.Enabled = True
            BT_PREV.Enabled = True
        End If
        'changer le kind of chart


    End Sub

    Private Sub CB_CRITERE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_CRITERE.SelectedIndexChanged
        BT_CHARTLOAD.Visible = True
        CB_CHARTKIND.Visible = False
    End Sub

    Private Sub CHB_MAT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHB_MAT.SelectedIndexChanged
        BT_CHARTLOAD.Visible = True
        CB_CHARTKIND.Visible = False
    End Sub

    Private Sub CHB_SPECIALITE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHB_SPECIALITE.SelectedIndexChanged
        BT_CHARTLOAD.Visible = True
        CB_CHARTKIND.Visible = False
    End Sub

    Private Sub CHB_PROMO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHB_PROMO.SelectedIndexChanged
        BT_CHARTLOAD.Visible = True
        CB_CHARTKIND.Visible = False
    End Sub

    Private Sub CHB_SECTION_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHB_SECTION.SelectedIndexChanged
        BT_CHARTLOAD.Visible = True
        CB_CHARTKIND.Visible = False
    End Sub

    Private Sub CHB_GROUPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHB_GROUPE.SelectedIndexChanged
        BT_CHARTLOAD.Visible = True
        CB_CHARTKIND.Visible = False
    End Sub

    Private Sub CHB_ANNEE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHB_ANNEE.SelectedIndexChanged
        BT_CHARTLOAD.Visible = True
        CB_CHARTKIND.Visible = False
    End Sub

    Private Sub TXT_MOYSEUIL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_MOYSEUIL.TextChanged
        BT_CHARTLOAD.Visible = True
        CB_CHARTKIND.Visible = False
    End Sub
End Class