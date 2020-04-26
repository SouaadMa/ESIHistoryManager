Imports System.Data.OleDb
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1

    Dim cnx2, cn As OleDbConnection           ' la connection 
    Dim cmd2, cmd3 As OleDbCommand              ' la commande
    Dim ta2, ta3 As OleDbDataAdapter                  ' le Data Adapter
    Dim dts2, dt, dts3, dt3 As New DataSet                      ' le Data Set
    Dim dt2 As DataTable                         ' le Data Table


    Dim ST As String = "/"
    Dim ST2 As String = "0"

    Dim REQUETE, SQL1, SQL2, SQL3, SQL4, Chmps_Distinataires, Champs_Sources, CnxSource As String
    Dim strProvider As String, strSQL As String, intResult As Integer
    Public Shared Function Const_CodePromo(ByVal NIVEAU As String, ByVal OPTIN As String, ByVal ANNEE As String) As String
        Dim Slash As String = "/"
        Dim CodePromo As String = NIVEAU & Slash & OPTIN & Slash & ANNEE
        Return CodePromo
    End Function



    Public Sub Eclatement_FROM_ACCESS(ByVal TABLE As String, ByVal F_ACCESS As String)

        dt2 = New DataTable()

        cnx2 = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & F_ACCESS & ".accdb")

        Try
            cnx2.Open()                   ' ouvrir la connection avec la base de donnée
            Try

                Select Case TABLE


                    Case "GROUPE"
                        REQUETE = "INSERT INTO GROUPE(CodeGroupe,CodeSection,CodePromo) SELECT DISTINCT CodeGroupe,CodeSection, CodePromo FROM INSCRIPTION"

                    Case "SECTIONS"
                        REQUETE = "INSERT INTO SECTIONS(CodeSection,CodePromo) SELECT DISTINCT CodeSection,CodePromo FROM GROUPE"

                    Case "PROMO"
                        REQUETE = "INSERT INTO PROMO(CodePromo,Niveau,Optin,Annee) SELECT DISTINCT CodePromo,Mid ([CodePromo],1,1),MID (CodePromo,3,3),Right(CodePromo,2) FROM SECTIONS where mid(CodeSection,1,1)<>'3'"

                    Case "ETUDIANT_UPDATE"

                        REQUETE = "UPDATE ETUDIANT SET NomEtudA ='NomEtudA', PrenomsA='PrenomsA',NomEtud ='NomEtud',Prenoms='Prenoms', VILLE='VILLE' , CODEPOS='CODPOST' ,ADRESSE='adresse' ,FILS_DE= 'pére ' , ET_DE = 'mére', MATRIC_INS ='matricule du bac', LieuNaisA= ' lieunaisa' , WilayaNaisA='wilnaisA', LieuNais = 'lieunais' "

                    Case "INSCRIPTION_UPDATE"
                        REQUETE = "UPDATE INSCRIPTION SET ADM ='adm', DECIIN='deciin',DECI ='dec'" ',Prenoms='Prenoms', VILLE='VILLE' , CODPOST='CODPOST' ,ADRESSE='adresse'   "

                End Select



                cmd2 = New OleDbCommand(REQUETE, cnx2)

                ta2 = New OleDbDataAdapter(cmd2)

                ta2.Fill(dts2) ' fill le data set par le résultat de l'éxécution de requete ( de data adapter ) 

                'dt2 = dts2.Tables("table")
            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

            cnx2.Close()
        Catch ex As Exception
            MsgBox(" Connection not openning ! ")
        End Try
    End Sub




    Public Sub Eclatement_FROM_EXCEL(ByVal TABLE As String, ByVal F_ACCESS As String, ByVal F_EXCEL As String)

        Try

            Select Case TABLE


                Case "INSCRIPTION"
                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""

                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[INSCRIPTION] SELECT "
                    Champs_Sources = "MATRIN AS MATRIN ,NG AS CodeGroupe,NS AS CodeSection,ANETIN&'" & ST & "'&OPTIIN&'" & ST & "'&ANSCIN AS CodePromo,MOYEIN AS MOYEIN,RANGIN AS RANGIN,MENTIN AS MENTIN,ELIMIN AS ELIMININ,RATRIN AS RATRIN,DECIIN AS DECIIN,ADM AS ADM ,DEC AS DECI"
                    SQL2 = " From [INSCRIT$]   where MATRIN IS NOT NULL AND NG IS NOT NULL AND NS IS NOT NULL AND ANETIN is NOT NULL AND OPTIIN IS NOT NULL AND ANSCIN IS NOT NULL AND MOYEIN IS NOT NULL AND RANGIN IS NOT NULL AND MENTIN IS NOT NULL AND ELIMIN IS NOT NULL AND RATRIN IS NOT NULL" '  AND DECIIN IS NOT NULL AND ADM IS NOT NULL  AND DEC IS NOT NULL  "
                    REQUETE = SQL1 & Champs_Sources & SQL2


                Case "ETUDIANT"
                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[ETUDIANT]  SELECT "
                    Champs_Sources = " MATRIN AS MATRIN,min(NomEtud) AS NomEtud,min(Prenoms) AS Prenoms ,min(NomEtudA) AS NomEtudA,min(PrenomsA) AS PrenomsA,min(MATRIC_INS) AS MATRIC_INS, min(DATENAIS) AS DateNais,min(LIEUNAISA) AS LieuNaisA ,min(WILNAISA) AS WilayaNaisA,min(LIEUNAIS) AS LieuNais, min(ADRESSE) AS ADRESSE, min(VILLE) AS VILLE, min(WILAYA) AS WILAYA , min(CODPOST) as CODEPOS,min(WILBAC) AS WILBAC,min(SERIEBAC) AS SERIEBAC, min(FILS_DE) AS FILS_DE,min(ET_DE) AS ET_DE,min(SEXE) AS  SEXE,min(WILNAIS) AS WILNAIS,min(MOYBAC) as MOYBAC ,min(ANNEEBAC) as ANNEEBAC "
                    SQL2 = " From [INSCRIT$] where  MATRIN IS NOT NULL  AND DATENAIS IS NOT NULL  AND WILNAIS IS NOT NULL   AND WILAYA IS NOT NULL AND WILNAIS IS NOT NULL AND WILBAC IS NOT NULL AND MOYBAC IS NOT NULL AND ANNEEBAC IS NOT NULL AND FILS_DE IS NOT NULL AND ET_DE IS NOT NULL   GROUP BY (MATRIN)    " 'AND NomEtud IS NOT NULL AND  Prenoms is not null and NomEtudA IS NOT null and PrenomsA is not null  AND  ADRESSE IS NOT NULL AND CODPOST IS NOT NULL  AND VILLE IS NOT NULL  AND FILS_DE IS NOT NULL AND ET_DE IS NOT NULL  AND   MATRIC_INS IS NOT NULL AND LIEUNAISA IS NOT NULL AND WILNAISA IS NOT NULL AND LIEUNAIS IS NOT NULL
                    REQUETE = SQL1 & Champs_Sources & SQL2


                Case "MATIERE"

                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[MATIERE]  SELECT "
                    Champs_Sources = " COMAMA&'" & ST & "'&ANETMA&'" & ST & "'&OPTIMA&'" & ST & "'&ANSCMA   AS CodeMat  ,ANETMA&'" & ST & "'&OPTIMA&'" & ST & "'&ANSCMA AS CodePromo ,COMAMA AS COMAMA,CYCLMA AS CYCLMA, LIBEMA as LIBEMA  ,TYPEMA AS TYPEMA , COEFMA AS COEFMA ,MOYMAT AS MOYMAT  "
                    SQL2 = " From [MATIERE$] where  CYCLMA is NOT NULL AND OPTIMA IS NOT NULL AND  COMAMA IS NOT NULL AND   LIBEMA IS NOT NULL AND   TYPEMA IS NOT NULL AND   ANSCMA IS NOT NULL AND   ANETMA IS NOT NULL AND   COEFMA IS NOT NULL AND   MOYMAT IS NOT NULL   "
                    REQUETE = SQL1 & Champs_Sources & SQL2
                    'ANETMA&'" & ST & "'&OPTIMA&'" & ST & "'&ANSCMA&'" & ST & "'&


                Case "NOTES"
                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[NOTES]  SELECT "
                    Champs_Sources = " COMANO&'" & ST & "'&ANETNO&'" & ST & "'&OPTINO&'" & ST & "'&ANSCNO  AS CodeMat ,ANETNO&'" & ST & "'&OPTINO&'" & ST & "'&ANSCNO as CodePromo   ,COMANO AS COMANO,MATRNO AS MATRIN ,min(NOJUNO) as NOJUNO ,min(NOSYNO) AS NOSYNO ,MIN(NORANO) AS NORANO,min(ELIMNO) AS ELIMNO ,min(RATRNO) AS RATRNO  "
                    SQL2 = " From [NOTE$] WHERE  MATRNO iS NOT NULL and COMANO IS NOT NULL AND ANSCNO IS NOT NULL AND OPTINO IS NOT NULL AND ANETNO IS NOT NULL     GROUP BY COMANO,ANSCNO,OPTINO,ANETNO,MATRNO" 'where  CYCLMA is NOT NULL AND OPTIMA IS NOT NULL AND  COMAMA IS NOT NULL AND   LIBEMA IS NOT NULL AND   TYPEMA IS NOT NULL AND   ANSCMA IS NOT NULL AND   ANETMA IS NOT NULL AND   COEFMA IS NOT NULL AND   MOYMAT IS NOT NULL   "
                    REQUETE = SQL1 & Champs_Sources & SQL2





                Case "RATRAP"

                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[RATRAP]  SELECT "
                    Champs_Sources = "DISTINCT  ANETRA&'" & ST & "'&OPTIRA&'" & ST & "'&ANSCRA AS CodeRat ,ANSCRA as ANSCRA   ,ANETRA AS ANETRA ,CYCLRA as CYCLRA ,OPTIRA AS OPTIRA "
                    SQL2 = " From [RATRAP$] WHERE ANETRA is not NULL  AND ANSCRA IS NOT NULL AND CYCLRA IS NOT NULL AND OPTIRA IS NOT NULL"
                    REQUETE = SQL1 & Champs_Sources & SQL2



                Case "NOTERATRAP"

                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & F_EXCEL & ".xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=" & F_ACCESS & ".accdb].[NoteRATRAP]  SELECT "
                    Champs_Sources = "DISTINCT ANETRA&'" & ST & "'&OPTIRA&'" & ST & "'&ANSCRA  AS CodeRat ,MATRRA as MATRIN   ,MOYERA AS MOYERA ,MENTRA  as MENTRA ,ELIMRA AS ELIMRA"
                    SQL2 = " From [RATRAP$] WHERE MENTRA is not NULL  AND MATRRA IS NOT NULL AND MOYERA IS NOT NULL AND ELIMRA IS NOT NULL"
                    REQUETE = SQL1 & Champs_Sources & SQL2



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

    Public Sub ECLATEMENT(ByVal F_ACCESS As String, ByVal EXCEL_INSCRIT As String, ByVal EXCEL_NOTE As String, ByVal EXCEL_MATIERE As String, ByVal EXCEL_RATRAP As String)
        Call Eclatement_FROM_EXCEL("INSCRIPTION", F_ACCESS, EXCEL_INSCRIT)
        Call Eclatement_FROM_EXCEL("ETUDIANT", F_ACCESS, EXCEL_INSCRIT)
        Call Eclatement_FROM_EXCEL("MATIERE", F_ACCESS, EXCEL_MATIERE)
        Call Eclatement_FROM_EXCEL("NOTES", F_ACCESS, EXCEL_NOTE)
        Call Eclatement_FROM_EXCEL("NOTERATRAP", F_ACCESS, EXCEL_RATRAP)
        Call Eclatement_FROM_EXCEL("RATRAP", F_ACCESS, EXCEL_RATRAP)
        Call Eclatement_FROM_ACCESS("GROUPE", F_ACCESS)
        Call Eclatement_FROM_ACCESS("SECTIONS", F_ACCESS)
        Call Eclatement_FROM_ACCESS("PROMO", F_ACCESS)
        Call Eclatement_FROM_ACCESS("ETUDIANT_UPDATE", F_ACCESS)
        Call Eclatement_FROM_ACCESS("INSCRIPTION_UPDATE", F_ACCESS)
    End Sub
    'Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    '   ECLATEMENT("C:\Users\DELL\Documents\BDD TRAFFIc", "C:\Users\DELL\Documents\INSCRIT_00_04", "C:\Users\DELL\Documents\NOTE_00_04", "C:\Users\DELL\Documents\MATIERE_00_04", "C:\Users\DELL\Documents\RATRAP_00_04")

    'End Sub
End Class





