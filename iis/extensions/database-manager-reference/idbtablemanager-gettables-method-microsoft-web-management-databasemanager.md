---
title: IDbTableManager.GetTables Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: GetTables Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbTableManager.GetTables(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.idbtablemanager.gettables(v=VS.90)
ms:contentKeyID: 20476482
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbTableManager.GetTables
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbTableManager.GetTables
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IDbTableManager.GetTables Method

Returns a list of tables from a database.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Function GetTables ( _
    connectionString As String _
) As ICollection(Of Table)
'Usage
Dim instance As IDbTableManager
Dim connectionString As String
Dim returnValue As ICollection(Of Table)

returnValue = instance.GetTables(connectionString)
```

```csharp
ICollection<Table> GetTables(
    string connectionString
)
```

```cpp
ICollection<Table^>^ GetTables(
    String^ connectionString
)
```

```jscript
function GetTables(
    connectionString : String
) : ICollection<Table>
```

### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The connection string for the database.  

### Return Value

Type: [System.Collections.Generic.ICollection](https://msdn.microsoft.com/library/92t2ye13)\<[Table](table-class-microsoft-web-management-databasemanager.md)\>  
An ICollection object that contains the collection of [Table](table-class-microsoft-web-management-databasemanager.md) objects.  

## Remarks

All database providers that implement the [IDbTableManager](idbtablemanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the GetTables method, which the database manager will use to retrieve the list of tables for a database.

## Examples

The following code sample implements the GetTables method to retrieve the list of tables for an OLEDB connection by using the connection string that the database manager provides.

```vb

    Public Function GetTables(ByVal connectionString As String) As System.Collections.Generic.ICollection(Of Table) Implements Microsoft.Web.Management.DatabaseManager.IDbTableManager.GetTables
        Dim tables As List(Of Table) = New List(Of Table)
        ' Create a connection to the database.
        Dim connection As OleDbConnection = New OleDbConnection(connectionString)
        ' Open the connection to the database.
        connection.Open()
        Dim restrictions() As String = New String((4) - 1) {}
        restrictions(3) = "TABLE"
        ' Open the schema information for the tables.
        Dim schema As DataTable = connection.GetSchema(OleDbMetaDataCollectionNames.Tables, restrictions)
        ' Enumerate the list of tables.
        For Each row As DataRow In schema.Rows
            ' Create a new table object.
            Dim table As Table = New Table
            ' Specify the table name.
            table.Name = CType(row("TABLE_NAME"), String)
            ' Test for a creation date.
            If Not DBNull.Value.Equals(row("DATE_CREATED")) Then
                ' Create a date/time object.
                Dim createDate As DateTime = New DateTime
                ' Parse the creation date for the table.
                If DateTime.TryParse(row("DATE_CREATED").ToString, createDate) Then
                    ' Specify the creation date for the table.
                    table.CreateDate = createDate
                End If
            End If
            ' Specify the table schema.
            If Not DBNull.Value.Equals(row("TABLE_SCHEMA")) Then
                table.Schema = CType(row("TABLE_SCHEMA"), String)
            Else
                table.Schema = String.Empty
            End If
            ' Add the table to the list of tables.
            tables.Add(table)
        Next
        ' Return the list of tables.
        Return tables

    End Function

```

```csharp

        // Retrieve the list of tables.
        public ICollection<Table> GetTables(string connectionString)
        {
            List<Table> tables = new List<Table>();

            // Create a connection to the database.
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Open the connection to the database.
                connection.Open();
                string[] restrictions = new string[4];
                restrictions[3] = "TABLE";

                // Open the schema information for the tables.
                DataTable schema = connection.GetSchema(OleDbMetaDataCollectionNames.Tables, restrictions);
                // Enumerate the list of tables.
                foreach (DataRow row in schema.Rows)
                {
                    // Create a new table object.
                    Table table = new Table();
                    // Specify the table name.
                    table.Name = (string)row["TABLE_NAME"];
                    // Test for a creation date.
                    if (row["DATE_CREATED"] != DBNull.Value)
                    {
                        // Create a date/time object.
                        DateTime createDate = new DateTime();
                        // Parse the creation date for the table.
                        if (DateTime.TryParse(row["DATE_CREATED"].ToString(),out createDate))
                        {
                            // Specify the creation date for the table.
                            table.CreateDate = createDate;
                        }
                    }
                    // Specify the table schema.
                    table.Schema = (string)(row["TABLE_SCHEMA"] == DBNull.Value ? String.Empty : row["TABLE_SCHEMA"]);
                    // Add the table to the list of tables.
                    tables.Add(table);
                }
            }
            // Return the list of tables.
            return tables;
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[IDbTableManager Interface](idbtablemanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

