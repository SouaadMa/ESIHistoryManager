Public Class Chargement

    Private ClickedButton As Button
    Private file1 As String = ""
    Private file2 As String = ""
    Private file3 As String = ""
    Private file4 As String = ""
    Private eclat As New ECLATEMENT()

    Private Sub Chargement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ChargementButton.Enabled = False
        CompletLabel.Visible = False
        'Panel2.AllowDrop = True
        'Panel3.AllowDrop = True
        'Panel4.AllowDrop = True
        'Panel5.AllowDrop = True
    End Sub

    Private Sub Panel2_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs)
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        Console.WriteLine(files(0))
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click
        ClickedButton = sender
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        ClickedButton.Text = OpenFileDialog1.FileName
        Select Case ClickedButton.Name
            Case "Button1"
                file1 = OpenFileDialog1.FileName
            Case "Button2"
                file2 = OpenFileDialog1.FileName
            Case "Button3"
                file3 = OpenFileDialog1.FileName
            Case "Button4"
                file4 = OpenFileDialog1.FileName
        End Select
        'ClickedButton.Text = IIf(ClickedButton.Text.Count > 30, ClickedButton.Text.Replace(ClickedButton.Text.Substring(0, ClickedButton.Text.LastIndexOf("\") - 5), "..."), ClickedButton.Text)
        ClickedButton.Text = ClickedButton.Text.Substring(ClickedButton.Text.LastIndexOf("\") + 1)
        CType(Panel1.Controls.Item("Label" + ClickedButton.Name.Last()), Label).BackColor = IIf(Not ClickedButton.Text.Equals("Cliquez pour choisir le fichier"), Color.FromArgb(0, 64, 104), Color.FromArgb(169, 119, 113))
    End Sub

    Private Sub Button4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.TextChanged, Button2.TextChanged, Button3.TextChanged, Button4.TextChanged
        For Each btn As Button In {Button1, Button2, Button3, Button4}
            If btn.Text.Equals("Cliquez pour choisir le fichier") Then
                ChargementButton.Enabled = False
                Exit For
            Else
                ChargementButton.Enabled = True
            End If
        Next
    End Sub

    Private Sub ChargementButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChargementButton.EnabledChanged
        If ChargementButton.Enabled Then
            ChargementButton.BackColor = Color.FromArgb(0, 64, 104)
        Else
            ChargementButton.BackColor = Color.FromArgb(169, 119, 113)
        End If
    End Sub

    Private Sub ChargementButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChargementButton.Click
        ChargBackgroundWorker.RunWorkerAsync({"..\..\BDD_APPLICATION", file1.Replace(".xlsx", ""), file2.Replace(".xlsx", ""), file3.Replace(".xlsx", ""), file4.Replace(".xlsx", "")})
        'eclat.ECLATEMENT("..\..\BDD_APPLICATION", file1.Replace(".xlsx", ""), file2.Replace(".xlsx", ""), file3.Replace(".xlsx", ""), file4.Replace(".xlsx", ""))
        Panel1.Visible = False
    End Sub

    Private Sub RechargementButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechargementButton.Click
        'eclat.RECHARGEMENT("..\..\BDD_APPLICATION")
        ChargBackgroundWorker.RunWorkerAsync({"..\..\BDD_APPLICATION"})
    End Sub

    Private Sub ChargBackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles ChargBackgroundWorker.DoWork
        Dim worker As System.ComponentModel.BackgroundWorker = DirectCast(sender, System.ComponentModel.BackgroundWorker)
        eclat.worker = worker
        Dim collection_files() As String = e.Argument
        If collection_files.Length > 1 Then
            eclat.ECLATEMENT(collection_files(0), collection_files(1), collection_files(2), collection_files(3), collection_files(4))
        Else
            eclat.RECHARGEMENT(collection_files(0))
        End If
        Login.Infosgenerale = New InfosGenerales()
    End Sub

    Private Sub ChargBackgroundWorker_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles ChargBackgroundWorker.ProgressChanged
        ProgressLabel.Text = e.ProgressPercentage.ToString + "%"
        PictureBox2.Size = New System.Drawing.Size(PictureBox2.Width, (e.ProgressPercentage * (PictureBox2.MaximumSize.Height)) \ 100)
    End Sub

    Private Sub ChargBackgroundWorker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ChargBackgroundWorker.RunWorkerCompleted
        eclat.progress = 0
        Panel1.Visible = True
        CompletLabel.Visible = True
    End Sub

    Private Sub Panel1_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel1.VisibleChanged
        ProgressPanel.Visible = Not Panel1.Visible
    End Sub

End Class





'ECLATEMENT("C:\Users\DELL\Documents\BDD_APPLICATION", "C:\Users\DELL\Documents\INSCRIT_00_04", "C:\Users\DELL\Documents\NOTE_00_04", "C:\Users\DELL\Documents\MATIERE_00_04", "C:\Users\DELL\Documents\RATRAP_00_04")
'RECHARGEMENT("C:\Users\DELL\Documents\BDD_APPLICATION")
'Dim r As New ECLATEMENT("..\..\BDD_APPLICATION", Button1.Text.Replace(".xlsx", ""), Button2.Text.Replace(".xlsx", ""), Button3.Text.Replace(".xlsx", ""), Button4.Text.Replace(".xlsx", ""))
'System.IO.File.Delete("..\..\BDD_APPLICATION.accdb")
'System.IO.File.Copy("..\..\BDD_VIDE.accdb", "..\..\BDD_APPLICATION.accdb", True)

'_TRAFFIC("..\..\BDD_APPLICATION", Button1.Text.Replace(".xlsx", ""), Button2.Text.Replace(".xlsx", ""), Button3.Text.Replace(".xlsx", ""), Button4.Text.Replace(".xlsx", ""))