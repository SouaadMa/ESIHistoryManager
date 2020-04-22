Public Class SortieRN

    Private dataSet As New DataSet
    Private nbreRN As Integer

    Public Sub New(ByVal etud As Etudiant, ByVal annee As String)

        'Récupération des informations stockées dans la collection dans l'objet Etudiant
        Dim dtEtud As New DataTable(BDD.nomTableEtudiant)
        Dim lignecomplete As DataRow = etud.InfosETUDIANT

        dtEtud.Columns.Add(lignecomplete.Item(BDD.champsNomEtud))
        dtEtud.Columns.Add(lignecomplete.Item(BDD.champsPrenoms))
        dtEtud.Columns.Add(lignecomplete.Item(BDD.champsMATRIN))


        'Création de la collection des champs pour générer la requête
        Dim listeChamps As New List(Of String)
        listeChamps.Add(BDD.champsLIBEMA)
        listeChamps.Add(BDD.champsNOJUNO)
        listeChamps.Add(BDD.champsNORANO)
        'A ajouter dans la Base
        'listeChamps.Add(BDD.champsRNPossible)

        Dim listeConditions As New List(Of Critere)
        listeConditions.Add(New Critere(BDD.champsMATRIN, etud.GetInfoChamps(BDD.champsMATRIN)))
        listeConditions.Add(New Critere(BDD.champsCodePromo, annee))

        '************Récupération des notes*************
        Dim tableNotesMat As New DataTable
        tableNotesMat = etud.GetNotesMat(listeChamps, listeConditions)


        ' Récuperation du nombre de Relevés de notes que cet étudiant a imprimé (pas encore ajouté à la BDD)
        'nbreRN = CType(tableNotesMat.Rows.Item(0).Item("NbreRN"), Integer)


        'Ajout du caractère spécial à la place des notes qu'on ne veut pas afficher
        'ArrangeRATTRA(tableNotesMat, "$")


        'Ajout des deux tables dans une DataSet
        'Etudiant
        dataSet.Tables.Add(dtEtud)
        'NotesMat
        dataSet.Tables.Add(tableNotesMat)


    End Sub

    Public Function GetDataSet() As DataSet
        Return dataSet
    End Function

    Public Function GetNbreRN() As Integer
        Return nbreRN
    End Function

    Public Sub SetNbreRN(ByVal etud As Etudiant, ByVal int As Integer)

        Dim modification As New Critere("NbreRN", int)
        Dim listeModif As New List(Of Critere)
        listeModif.Add(modification)

        Dim req As String
        req = Modif_BDD.genereModifRequete(etud.GetInfoChamps(BDD.champsMATRIN), listeModif)

        BDD.executeRequete(req)
        nbreRN = int


    End Sub

    'Cette méthode passe par la dataTable et remplace les champs de rattrapage -si nécessaire-
    ' et leur remplace par car_remplacement

    Public Sub ArrangeRATTRA(ByVal dt As DataTable, ByVal car_remplacement As String)


        For Each note As DataRow In dt.Rows

            If (CType(note.Item(BDD.champsNOJUNO), Double).CompareTo(CType(note.Item(BDD.champsNORANO), Double)) >= 0) Then


                note.Item(BDD.champsNORANO) = car_remplacement


            End If


        Next


    End Sub


End Class

