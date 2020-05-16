Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class password

    Public _agent_mdp As String
    Public _admin_mdp As String   ' the two passwords

    Public Sub New(ByVal _agent_mdp As String, ByVal _admin_mdp As String)
        Me._agent_mdp = _agent_mdp
        Me._admin_mdp = _admin_mdp
    End Sub

    Public Shared Function recover() As password
        Dim p As password = Nothing

        'open our filestream
        Dim stream As FileStream
        stream = File.OpenRead("password.bin")

        'create the binary formatter
        Dim formatter As New BinaryFormatter
        p = formatter.Deserialize(stream)
        stream.Close()

        Return p

    End Function


    Public Sub serialize()
        'serialiser password

        'open our filestream
        Dim stream As FileStream
        stream = File.OpenWrite("password.bin")

        'create the binary formatter
        Dim formatter As New BinaryFormatter
        formatter.Serialize(stream, Me)

        stream.Close()
    End Sub
End Class
