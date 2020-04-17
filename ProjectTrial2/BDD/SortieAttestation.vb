Public Class SortieAttestation

    Public Shared Function attestation(ByVal etud As Etudiant) As DataSet

        Dim dts As DataSet = New DataSet()

        Dim champ As List(Of String) = New List(Of String)
        Dim cond As List(Of Critere) = New List(Of Critere)
        Dim tab1 As String = ""
        Dim tab2 As String = ""
        Dim requete As String = ""
        Dim dt1 As DataTable = New DataTable(), dt2 As DataTable = New DataTable()
        Dim row As DataRow
        '____________________________
        champ.Add(BDD.champsMATRIN)
        champ.Add(BDD.champsAnnee)
        champ.Add(BDD.champsNiveau)
        champ.Add(BDD.champsOption)
        champ.Add(BDD.champsADM)

        cond.Add(New Critere(BDD.champsMATRIN, etud.getId()))

        tab1 = BDD.nomTableINSCRIPTION
        tab2 = BDD.nomTablePROMO

        requete = Class_BDD.genereRechRequete(champ, tab1, tab2, cond)

        dt1 = (BDD.executeRequete(requete)).Copy()
        ChangeVides(dt1)
        dts.Tables.Add(dt1)
        '____________________________
        row = dt2.NewRow()
        champ.Clear()
        champ.Add(BDD.champsMATRIN)
        champ.Add(BDD.champsNomEtud)
        champ.Add(BDD.champsPrenoms)
        champ.Add(BDD.champsDateNais)
        champ.Add(BDD.champsLieuNais)
        champ.Add(BDD.champsWILNAIS)
        For Each colomn As String In champ
            dt2.Columns.Add(colomn, GetType(System.String))
            row(colomn) = etud.GetInfoChamps(colomn)
        Next
        dt2.Rows.Add(row)

        ChangeVides(dt2)
        dts.Tables.Add(dt2)
        '____________________________
        Return dts

        'dt2.Columns.Add(BDD.champsNomEtud, GetType(System.String))
        'dt2.Columns.Add(BDD.champsPrenoms, GetType(System.String))
        'dt2.Columns.Add(BDD.champsDateNais, GetType(System.String))
        'dt2.Columns.Add(BDD.champsLieuNais, GetType(System.String))
        'dt2.Columns.Add(BDD.champsWILNAIS, GetType(System.String))
        'row = dt2.NewRow()
        'row(BDD.champsNomEtud) = etud.GetInfoChamps(BDD.champsNomEtud)
        'row(BDD.champsNomEtud) = etud.GetInfoChamps(BDD.champsNomEtud)
        'row(BDD.champsNomEtud) = etud.GetInfoChamps(BDD.champsNomEtud)
        'row(BDD.champsNomEtud) = etud.GetInfoChamps(BDD.champsNomEtud)

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
