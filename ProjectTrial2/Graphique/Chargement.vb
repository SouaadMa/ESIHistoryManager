Public Class Chargement

    Private ClickedButton As Button

    Private Sub Chargement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton3.Checked = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton4.Checked = False
        ChargementButton.Enabled = False
        'Panel2.AllowDrop = True
        'Panel3.AllowDrop = True
        'Panel4.AllowDrop = True
        'Panel5.AllowDrop = True
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged, RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        'For Each rdbtn As RadioButton In FlowLayoutPanel1.Controls
        '    rdbtn.BackColor = Color.FromArgb(169, 119, 113)
        'Next
        If CType(sender, RadioButton).Checked Then
            sender.BackColor = Color.FromArgb(0, 64, 104)
        Else
            sender.BackColor = Color.FromArgb(169, 119, 113)
        End If
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
        CType(ChargementPanel.Controls.Item("RadioButton" + ClickedButton.Name.Last()), RadioButton).Checked = True
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
                'System.IO.File.Delete("..\..\BDD_APPLICATION.accdb")
                'System.IO.File.Copy("..\..\BDD_VIDE.accdb", "..\..\BDD_APPLICATION.accdb", True)
        End If
        Dim r As New ECLATEMMENT_TRAFFIC("..\..\BDD_APPLICATION", Button1.Text.Replace(".xlsx", ""), Button2.Text.Replace(".xlsx", ""), Button3.Text.Replace(".xlsx", ""), Button4.Text.Replace(".xlsx", ""))
    End Sub

End Class