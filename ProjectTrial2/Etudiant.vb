Public Class Etudiant
    Implements IComparable(Of Etudiant)  'La classe implémente Comparable

    Private Id As String 'L'identité de l'étudiant (son matricule)

    Public Function getId() As String 'Getter pour l'Id
        Return Me.Id
    End Function

    Public Sub New(ByVal i As String)
        Id = i
    End Sub

    Public Function CompareTo(ByVal other As Etudiant) As Integer _
        Implements IComparable(Of Etudiant).CompareTo 'La méthode de la classe Comparable

        Return (Me.getInfo("Moyenne").CompareTo(other.getInfo("Moyenne"))) 'Elle compare entre les moyennes des deux étudiants

    End Function

    Public Function getInfo(ByVal champs As String) As Object
        'Return BDD.getInfoBDD(Id, champs)    'Décommenter lorsque la méthode getInfoBDD est disponible
        Return Nothing 'Supprimer cette ligne lorsque vous décommenter la ligne précédente

    End Function

End Class
