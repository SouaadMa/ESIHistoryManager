
Public Class Critere
    Private champs As String
    Private valeur As Object

    Public Sub New(ByVal cham As String, ByVal val As Object)
        champs = cham
        valeur = val

    End Sub

    Public Function getChamps() As String
        Return champs
    End Function

    Public Function getValeur() As Object
        Return valeur
    End Function

End Class
