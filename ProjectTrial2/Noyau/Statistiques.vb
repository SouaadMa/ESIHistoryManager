Public Class TraitStatistiques
    'Classe sépciale pour les méthodes de la fonctionnalité des statistiques

    Public Shared Sub TraitStatistiques(ByVal domaineEtudiants As List(Of Critere), ByVal ChampsDetude As String, ByVal RepartitionPar As Critere)

        Dim CodeConditions As New List(Of Critere)
        Dim Champs As New List(Of String)

        ' ***********************PARTIE 01: PREPARATION DES ARGUMENTS DE LA REQUETE*********************'
        ' **********************************************************************************************'

        ' On obtient tout les codes et leurs parties dans CodeConditions 
        ' On laisse le reste (si il en reste quelques critères) dans domaineEtudiants
        ExtractPartsOfCodeTable(domaineEtudiants, CodeConditions, BDD.nomTablePROMO)
        ExtractPartsOfCodeTable(domaineEtudiants, CodeConditions, BDD.nomTableEtudiant)
        'ExtractPartsOfCodeTable(domaineEtudiants, CodeConditions, BDD.nomTableMATIERE)

        '..............Conditions, Check :D


        ' On ajoute le champ d'étude, et le champ de répartition aux champs de la requête
        ' Et on prépare les tables avec lesquelles on va faire la requête
        Dim PaireTables As New Paire("", "") 'Objet dans lequel on récupère les tables

        Champs = prepareChamps(ChampsDetude, RepartitionPar.getChamps, PaireTables)


        '..............Champs, Check :DD
        '..............Tables, Check :DDD


        '**********************PARTIE 02 : PREPARATION DE LA REQUETE EN FONCTION DES ENTREES*************'
        '************************************************************************************************'

        Dim requeteSQL As String = prepareRequeteInitiale(Champs, PaireTables, domaineEtudiants)












    End Sub


    ' Méthode qui extrait les parties du CodeTable de la table donnée, elle les retourne dans partsOfCodeTable,
    ' *************************** Le code lui même, fait partie des parties du code *****************
    ' Et retourne le reste des critères (les autres champs) dans conditions.
    Private Shared Sub ExtractPartsOfCodeTable(ByRef conditions As List(Of Critere), ByRef partsOfCodeTable As List(Of Critere), ByVal nomTable As String)

        For Each cr In conditions

            If ((cr.getTable = nomTable Or cr.getTable = "") And BDD.CompareToCodeTable(nomTable, cr) <> "") Then

                'Si le critère appartient à la table, soit il est son code, soit il en fait partie.
                'Donc on le supprime de conditions, et on le rajoute à partsOfCodeTable
                cr.setTable(nomTable)
                conditions.Remove(cr)
                partsOfCodeTable.Add(cr)

            End If

            'Si le critère n'appartient pas à la table, on le laisse dans conditions

        Next


    End Sub



    ' Méthode qui prépare les champs de la requête des statistiques à partir du champ d'études et le champ de
    ' répartition, elle retourne une collection des champs, et remplit le paire des tables qu'on va travailler avec

    Private Shared Function prepareChamps(ByVal champE As String, ByVal champR As String, ByRef tables As Paire) As List(Of String)

        Dim champsRetour As New List(Of String)

        Select Case champE

            Case "Nombre"
            Case BDD.champsDECIIN, BDD.champsMOYEIN
                champsRetour.Add(champE)
                tables.elem1 = BDD.nomTableINSCRIPTION
            Case BDD.champsNOJUNO
                tables.elem1 = BDD.nomTableNOTE


        End Select

        champsRetour.Add(champR)

        Select Case champR

            Case BDD.champsSEXE
                tables.elem2 = BDD.nomTableEtudiant
            Case BDD.champsOption, BDD.champsNiveau
                tables.elem2 = BDD.nomTablePROMO
            Case BDD.champsCodeGroupe
                tables.elem2 = BDD.nomTableINSCRIPTION

        End Select

        Return champsRetour

    End Function

    Private Shared Function prepareRequeteInitiale(ByVal champs As List(Of String), ByVal paireTables As Paire, ByVal conditions As List(Of Critere)) As String

        Dim tab1 As String = paireTables.elem1
        Dim tab2 As String = paireTables.elem2
        Dim req As String = ""

        If (tab1 = "" And tab2 <> "") Then

            ' On va rechercher seulement dans tab2
            For Each cond As Critere In conditions

                req = Rech_BDD.genereRechRequetes(req, cond, tab2)

            Next














        End If










        Return ""

    End Function



    'filtrer les colonnes datatable de résultat si on a recherché dans une seule table



End Class
