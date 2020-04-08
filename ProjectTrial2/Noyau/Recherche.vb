Public Class Recherche  'La classe qui contient les méthodes du traitement

    
    Public Shared Function traitRechercher(ByVal criteres As List(Of Critere), ByVal bw As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs) As List(Of Etudiant)
        'La méthode qui retourne la collection des étudiants filtrés selon la collection des critères en entrée
        '        e.Cancel = True
        Dim instructionSQL As String = ""
        'L'instruction SQL à générer
        Dim resultatRech As DataTable = New DataTable
        'DataTable qui va contenir le résultat retourné par la BDD
        Dim listeEtudiants As List(Of Etudiant) = New List(Of Etudiant)
        'La collection des étudiants à retourner à la fin de la méthode
        'Console.WriteLine("trait")
        'Pour chaque critère on fait appel à génèreRequete
        If Not bw.CancellationPending Then

            For Each crit As Critere In criteres
                instructionSQL = Rech_BDD.genereRechRequetes(instructionSQL, crit)
            Next
            'Console.WriteLine("traited")
            'On passe la requête finale à ExécuteRequ et on sauvegarde son résultat
            If Not bw.CancellationPending Then
                resultatRech = BDD.executeRequete(instructionSQL)
            Else
                e.Cancel = True
            End If
            'Console.WriteLine(" execute requete success")
            'Form1.DataGridView1.DataSource = resultatRech
            'Form1.Show()

            'Pour chaque ligne du DataTable on crée un objet étudiant
            'Et on ajoute l'objet créé à la collection des étudiants à retourner
            Dim x As Integer = 0
            Dim _loop As Integer = resultatRech.Rows.Count
            For Each ligne As DataRow In resultatRech.Rows
                If Not bw.CancellationPending Then
                    listeEtudiants.Add(New Etudiant(ligne))
                    bw.ReportProgress(CInt((x / _loop) * 100))
                    x += 1
                Else
                    e.Cancel = True
                    Throw New NullReferenceException()
                    'Exit Function
                End If
            Next
        Else
            e.Cancel = True
        End If
        Return listeEtudiants

    End Function

    'Fonction qui retourne une liste de toutes les valeurs (chaine) possible de "champs" dans INSCRIPTION

    Public Shared Function GetALL(ByVal champs As String) As List(Of String)

        Dim dt As DataTable = BDD.GetALL(champs, BDD.nomTableINSCRIPTION)

        Dim liste As New List(Of String)

        For Each ligne As DataRow In dt.Rows

            liste.Add(CType(ligne(champs), String))

        Next

        Return liste

    End Function


End Class

