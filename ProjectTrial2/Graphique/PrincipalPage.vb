
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
End Class
