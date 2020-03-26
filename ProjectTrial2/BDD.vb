Imports System.Data.OleDb

Public Class BDD

         "LieuNais", "ADRESSE", "VILLE", "WILAYA", "CODEPOS", "WILBAC", "SERIEBAC", "FILS_DE", "ET_DE"}
    Private stringINSECRIPTION() As String = {"MATRIN", "CodeGroupe", "DECIIN", "DEC", "ADM"}
    Private stringGROUP() As String = {"NG"}
    Private stringSection() As String = {"NS"}
    Private stringPROMO() As String = {"Option"}
    Private stringNOTE() As String = {}
    Private stringMATIERE() As String = {"CYCLMA", "OPTIMA", "COMAMA", "LIBEMA", "TYPEMA"}
    Private stringNOTERATRAP() As String
    Private stringRATRAP() As String = {"CYCLRA", "OPTIRA"}

    Private numETUDIANT() As String = {"WILNAIS", "SEXE", "MOYBAC", "ANNEEBAC"}
    Private numINSECRIPTION() As String = {"MOYEIN", "RANGIN", "MENTIN", "ELIMININ", "RATRIN"}
    Private numGROUP() As String = {}
    Private numSection() As String = {}
    Private numPROMO() As String = {"Niveau", "Annee"}
    Private numNOTE() As String = {"NOJUNO", "NOSYNO", "NORANO", "ELIMNO", "RATRNO"}
    Private numMATIERE() As String = {"ANSCMA", "ANETMA", "COEFMA", "MOYMAT"}
    Private numNOTERATRAP() As String = {"MOYERA", "MENTRA", "ELIMRA", "RATRRA"}
    Private numRATRAP() As String = {"ANSCRA", "ANETRA"}

    Private boolETUDIANT() As String = {}
    Private boolINSECRIPTION() As String = {}
    Private boolGROUP() As String = {}
    Private boolSection() As String = {}
    Private boolPROMO() As String = {}
    Private boolNOTE() As String = {"ELIMNO"}
    Private boolMATIERE() As String = {}
    Private boolNOTERATRAP() As String = {}
    Private boolRATRAP() As String = {}

    Private stringChamp()() As String = {stringETUDIANT, stringINSECRIPTION, stringGROUP, stringSection, stringPROMO,
                              stringNOTE, stringMATIERE, stringNOTERATRAP, stringRATRAP}
    Private numChamp()() As String = {numETUDIANT, numINSECRIPTION, numGROUP, numSection, numPROMO,
                              numNOTE, numMATIERE, numNOTERATRAP, numRATRAP}
    Private boolChamp()() As String = {boolETUDIANT, boolINSECRIPTION, boolGROUP, boolSection, boolPROMO,
                              boolNOTE, boolMATIERE, boolNOTERATRAP, boolRATRAP}

    Public Function getStringChamp() As String()()
        Return stringChamp
    End Function

    Public Function getNumChamp() As String()()
        Return numChamp
    End Function

    Public Function getBoolChamp() As String()()
        Return boolChamp
    End Function

    Public Shared Function executeRequete(ByVal requete As String) As DataTable
        ' exécuter le requet SQL 'requet' sur la base de donnée 
        Dim cnx As OleDbConnection                  ' la connection 
        cnx = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\2CP\S2\PROJET\VisualStudioProject\Project\Project\Base de données.accdb")
        Dim cmd As OleDbCommand                     ' la commande
        Dim ta As OleDbDataAdapter                  ' le Data Adapter
        Dim dts As New DataSet                      ' le Data Set
        Dim dt As DataTable                         ' le Data Table

        dt = New DataTable()

        Try
            cnx.Open()                               ' ouvrir la connection avec la base de donnée
            Try

                cmd = New OleDbCommand(requete, cnx) ' donner le requete SQL et la connection au commande
                ta = New OleDbDataAdapter(cmd)       ' creer un nouveau DataAdapter
                ta.Fill(dts)                         ' fill le data set par le résultat de l'éxécution de requete ( de data adapter ) 

                dt = dts.Tables("table")             'mettre dans le data table le résultat de l'éxécution de requete ( le data set )

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


