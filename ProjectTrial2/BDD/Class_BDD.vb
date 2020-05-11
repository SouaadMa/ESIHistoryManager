Public Class Class_BDD


   Public Shared Function genereRechRequete(ByVal champs As List(Of String), ByVal tab1 As String, ByVal tab2 As String, ByVal conditions As List(Of Critere), ByVal bool As Boolean)
        
        Dim requete As String ' La requete a retourner
        Dim first As Boolean ' Booleén pour vérifier s'il y a au moins une Champ / Critere ( condition) ajouté à l'instruction sql
        Dim found As Boolean ' Booleén pour vérifier que le champ donnée existe dans la base ( dans les tables )
        Dim finalChamp As String ' Le champ a chercher ou a verifier en ajoutantle nom de tableau qui le contient
        Dim champ As String ' Le champ a chercher ou a verifier
        Dim valeur As String ' La valeur de champ à vérifier
        Dim ind As String ' l'indice pour parcourir les tables
        Dim cle1 As String ' Le champ qui est égale entre tab1 et tab2 pour tab1
        Dim cle2 As String ' Le champ qui est égale entre tab1 et tab2 pour tab2
        Dim t1 As String()
        Dim t2 As String()
        requete = "" ' Initialiser la requete sql
        cle1 = BDD.getCorrespondance(tab1, tab2, 1) ' Trouver le nom de champ qui est égale entre tab1 et tab2 pour tab1
        If (cle1 = "") Then
            cle1 = BDD.getCorrespondance(tab2, tab1, 1)
        End If
        cle2 = BDD.getCorrespondance(tab1, tab2, 2) ' Trouver le nom de champ qui est égale entre tab1 et tab2 pour tab2
        If (cle2 = "") Then
            cle2 = BDD.getCorrespondance(tab2, tab1, 2)
        End If
        If Not (cle1 = "") And Not (cle2 = "") Then ' And Not (champs.Count > 0) Then ' Si les tables tab1 et tab2 ont un champ égale dans la tables correspondante ( et La liste des champs 0 retourner n'est pas vide )
            finalChamp = ""
            requete = " SELECT " ' Initialiser la requete sql de(Recherche)
            first = True
            For Each champ In champs ' Pour chaque champ dans la liste des champs à retourner
                ind = 0
                found = False
                Try
                    found = lookInTab(tab1, champ, found)
                    If (found) Then
                        finalChamp = tab1 + "." + champ
                    Else
                        finalChamp = tab2 + "." + champ
                    End If
                    ind = 0
                    found = lookInTab(tab2, champ, found)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                If found Then ' Si le champ donnée exite
                    If first Then ' -> Si cette champ est le premier à ajouté()
                        first = False '--> mettre first à faux ( la premier critere est ajoutée )
                    Else '-> Sinon ( on a pas déjà ajouté aucun condition )
                        requete = requete + " , " '--> ajouter un vergule
                    End If
                    requete = requete + finalChamp ' Ajouter le champ

                End If
            Next
            requete = requete + " FROM " + tab1 + " INNER JOIN " + tab2 ' Ajouner les noms des tables de jointeur à l'instruction sql
            requete = requete + " ON " + tab1 + "." + cle1 + " = " + tab2 + "." + cle2
            ' Ajouner les noms des champs correspondantes des tables de jointeur à l'instruction sql
            If (conditions.Count > 0) Then 'Si La liste des conditions(n) 'est pas vide
                first = True
                requete = requete + " WHERE ( "
                For Each cond As Critere In conditions ' Pour chaque critere dans la liste des critères
                    champ = cond.getChamps
                    finalChamp = ""
                    valeur = ""
                    'valeur = "'" + cond.getValeur.ToString + "'"
                    ind = 0
                    found = False

                    Try
                        t1 = {}
                        t2 = {}
                        Select Case (cond.getValeur.GetType).ToString ' Savoir le type de la valeur :
                            Case "System.String" '
                                'valeur(Text)
                                'Console.WriteLine("string")
                                t1 = BDD.getStringTable(tab1)
                                ' Chercher dans le tableau des champs Text
                                t2 = BDD.getStringTable(tab2)
                                valeur = "'" + cond.getValeur + "'"
                            Case GetType(Integer).ToString, GetType(Double).ToString '
                                'valeur(Numérique)
                                'Console.WriteLine("num")
                                t1 = BDD.getNumTable(tab1)
                                ' Chercher dans le tableau des champs Numerique
                                t2 = BDD.getNumTable(tab2)
                                valeur = cond.getValeur.ToString
                            Case "System.Boolean" '
                                'valeur(Booleen)
                                'Console.WriteLine("bool")
                                t1 = BDD.getBoolTable(tab1)
                                ' Chercher dans le tableau des champs Booleen
                                t2 = BDD.getBoolTable(tab2)
                                valeur = cond.getValeur
                                'Case Else tab = {}
                        End Select
                        While Not found And ind < t1.Length ' Chercher si le champ donnée existe dans le tableau tab1 de la base de donnée
                            If champ.Equals(t1(ind)) Then
                                found = True
                            Else
                                ind += 1
                            End If
                        End While


                        If (found) Then
                            finalChamp = tab1 + "." + champ
                        Else
                            finalChamp = tab2 + "." + champ
                        End If
                        ind = 0
                        While Not found And ind < t2.Length ' Chercher si le champ donnée existe dans le tableau tab2 de la base de donnée
                            If champ.Equals(t2(ind)) Then
                                found = True
                            Else
                                ind += 1
                            End If
                        End While
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try


                    If found Then                       ' Si le champ donnée exite
                        If (Not first) Then                  ' -> Si cette critère n'est pas le premier à ajouté
                            If (bool = True) Then
                                requete = requete + " AND "               '--> ajouter un vergule
                            Else
                                requete = requete + " OR "               '--> ajouter un vergule
                            End If

                        Else                                 '-> Sinon ( on a pas encore ajouté aucun condition )
                            first = False                           '--> mettre first à faux ( la premier critere est ajoutée )
                        End If

                        requete = requete + finalChamp + " = " + valeur ' Ajouter le critère() ' champ = valeur'

                    End If
                Next
            End If
        End If



        If (conditions.Count > 0) Then
            Return requete + " )"
        Else
            Return requete
        End If



    End Function

    Public Shared Function lookInTab(ByVal tab As String, ByVal champ As String, ByVal found As Boolean) As Boolean
        ' Si found = false, found = le champ 'champ' existe dans la table 'tab' sinon found ne change pas



        Try
            Dim ind = 0

            While Not found And ind < (BDD.getStringTable(tab)).Length
                ' Chercher si le champ donnée existe dans le tableau tab comme champ des string de la base de donnée
                If champ.Equals((BDD.getStringTable(tab))(ind)) Then
                    found = True
                Else
                    ind += 1
                End If
            End While
            ind = 0
            While Not found And ind < (BDD.getNumTable(tab)).Length
                ' Chercher si le champ donnée existe dans le tableau tab comme champ numérique de la base de donnée
                If champ.Equals((BDD.getNumTable(tab))(ind)) Then
                    found = True
                Else
                    ind += 1
                End If
            End While
            ind = 0
            While Not found And ind < (BDD.getBoolTable(tab)).Length
                ' Chercher si le champ donnée existe dans le tableau tab comme champ boolean de la base de donnée
                If champ.Equals((BDD.getBoolTable(tab))(ind)) Then
                    found = True
                Else
                    ind += 1
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return found
    End Function

    Public Shared Function AjouterOrdre_Requete(ByVal requete As String, ByVal Champ As String) As String

        requete = requete & " order  by " & Champ & " "
        Return requete
    End Function
    Public Shared Function AjouterLimit_Requete(ByVal requete As String, ByVal LIMIT As Integer) As String

        requete = requete & "LIMIT " & LIMIT & "  "
        Return requete
    End Function

    'Compare le critere donné au champ en entrée
    Public Shared Function AddLIKECondition(ByVal SQLquery As String, ByVal champs As String, ByVal condition As Critere) As String

        Dim addition As String

        If BDD.CompareToCode(champs, condition) <> "" Then
            If (SQLquery.Contains("WHERE")) Then
                addition = " AND " + BDD.CompareToCode(champs, condition)
            Else
                addition = " WHERE " + BDD.CompareToCode(champs, condition)
            End If
        Else
            addition = ""
        End If

        Return (SQLquery + addition)

    End Function

    'Compare le critère donné au code de la table en entrée
    Public Shared Function AddLIKECondition(ByVal SQLquery As String, ByVal condition As Critere, ByVal nomtable As String) As String

        Dim addition As String
        Dim saTable As String

        If BDD.CompareToCodeTable(condition.getTable, condition) <> "" Then
            If (SQLquery.Contains("WHERE")) Then
                saTable = condition.getTable
                condition.setTable(nomtable)
                addition = " AND " + BDD.CompareToCodeTable(saTable, condition)
                condition.setTable(saTable)
            Else
                saTable = condition.getTable
                condition.setTable(nomtable)
                addition = " WHERE " + BDD.CompareToCodeTable(saTable, condition)
                condition.setTable(saTable)
            End If
        Else
            addition = ""
        End If

        Return (SQLquery + addition)

    End Function

    Public Shared Function AddONCondition(ByVal SQLQuery As String, ByVal tab1 As String, ByVal tab2 As String, ByVal champ1 As String, ByVal champ2 As String) As String

        If (SQLQuery.Contains("WHERE")) Then

            SQLQuery = SQLQuery.Insert(SQLQuery.IndexOf("WHERE"), "AND " + tab1 + "." + champ1 + " = " + tab2 + "." + champ2 + " ")

        Else


            SQLQuery = SQLQuery + "AND " + tab1 + "." + champ1 + " = " + tab2 + "." + champ2


        End If


        Return SQLQuery



    End Function

    Public Shared Function addCount(ByVal requete As String, ByVal champ As String, ByVal table As String, ByVal name As String) As String
        ' Ajouter un champ count a un instruction sql
        Dim finalChamp = ""

        finalChamp = table + "." + champ

        If (lookInTab(table, champ, False)) Then
            If (requete.Contains("SELECT")) Then

                requete = requete.Insert(requete.IndexOf("SELECT") + 6, " Count ( " + finalChamp + " ) AS " + name + " , ")
            Else
                requete = " SELECT Count ( " + finalChamp + " ) As " + name + " FROM " + table
            End If
        End If

        Return requete
    End Function

    Public Shared Function addGroupBy(ByVal requete As String, ByVal champ As String, ByVal table As String) As String
        ' Ajouter un champ de GROUPBY a un instruction sql
        If (lookInTab(table, champ, False)) Then
            If (requete.Contains("GROUP BY")) Then
                requete = requete.Insert(requete.IndexOf("GROUP BY") + 8, " " + table + "." + champ + " , ")
            Else
                requete = requete + " GROUP BY " + table + "." + champ
            End If
        End If

        Return requete
    End Function

    Public Shared Function addHaving(ByVal requete As String, ByVal condition As Critere, ByVal table As String) As String
        ' Ajouter un condition HAVNG a un instruction sql
        Dim ind = 0
        Dim champ As String = ""
        Dim valeur As String = ""
        Dim t1 As String() = {}
        Dim found As Boolean = False

        champ = condition.getChamps
        valeur = "'" + condition.getValeur.ToString + "'"

        Select Case (condition.getValeur.GetType).ToString ' Savoir le type de la valeur :
            Case "System.String" '
                t1 = BDD.getStringTable(table)               ' Chercher dans le tableau des champs Text
            Case GetType(Integer).ToString, GetType(Double).ToString '
                t1 = BDD.getNumTable(table)                   ' Chercher dans le tableau des champs Numerique
            Case "System.Boolean"
                t1 = BDD.getBoolTable(table)                  ' Chercher dans le tableau des champs Booleen
                'Case Else tab = {}
        End Select
        Try
            While Not found And ind < t1.Length ' Chercher si le champ donnée existe dans le tableau tab1 de la base de donnée
                If champ.Equals(t1(ind)) Then
                    found = True
                Else
                    ind += 1
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If found Then                       ' Si le champ donnée exite
            If (requete.Contains("HAVING")) Then
                requete = requete.Insert(requete.IndexOf("HAVING") + 6, " " + table + "." + champ + " = " + valeur + " AND ")
            Else
                requete = requete + " HAVING " + table + "." + champ + " = " + valeur
            End If
        End If

        Return requete

    End Function

End Class





