Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Data.SqlClient

Public Class RN

    Dim cb_anee As Boolean
    Dim esistselect As Etudiant ' letudiant selection f affichresult
    Dim RN As SortieRN = Nothing
    Dim codepromo As String = ""

    Public Sub New(ByVal e As Etudiant)

        ' This call is required by the designer.
        InitializeComponent()
        esistselect = e
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub RN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NoResultPanel.Visible = False
        BilanLinkLabel.Visible = False
        For Each ts As ToolStrip In CrystalReportViewer1.Controls.OfType(Of ToolStrip)()
            For Each tsb As ToolStripButton In ts.Items.OfType(Of ToolStripButton)()
                If tsb.AccessibleName.ToLower.Contains("Print") Or tsb.AccessibleName.ToLower.Contains("imprimer") Then
                    AddHandler tsb.Click, AddressOf printButton_Click
                End If
            Next
        Next
        'inisializer les panels
        'initialiser combo de promo
        'For Each cr As String In InfosGenerales.promo
        '    CB_ANNEE.Items.Add(cr)
        'Next

        NomLabel.Text = esistselect.GetInfoChamps(BDD.champsNomEtud)
        PrenomLabel.Text = esistselect.GetInfoChamps(BDD.champsPrenoms)
        Matricule.Text = esistselect.GetInfoChamps(BDD.champsMATRIN)
        AdresseLabel.Text = esistselect.GetInfoChamps(BDD.champsVILLE) + esistselect.GetInfoChamps(BDD.champsWILAYA)
        PromoLabel.Text = esistselect.GetInfoChamps(BDD.champsANNEEBAC)


        Try
            Dim allPromos As DataTable = esistselect.GetALL(BDD.champsCodePromo)
            If allPromos.Rows.Count = 0 Then
                Throw New NoyearRNException()
            End If
            For Each row In allPromos.Rows
                Dim codprom As String = ""
                Dim codannee As String = ""
                Dim prom = row(allPromos.Columns(0).ToString)
                codannee = prom.Substring(prom.LastIndexOf("/") + 1)
                codannee = codannee.Insert(0, IIf(CInt(codannee) > 11, "19", "20"))
                codannee += "/" + (CInt(codannee) + 1).ToString
                codprom = prom.Substring(0, 1) + IIf(prom.Substring(0, 1).Equals("1"), " ère", " ème") + " Année "
                codprom += IIf(prom.Substring(2, 3).Equals("TRC"), "Tronc Commun ", IIf(prom.Substring(2, 3).Equals("SIQ"), "Systèmes informatiques ", "Systèmes d'information ")) + codannee
                row(allPromos.Columns(0).ToString) = codprom
            Next
            'CB_ANNEE.FormattingEnabled = True
            CB_ANNEE.DisplayMember = allPromos.Columns(0).ToString

            'CB_ANNEE.FormatString = ""
            CB_ANNEE.ValueMember = allPromos.Columns(0).ToString
            CB_ANNEE.DataSource = allPromos

            'CB_ANNEE.DropDownStyle = ComboBoxStyle.DropDownList
            CB_ANNEE.Text = "Veuillez choisir un année"

            'initialiser generale
            cb_anee = False
            ImprTotalLabel.Visible = False
            BT_LOAD.Enabled = False
        Catch ex As NoyearRNException
            'MsgBox("Impossible de générer le relevé de note général de cet etudiant", , "Erreur")
            'BT_SORTIR_Click(SortirButton, New EventArgs())
            CrystalReportViewer1.Visible = False
            ImprTotalLabel.Visible = True
            With AvertToolTip
                '.Active = True
                '.IsBalloon = True
                '.ShowAlways = True
                '.ToolTipTitle = "La liste des années d'études est Vide !"
                '.ToolTipIcon = ToolTipIcon.Error
                '.SetToolTip(PictureBox1, "Cet étudiant n'a pas un historique d'année d'étude complet à afficher")
                '.Show("Cet étudiant n'a pas un historique d'année d'étude complet à afficher", PictureBox1)
            End With
            BT_LOAD.Enabled = False
            NoResultPanel.Visible = True
            NoResultLabel.Text = "Quelques informations manquent dans l'historique de cet étudiant dans cette année , veuillez les remplir et recharger la base de donnéez à nouveau."
            'BilanLinkLabel.Visible = True
        End Try

    End Sub

    Private Sub BT_LOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_LOAD.Click
        
        Try
            If cb_anee = True Then
                codepromo = esistselect.GetALL(BDD.champsCodePromo).Rows(CB_ANNEE.SelectedIndex)(BDD.champsCodePromo).ToString
                RN = New SortieRN(esistselect, codepromo) 'CB_ANNEE.Text)

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

                codannee = CB_ANNEE.Text.Substring(CB_ANNEE.Text.Count - 9) 'IIf(CInt(CB_ANNEE.Text.Substring(CB_ANNEE.Text.LastIndexOf("/") + 1)) > 11, "19", "20")
                'codannee += CB_ANNEE.Text.Substring(CB_ANNEE.Text.LastIndexOf("/") + 1)
                'codannee += "/" + (CInt(codannee) + 1).ToString
                codniveau = CB_ANNEE.Text.Substring(0, 11) ' + IIf(CB_ANNEE.Text.Substring(0, 1).Equals("1"), " ère", " ème") + " Année INGENIEUR"
                codoptin = CB_ANNEE.Text.Replace(codannee, "")
                codoptin = codoptin.Replace(codniveau, "")
                'IIf(CB_ANNEE.Text.Substring(2, 3).Equals("TRC"), "Tronc Commun ", IIf(CB_ANNEE.Text.Substring(2, 3).Equals("SIQ"), "Systèmes informatiques ", "Systèmes d'informations "))

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
                            FormulaField.Text = "'Admis en " + (CInt(CB_ANNEE.Text.Substring(0, 1)) + 1).ToString + IIf(CB_ANNEE.Text.Substring(0, 1).Equals("1"), " ère", " ème") + " Année' ;"
                        Case "R"
                            FormulaField.Text = "'" + "Redouble" + "' ;"
                        Case "M"
                            FormulaField.Text = "'" + "Maladie" + "' ;"
                        Case "S"
                            FormulaField.Text = "'Admis en " + (CInt(CB_ANNEE.Text.Substring(0, 1)) + 1).ToString + IIf(CB_ANNEE.Text.Substring(0, 1).Equals("1"), " ère", " ème") + " Année' ;"
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
                'If (Home.MainContainer1.Width <= 690) Then
                'Home.MenuButton_Click(Home.MenuButton, New MouseEventArgs(MouseButtons.Middle, 1, 15, 15, 0))
                'End If
                ' make the report viewer visible
                CrystalReportViewer1.Visible = True
                'disbale the affich button until any combobox values has been changed
                ' and that's it !

                'Form1.ds = RN.dataSet
                'Form1.Show()

            End If
            cb_anee = False
            If RN.GetNbreRN() > 0 Then
                ImprTotalLabel.Visible = True
            End If
        Catch ex As InvalidCastException
            'MsgBox("Impossible de générer le relevé de note général de cet etudiant", , "Erreur")
            'BT_SORTIR_Click(SortirButton, New EventArgs())
            CrystalReportViewer1.Visible = False
            NoResultPanel.Visible = True
            NoResultLabel.Text = "Quelques informations manquent dans l'historique de cet étudiant , veuillez les remplir et recharger la base de données à nouveau."
        
        End Try
        BilanLinkLabel.Visible = Not SortieRN.getBilan.Equals("Tout est bien passé!")
        BilanLinkLabel.Enabled = Not SortieRN.getBilan.Equals("Tout est bien passé!")
        'Console.WriteLine(SortieRN.getBilan)


    End Sub

    Private Sub CB_ANNEE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_ANNEE.SelectedIndexChanged
        cb_anee = True
        BT_LOAD.Enabled = True
    End Sub

    Private Sub CB_ANNEE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CB_ANNEE.KeyPress
        e.Handled = True
    End Sub

    Private Sub BT_SORTIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SORTIR.Click
        Me.Close()
        Home.MainContainer2.Visible = False
        Home.MainContainer1.Visible = True
    End Sub

    Private Sub ImprTotalLabel_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprTotalLabel.VisibleChanged
        If ImprTotalLabel.Visible Then

            With AvertToolTip
                .Active = True
                .IsBalloon = True
                .ShowAlways = True
                If Not IsNothing(RN) Then
                    .SetToolTip(sender, "Ce relevé de note a été imprimé déja" + RN.GetNbreRN().ToString + "fois")
                    .Show("Ce relevé de note a été imprimé déja " + RN.GetNbreRN().ToString + " fois ", sender, 8000)
                Else
                    .ToolTipTitle = "La liste des années d'études est Vide !"
                    .ToolTipIcon = ToolTipIcon.Error
                    .SetToolTip(sender, "Cet étudiant n'a pas un historique d'année d'étude complet à afficher")
                    .Show("Cet étudiant n'a pas un historique d'année d'étude complet à afficher", sender)
                End If

            End With

        Else
        AvertToolTip.Active = False
        End If
    End Sub

    Private Sub printButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox("Printed")
        Dim dialog As DialogResult
        ImprTotalLabel.Visible = False
        dialog = MsgBox("Est-ce que le relevé de note a été imprimé ?", MessageBoxButtons.YesNo, "Confirmer L'impression")
        If (dialog = Windows.Forms.DialogResult.Yes) Then
            RN.SetNbreRN(esistselect, RN.GetNbreRN + 1, codepromo)
            ImprTotalLabel.Visible = True
            'AvertToolTip.SetToolTip(sender, "Ce relevé de note a été imprimé déja" + RN.GetNbreRN().ToString + "fois")
            'AvertToolTip.Show("Ce relevé de note a été imprimé déja " + RN.GetNbreRN().ToString + " fois ", sender, 8000)
        Else
            ImprTotalLabel.Visible = False
        End If

        'MsgBox.Show("Printed")
    End Sub

    Private Sub BilanLinkLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BilanLinkLabel.Click
        BilanPage.RichTextBox1.Clear()
        BilanPage.RichTextBox1.Text = SortieRN.getBilan()
        BilanPage.Show()
    End Sub

End Class