Imports System.Data.OleDb

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VISUALDataSet.INSCRIPTION' table. You can move, or remove it, as needed.
        Me.INSCRIPTIONTableAdapter.Fill(Me.VISUALDataSet.INSCRIPTION)
        With DataGridView1
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
            .DataSource = INSCRIPTIONBindingSource
        End With
    End Sub


    Dim da As New OleDb.OleDbDataAdapter
    Dim con As New OleDb.OleDbConnection
    Dim dt As New DataTable
    Dim sql As String



    Function GETINFO(ByVal CHAMP As String, ByVal Matricule As String) As String
        Dim Resultat As String
        con = New OleDbConnection("provider=Microsoft.jet.oledb.4.0; data source=VISUAL.accdb")
        sql = "Select * from INSCRIPTION where MATRICULE='" & 2 / 149 & "'"
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)

            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                Resultat = row(CHAMP)
            Next

        Catch ex As Exception

        End Try
        'close connection
        con.Close()
        Return Resultat
    End Function
   

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = GETINFO("MOYEIN", "2/194")


    End Sub
End Class
