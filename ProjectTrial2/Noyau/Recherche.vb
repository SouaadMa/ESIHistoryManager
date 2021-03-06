﻿Public Class Recherche  'La classe qui contient les méthodes du traitement


    Public Shared Function traitRechercher(ByVal criteres As List(Of Critere), ByVal bw As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs) As DataTable 'List(Of Etudiant)
        'La méthode qui retourne la collection des étudiants filtrés selon la collection des critères en entrée
        Dim instructionSQL As String = ""
        'L'instruction SQL à générer
        Dim resultatRech As DataTable = New DataTable
        'DataTable qui va contenir le résultat retourné par la BDD
        'La collection des étudiants à retourner à la fin de la méthode
        'Dim x As Integer = 5
        'Pour chaque critère on fait appel à génèreRequete
        If Not bw.CancellationPending Then

            For Each crit As Critere In criteres

                If crit.getChamps.Equals(BDD.champsAnnee) Then
                    If criteres.Count = 1 Then
                        instructionSQL = Rech_BDD.genereRechRequetes(instructionSQL, Nothing, BDD.nomTableEtudiant)
                    End If
                    crit.setTable(BDD.nomTableEtudiant)
                    instructionSQL = Class_BDD.AddLIKECondition(instructionSQL, crit, BDD.nomTableEtudiant)
                Else
                    instructionSQL = Rech_BDD.genereRechRequetes(instructionSQL, crit, BDD.nomTableEtudiant)
                End If
                'x = x + 50 / criteres.Count
                'bw.ReportProgress(CInt(x))
            Next
            'x = 70
            'On passe la requête finale à ExécuteRequ et on sauvegarde son résultat
            If Not bw.CancellationPending Then
                resultatRech = BDD.executeRequete(instructionSQL)
                'x = 99
                'bw.ReportProgress(CInt(x))
            Else
                e.Cancel = True
            End If

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

    Public Shared Function GetALL(ByVal champs As String, ByVal table As String) As DataTable

        Dim dc As DataTable = BDD.GetALL(champs, table, New List(Of Critere))

        Return dc

    End Function

    Public Shared Function GetALLConditioned(ByVal champ As String, ByVal table As String, ByVal conditions As List(Of Critere)) As DataTable

        Dim dc As DataTable = BDD.GetALL(champ, table, conditions)

        Return dc

    End Function


    Public Shared Function CreateEtudiants(ByVal dt As DataTable) As List(Of Etudiant)

        Dim collection As New List(Of Etudiant)

        For Each ligne As DataRow In dt.Rows
            collection.Add(New Etudiant(ligne))
        Next


        Return collection

    End Function



End Class
