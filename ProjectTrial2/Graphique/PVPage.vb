Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports.Engine.FieldObject
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Data.SqlClient

Public Class PVPage

    Private Sub PVPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.Enabled = False
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
        CrystalReportViewer1.Enabled = True

        CrystalReportViewer1.Zoom(1)
        CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.Zoom(1)

        Dim ds As New DataSet
        Dim dt As New DataTable()

        CrystalReportViewer1.RefreshReport()
        Dim cryrpt As New PvReport

        ds = SortiePV.PV_DELIBERATION(NiveauBox.Text.Remove(0, 1), SpecialiteBox.Text, PromoBox.Text.Remove(0, 2))

        Dim TextObj As CrystalDecisions.CrystalReports.Engine.TextObject

        For Each CryObj As CrystalDecisions.CrystalReports.Engine.ReportObject In cryrpt.Section2.ReportObjects
            If CryObj.GetType().ToString.Equals("CrystalDecisions.CrystalReports.Engine.TextObject") Then
                TextObj = CryObj
                Select Case TextObj.Text
                    Case "PromoString"
                        TextObj.Text = NiveauBox.Text + IIf(NiveauBox.SelectedIndex > 0, " er", " ème") + " ANNEE INGENIEUR - " + SpecialiteBox.Text
                    Case "AnneeString"
                        TextObj.Text = PromoBox.Text + " - " + (PromoBox.SelectedIndex + 1990).ToString
                End Select
            End If
        Next

        'Dim FldObj As New CrystalDecisions.CrystalReports.Engine.FieldObject()

        'For i As Integer = 8 To ds.Tables(0).Columns.Count - 1 Step 1

        '    For Each FieldObj As CrystalDecisions.CrystalReports.Engine.FieldObject In cryrpt.Section3.ReportObjects
        '        Dim c As Char = FieldObj.Name.Chars(FieldObj.Name.Count - 2)
        '        If c > "0" And c < "9" Then
        '            'FieldObj.DataSource = ds.Tables(0).Columns.Item(i)
        '        End If
        '    Next

        'Next

        cryrpt.SetDataSource(ds.Tables(0))
        cryrpt.Database.Tables(0).SetDataSource(ds)
        CrystalReportViewer1.ReportSource = cryrpt
        CrystalReportViewer1.Visible = True

    End Sub

    Private Sub PromoBox_TextUpdate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecialiteBox.TextUpdate, PromoBox.TextUpdate, NiveauBox.TextUpdate
        Dim Box As ComboBox = CType(sender, ComboBox)
        If Box.Text = "" Then
            Me.AffichButton.Enabled = False
        End If
    End Sub

    Private Sub NiveauBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NiveauBox.SelectedIndexChanged, PromoBox.SelectedIndexChanged, SpecialiteBox.SelectedIndexChanged
        If (CType(sender, Control).Name.Equals(NiveauBox.Name)) Then
            If CType(sender, ComboBox).SelectedIndex < 2 Then
                If (Me.SpecialiteBox.Items.Count < 3) Then
                    Me.SpecialiteBox.Items.Insert(0, "TRC")
                End If
                Me.SpecialiteBox.SelectedIndex = 0
                Me.SpecialiteBox.Enabled = False
            Else
                If SpecialiteBox.Items.Item(0).ToString.Equals("TRC") Then
                    Me.SpecialiteBox.Items.Remove(Me.SpecialiteBox.Items(0))
                    Me.SpecialiteBox.Enabled = True
                End If
            End If
        End If

        If Not SpecialiteBox.Text.Equals("") And Not NiveauBox.Text.Equals("") And Not PromoBox.Text.Equals("") Then
            Me.AffichButton.Enabled = True
        Else
            Me.AffichButton.Enabled = False
        End If
    End Sub

End Class

'Public Function getAllOrders() As DataTable
'    Dim sqlCon As String = "User ID=sa;PWD=sa; server=databaseservername;INITIAL CATALOG=SampleDB;" + "PERSISTSECURITY INFO=FALSE;Connect Timeout=0"
'    Dim ds As DataSet = Nothing
'    Return ds.Tables.Item(0)
'End Function

'Dim sqlString As String = "SELECT MATRIN, NomEtud, Prenoms FROM ETUDIANT"
'New OleDbDataAdapter(sqlString, adoOleDbConnection)
'Dim adp As OleDbDataAdapter = New OleDbDataAdapter(sqlString, New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\BDD_TESTE.accdb"))
'adp.Fill(ds.DataTable1)
'dt = ds.Tables("DataTable1")
'ds.Tables.Item(0).Merge(dt)

'CrystalReportViewer1.ShowGroupTreeButton = False
'CrystalReportViewer1.ShowPageNavigateButtons = False
'CrystalReportViewer1.ShowParameterPanelButton = False