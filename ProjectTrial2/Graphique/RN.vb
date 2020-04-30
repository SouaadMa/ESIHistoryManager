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
        For Each cr As String In InfosGenerales.promo
            CB_ANNEE.Items.Add(cr)
        Next

        'initialiser generale
        cb_anee = False
        BT_LOAD.Enabled = False
        CrystalReportViewer1.Visible = False

    End Sub



    Private Sub BT_SORTIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Home.MainContainer2.Visible = False
        Home.MainContainer1.Visible = True
    End Sub

    Private Sub BT_LOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_LOAD.Click
        If cb_anee = True Then

            RN = New SortieRN(esistselect, "1/TRC/04") 'CB_ANNEE.Text)

            CrystalReportViewer1.Enabled = True
            Dim ds As DataSet = RN.dataSet 'the dataset which will be assigned to the report
            Dim cryrpt As New RNCrystalReport

            'assign the dataset first table to the report


            cryrpt.SetDataSource(ds)
            cryrpt.Database.Tables(0).SetDataSource(ds)

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

            Form1.ds = RN.dataSet
            Form1.Show()

        End If
        cb_anee = False
    End Sub

    Private Sub CB_ANNEE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_ANNEE.SelectedIndexChanged
        cb_anee = True
        BT_LOAD.Enabled = True
    End Sub
End Class