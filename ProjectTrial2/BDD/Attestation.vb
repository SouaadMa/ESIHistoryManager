Imports System.Data.OleDb

Public Class Attestation

    Public Shared Function attestation(ByVal mat As String) As DataSet

        Dim champ As List(Of String) = New List(Of String)
        Dim cond As List(Of Critere) = New List(Of Critere)
        Dim tab1 As String
        Dim tab2 As String
        Dim requete As String

        champ.Add(BDD.champsMATRIN)
        champ.Add(BDD.champsAnnee)
        champ.Add(BDD.champsNiveau)
        champ.Add(BDD.champsOption)
        champ.Add(BDD.champsADM)
        cond.Add(New Critere(BDD.champsMATRIN, mat))
        tab1 = BDD.nomTableINSCRIPTION
        tab2 = BDD.nomTablePROMO
        requete = Class_BDD.genereRechRequete(champ, tab1, tab2, cond)

        Return executeRequete(requete)

    End Function

    Public Shared Function executeRequete(ByVal requete As String) As DataSet

        Dim cnx As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\BDD_TABLES_ECLATES.accdb")  'la connexion à la BDD
        Dim cmd As OleDbCommand                     ' la commande
        Dim ta As OleDbDataAdapter                  ' le Data Adapter
        Dim dts As New DataSet                      ' le Data Set

        Try
            cnx.Open()                               ' ouvrir la connection avec la base de données
            cmd = New OleDbCommand(requete, cnx) ' la connection au commande
            ta = New OleDbDataAdapter(cmd)       ' creer un nouveau DataAdapter
            ta.Fill(dts)                         ' remplir le data set par le résultat de l'éxécution de la requête ( de data adapter )
        Catch ex As Exception
            MsgBox(ex.Message())
        Finally
            cnx.Close()                              'fermer la connexion
        End Try

        Return dts

    End Function


End Class
