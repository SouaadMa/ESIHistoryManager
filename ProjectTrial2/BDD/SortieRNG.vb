Public Class SortieRNG

    Public Shared Function RNG(ByVal etud As Etudiant) As DataSet



        Dim dtEtud As New DataTable(BDD.nomTableEtudiant)
        Dim lignecomplete As DataRow = etud.InfosETUDIANT

        Dim Annees_Decisions As List(Of Critere) = New List(Of Critere)
        Dim ds As DataSet = New DataSet()


        dtEtud.Columns.Add(BDD.champsNomEtud)
        dtEtud.Columns.Add(BDD.champsPrenoms)
        dtEtud.Columns.Add(BDD.champsMATRIN)
        dtEtud.Columns.Add(BDD.champsDateNais)
        dtEtud.Columns.Add(BDD.champsLieuNais)

        'dtEtud.Columns.Add(lignecomplete.Item(BDD.champsNomEtud))
        'dtEtud.Columns.Add(lignecomplete.Item(BDD.champsPrenoms))
        'dtEtud.Columns.Add(lignecomplete.Item(BDD.champsMATRIN))
        'dtEtud.Columns.Add(lignecomplete.Item(BDD.champsDateNais))
        'dtEtud.Columns.Add(lignecomplete.Item(BDD.champsLieuNais))

        dtEtud.Rows.Add({lignecomplete.Item(BDD.champsNomEtud), lignecomplete.Item(BDD.champsPrenoms), lignecomplete.Item(BDD.champsMATRIN), lignecomplete.Item(BDD.champsDateNais), lignecomplete.Item(BDD.champsLieuNais)})

        ds.Tables.Add(dtEtud)

        'dtEtud.Clear()


        Dim listeChamps As New List(Of String)

        Dim listeConditions As New List(Of Critere)

        listeChamps.Add(BDD.champsMENTIN)
        listeChamps.Add(BDD.champsRANGIN)
        listeChamps.Add(BDD.champsMOYEIN)
        listeChamps.Add(BDD.champsNbreEtudiant)
        listeChamps.Add(BDD.champsCodePromo)
        listeChamps.Add(BDD.champsADM)

        'listeConditions.Add(New Critere(BDD.champsADM, "adm"))
        listeConditions.Add(New Critere(BDD.champsMATRIN, etud.GetInfoChamps(BDD.champsMATRIN)))
        '__________________________________________________

        Dim requete As String = ""
        Dim dtInscrit As New DataTable()
        requete = Class_BDD.genereRechRequete(listeChamps, BDD.nomTableINSCRIPTION, BDD.nomTablePROMO, listeConditions, True)
        dtInscrit = (BDD.executeRequete(requete))
        dtInscrit = Classement.SortASCCollection(dtInscrit, BDD.champsCodePromo)
        ds.Tables.Add(dtInscrit)



        listeChamps.Clear()

        listeChamps.Add(BDD.champsLIBEMA)
        listeChamps.Add(BDD.champsNOJUNO)
        listeChamps.Add(BDD.champsNORANO)
        listeChamps.Add(BDD.champsCOEFMA)

        Dim dt As DataTable


        If etud.RNGPossible(Annees_Decisions) Then

            For Each a As Critere In Annees_Decisions

                If a.getValeur = "J" Or a.getValeur = "S" Then       ' Or a.getValeur = "2"

                    listeConditions.Clear()
                    listeConditions.Add(New Critere(BDD.champsMATRIN, etud.GetInfoChamps(BDD.champsMATRIN)))
                    listeConditions.Add(New Critere(BDD.champsCodePromo, a.getChamps))

                    dt = etud.GetNotesMat(listeChamps, listeConditions)
                    dt.TableName = "tableNotesMat" & a.getChamps().Substring(0, 1)
                    ds.Tables.Add(dt)
                    'ds.Tables(0).i()

                End If
            Next
        Else
            Throw New RngImpossibleException()
        End If

        Return ds

    End Function

End Class
