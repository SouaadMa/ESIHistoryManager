Imports System.Runtime.CompilerServices
Imports System.ComponentModel
Imports System.Reflection


<Extension()>
Module Extensions

    <Extension()>
    Public Function ToDataTable(Of T)(ByVal source As List(Of T)) As DataTable

        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim table As New DataTable()
        Dim descriptor As PropertyDescriptor = Nothing
        Dim column As DataColumn = Nothing
        Dim values As Object() = Nothing
        Dim length As Integer = Nothing
        Dim index As Integer = Nothing
        Dim item As T = Nothing
        Dim type As Type = Nothing

        table.BeginInit()

        For Each descriptor In properties
            type = Nullable.GetUnderlyingType(descriptor.PropertyType)
            column = New DataColumn()
            column.ColumnName = descriptor.Name
            column.Caption = descriptor.DisplayName
            column.DataType = If((type Is Nothing), descriptor.PropertyType, type)
            column.ReadOnly = descriptor.IsReadOnly
            table.Columns.Add(column)
        Next

        table.BeginLoadData()
        length = (properties.Count - 1)
        values = New Object(length) {}

        For Each item In source
            For index = 0 To length
                values(index) = properties(index).GetValue(item)
            Next
            table.Rows.Add(values)
        Next

        table.EndLoadData()
        table.EndInit()

        Return table

    End Function

    <Extension()>
    Public Function ToList(Of T As {Class, New})(ByVal source As DataTable) As List(Of T)

        If (source Is Nothing) Then
            Throw New ArgumentNullException("source")
        End If

        Dim list As New List(Of T)
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim descriptor As PropertyDescriptor = Nothing
        Dim index As Integer = Nothing
        Dim row As DataRow = Nothing
        Dim item As T = Nothing

        For index = (properties.Count - 1) To 0 Step -1
            If (Not source.Columns.Contains(properties(index).Name)) Then
                'properties.RemoveAt(index)
            End If
        Next

        For Each row In source.Rows
            item = New T()
            For Each descriptor In properties
                descriptor.SetValue(item, row.Item(descriptor.Name))
            Next
            list.Add(item)
        Next

        Return list

    End Function


End Module
