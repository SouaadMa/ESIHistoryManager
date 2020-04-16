Imports System.Data.OleDb
Imports Microsoft.VisualBasic.ApplicationServices

Public Class ECLATEMENT

    Dim cnx2, cn As OleDbConnection           ' la connection 
    Dim cmd2, cmd3 As OleDbCommand              ' la commande
    Dim ta2, ta3 As OleDbDataAdapter                  ' le Data Adapter
    Dim dts2, dt, dts3, dt3 As New DataSet                      ' le Data Set
    Dim dt2 As DataTable                         ' le Data Table


    Dim ST As String = "/"
    Dim ST2 As String = "0"

    Dim REQUETE, SQL1, SQL2, SQL3, SQL4, Chmps_Distinataires, Champs_Sources, CnxSource As String
    Dim strProvider As String, strSQL As String, intResult As Integer
    Public Sub Eclatement_FROM_ACCESS(ByVal TABLE As String)

        dt2 = New DataTable()

        cnx2 = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Documents\Base de données (4).accdb")

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


                End Select



                cmd2 = New OleDbCommand(REQUETE, cnx2)

                ta2 = New OleDbDataAdapter(cmd2)

                ta2.Fill(dts2) ' fill le data set par le résultat de l'éxécution de requete ( de data adapter ) 

                dt2 = dts2.Tables("table")
            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

            cnx2.Close()
        Catch ex As Exception
            MsgBox(" Connection not openning ! ")
        End Try
    End Sub




    Public Sub Eclatement_FROM_EXCEL(ByVal TABLE As String)

        Try

            Select Case TABLE


                Case "INSCRIPTION"
                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\DELL\Documents\INSCRIT_00_04.xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""

                    SQL1 = "INSERT INTO [MS Access;Database=C:\Users\DELL\Documents\Base de données (4).accdb].[INSCRIPTION] SELECT "
                    Champs_Sources = "MATRIN AS MATRIN ,NG AS CodeGroupe,NS AS CodeSection,ANETIN&'" & ST & "'&OPTIIN&'" & ST & "'&ANSCIN AS CodePromo,MOYEIN AS MOYEIN,RANGIN AS RANGIN,MENTIN AS MENTIN,ELIMIN AS ELIMININ,RATRIN AS RATRIN,DECIIN AS DECIIN,ADM AS ADM ,DEC AS DECI"
                    SQL2 = " From [INSCRIT$]  where MATRIN IS NOT NULL AND NG IS NOT NULL AND NS IS NOT NULL AND ANETIN is NOT NULL AND OPTIIN IS NOT NULL AND ANSCIN IS NOT NULL AND MOYEIN IS NOT NULL AND RANGIN IS NOT NULL AND MENTIN IS NOT NULL AND ELIMIN IS NOT NULL AND RANGIN IS NOT NULL AND DECIIN IS NOT NULL AND ADM IS NOT NULL AND DEC IS NOT NULL  "
                    REQUETE = SQL1 & Champs_Sources & SQL2
                    'REQUETE = "DELETE FROM INSCRIPTION where MENTIN=0"

                Case "ETUDIANT"
                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\DELL\Documents\INSCRIT_00_04.xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=C:\Users\DELL\Documents\Base de données (3).accdb].[ETUDIANT]  SELECT "
                    Champs_Sources = " MATRIN AS MATRIN,min(NomEtud) AS NomEtud,min(Prenoms) AS Prenoms ,min(NomEtudA) AS NomEtudA,min(PrenomsA) AS PrenomsA,min(MATRIC_INS) AS MATRIC_INS, min(DATENAIS) AS DateNais,min(LIEUNAISA) AS LieuNaisA ,min(WILNAISA) AS WilayaNaisA,min(LIEUNAIS) AS LieuNais, min(ADRESSE) AS ADRESSE, min(VILLE) AS VILLE, min(WILAYA) AS WILAYA , min(CODPOST) as CODEPOS,min(WILBAC) AS WILBAC,min(SERIEBAC) AS SERIEBAC, min(FILS_DE) AS FILS_DE,min(ET_DE) AS ET_DE,min(SEXE) AS  SEXE,min(WILNAIS) AS WILNAIS,min(MOYBAC) as MOYBAC ,min(ANNEEBAC) as ANNEEBAC "
                    SQL2 = " From [INSCRIT$] where    MATRIC_INS IS NOT NULL  AND DATENAIS IS NOT NULL AND LIEUNAISA IS NOT NULL AND WILNAISA IS NOT NULL AND LIEUNAIS IS NOT NULL AND ADRESSE IS NOT NULL AND CODPOST IS NOT NULL AND FILS_DE IS NOT NULL AND ET_DE IS NOT NULL  GROUP BY (MATRIN) " ' AND NomEtud IS NOT NULL AND  Prenoms is not null and NomEtudA IS NOT NULL  AND VILLE IS NOT NULL AND WILAYA IS NOT NULL   "
                    REQUETE = SQL1 & Champs_Sources & SQL2


                Case "MARIERE"

                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\DELL\Documents\MATIERE_00_04.xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=C:\Users\DELL\Documents\Base de données (4).accdb].[MATIERE]  SELECT "
                    Champs_Sources = " COMAMA&ANSCMA&OPTIMA&ANETMA   AS CodeMat  ,OPTIMA AS OPTIMA ,CYCLMA AS CYCLMA,COMAMA AS COMAMA ,LIBEMA as LIBEMA  ,TYPEMA AS TYPEMA ,ANSCMA AS ANSCMA , ANETMA AS ANETMA , COEFMA AS COEFMA ,MOYMAT AS MOYMAT  "
                    SQL2 = " From [MATIERE$] where  CYCLMA is NOT NULL AND OPTIMA IS NOT NULL AND  COMAMA IS NOT NULL AND   LIBEMA IS NOT NULL AND   TYPEMA IS NOT NULL AND   ANSCMA IS NOT NULL AND   ANETMA IS NOT NULL AND   COEFMA IS NOT NULL AND   MOYMAT IS NOT NULL   "
                    REQUETE = SQL1 & Champs_Sources & SQL2



                Case "NOTES"
                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\DELL\Documents\NOTE_00_04.xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=C:\Users\DELL\Documents\Base de données (4).accdb].[NOTES]  SELECT "
                    Champs_Sources = " COMANO AS CodeMat ,ANSCNO&OPTINO&ANETNO as CodePromo   ,MATRNO AS MATRIN ,min(NOJUNO) as NOJUNO ,min(NOSYNO) AS NOSYNO ,MIN(NORANO) AS NORANO,min(ELIMNO) AS ELIMNO ,min(RATRNO) AS RATRNO  "
                    SQL2 = " From [NOTE$] WHERE MATRNO iS NOT NULL and COMANO IS NOT NULL AND ANSCNO IS NOT NULL AND OPTINO IS NOT NULL AND ANETNO IS NOT NULL     GROUP BY COMANO,ANSCNO,OPTINO,ANETNO,MATRNO" 'where  CYCLMA is NOT NULL AND OPTIMA IS NOT NULL AND  COMAMA IS NOT NULL AND   LIBEMA IS NOT NULL AND   TYPEMA IS NOT NULL AND   ANSCMA IS NOT NULL AND   ANETMA IS NOT NULL AND   COEFMA IS NOT NULL AND   MOYMAT IS NOT NULL   "
                    REQUETE = SQL1 & Champs_Sources & SQL2





                Case "RATRAP"

                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\DELL\Documents\RATRAP_00_04.xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=C:\Users\DELL\Documents\Base de données (4).accdb].[RATRAP]  SELECT "
                    Champs_Sources = "DISTINCT  ANSCRA&OPTIRA&ANETRA&ANSCRA AS CodeRat ,ANSCRA as ANSCRA   ,ANETRA AS ANETRA ,CYCLRA as CYCLRA ,OPTIRA AS OPTIRA "
                    SQL2 = " From [RATRAP$] WHERE ANETRA is not NULL  AND ANSCRA IS NOT NULL AND CYCLRA IS NOT NULL AND OPTIRA IS NOT NULL"
                    REQUETE = SQL1 & Champs_Sources & SQL2



                Case "NOTERATRAP"

                    strProvider = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\DELL\Documents\RATRAP_00_04.xlsx;Extended Properties=""Excel 12.0;HDR=Yes"""
                    SQL1 = "INSERT INTO [MS Access;Database=C:\Users\DELL\Documents\Base de données (4).accdb].[NoteRATRAP]  SELECT "
                    Champs_Sources = "DISTINCT  ANSCRA&OPTIRA&ANETRA&ANSCRA AS CodeRat ,MATRRA as MATRIN   ,MOYERA AS MOYERA ,MENTRA  as MENTRA ,ELIMRA AS ELIMRA,RATRRA AS RATRRA "
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
    Public Sub ECLATEMENT()
        Call Eclatement_FROM_EXCEL("INSCRIPTION")
        Call Eclatement_FROM_EXCEL("ETUDIANT")
        Call Eclatement_FROM_EXCEL("MATIERE")
        Call Eclatement_FROM_EXCEL("NOTES")
        Call Eclatement_FROM_EXCEL("RATRAP")
        Call Eclatement_FROM_EXCEL("NOTERATRAP")
        Call Eclatement_FROM_ACCESS("GROUPE")
        Call Eclatement_FROM_ACCESS("NOTES")
        Call Eclatement_FROM_ACCESS("PROMO")

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles MyBase.Load


        ECLATEMENT()

    End Sub
End Class
