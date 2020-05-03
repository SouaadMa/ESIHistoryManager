Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class Login

    Public Shared password_ As password = Nothing
    Public Shared password_n As password = Nothing

    Public Shared Infosgenerale As InfosGenerales = Nothing

    Function Connexion(ByVal mdp As String) As Boolean ' fnction that return the responce to the password according to the mode of connexion

        Dim correct As Boolean = False

        If AgentButton.Checked Then
            If mdp = password_._agent_mdp Then
                correct = True
            End If
        End If

        If AdminButton.Checked Then
            If mdp = password_._admin_mdp Then
                correct = True
                'Dim r As New ECLATEMMENT_TRAFFIC()
            End If
        End If
        Return correct
    End Function


    'a function that determine the mode of connexion
    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AgentButton.CheckedChanged

        If AgentButton.Checked Then
            Me.profile_photo_login.Image = My.Resources.user_profile
            AgentButton.ForeColor = Color.Pink
            AgentButton.Image = My.Resources.Rectangle_rose

            AdminButton.ForeColor = Color.LavenderBlush                     ' change the appearance of the two radioButton according to the user' selection
            AdminButton.Image = My.Resources.Rectangle_blanc

        ElseIf AdminButton.Checked Then
            Me.profile_photo_login.Image = My.Resources.administrator_profile

            AdminButton.ForeColor = Color.Pink
            AdminButton.Image = My.Resources.Rectangle_rose

            AgentButton.ForeColor = Color.LavenderBlush
            AgentButton.Image = My.Resources.Rectangle_blanc
        End If
    End Sub

    ' a function to show the responce to the connexion request ( launch the home page or the error message )
    Private Sub ConexionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConexionButton.Click
        If Connexion(Me.MotDePasseTextField.Text) Then
            Infosgenerale = New InfosGenerales()
            'open our filestream
            ' Dim stream As FileStream
            'stream = File.OpenRead("InfosGenerale.txt")

            'create the binary formatter
            'Dim formatter As New BinaryFormatter
            'Infosgenerale = formatter.Deserialize(stream)

            'stream.Close()
            Home.Show()
        Else
            Me.avertissemnt.Visible = True
        End If

    End Sub

    ' handle the appearnace when focusing on the password input
    Private Sub MotDePasseTextField_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MotDePasseTextField.GotFocus, MotDePasseTextField.TextChanged, MotDePasseTextField.Click
        Me.avertissemnt.Visible = False
    End Sub
    ' initialize the mode of connexion to agent when entering the application 
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AgentButton.Checked = True
        Me.Size = New System.Drawing.Size(1024, 728)
        Me.MinimumSize = New System.Drawing.Size(1023, 700)
        Me.MaximumSize = New System.Drawing.Size(1050, 750)

        'open our filestream
        Dim stream As FileStream
        stream = File.OpenRead("password.txt")

        'create the binary formatter
        Dim formatter As New BinaryFormatter
        Login.password_ = formatter.Deserialize(stream)
        stream.Close()

        stat()



        Console.WriteLine()

    End Sub

    Public Shared Sub stat()

        Dim domaine As New List(Of Critere) '({New Critere(BDD.champsCodePromo, "4/SI/00", BDD.nomTableINSCRIPTION)}) '({New Critere(BDD.champsAnnee, "2000", BDD.nomTableINSCRIPTION), New Critere(BDD.champsOption, "TRC", ""), New Critere(BDD.champsNiveau, "4", BDD.nomTablePROMO)})
        '({New Critere(BDD.champsCodePromo, "4/SI/00")})
        '({New Critere(BDD.champsNiveau, "4", BDD.nomTablePROMO)
        ' New Critere(BDD.champsCodeGroupe, 6)

        'Dim dt As New DataTable

        Dim stat1_1 As New Statistiques(domaine, New Critere("Nombre", ""), BDD.champsDECIIN)

        Dim ds As New DataSet()
        
        Dim dt As DataTable = stat1_1.GetDataTable
        ds.Tables.Add(dt)
        

        Form1.ds = ds
        Form1.Show()

        Dim stat1_2 As New Statistiques(domaine, New Critere("Nombre", ""), BDD.champsSEXE)

        Dim stat1_3 As New Statistiques(domaine, New Critere("Nombre", ""), BDD.champsOption)

        Dim stat2_1 As New Statistiques(domaine, New Critere(BDD.champsNOJUNO, 10), BDD.champsCOMAMA)

        Dim stat2_2 As New Statistiques(domaine, New Critere(BDD.champsDECIIN, "REUSSITE"), BDD.champsCodeGroupe)

        Dim stat2_3 As New Statistiques(domaine, New Critere(BDD.champsDECIIN, "REUSSITE"), BDD.champsNiveau)


        Dim stat5_1 As New Statistiques(domaine, New Critere(BDD.champsMOYEIN, 10), BDD.champsNiveau)

        Dim stat5_2 As New Statistiques(domaine, New Critere(BDD.champsMOYEIN, 10), BDD.champsCodeGroupe)

        Dim stat5_3 As New Statistiques(domaine, New Critere(BDD.champsMOYEIN, 10), BDD.champsCodeSection)




    End Sub

End Class
