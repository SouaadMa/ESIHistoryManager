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
        Me.LB_ADR.Text = esistselect.GetInfoChamps("ADRESSE")
        Me.LB_ANNEEB.Text = esistselect.GetInfoChamps("ANNEEBAC")
        Me.LB_CODEPOS.Text = esistselect.GetInfoChamps("CODPOST")
        Me.LB_DATEN.Text = esistselect.GetInfoChamps("DateNais")
        Me.LB_ETDE.Text = esistselect.GetInfoChamps("ET_DE")
        Me.LB_FILSDE.Text = esistselect.GetInfoChamps("FILS_DE")
        Me.LB_LIEUN.Text = esistselect.GetInfoChamps("LieuNais")
        Me.LB_LIEUNA.Text = esistselect.GetInfoChamps("LieuNaisA")
        Me.LB_MATRICUL.Text = esistselect.GetInfoChamps("MATRIN")
        Me.LB_MATRICULB.Text = esistselect.GetInfoChamps("MATRIC_INS")
        Me.LB_MOYBAC.Text = esistselect.GetInfoChamps("MOYBAC")
        Me.LB_NOM.Text = esistselect.GetInfoChamps("NomEtud")
        Me.LB_NOMA.Text = esistselect.GetInfoChamps("NomEtudA")
        Me.LB_PRENOM.Text = esistselect.GetInfoChamps("Prenoms")
        Me.LB_PRENOMA.Text = esistselect.GetInfoChamps("PrenomsA")
        Me.LB_SERI.Text = esistselect.GetInfoChamps("SERIEBAC")
        Me.LB_SEXE.Text = esistselect.GetInfoChamps("SEXE")
        Me.LB_VILLE.Text = esistselect.GetInfoChamps("VILLE")
        Me.LB_WILAYA.Text = esistselect.GetInfoChamps("WILAYA")
        Me.LB_WILAYAB.Text = esistselect.GetInfoChamps("WILBAC")
        Me.LB_WILAYAN.Text = esistselect.GetInfoChamps("WILNAIS")
        Me.LB_WILAYANA.Text = esistselect.GetInfoChamps("WILNAISA")

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

    Private Sub BT_SORTIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SORTIR.Click
        Me.Close()
        'Home.f.Show()
        Home.MainContainer2.Visible = False
        Home.MainContainer1.Visible = True
    End Sub

End Class