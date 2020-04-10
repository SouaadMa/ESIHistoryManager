<Serializable()>
Public Class password

    Public _agent_mdp As String
    Public _admin_mdp As String   ' the two passwords

    Public Sub New(ByVal _agent_mdp As String, ByVal _admin_mdp As String)
        Me._agent_mdp = _agent_mdp
        Me._admin_mdp = _admin_mdp
    End Sub

End Class
