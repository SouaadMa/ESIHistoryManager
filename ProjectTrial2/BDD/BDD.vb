Imports System.Data.OleDb

Public Class BDD

    'Les noms des tables de la BDD
    Public Const nomTableEtudiant = "ETUDIANT", nomTableINSCRIPTION = "INSCRIPTION"
    Public Const nomTableNOTE = "NOTES", nomTableNoteRATRAP = "NoteRATRAP"
    Public Const nomTableGROUP = "GROUPE", nomTableSection = "SECTIONS"
    Public Const nomTablePROMO = "PROMO", nomTableMATIERE = "MATIERE"
    Public Const nomTableRATRAP = "RATRAP"

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
    Public Const champsDECIIN = "DECIIN", champsDECI = "DECI"
    Public Const champsADM = "ADM"

    'Les noms des champs de la table NOTES
    Public Const champsCodeMat = "CodeMat", champsNOJUNO = "NOJUNO"
    Public Const champsNOSYNO = "NOSYNO", champsNORANO = "NORANO"
    Public Const champsELIMNO = "ELIMNO", champsRATRNO = "RATRNO"
    Public Const champsCOMANO = "COMANO"

    'Les noms des champs de la table NoteRATRAP
    Public Const champsCodeRat = "CodeRat", champsMOYERA = "MOYERA"
    Public Const champsMENTRA = "MENTRA", champsELIMRA = "ELIMRA"


    'Les noms des champs de la table GROUPE
    Public Const champsCodeSection = "CodeSection"

    'Les noms des champs de la table Section
    Public Const champsCodePromo = "CodePromo"

    'Les noms des champs de la table PROMO
    Public Const champsNiveau = "Niveau", champsOption = "Optin"
    Public Const champsAnnee = "Annee", champsNbreEtudiant = "NbreEtudiant"
    Public Const champsMoyenne = "Moyenne"

    'Les noms des champs de la table MATIERE
    Public Const champsANSCMA = "ANSCMA", champsANETMA = "ANETMA"
    Public Const champsCYCLMA = "CYCLMA", champsOPTIMA = "OPTIMA"
    Public Const champsLIBEMA = "LIBEMA", champsCOMAMA = "COMAMA"
    Public Const champsTYPEMA = "TYPEMA", champsCOEFMA = "COEFMA"
    Public Const champsMOYMAT = "MOYMAT"

    'Les noms des champs de la table RATRAP
    Public Const champsANSCRA = "ANSCRA", champsANETRA = "ANETRA"
    Public Const champsCYCLRA = "CYCLRA", champsOPTIRA = "OPTIRA"


    ' les tableaux qui contiennet les champs des tables de base de données :
    Public Shared stringETUDIANT() As String = {BDD.champsNomEtud, BDD.champsPrenoms, BDD.champsNomEtudA, BDD.champsPrenomsA, BDD.champsMATRIC_INS, BDD.champsMATRIN, BDD.champsDateNais, BDD.champsLieuNaisA, BDD.champsLieuNais, BDD.champsADRESSE, BDD.champsVILLE, BDD.champsWILAYA, BDD.champsWILBAC, BDD.champsSERIEBAC, BDD.champsFILS_DE, BDD.champsET_DE, BDD.champsCODEPOS, BDD.champsWilayaNaisA, BDD.champsANNEEBAC, BDD.champsSEXE, BDD.champsWILNAIS, BDD.champsMOYBAC}
    Public Shared stringINSCRIPTION() As String = {BDD.champsMATRIN, BDD.champsCodePromo, BDD.champsCodeSection, BDD.champsDECIIN, BDD.champsDECI, BDD.champsADM}
    Public Shared stringGROUP() As String = {BDD.champsCodePromo, BDD.champsCodeSection}
    Public Shared stringSection() As String = {BDD.champsCodePromo, BDD.champsCodeSection}
    Public Shared stringPROMO() As String = {BDD.champsCodePromo, BDD.champsOption, BDD.champsAnnee}
    Public Shared stringNOTE() As String = {BDD.champsCodeMat, BDD.champsMATRIN, BDD.champsCodePromo, BDD.champsCOMANO}
    Public Shared stringMATIERE() As String = {BDD.champsCodeMat, BDD.champsCodePromo, BDD.champsCOMAMA, BDD.champsCYCLMA, BDD.champsLIBEMA, BDD.champsTYPEMA}
    Public Shared stringNOTERATRAP() As String = {BDD.champsMATRIN, BDD.champsCodeRat}
    Public Shared stringRATRAP() As String = {BDD.champsCYCLRA, BDD.champsOPTIRA, BDD.champsCodeRat, BDD.champsANSCRA}

    Public Shared numETUDIANT() As String = {}
    Public Shared numINSCRIPTION() As String = {BDD.champsCodeGroupe, BDD.champsMOYEIN, BDD.champsRANGIN, BDD.champsMENTIN, BDD.champsELIMININ, BDD.champsRATRIN}
    Public Shared numGROUP() As String = {BDD.champsCodeGroupe}
    Public Shared numSection() As String = {}
    Public Shared numPROMO() As String = {BDD.champsNiveau, BDD.champsNbreEtudiant, BDD.champsMoyenne}
    Public Shared numNOTE() As String = {BDD.champsNOJUNO, BDD.champsNOSYNO, BDD.champsNORANO, BDD.champsELIMNO, BDD.champsRATRNO}
    Public Shared numMATIERE() As String = {BDD.champsCOEFMA, BDD.champsMOYMAT}
    Public Shared numNOTERATRAP() As String = {BDD.champsMOYERA, BDD.champsMENTRA, BDD.champsELIMRA}
    Public Shared numRATRAP() As String = {BDD.champsANETRA}

    Public Shared boolETUDIANT() As String = {}
    Public Shared boolINSCRIPTION() As String = {}
    Public Shared boolGROUP() As String = {}
    Public Shared boolSection() As String = {}
    Public Shared boolPROMO() As String = {}
    Public Shared boolNOTE() As String = {}
    Public Shared boolMATIERE() As String = {}
    Public Shared boolNOTERATRAP() As String = {}
    Public Shared boolRATRAP() As String = {}

    Private stringChamp()() As String = {stringETUDIANT, stringINSCRIPTION, stringGROUP, stringSection, stringPROMO,
                              stringNOTE, stringMATIERE, stringNOTERATRAP, stringRATRAP}
    Private numChamp()() As String = {numETUDIANT, numINSCRIPTION, numGROUP, numSection, numPROMO,
                              numNOTE, numMATIERE, numNOTERATRAP, numRATRAP}
    Private boolChamp()() As String = {boolETUDIANT, boolINSCRIPTION, boolGROUP, boolSection, boolPROMO,
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

    'Fonction qui retourne la table des champs de type "chaine"
    'Créé pour faciliter la généralisation des autres méthodes
    Public Shared Function getStringTable(ByVal name) As String()

        Select Case name

            Case nomTableEtudiant
                Return stringETUDIANT
            Case nomTableGROUP
                Return stringGROUP
            Case nomTableINSCRIPTION
                Return stringINSCRIPTION
            Case nomTableMATIERE
                Return stringMATIERE
            Case nomTableNOTE
                Return stringNOTE
            Case nomTableNoteRATRAP
                Return stringNOTERATRAP
            Case nomTablePROMO
                Return stringPROMO
            Case nomTableRATRAP
                Return stringRATRAP
            Case nomTableSection
                Return stringSection
            Case Else
                MsgBox("Le nom de la table entrée n'existe pas")
                Return stringETUDIANT


        End Select


    End Function


    'Fonction qui retourne la table des champs de type "numérique"
    Public Shared Function getNumTable(ByVal name) As String()

        Select Case name

            Case nomTableEtudiant
                Return numETUDIANT
            Case nomTableGROUP
                Return numGROUP
            Case nomTableINSCRIPTION
                Return numINSCRIPTION
            Case nomTableMATIERE
                Return numMATIERE
            Case nomTableNOTE
                Return numNOTE
            Case nomTableNoteRATRAP
                Return numNOTERATRAP
            Case nomTablePROMO
                Return numPROMO
            Case nomTableRATRAP
                Return numRATRAP
            Case nomTableSection
                Return numSection
            Case Else
                MsgBox("Le nom de la table entrée n'existe pas")
                Return numETUDIANT


        End Select

    End Function


    'Fonction qui retourne la table des champs de type "booléen"
    Public Shared Function getBoolTable(ByVal name) As String()

        Select Case name

            Case nomTableEtudiant
                Return boolETUDIANT
            Case nomTableGROUP
                Return boolGROUP
            Case nomTableINSCRIPTION
                Return boolINSCRIPTION
            Case nomTableMATIERE
                Return boolMATIERE
            Case nomTableNOTE
                Return boolNOTE
            Case nomTableNoteRATRAP
                Return boolNOTERATRAP
            Case nomTablePROMO
                Return boolPROMO
            Case nomTableRATRAP
                Return boolRATRAP
            Case nomTableSection
                Return boolSection
            Case Else
                MsgBox("Le nom de la table entrée n'existe pas")
                Return boolETUDIANT


        End Select


    End Function

    Public Shared Function executeRequete(ByVal requete As String) As DataTable
        'retourner un dataTable contenant les étudiants qui vérifient la requête


        Dim cnx As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\BDD_TESTE.accdb")  'la connexion à la BDD


        Dim cmd As OleDbCommand                     ' la commande
        Dim ta As OleDbDataAdapter                  ' le Data Adapter
        Dim dts As New DataSet                      ' le Data Set
        Dim dt As DataTable                         ' le Data Table

        dt = New DataTable()

        Try
            'Console.WriteLine("problem here0")
            cnx.Open()                               ' ouvrir la connection avec la base de données
            'Console.WriteLine("problem here1")
            cmd = New OleDbCommand(requete, cnx) ' la connection au commande
            'Console.WriteLine("problem here2")
            ta = New OleDbDataAdapter(cmd)       ' creer un nouveau DataAdapter
            'Console.WriteLine("problem here3")
            ta.Fill(dts)                         ' remplir le data set par le résultat de l'éxécution de la requête ( de data adapter ) 
            'Console.WriteLine("problem here4")
            dt = dts.Tables("table")              'mettre dans le data table le résultat de l'éxécution de requête ( le data set )
            'Console.WriteLine("problem here5")

        Catch ex As Exception
            MsgBox("excecute recherche problem" + ex.Message())
        Finally
            cnx.Close()                              'fermer la connexion
        End Try

        Return dt

    End Function




    Public Shared Function getInfoBDD(ByVal champs As String, ByVal matricule As String) As String
        ' retourner une information d'un champ spécifié "champs"  d'un étudiant idantifié par son "MATRICULE" 

        'MsgBox("INSIDE GETINFO")

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

    Public Shared Function GetFromTable(ByVal nomTable As String, ByVal critere As Critere) As DataRow

        'Méthode qui retourne toutes les informations de la table "nomTable" qui correspondent 
        ' au critère en entrée

        'Création de la requête
        Dim SqlQuery As String = "SELECT * FROM " + nomTable + " WHERE " + CompareToCodeTable(nomTable, critere) + ";"

        'Exécution de la requête
        Dim table As DataTable = executeRequete(SqlQuery)

        'Récupération de la première (et seule) ligne de la table du résultat
        Dim resultat As DataRow = table.Rows.Item(0)

        Return resultat


    End Function


    Public Shared Function GetFromTable(ByVal nomTable As String, ByVal matrin As String, ByVal critere As Critere) As DataRow
        'Méthode qui retourne toutes les informations de la table "nomTable" qui correspondent 
        'à un étudiant
        'de matricule matrin, + un critère avec lequel on détermine l'année

        'Création de la requête
        Dim SqlQuery As String = "SELECT * FROM " + nomTable + " WHERE " + champsMATRIN + " = '" + matrin + "' AND " + CompareToCodeTable(nomTable, critere) + ";"

        'Exécution de la requête
        Dim table As DataTable = executeRequete(SqlQuery)

        'Récupération de la première (et seule) ligne de la table du résultat
        Dim resultat As DataRow = table.Rows.Item(0)

        Return resultat

    End Function

    Public Shared Function CompareToCodeTable(ByVal nomTable As String, ByVal critere As Critere) As String

        Select Case nomTable
            Case nomTableINSCRIPTION
                Return CompareToCodeGroupe(critere)
            Case nomTableGROUP
                Return CompareToCodeGroupe(critere)
            Case nomTableSection
                Return CompareToCodeSection(critere)
            Case nomTableNOTE
                Return CompareToCodeMat(critere)
            Case Else
                Return ""
        End Select

    End Function




    Private Shared Function CompareToCodeGroupe(ByVal critere As Critere) As String

        ' Méthode qui génère la condition pour que le critère ressemble au CodeGroupe 

        Dim chaine As String = ""
        Dim champs As String = critere.getChamps

        ' Le CodeGroupe s'écrit de la forme NG/NS/Niv/Option/Annee
        ' __________________________________NG/CodeSection
        ' __________________________________NG/NS/CodePromo

        Select Case champs

            Case BDD.champsNiveau
                chaine = "CodeGroupe LIKE '%/" + champs + "/%'"
            Case BDD.champsOption
                chaine = "CodeGroupe LIKE '%/" + champs + "/%'"
            Case BDD.champsAnnee
                chaine = "CodeGroupe LIKE '%/" + champs + "'"
            Case BDD.champsCodeSection
                chaine = "CodeGroupe LIKE '%/" + champs + "'"
            Case BDD.champsCodePromo
                chaine = "CodeGroupe LIKE '%/" + champs + "'"
            Case BDD.champsCodeGroupe
                chaine = "CodeGroupe = '" + champs + "'"

                'A ajouter CodePROMO et CodeSection

        End Select


        Return chaine

    End Function

    Private Shared Function CompareToCodeSection(ByVal critere As Critere) As String

        ' Méthode qui génère la condition pour que le critère ressemble au CodeSection

        Dim chaine As String = ""
        Dim champs As String = critere.getChamps

        ' Le CodeSection s'écrit de la forme NS/Niv/Option/Annee
        '____________________________________NS/CodePROMO 

        Select Case champs

            Case BDD.champsNiveau
                chaine = "CodeSection LIKE '_/" + champs + "/%'"
            Case BDD.champsOption
                chaine = "CodeSection LIKE '%/" + champs + "/%'"
            Case BDD.champsAnnee
                chaine = "CodeSection LIKE '%/" + champs + "'"
            Case BDD.champsCodePromo
                chaine = "CodeSection = '%/" + champs + "'"
            Case BDD.champsCodeSection
                chaine = "CodeSection = '" + champs + "'"
            Case Else
                chaine = ""
        End Select

        Return chaine

    End Function

    Private Shared Function CompareToCodePROMO(ByVal critere As Critere) As String

        ' Méthode qui génère la condition pour que le critère ressemble au CodePROMO

        Dim chaine As String = ""
        Dim champs As String = critere.getChamps

        ' Le CodePROMO s'écrit de la forme Niv/Option/Annee

        Select Case champs

            Case BDD.champsNiveau
                chaine = "CodePROMO LIKE '" + champs + "/%'"
            Case BDD.champsOption
                chaine = "CodePROMO LIKE '%/" + champs + "/%'"
            Case BDD.champsAnnee
                chaine = "CodePROMO LIKE '%/" + champs + "'"
            Case BDD.champsCodePromo
                chaine = "CodePROMO = '" + champs + "'"
            Case Else
                chaine = ""

        End Select

        Return chaine

    End Function

    Private Shared Function CompareToCodeMat(ByVal critere As Critere) As String

        ' Méthode qui génère la condition pour que le critère ressemble au CodeMat

        Dim chaine As String = ""
        Dim champs As String = critere.getChamps

        ' Le CodeMat s'écrit de la forme Nom/Annee/Option/Niveau

        Select Case champs

            Case BDD.champsLIBEMA
                Return "CodeMat LIKE '" + champs + "/%'"
            Case BDD.champsAnnee
                Return "CodeMat LIKE '%/" + champs + "/%'"
            Case BDD.champsOption
                Return "CodeMat LIKE '%/" + champs + "/%'"
            Case BDD.champsNiveau
                Return "CodeMat LIKE '%/" + champs + "'"
            Case BDD.champsCodeMat
                Return "CodeMat = '" + champs + "'"
            Case Else
                Return ""

                'A ajouter CodePROMO si on en aura besoin

        End Select


    End Function


    'Une fonction qui ramène toutes les valeurs possibles (distinctes) d'un certain champs de la BDD

    Public Shared Function GetALL(ByVal nomChamps As String, ByVal nomTable As String) As DataTable

        If ExisteDansTable(nomChamps, nomTable) Then

            Dim SqlQuery = "SELECT DISTINCT " & nomChamps & " FROM " & nomTable & ";"

            'MsgBox("before execute")

            Return executeRequete(SqlQuery)

        Else

            MsgBox("Ce champs n'existe pas dans la table")
            Return Nothing


        End If

    End Function

    Public Shared Function GetALL(ByVal nomChamps As String, ByVal nomTable As String, ByVal condition As Critere) As DataTable

        If ExisteDansTable(nomChamps, nomTable) Then

            Dim SqlQuery = "SELECT DISTINCT " & nomChamps & " FROM " & nomTable & " WHERE " & condition.getChamps & " = '" & condition.getValeur & "';"

            'MsgBox("before execute")

            Return executeRequete(SqlQuery)

        Else

            MsgBox("Ce champs n'existe pas dans la table")
            Return Nothing


        End If

    End Function

    Public Shared Function GetALLChamps(ByVal nomChamp1 As String, ByVal nomChamp2 As String, ByVal condition As Critere) As DataTable



        Dim SqlQuery = "SELECT DISTINCT " & nomChamp1 & "," & nomChamp2 & " FROM MATIERE WHERE " & condition.getChamps & " = '" & condition.getValeur & "'"

        'MsgBox("before execute")

        Return executeRequete(SqlQuery)



    End Function




    ' Méthode qui vérifie si le champs "champs" existe dans la table "table"

    Public Shared Function ExisteDansTable(ByVal champs As String, ByVal table As String) As Boolean

        Select Case table
            Case nomTableEtudiant
                Return (stringETUDIANT.Contains(champs) Or numETUDIANT.Contains(champs) Or boolETUDIANT.Contains(champs))
            Case nomTableGROUP
                Return (stringGROUP.Contains(champs) Or numGROUP.Contains(champs) Or boolGROUP.Contains(champs))
            Case nomTableINSCRIPTION
                Return (stringINSCRIPTION.Contains(champs) Or numINSCRIPTION.Contains(champs) Or boolINSCRIPTION.Contains(champs))
            Case nomTableMATIERE
                Return (stringMATIERE.Contains(champs) Or numMATIERE.Contains(champs) Or boolMATIERE.Contains(champs))
            Case nomTableNOTE
                Return (stringNOTE.Contains(champs) Or numNOTE.Contains(champs) Or boolNOTE.Contains(champs))
            Case nomTableSection
                Return (stringSection.Contains(champs) Or numSection.Contains(champs) Or boolSection.Contains(champs))
            Case nomTableNoteRATRAP
                Return (stringNOTERATRAP.Contains(champs) Or numNOTERATRAP.Contains(champs) Or boolNOTERATRAP.Contains(champs))
            Case nomTablePROMO
                Return (stringPROMO.Contains(champs) Or numPROMO.Contains(champs) Or boolPROMO.Contains(champs))
            Case nomTableRATRAP
                Return (stringRATRAP.Contains(champs) Or numRATRAP.Contains(champs) Or boolRATRAP.Contains(champs))
            Case Else
                Return False
        End Select


    End Function

    ' Méthode qui retourne la table qui contient le champs en entrée
    ' Utilisé en cas d'urgence x)

    Public Shared Function GetTable(ByVal champs As String) As String

        If (ExisteDansTable(champs, BDD.nomTableINSCRIPTION)) Then
            Return BDD.nomTableINSCRIPTION
        End If
        If (ExisteDansTable(champs, BDD.nomTableEtudiant)) Then
            Return BDD.nomTableEtudiant
        End If
        If (ExisteDansTable(champs, BDD.nomTableGROUP)) Then
            Return BDD.nomTableGROUP
        End If
        If (ExisteDansTable(champs, BDD.nomTableMATIERE)) Then
            Return BDD.nomTableMATIERE
        End If
        If (ExisteDansTable(champs, BDD.nomTableNOTE)) Then
            Return BDD.nomTableNOTE
        End If
        If (ExisteDansTable(champs, BDD.nomTableNoteRATRAP)) Then
            Return BDD.nomTableNoteRATRAP
        End If
        If (ExisteDansTable(champs, BDD.nomTablePROMO)) Then
            Return BDD.nomTablePROMO
        End If
        If (ExisteDansTable(champs, BDD.nomTableSection)) Then
            Return BDD.nomTableSection
        End If
        If (ExisteDansTable(champs, BDD.nomTableRATRAP)) Then
            Return BDD.nomTableRATRAP
        End If

        Return ""

    End Function




    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Shared tableCorespondante() As Paire = {New Paire(nomTableEtudiant, nomTableINSCRIPTION), New Paire(nomTableEtudiant, nomTableNOTE), New Paire(nomTableNOTE, nomTableMATIERE)}
    Private Shared champCorespondante() As Paire = {New Paire(champsMATRIN, champsMATRIN), New Paire(champsMATRIN, champsMATRIN), New Paire(champsCodeMat, champsCodeMat)}

    Public Shared Function getCorrespondance(ByVal tabs As Paire) As Paire
        Dim ind As Integer = IndexOf(tableCorespondante, tabs)
        'MsgBox(ind)
        If (ind > -1) Then
            Return champCorespondante(ind)
        Else
            MsgBox("Ces deux tables n'ont pas de correspandance")
            Return New Paire("", "")
        End If
    End Function

    Public Shared Function getCorrespondance(ByVal tab1 As String, ByVal tab2 As String, ByVal ind As Integer) As String
        Dim cles As Paire = getCorrespondance(New Paire(tab1, tab2))
        Return cles.getElement(ind)
    End Function

    Public Shared Function IndexOf(ByVal table As Paire(), ByVal paire As Paire) As Integer
        Dim ind As Integer = 0
        Dim found As Boolean = False
        While Not found And ind < table.Length
            If (table(ind).getElement(1)).Equals(paire.getElement(1)) And (table(ind).getElement(2)).Equals(paire.getElement(2)) Then
                found = True
            Else
                ind += 1
            End If
        End While
        If (found) Then
            Return ind
        Else
            Return -1
        End If

    End Function




End Class
