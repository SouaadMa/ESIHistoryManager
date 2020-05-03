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
        Dim ds As DataSet

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
        ' make the report viewer visible
        CrystalReportViewer1.Visible = True
        'disbale the affich button until any combobox values has been changed
        ' and that's it !

        'Form1.ds = ds
        'Form1.Show()


    End Sub



    Private Sub BT_SORTIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SORTIR.Click
        Me.Close()
        'Home.f.Show()
        Home.MainContainer2.Visible = False
        Home.MainContainer1.Visible = True
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class