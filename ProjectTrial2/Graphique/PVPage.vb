

Public Class PVPage

    Private Sub PVPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.Zoom(2)
        CrystalReportViewer1.Visible = False
        Dim ds As New BDD_TABLES_ECLATESDataSet
        Dim adp As New BDD_TABLES_ECLATESDataSetTableAdapters.ETUDIANTTableAdapter
        Dim dt As New DataTable()

        ds.Tables.Item(0).Merge(dt)

        adp.Fill(ds.ETUDIANT)
        Dim cryrpt As New CrystalReport1
        cryrpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = cryrpt
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CrystalReportViewer1.Visible = True
        'CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.Zoom(2)
        CrystalReportViewer1.ShowGroupTreeButton = False
        CrystalReportViewer1.ShowPageNavigateButtons = False
        CrystalReportViewer1.ShowParameterPanelButton = False
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