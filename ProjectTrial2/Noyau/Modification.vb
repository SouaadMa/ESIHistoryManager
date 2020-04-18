Public Class Modification

    Private Sub New()
    End Sub

    Public Shared Sub traitModifier(ByVal criteres As List(Of Critere), ByVal etud As Etudiant)
        'MsgBox("< " + etud.getId + " >")
        'sauvegarder les modifications faites par l'utilisateur 
        'MsgBox(" > TRAIT MODIFIER ")
        Dim instEtudiant As String = ""             'instruction SQL pour accéder à la table Etudiant et mettre à jour les champs modifiés  

        'générer la requête SQL 
        instEtudiant = Modif_BDD.genereModifRequete(etud.getId, criteres)

        'MsgBox(" TRAIT MODIFIER < ")
        'executer la requête

        BDD.executeRequete(instEtudiant)

        ' Faire les changement appliquée sur les informations sauvegarder dans l'objet ETUDIANT


        For Each crit In criteres
            etud.InfosETUDIANT.Item(crit.getChamps) = crit.getValeur
            'etud.getCollection("Etudiant").Item(crit.getChamps) = crit.getValeur()
        Next


    End Sub

End Class

