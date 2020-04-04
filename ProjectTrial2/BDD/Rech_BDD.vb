
Public Class Rech_BDD

    Public Shared Function genereRechRequetes(ByRef instructionSQL As String, ByVal critere As Critere) As String

        'Générer un requete de recherche SQL apartir d'une requete existe déja 'instructionSQL' ou non ( si instructionSQL est vide )
        ' en ajoutant le champ et son valeur apartir de critere
        Dim found As Boolean = False
        Dim i As Integer = 0
        Dim ind As Integer = 0
        Dim tab()() As String = {}
        Dim valeur As String = ""
        Dim champ As String = critere.getChamps
        Dim Bdd As BDD = New BDD()

        If requeteRechValide(instructionSQL) Then      ' Si la instructionSQL donnee peut etre un requete de recherche
            Select Case (critere.getValeur.GetType).ToString       ' Savoir le type de la valeur :
                Case "System.String"                                      ' valeur Text
                    'Console.WriteLine("string")
                    tab = Bdd.getStringChamp                                           ' Chercher dans le tableau des champs Text
                    valeur = "'" + critere.getValeur + "'"
                Case GetType(Integer).ToString, GetType(Double).ToString  ' valeur Numérique
                    'Console.WriteLine("num")
                    tab = Bdd.getNumChamp                                              ' Chercher dans le tableau des champs Numerique                    
                    valeur = critere.getValeur.ToString
                Case "System.Boolean"                                     ' valeur Booleen
                    'Console.WriteLine("bool")
                    tab = Bdd.getBoolChamp                                             ' Chercher dans le tableau des champs Booleen
                    valeur = critere.getValeur
                    'Case Else     tab = {}
            End Select
            Console.WriteLine("critere = " + critere.getChamps())
            Try
                'Console.WriteLine(tab.Length)
                While Not found And ind < tab.Length                ' Chercher si le champ donnée existe dans les tableaux de la base de donnée  
                    'Console.WriteLine("ind = " + ind.ToString)
                    i = 0
                    While Not found And i < tab(ind).Length         ' Parcourir les tableaux jusqu'a trouver le champ ou atteindre la fin de tableau
                        'Console.WriteLine("i = " + i.ToString + "champs :" + tab(ind)(i).ToString)
                        If critere.getChamps.Equals(tab(ind)(i)) Then
                            found = True
                            'Console.WriteLine("found !")
                        Else
                            i += 1
                        End If
                    End While
                    ind += 1
                End While
            Catch e As NullReferenceException
                Console.WriteLine("NullReferenceException") 'à changer par la suite 
            Finally

            End Try
            If found Then                                       ' Si le champ donnée existe dans la base de donnée
                If stringvide(instructionSQL) Then                     ' Si la requete donnée vide ou contient seulement des espaces
                    instructionSQL = " SELECT * FROM INSCRIPTION WHERE "  ' -> affecter la valeur d'une requete de rechercher retourne tout les champs de tableau ETUDIANT
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

End Class


