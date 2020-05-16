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
        NoResultPanel.Visible = False
        'retrieve the print button and add a click handler to it
        For Each ts As ToolStrip In CrystalReportViewer1.Controls.OfType(Of ToolStrip)()
            For Each tsb As ToolStripButton In ts.Items.OfType(Of ToolStripButton)()
                If tsb.AccessibleName.ToLower.Contains("Print") Or tsb.AccessibleName.ToLower.Contains("imprimer") Then
                    AddHandler tsb.Click, AddressOf printButton_Click
                End If
            Next
        Next

        'initialize the graphic componants values
        CrystalReportViewer1.Enabled = True
        ' make the report viewer visible
        CrystalReportViewer1.Visible = True
        'disbale the affich button until any combobox values has been changed
        ImprTotalLabel.Visible = False

        NomLabel.Text = esistselect.GetInfoChamps(BDD.champsNomEtud)
        PrenomLabel.Text = esistselect.GetInfoChamps(BDD.champsPrenoms)
        Matricule.Text = esistselect.GetInfoChamps(BDD.champsMATRIN)
        AdresseLabel.Text = esistselect.GetInfoChamps(BDD.champsVILLE) + esistselect.GetInfoChamps(BDD.champsWILAYA)
        PromoLabel.Text = esistselect.GetInfoChamps(BDD.champsANNEEBAC)
        ' and that's it !
    End Sub

    Private Sub RNGPage_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        'call the pv function to get the dataset
        Try
            Dim ds As New DataSet   'the dataset which will be assigned to the report
            Dim cryrpt As New rng2lReport

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
                codprom = ds.Tables(1).Rows(i)(BDD.champsCodePromo).ToString.Substring(0, 1) + IIf(ds.Tables(1).Rows(i)(BDD.champsCodePromo).ToString.Substring(0, 1).Equals("1"), " ère", " ème") + " Année "
                codprom += IIf(ds.Tables(1).Rows(i)(BDD.champsCodePromo).ToString.Substring(2, 3).Equals("TRC"), "Tronc Commun ", IIf(ds.Tables(1).Rows(i)(BDD.champsCodePromo).ToString.Substring(2, 3).Equals("SIQ"), "Systèmes informatiques ", "Systèmes d'informations ")) + codannee
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
                    Try
                        Select Case ds.Tables(1).Rows(i)(BDD.champsMENTIN).ToString
                            Case "1"
                                FormulaField.Text = "'TRES BIEN' ;"
                            Case "2"
                                FormulaField.Text = "'" + "BIEN" + "' ;"
                            Case "3"
                                FormulaField.Text = "'" + "ASSEZ BIEN" + "' ;"
                            Case "4"
                                FormulaField.Text = "'PASSABLE' ;"
                            Case "6"
                                FormulaField.Text = "'" + "Passer au rattrapage" + "' ;"
                            Case "7"
                                FormulaField.Text = "'" + "En situation d'abondance" + "' ;"
                            Case "8"
                                FormulaField.Text = "'" + "redoubler sans passer au rattrapage" + "' ;"
                            Case Else
                                FormulaField.Text = "'" + "None" + "' ;"
                        End Select
                    Catch ex As Exception
                        FormulaField.Text = "'" + "champs vide" + "' ;"
                    End Try
                    'FormulaField.Text = "'" + ds.Tables(1).Rows(i)(BDD.champsMENTIN).ToString + "' ;"    '.Replace(",", ".")
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

        Catch ex As RngImpossibleException
            'MsgBox("Cet étudiant n'a pas obtenu son diplome ", , "Erreur")
            CrystalReportViewer1.Visible = False
            NoResultPanel.Visible = True
            NoResultLabel.Text = "Cet étudiant n'a pas obtenu son diplome"
        Catch ex As Exception
            'MsgBox("Impossible de générer le relevé de note général de cet etudiant", , "Erreur")
            'BT_SORTIR_Click(SortirButton, New EventArgs())
            CrystalReportViewer1.Visible = False
            NoResultPanel.Visible = True
            NoResultLabel.Text = "Quelques informations manquent dans l'historique de cet étudiant , veuillez les remplir et recharger la base de données à nouveau."
        End Try
        If esistselect.GetInfoChamps(BDD.champsNBR_RNG) Then
            ImprTotalLabel.Visible = True
        End If
    End Sub

    Private Sub BT_SORTIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortirButton.Click
        Me.Close()
        'Home.f.Show()
        Home.MainContainer2.Visible = False
        Home.MainContainer1.Visible = True
    End Sub

    Private Sub ImprTotalLabel_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprTotalLabel.VisibleChanged
        If ImprTotalLabel.Visible Then
            With AvertToolTip
                .Active = True
                .IsBalloon = True
                .SetToolTip(sender, "Ce relevé de note a été imprimé déja" + esistselect.GetInfoChamps(BDD.champsNBR_RNG).ToString + "fois")
                .Show("Ce relevé de note a été imprimé déja" + esistselect.GetInfoChamps(BDD.champsNBR_RNG).ToString + "fois", sender)
                .ShowAlways = True
            End With
        Else
            AvertToolTip.Active = False
        End If
    End Sub

    Private Sub printButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox("Printed")
        Dim dialog As DialogResult
        ImprTotalLabel.Visible = False
        dialog = MsgBox("Est-ce que le relevé de note général a été imprimé ?", MessageBoxButtons.YesNo, "Confirmer L'impression")
        If (dialog = Windows.Forms.DialogResult.Yes) Then
            SortieRNG.SetNbreRNG(esistselect, esistselect.GetInfoChamps(BDD.champsNBR_RNG) + 1)
            ImprTotalLabel.Visible = True
        Else
            ImprTotalLabel.Visible = False
        End If

        'MsgBox.Show("Printed")
    End Sub

End Class