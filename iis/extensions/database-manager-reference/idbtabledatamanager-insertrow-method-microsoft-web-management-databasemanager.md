---
title: IDbTableDataManager.InsertRow Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: InsertRow Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbTableDataManager.InsertRow(System.String,System.String,System.String,System.Collections.Generic.IList{Microsoft.Web.Management.DatabaseManager.ColumnDataInfo})
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.idbtabledatamanager.insertrow(v=VS.90)
ms:contentKeyID: 20476803
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbTableDataManager.InsertRow
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbTableDataManager.InsertRow
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IDbTableDataManager.InsertRow Method

Inserts a row of data into a table.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Function InsertRow ( _
    connectionString As String, _
    tableName As String, _
    schema As String, _
    columnDataInfoList As IList(Of ColumnDataInfo) _
) As Object()
'Usage
Dim instance As IDbTableDataManager
Dim connectionString As String
Dim tableName As String
Dim schema As String
Dim columnDataInfoList As IList(Of ColumnDataInfo)
Dim returnValue As Object()

returnValue = instance.InsertRow(connectionString, _
    tableName, schema, columnDataInfoList)
```

```csharp
Object[] InsertRow(
    string connectionString,
    string tableName,
    string schema,
    IList<ColumnDataInfo> columnDataInfoList
)
```

```cpp
array<Object^>^ InsertRow(
    String^ connectionString, 
    String^ tableName, 
    String^ schema, 
    IList<ColumnDataInfo^>^ columnDataInfoList
)
```

```jscript
function InsertRow(
    connectionString : String, 
    tableName : String, 
    schema : String, 
    columnDataInfoList : IList<ColumnDataInfo>
) : Object[]
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
    An IList object that contains a list of [ColumnDataInfo](columndatainfo-class-microsoft-web-management-databasemanager.md) objects to insert.  

### Return Value

