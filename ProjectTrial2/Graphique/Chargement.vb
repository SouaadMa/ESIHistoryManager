Public Class Chargement

    Private ClickedButton As Button

    Private Sub Chargement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ChargementButton.Enabled = False
        'Panel2.AllowDrop = True
        'Panel3.AllowDrop = True
        'Panel4.AllowDrop = True
        'Panel5.AllowDrop = True
    End Sub

    Private Sub Panel2_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs)
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        Console.WriteLine(files(0))
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click, Button3.Click, Button2.Click, Button1.Click
        ClickedButton = sender
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        ClickedButton.Text = OpenFileDialog1.FileName
        CType(ChargementPanel.Controls.Item("Label" + ClickedButton.Name.Last()), Label).BackColor = IIf(ClickedButton.Text.Equals(""), Color.FromArgb(0, 64, 104), Color.FromArgb(169, 119, 113))
    End Sub

    Private Sub Button4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.TextChanged, Button3.TextChanged, Button2.TextChanged, Button1.TextChanged
        For Each btn As Button In {Button1, Button2, Button3, Button4}
            If btn.Text = "" Then
                ChargementButton.Enabled = False
                Exit For
            Else
                ChargementButton.Enabled = True
            End If
        Next
    End Sub

    Private Sub ChargementButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChargementButton.Click
        If System.IO.File.Exists("..\..\BDD_APPLICATION.accdb") Then
            'ECLATEMENT("C:\Users\DELL\Documents\BDD_APPLICATION", "C:\Users\DELL\Documents\INSCRIT_00_04", "C:\Users\DELL\Documents\NOTE_00_04", "C:\Users\DELL\Documents\MATIERE_00_04", "C:\Users\DELL\Documents\RATRAP_00_04")
            'RECHARGEMENT("C:\Users\DELL\Documents\BDD_APPLICATION")
            'Dim r As New ECLATEMENT("..\..\BDD_APPLICATION", Button1.Text.Replace(".xlsx", ""), Button2.Text.Replace(".xlsx", ""), Button3.Text.Replace(".xlsx", ""), Button4.Text.Replace(".xlsx", ""))
            'System.IO.File.Delete("..\..\BDD_APPLICATION.accdb")
            'System.IO.File.Copy("..\..\BDD_VIDE.accdb", "..\..\BDD_APPLICATION.accdb", True)
        End If
        'Dim r As New ECLATEMMENT_TRAFFIC("..\..\BDD_APPLICATION", Button1.Text.Replace(".xlsx", ""), Button2.Text.Replace(".xlsx", ""), Button3.Text.Replace(".xlsx", ""), Button4.Text.Replace(".xlsx", ""))
    End Sub

End Class


'Private Sub RadioButton4_CheckedChanged(ByVal lbl As Label, ByVal num As Integer)
'    If num = 1 Then
'        lbl.BackColor = Color.FromArgb(0, 64, 104)
'    Else
'        lbl.BackColor = Color.FromArgb(169, 119, 113)
'    End If
'End Sub