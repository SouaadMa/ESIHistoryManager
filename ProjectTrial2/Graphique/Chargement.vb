Public Class Chargement


    Private Sub Chargement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel2.AllowDrop = True
        Panel3.AllowDrop = True
        Panel4.AllowDrop = True
        Panel5.AllowDrop = True
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        For Each rdbtn As RadioButton In FlowLayoutPanel1.Controls
            rdbtn.BackColor = Color.FromArgb(169, 119, 113)
        Next
        If RadioButton1.Checked Then
            sender.BackColor = Color.FromArgb(0, 64, 104)
        End If

    End Sub

    Private Sub Panel2_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Panel5.DragDrop, Panel4.DragDrop, Panel3.DragDrop, Panel2.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        Console.WriteLine(files(0))
    End Sub

    Private Sub Panel2_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Panel2.DragEnter, Panel5.DragEnter, Panel4.DragEnter, Panel3.DragEnter

    End Sub

End Class