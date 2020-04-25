﻿Public Class SortieRN

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
        listeChamps.Add(BDD.champsNBR_RN)

        '************Récupération des informations de l'inscription*************'
        Dim reqSQL As String = Class_BDD.genereRechRequete(listeChamps, BDD.nomTableINSCRIPTION, BDD.nomTablePROMO, listeConditions)
        Dim tableINSCRIPTION As DataTable = BDD.executeRequete(reqSQL)
        '


        nbreRN = CType(tableINSCRIPTION.Rows.Item(0).Item(BDD.champsNBR_RN), Integer)


        'Ajout du caractère spécial à la place des notes qu'on ne veut pas afficher
        ArrangeRATTRA(tableNotesMat, "$")


        'Ajout des deux tables dans une DataSet
        'Etudiant
        dataSet.Tables.Add(dtEtud)
        'Notes + Matiere
        dataSet.Tables.Add(tableNotesMat)
        'INSCRIPTION + PROMO
        dataSet.Tables.Add(tableINSCRIPTION)


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


        BDD.executeRequete(req)
        nbreRN = int


    End Sub

    'Cette méthode passe par la dataTable et remplace les champs de rattrapage -si nécessaire-
    '  par car_remplacement

    Public Sub ArrangeRATTRA(ByVal dt As DataTable, ByVal car_remplacement As String)


        For Each note As DataRow In dt.Rows

            If (CType(note.Item(BDD.champsNOJUNO), Double).CompareTo(CType(note.Item(BDD.champsNORANO), Double)) >= 0) Then


                note.Item(BDD.champsNORANO) = car_remplacement


            End If


        Next


    End Sub


End Class

