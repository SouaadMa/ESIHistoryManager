Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports.Engine.FieldObject
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Data.SqlClient

Public Class RNGPage

    Dim esistselect As Etudiant ' letudiant selection f affichresult

    Public Sub New(ByVal e As Etudiant)

        ' This call is required by the designer.
        InitializeComponent()
        esistselect = e
        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Private Sub RNGPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'initialize the graphic componants values

        CrystalReportViewer1.Enabled = True
        Dim ds As New DataSet   'the dataset which will be assigned to the report
        Dim cryrpt As New PvReport

        'call the pv function to get the dataset

        ds = SortieRNG.RNG(esistselect)

        Form1.DataGridView1.DataSource = ds.Tables(0)
        Form1.Show()

        GoTo en
        'initilize the textboxes of promotion and annee
        Dim TextObj As CrystalDecisions.CrystalReports.Engine.TextObject

        For Each CryObj As CrystalDecisions.CrystalReports.Engine.ReportObject In cryrpt.Section2.ReportObjects
            If CryObj.GetType().ToString.Equals("CrystalDecisions.CrystalReports.Engine.TextObject") Then
                TextObj = CryObj
                Select Case TextObj.Name
                    Case "PromoString"
                        'TextObj.Text = NiveauBox.Text + IIf(NiveauBox.SelectedIndex > 0, " er", " ème") + " ANNEE INGENIEUR - " + SpecialiteBox.Text
                    Case "AnneeString"
                        'TextObj.Text = PromoBox.Text + " - " + (PromoBox.SelectedIndex + 1990).ToString
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
        ' and that's it !
en:
    End Sub

    Private Sub BT_SORTIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        'Home.f.Show()
        Home.MainContainer2.Visible = False
        Home.MainContainer1.Visible = True
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class