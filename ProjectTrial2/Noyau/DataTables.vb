Public Class DataTables

    

    Private Class TotalValue

        Public Property Key As String
        Public Property Total As Integer

    End Class

    

    Public Shared Sub JOINDataTables(ByVal ds As DataSet)



        Dim domaine1 As New List(Of Critere)({New Critere(BDD.champsNiveau, "1")})
        Dim domaine2 As New List(Of Critere)({New Critere(BDD.champsNiveau, "2")})

        Dim stat1 As New Statistiques(domaine1, New Critere("Nombre", ""), BDD.champsDECIIN)
        Dim stat2 As New Statistiques(domaine2, New Critere("Nombre", ""), BDD.champsDECIIN)

        Dim dt1 As DataTable = stat1.GetDataTable
        Dim dt2 As DataTable = stat2.GetDataTable

        


        'ds.Tables.Add(table)

        'Form1.ds = ds


        Form1.Show()

        





    End Sub

    Public Shared Function JoinTwoDataTables(ByVal dt1 As DataTable, ByVal dt2 As DataTable) As DataTable


        Dim tot1 As List(Of TotalValue) = dt1.ToList(Of TotalValue)()
        Dim tot2 As List(Of TotalValue) = dt2.ToList(Of TotalValue)()

        Dim vDRnull As DataRow = dt1.Rows.Add

        Dim vLINQ0 = From a In tot2
            Group Join bTemp In tot1
            On a.Key Equals bTemp.Key
            Into Group Let b = If(Group.FirstOrDefault Is Nothing, 0, Group.FirstOrDefault.Total)
            Select Total1 = a.Total, Total2 = b, key = a.Key





        Return vLINQ0.ToList.ToDataTable

        For Each part In vLINQ0

            Console.WriteLine(part.Total1.ToString + " " + part.Total2.ToString + " " + part.key)

        Next






    End Function

    Public Shared Sub prepareNomsColonnes(ByVal dt As DataTable)

        If dt.Columns.Count = 2 Then

            For Each col As DataColumn In dt.Columns

                If col.ColumnName.Equals("Total") Then


                Else

                    col.ColumnName = "Key"


                End If






            Next










        End If







    End Sub






End Class
