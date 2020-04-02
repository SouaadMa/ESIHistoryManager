Imports System.Data.OleDb

Public Class BDD

    'Les noms des champs de la table Etudiant
    Public Const champsNomEtud = "NomEtud", champsPrenoms = "Prenoms"
    Public Const champsNomEtudA = "NomEtudA", champsPrenomsA = "PrenomsA"
    Public Const champsMATRIC_INS = "MATRIC_INS", champsMATRIN = "MATRIN"
    Public Const champsDateNais = "DateNais", champsLieuNaisA = "LieuNaisA"
    Public Const champsWilayaNaisA = "WilayaNaisA", champsLieuNais = "LieuNais"
    Public Const champsWILNAIS = "WILNAIS", champsADRESSE = "ADRESSE"
    Public Const champsVILLE = "VILLE", champsWILAYA = "WILAYA"
    Public Const champsCODEPOS = "CODEPOS", champsWILBAC = "WILBAC"
    Public Const champsSEXE = "SEXE", champsSERIEBAC = "SERIEBAC"
    Public Const champsMOYBAC = "MOYBAC", champsANNEEBAC = "ANNEEBAC"
    Public Const champsFILS_DE = "FILS_DE", champsET_DE = "ET_DE"

    'Les noms des champs de la table INSCRIPTION
    Public Const champsCodeGroupe = "CodeGroupe", champsMOYEIN = "MOYEIN"
    Public Const champsRANGIN = "RANGIN", champsMENTIN = "MENTIN"
    Public Const champsELIMININ = "ELIMININ", champsRATRIN = "RATRIN"
    Public Const champsDECIIN = "DECIIN", champsDEC = "DEC"
    Public Const champsADM = "ADM"

    'Les noms des champs de la table NOTE
    Public Const champsCodeMat = "CodeMat", champsNOJUNO = "NOJUNO"
    Public Const champsNOSYNO = "NOSYNO", champsNORANO = "NORANO"
    Public Const champsELIMNO = "ELIMNO", champsRATRNO = "RATRNO"

    'Les noms des champs de la table NoteRATRAP
    Public Const champsCodeRat = "CodeRatr", champsMOYERA = "MOYERA"
    Public Const champsMENTRA = "MENTRA", champsELIMRA = "ELIMRA"
    Public Const champsRATRRA = "RATTRA"

    'Les noms des champs de la table GROUP
    Public Const champsNG = "NG", champsCodeSection = "CodeSection"

    'Les noms des champs de la table Section
    Public Const champsNS = "NS", champsCodePromo = "CodePromo"

    'Les noms des champs de la table PROMO
    Public Const champsNiveau = "Niveau", champsOption = "Option"
    Public Const champsAnnee = "Annee", champsNbreEtudiant = "NbreEtudiant"
    Public Const champsMoyenne = "Moyenne"

    'Les noms des champs de la table MATIERE
    Public Const champsANSCMA = "ANSCMA", champsANETMA = "ANETMA"
    Public Const champsCYCLMA = "CYCLMA", champsOPTIMA = "OPTIMA"
    Public Const champsCOMAMA = "COMAMA", champsLIBEMA = "LIBEMA"
    Public Const champsTYPEMA = "TYPEMA", champsCOEFMA = "COEFMA"
    Public Const champsMOYMAT = "MOYMAT"

    'Les noms des champs de la table RATRAP
    Public Const champsANSCRA = "ANSCRA", champsANETRA = "ANETRA"
    Public Const champsCYCLRA = "CYCLRA", champsOPTIRA = "OPTIRA"

    'Public Shared stringETUDIANT() As String = {"NomEtud", "Prenoms", "NomEtudA", "PrenomsA", "MATRIC_INS", "MATRIN", "DateNais", "LieuNaisA", "WilayaNaisA", "LieuNais", "ADRESSE", "VILLE", "WILAYA", "CODEPOS", "WILBAC", "SERIEBAC", "FILS_DE", "ET_DE"}

    ' les tableaux qui contiennet les champs des tables de base de données :
    Public Shared stringETUDIANT() As String = {"NomEtud", "Prenoms", "NomEtudA", "PrenomsA", "MATRIC_INS", "MATRIN", "DateNais", "LieuNaisA", "LieuNais", "ADRESSE", "VILLE", "WILAYA", "WILBAC", "SERIEBAC", "FILS_DE", "ET_DE", "CODPOST", "WILNAISA", "ANNEEBAC"}
    Public Shared stringINSECRIPTION() As String = {"MATRIN", "CodeGroupe", "DECIIN", "DEC", "ADM"}
    Public Shared stringGROUP() As String = {"NG"}
    Public Shared stringSection() As String = {"NS"}
    Public Shared stringPROMO() As String = {"Option"}
    Public Shared stringNOTE() As String = {}
    Public Shared stringMATIERE() As String = {"CYCLMA", "OPTIMA", "COMAMA", "LIBEMA", "TYPEMA"}
    Public Shared stringNOTERATRAP() As String = {}
    Public Shared stringRATRAP() As String = {"CYCLRA", "OPTIRA"}

    'Public Shared numETUDIANT() As String = {"WILNAIS", "SEXE", "MOYBAC", "ANNEEBAC"}
    Public Shared numETUDIANT() As String = {"WILNAIS", "SEXE", "MOYBAC"}
    Public Shared numINSECRIPTION() As String = {"MOYEIN", "RANGIN", "MENTIN", "ELIMININ", "RATRIN"}
    Public Shared numGROUP() As String = {}
    Public Shared numSection() As String = {}
    Public Shared numPROMO() As String = {"Niveau", "Annee"}
    Public Shared numNOTE() As String = {"NOJUNO", "NOSYNO", "NORANO", "ELIMNO", "RATRNO"}
    Public Shared numMATIERE() As String = {"ANSCMA", "ANETMA", "COEFMA", "MOYMAT"}
    Public Shared numNOTERATRAP() As String = {"MOYERA", "MENTRA", "ELIMRA", "RATRRA"}
    Public Shared numRATRAP() As String = {"ANSCRA", "ANETRA"}

    Public Shared boolETUDIANT() As String = {}
    Public Shared boolINSECRIPTION() As String = {}
    Public Shared boolGROUP() As String = {}
    Public Shared boolSection() As String = {}
    Public Shared boolPROMO() As String = {}
    Public Shared boolNOTE() As String = {"ELIMNO"}
    Public Shared boolMATIERE() As String = {}
    Public Shared boolNOTERATRAP() As String = {}
    Public Shared boolRATRAP() As String = {}

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
        Dim cnx As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\VISUAL.accdb")  'la connexion à la BDD
        Dim cmd As OleDbCommand                     ' la commande
        Dim ta As OleDbDataAdapter                  ' le Data Adapter
        Dim dts As New DataSet                      ' le Data Set
        Dim dt As DataTable                         ' le Data Table

        dt = New DataTable()

        Try
            cnx.Open()                               ' ouvrir la connection avec la base de données
            Console.WriteLine("problem here1")
            cmd = New OleDbCommand(requete, cnx) ' la connection au commande
            Console.WriteLine("problem here2")
            ta = New OleDbDataAdapter(cmd)       ' creer un nouveau DataAdapter
            Console.WriteLine("problem here3")
            ta.Fill(dts)                         ' remplir le data set par le résultat de l'éxécution de la requête ( de data adapter ) 
            Console.WriteLine("problem here4")
            dt = dts.Tables("table")              'mettre dans le data table le résultat de l'éxécution de requête ( le data set )
            Console.WriteLine("problem here5")

        Catch ex As Exception
            MsgBox("excecute recherche problem" + ex.Message())
        Finally
            cnx.Close()                              'fermer la connexion
        End Try

        Return dt

    End Function


    Public Shared Function getInfoBDD(ByVal champs As String, ByVal matricule As String) As String
        ' retourner une information d'un champ spécifié "champs"  d'un étudiant idantifié par son "MATRICULE" 


        Dim da As New OleDb.OleDbDataAdapter        'le data adapter
        Dim con As OleDb.OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=..\..\VISUAL.accdb")       'la connexion à la BDD
        Dim dt As New DataTable                     'le datatable
        Dim cmd As OleDbCommand                     'la commande
        Dim dts As New DataSet                      'le Data Set
        Dim Resultat As Object = ""  'l'information qu'on cherche sur l'étudiant
        Dim sql As String = " SELECT * FROM INSCRIPTION WHERE " & champsMATRIN & "='" & matricule & "'"  'l'instruction SQL 


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
            MsgBox(" La connexion à la base de données est échouée :( ", ex.Message)
        Finally
            'close connection
            con.Close()
        End Try

        Return Resultat

    End Function

End Class