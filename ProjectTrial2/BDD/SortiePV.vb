Public Class SortiePV


    Public Shared Function Const_CodePromo(ByVal NIVEAU As String, ByVal OPTIN As String, ByVal ANNEE As String) As String
        Dim Slash As String = "/"
        Dim CodePromo As String = NIVEAU & Slash & OPTIN & Slash & ANNEE
        Return CodePromo
    End Function



    Public Shared Function PV_DELIBERATION(ByVal NIVEAU As String, ByVal OPTIN As String, ByVal ANNEE As String) As DataSet

        Dim dts As DataSet = New DataSet()
        Dim CodePromo As String
        Dim champ As List(Of String) = New List(Of String)
        Dim cond As List(Of Critere) = New List(Of Critere)
        Dim tab1 As String = ""
        Dim tab2 As String = ""
        Dim requete As String = ""
        Dim dt1 As DataTable = New DataTable(), dt2 As DataTable = New DataTable(), dt3 As DataTable = New DataTable(), dt4 As DataTable = New DataTable()
        'Dim row As DataRow

        '1)get from inscription ________________________________________________________________________

        champ.Add(BDD.champsMATRIN)    'BDD.nomTableEtudiant +
        champ.Add(BDD.champsMOYEIN)
        champ.Add(BDD.champsMENTIN)
        champ.Add(BDD.champsRANGIN)
        champ.Add(BDD.champsELIMININ)
        champ.Add(BDD.champsRATRIN)
        champ.Add(BDD.champsNomEtud)
        champ.Add(BDD.champsPrenoms)
        champ.Add(BDD.champsADM)

        CodePromo = Const_CodePromo(NIVEAU, OPTIN, ANNEE)
        cond.Add(New Critere(BDD.champsCodePromo, CodePromo))
        '__________________________________________________
        tab1 = BDD.nomTableINSCRIPTION
        tab2 = BDD.nomTableEtudiant


        requete = Class_BDD.genereRechRequete(champ, tab2, tab1, cond, True)
        requete = requete.Insert(8, BDD.nomTableEtudiant + ".")
        requete = requete.Insert(requete.IndexOf("CodePromo"), BDD.nomTableINSCRIPTION + ".")
        dt1 = (BDD.executeRequete(requete)) '.Copy()



        '2)get all subject  of this promo  _________________________________________________

        cond.Clear()

        'cond.Add(New Critere(BDD.champsANETMA, NIVEAU))
        'cond.Add(New Critere(BDD.champsANSCMA, ANNEE))
        'cond.Add(New Critere(BDD.champsOPTIMA, OPTIN))

        Dim condition As Critere = New Critere("CodePromo", CodePromo)

        dt2 = BDD.GetALLChamps(BDD.champsCOMAMA, BDD.champsCOEFMA, condition)
        dt2 = Classement.SortDESCollection(dt2, BDD.champsCOEFMA)

        '3)get all note with matrin for this promotion ________________________________________________()
        champ.Clear()
        champ.Add(BDD.champsMATRIN)
        champ.Add(BDD.champsNOJUNO)
        'champ.Add(BDD.champsCOMAMA)
        champ.Add("COMANO")


        CodePromo = Const_CodePromo(NIVEAU, OPTIN, ANNEE)
        cond.Add(New Critere(BDD.champsCodePromo, CodePromo))
        '__________________________________________________
        tab1 = BDD.nomTableMATIERE
        tab2 = BDD.nomTableNOTE


        requete = Class_BDD.genereRechRequete(champ, tab2, tab1, cond, True)
        requete = requete.Insert(requete.IndexOf("CodePromo"), BDD.nomTableNOTE + ".")
        dt3 = (BDD.executeRequete(requete))     '.Copy()



        '4)add champs of subject for each subject _______________________________________________

        For Each rows As DataRow In dt2.Rows
            dt1.Columns.Add(rows("COMAMA"), GetType(System.String))

        Next

        GoTo NoNotes

        '5)get all note de  ratrapage pour cette promotion  _______________________________________
        champ.Clear()
        champ.Add(BDD.champsMATRIN)
        champ.Add(BDD.champsMOYERA)
        champ.Add(BDD.champsMENTRA)


        CodePromo = Const_CodePromo(NIVEAU, OPTIN, ANNEE)
        cond.Add(New Critere(BDD.champsCodePromo, CodePromo))
        '__________________________________________________
        tab1 = BDD.nomTableINSCRIPTION
        tab2 = BDD.nomTableNoteRATRAP



        requete = Class_BDD.genereRechRequete(champ, tab1, tab2, cond, True)

        dt4 = (BDD.executeRequete(requete))         '.Copy()

        'ajouter la column du ratrapage

NoNotes:

        '6____________________________laison entre dt1 et dt3 et dt4
        'Dim myRow() As DataRow
        For Each row1 As DataRow In dt1.Rows
            'la note 
            'For Each row3 As DataRow In dt3.Rows
            For Each row2 As DataRow In dt2.Rows
                'myRow = dt2.Select("COMAMA =  " & row2("COMAMA") & " and MATRIN = " & row1("MATRIN") & " ")
                row1(row2("COMAMA")) = dt3.Select("COMANO =  '" & row2("COMAMA") & "' and MATRIN = '" & row1("MATRIN") & "' ")(0)("NOJUNO")
                'row3(1)
            Next
            'la phase du ratrapage(select from dt4 where matrin = matrin and insert it in column ratrapage   
            'Next

        Next
        dt2.TableName = "DataTable2"
        dts.Tables.Add(dt1.Copy())
        dts.Tables.Add(dt2.Copy())  'to bring the coeffs of each modules

        'For Each ligne As DataRow In dts.Tables(0).Rows
        '    For Each col As DataColumn In dts.Tables(0).Columns
        '        Console.WriteLine(col.ColumnName + " = " + ligne(col.ColumnName).ToString + " " + ligne(col.ColumnName).GetType().ToString)
        '    Next
        'Next
        'Form1.DataGridView1.DataSource = dt1
        'Form1.Show()
        ' fin ____________________________________
        Return dts




    End Function



End Class






