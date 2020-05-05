Public Class Statistiques
    'Classe sépciale pour les méthodes de la fonctionnalité des statistiques

    Private Shared tableDomaineEtudiants As String = "" ' BDD.nomTableINSCRIPTION
    Private Shared tableCodes As String() = {BDD.champsCodePromo, BDD.champsMATRIN}
    Private crEtudes As Critere
    Private champRepartition As String
    Private dataTable As New DataTable
    Private paireTables As New Paire("", "")


    Public Sub New(ByVal domaineEtudiants As List(Of Critere), ByVal ChampsDetude As Critere, ByVal RepartitionPar As String)

        Dim domaine As New List(Of Critere)(domaineEtudiants.AsEnumerable)
        Dim CodeConditions As New List(Of Critere)
        Dim Champs As New List(Of String)
        crEtudes = ChampsDetude
        champRepartition = RepartitionPar

        ' ***********************PARTIE 01: PREPARATION DES ARGUMENTS DE LA REQUETE*********************'
        ' **********************************************************************************************'

        ' On obtient tout les codes et leurs parties dans CodeConditions 
        ' On laisse le reste (si il en reste quelques critères) dans domaineEtudiants
        'ExtractPartsOfCodeTable(domaineEtudiants, CodeConditions, BDD.nomTablePROMO)
        'ExtractPartsOfCodeTable(domaineEtudiants, CodeConditions, BDD.nomTableEtudiant)
        'ExtractPartsOfCodeTable(domaineEtudiants, CodeConditions, BDD.nomTableMATIERE)

        If (domaineEtudiants.Count > 0) Then
            tableDomaineEtudiants = BDD.nomTableINSCRIPTION

            If checkTableDomaine(domaine, tableDomaineEtudiants) = True Then

                ExtractPartsOfCodeTable(domaine, CodeConditions, tableCodes(0))

            Else
                MsgBox("Les conditions sur le domaine doivent appartenir à tableDomaine")
            End If

        End If

        'Console.WriteLine("domaine")
        'show(domaine)
        'Console.WriteLine("codeconditions")
        'show(CodeConditions)


        '..............Conditions, Check :D


        ' On ajoute le champ d'étude, et le champ de répartition aux champs de la requête
        ' Et on prépare les tables avec lesquelles on va faire la requête


        Champs = prepareChamps()

        'Console.WriteLine("champsRetour")
        'show(Champs)

        'Console.WriteLine("Paire")
        'Console.WriteLine(PaireTables.elem1 + "." + PaireTables.elem2)
        Console.WriteLine(PaireTables.elem1 + "." + PaireTables.elem2)

        '..............Champs, Check :DD
        '..............Tables, Check :DDD


        '**********************PARTIE 02 : PREPARATION DE LA REQUETE EN FONCTION DES ENTREES*************'
        '************************************************************************************************'

        Dim requeteSQL As String = prepareRequeteInitiale(Champs, paireTables, domaine)


        For Each ch In CodeConditions
            ch.setTable(paireTables.elem1)
            requeteSQL = Class_BDD.AddLIKECondition(requeteSQL, tableCodes(0), ch)
        Next

        
        ' A cette étape, notre requête sélectionne les colonnes crEtudes et champRepartition
        ' de toutes les lignes de la BDD qui vérifient les critères du domaine en entrée.


        ' Il nous reste d'ajouter la fonction d'agrégation 'COUNT'
        ' et de les regouper selon le champ de répartition

        requeteSQL = Class_BDD.addCount(requeteSQL, champRepartition, paireTables.elem2, "Total")

        requeteSQL = ajouteConditions(requeteSQL)

        requeteSQL = Class_BDD.addGroupBy(requeteSQL, champRepartition, paireTables.elem2)

        Console.WriteLine(requeteSQL)





        dataTable = BDD.executeRequete(requeteSQL)









    End Sub

    ' Méthode pour filtrer une DataTable selon le critère en entrée
    Public Shared Function FilterDataTableBy(ByVal dataTable As DataTable, ByVal critere As Critere) As DataTable

        Dim filter As String
        Dim valeur As String

        If (dataTable.Columns.Contains(critere.getChamps)) Then

            Select Case (critere.getValeur.GetType).ToString       ' Savoir le type de la valeur :
                Case "System.String"                                      ' valeur Text
                    valeur = "'" + critere.getValeur + "'"
                Case GetType(Integer).ToString, GetType(Double).ToString  ' valeur Numérique
                    valeur = critere.getValeur.ToString
                Case "System.Boolean"                                     ' valeur Booleen
                    valeur = critere.getValeur
                Case Else
                    Console.WriteLine("Erreur type FilterDataTableBy")
                    valeur = ""
            End Select

            filter = critere.getChamps + " = " + valeur

        Else

            Console.WriteLine("La colonne avec laquelle vous voulez filtrer n'appartient pas à DataTable")
            Return Nothing

        End If

        Console.WriteLine(filter)

        Return dataTable.Select(filter).CopyToDataTable

    End Function

    ' Méthode pour filtrer une DataTable selon le critère en entrée
    Public Shared Function FilterDataTableBy(ByVal dataTable As DataTable, ByVal critere As Critere, ByVal superior As Boolean) As DataTable

        Dim filter As String

        If (dataTable.Columns.Contains(critere.getChamps)) Then

            If critere.getValeur.GetType.ToString.Equals(GetType(Integer).ToString) Or critere.getValeur.GetType.ToString.Equals(GetType(Double).ToString) Then
                If superior Then
                    filter = critere.getChamps + " > " + critere.getValeur.ToString
                Else
                    filter = critere.getChamps + " < " + critere.getValeur.ToString
                End If
            Else
                Console.WriteLine("Vous êtes entrain de comparer avec un type non numérique")
                Return Nothing
            End If

        Else

            Console.WriteLine("La colonne avec laquelle vous voulez filtrer n'appartient pas à DataTable")
            Return Nothing

        End If

        Console.WriteLine("filter: " + filter)

        Return dataTable.Select(filter).CopyToDataTable

    End Function



    ' Méthode qui extrait les parties du CodeTable donné, elle les retourne dans partsOfCodeTable,
    ' *************************** Le code lui même, fait partie des parties du code *****************
    ' Et retourne le reste des critères (les autres champs) dans conditions.
    Private Shared Sub ExtractPartsOfCodeTable(ByRef conditions As List(Of Critere), ByRef partsOfCodeTable As List(Of Critere), ByVal nomCode As String)

        Dim copyconditions As New List(Of Critere)
        copyconditions.AddRange(conditions)

        For Each cr In copyconditions

            If (BDD.CompareToCode(nomCode, cr) <> "") Then

                'Si le critère appartient au code, soit c'est lui même, soit il en fait partie.
                'Donc on le supprime de conditions, et on le rajoute à partsOfCodeTable
                conditions.Remove(cr)
                partsOfCodeTable.Add(cr)

            End If

            'Si le critère n'appartient pas au code, on le laisse dans conditions

        Next


    End Sub

    ' 

    Private Shared Function checkTableDomaine(ByVal domaine As List(Of Critere), ByVal nomTable As String) As Boolean

        Dim valide As Boolean = True

        For Each cr In domaine

            If (Not cr.getTable = nomTable) And cr.getTable <> "" Then
                valide = False

                For Each code In tableCodes

                    If BDD.CompareToCode(code, cr) <> "" Then
                        valide = True
                    End If

                Next

                If Not valide Then
                    Console.WriteLine(cr.getChamps)
                End If

            End If

        Next

        Return valide

    End Function



    ' Méthode qui prépare les champs de la requête des statistiques à partir du champ d'études et le champ de
    ' répartition, elle retourne une collection des champs, et remplit le paire des tables qu'on va travailler avec

    Private Function prepareChamps() As List(Of String)

        Dim champsRetour As New List(Of String)

        Select Case crEtudes.getChamps

            Case "Nombre"
            Case BDD.champsDECIIN, BDD.champsMOYEIN
                'champsRetour.Add(crEtudes.getChamps)
                paireTables.elem1 = BDD.nomTableINSCRIPTION
            Case BDD.champsNOJUNO
                paireTables.elem1 = BDD.nomTableNOTE
                'champsRetour.Add(crEtudes.getChamps)


        End Select

        champsRetour.Add(champRepartition)

        Select Case champRepartition

            Case BDD.champsSEXE
                paireTables.elem2 = BDD.nomTableEtudiant
            Case BDD.champsOption, BDD.champsNiveau
                paireTables.elem2 = BDD.nomTablePROMO
            Case BDD.champsCodeGroupe, BDD.champsDECIIN
                paireTables.elem2 = BDD.nomTableINSCRIPTION
            Case BDD.champsCOMAMA
                paireTables.elem2 = BDD.nomTableMATIERE

        End Select

        Return champsRetour

    End Function

    Private Shared Function prepareRequeteInitiale(ByVal champs As List(Of String), ByVal paireTables As Paire, ByVal conditions As List(Of Critere)) As String

        Dim tab1 As String = paireTables.elem1
        Dim tab2 As String = paireTables.elem2
        Dim req As String = ""

        '****************************PREMIER CAS: LES DEUX TABLES SONT VIDES*********************'
        '**************************************ERREUR********************************************'

        If (tab1 = "" And tab2 = "") Then

            MsgBox("Paire VIDE")
            Return ""

        End If


        '****************************DEUXIEME CAS: UNE DES DEUX TABLES EST VIDE*******************'
        '*************On va le traiter avec le troisième cas***************************
        '*********************************_______________________*********************************'

        If ((tab1 = "" And tab2 <> "") Or tab1.Equals(tab2)) Then

            If (tableDomaineEtudiants = "") Then
                tab1 = tab2
            Else
                tab1 = tableDomaineEtudiants
            End If


        ElseIf (tab2 = "") Then
            '******* tab2 VIDE *******'


            If (tableDomaineEtudiants = "") Then
                tab2 = tab1
            Else
                tab2 = tableDomaineEtudiants
            End If

        End If

        '****************************TROISIEME CAS: tab1 = tab2*******************'
        '****************************__________________________*******************'

        If tab1 = tab2 Then

            'Console.WriteLine("tab1 = tab2")
            'Console.WriteLine(tab1 + "." + tab2)

            req = Rech_BDD.genereRechRequetes(req, Nothing, tab1)

            For Each cond In conditions
                req = Rech_BDD.genereRechRequetes(req, cond, tab1)
            Next

            req = Rech_BDD.AddChamps(req, champs, tab1)

        End If


        '*******************QUATRIEME CAS: LES DEUX TABLES SONT NON VIDES ET DISTINCTES*******************'
        '************************************RECHERCHE DANS DEUX TABLEs***********************************'

        If (tab1 <> "" And tab2 <> "") And Not (tab1.Equals(tab2)) Then

            req = Class_BDD.genereRechRequete(champs, tab1, tab2, conditions, True)

            'Console.WriteLine("DEUX TABS NON VIDES")
            'Console.WriteLine(tab1 + "." + tab2)

            'For Each cr In conditions
            'Console.WriteLine(cr.getChamps)
            'Next

        End If

        paireTables.elem1 = tab1
        paireTables.elem2 = tab2


        Return req

    End Function

    Public Shared Sub show(ByVal list As List(Of Critere))

        For Each cr In list
            Console.WriteLine(cr.getChamps + cr.getValeur.ToString + cr.getTable)

        Next

        Console.WriteLine()
    End Sub

    Public Shared Sub show(ByVal list As List(Of String))

        For Each cr In list
            Console.WriteLine(cr)

        Next

        Console.WriteLine()
    End Sub

    Public Function ajouteConditions(ByVal req As String) As String

        Dim nouvReq As String = req

        Select Case crEtudes.getChamps

            Case BDD.champsNOJUNO
                nouvReq = Rech_BDD.AddWHEREComparaison(req, crEtudes, 1, True)
            Case BDD.champsDECIIN
                Select Case crEtudes.getValeur.ToString

                    Case "REUSSITE"
                        nouvReq = Rech_BDD.AddWHEREComparaison(req, New Critere("(" + BDD.champsDECIIN, "'1'"), 0, True)
                        nouvReq = Rech_BDD.AddWHEREComparaison(nouvReq, New Critere(BDD.champsDECIIN, "'2')"), 0, False)
                    Case "ECHEC"
                        nouvReq = Rech_BDD.AddWHEREComparaison(req, New Critere(BDD.champsDECIIN, "'3'"), 0, True)
                        nouvReq = Rech_BDD.AddWHEREComparaison(nouvReq, New Critere(BDD.champsDECIIN, "'4'"), 0, False)
                    Case Else
                        'Abandon / Maladie
                        nouvReq = Rech_BDD.AddWHEREComparaison(req, New Critere(BDD.champsDECIIN, "'0'"), 0, True)


                End Select
            Case BDD.champsMOYEIN
                nouvReq = Rech_BDD.AddWHEREComparaison(req, crEtudes, 1, True)


        End Select

        Return nouvReq

    End Function

    Public Function GetTotal(ByVal condition As Object) As Integer

        Dim valeur As String

        

        Select Case (condition.GetType).ToString       ' Savoir le type de la valeur :
            Case "System.String"                                      ' valeur Text
                valeur = "'" + condition + "'"
                Select Case valeur
                    Case "'ADMIS'"
                        valeur = "1"
                    Case "'RACHAT'"
                        valeur = "2"
                    Case "'REDOUBLE'"
                        valeur = "3"
                    Case "'NONADMIS'"
                        valeur = "4"
                    Case "'ABANDON'"
                        valeur = "0"
                End Select
            Case GetType(Integer).ToString, GetType(Double).ToString, "System.Boolean"
                valeur = condition.ToString
            Case Else
                MsgBox("Rakom Tela3bou ha ma tmedoulish objet khaser")
                valeur = ""
        End Select

        Dim rows() As DataRow = dataTable.Select(dataTable.Columns(1).ColumnName + " = " + valeur)
        If rows.Count > 0 Then
            Return rows(0).Item("Total")
        Else
            Return 0
        End If

    End Function

    Public Function GetDataTable() As DataTable
        Return dataTable
    End Function

End Class
