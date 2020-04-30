Public Class Classement
    'Classe pour la fonctionnalité du classement et du tri des étudiants


    Public Shared Function TraitClassement(ByVal Annee As String) As DataTable
        ' Méthode qui retourne une DataTable des étudiants ayant le même cursus, 
        ' commençant leurs études à l'année en entrée
        ' Cette DataTable est triée selon leurs moyennes de classement

        Dim tableEtudiants As New DataTable
        Dim tableMoyennesEtudiants As New DataTable
        Dim requeteSQL As New String("")
        Dim collectionMat As List(Of String) = New List(Of String)
        Dim listeConditions As List(Of Critere) = New List(Of Critere)
        Dim listeChamps As List(Of String) = New List(Of String)
        Dim dt As New DataTable



        ' ************** GETTING THE INFO FROM THE DATABASE *************** '
        ' Préparation de la liste des champs
        listeChamps.Add(BDD.champsRANGIN)
        listeChamps.Add(BDD.champsMATRIN)
        listeChamps.Add(BDD.champsNomEtud)
        listeChamps.Add(BDD.champsPrenoms)
        listeChamps.Add(BDD.champsCodePromo)
        ' Préparation de la liste des conditions
        listeConditions.Add(New Critere(BDD.champsDECIIN, "1"))
        listeConditions.Add(New Critere(BDD.champsDECIIN, "2"))


        ' La génération de la requête SQL pour obtenir la table des étudiants qu'on va classer
        requeteSQL = Class_BDD.genereRechRequete(listeChamps, BDD.nomTableEtudiant, BDD.nomTableINSCRIPTION, listeConditions, False)
        'requeteSQL == SELECT RANGIN, NomEtud, Prenoms, CodePromo
        'FROM INSCRIPTION INNER JOIN ETUDIANT ON INSCRIPTION.MATRIN = ETUDIANT.MATRIN
        ' WHERE (CodePromo LIKE '5/%/Annee+5') AND (DECIIN = )
        requeteSQL = Class_BDD.AddLIKECondition(requeteSQL, BDD.champsMATRIN, New Critere(BDD.champsAnnee, Annee, BDD.nomTableEtudiant))
        ' requeteSQL == requeteSQL + " AND (MATRIN LIKE 'Annee/%')"
        requeteSQL = Class_BDD.AddLIKECondition(requeteSQL, BDD.champsCodePromo, New Critere(BDD.champsNiveau, "5", BDD.nomTableINSCRIPTION))
        ' requeteSQL == requeteSQL + " AND (CodePromo LIKE '5/%')"
        requeteSQL = Class_BDD.AddLIKECondition(requeteSQL, BDD.champsCodePromo, New Critere(BDD.champsAnnee, (Integer.Parse(Annee) + 5).ToString, BDD.nomTableINSCRIPTION))
        ' requeteSQL == requeteSQL + " AND (CodePromo LIKE '%/Annee+5')"

        Console.WriteLine(requeteSQL)

        tableEtudiants = BDD.executeRequete(requeteSQL)


        For Each row As DataRow In tableEtudiants.Rows
            collectionMat.Add(CType(row(BDD.champsMATRIN), String))
        Next


        requeteSQL = ""
        listeChamps.Clear()

        listeChamps.Add(BDD.champsMATRIN)
        listeChamps.Add(BDD.champsMOYEIN)
        listeChamps.Add(BDD.champsMOYERA)

        listeConditions.Clear()

        Dim i As Integer = 0

        For Each mat In collectionMat

            If (i < 10) Then
                listeConditions.Add(New Critere(BDD.champsMATRIN, mat))
                i = i + 1
            Else
                requeteSQL = ""
                requeteSQL = Class_BDD.genereRechRequete(listeChamps, BDD.nomTableINSCRIPTION, BDD.nomTableNoteRATRAP, listeConditions, False)
                requeteSQL = Class_BDD.AddONCondition(requeteSQL, BDD.nomTableINSCRIPTION, BDD.nomTableNoteRATRAP, BDD.champsCodePromo, BDD.champsCodeRat)
                'Console.WriteLine(requeteSQL)

                dt.Merge(BDD.executeRequete(requeteSQL))

                listeConditions.Clear()
                i = 0
            End If

        Next

        



        'requeteSQL = Class_BDD.genereRechRequete(listeChamps, BDD.nomTableINSCRIPTION, BDD.nomTableNoteRATRAP, listeConditions, False)
        'dt = BDD.executeRequete(requeteSQL)

        'Console.WriteLine(dt.Equals(Nothing))

        calculMoyClassement(dt, tableEtudiants)


        Return SortDESCollection(tableEtudiants, "MoyClassement")

    End Function

    Public Shared Sub calculMoyClassement(ByVal dt As DataTable, ByRef dtEtud As DataTable)

        Dim moyennes() As DataRow
        Dim moyClassement As DataColumn = New DataColumn
        Dim moy As Double = 0
        Dim i As Integer = 0

        dtEtud.Columns.Add("MoyClassement", GetType(Double))

        For Each etud As DataRow In dtEtud.Rows

            i = 0

            moyennes = dt.Select(BDD.champsMATRIN & "=" & "'" & etud(BDD.champsMATRIN) & "'")
            For Each row As DataRow In moyennes
                i = i + 1
                moy += max(row(BDD.champsMOYEIN), row(BDD.champsMOYERA))
            Next
            moy /= 5

            'Console.WriteLine(i.ToString + " " + etud(BDD.champsMATRIN))

            etud("MoyClassement") = moy

            moy = 0

        Next

    End Sub

    Public Shared Function max(ByVal d1 As Double, ByVal d2 As Double) As Double

        If (d1.CompareTo(d2) > 0) Then
            Return d1
        Else
            Return d2
        End If
    End Function

    ' Ancienne Méthode qui retourne une collection limitée d'étudiants, triée selon leurs moyennes
    Public Shared Function TraitClassementA(ByVal criteres As List(Of Critere), Optional ByVal limite As Integer = 0) As DataTable

        Dim req = ""

        Dim year As New String("")
        Dim optio As New String("")
        Dim niv As New String("")
        Dim conditions As New List(Of Critere)

        ' This for each loop serves to create CodePromo and add it with the rest of the conditions..

        For Each criterea As Critere In criteres

            If criterea.getChamps.Equals(BDD.champsAnnee) Then
                year = criterea.getValeur
            Else
                If criterea.getChamps.Equals(BDD.champsOption) Then
                    optio = criterea.getValeur
                Else
                    If criterea.getChamps.Equals(BDD.champsNiveau) Then
                        niv = criterea.getValeur
                    Else
                        ' Other fields can be CodeSection and CodeGroupe
                        conditions.Add(criterea)

                    End If
                End If
            End If

        Next

        Try
            Dim codePromo As New Critere(BDD.champsCodePromo, New String(niv + "/" + optio + "/" + year))
            conditions.Add(New Critere(BDD.champsCodePromo, codePromo))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim champsDemandes As New List(Of String)({BDD.champsNomEtud, BDD.champsPrenoms, BDD.champsRANGIN, BDD.champsMATRIN, BDD.champsMOYEIN})

        req = Class_BDD.genereRechRequete(champsDemandes, BDD.nomTableEtudiant, BDD.nomTableINSCRIPTION, conditions, True)
        If limite > 0 Then
            Class_BDD.AjouterLimit_Requete(req, limite)
        End If
        Class_BDD.AjouterOrdre_Requete(req, BDD.champsMOYEIN)

        Return BDD.executeRequete(req)


    End Function


    ' Méthode pour filtrer une DataTable selon le critère en entrée
    Public Shared Function FilterDataTableBy(ByVal dataTable As DataTable, ByVal critere As Critere) As DataTable

        Dim filter As String = BDD.CompareToCode(BDD.champsCodePromo, critere)

        Console.WriteLine(filter)

        Return dataTable.Select(filter).CopyToDataTable

    End Function

    ' Méthode qui limite le nombre de lignes d'une DataTable ... 
    Public Shared Function LimitRows(ByVal table As DataTable, ByVal int As Integer) As DataTable


        Return table.AsEnumerable().Take(int).CopyToDataTable

    End Function


    ' Méthode pour le tri ascendant d'une datatable 
    Public Shared Function SortASCCollection(ByVal table As DataTable, ByVal champs As String) As DataTable

        table.DefaultView.Sort = champs + " ASC"
        Return table.DefaultView.ToTable

    End Function

    ' Méthode pour le tri ascendant d'une datatable 
    Public Shared Function SortDESCollection(ByVal table As DataTable, ByVal champs As String) As DataTable

        table.DefaultView.Sort = champs + " DESC"
        Return table.DefaultView.ToTable

    End Function

    ' Méthode pour le classement ascendant d'une collection d'étudiants
    Public Shared Function SortASCCollection(ByVal collection As List(Of Etudiant), ByVal champs As String) As List(Of Etudiant)

        ' Création du comparateur selon le champs donné
        Dim cust_comparer As New  _
            ComparateurASCEtudiant(champs)

        ' Le tri
        collection.Sort(cust_comparer)

        Return collection
    End Function

    ' Méthode pour le classement descendant d'une collection d'étudiants
    Public Shared Function SortDESCollection(ByVal collection As List(Of Etudiant), ByVal champs As String) As List(Of Etudiant)

        ' Création du comparateur selon le champs donné
        Dim cust_comparer As New  _
            ComparateurDESEtudiant(champs)

        ' Le tri
        collection.Sort(cust_comparer)

        Return collection
    End Function


    'Classe interne qui aide avec la comparaison avec plusieurs champs 
    'Pour le tri ascendant

    Private Class ComparateurASCEtudiant
        Implements IComparer(Of Etudiant)

        ' L'attribut décide le champs avec lequel les étudiants seront comparés.
        Public ChampsComparaison As String = BDD.champsMATRIN


        Public Sub New(ByVal compare_type As String)
            ChampsComparaison = compare_type
        End Sub

        ' Méthode qui compare deux étudiants selon l'attribut ChampsComparaison de la classe.
        Public Function Compare(ByVal x As Etudiant, ByVal y As  _
            Etudiant) As Integer Implements _
            System.Collections.Generic.IComparer(Of Etudiant).Compare

            'On fait le cast des deux objets en entrée
            Dim x_cust As Etudiant = DirectCast(x,  _
                Etudiant)
            Dim y_cust As Etudiant = DirectCast(y,  _
                Etudiant)

            Return x_cust.GetInfoChamps(ChampsComparaison).CompareTo(y_cust.GetInfoChamps(ChampsComparaison))

        End Function
    End Class

    'Classe interne qui aide avec la comparaison avec plusieurs champs
    'Pour le tri descendant

    Private Class ComparateurDESEtudiant
        Implements IComparer(Of Etudiant)

        ' L'attribut décide le champs avec lequel les étudiants seront comparés.
        Public ChampsComparaison As String = BDD.champsMATRIN


        Public Sub New(ByVal compare_type As String)
            ChampsComparaison = compare_type
        End Sub

        ' Méthode qui compare deux étudiants selon l'attribut ChampsComparaison de la classe.
        Public Function Compare(ByVal x As Etudiant, ByVal y As  _
            Etudiant) As Integer Implements _
            System.Collections.Generic.IComparer(Of Etudiant).Compare

            'On fait le cast des deux objets en entrée
            Dim x_cust As Etudiant = DirectCast(x,  _
                Etudiant)
            Dim y_cust As Etudiant = DirectCast(y,  _
                Etudiant)

            Return -(x_cust.GetInfoChamps(ChampsComparaison).CompareTo(y_cust.GetInfoChamps(ChampsComparaison)))

        End Function
    End Class


End Class

