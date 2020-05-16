Public Class Etudiant

    Implements IComparable(Of Etudiant)  'La classe implémente Comparable

    Public InfosETUDIANT As DataRow
    

    Public Function getId() As String 'Getter pour l'Id
        Return Me.GetInfoChamps(BDD.champsMATRIN)
    End Function


    Public Sub New(ByVal ligne As DataRow)

        InfosETUDIANT = ligne

    End Sub


    'Méthode qui charge les informations de la table INSCRIPTION de l'étudiant selon le critère donné (l'année)
    'We don't need to use it as long as we have ChargementInfos, the method above
    'But don't delete it

    Public Function ChargementInfosINSCRIPTION(ByVal critere As Critere) As DataRow

        Dim ligne As DataRow = BDD.GetFromTable(BDD.nomTableINSCRIPTION, Me.GetInfoChamps(BDD.champsMATRIN), critere)

        Return ligne


    End Function

    'Méthode qui charge les informations de l'étudiant selon le critère donné 
    Public Function ChargementInfos(ByVal critere As Critere) As DataRow

        Dim ligne As DataRow


        'Les tables qui ont relation avec un seul étudiant
        If (critere.getTable.Equals(BDD.nomTableINSCRIPTION) Or critere.getTable.Equals(BDD.nomTableNOTE) Or critere.getTable.Equals(BDD.nomTableNoteRATRAP)) Then

            ligne = BDD.GetFromTable(critere.getTable, Me.GetInfoChamps(BDD.champsMATRIN), critere)
            Return ligne

        Else

            'MATIERE, RATRAP, GROUP, Section, PROMO 
            'Sont des tables indépendantes de l'étudiant

            ligne = BDD.GetFromTable(critere.getTable, critere)
            Return ligne

        End If


    End Function



    Public Function CompareTo(ByVal other As Etudiant) As Integer _
        Implements IComparable(Of Etudiant).CompareTo 'La méthode de la classe Comparable

        Return (Me.GetInfoChamps(BDD.champsMATRIN).CompareTo(other.GetInfoChamps(BDD.champsMATRIN))) 'Elle compare entre les matricules des deux étudiants

    End Function


    Public Function GetInfoChamps(ByVal champs As String) As String
        Try
            Return CType(InfosETUDIANT(champs), String)
        Catch ex As InvalidCastException
            Return "champs vide"
        End Try

    End Function

    ' Méthode qui retourne toutes les valeurs possibles d'un champs dans la base de données,
    ' et qui correspondent à l'étudiant

    Public Function GetALL(ByVal champs As String) As DataTable

        'Génération du critère MATRIN
        Dim condition As New Critere(BDD.champsMATRIN, Me.GetInfoChamps(BDD.champsMATRIN))

        'Récuperation du résultat de la requête dans la BDD
        Dim dt As New DataTable


        dt = BDD.GetALL(champs, BDD.GetTable(champs), condition)


        Return dt


    End Function



    ' Méthodes particulières pour les sorties d'un étudiant

    Public Function GetNotesMat(ByVal listeChamps As List(Of String), ByVal listeConditions As List(Of Critere)) As DataTable

        Dim req As String = Class_BDD.genereRechRequete(listeChamps, BDD.nomTableNOTE, BDD.nomTableMATIERE, listeConditions, True)

        Return BDD.executeRequete(req)

    End Function


    'Méthode qui vérifie la possibilité d'imprimer un RNG pour un étudiant.
    'Elle retourne vrai si c'est possible, faux sinon
    'nombreAnnees est le nombre des années qu'il a étudié (nombre de lignes de cet étudiant dans INSCRIPTION
    Public Function RNGPossible(ByRef Annees_Decisions As List(Of Critere), ByRef nombreAnnees As Integer) As Boolean

        Dim dt As DataTable
        Dim sql As String = ""
        Dim bool As Boolean = False


        sql = Rech_BDD.genereRechRequetes(sql, New Critere(BDD.champsMATRIN, GetInfoChamps(BDD.champsMATRIN)), BDD.nomTableINSCRIPTION)
        dt = BDD.executeRequete(sql)
        dt = Classement.SortASCCollection(dt, BDD.champsCodePromo)
        nombreAnnees = dt.Rows.Count
        For Each ligne As DataRow In dt.Rows

            If ligne(BDD.champsCodePromo).Substring(0, 1) = "5" Then
                bool = True
                Exit For
            End If

        Next
        If bool Then
            For Each ligne As DataRow In dt.Rows
                Annees_Decisions.Add(New Critere(ligne(BDD.champsCodePromo), ligne(BDD.champsADM)))
            Next
        End If

        Return bool


    End Function


End Class
