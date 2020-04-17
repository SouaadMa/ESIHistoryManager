Public Class Recherche  'La classe qui contient les méthodes du traitement


    Public Shared Function traitRechercher(ByVal criteres As List(Of Critere), ByVal bw As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs) As DataTable 'List(Of Etudiant)
        'La méthode qui retourne la collection des étudiants filtrés selon la collection des critères en entrée
        Dim instructionSQL As String = ""
        'L'instruction SQL à générer
        Dim resultatRech As DataTable = New DataTable
        'DataTable qui va contenir le résultat retourné par la BDD
        'La collection des étudiants à retourner à la fin de la méthode

        'Console.WriteLine("c")
        'Pour chaque critère on fait appel à génèreRequete
        If Not bw.CancellationPending Then

            For Each crit As Critere In criteres
                instructionSQL = Rech_BDD.genereRechRequetes(instructionSQL, crit)
                'bw.ReportProgress(CInt(x))
            Next
            Console.WriteLine(instructionSQL)
            'On passe la requête finale à ExécuteRequ et on sauvegarde son résultat
            If Not bw.CancellationPending Then
                resultatRech = BDD.executeRequete(instructionSQL)
                'x = 99
                'bw.ReportProgress(CInt(x))
            Else
                e.Cancel = True
            End If
            'Console.WriteLine(" execute requete success")

            'Pour chaque ligne du DataTable on crée un objet étudiant
            'Et on ajoute l'objet créé à la collection des étudiants à retourner

            '
            'Dim _loop As Integer = resultatRech.Rows.Count
            'For Each ligne As DataRow In resultatRech.Rows
            '    If Not bw.CancellationPending Then
            '        listeEtudiants.Add(New Etudiant(ligne))
            '        bw.ReportProgress(CInt((x / _loop) * 100))
            '        x += 1
            '    Else
            '        e.Cancel = True
            '        Throw New NullReferenceException()
            '        'Exit Function
            '    End If
            'Next

        Else
            e.Cancel = True
        End If
        Return resultatRech

    End Function

    'Fonction qui retourne une liste de toutes les valeurs (chaine) possible de "champs" dans Etudiant

    Public Shared Function GetALL(ByVal champs As String) As List(Of String)

        Dim dt As DataTable = BDD.GetALL(champs, BDD.nomTableEtudiant)

        Dim liste As New List(Of String)

        'MsgBox("GetALLRech")

        For Each ligne As DataRow In dt.Rows

            Try
                liste.Add(CType(ligne(champs), String))
                Console.WriteLine(CType(ligne(champs), String))
            Catch ex As Exception
                'MsgBox(ex.Message)
                liste.Add(" ")
            End Try


        Next

        Return liste

    End Function


End Class
