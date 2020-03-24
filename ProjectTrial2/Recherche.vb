Public Class Recherche

    Private Sub New()
    End Sub

    Public Shared Function traitRechercher(ByVal criteres As List(Of Critere)) As List(Of Etudiant)
        Dim instructionSQL As String = ""
        Dim resultatRech As DataTable = New DataTable
        Dim listeEtudiants As List(Of Etudiant) = New List(Of Etudiant)

        For Each crit As Critere In criteres
            Rech_BDD.genereRechRequetes(instructionSQL, crit)
        Next

        resultatRech = BDD.executeRecherche(instructionSQL)

        For Each ligne As DataRow In resultatRech.Rows
            listeEtudiants.Add(New Etudiant(ligne("matricule")))
        Next

        Return listeEtudiants

    End Function

End Class

