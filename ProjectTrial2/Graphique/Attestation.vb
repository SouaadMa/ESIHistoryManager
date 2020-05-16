Public Class Attestation

    Dim esistselect As Etudiant ' letudiant selection f affichresult

    Public Sub New(ByVal e As Etudiant)

        ' This call is required by the designer.
        InitializeComponent()
        esistselect = e
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub attestation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'inisializer les panels
        NoResultPanel.Visible = False
        ' make the report viewer visible
        CrystalReportViewer1.Visible = True
        
        NomLabel.Text = esistselect.GetInfoChamps(BDD.champsNomEtud)
        PrenomLabel.Text = esistselect.GetInfoChamps(BDD.champsPrenoms)
        Matricule.Text = esistselect.GetInfoChamps(BDD.champsMATRIN)
        AdresseLabel.Text = esistselect.GetInfoChamps(BDD.champsVILLE) + esistselect.GetInfoChamps(BDD.champsWILAYA)
        PromoLabel.Text = esistselect.GetInfoChamps(BDD.champsANNEEBAC)

    End Sub

    Private Sub attestation_shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Dim ds As DataSet
        Try
            ds = SortieAttestation.attestation(esistselect)

            Dim cryrpt As New AttestationCrystalReport

            'assign the dataset tables to the report

            cryrpt.SetDataSource(ds)
            cryrpt.Database.Tables(0).SetDataSource(ds.Tables(0))
            cryrpt.Database.Tables(1).SetDataSource(ds.Tables(1))

            ' refresh the report to view the changes
            CrystalReportViewer1.RefreshReport()
            'Set the report viewer report objet 
            CrystalReportViewer1.ReportSource = cryrpt
            'set the zoom factor the width of the page
            CrystalReportViewer1.Zoom(1)
            ' if the bule side bar is opened , then close it by simulating a mouse click on the menu button to make the view more big
            If (Home.MainContainer1.Width <= 690) Then
                Home.MenuButton_Click(Home.MenuButton, New MouseEventArgs(MouseButtons.Middle, 1, 15, 15, 0))
            End If
        Catch ex As InvalidCastException
            'MsgBox("Impossible de générer le relevé de note général de cet etudiant", , "Erreur")
            'BT_SORTIR_Click(SortirButton, New EventArgs())
            CrystalReportViewer1.Visible = False
            NoResultPanel.Visible = True
            NoResultLabel.Text = "Quelques informations manquent dans l'historique de cet étudiant , veuillez les remplir et recharger la base de données à nouveau."
            BilanLinkLabel.Visible = True
        End Try
        
        ' and that's it !

        'Form1.ds = ds
        'Form1.Show()

    End Sub

    Private Sub BT_SORTIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortirButton.Click
        Me.Close()
        'Home.f.Show()
        Home.MainContainer2.Visible = False
        Home.MainContainer1.Visible = True
    End Sub

    Private Sub BilanLinkLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BilanLinkLabel.Click
        BilanPage.RichTextBox1.Text = SortieAttestation.getBilan()
        BilanPage.Show()
    End Sub
End Class