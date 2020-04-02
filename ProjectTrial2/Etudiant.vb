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
            Console.Write(champs + " : ")
            Try
                'Console.WriteLine(ligne(champs).ToString)
                InfosETUDIANT.Add(champs, CType(ligne(champs), String))
            Catch ex As Exception
                Console.WriteLine("Valeur erronnee !")
            End Try

        Next
        For Each champs As String In BDD.numETUDIANT
            'Console.Write(champs + " : ")
            Try
                'Console.WriteLine(ligne(champs).ToString)
                InfosETUDIANT.Add(champs, CType(ligne(champs), String))
            Catch ex As Exception
                Console.WriteLine("Valeur erronnee !")
            End Try

        Next
        For Each champs As String In BDD.boolETUDIANT
            'Console.Write(champs + " : ")
            Try
                'Console.WriteLine(ligne(champs).ToString)
                InfosETUDIANT.Add(champs, CType(ligne(champs), String))
            Catch ex As Exception
                Console.WriteLine("Valeur erronnee !")
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

End Class
