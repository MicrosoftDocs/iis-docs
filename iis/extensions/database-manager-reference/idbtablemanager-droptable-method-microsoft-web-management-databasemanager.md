---
title: IDbTableManager.DropTable Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: DropTable Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbTableManager.DropTable(System.String,System.String,Microsoft.Web.Management.DatabaseManager.TableInfo)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.idbtablemanager.droptable(v=VS.90)
ms:contentKeyID: 22049612
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbTableManager.DropTable
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbTableManager.DropTable
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# IDbTableManager.DropTable Method

Removes a table from the database.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Sub DropTable ( _
    connectionString As String, _
    schema As String, _
    tableInfo As TableInfo _
)
'Usage
Dim instance As IDbTableManager
Dim connectionString As String
Dim schema As String
Dim tableInfo As TableInfo

instance.DropTable(connectionString, _
    schema, tableInfo)
```

```csharp
void DropTable(
    string connectionString,
    string schema,
    TableInfo tableInfo
)
```

```cpp
void DropTable(
    String^ connectionString, 
    String^ schema, 
    TableInfo^ tableInfo
)
```

```jscript
function DropTable(
    connectionString : String, 
    schema : String, 
    tableInfo : TableInfo
)
```

### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The connection string for the database.  

<!-- end list -->

  - schema  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The schema name for the table.  
    **Note**    If schema is empty, the default schema name will be used.  

<!-- end list -->

  - tableInfo  
    Type: [Microsoft.Web.Management.DatabaseManager.TableInfo](tableinfo-class-microsoft-web-management-databasemanager.md)  
    A [TableInfo](tableinfo-class-microsoft-web-management-databasemanager.md) object that contains the list of information about the table and columns.  

## Remarks

All database providers that implement the [IDbTableManager](idbtablemanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the DropTable method, which the database manager will use to remove a table from a database.

### 

### Notes for Implementers

If your provider does not support deleting tables, you can use the following code sample to raise a not-implemented exception:

    public void void DropTable(string connectionString, string schema, TableInfo tableInfo)
    {
       throw new NotImplementedException();
    }


> [!NOTE]  
> See the [DROP TABLE (Transact-SQL)](http://msdn.microsoft.com/en-us/library/ms173790.aspx) topic for more information about the DROP TABLE SQL statements.


## Examples

The following code sample shows how to use the DropTable method for an OLEDB connection by using the TableInfo object that the database manager provides.

```vb

    Public Sub DropTable(ByVal connectionString As String, ByVal schema As String, ByVal tableInfo As Microsoft.Web.Management.DatabaseManager.TableInfo) Implements Microsoft.Web.Management.DatabaseManager.IDbTableManager.DropTable
        ' Create a connection to the database.
        Dim connection As OleDbConnection = New OleDbConnection(connectionString)
        ' Open the connection to the database.
        connection.Open()
        ' Begin a transaction.
        Dim transaction As OleDbTransaction = connection.BeginTransaction
        Try
            ' Create the DROP TABLE SQL statement.
            Dim dropStatement As String = String.Format("DROP TABLE {0}", EscapeName(tableInfo.Name))
            ' Create an OLEDB command object.
            Dim command As OleDbCommand = New OleDbCommand(dropStatement, connection)
            ' Specify the transaction.
            command.Transaction = transaction
            ' Run the SQL statement.
            command.ExecuteNonQuery()
            ' Commit the transaction.
            transaction.Commit()
        Catch ex As Exception
            ' Roll back the transaction.
            transaction.Rollback()
            ' Raise an exception if an error occurs.
            Throw New ProviderException(("DROP TABLE Exception:" + vbCrLf + vbCrLf + ex.Message))
        Finally
            ' Close the database connection.
            connection.Close()
        End Try
    End Sub

```

```csharp

        public void DropTable(string connectionString, string schema, TableInfo tableInfo)
        {
            // Create a connection to the database.
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Open the connection to the database.
                connection.Open();
                // Begin a transaction.
                OleDbTransaction transaction = connection.BeginTransaction();
                try
                {
                    // Create the DROP TABLE SQL statement.
                    string dropStatement = String.Format("DROP TABLE {0}", EscapeName(tableInfo.Name));
                    // Create an OLEDB command object.
                    using (OleDbCommand command = new OleDbCommand(dropStatement, connection))
                    {
                        // Specify the transaction.
                        command.Transaction = transaction;
                        // Run the SQL statement.
                        command.ExecuteNonQuery();
                        // Commit the transaction.
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    // Roll back the transaction.
                    transaction.Rollback();
                    // Raise an exception if an error occurs.
                    throw new ProviderException("DROP TABLE Exception:\n\n" + ex.Message);
                }
                finally
                {
                    // Close the database connection.
                    connection.Close();
                }
            }
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[IDbTableManager Interface](idbtablemanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

