Public Class Etudiant
    Implements IComparable(Of Etudiant)

    Private Id As String

    Public Function getId() As String
        Return Me.Id
    End Function

    Public Function CompareTo(ByVal other As Etudiant) As Integer _
        Implements IComparable(Of WindowsApplication1.Etudiant).CompareTo

        Return (Me.getInfo("Moyenne").CompareTo(other.getInfo("Moyenne")))

    End Function

    Public Function getInfo(ByVal champs As String) As Object
        'Return ClasseBDD.getInfoBDD(Id, champs)
        Return Nothing

    End Function

End Class
