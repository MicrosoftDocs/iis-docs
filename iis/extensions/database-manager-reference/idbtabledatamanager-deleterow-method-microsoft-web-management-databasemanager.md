---
title: IDbTableDataManager.DeleteRow Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: DeleteRow Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbTableDataManager.DeleteRow(System.String,System.String,System.String,System.Collections.Generic.IList{Microsoft.Web.Management.DatabaseManager.ColumnDataInfo})
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.idbtabledatamanager.deleterow(v=VS.90)
ms:contentKeyID: 20476433
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbTableDataManager.DeleteRow
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbTableDataManager.DeleteRow
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# IDbTableDataManager.DeleteRow Method

Removes a row from a table.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Sub DeleteRow ( _
    connectionString As String, _
    tableName As String, _
    schema As String, _
    columnDataInfoList As IList(Of ColumnDataInfo) _
)
'Usage
Dim instance As IDbTableDataManager
Dim connectionString As String
Dim tableName As String
Dim schema As String
Dim columnDataInfoList As IList(Of ColumnDataInfo)

instance.DeleteRow(connectionString, _
    tableName, schema, columnDataInfoList)
```

```csharp
void DeleteRow(
    string connectionString,
    string tableName,
    string schema,
    IList<ColumnDataInfo> columnDataInfoList
)
```

```cpp
void DeleteRow(
    String^ connectionString, 
    String^ tableName, 
    String^ schema, 
    IList<ColumnDataInfo^>^ columnDataInfoList
)
```

```jscript
function DeleteRow(
    connectionString : String, 
    tableName : String, 
    schema : String, 
    columnDataInfoList : IList<ColumnDataInfo>
)
```

### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The connection string for the database.  

<!-- end list -->

  - tableName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The name of the table.  

<!-- end list -->

  - schema  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The schema name for the table.  
    **Note**    If schema is empty, the default schema name will be used.  

<!-- end list -->

  - columnDataInfoList  
    Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6)\<[ColumnDataInfo](columndatainfo-class-microsoft-web-management-databasemanager.md)\>  
    An IList object that contains a list of [ColumnDataInfo](columndatainfo-class-microsoft-web-management-databasemanager.md) objects to delete.  

## Remarks

All database providers that implement the [IDbTableDataManager](idbtabledatamanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the DeleteRow method. The database manager will use this method to remove rows from a table in a database.

### 

### Notes for Implementers

If your provider does not support deleting rows, you can use the following code sample to raise a not-implemented exception:

public void DeleteRow(string connectionString, string tableName, string schema, IList\<ColumnDataInfo\> columnDataInfoList)

{

   throw new NotImplementedException();

}


> [!NOTE]  
> See the [DELETE (Transact-SQL)](http://msdn.microsoft.com/en-us/library/ms189835.aspx) topic for more information about the DELETE SQL statement.


## Examples

The following code sample implements the DeleteRow method to remove a row from an OLEDB data source.


> [!NOTE]  
> This example also provides helper methods that perform additional database tasks.


```vb

    ' Delete a row from a table.
    Public Sub DeleteRow( _
            ByVal connectionString As String, _
            ByVal tableName As String, _
            ByVal schema As String, _
            ByVal columnDataInfoList _
            As System.Collections.Generic.IList( _
            Of Microsoft.Web.Management.DatabaseManager.ColumnDataInfo)) _
            Implements Microsoft.Web.Management.DatabaseManager.IDbTableDataManager.DeleteRow

        ' Create a new string builder for the SQL statement.
        Dim whereText As StringBuilder = New StringBuilder
        ' Create a connection to the database.
        Dim connection As OleDbConnection = New OleDbConnection(connectionString)
        ' Create database command object.
        Dim command As OleDbCommand = New OleDbCommand
        ' Specify the command type.
        command.Connection = connection
        command.CommandType = CommandType.Text
        Dim whereClause As String = CreateWhereClause(columnDataInfoList, command, False)
        ' Construct the DELETE query.
        command.CommandText = String.Format("DELETE FROM {0} WHERE {1}", EscapeName(tableName), whereClause)
        ' Open the database connection.
        connection.Open()
        ' Run the query.
        ExecuteNonQuery(connection, command)
        ' Close the database connection.
        connection.Close()


    End Sub



