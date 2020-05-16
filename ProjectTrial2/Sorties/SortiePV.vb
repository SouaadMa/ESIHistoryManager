Public Class SortiePV

    Public Shared bilan As String = ""

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


        '0) construction du code promo 
        CodePromo = Const_CodePromo(NIVEAU, OPTIN, ANNEE)
        '1)get from inscription ________________________________________________________________________

        champ.Add(BDD.champsMATRIN)    'BDD.nomTableEtudiant +
        champ.Add(BDD.champsCodePromo)
        champ.Add(BDD.champsMOYEIN)
        champ.Add(BDD.champsMENTIN)
        champ.Add(BDD.champsRANGIN)
        champ.Add(BDD.champsELIMININ)
        champ.Add(BDD.champsRATRIN)
        champ.Add(BDD.champsNomEtud)
        champ.Add(BDD.champsPrenoms)
        champ.Add(BDD.champsADM)

        'CodePromo = Const_CodePromo(NIVEAU, OPTIN, ANNEE)

        cond.Add(New Critere(BDD.champsCodePromo, CodePromo))
        'cond.Add(New Critere(BDD.champsMATRIN, "03/0041"))
        '____________________________________________________________________________________
        tab1 = BDD.nomTableINSCRIPTION
        tab2 = BDD.nomTableEtudiant


        requete = Class_BDD.genereRechRequete(champ, tab2, tab1, cond, True)

        dt1 = (BDD.executeRequete(requete))


        '2)get all subject  of this promo  _________________________________________________

        cond.Clear()


        Dim condition As Critere = New Critere(BDD.champsCodePromo, CodePromo)

        dt2 = BDD.GetALLChamps(BDD.champsCOMAMA, BDD.champsCOEFMA, condition)
        dt2 = Classement.SortDESCollection(dt2, BDD.champsCOEFMA)

        '3)get all "note' with 'matrin' for this promotion ________________________________________________()

        champ.Clear()
        champ.Add(BDD.champsMATRIN)
        champ.Add(BDD.champsNOJUNO)
        champ.Add(BDD.champsNORANO)
        champ.Add(BDD.champsCOMANO)



        cond.Add(New Critere(BDD.champsCodePromo, CodePromo))
        '__________________________________________________
        tab1 = BDD.nomTableMATIERE
        tab2 = BDD.nomTableNOTE


        requete = Class_BDD.genereRechRequete(champ, tab2, tab1, cond, True)

        dt3 = (BDD.executeRequete(requete))     '.Copy()



        '4)add champs of subject for each subject _______________________________________________

        For Each rows As DataRow In dt2.Rows
            dt1.Columns.Add(rows(BDD.champsCOMAMA), GetType(System.String))
            'MsgBox(rows("COMAMA"))
        Next



        '5)get all note de  ratrapage pour cette promotion  _______________________________________
        champ.Clear()
        champ.Add(BDD.champsMATRIN)
        champ.Add(BDD.champsMOYERA)
        champ.Add(BDD.champsMENTRA)


        cond.Add(New Critere(BDD.champsCodeRat, CodePromo))
        '__________________________________________________
        tab1 = BDD.nomTableINSCRIPTION
        tab2 = BDD.nomTableNoteRATRAP



        requete = Class_BDD.genereRechRequete(champ, tab1, tab2, cond, True)

        dt4 = (BDD.executeRequete(requete))         '.Copy()

        '5') ajouter la column du ratrapage
        dt1.Columns.Add("Moyenne Ratr", GetType(System.String))


        '6____________________________liaison entre dt1 et dt3 et dt4

        Dim NORANO As Integer
        For Each row1 As DataRow In dt1.Rows
            Try
                For Each row2 As DataRow In dt2.Rows
                    Try

                        row1(row2("COMAMA")) = dt3.Select("COMANO =  '" & row2("COMAMA") & "' and MATRIN = '" & row1("MATRIN") & "' ")(0)("NOJUNO")

                    Catch ex As Exception
                        bilan += "L'étudiant : MARICULE = " & row1("MATRIN") & " SA NOTE du " & row2("COMAMA") & "  n'existe pas dans la table NOTE  " & vbNewLine

                        '**************************************
                        'Throw New InvalidCastException

                    End Try
                Next
                row1("Moyenne Ratr") = ""
                row1("Moyenne Ratr") = dt4.Select("MATRIN = '" & row1("MATRIN") & "' ")(0)("MOYERA")

                If row1("Moyenne Ratr") <> "" Then
                    Console.WriteLine("MoyR")

                    If row1(BDD.champsMOYEIN) >= row1("Moyenne Ratr") Then
                        row1("Moyenne Ratr") = "_"

                    Else
                        row1(BDD.champsMENTIN) = dt4.Select("MATRIN = '" & row1("MATRIN") & "' ")(0)("MENTRA")

                        For Each row2 As DataRow In dt2.Rows

                            NORANO = dt3.Select("COMANO =  '" & row2("COMAMA") & "' and MATRIN = '" & row1("MATRIN") & "' ")(0)("NORANO")

                            If (NORANO > row1(row2("COMAMA"))) Then
                                row1(row2("COMAMA")) = NORANO
                            End If

                        Next

                    End If


                End If
            Catch ex As Exception
                Console.WriteLine("Exce")
                If (row1("RATRIN") > 0) Then
                    row1("Moyenne Ratr") = "_"
                    bilan += "L'étudiant : MARICULE = " & row1("MATRIN") & ", son RATRIN=" & row1("RATRIN") & " mais sa note de ratrapage n'existe pas dans la table NoteRATRAP " & vbNewLine

                Else
                    row1("Moyenne Ratr") = "_"

                End If
            End Try



        Next

        dts.Tables.Add(dt1.Copy())
        dts.Tables.Add(dt2.Copy())  'to bring the coeffs of each modules



        If dts Is Nothing Then
            Throw New InvalidCastException
        Else
            If dts.Tables(0).Rows.Count = 0 Then
                Throw New InvalidCastException
            End If
            If dts.Tables(1).Rows.Count = 0 Then
                Throw New NoMatierePVException
            End If
        End If

        Console.WriteLine(getBilan)

        ' fin ____________________________________
        Return dts




    End Function

    Public Shared Function getBilan() As String
        If bilan = "" Then
            Return "Tout est bien passé!"
        Else
            Return bilan
        End If
    End Function

End Class






