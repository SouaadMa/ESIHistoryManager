Public Class SortieRNG

    Private Shared bilan As String = ""

    Public Shared Function RNG(ByVal etud As Etudiant) As DataSet
        bilan = ""

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

        '************Récuperation des moyennes de Rattrapage*******************'
        listeChamps.Clear()
        listeChamps.Add(BDD.champsMOYERA)

        requete = Rech_BDD.genereRechRequetes("", New Critere(BDD.champsMATRIN, etud.GetInfoChamps(BDD.champsMATRIN)), BDD.nomTableNoteRATRAP)
        

        Dim tableRATTRAP As DataTable = BDD.executeRequete(requete)

        If tableRATTRAP.Rows.Count = 0 Then
            bilan += "Cet étudiant, ayant le MATRICULE = " & etud.GetInfoChamps(BDD.champsMATRIN) & " n'a pas d'informations dans la table NotesRATTRAP" & vbNewLine
            'Throw New InvalidCastException
        End If

        ArrangeMOYERAs(dtInscrit, tableRATTRAP)

        ds.Tables.Add(tableRATTRAP)
        '***********************************************************************'


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

                    SortieRN.ArrangeRATTRA(dt, 0.0)

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


    'Remplace la MOYEIN dans dtDest par MOYERA dans dtSource si MOYERA>MOYEIN
    Public Shared Sub ArrangeMOYERAs(ByVal dtDest As DataTable, ByVal dtSource As DataTable)

        Dim codePromo As String = ""
        Dim i As Integer = 0
        Dim rowS As DataRow

        'On fait le tri pour avoir une correspondance entre les lignes des deux tables
        'Dans ce cas, les tables sont déjà triés
        '
        'Classement.SortASCCollection(dtDest, BDD.champsCodePromo)
        'Classement.SortASCCollection(dtSource, BDD.champsCodePromo)

        For Each rowD As DataRow In dtDest.Rows

            codePromo = CType(rowD.Item(BDD.champsCodePromo), String)


            Try
                rowS = dtSource.Rows(i)

                If (CType(rowS(BDD.champsCodeRat), String).Equals(codePromo)) Then


                    If CType(rowD(BDD.champsMOYEIN), Double).CompareTo(CType(rowS.Item(BDD.champsMOYERA), Double)) < 0 Then
                        rowD(BDD.champsMOYEIN) = rowS.Item(BDD.champsMOYERA)
                    End If
                End If



            Catch ex As Exception

            End Try

            i += 1

        Next


    End Sub

End Class
