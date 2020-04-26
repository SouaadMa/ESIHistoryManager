Public Class Etudiant

    Implements IComparable(Of Etudiant)  'La classe implémente Comparable

    'Private InfosETUDIANT As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Public InfosETUDIANT As DataRow
    'Private InfosINSCRIPTION As Dictionary(Of String, String) = New Dictionary(Of String, String)
    'Private InfosGROUP As Dictionary(Of String, String) = New Dictionary(Of String, String)
    'Private InfosSECTION As Dictionary(Of String, String) = New Dictionary(Of String, String)
    'Private InfosPROMO As Dictionary(Of String, String) = New Dictionary(Of String, String)
    'Private InfosNOTE As Dictionary(Of String, String) = New Dictionary(Of String, String)
    'Private InfosMATIERE As Dictionary(Of String, String) = New Dictionary(Of String, String)
    'Private InfosNOTERATRAP As Dictionary(Of String, String) = New Dictionary(Of String, String)
    'Private InfosRATRAP As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Public Anneedetude As New List(Of String)


    Private Id As String 'L'identité de l'étudiant (son matricule)

    Public Function getId() As String 'Getter pour l'Id
        Return Me.Id
    End Function

    Public Sub New(ByVal i As String)
        Id = i
    End Sub

    Public Sub New(ByVal ligne As DataRow)

        InfosETUDIANT = ligne

        If (False) Then

            For Each champs As String In BDD.stringETUDIANT
                'Console.Write(champs + " : ")
                Try
                    'Console.WriteLine(ligne(champs).ToString)
                    'InfosETUDIANT.Add(champs, CType(ligne(champs), String))
                Catch ex As InvalidCastException
                    'Console.WriteLine("Valeur erronnee !")
                End Try
            Next
            For Each champs As String In BDD.numETUDIANT
                'Console.Write(champs + " : ")
                Try
                    'Console.WriteLine(ligne(champs).ToString)
                    'InfosETUDIANT.Add(champs, CType(ligne(champs), String))
                Catch ex As InvalidCastException
                    'Console.WriteLine("Valeur erronnee !")

                End Try

            Next
            For Each champs As String In BDD.boolETUDIANT
                'Console.Write(champs + " : ")
                Try
                    'Console.WriteLine(ligne(champs).ToString)
                    'InfosETUDIANT.Add(champs, CType(ligne(champs), String))
                Catch ex As InvalidCastException
                    'Console.WriteLine("Valeur erronnee !")
                End Try
            Next
            'Console.WriteLine("------------------------------------------------------")
        End If

    End Sub




    'Méthode qui charge les informations de la table INSCRIPTION de l'étudiant selon le critère donné (l'année)
    'We don't need to use it as long as we have ChargementInfos, the method above
    'But don't delete it

    Public Function ChargementInfosINSCRIPTION(ByVal critere As Critere) As DataRow

        Dim ligne As DataRow = BDD.GetFromTable(BDD.nomTableINSCRIPTION, Me.GetInfoChamps(BDD.champsMATRIN), critere)

        Return ligne

        

    End Function

    'Méthode qui charge les informations de l'étudiant selon le critère donné 
    Public Function ChargementInfos(ByVal critere As Critere) As DataRow

        Dim ligne As DataRow


        'Les tables qui ont relation avec un seul étudiant
        If (critere.getTable.Equals(BDD.nomTableINSCRIPTION) Or critere.getTable.Equals(BDD.nomTableNOTE) Or critere.getTable.Equals(BDD.nomTableNoteRATRAP)) Then

            ligne = BDD.GetFromTable(critere.getTable, Me.GetInfoChamps(BDD.champsMATRIN), critere)
            Return ligne

        Else

            'MATIERE, RATRAP, GROUP, Section, PROMO 
            'Sont des tables indépendantes de l'étudiant

            ligne = BDD.GetFromTable(critere.getTable, critere)
            Return ligne

        End If


    End Function



    Public Function CompareTo(ByVal other As Etudiant) As Integer _
        Implements IComparable(Of Etudiant).CompareTo 'La méthode de la classe Comparable

        Return (Me.GetInfoChamps(BDD.champsMATRIN).CompareTo(other.GetInfoChamps(BDD.champsMATRIN))) 'Elle compare entre les matricules des deux étudiants

    End Function


    Public Function GetInfoChamps(ByVal champs As String) As String

        Return CType(InfosETUDIANT(champs), String)


    End Function

    ' Méthode qui retourne toutes les valeurs possibles d'un champs dans la base de données,
    ' et qui correspondent à l'étudiant

    Public Function GetALL(ByVal champs As String) As List(Of String)

        'Génération du critère MATRIN
        Dim condition As New Critere(BDD.champsMATRIN, Me.GetInfoChamps(BDD.champsMATRIN))

        'Récuperation du résultat de la requête dans la BDD
        Dim dt As New DataTable

        'Console.WriteLine(champs + " Table: " + BDD.GetTable(champs))


        dt = BDD.GetALL(champs, BDD.GetTable(champs), condition)


        'Création de la liste à retourner
        Dim liste As New List(Of String)

        For Each ligne As DataRow In dt.Rows

            Try
                liste.Add(CType(ligne(champs), String))

            Catch ex As Exception
                MsgBox("GetALLEtudiant " + ex.Message)
                liste.Add(" ")
            End Try


        Next

        Return liste


    End Function



    ' Méthodes particulières pour les sorties d'un étudiant

    Public Function GetNotesMat(ByVal listeChamps As List(Of String), ByVal listeConditions As List(Of Critere)) As DataTable

        Dim req As String = Class_BDD.genereRechRequete(listeChamps, BDD.nomTableNOTE, BDD.nomTableMATIERE, listeConditions)
        'req = req.Insert(req.IndexOf(BDD.champsCodePromo), BDD.nomTableMATIERE + ".")
        Return BDD.executeRequete(req)

    End Function



    Public Function RNGPossible(ByRef Annees_Decisions As List(Of Critere)) As Boolean

        Dim dt As DataTable
        Dim sql As String = ""
        Dim bool As Boolean = False


        sql = Rech_BDD.genereRechRequetes(sql, New Critere(BDD.champsMATRIN, GetInfoChamps(BDD.champsMATRIN)), BDD.nomTableINSCRIPTION)
        dt = BDD.executeRequete(sql)

        For Each ligne As DataRow In dt.Rows

            If ligne(BDD.champsCodePromo).Substring(0, 1) = "5" Then
                bool = True
            End If

        Next
        If bool Then
            For Each ligne As DataRow In dt.Rows
                Annees_Decisions.Add(New Critere(ligne(BDD.champsCodePromo), ligne(BDD.champsDECIIN)))
            Next
        End If

        Return bool


    End Function


End Class
