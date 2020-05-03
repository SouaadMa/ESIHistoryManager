
Public Class PrincipalPage

    Private Sub PrincipalPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'initialize the graphic componants values

    End Sub
    'handle the appearence of help button when hovering
    Private Sub HelpButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        Help_Button.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)

    End Sub

    'handle the appearence of help button when leaving
    Private Sub HelpButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        Help_Button.BackColor = Color.Transparent
    End Sub

    'Private Sub BT_charg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Me.PN_BIENVENUE.Visible = False 'hide the acceuil pane
    '    If Not Home.f Is Nothing Then
    '        Home.f.Close()
    '    End If
    '    Home.f = New Chargement()         ' assign the search form to  the f form
    '    Home.f.TopLevel = False
    '    Home.f.TopMost = True
    '    Home.f.WindowState = FormWindowState.Normal
    '    Home.MainContainer1.Controls.Add(Home.f)        ' add the controlers of the searche page to the main form f 
    '    Home.f.Show()                                ' show the form f in the middle of the home page
    '    Home.MainContainer1.Visible = True
    '    'Me.MainContainer.Width = 680            ' adjust its appearance
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Chargement.Show()
        Chargement.TopLevel = False
        'Chargement.TopMost = True
    End Sub
End Class
