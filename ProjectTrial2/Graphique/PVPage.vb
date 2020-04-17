Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Data.SqlClient

Public Class PVPage

    Private Sub PVPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.Zoom(1)
        CrystalReportViewer1.Visible = False

        Dim sqlString As String = "SELECT MATRIN, NomEtud, Prenoms FROM ETUDIANT"
        'New OleDbDataAdapter(sqlString, adoOleDbConnection)
        Dim ds As New DataSet1
        Dim dt As New DataTable()
        Dim adp As OleDbDataAdapter = New OleDbDataAdapter(sqlString, New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\BDD_TABLES_ECLATES.accdb"))
        adp.Fill(ds.DataTable1)
        dt = ds.Tables("DataTable1")
        ds.Tables.Item(0).Merge(dt)
        CrystalReportViewer1.RefreshReport()
        Dim cryrpt As New CrystalReport1
        'cryrpt.Load(server)
        cryrpt.SetDataSource(ds.Tables(0))
        cryrpt.Database.Tables(0).SetDataSource(ds)
        CrystalReportViewer1.ReportSource = cryrpt
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CrystalReportViewer1.Visible = True
        'CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.Zoom(1)
        'CrystalReportViewer1.ShowGroupTreeButton = False
        'CrystalReportViewer1.ShowPageNavigateButtons = False
        'CrystalReportViewer1.ShowParameterPanelButton = False
    End Sub

    
    Private Sub CrystalReportViewer1_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.VisibleChanged
        Button1.Visible = Not CrystalReportViewer1.Visible
    End Sub

    Public Function getAllOrders() As DataTable
        Dim sqlCon As String = "User ID=sa;PWD=sa; server=databaseservername;INITIAL CATALOG=SampleDB;" + "PERSISTSECURITY INFO=FALSE;Connect Timeout=0"
        Dim ds As DataSet = Nothing


        Return ds.Tables.Item(0)
    End Function

    
End Class