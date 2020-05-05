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
        'For Each cr As String In InfosGenerales.promo
        '    CB_ANNEE.Items.Add(cr)
        'Next

        CB_ANNEE.DisplayMember = esistselect.GetALL(BDD.champsCodePromo).Columns(0).ToString
        CB_ANNEE.ValueMember = esistselect.GetALL(BDD.champsCodePromo).Columns(0).ToString
        CB_ANNEE.DataSource = esistselect.GetALL(BDD.champsCodePromo)
        CB_ANNEE.Text = ""

        'initialiser generale
        cb_anee = False
        BT_LOAD.Enabled = False

    End Sub



    Private Sub BT_SORTIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Home.MainContainer2.Visible = False
        Home.MainContainer1.Visible = True
    End Sub

    Private Sub BT_LOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_LOAD.Click
        If cb_anee = True Then

            RN = New SortieRN(esistselect, CB_ANNEE.Text) 'CB_ANNEE.Text)

            CrystalReportViewer1.Enabled = True
            Dim ds As DataSet = RN.dataSet 'the dataset which will be assigned to the report
            Dim cryrpt As New RNCrystalReport

            'assign the dataset tables to the report

            cryrpt.SetDataSource(ds)
            cryrpt.Database.Tables(0).SetDataSource(ds.Tables(0))
            'cryrpt.Database.Tables(1).SetDataSource(ds.Tables(1))
            'cryrpt.Database.Tables(2).SetDataSource(ds.Tables(2))


            Dim codoptin As String
            Dim codniveau As String
            Dim codannee As String

            codannee = IIf(CInt(CB_ANNEE.Text.Substring(CB_ANNEE.Text.LastIndexOf("/") + 1)) > 11, "19", "20")
            codannee += CB_ANNEE.Text.Substring(CB_ANNEE.Text.LastIndexOf("/") + 1)
            codannee += "/" + (CInt(codannee) + 1).ToString
            codniveau = CB_ANNEE.Text.Substring(0, 1) + IIf(CB_ANNEE.Text.Substring(0, 1).Equals("1"), " ère", " ème") + " Année INGENIEUR"
            codoptin = IIf(CB_ANNEE.Text.Substring(2, 3).Equals("TRC"), "Tronc Commun ", IIf(CB_ANNEE.Text.Substring(2, 3).Equals("SIQ"), "Systeme d informatiques ", "Systeme d informations "))

            'initilize the textboxes of promotion and annee
            Dim TextObj As CrystalDecisions.CrystalReports.Engine.TextObject

            For Each CryObj As CrystalDecisions.CrystalReports.Engine.ReportObject In cryrpt.Section2.ReportObjects
                If CryObj.GetType().ToString.Equals("CrystalDecisions.CrystalReports.Engine.TextObject") Then
                    TextObj = CryObj
                    Select Case TextObj.Name
                        Case "OptinString"
                            TextObj.Text = codoptin
                        Case "AnneeString"
                            TextObj.Text = codannee
                        Case "NiveauString"
                            TextObj.Text = codniveau
                    End Select
                End If
            Next


            Dim FormulaFields As FormulaFieldDefinitions    ' the collection 
            Dim FormulaField As FormulaFieldDefinition      ' an item of the collection

            FormulaFields = cryrpt.DataDefinition.FormulaFields

            ' the corresponding formula item
            FormulaField = FormulaFields.Item(0)
            Try
                Select Case ds.Tables(2).Rows(0)("ADM")
                    Case "J"
                        FormulaField.Text = "'Admis en " + CB_ANNEE.Text.Substring(0, 1) + IIf(CB_ANNEE.Text.Substring(0, 1).Equals("1"), " ère", " ème") + " Année' ;"
                    Case "R"
                        FormulaField.Text = "'" + "Redouble" + "' ;"
                    Case "M"
                        FormulaField.Text = "'" + "Maladie" + "' ;"
                    Case "S"
                        FormulaField.Text = "'Admis en " + CB_ANNEE.Text.Substring(0, 1) + IIf(CB_ANNEE.Text.Substring(0, 1).Equals("1"), " ère", " ème") + " Année' ;"
                    Case "X"
                        FormulaField.Text = "'" + "Non admis" + "' ;"
                    Case Else
                        FormulaField.Text = "'" + "None" + "' ;"
                End Select
            Catch ex As Exception
                FormulaField.Text = "'" + "champs vide" + "' ;"
            End Try
            
            '    if {Table2.ADM} = "J" then Join (["Admis en",{@an},"Année"]," ") 
            '    Else
            '    if {Table2.ADM} = "R" then "Redouble" 
            '        Else
            'if {Table2.ADM} = "M" then "Maladie"
            '            Else
            '    if {Table2.ADM} = "S" then Join (["Admis en",{@an},"Année"]," ")
            '                Else
            '        if {Table2.ADM} = "X" then "Non admis" 
            '        else "None"
            'FormulaField.Text = "'" + ds.Tables(2).Rows(0)("ADM") + "' ;"

            FormulaField = FormulaFields.Item(1)
            FormulaField.Text = "" + ds.Tables(2).Rows(0)("RANGIN").ToString + " ;"

            FormulaField = FormulaFields.Item(2)
            FormulaField.Text = "" + ds.Tables(2).Rows(0)("NbreEtudiant").ToString + " ;"

            FormulaField = FormulaFields.Item(3)
            FormulaField.Text = "" + ds.Tables(2).Rows(0)("MOYEIN").ToString.Replace(",", ".") + " ;"

            FormulaField = FormulaFields.Item(4)
            FormulaField.Text = "'" + CB_ANNEE.Text.Substring(0, 1) + IIf(CB_ANNEE.Text.Substring(0, 1).Equals("1"), " ère", " ème") + "' ;"

            ' refresh the report to view the changes
            CrystalReportViewer1.RefreshReport()
            'Set the report viewer report objet 
            CrystalReportViewer1.ReportSource = cryrpt
            'set the zoom factor the width of the page
            CrystalReportViewer1.Zoom(1)
            ' if the bule side bar is opened , then close it by simulating a mouse click on the menu button to make the view more big
            If (Home.MainContainer1.Width <= 690) Then
                Home.MenuButton_Click(Home.MenuButton, New MouseEventArgs(MouseButtons.Middle, 1, 15, 15, 0))
            End If
            ' make the report viewer visible
            CrystalReportViewer1.Visible = True
            'disbale the affich button until any combobox values has been changed
            ' and that's it !

            'Form1.ds = RN.dataSet
            'Form1.Show()

        End If
        cb_anee = False
    End Sub

    Private Sub CB_ANNEE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_ANNEE.SelectedIndexChanged
        cb_anee = True
        BT_LOAD.Enabled = True
    End Sub
End Class