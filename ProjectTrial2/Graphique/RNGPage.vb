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
        Dim cryrpt As New rng2lReport

        'call the pv function to get the dataset

        ds = SortieRNG.RNG(esistselect)

        'Form1.ds = ds
        'Form1.Show()

        'assign the dataset first table to the report

        cryrpt.SetDataSource(ds)
        cryrpt.Database.Tables(0).SetDataSource(ds)

        ' the collection of formulas fields in the report

        Dim FormulaFields As FormulaFieldDefinitions    ' the collection 
        Dim FormulaField As FormulaFieldDefinition      ' an item of the collection

        Dim codprom As String
        Dim codannee As String
        For i As Integer = 0 To cryrpt.Subreports.Count - 1 Step 1
            FormulaFields = cryrpt.Subreports.Item(i).DataDefinition.FormulaFields
            codannee = "20" + ds.Tables(1).Rows(i)(BDD.champsCodePromo).ToString.Substring(ds.Tables(1).Rows(i)(BDD.champsCodePromo).ToString.LastIndexOf("/") + 1)
            codannee += "/" + (CInt(codannee) + 1).ToString
            codprom = ds.Tables(1).Rows(i)(BDD.champsCodePromo).ToString.Substring(0, 1) + IIf(ds.Tables(1).Rows(i)(BDD.champsCodePromo).ToString.Substring(0, 1).Equals("1"), " er", " ème") + " Année "
            codprom += IIf(ds.Tables(1).Rows(i)(BDD.champsCodePromo).ToString.Substring(2, 3).Equals("TRC"), "Tronc Commun ", IIf(ds.Tables(1).Rows(i)(BDD.champsCodePromo).ToString.Substring(2, 3).Equals("SIQ"), "Systeme d informatiques ", "Systeme d informations ")) + codannee
            If i <> 4 Then
                'get the corresponding formula item
                FormulaField = FormulaFields.Item(0)
                FormulaField.Text = "{" + cryrpt.Database.Tables.Item(i + 2).Name + "." + cryrpt.Database.Tables(i + 2).Fields.Item("LIBEMA").Name + "} ;"

                FormulaField = FormulaFields.Item(2)
                FormulaField.Text = "{" + cryrpt.Database.Tables.Item(i + 2).Name + "." + cryrpt.Database.Tables(i + 2).Fields.Item("COEFMA").Name + "} ;"

                FormulaField = FormulaFields.Item(1)
                FormulaField.Text = "{" + cryrpt.Database.Tables.Item(i + 2).Name + "." + cryrpt.Database.Tables(i + 2).Fields.Item("NOJUNO").Name + "} ;"

                FormulaField = FormulaFields.Item(3)
                FormulaField.Text = "{" + cryrpt.Database.Tables.Item(i + 2).Name + "." + cryrpt.Database.Tables(i + 2).Fields.Item("NORANO").Name + "} ;"

                FormulaField = FormulaFields.Item("codepromo")
                FormulaField.Text = "'" + codprom + "'"
                FormulaField = FormulaFields.Item("moyenne")
                FormulaField.Text = "'" + ds.Tables(1).Rows(i)(BDD.champsMOYEIN).ToString + "' ;"    '.Replace(",", ".")
                FormulaField = FormulaFields.Item("decision")
                FormulaField.Text = "'Admis'" + " ;"
                FormulaField = FormulaFields.Item("rang")
                FormulaField.Text = ds.Tables(1).Rows(i)(BDD.champsRANGIN).ToString + " ;"
                FormulaField = FormulaFields.Item("nbetud")
                FormulaField.Text = ds.Tables(1).Rows(i)(BDD.champsNbreEtudiant).ToString + " ;"

            Else

                FormulaField = FormulaFields.Item("codepromo")
                FormulaField.Text = "'" + codprom + "'"
                FormulaField = FormulaFields.Item("memoire")
                FormulaField.Text = "'" + ds.Tables(1).Rows(i)(BDD.champsMOYEIN).ToString + "' ;"    '.Replace(",", ".")
                FormulaField = FormulaFields.Item("annee")
                FormulaField.Text = "'" + codannee + "' ;"
                FormulaField = FormulaFields.Item("mention")
                FormulaField.Text = "'" + ds.Tables(1).Rows(i)(BDD.champsMENTIN).ToString + "' ;"    '.Replace(",", ".")
            End If

        Next


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
    End Sub

    Private Sub BT_SORTIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        'Home.f.Show()
        Home.MainContainer2.Visible = False
        Home.MainContainer1.Visible = True
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub BT_SORTIR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SORTIR.Click
        Me.Close()
        'Home.f.Show()
        Home.MainContainer2.Visible = False
        Home.MainContainer1.Visible = True
    End Sub
End Class