...



    Friend Shared Function EscapeName(ByVal name As String) As String
        ' Test if the value is already escaped.
        If (name.StartsWith("[", StringComparison.Ordinal) AndAlso name.EndsWith("]", StringComparison.Ordinal)) Then
            ' Return the string with no changes.
            Return name
        End If
        ' Create a new string builder for the escaped string.
        Dim escapedName As StringBuilder = New StringBuilder
        ' Prepend the string with an opening bracket.
        escapedName.Append(Microsoft.VisualBasic.ChrW(91))
        ' Loop through the string.
        Dim i As Integer = 0
        Do While (i < name.Length)
            Dim c As Char = name(i)
            If (c = Microsoft.VisualBasic.ChrW(93)) Then
                escapedName.Append(Microsoft.VisualBasic.ChrW(93))
            End If
            escapedName.Append(c)
            i = (i + 1)
        Loop
        ' Append the string with an opening bracket.
        escapedName.Append(Microsoft.VisualBasic.ChrW(93))
        ' Return the escaped string.
        Return escapedName.ToString
    End Function



...



    ' Run a transactional query.
    Private Function ExecuteNonQuery( _
            ByVal connection As OleDbConnection, _
            ByVal command As OleDbCommand) As Integer

        ' Begin a transaction.
        Dim transaction As OleDbTransaction = connection.BeginTransaction
        ' Specify the transaction for the command.
        command.Transaction = transaction
        Try
            ' Run the query.
            Dim records As Integer = command.ExecuteNonQuery
            ' Test for the number of affected rows.
            If (records > 1) Then
                ' Throw an error if more than one row was affected.
                Dim e As InvalidOperationException = New InvalidOperationException
                e.Data("RowsAffected") = records
                Throw e
            End If
            ' Commit the transaction.
            transaction.Commit()
            ' Return the count of affected records.
            Return records
        Catch ex As Exception
            ' Roll back the transaction if en exception occurred
            transaction.Rollback()
            ' Raise an exception when an error occured.
            Throw New ProviderException(ex.Message)
        End Try

    End Function



...



    Private Function CreateWhereClause( _
            ByVal list As IList(Of ColumnDataInfo), _
            ByVal command As OleDbCommand, _
            ByVal includeModifiedColumnsOnly As Boolean) As String

        ' Create a new string builder for the SQL statement.
        Dim whereClause As StringBuilder = New StringBuilder
        For Each info As ColumnDataInfo In list
            ' Determine the OLEDB type for the column.
            Dim dbType As OleDbType = StringToOleDbType(info.TypeInfo.ToString)
            ' Do not add binary fields.
            If (dbType <> OleDbType.Binary) Then
                ' Do not include modified columns if the flag is set true
                If (Not includeModifiedColumnsOnly _
                            OrElse info.IsEdited) Then
                    whereClause.Append(EscapeName(info.ColumnName))
                    If (info.OriginalValue Is Nothing) Then
                        whereClause.Append(" IS NULL AND ")
                    Else
                        whereClause.Append("=? AND ")
                        Dim param As OleDbParameter = command.CreateParameter
                        param.OleDbType = dbType
                        If (dbType = OleDbType.Guid) Then
                            ' Convert the GUID string back to a GUID for the parameter.
                            param.Value = New Guid(info.OriginalValue.ToString)
                        Else
                            ' Add the parameter value.
                            param.Value = GetDataValue(info.OriginalValue)
                        End If
                        command.Parameters.Add(param)
                    End If
                End If
            End If
        Next
        whereClause.Remove((whereClause.Length - 5), 5)
        Return whereClause.ToString

    End Function


```

```csharp

