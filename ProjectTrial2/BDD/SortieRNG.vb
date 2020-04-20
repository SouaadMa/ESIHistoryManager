Public Class SortieRNG

    Public Shared Function RNG(ByVal etud As Etudiant) As DataSet



        Dim dtEtud As New DataTable(BDD.nomTableEtudiant)
        Dim lignecomplete As DataRow = etud.InfosETUDIANT

        Dim Annees_Decisions As List(Of Critere) = New List(Of Critere)
        Dim ds As DataSet = New DataSet()


        dtEtud.Columns.Add(lignecomplete.Item(BDD.champsNomEtud))
        dtEtud.Columns.Add(lignecomplete.Item(BDD.champsPrenoms))
        dtEtud.Columns.Add(lignecomplete.Item(BDD.champsMATRIN))
        dtEtud.Columns.Add(lignecomplete.Item(BDD.champsDateNais))
        dtEtud.Columns.Add(lignecomplete.Item(BDD.champsLieuNais))

        ds.Tables.Add(dtEtud)




       
        Dim listeChamps As New List(Of String)
        listeChamps.Add(BDD.champsLIBEMA)
        listeChamps.Add(BDD.champsNOJUNO)
        listeChamps.Add(BDD.champsNORANO)


        Dim listeConditions As New List(Of Critere)

        Dim dt As DataTable


        If etud.RNGPossible(Annees_Decisions) Then

            For Each a As Critere In Annees_Decisions

                If a.getValeur = "1" Or a.getValeur = "2" Then

                    listeConditions.Clear()
                    listeConditions.Add(New Critere(BDD.champsMATRIN, etud.GetInfoChamps(BDD.champsMATRIN)))
                    listeConditions.Add(New Critere(BDD.champsCodePromo, a.getChamps))

                    dt = etud.GetNotesMat(listeChamps, listeConditions)
                    dt.TableName = "tableNotesMat" & a.getChamps().Substring(1, 1)
                    ds.Tables.Add(dt)

                End If
            Next

        End If

        Return ds

    End Function

End Class
