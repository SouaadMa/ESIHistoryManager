Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Data.SqlClient

Public Class RN

    Dim cb_anee As Boolean
    Dim esistselect As Etudiant ' letudiant selection f affichresult
    Dim RN As SortieRN = Nothing

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
        cb_anee = False
        BT_LOAD.Enabled = False
        CrystalReportViewer1.Visible = False

    End Sub



    Private Sub BT_SORTIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Home.MainContainer2.Visible = False
        Home.MainContainer1.Visible = True
    End Sub

    Private Sub BT_LOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_LOAD.Click
        If cb_anee = True Then

            RN = New SortieRN(esistselect, CB_ANNEE.Text)

            CrystalReportViewer1.Enabled = True
            Dim ds As New DataSet   'the dataset which will be assigned to the report
            Dim report As New RNCrystalReport

            Form1.DataGridView1.DataSource = RN.GetDataSet().Tables(0)
            Form1.Show()

        End If
        cb_anee = False
    End Sub

    Private Sub CB_ANNEE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_ANNEE.SelectedIndexChanged
        cb_anee = True
        BT_LOAD.Enabled = True
    End Sub
End Class