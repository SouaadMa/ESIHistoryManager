Public Class SortieRN

    Private dataSet As New DataSet

    Public Sub New(ByVal etud As Etudiant, ByVal annee As String)

        If (etud.RNpossible(annee)) Then

            'Récupération des informations stockées dans la collection dans l'objet Etudiant

            'Création de la collection des champs pour générer la requête
            Dim listeChamps As New List(Of String)
            listeChamps.Add(BDD.champsLIBEMA)
            listeChamps.Add(BDD.champsNOJUNO)
            listeChamps.Add(BDD.champsNORANO)

            Dim listeConditions As New List(Of Critere)
            listeConditions.Add(New Critere(BDD.champsMATRIN, etud.GetInfoChamps(BDD.champsMATRIN)))
            listeConditions.Add(New Critere(BDD.champsCodePromo, annee))

            '************Récupération des notes*************
            Dim req As String = Class_BDD.genereRechRequete(listeChamps, BDD.nomTableNOTE, BDD.nomTableMATIERE, listeConditions)
            Dim tableNotesMat As New DataTable
            tableNotesMat = BDD.executeRequete(req)

            'Ajout des deux tables dans une DataSet

        End If






    End Sub

    Public Function GetDataSet() As DataSet
        Return dataSet
    End Function




End Class
