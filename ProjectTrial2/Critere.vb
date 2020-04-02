Public Class Critere
    Private champs As String 'Le nom du champs
    Private valeur As Object 'La valeur correspondante au champs
    Private table As String 'Le nom de la table qui contient le champs

    Public Sub New(ByVal cham As String, ByVal val As Object) 'Constructeur
        champs = cham
        valeur = val
    End Sub

    Public Sub New(ByVal cham As String, ByVal val As Object, ByVal tab As String) 'Deuxième constructeur (pour modifier)
        champs = cham
        valeur = val
        table = tab
    End Sub

    Public Function getChamps() As String 'Getter pour le champs
        Return champs
    End Function

    Public Function getValeur() As Object 'Getter pour la valeur
        Return valeur
    End Function

    Public Function getTable() As String 'Getter pour le nom de la table
        Return table
    End Function

End Class
