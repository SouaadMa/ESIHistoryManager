Public Class SortieRN

    Public dataSet As New DataSet
    Private nbreRN As Integer

    Public Sub New(ByVal etud As Etudiant, ByVal promo As String)

        'Récupération des informations stockées dans la collection dans l'objet Etudiant
        Dim dtEtud As New DataTable(BDD.nomTableEtudiant)
        Dim lignecomplete As DataRow = etud.InfosETUDIANT

        dtEtud.Columns.Add(BDD.champsNomEtud)
        dtEtud.Columns.Add(BDD.champsPrenoms)
        dtEtud.Columns.Add(BDD.champsMATRIN)

        dtEtud.Rows.Add({lignecomplete.Item(BDD.champsNomEtud), lignecomplete.Item(BDD.champsPrenoms), lignecomplete.Item(BDD.champsMATRIN)})
        '///////////////////////////////////////////////


        'Création de la collection des champs pour générer la requête01
        Dim listeChamps As New List(Of String)
        listeChamps.Add(BDD.champsLIBEMA)
        listeChamps.Add(BDD.champsNOJUNO)
        listeChamps.Add(BDD.champsNORANO)
        listeChamps.Add(BDD.champsCOEFMA)


        Dim listeConditions As New List(Of Critere)
        listeConditions.Add(New Critere(BDD.champsMATRIN, etud.GetInfoChamps(BDD.champsMATRIN)))
        listeConditions.Add(New Critere(BDD.champsCodePromo, promo))

        '************Récupération des notes*************'
        Dim tableNotesMat As New DataTable
        tableNotesMat = etud.GetNotesMat(listeChamps, listeConditions)
        '


        '***********************************************'
        'Création de la collection des champs pour générer la requête2
        listeChamps.Clear()
        listeChamps.Add(BDD.champsMOYEIN)
        listeChamps.Add(BDD.champsRANGIN)
        listeChamps.Add(BDD.champsADM)
        listeChamps.Add(BDD.champsNbreEtudiant)
        listeChamps.Add(BDD.champsMENTIN)
        listeChamps.Add(BDD.champsNBR_RN)


        '************Récupération des informations de l'inscription*************'
        Dim reqSQL As String = Class_BDD.genereRechRequete(listeChamps, BDD.nomTableINSCRIPTION, BDD.nomTablePROMO, listeConditions, True)
        Dim tableINSCRIPTION As DataTable = BDD.executeRequete(reqSQL)
        '

        '************Récuperation de la moyenne de Ratrappage*******************'
        listeChamps.Clear()
        listeChamps.Add(BDD.champsMOYERA)

        reqSQL = Rech_BDD.genereRechRequetes("", New Critere(BDD.champsMATRIN, etud.GetInfoChamps(BDD.champsMATRIN)), BDD.nomTableNoteRATRAP)
        reqSQL = Rech_BDD.genereRechRequetes(reqSQL, New Critere(BDD.champsCodeRat, promo), BDD.nomTableNoteRATRAP)

        Console.WriteLine(reqSQL)
        Dim tableRATTRAP As DataTable = BDD.executeRequete(reqSQL)

        '***********Ajout de la moyenne de Rattrapage à la table INSCRIPTION**********

        tableINSCRIPTION.Columns.Add(BDD.champsMOYERA)

        Try
            tableINSCRIPTION.Rows.Add()
            tableINSCRIPTION.Rows(0).Item(BDD.champsMOYERA) = tableRATTRAP.Rows(0).Item(BDD.champsMOYERA)

        Catch ex As Exception

            Console.WriteLine("Cet etudiant n'a pas d'informations dans la table NoteRATTRAP pour cette promo")

            tableINSCRIPTION.Rows(0).Item(BDD.champsMOYERA) = -1

            '***********'

        End Try
        


        Try
            nbreRN = CType(tableINSCRIPTION.Rows.Item(0).Item(BDD.champsNBR_RN), Integer)

        Catch ex As Exception
            Console.WriteLine("NBRERN")
            nbreRN = 0
        End Try
        
        Console.WriteLine(nbreRN)

        'Ajout du caractère spécial 99.99 à la place des notes qu'on ne veut pas afficher
        ArrangeRATTRA(tableNotesMat, 0.0)


        'Ajout des deux tables dans une DataSet
        'Etudiant
        dataSet.Tables.Add(dtEtud)
        'Notes + Matiere
        dataSet.Tables.Add(tableNotesMat)
        'INSCRIPTION + PROMO
        dataSet.Tables.Add(tableINSCRIPTION)

        'Form1.ds = dataSet
        'Form1.Show()

    End Sub

    Public Function GetDataSet() As DataSet
        Return dataSet
    End Function

    Public Function GetNbreRN() As Integer
        Return nbreRN
    End Function

    Public Sub SetNbreRN(ByVal etud As Etudiant, ByVal int As Integer, ByVal promo As String)

        Dim modification As New Critere(BDD.champsNBR_RN, int)
        Dim listeModif As New List(Of Critere)
        listeModif.Add(modification)

        Dim req As String
        req = Modif_BDD.genereModifRequete(etud.GetInfoChamps(BDD.champsMATRIN), listeModif, BDD.nomTableINSCRIPTION)
        req = Modif_BDD.AddCondition(req, New Critere(BDD.champsCodePromo, promo, BDD.nomTableINSCRIPTION))

        Console.WriteLine(req)

        BDD.executeRequete(req)
        nbreRN = int


    End Sub

    'Cette méthode passe par la dataTable et remplace les champs de rattrapage -si nécessaire-
    '  par car_remplacement

    Public Sub ArrangeRATTRA(ByVal dt As DataTable, ByVal car_remplacement As Double)


        For Each note As DataRow In dt.Rows

            If (CType(note.Item(BDD.champsNOJUNO), Double).CompareTo(CType(note.Item(BDD.champsNORANO), Double)) >= 0) Then


                note.Item(BDD.champsNORANO) = car_remplacement


            End If


        Next


    End Sub


End Class

