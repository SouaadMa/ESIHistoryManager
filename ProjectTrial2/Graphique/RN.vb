Public Class RN

    Dim esistselect As Etudiant ' letudiant selection f affichresult

    Public Sub New(ByVal e As Etudiant)

        ' This call is required by the designer.
        InitializeComponent()
        esistselect = e
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub RN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'inisializer les panels
        'initialiser de promo
        For Each cr As String In InfosGenerales.promo
            CB_ANNEE.Items.Add(cr)
        Next


        'initialiser generale
        CB_ANNEE.SelectedIndex = 0

    End Sub



    Private Sub BT_SORTIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        'Home.f.Show()
        Home.MainContainer2.Visible = False
        Home.MainContainer1.Visible = True
    End Sub




    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BT_LOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class