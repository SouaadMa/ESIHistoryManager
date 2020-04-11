Public Class Modif_BDD

    Private Sub New()
    End Sub

    Public Shared Function genereModifRequete(ByVal matrin As String, ByVal criteres As List(Of Critere)) As String
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

        requete = " UPDATE ETUDIANT SET " ' Initialiser la requete sql
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
                    tab = BDD.stringETUDIANT                                            ' Chercher dans le tableau des champs Text
                    'valeur = "'" + crit.getValeur + "'"
                Case GetType(Integer).ToString, GetType(Double).ToString  ' valeur Numérique
                    'Console.WriteLine("num")
                    tab = BDD.numETUDIANT                                               ' Chercher dans le tableau des champs Numerique                    
                    'valeur = crit.getValeur.ToString
                Case "System.Boolean"                                     ' valeur Booleen
                    'Console.WriteLine("bool")
                    tab = BDD.boolETUDIANT                                            ' Chercher dans le tableau des champs Booleen
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
        MsgBox(" - " + requete)
        Return requete                                              ' Retourner l'instruction sql de modification

    End Function

End Class
