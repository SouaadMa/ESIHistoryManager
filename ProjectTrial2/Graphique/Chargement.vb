Public Class Chargement


    Private Sub Panel2_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs)
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        For Each rdbtn As RadioButton In FlowLayoutPanel1.Controls
            rdbtn.BackColor = Color.FromArgb(169, 119, 113)
        Next
        If RadioButton1.Checked Then
            sender.BackColor = Color.FromArgb(0, 64, 104)
        End If

    End Sub

    Private Sub Panel2_DragDrop_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Panel2.DragDrop

    End Sub

    Private Sub Panel2_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Panel2.DragEnter

    End Sub
End Class