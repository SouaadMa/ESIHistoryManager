Public Class details

    Dim esistselect As Etudiant ' letudiant selection f affichresult

    Public Sub New(ByVal e As Etudiant)

        ' This call is required by the designer.
        InitializeComponent()
        esistselect = e
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'inisializer les panels
        Me.BT_GENERALINFO.Checked = True
        Me.PN_INFOGENERAL.Visible = True
        Me.PN_RESIDENCE.Visible = False
        Me.PN_BAC.Visible = False

        'initiliser les champs
        Me.LB_ADR.Text = esistselect.GetInfoChamps(BDD.champsADRESSE)
        Me.LB_ANNEEB.Text = esistselect.GetInfoChamps(BDD.champsANNEEBAC)
        Me.LB_CODEPOS.Text = esistselect.GetInfoChamps(BDD.champsCODEPOS)
        Me.LB_DATEN.Text = esistselect.GetInfoChamps(BDD.champsDateNais)
        Me.LB_ETDE.Text = esistselect.GetInfoChamps(BDD.champsET_DE)
        Me.LB_FILSDE.Text = esistselect.GetInfoChamps(BDD.champsFILS_DE)
        Me.LB_LIEUN.Text = esistselect.GetInfoChamps(BDD.champsLieuNais)
        Me.LB_LIEUNA.Text = esistselect.GetInfoChamps(BDD.champsLieuNaisA)
        Me.LB_MATRICUL.Text = esistselect.GetInfoChamps(BDD.champsMATRIN)
        Me.LB_MATRICULB.Text = esistselect.GetInfoChamps(BDD.champsMATRIC_INS)
        Me.LB_MOYBAC.Text = esistselect.GetInfoChamps(BDD.champsMOYBAC)
        Me.LB_NOM.Text = esistselect.GetInfoChamps(BDD.champsNomEtud)
        Me.LB_NOMA.Text = esistselect.GetInfoChamps(BDD.champsNomEtudA)
        Me.LB_PRENOM.Text = esistselect.GetInfoChamps(BDD.champsPrenoms)
        Me.LB_PRENOMA.Text = esistselect.GetInfoChamps(BDD.champsPrenomsA)
        Me.LB_SERI.Text = esistselect.GetInfoChamps(BDD.champsSERIEBAC)
        Me.LB_SEXE.Text = InfosGenerales.sexe(CInt(esistselect.GetInfoChamps(BDD.champsSEXE)))
        Me.LB_VILLE.Text = esistselect.GetInfoChamps(BDD.champsVILLE)
        Me.LB_WILAYA.Text = esistselect.GetInfoChamps(BDD.champsWILAYA)
        Me.LB_WILAYAB.Text = esistselect.GetInfoChamps(BDD.champsWILBAC)
        Me.LB_WILAYAN.Text = esistselect.GetInfoChamps(BDD.champsWILNAIS)
        Me.LB_WILAYANA.Text = esistselect.GetInfoChamps(BDD.champsWilayaNaisA)

    End Sub

    Private Sub BT_GENERALINFO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_GENERALINFO.CheckedChanged
        If Me.BT_GENERALINFO.Checked Then
            Me.BT_GENERALINFO.ForeColor = Color.MidnightBlue
            Me.BT_GENERALINFO.BackgroundImage = My.Resources.backBTcheked
            Me.PN_INFOGENERAL.Visible = True
        Else
            Me.BT_GENERALINFO.ForeColor = Color.Gray
            Me.BT_GENERALINFO.BackgroundImage = My.Resources.backBTchekedNone
            Me.PN_INFOGENERAL.Visible = False
        End If
    End Sub

    Private Sub BT_INFORESIDENCE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_INFORESIDENCE.CheckedChanged
        If Me.BT_INFORESIDENCE.Checked Then
            Me.BT_INFORESIDENCE.ForeColor = Color.MidnightBlue
            Me.BT_INFORESIDENCE.BackgroundImage = My.Resources.backBTcheked
            Me.PN_RESIDENCE.Visible = True
        Else
            Me.BT_INFORESIDENCE.ForeColor = Color.Gray
            Me.BT_INFORESIDENCE.BackgroundImage = My.Resources.backBTchekedNone
            Me.PN_RESIDENCE.Visible = False
        End If
    End Sub

    Private Sub BT_INFOBAC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_INFOBAC.CheckedChanged
        If Me.BT_INFOBAC.Checked Then
            Me.BT_INFOBAC.ForeColor = Color.MidnightBlue
            Me.BT_INFOBAC.BackgroundImage = My.Resources.backBTcheked
            Me.PN_BAC.Visible = True
        Else
            Me.BT_INFOBAC.ForeColor = Color.Gray
            Me.BT_INFOBAC.BackgroundImage = My.Resources.backBTchekedNone
            Me.PN_BAC.Visible = False
        End If
    End Sub

    Private Sub BT_SORTIR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        'Home.f.Show()
        Home.MainContainer2.Visible = False
        Home.MainContainer1.Visible = True
    End Sub
End Class