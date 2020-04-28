Public Class Modif_BDD

    Private Sub New()
    End Sub

    Public Shared Function genereModifRequete(ByVal matrin As String, ByVal criteres As List(Of Critere), ByVal table As String) As String
        'Générer un requete sql qui modifier les champs contenu dans critères avec leur novelles valeurs quand le matricule
        ' de l'étudiant = matrin

        Dim requete As String   ' La requete a retourner
        'Dim length As Integer   ' La longueure de liste des critères
        Dim champ As String     ' Le champ à modifier
        Dim valeur As String    ' La nouvelle valeur de champ à modifier
        'Dim i As Integer
        Dim tab As String()     ' Le tableau qui contint tous les champs de la base approprié avec le type de valeur de champ
        Dim ind As Integer      ' l'indice pour parcourir tab
        Dim found As Boolean    ' Booleén pour vérifier que le champ donnée existe dans la base ( dans tab )
        Dim first As Boolean    ' Booleén pour vérifier s'il y a au moins une critere ( champ = valeur ) ajouté à l'instruction sql

        requete = " UPDATE " + table + " SET " ' Initialiser la requete sql
        'length = criteres.Count - 2       ' Mettre dans length l'indice de dernière élément de la liste
        'i = 0
        first = True                    ' Initialiser first a true ( l'élément qu'on va ajouter va etre le premier )

        For Each crit As Critere In criteres    'Parcourir la liste des criteres et pour chaque critere :
            'For i = 0 To criteres.Count - 2   

            champ = crit.getChamps
            valeur = ""
            ind = 0
            found = False
            tab = {}

            Select Case (crit.getValeur.GetType).ToString       ' Savoir le type de la valeur :
                Case "System.String"                                      ' valeur Text
                    'Console.WriteLine("string")
                    tab = BDD.getStringTable(table)                                           ' Chercher dans le tableau des champs Text
                    'valeur = "'" + crit.getValeur + "'"
                Case GetType(Integer).ToString, GetType(Double).ToString  ' valeur Numérique
                    'Console.WriteLine("num")
                    tab = BDD.getNumTable(table)                                               ' Chercher dans le tableau des champs Numerique                    
                    'valeur = crit.getValeur.ToString
                Case "System.Boolean"                                     ' valeur Booleen
                    'Console.WriteLine("bool")
                    tab = BDD.getBoolTable(table)                                           ' Chercher dans le tableau des champs Booleen
                    'valeur = crit.getValeur
                    'Case Else     tab = {}
            End Select
            valeur = "'" + crit.getValeur.ToString.Replace("'", "`") + "'"

            Try
                While Not found And ind < tab.Length                ' Chercher si le champ donnée existe dans les tableaux de la base de donnée  
                    If champ.Equals(tab(ind)) Then
                        found = True
                    Else
                        ind += 1
                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If found Then               ' Si le champ donnée exite
                If (Not first) Then     ' -> Si cette critère n'est pas le premier à ajouté
                    requete = requete + " , "       '--> ajouter un vergule
                Else                    '-> Sinon ( on a pas encore ajouté aucun condition )
                    first = False                   '--> mettre first à faux ( la premier critere est ajoutée )
                End If
                requete = requete + champ + " = " + valeur  ' Ajouter le critère ' champ = valeur'
            End If
        Next

        requete = requete + " WHERE MATRIN = '" + matrin + "' " '    ' Completer l'instruction sql de modification en ajoutant le condition ( la valeur de matricule de l'étudiant qui va etre changée
        Return requete                                              ' Retourner l'instruction sql de modification

    End Function

    Public Shared Function AddCondition(ByVal SQLQuery As String, ByVal critere As Critere) As String

        Dim TAB As String()
        Dim found As Boolean = False
        Dim champ As String = critere.getChamps

        Dim ind As Integer = 0
        found = False
        TAB = {}

        Select Case (critere.getValeur.GetType).ToString
            Case "System.String"

                TAB = BDD.getStringTable(critere.getTable)
            Case GetType(Integer).ToString, GetType(Double).ToString

                TAB = BDD.getNumTable(critere.getTable)

            Case "System.Boolean"
                TAB = BDD.getBoolTable(critere.getTable)

        End Select

        Dim valeur As String = "'" + critere.getValeur.ToString.Replace("'", "`") + "'"

        Try
            While Not found And ind < TAB.Length                ' Chercher si le champ donnée existe dans les tableaux de la base de donnée  
                If champ.Equals(TAB(ind)) Then
                    found = True
                Else
                    ind += 1
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If found Then               ' Si le champ donnée exite

            SQLQuery = SQLQuery + " AND "       '--> ajouter AND

            
            SQLQuery = SQLQuery + champ + " = " + valeur  ' Ajouter le critère ' champ = valeur'
        End If

        Return SQLQuery


    End Function

    

End Class
