Imports System.Data.OleDb
Imports Microsoft.VisualBasic.ApplicationServices

Public Class ECLATEMENT

    Dim cnx As OleDbConnection           ' la connection 
    Dim cmd As OleDbCommand              ' la commande
    Dim ta As OleDbDataAdapter           ' le Data Adapter
    Dim dts As New DataSet          ' le Data Set
    Dim ST As String = "/"
    Dim REQUETE, CONDITION, SQL1, SQL2, Champs, CnxSource As String
    Dim strProvider As String, strSQL As String, intResult As Integer



    Public Sub ECLATEMENT(ByVal F_ACCESS As String, ByVal EXCEL_INSCRIT As String, ByVal EXCEL_NOTE As String, ByVal EXCEL_MATIERE As String, ByVal EXCEL_RATRAP As String)

        Call ECLATEMENT_NORMAL(F_ACCESS, EXCEL_INSCRIT, EXCEL_NOTE, EXCEL_MATIERE, EXCEL_RATRAP)
        Call ECLATEMENT_ACV(F_ACCESS, EXCEL_INSCRIT, EXCEL_NOTE, EXCEL_MATIERE, EXCEL_RATRAP)
        Call DOUBLES(F_ACCESS, EXCEL_INSCRIT, EXCEL_NOTE, EXCEL_MATIERE, EXCEL_RATRAP)

    End Sub


    Public Sub ECLATEMENT_NORMAL(ByVal F_ACCESS As String, ByVal EXCEL_INSCRIT As String, ByVal EXCEL_NOTE As String, ByVal EXCEL_MATIERE As String, ByVal EXCEL_RATRAP As String)
        Call Eclatement_FROM_EXCEL("INSCRIPTION", F_ACCESS, EXCEL_INSCRIT)
        Call Eclatement_FROM_EXCEL("ETUDIANT", F_ACCESS, EXCEL_INSCRIT)
        Call Eclatement_FROM_EXCEL("MATIERE", F_ACCESS, EXCEL_MATIERE)
        Call Eclatement_FROM_EXCEL("NOTES", F_ACCESS, EXCEL_NOTE)
        Call Eclatement_FROM_EXCEL("NOTERATRAP", F_ACCESS, EXCEL_RATRAP)
        Call Eclatement_FROM_EXCEL("RATRAP", F_ACCESS, EXCEL_RATRAP)
        Call Eclatement_FROM_ACCESS("GROUPE", F_ACCESS)
        Call Eclatement_FROM_ACCESS("SECTIONS", F_ACCESS)
        Call Eclatement_FROM_ACCESS("PROMO", F_ACCESS)
        Call Eclatement_FROM_ACCESS("UPDATE_PROMO", F_ACCESS)
    End Sub


    Public Sub Eclatement_FROM_ACCESS(ByVal TABLE As String, ByVal F_ACCESS As String)



        cnx = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & F_ACCESS & ".accdb")

        Try
            cnx.Open()                   ' ouvrir la connection avec la base de donnée
            Try

                Select Case TABLE


                    Case "GROUPE"
                        REQUETE = "INSERT INTO GROUPE(CodeGroupe,CodeSection,CodePromo) SELECT DISTINCT CodeGroupe,CodeSection, CodePromo FROM INSCRIPTION WHERE NOT EXISTS(SELECT CodeGroupe FROM GROUPE WHERE  CodeGroupe=INSCRIPTION.CodeGroupe AND CodeSection= INSCRIPTION.CodeSection AND CodePromo= INSCRIPTION.CodePromo) "

                    Case "SECTIONS"
                        REQUETE = "INSERT INTO SECTIONS SELECT DISTINCT  CodeSection AS CodeSection ,  CodePromo AS CodePromo  FROM GROUPE WHERE NOT EXISTS(SELECT CodeSection FROM SECTIONS WHERE   CodeSection= GROUPE.CodeSection AND CodePromo= GROUPE.CodePromo)  "

                    Case "PROMO"
                        REQUETE = "INSERT INTO PROMO(CodePromo,Niveau,Optin,Annee,NbreEtudiant) SELECT  CodePromo,Mid ([CodePromo],1,1),MID (CodePromo,3,3),Right(CodePromo,2),COUNT(CodePromo) FROM INSCRIPTION where NOT EXISTS(SELECT CodePromo from PROMO WHERE CodePromo=INSCRIPTION.CodePromo)  GROUP BY CodePromo "

                    Case "UPDATE_PROMO"
                        REQUETE = "UPDATE PROMO  SET Optin='SI' WHERE Optin='SI/' "





                End Select



                cmd = New OleDbCommand(REQUETE, cnx)

                ta = New OleDbDataAdapter(cmd)

                ta.Fill(dts) ' fill le data set par le résultat de l'éxécution de requete ( de data adapter ) 
                MsgBox(TABLE)

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

            cnx.Close()
        Catch ex As Exception
            MsgBox(" Connection not openning ! ")
        End Try
    End Sub




    Public Sub Eclatement_FROM_EXCEL(ByVal TABLE As String, ByVal F_ACCESS As String, ByVal F_EXCEL As String)

        Try

            Select Case TABLE

                Case "ETUDIANT"
                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[ETUDIANT]  SELECT "
                    Champs = " MATRIN AS MATRIN,min(NomEtud) AS NomEtud,min(Prenoms) AS Prenoms ,min(NomEtudA) AS NomEtudA,min(PrenomsA) AS PrenomsA,min(MATRIC_INS) AS MATRIC_INS, min(DATENAIS) AS DateNais,min(LIEUNAISA) AS LieuNaisA ,min(WILNAISA) AS WilayaNaisA,min(LIEUNAIS) AS LieuNais, min(ADRESSE) AS ADRESSE, min(VILLE) AS VILLE, min(WILAYA) AS WILAYA , min(CODPOST) as CODEPOS,min(WILBAC) AS WILBAC,min(SERIEBAC) AS SERIEBAC, min(FILS_DE) AS FILS_DE,min(ET_DE) AS ET_DE,min(SEXE) AS  SEXE,min(WILNAIS) AS WILNAIS,min(MOYBAC) as MOYBAC ,min(ANNEEBAC) as ANNEEBAC "
                    SQL2 = " From [INSCRIT$] where  MATRIN IS NOT NULL AND   MATRIC_INS IS NOT NULL  AND DATENAIS IS NOT NULL AND LIEUNAISA IS NOT NULL AND WILNAISA IS NOT NULL AND LIEUNAIS IS NOT NULL AND WILNAIS IS NOT NULL AND  ADRESSE IS NOT NULL AND CODPOST IS NOT NULL   AND VILLE IS NOT NULL AND WILAYA IS NOT NULL  AND WILBAC IS NOT NULL AND MOYBAC IS NOT NULL AND ANNEEBAC IS NOT NULL AND SERIEBAC IS NOT NULL AND SEXE IS NOT NULL AND  FILS_DE IS NOT NULL AND ET_DE IS NOT NULL AND NOT EXISTS  (SELECT MATRIN FROM [MS Access;Database=" & F_ACCESS & ".accdb].[ETUDIANT]  WHERE MATRIN=ETUDIANT.MATRIN )  GROUP BY (MATRIN)    "
                    REQUETE = SQL1 & Champs & SQL2
                    'AND  NomEtud  IS NOT NULL AND  Prenoms  IS NOT NULL AND  NomEtudA IS NOT NULL AND  PrenomsA IS NOT NULL 


                Case "INSCRIPTION"
                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""

                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[INSCRIPTION] SELECT "
                    Champs = "MATRIN AS MATRIN ,NG AS CodeGroupe,NS AS CodeSection,ANETIN&'" & ST & "'&OPTIIN&'" & ST & "'&ANSCIN AS CodePromo ,min(MOYEIN) AS MOYEIN,min(RANGIN) AS RANGIN,min(MENTIN) AS MENTIN,min(ELIMIN) AS ELIMININ,min(RATRIN) AS RATRIN,min(DECIIN) AS DECIIN,min(ADM) AS ADM ,min(DEC) AS DECI"
                    SQL2 = " From [INSCRIT$]   where  MATRIN IS NOT NULL AND NG IS NOT NULL  AND NS IS NOT NULL  AND  ANETIN IS NOT NULL AND OPTIIN IS NOT NULL  AND ANSCIN IS NOT NULL AND MOYEIN IS NOT NULL AND RANGIN IS NOT NULL AND MENTIN IS NOT NULL AND ELIMIN IS NOT NULL  AND RATRIN IS NOT NULL  AND DECIIN IS NOT NULL  AND ADM IS NOT NULL AND DEC  IS NOT NULL AND  NOT  EXISTS (SELECT MATRIN  FROM [MS Access;Database=" & F_ACCESS & ".accdb].[INSCRIPTION]  WHERE MATRIN=INSCRIPTION.MATRIN and CodePromo=ANETIN&'/'&OPTIIN&'/'&ANSCIN) GROUP BY MATRIN,NG,NS, ANETIN ,ANSCIN , OPTIIN"
                    REQUETE = SQL1 & Champs & SQL2

                    'a enleve 
                    'Case "PROMO"
                    '   strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    '  SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[PROMO] SELECT "
                    ' Champs = "COUNT(*) AS  NbreEtudiant,ANETIN AS Niveau , OPTIIN AS Optin , ANSCIN AS Annee,ANETIN&'" & ST & "'&OPTIIN&'" & ST & "'&ANSCIN AS CodePromo  "
                    'SQL2 = "FROM [INSCRIT$] WHERE ANETIN is NOT NULL AND OPTIIN IS NOT NULL AND ANSCIN IS NOT NULL  GROUP BY OPTIIN,ANETIN,ANSCIN "
                    '
                    'REQUETE = SQL1 & Champs & SQL2



                Case "MATIERE"

                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[MATIERE]  SELECT "
                    Champs = " COMAMA&'" & ST & "'&ANETMA&'" & ST & "'&OPTIMA&'" & ST & "'&ANSCMA   AS CodeMat  ,ANETMA&'" & ST & "'&OPTIMA&'" & ST & "'&ANSCMA AS CodePromo ,COMAMA AS COMAMA,min(CYCLMA) AS CYCLMA, min(LIBEMA) as LIBEMA  ,min(TYPEMA) AS TYPEMA , min(COEFMA) AS COEFMA ,min(MOYMAT) AS MOYMAT  "
                    SQL2 = " From [MATIERE$] where  CYCLMA is NOT NULL AND OPTIMA IS NOT NULL AND  COMAMA IS NOT NULL AND   LIBEMA IS NOT NULL AND   TYPEMA IS NOT NULL AND   ANSCMA IS NOT NULL AND   ANETMA IS NOT NULL AND   COEFMA IS NOT NULL AND   MOYMAT IS NOT NULL  AND  NOT  EXISTS (SELECT CodeMat  FROM [MS Access;Database=" & F_ACCESS & ".accdb].[MATIERE]  WHERE CodeMat=COMAMA&'/'&ANETMA&'/'&OPTIMA&'/'&ANSCMA) GROUP BY COMAMA,ANSCMA,ANETMA,OPTIMA   "
                    REQUETE = SQL1 & Champs & SQL2



                Case "NOTES"
                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[NOTES]  SELECT "
                    Champs = " COMANO&'" & ST & "'&ANETNO&'" & ST & "'&OPTINO&'" & ST & "'&ANSCNO  AS CodeMat ,ANETNO&'" & ST & "'&OPTINO&'" & ST & "'&ANSCNO as CodePromo   ,COMANO AS COMANO,MATRNO AS MATRIN ,min(NOJUNO) as NOJUNO ,min(NOSYNO) AS NOSYNO ,MIN(NORANO) AS NORANO,min(ELIMNO) AS ELIMNO ,min(RATRNO) AS RATRNO  "
                    SQL2 = " From [NOTE$] WHERE  MATRNO iS NOT NULL and COMANO IS NOT NULL AND ANSCNO IS NOT NULL AND OPTINO IS NOT NULL AND ANETNO IS NOT NULL AND NOJUNO IS NOT NULL AND NOSYNO IS NOT NULL AND NORANO IS NOT NULL   AND NOT  EXISTS (SELECT MATRIN  FROM [MS Access;Database=" & F_ACCESS & ".accdb].[NOTES] WHERE  MATRIN=MATRNO AND (CodeMat=COMANO&'/'&ANETNO&'/'&OPTINO&'/'&ANSCNO))    GROUP BY COMANO,ANSCNO,OPTINO,ANETNO,MATRNO"
                    REQUETE = SQL1 & Champs & SQL2


                Case "RATRAP"
                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[RATRAP]  SELECT "
                    Champs = "DISTINCT  ANETRA&'" & ST & "'&OPTIRA&'" & ST & "'&ANSCRA AS CodeRat ,ANSCRA as ANSCRA   ,ANETRA AS ANETRA ,CYCLRA as CYCLRA ,OPTIRA AS OPTIRA "
                    SQL2 = " From [RATRAP$] WHERE ANETRA is not NULL  AND ANSCRA IS NOT NULL AND CYCLRA IS NOT NULL AND OPTIRA IS NOT NULL AND NOT  EXISTS (SELECT CodeRat  FROM [MS Access;Database=" & F_ACCESS & ".accdb].[RATRAP]  WHERE  CodeRAT=ANETRA&'/'&OPTIRA&'/'&ANSCRA)"
                    REQUETE = SQL1 & Champs & SQL2



                Case "NOTERATRAP"

                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[NoteRATRAP]  SELECT "
                    Champs = " ANETRA&'" & ST & "'&OPTIRA&'" & ST & "'&ANSCRA  AS CodeRat ,MATRRA as MATRIN   ,MIN(MOYERA) AS MOYERA ,MIN(MENTRA) AS MENTRA ,MIN(ELIMRA) AS ELIMRA"
                    SQL2 = " From [RATRAP$] WHERE ANETRA IS NOT NULL AND OPTIRA IS NOT NULL AND ANSCRA IS NOT NULL AND MENTRA  is not NULL  AND MATRRA IS NOT NULL AND MOYERA IS NOT NULL AND ELIMRA IS NOT NULL AND NOT  EXISTS (SELECT MATRIN  FROM [MS Access;Database=" & F_ACCESS & ".accdb].[NoteRATRAP]  WHERE MATRIN=MATRRA AND CodeRAT=ANETRA&'/'&OPTIRA&'/'&ANSCRA) GROUP BY MATRRA, ANSCRA,ANETRA,OPTIRA"
                    REQUETE = SQL1 & Champs & SQL2



            End Select

            Using myCon As New OleDb.OleDbConnection(strProvider)
                Using myCmd As New OleDb.OleDbCommand(REQUETE, myCon)
                    myCon.Open()
                    intResult = myCmd.ExecuteNonQuery()
                End Using '...myCmd
            End Using '...myCon
            MessageBox.Show(TABLE)


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub

    '*******************************************************************************************************************************************
    '**********************************ECLATEMENT A CHAMP VIDE *********************************************************************************
    '
    Public Sub ECLATEMENT_ACV(ByVal F_ACCESS As String, ByVal EXCEL_INSCRIT As String, ByVal EXCEL_NOTE As String, ByVal EXCEL_MATIERE As String, ByVal EXCEL_RATRAP As String)

        Call Eclatement_FROM_EXCEL_ACV("INSCRIPTION", F_ACCESS, EXCEL_INSCRIT)
        Call Eclatement_FROM_EXCEL_ACV("ETUDIANT", F_ACCESS, EXCEL_INSCRIT)
        Call Eclatement_FROM_EXCEL_ACV("MATIERE", F_ACCESS, EXCEL_MATIERE)
        Call Eclatement_FROM_EXCEL_ACV("NOTES", F_ACCESS, EXCEL_NOTE)
        Call Eclatement_FROM_EXCEL_ACV("NOTERATRAP", F_ACCESS, EXCEL_RATRAP)
    End Sub
    '**********************************************************************************************************************************************


    Public Sub Eclatement_FROM_EXCEL_ACV(ByVal TABLE As String, ByVal F_ACCESS As String, ByVal F_EXCEL As String)

        Try

            Select Case TABLE


                Case "INSCRIPTION"
                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""

                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[INSCRIPTION_ACV] SELECT "
                    Champs = "MATRIN AS MATRIN ,NG AS NG,NS AS NS,ANETIN AS ANETIN,OPTIIN AS OPTIIN ,ANSCIN AS ANSCIN, MOYEIN AS MOYEIN,RANGIN AS RANGIN,MENTIN AS MENTIN,ELIMIN AS ELIMININ,RATRIN AS RATRIN,DECIIN AS DECIIN,ADM AS ADM ,DEC AS DECI"
                    SQL2 = " From [INSCRIT$]   where MATRIN IS  NULL OR NG IS  NULL OR NS IS  NULL OR ANETIN is  NULL OR OPTIIN IS  NULL OR ANSCIN IS  NULL OR MOYEIN IS  NULL OR RANGIN IS NULL OR MENTIN IS NULL OR ELIMIN IS NULL OR RATRIN IS  NULL OR DECIIN IS NULL OR ADM IS  NULL OR DEC IS  NULL  "
                    REQUETE = SQL1 & Champs & SQL2


                Case "ETUDIANT"
                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[ETUDIANT_ACV]  SELECT "
                    Champs = " MATRIN AS MATRIN,min(NomEtud) AS NomEtud,min(Prenoms) AS Prenoms ,min(NomEtudA) AS NomEtudA,min(PrenomsA) AS PrenomsA,min(MATRIC_INS) AS MATRIC_INS, min(DATENAIS) AS DateNais,min(LIEUNAISA) AS LieuNaisA ,min(WILNAISA) AS WilayaNaisA,min(LIEUNAIS) AS LieuNais, min(ADRESSE) AS ADRESSE, min(VILLE) AS VILLE, min(WILAYA) AS WILAYA , min(CODPOST) as CODEPOS,min(WILBAC) AS WILBAC,min(SERIEBAC) AS SERIEBAC, min(FILS_DE) AS FILS_DE,min(ET_DE) AS ET_DE,min(SEXE) AS  SEXE,min(WILNAIS) AS WILNAIS,min(MOYBAC) as MOYBAC ,min(ANNEEBAC) as ANNEEBAC "
                    SQL2 = " From [INSCRIT$] where  MATRIN IS  NULL OR NomEtud IS NULL OR  Prenoms is  null OR NomEtudA IS null OR PrenomsA is  null OR  MATRIC_INS IS  NULL OR DATENAIS IS  NULL OR LIEUNAISA IS  NULL OR WILNAISA IS  NULL OR LIEUNAIS IS  NULL OR WILNAIS IS  NULL OR  ADRESSE IS  NULL OR CODPOST IS NULL  OR  VILLE IS  NULL OR WILAYA IS  NULL OR WILBAC IS  NULL OR MOYBAC IS  NULL OR ANNEEBAC IS  NULL OR SEXE IS NULL OR SERIEBAC IS NULL  OR FILS_DE IS NULL OR ET_DE IS  NULL   GROUP BY (MATRIN)    "
                    REQUETE = SQL1 & Champs & SQL2


                Case "MATIERE"

                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[MATIERE_ACV]  SELECT "
                    Champs = " COMAMA AS COMAMA ,  ANETMA AS ANETMA , OPTIMA  AS OPTIMA ,ANSCMA AS ANSCMA , CYCLMA AS CYCLMA, LIBEMA as LIBEMA  ,TYPEMA AS TYPEMA , COEFMA AS COEFMA ,MOYMAT AS MOYMAT  "
                    SQL2 = " From [MATIERE$] where  CYCLMA is NULL OR OPTIMA IS  NULL OR  COMAMA IS  NULL OR   LIBEMA IS  NULL OR   TYPEMA IS  NULL OR ANSCMA IS  NULL OR  ANETMA IS  NULL OR  COEFMA IS  NULL OR MOYMAT IS   NULL   "
                    REQUETE = SQL1 & Champs & SQL2



                Case "NOTES"
                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[NOTES_ACV]  SELECT "
                    Champs = "ANETNO AS ANETNO , OPTINO  AS OPTINO ,ANSCNO AS ANSCNO ,COMANO AS COMANO,MATRNO AS MATRNO ,NOJUNO as NOJUNO ,NOSYNO AS NOSYNO ,NORANO AS NORANO,ELIMNO AS ELIMNO ,RATRNO AS RATRNO  "
                    SQL2 = " From [NOTE$] WHERE  MATRNO iS  NULL OR COMANO IS  NULL OR ANSCNO IS NULL OR OPTINO IS  NULL OR ANETNO IS  NULL OR NOJUNO IS  NULL OR NOSYNO IS  NULL OR NORANO IS  NULL OR ELIMNO IS  NULL OR RATRNO IS  NULL   "
                    REQUETE = SQL1 & Champs & SQL2


                Case "NOTERATRAP"

                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[NoteRATRAP_ACV]  SELECT "
                    Champs = "ANETRA AS ANETRA, OPTIRA AS OPTIRA , ANSCRA  AS ANSCRA ,MATRRA as MATRRA   ,MOYERA AS MOYERA ,MENTRA  as MENTRA ,ELIMRA AS ELIMRA"
                    SQL2 = " From [RATRAP$] WHERE ANETRA IS NULL OR OPTIRA IS NULL OR  ANSCRA IS NULL OR MENTRA is  NULL OR MATRRA IS NULL OR MOYERA IS  NULL OR ELIMRA IS  NULL"
                    REQUETE = SQL1 & Champs & SQL2



            End Select

            Using myCon As New OleDb.OleDbConnection(strProvider)
                Using myCmd As New OleDb.OleDbCommand(REQUETE, myCon)
                    myCon.Open()
                    intResult = myCmd.ExecuteNonQuery()
                End Using '...myCmd
            End Using '...myCon
            MessageBox.Show("finish")


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub
    '***************************************************************************************************************************************************
    '**************************************LES ENREGISTREMENT DOUBLES **********************************************************************************
    Public Sub DOUBLES(ByVal F_ACCESS As String, ByVal EXCEL_INSCRIT As String, ByVal EXCEL_NOTE As String, ByVal EXCEL_MATIERE As String, ByVal EXCEL_RATRAP As String)
        Call ENRG_DOUBLES("INSCRIPTION", F_ACCESS, EXCEL_INSCRIT)
        Call ENRG_DOUBLES("NOTES", F_ACCESS, EXCEL_NOTE)
        Call ENRG_DOUBLES("MATIERE", F_ACCESS, EXCEL_MATIERE)
        Call ENRG_DOUBLES("NOTERATRAP", F_ACCESS, EXCEL_RATRAP)
    End Sub
    '*******************************************************************************************************************************************************

    Public Sub ENRG_DOUBLES(ByVal TABLE As String, ByVal F_ACCESS As String, ByVal F_EXCEL As String)

        Try

            Select Case TABLE





                Case "INSCRIPTION"
                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""

                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[INSCRIPTION_DOUBLES] SELECT "
                    Champs = "COUNT(MATRIN) as NBR_DOUBLON, MATRIN AS MATRIN ,NG AS NG,NS AS NS,ANETIN AS ANETIN ,ANSCIN AS ANSCIN, OPTIIN AS OPTIIN ,min(MOYEIN) AS MOYEIN,min(RANGIN) AS RANGIN,min(MENTIN) AS MENTIN,min(ELIMIN) AS ELIMININ,min(RATRIN) AS RATRIN,min(DECIIN) AS DECIIN,min(ADM) AS ADM ,min(DEC) AS DECI"
                    SQL2 = " From [INSCRIT$] GROUP BY MATRIN,NG,NS, ANETIN ,ANSCIN , OPTIIN   HAVING COUNT(*)>1  "
                    REQUETE = SQL1 & Champs & SQL2



                Case "MATIERE"

                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[MATIERE_DOUBLES]  SELECT "
                    Champs = "COUNT(COMAMA) AS NBR_DOUBLON , COMAMA AS COMAMA ,  ANETMA AS ANETMA , OPTIMA  AS OPTIMA ,ANSCMA AS ANSCMA , min(CYCLMA) AS CYCLMA, min(LIBEMA) as LIBEMA  ,min(TYPEMA) AS TYPEMA , min(COEFMA) AS COEFMA ,min(MOYMAT) AS MOYMAT  "
                    SQL2 = " From [MATIERE$]   GROUP BY OPTIMA , ANSCMA , ANETMA ,COMAMA HAVING COUNT(*)>1  "
                    REQUETE = SQL1 & Champs & SQL2


                Case "NOTES"
                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[NOTES_DOUBLES] SELECT "
                    Champs = "COUNT(MATRNO) AS NBR_DOUBLON,MATRNO AS MATRNO , ANETNO AS ANETNO,ANSCNO AS ANSCNO ,OPTINO AS OPTINO,COMANO AS COMANO ,min(NOJUNO) AS NOJUNO, min(NORANO) AS NORANO ,min(ELIMNO) as ELIMNO"
                    SQL2 = " From [NOTE$] GROUP BY COMANO,MATRNO,ANETNO,ANSCNO,OPTINO HAVING   COUNT(*) > 1  "
                    REQUETE = SQL1 & Champs & SQL2  '

                Case "NOTERATRAP"

                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[NoteRATRAP_DOUBLES]  SELECT "
                    Champs = "COUNT (ANETRA) AS NBR_DOUBLON,  ANETRA  AS ANETRA, OPTIRA AS OPTIRA , ANSCRA  AS ANSCRA ,MATRRA as MATRRA   ,min(MOYERA) AS MOYERA ,min(MENTRA)  as MENTRA ,min(ELIMRA) AS ELIMRA"
                    SQL2 = " From [RATRAP$]  GROUP BY MATRRA, ANSCRA,ANETRA,OPTIRA  HAVING   COUNT(*) > 1  "
                    REQUETE = SQL1 & Champs & SQL2


            End Select

            Using myCon As New OleDb.OleDbConnection(strProvider)
                Using myCmd As New OleDb.OleDbCommand(REQUETE, myCon)
                    myCon.Open()
                    intResult = myCmd.ExecuteNonQuery()
                End Using '...myCmd
            End Using '...myCon
            MessageBox.Show("finish")


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub

    '*********************************************************************************************************************************************
    '**********************************************  RECHARGEMENT ********************************************************************************
    '*********************************************************************************************************************************************


    Public Sub RECHARGEMENT(ByVal F_ACCESS As String)

        Call RECHARGEMENT_FROM_ACV(F_ACCESS)
        Call FILTRE_ACV(F_ACCESS)

    End Sub
    Public Sub RECHARGEMENT_FROM_ACV(ByVal F_ACCESS As String)

        Call RECHARGEMENT_TABLE("ETUDIANT", F_ACCESS)
        Call RECHARGEMENT_TABLE("INSCRIPTION", F_ACCESS)
        Call RECHARGEMENT_TABLE("GROUPE", F_ACCESS)
        Call RECHARGEMENT_TABLE("SECTIONS", F_ACCESS)
        Call RECHARGEMENT_TABLE("pre_PROMO", F_ACCESS)
        Call RECHARGEMENT_TABLE("PROMO", F_ACCESS)
        Call RECHARGEMENT_TABLE("NOTES", F_ACCESS)
        Call RECHARGEMENT_TABLE("MATIERE", F_ACCESS)
        Call RECHARGEMENT_TABLE("NoteRATRAP", F_ACCESS)

    End Sub

    Public Sub RECHARGEMENT_TABLE(ByVal TABLE As String, ByVal F_ACCESS As String)

        ''************************la fonction qui fait le RECHARGEMENT de la table 'TABLE' à partir des Tables A CHAMPS VIDES*****************************' 
        cnx = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & F_ACCESS & ".accdb")

        Try
            cnx.Open()                   ' ouvrir la connection avec la base de donnée
            Try

                Select Case TABLE


                    Case "ETUDIANT"

                        REQUETE = "INSERT  INTO ETUDIANT SELECT MATRIN AS MATRIN, min(NomEtud) AS NomEtud ,min(Prenoms) AS prenoms , min(NomEtudA) AS NomEtudA, min(PrenomsA) as PrenomsA ,min(MATRIC_INS) AS MATRIC_INS, min(DateNais) AS DateNais,min(LieuNaisA) AS LieuNaisA ,min(WilayaNaisA) AS WilayaNaisA,min(LieuNais) AS LieuNais, min(ADRESSE) AS ADRESSE, min(VILLE) AS VILLE, min(WILAYA) AS WILAYA , min(CODEPOS) as CODEPOS,min(WILBAC) AS WILBAC,min(SERIEBAC) AS SERIEBAC, min(FILS_DE) AS FILS_DE,min(ET_DE) AS ET_DE,min(SEXE) AS  SEXE,min(WILNAIS) AS WILNAIS,min(MOYBAC) as MOYBAC ,min(ANNEEBAC) AS ANNEEBAC  FROM ETUDIANT_ACV  "
                        CONDITION = " WHERE  MATRIN Is Not NULL And NomEtud IS Not NULL And Prenoms Is Not null And NomEtudA Is Not NULL And PrenomsA Is Not NULL And MATRIC_INS Is Not NULL And DateNais Is Not NULL And LieuNaisA Is Not NULL And WilayaNaisA Is Not NULL And LieuNais Is Not NULL And WILNAIS Is Not NULL And ADRESSE Is Not NULL And ANNEEBAC IS NOT NULL AND VILLE IS NOT NULL AND WILAYA IS NOT NULL AND WILBAC IS NOT NULL AND  SEXE IS NOT NULL AND SERIEBAC IS NOT NULL AND MOYBAC IS NOT NULL  AND  CODEPOS Is Not NULL And FILS_DE Is Not NULL And ET_DE Is Not NULL  AND NOT   EXISTS (SELECT MATRIN  FROM ETUDIANT WHERE MATRIN=ETUDIANT_ACV.MATRIN) GROUP BY MATRIN"
                        REQUETE = REQUETE & CONDITION

                    Case "INSCRIPTION"

                        REQUETE = "INSERT  INTO INSCRIPTION SELECT MATRIN AS MATRIN,ANETIN&'" & ST & "'&OPTIIN&'" & ST & "'&ANSCIN AS CodePromo,NS as CodeSection , NG AS CodeGroupe , min(MOYEIN) AS MOYEIN , min(MENTIN) AS MENTIN , min(RANGIN) AS RANGIN ,min(RATRIN) AS RATRIN , min(ELIMININ) AS ELIMININ ,min(DECIIN) AS DECIIN ,min(DECI) AS DECI , min(ADM) AS ADM   FROM INSCRIPTION_ACV "
                        CONDITION = "WHERE MATRIN IS Not NULL AND ANSCIN IS Not NULL AND  OPTIIN IS Not NULL AND ANETIN IS Not NULL AND  NS IS Not NULL AND  NG IS Not NULL AND  ADM IS Not NULL AND  DECI IS Not NULL  AND  DECIIN IS Not NULL AND  MOYEIN IS Not NULL AND  MENTIN IS Not NULL AND RANGIN IS Not NULL AND  RATRIN IS Not NULL AND  ELIMININ  IS NOT NULL AND NOT  EXISTS (SELECT MATRIN  FROM INSCRIPTION WHERE MATRIN=INSCRIPTION_ACV.MATRIN and CodePromo=ANETIN&'/'&OPTIIN&'/'&ANSCIN) GROUP BY MATRIN,ANETIN,ANSCIN,OPTIIN, NG , NS   "
                        REQUETE = REQUETE & CONDITION

                    Case "GROUPE"
                        REQUETE = "INSERT INTO GROUPE  SELECT DISTINCT  CodeGroupe AS CodeGroupe ,  CodeSection AS CodeSection ,  CodePromo AS CodePromo FROM INSCRIPTION WHERE NOT EXISTS(SELECT CodeGroupe FROM GROUPE WHERE  CodeGroupe=INSCRIPTION.CodeGroupe AND CodeSection= INSCRIPTION.CodeSection AND CodePromo= INSCRIPTION.CodePromo)  "

                    Case "SECTIONS"
                        REQUETE = "INSERT INTO SECTIONS SELECT DISTINCT    CodeSection AS CodeSection ,  CodePromo AS CodePromo  FROM GROUPE WHERE NOT EXISTS(SELECT CodeSection FROM SECTIONS WHERE   CodeSection= GROUPE.CodeSection AND CodePromo= GROUPE.CodePromo)  "

                    Case "pre_PROMO"
                        REQUETE = "delete from PROMO "

                    Case "PROMO"
                        REQUETE = "INSERT INTO PROMO(CodePromo,Niveau,Optin,Annee,NbreEtudiant) SELECT  CodePromo,Mid ([CodePromo],1,1),MID (CodePromo,3,3),Right(CodePromo,2),COUNT(CodePromo) FROM INSCRIPTION where NOT EXISTS(SELECT CodePromo from PROMO WHERE CodePromo=INSCRIPTION.CodePromo)  GROUP BY CodePromo "

                    Case "UPDATE_PROMO"
                        REQUETE = "UPDATE PROMO  SET Optin='SI' WHERE Optin='SI/' "

                    Case "MATIERE"

                        REQUETE = "INSERT  INTO MATIERE SELECT  COMAMA&'" & ST & "'&ANETMA&'" & ST & "'&OPTIMA&'" & ST & "'&ANSCMA   AS CodeMat  ,ANETMA&'" & ST & "'&OPTIMA&'" & ST & "'&ANSCMA AS CodePromo ,COMAMA AS COMAMA,min(CYCLMA) AS CYCLMA, min(LIBEMA) as LIBEMA  ,min(TYPEMA) AS TYPEMA , min(COEFMA) AS COEFMA ,min(MOYMAT) AS MOYMAT    FROM MATIERE_ACV   "
                        CONDITION = "WHERE  CYCLMA is NOT NULL AND OPTIMA IS NOT NULL AND  COMAMA IS NOT NULL AND   LIBEMA IS NOT NULL AND   TYPEMA IS NOT NULL AND   ANSCMA IS NOT NULL AND   ANETMA IS NOT NULL AND   COEFMA IS NOT NULL AND   MOYMAT IS NOT NULL AND NOT  EXISTS (SELECT CodeMat  FROM MATIERE WHERE CodeMat=COMAMA&'/'&ANETMA&'/'&OPTIMA&'/'&ANSCMA) GROUP BY ANETMA,OPTIMA,ANSCMA,COMAMA  "
                        REQUETE = REQUETE & CONDITION

                    Case "NOTES"

                        REQUETE = "INSERT  INTO NOTES SELECT COMANO&'" & ST & "'&ANETNO&'" & ST & "'&OPTINO&'" & ST & "'&ANSCNO  AS CodeMat ,ANETNO&'" & ST & "'&OPTINO&'" & ST & "'&ANSCNO as CodePromo   ,COMANO AS COMANO,MATRNO AS MATRIN ,min(NOJUNO) as NOJUNO ,min(NOSYNO) AS NOSYNO ,MIN(NORANO) AS NORANO,min(ELIMNO) AS ELIMNO ,min(RATRNO) AS RATRNO FROM NOTES_ACV "
                        CONDITION = "WHERE   MATRNO iS NOT NULL and COMANO IS NOT NULL AND ANSCNO IS NOT NULL AND OPTINO IS NOT NULL AND ANETNO IS NOT NULL AND NOJUNO IS NOT NULL    AND NORANO IS NOT NULL AND NOSYNO IS NOT NULL AND ELIMNO IS NOT NULL AND RATRNO IS NOT NULL AND NOT  EXISTS (SELECT MATRIN  FROM NOTES WHERE  MATRIN=MATRNO AND CodeMat=COMANO&'/'&ANETNO&'/'&OPTINO&'/'&ANSCNO)   GROUP BY COMANO,ANSCNO,OPTINO,ANETNO,MATRNO"
                        REQUETE = REQUETE & CONDITION

                    Case "NoteRATRAP"

                        REQUETE = "INSERT  INTO NoteRATRAP SELECT  ANETRA&'" & ST & "'&OPTIRA&'" & ST & "'&ANSCRA  AS CodeRat ,MATRRA as MATRIN   ,min(MOYERA) AS MOYERA ,min(MENTRA)  as MENTRA ,min(ELIMRA) AS ELIMRA FROM NoteRATRAP_ACV "
                        CONDITION = "WHERE MENTRA is not NULL AND ANETRA IS NOT NULL AND OPTIRA IS NOT NULL AND ANSCRA IS NOT NULL   AND MATRRA IS NOT NULL AND MOYERA IS NOT NULL AND ELIMRA IS NOT NULL AND NOT  EXISTS (SELECT MATRIN  FROM NoteRATRAP WHERE MATRIN=MATRRA AND CodeRAT=ANETRA&'/'&OPTIRA&'/'&ANSCRA) GROUP BY MATRRA , ANETRA,OPTIRA,ANSCRA "
                        REQUETE = REQUETE & CONDITION
                    Case "RATRAP"
                        REQUETE = "INSERT  INTO RATRAP SELECT  CodeRat  AS CodeRat ,  ANETRA AS ANETRA ,OPTIRA AS OPTIRA ,ANSCRA AS ANSCRA , MIN(CYCLRA) AS CYCLRA    FROM NoteRATRAP_ACV "
                        CONDITION = "WHERE MENTRA is not NULL AND ANETRA IS NOT NULL AND OPTIRA IS NOT NULL AND ANSCRA IS NOT NULL   AND MATRRA IS NOT NULL AND MOYERA IS NOT NULL AND ELIMRA IS NOT NULL AND NOT  EXISTS (SELECT CodeRat FROM RATRAP WHERE  CodeRAT=ANETRA&'/'&OPTIRA&'/'&ANSCRA) GROUP BY MATRRA , ANETRA,OPTIRA,ANSCRA "
                        REQUETE = REQUETE & CONDITION
                End Select



                cmd = New OleDbCommand(REQUETE, cnx)

                ta = New OleDbDataAdapter(cmd)

                ta.Fill(dts) ' fill le data set par le résultat de l'éxécution de requete ( de data adapter ) 


            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

            cnx.Close()
        Catch ex As Exception
            MsgBox(" Connection not openning ! ")
        End Try
    End Sub




    Public Sub FILTRE_ACV(ByVal F_ACCESS As String)

        Call FILTRE_ACV_TABLE("ETUDIANT", F_ACCESS)
        Call FILTRE_ACV_TABLE("INSCRIPTION", F_ACCESS)
        Call FILTRE_ACV_TABLE("NOTES", F_ACCESS)
        Call FILTRE_ACV_TABLE("MATIERE", F_ACCESS)
        Call FILTRE_ACV_TABLE("NoteRATRAP", F_ACCESS)
    End Sub
    Public Sub FILTRE_ACV_TABLE(ByVal Table As String, ByVal F_ACCESS As String)

        cnx = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & F_ACCESS & ".accdb")

        Try
            cnx.Open()                   ' ouvrir la connection avec la base de donnée
            Try
                Select Case Table


                    Case "ETUDIANT"
                        REQUETE = "DELETE FROM ETUDIANT_ACV WHERE  EXISTS (SELECT MATRIN  FROM ETUDIANT WHERE MATRIN=ETUDIANT_ACV.MATRIN)"

                    Case "INSCRIPTION"
                        REQUETE = "DELETE FROM INSCRIPTION_ACV WHERE  EXISTS (SELECT MATRIN  FROM INSCRIPTION WHERE MATRIN=INSCRIPTION_ACV.MATRIN and CodePromo=ANETIN&'/'&OPTIIN&'/'&ANSCIN)"

                    Case "MATIERE"
                        REQUETE = "DELETE FROM MATIERE_ACV WHERE  EXISTS (SELECT CodeMat  FROM MATIERE WHERE CodeMat=COMAMA&'/'&ANETMA&'/'&OPTIMA&'/'&ANSCMA)"

                    Case "NOTES"

                        REQUETE = "DELETE FROM NOTES_ACV WHERE  EXISTS (SELECT MATRIN  FROM NOTES WHERE  MATRIN=MATRNO AND (CodeMat=COMANO&'/'&ANETNO&'/'&OPTINO&'/'&ANSCNO))"

                    Case "NoteRATRAP"
                        REQUETE = "DELETE FROM NoteRATRAP_ACV WHERE  EXISTS (SELECT MATRIN  FROM NoteRATRAP WHERE MATRIN=MATRRA AND CodeRAT=ANETRA&'/'&OPTIRA&'/'&ANSCRA)"
                End Select



                cmd = New OleDbCommand(REQUETE, cnx)

                ta = New OleDbDataAdapter(cmd)

                ta.Fill(dts) ' fill le data set par le résultat de l'éxécution de requete ( de data adapter ) 

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

            cnx.Close()
        Catch ex As Exception
            MsgBox(" Connection not openning ! ")
        End Try
    End Sub




    'Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '   ECLATEMENT("C:\Users\DELL\Documents\BDD_APPLICATION", "C:\Users\DELL\Documents\INSCRIT_00_04", "C:\Users\DELL\Documents\NOTE_00_04", "C:\Users\DELL\Documents\MATIERE_00_04", "C:\Users\DELL\Documents\RATRAP_00_04")
    '  RECHARGEMENT("C:\Users\DELL\Documents\BDD_APPLICATION")
    ' MsgBox("olilililililolilooooliloilolilooooliloooliloliooilooi")
    'End Sub
End Class






