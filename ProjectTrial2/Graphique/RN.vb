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
        CB_ANNEE.SelectedIndex = 0
        cb_anee = False
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

            'upload le raport crystal
            CrystalReportViewer1.Visible = True

            CrystalReportViewer1.Zoom(1)
            CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.Zoom(1)
            CrystalReportViewer1.Visible = False

            'Dim sqlString As String = "SELECT MATRIN, NomEtud, Prenoms FROM ETUDIANT"
            'New OleDbDataAdapter(sqlString, adoOleDbConnection)
            Dim ds As New RNDataSetxsd
            Dim dt As New DataTable()
            'Dim adp As OleDbDataAdapter = New OleDbDataAdapter(sqlString, New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\BDD_TESTE.accdb"))
            'adp.Fill(ds.DataTable1)
            'dt = ds.Tables("DataTable1")
            'ds.Tables.Item(0).Merge(dt)

            ds = RN.GetDataSet()
            CrystalReportViewer1.RefreshReport()
            Dim cryrpt As New RNCrystalReport

            cryrpt.SetDataSource(ds.Tables(0))
            cryrpt.Database.Tables(0).SetDataSource(ds)
            CrystalReportViewer1.ReportSource = cryrpt

            'CrystalReportViewer1.ShowGroupTreeButton = False
            'CrystalReportViewer1.ShowPageNavigateButtons = False
            'CrystalReportViewer1.ShowParameterPanelButton = False

        End If
        cb_anee = False
    End Sub

    Private Sub CB_ANNEE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_ANNEE.SelectedIndexChanged
        cb_anee = True
    End Sub
End Class