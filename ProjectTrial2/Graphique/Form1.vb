Public Class Form1

    Public Shared i = 0
    Public ds As New DataSet()

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        i = (i + 1) Mod ds.Tables.Count
        'i = i + 1
        'If i >= ds.Tables.Count Then
        '    i = 0
        'End If
        Me.DataGridView1.DataSource = ds.Tables(i)
        Label1.Text = i.ToString
        DataGridView1.Refresh()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ds.Tables.Count > 0 Then
            Me.DataGridView1.DataSource = ds.Tables(0)
        End If
        Label1.Text = "0"
    End Sub
End Class