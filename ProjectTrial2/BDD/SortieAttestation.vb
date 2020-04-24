
Public Class SortieAttestation

    Public Shared Function attestation(ByVal etud As Etudiant) As DataSet

        Dim dts As DataSet = New DataSet()                                  ' Le data set qui va contenir le résultat à retourner

        Dim champ As List(Of String) = New List(Of String)                  ' La liste des champs à rechercher 
        Dim cond As List(Of Critere) = New List(Of Critere)                 ' La liste des condition à verifier dans la recherche
        Dim tab1 As String = ""                                             ' Les noms de deux tableaux
        Dim tab2 As String = ""
        Dim requete As String = ""                                          'Le requete SQL
        Dim dt1 As DataTable = New DataTable(), dt2 As DataTable = New DataTable()                      'Les data tables a mettre dans le dataset
        Dim row As DataRow
        '____________________________
        champ.Add(BDD.champsMATRIN)                                         'Ajouter les noms des champs à rechercher dans la base
        champ.Add(BDD.champsAnnee)
        champ.Add(BDD.champsNiveau)
        champ.Add(BDD.champsOption)
        champ.Add(BDD.champsADM)


        cond.Add(New Critere(BDD.champsMATRIN, etud.getId()))               ' Ajouter le condition ( la valeur de matricule )

        tab1 = BDD.nomTableINSCRIPTION                                      ' Ajouter les noms des deux tableaux
        tab2 = BDD.nomTablePROMO

        requete = Class_BDD.genereRechRequete(champ, tab1, tab2, cond)      ' Générer le requète sql de recherche dans deux tableaux

        dt1 = (BDD.executeRequete(requete)).Copy()                          ' Mettre le résultat de recherche dans dt1
        ChangeVides(dt1)                                                    ' Effacer les vides dans dt1
        dts.Tables.Add(dt1)                                                 ' Ajouter dt1 au dataset
        '____________________________
        row = dt2.NewRow()                                                  'Créer un nouveau ligne row
        champ.Clear()
        champ.Add(BDD.champsMATRIN)                                         'Ajouter les champs à récuperer de l'étudiant
        champ.Add(BDD.champsNomEtud)
        champ.Add(BDD.champsPrenoms)
        champ.Add(BDD.champsDateNais)
        champ.Add(BDD.champsLieuNais)
        champ.Add(BDD.champsWILNAIS)
        ChangeVides(etud.InfosETUDIANT.Table)                               'Effacer les vides -> à Effacer si le problème des vides est réglé
        For Each colomn As String In champ                                  'Ajouter les champ et ses valeur au row
            dt2.Columns.Add(colomn, GetType(System.String))
            row(colomn) = etud.GetInfoChamps(colomn)
        Next
        dt2.Rows.Add(row)                                                   ' Mettre row dans dt2

        ChangeVides(dt2)                                                    ' Effacer les vides dans dt2
        dts.Tables.Add(dt2)                                                 ' Ajouter dt2 au dataset
        '____________________________
        Return dts                                                          ' Retourner le data set dts

    End Function

    Public Shared Sub ChangeVides(ByRef dt As DataTable)

        Dim defaut As Object = ""
        Dim colomnName As String = ""

        For Each colomn As DataColumn In dt.Columns
            colomnName = colomn.ColumnName
            Select Case colomn.DataType.ToString
                Case "System.String"
                    defaut = "_"
                Case GetType(Integer).ToString, GetType(Double).ToString
                    defaut = 0
                Case Else
                    defaut = "_"
            End Select
            For Each row As DataRow In dt.Rows
                If (row(colomnName).ToString).Equals("") Then
                    row(colomnName) = defaut
                End If
            Next
        Next

    End Sub

End Class
