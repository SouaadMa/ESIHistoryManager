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
        Dim row As DataRow

        '1)get from inscription ________________________________________________________________________

        champ.Add(BDD.champsMATRIN)
        champ.Add(BDD.champsMOYEIN)
        champ.Add(BDD.champsMENTIN)
        champ.Add(BDD.champsRANGIN)
        champ.Add(BDD.champsELIMININ)
        champ.Add(BDD.champsRATRIN)
        champ.Add(BDD.champsNomEtud)
        champ.Add(BDD.champsPrenoms)

        CodePromo = Const_CodePromo(NIVEAU, OPTIN, ANNEE)
        cond.Add(New Critere(BDD.champsCodePromo, CodePromo))
        '__________________________________________________
        tab1 = BDD.nomTableINSCRIPTION
        tab2 = BDD.nomTableEtudiant


        requete = Class_BDD.genereRechRequete(champ, tab2, tab1, cond)

        dt1 = (BDD.executeRequete(requete)).Copy()



        '2)get all subject  of this promo  _________________________________________________


       
        Dim condition As Critere = New Critere("CodePromo", CodePromo)
        
        dt2 = BDD.GetALLChamps(BDD.champsCOMAMA, BDD.champsCOEFMA, condition)



        '3)get all note with matrin for this promotion ________________________________________________()
        champ.Clear()
        champ.Add(BDD.champsMATRIN)
        champ.Add(BDD.champsNOJUNO)
        champ.Add("COMANO")
       

        CodePromo = Const_CodePromo(NIVEAU, OPTIN, ANNEE)
        cond.Add(New Critere(BDD.champsCodePromo, CodePromo))
        '__________________________________________________
        tab1 = BDD.nomTableMATIERE
        tab2 = BDD.nomTableNOTE


        requete = Class_BDD.genereRechRequete(champ, tab1, tab2, cond)

        dt3 = (BDD.executeRequete(requete)).Copy()



        '4)add champs of subject for each subject _______________________________________________

        For Each rows As DataRow In dt2.Rows
            dt1.Columns.Add(rows("COMAMA"), GetType(System.String))

        Next

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



        requete = Class_BDD.genereRechRequete(champ, tab1, tab2, cond)

        dt4 = (BDD.executeRequete(requete)).Copy()

        'ajouter la column du ratrapage

        '6____________________________laison entre dt1 et dt3 et dt4
        Dim myRow() As DataRow
        For Each rows As DataRow In dt1.Rows
            'la note 
            For Each row2 As DataRow In dt2.Rows
                myRow = dt3.Select("COMAMA =  " & row2("COMAMA") & " and MATRIN= " & rows("MATRIN") & " ")
                For Each row3 As DataRow In myRow
                    rows(row2("COMAMA")) = row3(1)
                Next
                'la phase du ratrapage(select from dt4 where matrin = matrin and insert it in column ratrapage   
            Next

        Next
        dts.Tables.Add(dt1)
        ' fin ____________________________________
        Return dts



       
    End Function

  

End Class






