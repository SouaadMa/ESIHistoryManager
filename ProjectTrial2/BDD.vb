Imports System.Data.OleDb

Public Class BDD

    ' les tableaux qui contiennet les champs des tableaux de base de données :
    Private stringETUDIANT() As String = {"NomEtud", "Prenoms", "NomEtudA", "PrenomsA", "MATRIC_INS", "MATRIN", "DateNais", "LieuNaisA", "WilayaNaisA",
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
        'retourner un dataTable contenant les étudiants qui vérifient la requête

        Dim cnx As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\Base_de_donnees.accdb")  'la connexion à la BDD
        Dim cmd As OleDbCommand                     ' la commande
        Dim ta As OleDbDataAdapter                  ' le Data Adapter
        Dim dts As New DataSet                      ' le Data Set
        Dim dt As DataTable                         ' le Data Table

        dt = New DataTable()

        Try
            cnx.Open()                               ' ouvrir la connection avec la base de données


            cmd = New OleDbCommand(requete, cnx) ' la connection au commande
            ta = New OleDbDataAdapter(cmd)       ' creer un nouveau DataAdapter
            ta.Fill(dts)                         ' remplir le data set par le résultat de l'éxécution de la requête ( de data adapter ) 

            dt = dts.Tables("table")              'mettre dans le data table le résultat de l'éxécution de requête ( le data set )

        Catch ex As Exception
            MsgBox("  La connexion à la base de données est échouée :( ")
        Finally
            cnx.Close()                              'fermer la connexion
        End Try

        Return dt

    End Function


    Public Shared Function getInfoBDD(ByVal champs As String, ByVal matricule As String) As String
        ' retourner une information d'un champ spécifié "champs"  d'un étudiant idantifié par son "MATRICULE" 


        Dim da As New OleDb.OleDbDataAdapter        'le data adapter
        Dim con As OleDb.OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=..\..\Base_de_donnees.accdb")       'la connexion à la BDD
        Dim dt As New DataTable                     'le datatable
        Dim cmd As OleDbCommand                     'la commande
        Dim dts As New DataSet                      'le Data Set
        Dim Resultat As Object = ""  'l'information qu'on cherche sur l'étudiant
        Dim sql As String = " SELECT * FROM ETUDIANT WHERE MATRIN='" & matricule & "'"  'l'instruction SQL 


        Try
            con.Open()  'ouvrir la connexion

            'creer un adaptateur à partir de la connexion et l'instruction SQL

            cmd = New OleDbCommand(sql, con) ' donner le requete SQL et la connection au commande
            da = New OleDbDataAdapter(cmd)       ' creer un nouveau DataAdapter


            'remplir le dataset par le résultat de l'exécution de la requête
            da.Fill(dts)

            'extraire le dataTable
            dt = dts.Tables("table")

            'parcourir le dataTable pour récupérer l'information 

            For Each row As DataRow In dt.Rows
                Resultat = CType(row(champs), String)
            Next

        Catch ex As Exception
            MsgBox(" La connexion à la base de données est échouée :( ")
        Finally
            'close connection
            con.Close()
        End Try

        Return Resultat

    End Function

End Class


