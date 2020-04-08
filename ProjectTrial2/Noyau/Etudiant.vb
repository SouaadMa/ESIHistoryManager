Public Class Etudiant
    Implements IComparable(Of Etudiant)  'La classe implémente Comparable

    Private InfosETUDIANT As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Private InfosINSCRIPTION As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Private InfosGROUP As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Private InfosSECTION As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Private InfosPROMO As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Private InfosNOTE As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Private InfosMATIERE As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Private InfosNOTERATRAP As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Private InfosRATRAP As Dictionary(Of String, String) = New Dictionary(Of String, String)

    Private Id As String 'L'identité de l'étudiant (son matricule)

    Public Function getId() As String 'Getter pour l'Id
        Return Me.Id
    End Function

    Public Sub New(ByVal i As String)
        Id = i
    End Sub

    Public Sub New(ByVal ligne As DataRow)
        For Each champs As String In BDD.stringETUDIANT
            'Console.Write(champs + " : ")
            Try
                'Console.WriteLine(ligne(champs).ToString)
                InfosETUDIANT.Add(champs, CType(ligne(champs), String))
            Catch ex As InvalidCastException
                'Console.WriteLine("Valeur erronnee !")
            End Try
        Next
        For Each champs As String In BDD.numETUDIANT
            'Console.Write(champs + " : ")
            Try
                'Console.WriteLine(ligne(champs).ToString)
                InfosETUDIANT.Add(champs, CType(ligne(champs), String))
            Catch ex As InvalidCastException
                'Console.WriteLine("Valeur erronnee !")

            End Try

        Next
        For Each champs As String In BDD.boolETUDIANT
            'Console.Write(champs + " : ")
            Try
                'Console.WriteLine(ligne(champs).ToString)
                InfosETUDIANT.Add(champs, CType(ligne(champs), String))
            Catch ex As InvalidCastException
                'Console.WriteLine("Valeur erronnee !")
            End Try
        Next
        'Console.WriteLine("------------------------------------------------------")
    End Sub

    

    'Méthode qui charge les informations de l'étudiant selon le critère donné 
    Public Sub ChargementInfos(ByVal critere As Critere)

        Dim ligne As DataRow


        'Les tables qui ont relation avec un seul étudiant
        If (critere.getTable.Equals(BDD.nomTableINSCRIPTION) Or critere.getTable.Equals(BDD.nomTableNOTE) Or critere.getTable.Equals(BDD.nomTableNoteRATRAP)) Then

            ligne = BDD.GetFromTable(critere.getTable, Me.GetInfoChamps(BDD.champsMATRIN), critere)
            FillCollection(critere.getTable, ligne)

        Else

            'MATIERE, RATRAP, GROUP, Section, PROMO 
            'Sont des tables indépendantes de l'étudiant

            ligne = BDD.GetFromTable(critere.getTable, critere)
            FillCollection(critere.getTable, ligne)

        End If


    End Sub

    'Méthode qui charge les informations de la table INSCRIPTION de l'étudiant selon le critère donné (l'année)
    'We don't need to use it as long as we have ChargementInfos, the method above
    'But don't delete it

    Public Sub ChargementInfosINSCRIPTION(ByVal critere As Critere)



        Dim ligne As DataRow = BDD.GetFromTable(BDD.nomTableINSCRIPTION, Me.GetInfoChamps(BDD.champsMATRIN), critere)


        For Each champs As String In BDD.stringINSCRIPTION

            Try

                InfosINSCRIPTION.Add(champs, CType(ligne(champs), String))
            Catch ex As Exception

            End Try
        Next
        For Each champs As String In BDD.numINSCRIPTION

            Try

                InfosINSCRIPTION.Add(champs, CType(ligne(champs), String))
            Catch ex As Exception


            End Try

        Next
        For Each champs As String In BDD.boolINSCRIPTION

            Try

                InfosINSCRIPTION.Add(champs, CType(ligne(champs), String))

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try
        Next




    End Sub



    Public Function CompareTo(ByVal other As Etudiant) As Integer _
        Implements IComparable(Of Etudiant).CompareTo 'La méthode de la classe Comparable

        Return (Me.GetInfoChamps(BDD.champsMATRIN).CompareTo(other.GetInfoChamps(BDD.champsMATRIN))) 'Elle compare entre les matricules des deux étudiants

    End Function


    Public Function GetInfoChamps(ByVal champs As String) As String

        If InfosETUDIANT.ContainsKey(champs) Then
            Return InfosETUDIANT.Item(champs)

            If InfosINSCRIPTION.ContainsKey(champs) Then
                Return InfosINSCRIPTION.Item(champs)

                If InfosNOTE.ContainsKey(champs) Then
                    Return InfosNOTE.Item(champs)

                    If InfosNOTERATRAP.ContainsKey(champs) Then
                        Return InfosNOTERATRAP.Item(champs)

                        If InfosGROUP.ContainsKey(champs) Then
                            Return InfosGROUP.Item(champs)

                            If InfosSECTION.ContainsKey(champs) Then
                                Return InfosSECTION.Item(champs)

                                If InfosPROMO.ContainsKey(champs) Then
                                    Return InfosPROMO.Item(champs)

                                    If InfosMATIERE.ContainsKey(champs) Then
                                        Return InfosMATIERE.Item(champs)
                                    Else
                                        Return InfosRATRAP.Item(champs)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        Return ""

    End Function


    'FillCollection est une méthode qui remplie la collection avec le nom "nameTable" avec les informations
    'Qui sont dans la ligne "ligne"
    Public Sub FillCollection(ByVal nameTable As String, ByVal ligne As DataRow)

        For Each champs As String In BDD.getStringTable(nameTable)

            Try

                getCollection(nameTable).Add(champs, CType(ligne(champs), String))

            Catch ex As Exception

                'MsgBox(ex.Message)

            End Try

        Next

        For Each champs As String In BDD.getNumTable(nameTable)

            Try

                getCollection(nameTable).Add(champs, CType(ligne(champs), String))

            Catch ex As Exception

                'MsgBox(ex.Message)

            End Try

        Next

        For Each champs As String In BDD.getBoolTable(nameTable)

            Try

                getCollection(nameTable).Add(champs, CType(ligne(champs), String))

            Catch ex As Exception

                'MsgBox(ex.Message)

            End Try
        Next


    End Sub

    Private Function getCollection(ByVal nameTable) As Dictionary(Of String, String)

        Select Case nameTable
            Case BDD.nomTableEtudiant
                Return InfosETUDIANT
            Case BDD.nomTableGROUP
                Return InfosGROUP
            Case BDD.nomTableINSCRIPTION
                Return InfosINSCRIPTION
            Case BDD.nomTableMATIERE
                Return InfosMATIERE
            Case BDD.nomTableNOTE
                Return InfosNOTE
            Case BDD.nomTableSection
                Return InfosSECTION
            Case BDD.nomTableNoteRATRAP
                Return InfosNOTERATRAP
            Case BDD.nomTablePROMO
                Return InfosPROMO
            Case BDD.nomTableRATRAP
                Return InfosRATRAP
            Case Else

                'ATTENTION !! !! !!
                'There should be an exception here if the table name doesn't exist


                Return InfosETUDIANT

        End Select



    End Function

End Class
