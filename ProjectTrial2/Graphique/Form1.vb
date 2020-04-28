Public Class Form1

    Public Shared i = 0
    Public ds As DataSet

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        i = i Mod (ds.Tables.Count - 1) + 1
        Me.DataGridView1.DataSource = ds.Tables(i)
        Label1.Text = i.ToString
        DataGridView1.Refresh()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataGridView1.DataSource = ds.Tables(0)
        Label1.Text = "0"
    End Sub
End Class