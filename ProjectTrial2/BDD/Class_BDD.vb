﻿Public Class Class_BDD

    Public Shared Function genereRechRequete(ByVal champs As List(Of String), ByVal tab1 As String, ByVal tab2 As String, ByVal conditions As List(Of Critere))
        Dim requete As String       ' La requete a retourner
        Dim first As Boolean        ' Booleén pour vérifier s'il y a au moins une Champ / Critere ( condition) ajouté à l'instruction sql
        Dim found As Boolean        ' Booleén pour vérifier que le champ donnée existe dans la base ( dans les tables )
        Dim champ As String         ' Le champ à vérifier pour les conditions
        Dim valeur As String        ' La valeur de champ à vérifier      
        Dim ind As String           ' l'indice pour parcourir les tables
        Dim cle1 As String          ' Le champ qui est égale entre tab1 et tab2 pour tab1
        Dim cle2 As String          ' Le champ qui est égale entre tab1 et tab2 pour tab2
        Dim t1 As String()
        Dim t2 As String()

        requete = ""                                        ' Initialiser la requete sql 
        cle1 = BDD.getCorrespondance(tab1, tab2, 1)         ' Trouver le nom de champ qui est égale entre tab1 et tab2 pour tab1
        cle2 = BDD.getCorrespondance(tab1, tab2, 2)         ' Trouver le nom de champ qui est égale entre tab1 et tab2 pour tab2

        If Not (cle1 = "") And Not (cle2 = "") Then ' And Not (champs.Count > 0) Then  ' Si les tables tab1 et tab2 ont un champ égale dans la tables correspondante ( et La liste des champs 0 retourner n'est pas vide )

            requete = " SELECT "                            ' Initialiser la requete sql de recherche
            first = True
            For Each champ In champs                        ' Pour chaque champ dans la liste des champs à retourner
                ind = 0
                found = False
                Try
                    While Not found And ind < (BDD.getStringTable(tab1)).Length                ' Chercher si le champ donnée existe dans le tableau tab1 comme champ des stringde la base de donnée  
                        If champ.Equals((BDD.getStringTable(tab1))(ind)) Then
                            found = True
                        Else
                            ind += 1
                        End If
                    End While
                    ind = 0
                    While Not found And ind < (BDD.getNumTable(tab1)).Length                ' Chercher si le champ donnée existe dans le tableau tab1 comme champ numériquede la base de donnée  
                        If champ.Equals((BDD.getNumTable(tab1))(ind)) Then
                            found = True
                        Else
                            ind += 1
                        End If
                    End While
                    ind = 0
                    While Not found And ind < (BDD.getBoolTable(tab1)).Length                ' Chercher si le champ donnée existe dans le tableau tab1 comma champ boolean de la base de donnée  
                        If champ.Equals((BDD.getBoolTable(tab1))(ind)) Then
                            found = True
                        Else
                            ind += 1
                        End If
                    End While
                    ind = 0
                    While Not found And ind < (BDD.getStringTable(tab2)).Length                ' Chercher si le champ donnée existe dans le tableau tab2 des champs string de la base de donnée  
                        If champ.Equals((BDD.getStringTable(tab2))(ind)) Then
                            found = True
                        Else
                            ind += 1
                        End If
                    End While
                    ind = 0
                    While Not found And ind < (BDD.getNumTable(tab2)).Length                ' Chercher si le champ donnée existe dans le tableau tab2 des champs numérique de la base de donnée  
                        If champ.Equals((BDD.getNumTable(tab2))(ind)) Then
                            found = True
                        Else
                            ind += 1
                        End If
                    End While
                    ind = 0
                    While Not found And ind < (BDD.getBoolTable(tab2)).Length                ' Chercher si le champ donnée existe dans le tableau tab2 des champs boolean de la base de donnée  
                        If champ.Equals((BDD.getBoolTable(tab2))(ind)) Then
                            found = True
                        Else
                            ind += 1
                        End If
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                If found Then               ' Si le champ donnée exite
                    If first Then                   ' -> Si cette champ est le premier à ajouté
                        first = False                           '--> mettre first à faux ( la premier critere est ajoutée )
                    Else                            '-> Sinon ( on a pas déjà ajouté aucun condition )
                        requete = requete + " , "               '--> ajouter un vergule
                    End If
                    requete = requete + champ       ' Ajouter le champ
                End If
            Next

            requete = requete + " FROM " + tab1 + " JOIN " + tab2       '   Ajouner les noms des tables de jointeur à l'instruction sql

            requete = requete + " ON " + tab1 + "." + cle1 + " = " + tab2 + "." + cle2      '   Ajouner les noms des champs correspondantes des tables de jointeur à l'instruction sql

            If (conditions.Count > 0) Then                      'Si La liste des conditions n'est pas vide 

                first = True
                requete = requete + " WHERE "
                For Each cond As Critere In conditions          ' Pour chaque critere dans la liste des critères

                    champ = cond.getChamps
                    valeur = "'" + cond.getValeur.ToString + "'"
                    ind = 0
                    found = False

                    Try

                        t1 = {}
                        t2 = {}

                        Select Case (cond.getValeur.GetType).ToString       ' Savoir le type de la valeur :
                            Case "System.String"                                      ' valeur Text
                                'Console.WriteLine("string")
                                t1 = BDD.getStringTable(tab1)                                           ' Chercher dans le tableau des champs Text
                                t2 = BDD.getStringTable(tab2)
                                'valeur = "'" + crit.getValeur + "'"
                            Case GetType(Integer).ToString, GetType(Double).ToString  ' valeur Numérique
                                'Console.WriteLine("num")
                                t1 = BDD.getNumTable(tab1)                                               ' Chercher dans le tableau des champs Numerique                    
                                t2 = BDD.getNumTable(tab2)
                                'valeur = crit.getValeur.ToString
                            Case "System.Boolean"                                     ' valeur Booleen
                                'Console.WriteLine("bool")
                                t1 = BDD.getBoolTable(tab1)                                          ' Chercher dans le tableau des champs Booleen
                                t2 = BDD.getBoolTable(tab2)
                                'valeur = crit.getValeur
                                'Case Else     tab = {}
                        End Select


                        While Not found And ind < t1.Length                ' Chercher si le champ donnée existe dans le tableau tab1 de la base de donnée  
                            If champ.Equals(t1(ind)) Then
                                found = True
                            Else
                                ind += 1
                            End If
                        End While
                        ind = 0
                        While Not found And ind < t2.Length                ' Chercher si le champ donnée existe dans le tableau tab2 de la base de donnée  
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
                            requete = requete + " , "               '--> ajouter un vergule
                        Else                                 '-> Sinon ( on a pas encore ajouté aucun condition )
                            first = False                           '--> mettre first à faux ( la premier critere est ajoutée )
                        End If
                        requete = requete + champ + " = " + valeur      ' Ajouter le critère ' champ = valeur'
                    End If

                Next

            End If

        End If

        Return requete
    End Function
    Public Function AjouterOrdre_Requete(ByVal requete As String, ByVal Champ As String) As String
        requete = requete & " order  by " & Champ & " "
        Return requete
    End Function
    Public Function AjouterLimit_Requete(ByVal requete As String, ByVal LIMIT As Integer) As String

        requete = requete & "LIMIT " & LIMIT & "  "
        Return requete
    End Function

End Class




