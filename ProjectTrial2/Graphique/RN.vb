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


        For Each promo In esistselect.GetALL(BDD.champsCodePromo)
            CB_ANNEE.Items.Add(promo)
        Next


        'For Each cr As String In InfosGenerales.promo
        'CB_ANNEE.Items.Add(cr)
        'Next
        

        Console.WriteLine("RN_Load")

        'initialiser generale
        'CB_ANNEE.SelectedIndex = 0

    End Sub



    Private Sub BT_SORTIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        'Home.f.Show()
        Home.MainContainer2.Visible = False
        Home.MainContainer1.Visible = True
    End Sub




    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Console.WriteLine("CRV_LOAD")

    End Sub

    
    Private Sub BT_LOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_LOAD.Click

        'Console.WriteLine("Click load " + CType(CB_ANNEE.SelectedItem, String) + "jjj")
        'Dim rn As New SortieRN(esistselect, CType(CB_ANNEE.SelectedItem, String))
        'Console.WriteLine("Done")

        Dim dts As DataSet
        'dts = rn.GetDataSet

        'Pour afficher le nombre de RN que cet étudiant a imprimé
        'Dim nbRN = rn.GetNbreRN() 

        Dim r As SortieRN = New SortieRN(esistselect, "1/TRC/04")
        Form2.DataGridView1.DataSource = r.dataSet.Tables(0)
        Form2.Show()
    End Sub

End Class