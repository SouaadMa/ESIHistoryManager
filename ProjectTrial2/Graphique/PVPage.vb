Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports.Engine.FieldObject
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Data.SqlClient

Public Class PVPage

    Private Sub PVPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'initialize the graphic componants values

        CrystalReportViewer1.Enabled = False
        Me.AffichButton.Enabled = Not Me.AffichButton.Enabled

        AllCheckBox.Checked = True
        LimitUpDown.Enabled = False

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
        Dim ds As New DataSet   'the dataset which will be assigned to the report
        Dim cryrpt As New PvReport

        'call the pv function to get the dataset

        ds = SortiePV.PV_DELIBERATION(NiveauBox.Text.Remove(0, 1), SpecialiteBox.Text, PromoBox.Text.Remove(0, 2))
        ' if there is a limit to viewed students , then remove the rest from the datatable
        If Not AllCheckBox.Checked Then
            'FormulaField = FormulaFields.Item("limit")
            'FormulaField.Text = LimitUpDown.Value.ToString + " ;"
            While ds.Tables(0).Rows.Count > LimitUpDown.Value
                ds.Tables(0).Rows.RemoveAt(LimitUpDown.Value)
            End While
        End If

        'initilize the textboxes of promotion and annee
        Dim TextObj As CrystalDecisions.CrystalReports.Engine.TextObject

        For Each CryObj As CrystalDecisions.CrystalReports.Engine.ReportObject In cryrpt.Section2.ReportObjects
            If CryObj.GetType().ToString.Equals("CrystalDecisions.CrystalReports.Engine.TextObject") Then
                TextObj = CryObj
                Select Case TextObj.Name
                    Case "PromoString"
                        TextObj.Text = NiveauBox.Text + IIf(NiveauBox.SelectedIndex > 0, " er", " ème") + " ANNEE INGENIEUR - " + SpecialiteBox.Text
                    Case "AnneeString"
                        TextObj.Text = PromoBox.Text + " - " + (PromoBox.SelectedIndex + 1990).ToString
                End Select
            End If
        Next

        'assign the dataset first table to the report

        cryrpt.SetDataSource(ds.Tables(0))
        cryrpt.Database.Tables(0).SetDataSource(ds)

        'get the collection of formulas fields in the report

        Dim FormulaFields As FormulaFieldDefinitions    ' the collection 
        Dim FormulaField As FormulaFieldDefinition      ' an item of the collection

        FormulaFields = cryrpt.DataDefinition.FormulaFields

        For i As Integer = 9 To ds.Tables(0).Columns.Count - 1 Step 1   ' for each subject in the datatable
            'get the corresponding formula item
            FormulaField = FormulaFields.Item("UnboundNumber" + (i - 8).ToString)
            'assign the corresponding subject colonnes to the formula
            FormulaField.Text = "{" + cryrpt.Database.Tables.Item(0).Name + "." + cryrpt.Database.Tables(0).Fields.Item(i).Name + "} ;"
            ' get the corresponding column header  
            TextObj = CType(cryrpt.Section2.ReportObjects.Item("UnboundNumber" + (i - 8).ToString + "1Text"), CrystalDecisions.CrystalReports.Engine.TextObject)
            ' assign it the subject name and coeff
            TextObj.Text = ds.Tables.Item(1).Rows(i - 9)(BDD.champsCOMAMA).ToString + Environment.NewLine + ds.Tables.Item(1).Rows(i - 9)(BDD.champsCOEFMA).ToString
        Next

        ' calculate the blank space in the report (if the subjects counts is less than 8 )
        Dim blankSpace As Integer = 8 - ds.Tables(1).Rows.Count

        'if so
        If 0 < blankSpace Then
            'get the report fiels of en tete section and details section
            Dim Fields2 As CrystalDecisions.CrystalReports.Engine.ReportObjects = cryrpt.Section2.ReportObjects
            Dim Fields3 As CrystalDecisions.CrystalReports.Engine.ReportObjects = cryrpt.Section3.ReportObjects
            Dim Fieldsnames As New List(Of String)

            ' get the details fields names
            For Each field As FieldObject In Fields3
                Fieldsnames.Add(field.Name)
            Next
            'the blank space calculation
            blankSpace *= Fields3.Item("UnboundNumber11Text").Width
            ' assign its values to the blankspace field formula
            FormulaField = FormulaFields.Item("blankSpace")
            FormulaField.Text = blankSpace.ToString + ";"

            'remove the names of the suppressed columns from the report
            For i As Integer = 8 To ds.Tables(1).Rows.Count + 1 Step -1
                TextObj = Fields2.Item("UnboundNumber" + i.ToString + "1Text")
                Fieldsnames.Remove("UnboundNumber" + i.ToString + "1Text")
                Fieldsnames.Remove("UnboundNumber" + i.ToString + "1")
                TextObj.Text = ""
                TextObj.Width = 0
                TextObj.Height = 0
            Next

            While Fieldsnames.Count <> 0    'for each field in thed etails section
                'if the field at the right of blank space , then shift it with its header to the right and suppress their names 
                If (Fields3.Item(Fieldsnames.Item(0)).Left >= cryrpt.Section2.ReportObjects.Item("ELIMININ1").Left) Then
                    Fields3.Item(Fieldsnames.Item(0)).Left -= blankSpace \ 2
                    Fields2.Item(Fieldsnames.Item(0) + "Text").Left -= blankSpace \ 2
                    Fieldsnames.Remove(Fieldsnames.Item(0))
                Else    ' if it is on the right , then shift it to the right with its header , but if it is the column of a formula , them
                    ' then shift just the header (crytal don't move formula fileds without a formula , the formula is in crytal
                    ' it maniplate the blankspace formula filed that was sent earlier to the report 
                    ' and then suppress their names
                    If (Not Fieldsnames.Item(0).Contains("UnboundNumber")) Then
                        Fields3.Item(Fieldsnames.Item(0)).Left += blankSpace \ 2
                    End If
                    Fields2.Item(Fieldsnames.Item(0) + "Text").Left += blankSpace \ 2
                    Fieldsnames.Remove(Fieldsnames.Item(0))
                End If
            End While

        End If
        ' refresh the report to view the changes
        CrystalReportViewer1.RefreshReport()
        'Set the report viewer report objet 
            CrystalReportViewer1.ReportSource = cryrpt
        'set the zoom factor the width of the page
        CrystalReportViewer1.Zoom(1)
        ' if the bule side bar is opened , then close it by simulating a mouse click on the menu button to make the view more big
            If (Home.MainContainer1.Width <= 700) Then
            Home.MenuButton_Click(Home.MenuButton, New MouseEventArgs(MouseButtons.Middle, 1, 15, 15, 0))
        End If
        ' make the report viewer visible
        CrystalReportViewer1.Visible = True
        'disbale the affich button until any combobox values has been changed
        AffichButton.Enabled = False
        ' and that's it !
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

    Private Sub LimitUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimitUpDown.ValueChanged
        AllCheckBox.Checked = False
        NiveauBox_SelectedIndexChanged(PromoBox, New EventArgs())
    End Sub

    Private Sub AllCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllCheckBox.CheckedChanged
        LimitUpDown.Enabled = Not AllCheckBox.Checked
        NiveauBox_SelectedIndexChanged(PromoBox, New EventArgs())
    End Sub

    Private Sub AffichButton_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AffichButton.EnabledChanged
        AffichButton.BackColor = IIf(AffichButton.Enabled, Color.FromArgb(0, 64, 104), Color.FromArgb(169, 119, 113))
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

'For Each FieldObj As CrystalDecisions.CrystalReports.Engine.FieldObject In cryrpt.Section3.ReportObjects
'    Dim c As Char = FieldObj.Name.Chars(FieldObj.Name.Count - 1)
'    If FieldObj.Name.StartsWith("MAT") And Val(c) = i - 8 Then 'it is a field of subjects
'               ''''''Could be a database field (table.field)
'        Exit For
'    End If
'Next


'EvaluateAfter ({@UnboundNumber8}) ;
'DefaultAttribute + (975*3*2 \ 2)