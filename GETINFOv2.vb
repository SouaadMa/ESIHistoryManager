Imports System.Data.OleDb
Public Class Form1
    Public Shared Function GETINFO(ByVal CHAMP As String, ByVal MATRICULE As String) As DataTable
        ' retourné une information d'un champ spécifie"CHAMP" pour un étudiant idantifié par son "MATRICULE" 
        Dim cnx As OleDbConnection                  ' la connection 
        cnx = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VISUAL.accdb")
        Dim cmd As OleDbCommand                     ' la commande
        Dim ta As OleDbDataAdapter                  ' le Data Adapter
        Dim dts As New DataSet                      ' le Data Set
        Dim dt As DataTable                         ' le Data Table

        dt = New DataTable()

        Try
            cnx.Open()                               ' ouvrir la connection avec la base de donnée
            Try
                Dim sql, resultat As String
                sql = "Select * from INSCRIPTION where MATRICULE='" & MATRICULE & "'"
                cmd = New OleDbCommand(Sql, cnx) ' donner le requete SQL et la connection au commande
                ta = New OleDbDataAdapter(cmd)       ' creer un nouveau DataAdapter
                ta.Fill(dts)                         ' fill le data set par le résultat de l'éxécution de requete ( de data adapter ) 

                dt = dts.Tables("table")             'mettre dans le data table le résultat de l'éxécution de requete ( le data set )
                For Each row As DataRow In dt.Rows
                    resultat = row(CHAMP)              'mettre dans résultat la valeur du champ demandé
                Next

                MsgBox(" Command execute ")
            Catch ex As Exception
                MsgBox(" Command non execute ")
            End Try

            'ta.Dispose()            
            cnx.Close()                              'fermer la connection
        Catch ex As Exception
            MsgBox(" Connection not openning ! ")
        End Try
        Return dt

    End Function

End Class
