
Public Class Rech_BDD

    Public Shared Function genereRechRequetes(ByRef instructionSQL As String, ByVal critere As Critere, ByVal nomTable As String) As String

        'Générer un requete de recherche SQL apartir d'une requete existe déja 'instructionSQL' ou non ( si instructionSQL est vide )
        ' en ajoutant le champ et son valeur apartir de critere


        Dim valeur As String = ""

        If (IsNothing(critere)) Then

            If instructionSQL = "" Then
                Return " SELECT * FROM " & nomTable
            Else
                If requeteRechValide(instructionSQL) Then
                    Return instructionSQL
                End If
            End If

        End If


        Dim champ As String = critere.getChamps

        If requeteRechValide(instructionSQL) Then      ' Si la instructionSQL donnee peut etre une requete de recherche



            Select Case (critere.getValeur.GetType).ToString       ' Savoir le type de la valeur :
                Case "System.String"                                      ' valeur Text
                    valeur = "'" + critere.getValeur + "'"
                Case GetType(Integer).ToString, GetType(Double).ToString  ' valeur Numérique
                    valeur = critere.getValeur.ToString
                Case "System.Boolean"                                     ' valeur Booleen
                    valeur = critere.getValeur
            End Select


            If BDD.ExisteDansTable(critere.getChamps, nomTable) Then                                       ' Si le champ donnée existe dans la base de donnée
                If stringvide(instructionSQL) Then                     ' Si la requete donnée vide ou contient seulement des espaces
                    instructionSQL = " SELECT * FROM " & nomTable & " WHERE "  ' -> affecter la valeur d'une requete de rechercher retourne tout les champs de tableau ETUDIANT
                ElseIf instructionSQL.Contains("WHERE") Then           ' Sinon, Si la instructionSQL contient WHERE
                    If Not LastWord(instructionSQL, "WHERE") Then      '-> Si WHERE n'est pas la derniere mot de instructionSQL
                        instructionSQL = instructionSQL + " AND "                    '-> ajouter un vergule "," au instructionSQL 
                    End If
                Else                                            ' Sinon ( Si la instructionSQL n'est pas vide et ne contient pas WHERE
                    instructionSQL = instructionSQL + " WHERE "               '-> ajouter WHERE au instructionSQL
                End If
                instructionSQL = instructionSQL + champ + " = " + valeur      ' Ajouter le champ et son valeur donnée ( Le critere ) a la fin de instructionSQL 
            End If
        End If

        Return instructionSQL                              ' retourner la requete -> écrit si la instructionSQL donnée est valide est le champ donnée existe dans un des tableaaux de base de données aproprié
        '                                                                  -> la meme donnée s'il n'est pas valide ou si le champ donnée n'existe pas 
    End Function

    Private Shared Function LastWord(ByVal sentence As String, ByVal word As String) As Boolean
        'Vérifier si word est le dernier 'mot' dans la chaine 'sentence'
        Dim last As Boolean = False
        Dim ind As Integer = 0
        Dim len As Integer = sentence.IndexOf(word) + word.Length
        If sentence.Contains(word) Then
            last = True
            While (len + ind < sentence.Length And last)
                If sentence.Substring(len + ind, 1) = " " Then
                    ind += 1
                Else
                    last = False
                End If
            End While
        End If
        Return last
    End Function

    Private Shared Function stringvide(ByVal chaine As String) As Boolean
        ' Verifier si 'chaine' est vide ou contient seulement des espaces
        Dim vide As Boolean = True
        For Each element As Char In chaine
            If element <> " " Then
                vide = False
                Exit For
            End If
        Next
        Return vide
    End Function


    Private Shared Function requeteRechValide(ByRef requete As String) As Boolean
        ' Vérifier si 'requete' est un requete SQL de recherche valide
        Dim valide As Boolean = True
        Dim i As Integer = 0
        Dim c As String = ""
        If Not stringvide(requete) Then 'Si la chaine n'est pas vide

            While requete.Substring(i, 1) = " " 'Tant que il y a des espaces
                i += 1
            End While

            c = requete.Substring(i, 6).ToUpper() 'On vérifie le premier mot

            If c.Equals("SELECT") Then
                valide = (requete.Contains("FROM") Or requete.Contains("from"))
            Else
                valide = False
            End If
        End If
        Return valide
    End Function

    Public Shared Function AddChamps(ByVal req As String, ByVal champs As List(Of String), ByVal tab As String) As String

        Dim first As Boolean = True
        Dim StrChamps As String = ""
        Dim nomTable As String

        If tab = "" Then
            nomTable = ""
        Else
            nomTable = tab + "."
        End If


        For Each ch As String In champs

            If first Then
                first = False
            Else
                StrChamps = StrChamps + ", "
            End If

            StrChamps = StrChamps + nomTable + ch

        Next

        If requeteRechValide(req) And Not String.IsNullOrWhiteSpace(req) Then

            If req.Contains("*") Then

                'Console.WriteLine(req)

                req = req.Replace("*", StrChamps)

            Else

                'Console.WriteLine("u" + req + "u")

                req = req.Insert(req.IndexOf("SELECT") + "SELECT".Length, " " + StrChamps + ", ")

            End If


        End If

        Return req


    End Function

    Public Shared Function AddWHEREComparaison(ByVal req As String, ByVal critere As Critere, ByVal valComparaison As Integer, ByVal CONJUNCTION As Boolean) As String

        Dim comp As String

        If (valComparaison = 0) Then
            comp = " = "
        Else
            If valComparaison > 0 Then
                comp = " > "
            Else
                comp = " < "
            End If
        End If

        If (req.Contains("WHERE")) Then

            If CONJUNCTION Then
                Return req + " AND " + critere.getChamps + comp + critere.getValeur.ToString
            Else
                Return req + " OR " + critere.getChamps + comp + critere.getValeur.ToString
            End If


        Else
            Return req + " WHERE " + critere.getChamps + comp + critere.getValeur.ToString
        End If


    End Function





End Class


