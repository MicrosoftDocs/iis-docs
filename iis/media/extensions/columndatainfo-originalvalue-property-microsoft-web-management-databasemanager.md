---
title: ColumnDataInfo.OriginalValue Property  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: OriginalValue Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.ColumnDataInfo.OriginalValue
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.columndatainfo.originalvalue(v=VS.90)
ms:contentKeyID: 20476421
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.ColumnDataInfo.OriginalValue
- Microsoft.Web.Management.DatabaseManager.ColumnDataInfo.get_OriginalValue
- Microsoft.Web.Management.DatabaseManager.ColumnDataInfo.set_OriginalValue
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.ColumnDataInfo.get_OriginalValue
- Microsoft.Web.Management.DatabaseManager.ColumnDataInfo.OriginalValue
- Microsoft.Web.Management.DatabaseManager.ColumnDataInfo.set_OriginalValue
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ColumnDataInfo.OriginalValue Property

Gets or sets an object that represents the original value.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Public Property OriginalValue As Object
'Usage
Dim instance As ColumnDataInfo
Dim value As Object

value = instance.OriginalValue
```

``` csharp
public Object OriginalValue { get; internal set; }
```

``` c++
public:
property Object^ OriginalValue {
    Object^ get ();
    internal: void set (Object^ value);
}
```

``` jscript
function get OriginalValue () : Object
internal function set OriginalValue (value : Object)
```

#### Property Value

Type: [System.Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
An object that represents the original value that was contained in the column.  

## Examples

The following code sample implements the EditRow method to insert data into a database table in an OLEDB data source.


> [!NOTE]
> <P>This example also provides helper methods that perform additional database tasks.</P>



``` vb

    Public Sub EditRow( _
            ByVal connectionString As String, _
            ByVal tableName As String, _
            ByVal schema As String, _
            ByVal columnDataInfoList _
            As System.Collections.Generic.IList( _
            Of Microsoft.Web.Management.DatabaseManager.ColumnDataInfo)) _
            Implements Microsoft.Web.Management.DatabaseManager.IDbTableDataManager.EditRow

        Dim connection As OleDbConnection = New OleDbConnection(connectionString)
        Dim command As OleDbCommand = New OleDbCommand
        command.Connection = connection
        command.CommandType = CommandType.Text
        Dim setClause As String = CreateSetClause(columnDataInfoList, command)
        Dim whereClause As String = CreateWhereClause(columnDataInfoList, command, False)
        command.CommandText = String.Format("UPDATE {0} SET {1} WHERE {2}", EscapeName(tableName), setClause, whereClause)
        ' Open the database connection.
        connection.Open()
        ' Run the query.
        ExecuteNonQuery(connection, command)
        ' Close the database connection.
        connection.Close()

    End Sub



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




...



    Private Function CreateSetClause( _
            ByVal list As IList(Of ColumnDataInfo), _
            ByVal command As OleDbCommand) As String

        ' Create a new string builder for the SQL statement.
        Dim setClause As StringBuilder = New StringBuilder
        For Each info As ColumnDataInfo In list
            ' Determine the OLEDB type for the column.
            Dim dbType As OleDbType = StringToOleDbType(info.TypeInfo.ToString)
            If info.IsEdited Then
                setClause.Append(EscapeName(info.ColumnName))
                setClause.Append("=?, ")
                Dim param As OleDbParameter = command.CreateParameter
                If (dbType = OleDbType.Guid) Then
                    ' Convert the GUID string back to a GUID for the parameter.
                    param.Value = New Guid(info.NewValue.ToString)
                Else
                    ' Add the parameter value.
                    param.Value = GetDataValue(info.NewValue)
                End If
                param.OleDbType = dbType
                command.Parameters.Add(param)
            End If
        Next
        setClause.Remove((setClause.Length - 2), 2)
        Return setClause.ToString

    End Function

```

``` csharp

public void EditRow(string connectionString, string tableName, string schema, IList<ColumnDataInfo> columnDataInfoList)
{
    using (OleDbConnection connection = new OleDbConnection(connectionString))
    {
        using (OleDbCommand command = new OleDbCommand())
        {
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            string setClause = CreateSetClause(columnDataInfoList, command);
            string whereClause = CreateWhereClause(columnDataInfoList, command, false);

            command.CommandText = String.Format("UPDATE {0} SET {1} WHERE {2}", EscapeName(tableName), setClause, whereClause);

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



...



        private string CreateSetClause(IList<ColumnDataInfo> list, OleDbCommand command)
        {
            // Create a new string builder for the SQL statement.
            StringBuilder setClause = new StringBuilder();

            foreach (ColumnDataInfo info in list)
            {
                // Determine the OLEDB type for the column.
                OleDbType dbType = StringToOleDbType(info.TypeInfo.ToString());

                if (info.IsEdited)
                {
                    setClause.Append(EscapeName(info.ColumnName));
                    setClause.Append("=?, ");
                    OleDbParameter param = command.CreateParameter();

                    if (dbType == OleDbType.Guid)
                    {
                        // Convert the GUID string back to a GUID for the parameter.
                        param.Value = new Guid(info.NewValue.ToString());
                    }
                    else
                    {
                        // Add the parameter value.
                        param.Value = GetDataValue(info.NewValue);
                    }
                    param.OleDbType = dbType;
                    command.Parameters.Add(param);
                }
            }

            setClause.Remove(setClause.Length - 2, 2);

            return setClause.ToString();
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ColumnDataInfo Class](columndatainfo-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