Type: array\<[System.Object](https://msdn.microsoft.com/library/e5kfa45b)\[\]  
An object array that contains the data that was inserted and any computed values, such as identities.  

## Remarks

All database providers that implement the [IDbTableDataManager](idbtabledatamanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the InsertRow method. The database manager will use this method to insert data into a table of a database.

### 

### Notes for Implementers

If your provider does not support inserting rows, you can use the following code sample to raise a not-implemented exception:

public object\[\] InsertRow(string connectionString, string tableName, string schema, IList\<ColumnDataInfo\> columnDataInfoList)

{

   throw new NotImplementedException();

}


> [!NOTE]  
> See the [INSERT (Transact-SQL)](https://msdn.microsoft.com/library/ms174335.aspx) topic for more information about the INSERT SQL statement.


## Examples

The following code sample implements the InsertRow method to insert data into a database table in an OLEDB data source.


> [!NOTE]  
> This example also provides helper methods that perform additional database tasks.


```vb

    Public Function InsertRow( _
            ByVal connectionString As String, _
            ByVal tableName As String, _
            ByVal schema As String, _
            ByVal columnDataInfoList _
            As System.Collections.Generic.IList( _
            Of Microsoft.Web.Management.DatabaseManager.ColumnDataInfo)) _
            As Object() _
            Implements Microsoft.Web.Management.DatabaseManager.IDbTableDataManager.InsertRow

        Dim insertFieldsText As StringBuilder = New StringBuilder
        Dim valuesText As StringBuilder = New StringBuilder
        Dim whereText As StringBuilder = New StringBuilder
        Dim selectFieldsText As StringBuilder = New StringBuilder

        Dim insertedRow() As Object = Nothing
        Dim connection As OleDbConnection = New OleDbConnection(connectionString)
        Dim command As OleDbCommand = New OleDbCommand
        command.Connection = connection
        command.CommandType = CommandType.Text

        For Each info As ColumnDataInfo In columnDataInfoList
            ' Append the column to the SELECT fields.
            selectFieldsText.Append(EscapeName(info.ColumnName))
            selectFieldsText.Append(",")
            ' Only update modified fields.
            If (info.IsEdited = True) Then
                ' Append the column to the INSERT fields.
                insertFieldsText.Append(EscapeName(info.ColumnName))
                insertFieldsText.Append(",")
                valuesText.Append("?,")
                ' Append the column to the WHERE statement.
                whereText.Append(String.Format("({0} = ?)", EscapeName(info.ColumnName)))
                whereText.Append(" AND ")
                ' Determine the OLEDB type for the column.
                Dim dbType As OleDbType = StringToOleDbType(info.TypeInfo.ToString)
                ' 
                Dim parameter As OleDbParameter = command.CreateParameter
                parameter.ParameterName = ("@" + info.ColumnName)
                parameter.OleDbType = dbType
                ' Test if the column is a GUID field.
                If (dbType = OleDbType.Guid) Then
                    ' Convert the GUID string back to a GUID for the parameter.
                    parameter.Value = New Guid(info.NewValue.ToString)
                Else
                    ' Add the parameter value.
                    parameter.Value = GetDataValue(info.NewValue)
                End If
                parameter.Direction = ParameterDirection.Input
                command.Parameters.Add(parameter)
            End If
        Next
        insertFieldsText.Remove((insertFieldsText.Length - 1), 1)
        valuesText.Remove((valuesText.Length - 1), 1)
        whereText.Remove((whereText.Length - 5), 5)
        selectFieldsText.Remove((selectFieldsText.Length - 1), 1)
        command.CommandText = String.Format("INSERT INTO {0} ({1}) VALUES({2})", EscapeName(tableName), insertFieldsText.ToString, valuesText.ToString)
        ' Open the database connection.
        connection.Open()
        ' Run the query.
        ExecuteNonQuery(connection, command)
        ' Close the database connection.
        connection.Close()
        Return insertedRow

    End Function



...


    Private Shared Function ConvertToSerializable(ByVal data As Object) As Object
        If (TypeOf data Is DBNull) Then
            Return Nothing
        ElseIf (TypeOf data Is Decimal) Then
            Return CType(CType(data, Decimal), Double)
        ElseIf (TypeOf data Is Guid) Then
            Return data.ToString
        Else
            Return data
        End If
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



    Private Shared Function GetDataValue(ByVal value As Object) As Object
        If (value Is Nothing) Then
            Return DBNull.Value
        Else
            Return value
        End If
    End Function

```

```csharp

        public object[] InsertRow(string connectionString, string tableName, string schema, IList<ColumnDataInfo> columnDataInfoList)
        {
            StringBuilder insertFieldsText = new StringBuilder();
            StringBuilder valuesText = new StringBuilder();
            StringBuilder whereText = new StringBuilder();
            StringBuilder selectFieldsText = new StringBuilder();
            Object[] insertedRow = null;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;

                    foreach (ColumnDataInfo info in columnDataInfoList)
                    {
                        // Append the column to the SELECT fields.
                        selectFieldsText.Append(EscapeName(info.ColumnName));
                        selectFieldsText.Append(",");

                        // Only update modified fields.
                        if (info.IsEdited == true)
                        {
                            // Append the column to the INSERT fields.
                            insertFieldsText.Append(EscapeName(info.ColumnName));
                            insertFieldsText.Append(",");

                            valuesText.Append("?,");

                            // Append the column to the WHERE statement.
                            whereText.Append(string.Format("({0} = ?)", EscapeName(info.ColumnName)));
                            whereText.Append(" AND ");

                            // Determine the OLEDB type for the column.
                            OleDbType dbType = StringToOleDbType(info.TypeInfo.ToString());

                            // 
                            OleDbParameter parameter = command.CreateParameter();
                            parameter.ParameterName = "@" + info.ColumnName;
                            parameter.OleDbType = dbType;

                            // Test if the column is a GUID field.
                            if (dbType == OleDbType.Guid)
                            {
                                // Convert the GUID string back to a GUID for the parameter.
                                parameter.Value = new Guid(info.NewValue.ToString());
                            }
                            else
                            {
                                // Add the parameter value.
                                parameter.Value = GetDataValue(info.NewValue);
                            }

                            parameter.Direction = ParameterDirection.Input;
                            command.Parameters.Add(parameter);
                        }
                    }

                    insertFieldsText.Remove(insertFieldsText.Length - 1, 1);
                    valuesText.Remove(valuesText.Length - 1, 1);
                    whereText.Remove(whereText.Length - 5, 5);
                    selectFieldsText.Remove(selectFieldsText.Length - 1, 1);

                    command.CommandText = String.Format("INSERT INTO {0} ({1}) VALUES({2})", EscapeName(tableName), insertFieldsText.ToString(), valuesText.ToString());

                    // Open the database connection.
                    connection.Open();
                    // Run the query.
                    ExecuteNonQuery(connection,command);
                    // Close the database connection.
                    connection.Close();
                }
            }

            return insertedRow;
        }



...



        private static object ConvertToSerializable(object data)
        {
            if (data is DBNull)
            {
                return null;
            }
            else if (data is Decimal)
            {
                return (double)((Decimal)data);
            }
            else if (data is Guid)
            {
                return data.ToString();
            }
            else
            {
                return data;
            }
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



        // Compute if a data value is null.
        private static object GetDataValue(object value)
        {
            return (value == null ? DBNull.Value : value);
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[IDbTableDataManager Interface](idbtabledatamanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