// Delete a row from a table.
public void DeleteRow(string connectionString, string tableName, string schema, IList<ColumnDataInfo> columnDataInfoList)
{
    // Create a new string builder for the SQL statement.
    StringBuilder whereText = new StringBuilder();
    // Create a connection to the database.
    using (OleDbConnection connection = new OleDbConnection(connectionString))
    {
        // Create database command object.
        using (OleDbCommand command = new OleDbCommand())
        {
            // Specify the command type.
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            string whereClause = CreateWhereClause(columnDataInfoList, command, false);

            // Construct the DELETE query.
            command.CommandText = String.Format("DELETE FROM {0} WHERE {1}", EscapeName(tableName), whereClause);

            // Open the database connection.
            connection.Open();
            // Run the query.
            ExecuteNonQuery(connection, command);
            // Close the database connection.
            connection.Close();
        }
    }
}




...



        internal static string EscapeName(string name)
        {
            // Test if the value is already escaped.
            if (name.StartsWith("[", StringComparison.Ordinal) && name.EndsWith("]", StringComparison.Ordinal))
            {
                // Return the string with no changes.
                return name;
            }
            // Create a new string builder for the escaped string.
            StringBuilder escapedName = new StringBuilder();
            // Prepend the string with an opening bracket.
            escapedName.Append('[');
            // Loop through the string.
            for (int i = 0; i < name.Length; i++)
            {
                char c = name[i];
                if (c == ']')
                {
                    escapedName.Append(']');
                }
                escapedName.Append(c);
            }
            // Append the string with an opening bracket.
            escapedName.Append(']');
            // Return the escaped string.
            return escapedName.ToString();
        }



...



        // Run a transactional query.
        private int ExecuteNonQuery(OleDbConnection connection, OleDbCommand command)
        {
            // Begin a transaction.
            OleDbTransaction transaction = connection.BeginTransaction();
            // Specify the transaction for the command.
            command.Transaction = transaction;
            try
            {
                // Run the query.
                int records = command.ExecuteNonQuery();
                // Test for the number of affected rows.
                if (records > 1)
                {
                    // Throw an error if more than one row was affected.
                    InvalidOperationException e = new InvalidOperationException();
                    e.Data["RowsAffected"] = records;
                    throw e;
                }
                // Commit the transaction.
                transaction.Commit();
                // Return the count of affected records.
                return records;
            }
            catch (Exception ex)
            {
                // Roll back the transaction if en exception occurred
                transaction.Rollback();
                // Raise an exception when an error occured.
                throw new ProviderException(ex.Message);
            }
        }



...



        private string CreateWhereClause(IList<ColumnDataInfo> list, OleDbCommand command, bool includeModifiedColumnsOnly)
        {
            // Create a new string builder for the SQL statement.
            StringBuilder whereClause = new StringBuilder();

            foreach (ColumnDataInfo info in list)
            {
                // Determine the OLEDB type for the column.
                OleDbType dbType = StringToOleDbType(info.TypeInfo.ToString());

                // Do not add binary fields.
                if (dbType != OleDbType.Binary)
                {
                    // Do not include modified columns if the flag is set true
                    if (!includeModifiedColumnsOnly || info.IsEdited)
                    {
                        whereClause.Append(EscapeName(info.ColumnName));

                        if (info.OriginalValue == null)
                        {
                            whereClause.Append(" IS NULL AND ");
                        }
                        else
                        {
                            whereClause.Append("=? AND ");

                            OleDbParameter param = command.CreateParameter();
                            param.OleDbType = dbType;
                            if (dbType == OleDbType.Guid)
                            {
                                // Convert the GUID string back to a GUID for the parameter.
                                param.Value = new Guid(info.OriginalValue.ToString());
                            }
                            else
                            {
                                // Add the parameter value.
                                param.Value = GetDataValue(info.OriginalValue);
                            }
                            command.Parameters.Add(param);
                        }
                    }
                }
            }

            whereClause.Remove(whereClause.Length - 5, 5);

            return whereClause.ToString();
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[IDbTableDataManager Interface](idbtabledatamanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

