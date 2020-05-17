Public Class SortieRNG

    Private Shared bilan As String = ""

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


        dtEtud.Rows.Add({lignecomplete.Item(BDD.champsNomEtud), lignecomplete.Item(BDD.champsPrenoms), lignecomplete.Item(BDD.champsMATRIN), lignecomplete.Item(BDD.champsDateNais), lignecomplete.Item(BDD.champsLieuNais)})

        ds.Tables.Add(dtEtud)

        
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

        If (dtInscrit.Rows.Count = 0) Then
            bilan += "Cet étudiant, ayant le MATRICULE " & etud.getId & " n'a aucune information d'INSCRIPTION " & vbNewLine
        End If


        listeChamps.Clear()

        listeChamps.Add(BDD.champsLIBEMA)
        listeChamps.Add(BDD.champsNOJUNO)
        listeChamps.Add(BDD.champsNORANO)
        listeChamps.Add(BDD.champsCOEFMA)

        Dim dt As DataTable
        Dim nombreAnnees As Integer = 0

        If etud.RNGPossible(Annees_Decisions, nombreAnnees) Then

            For Each a As Critere In Annees_Decisions

                If a.getValeur = "J" Or a.getValeur = "S" Then       ' Or a.getValeur = "2"

                    listeConditions.Clear()
                    listeConditions.Add(New Critere(BDD.champsMATRIN, etud.GetInfoChamps(BDD.champsMATRIN)))
                    listeConditions.Add(New Critere(BDD.champsCodePromo, a.getChamps))

                    dt = etud.GetNotesMat(listeChamps, listeConditions)
                    dt.TableName = "tableNotesMat" & a.getChamps().Substring(0, 1)
                    ds.Tables.Add(dt)

                    If dt.Rows.Count = 0 Then
                        bilan += "Les informations des Notes/Matière de cet étudiant de l'année " & a.getChamps & " n'existent pas."
                    End If

                End If
            Next
            bilan = "Cet étudiant, ayant le MATRICULE = " & etud.GetInfoChamps(BDD.champsMATRIN) & " a " & nombreAnnees.ToString & " année(s) dans la table INSCRIPTION." & vbNewLine + bilan
            bilan += "Il/Elle a été admis(e) en " & (ds.Tables.Count - 2).ToString & " année(s)." & vbNewLine
            Console.WriteLine(getBilan)
        Else
            bilan = "Cet étudiant, ayant le MATRICULE = " & etud.GetInfoChamps(BDD.champsMATRIN) & " a " & nombreAnnees.ToString & " année(s) dans la table INSCRIPTION." & vbNewLine + bilan
            bilan += "Il/Elle a été admis(e) en " & (ds.Tables.Count - 2).ToString & " année(s)." & vbNewLine
            Console.WriteLine(getBilan)
            Throw New RngImpossibleException()
        End If

        Console.WriteLine(getBilan)

        Return ds

    End Function


    Public Shared Sub SetNbreRNG(ByVal etud As Etudiant, ByVal i As Integer)
        Dim modification As New Critere(BDD.champsNBR_RNG, i, BDD.nomTableEtudiant)
        Dim listeModif As New List(Of Critere)
        listeModif.Add(modification)

        Dim req As String
        req = Modif_BDD.genereModifRequete(etud.GetInfoChamps(BDD.champsMATRIN), listeModif, BDD.nomTableEtudiant)

        BDD.executeRequete(req)

        etud.InfosETUDIANT.Item(BDD.champsNBR_RNG) = i

    End Sub

    Public Shared Function getBilan() As String
        If bilan = "" Then
            Return "Tout est bien passé!"
        Else
            Return bilan
        End If
    End Function

End Class
