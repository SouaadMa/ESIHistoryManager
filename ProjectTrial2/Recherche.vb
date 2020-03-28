Public Class Recherche  'La classe qui contient les méthodes du traitement

    Private Sub New()
    End Sub

    Public Shared Function traitRechercher(ByVal criteres As List(Of Critere)) As List(Of Etudiant)
        'La méthode qui retourne la collection des étudiants filtrés selon la collection des critères en entrée

        Dim instructionSQL As String = ""
        'L'instruction SQL à générer
        Dim resultatRech As DataTable = New DataTable
        'DataTable qui va contenir le résultat retourné par la BDD
        Dim listeEtudiants As List(Of Etudiant) = New List(Of Etudiant)
        'La collection des étudiants à retourner à la fin de la méthode

        'Pour chaque critère on fait appel à génèreRequete
        For Each crit As Critere In criteres
        instructionSQL=Rech_BDD.genereRechRequetes(instructionSQL, crit)
        Next

        'On passe la requête finale à ExécuteRequ et on sauvegarde son résultat

        resultatRech = BDD.executeRequete(instructionSQL)


        'Pour chaque ligne du DataTable on crée un objet étudiant
        'Et on ajoute l'objet créé à la collection des étudiants à retourner
        For Each ligne As DataRow In resultatRech.Rows
            listeEtudiants.Add(New Etudiant(ligne("Matricule")))
        Next

        Return listeEtudiants

    End Function

End Class

