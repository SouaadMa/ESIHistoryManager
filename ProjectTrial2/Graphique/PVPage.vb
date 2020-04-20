Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Data.SqlClient

Public Class PVPage

    Private Sub PVPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.Visible = False
        Me.AffichButton.Enabled = False

        For Each Critere As String In InfosGenerales.promo
            Me.NiveauBox.Items.Add(Critere)
        Next

        For Each Critere As String In InfosGenerales.specialite
            Me.SpecialiteBox.Items.Add(Critere)
        Next

        For i = InfosGenerales.firstYear To InfosGenerales.lastYear
            Me.PromoBox.Items.Add(i)
        Next

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AffichButton.Click
        CrystalReportViewer1.Visible = True

        CrystalReportViewer1.Zoom(1)
        CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.Zoom(1)
        CrystalReportViewer1.Visible = False

        Dim sqlString As String = "SELECT MATRIN, NomEtud, Prenoms FROM ETUDIANT"
        'New OleDbDataAdapter(sqlString, adoOleDbConnection)
        Dim ds As New PvDataSet
        Dim dt As New DataTable()
        Dim adp As OleDbDataAdapter = New OleDbDataAdapter(sqlString, New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\BDD_TESTE.accdb"))
        adp.Fill(ds.DataTable1)
        dt = ds.Tables("DataTable1")
        ds.Tables.Item(0).Merge(dt)

        ds = SortiePV.PV_DELIBERATION(NiveauBox.Text, SpecialiteBox.Text, PromoBox.Text)
        CrystalReportViewer1.RefreshReport()
        Dim cryrpt As New PvReport

        cryrpt.SetDataSource(ds.Tables(0))
        cryrpt.Database.Tables(0).SetDataSource(ds)
        CrystalReportViewer1.ReportSource = cryrpt

        'CrystalReportViewer1.ShowGroupTreeButton = False
        'CrystalReportViewer1.ShowPageNavigateButtons = False
        'CrystalReportViewer1.ShowParameterPanelButton = False
    End Sub

    Private Sub PromoBox_TextUpdate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecialiteBox.TextUpdate, PromoBox.TextUpdate, NiveauBox.TextUpdate
        Dim Box As ComboBox = CType(sender, ComboBox)
        If Box.Text = "" Then
            Me.AffichButton.Enabled = False
        ElseIf SpecialiteBox.Text <> "" And NiveauBox.Text <> "" And PromoBox.Text <> "" Then
            Me.AffichButton.Enabled = True
        End If
    End Sub

    Private Sub NiveauBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NiveauBox.SelectedIndexChanged
        If CType(sender, ComboBox).SelectedIndex < 3 Then
            If (Me.SpecialiteBox.Items.Count < 3) Then
                Me.SpecialiteBox.Items.Insert(0, "TRC")
            End If
            Me.SpecialiteBox.SelectedIndex = 0
            Me.SpecialiteBox.Enabled = False
        Else
            Me.SpecialiteBox.Items.Remove(Me.SpecialiteBox.Items(0))
            Me.SpecialiteBox.Enabled = True
        End If
    End Sub

End Class

'Public Function getAllOrders() As DataTable
'    Dim sqlCon As String = "User ID=sa;PWD=sa; server=databaseservername;INITIAL CATALOG=SampleDB;" + "PERSISTSECURITY INFO=FALSE;Connect Timeout=0"
'    Dim ds As DataSet = Nothing
'    Return ds.Tables.Item(0)
'End Function