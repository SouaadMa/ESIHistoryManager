Imports System.Data.OleDb

Public Class Eclatement

    Public Shared Sub importExcelAccess(ByVal fileExcel As String, ByVal sheetExcel As String, ByVal fileAccess As String, ByVal tableName As String)
        Dim tables As DataTableCollection = Eclatement.lireExcelFile(fileExcel, sheetExcel)
        If tables.Count > 0 Then
            ecrireDataTable(fileAccess, tableName, tables(0))
        Else
            MsgBox(" La feuille excel ne contient aucun tableau !")
        End If
    End Sub

    Public Shared Function lireExcelFile(ByVal fileExcel As String, ByVal sheetExcel As String) As DataTableCollection

        Dim dt As DataTableCollection

        Dim cnx As System.Data.OleDb.OleDbConnection
        Dim dts As System.Data.DataSet
        Dim cmd As System.Data.OleDb.OleDbDataAdapter

        cnx = New System.Data.OleDb.OleDbConnection(" provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileExcel + "; Extended Properties='Excel 12.0 Xml; HDR=YES'")
        cnx.Open()
        cmd = New System.Data.OleDb.OleDbDataAdapter("Select * From [" + sheetExcel + "$]", cnx)
        dts = New System.Data.DataSet

        cmd.Fill(dts)
        dt = (dts.Tables)

        Return dt
    End Function

    Public Shared Sub ecrireDataTable(ByVal fileAccess As String, ByVal tableName As String, ByVal dt As DataTable)

        Dim dataType() As String = {"System.String", "System.Double", "System.Boolean", "System.Date"}
        Dim sqlType() As String = {"varchar", "Number", "YESNO", "Date"}
        Dim sqlKeyWord() As String = {"DEC", "SELECT", "INSERT", "UPDATE", "WHERE", "IN", "AND", "OR", "NOTE"}

        Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileAccess)
        Dim cmd As OleDbCommand = New OleDbCommand()
        Dim length As Integer = dt.Columns.Count
        Dim i As Integer = 0
        Dim ind As Integer = 0
        Dim colomn As DataColumn
        Dim row As DataRow
        Dim champ(length) As String
        Dim champSql(length) As String
        Dim type(length) As String
        Dim cmdText As String
        Dim cmdText2 As String
        Dim nom As Object
        Dim empty As Boolean = True

        If sqlKeyWord.Contains(tableName) Then
            tableName = "_" + tableName
        End If

        Try
            con.Open()
            cmd.Connection = con

            cmdText = "CREATE TABLE " + tableName
            cmd.CommandText = cmdText
            cmd.ExecuteNonQuery()

            For Each colomn In dt.Columns
                Try
                    champ(i) = colomn.ColumnName
                    If sqlKeyWord.Contains(champ(i)) Then
                        champSql(i) = "_" + champ(i)
                    Else
                        champSql(i) = champ(i)
                    End If
                    ind = Array.IndexOf(dataType, colomn.DataType.ToString)
                    type(i) = IIf(ind >= 0, sqlType(ind), "Text")
                    cmdText = "ALTER TABLE " + tableName + " ADD " + champSql(i) + " " + type(i)
                    cmd.CommandText = cmdText
                    cmd.ExecuteNonQuery()
                    i += 1
                Catch ex As Exception
                    MsgBox(" Le champ " + colomn.ColumnName + " ne peut pas etre crée ! ")
                End Try
            Next
            length = i
            MsgBox("Table " + tableName + " created.")

            For Each row In dt.Rows
                ind = -1
                empty = True
                While empty And ind < length - 1
                    ind += 1
                    empty = (row(champ(ind)).ToString).Equals("")
                End While
                If Not empty Then
                    cmdText = "INSERT INTO " + tableName + " ( "
                    cmdText2 = " VALUES ( "
                    Select Case type(ind)
                        Case "YESNO"
                            nom = "'" + (IIf(row(champ(ind)).ToString = "True", -1, 0)).ToString + "'"
                            'Case "int"
                            'nom = CDbl(row(champ(ind))).ToString.Replace(",", ".")
                        Case Else
                            nom = "'" + row(champ(ind)).ToString.Replace("'", "`") + "'"
                    End Select
                    cmdText = cmdText + champSql(ind)
                    cmdText2 = cmdText2 + nom
                    For i = ind + 1 To length - 1
                        If (Not (row(champ(i)).ToString).Equals("")) Then
                            Select Case type(i)
                                Case "YESNO"
                                    nom = "'" + (IIf(row(champ(i)).ToString = "True", -1, 0)).ToString + "'"
                                    'Case "int"
                                    'nom = CDbl(row(champ(i))).ToString.Replace(",", ".")
                                Case Else
                                    nom = "'" + row(champ(i)).ToString.Replace("'", "`") + "'"
                            End Select
                            cmdText = cmdText + " , " + champSql(i)
                            cmdText2 = cmdText2 + " , " + nom
                        End If
                    Next
                    cmdText = cmdText + " ) "
                    cmdText2 = cmdText2 + " ) "
                    cmd.CommandText = cmdText + cmdText2
                    cmd.ExecuteNonQuery()
                End If

            Next
            MsgBox("Table " + tableName + " Remplir .")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

End Class
