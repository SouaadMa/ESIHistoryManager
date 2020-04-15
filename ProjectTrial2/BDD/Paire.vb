Public Class Paire

    Public elem1 As String
    Public elem2 As String

    Public Sub New(ByVal ele1 As String, ByVal ele2 As String)
        elem1 = ele1
        elem2 = ele2
    End Sub

    Public Function getElement(ByVal ind As Integer)
        Select Case ind
            Case 1
                Return elem1
            Case 2
                Return elem2
            Case Else
                Return ""
        End Select
    End Function

End Class



