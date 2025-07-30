---
title: IDbTableManager.GetPrimaryKey Method  (Microsoft.Web.Management.DatabaseManager)
description: Describes the IDbTableManager.GetPrimaryKey method and provides the method's syntax, remarks, examples, and permissions.
TOCTitle: GetPrimaryKey Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbTableManager.GetPrimaryKey(System.String,System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.idbtablemanager.getprimarykey(v=VS.90)
ms:contentKeyID: 20476398
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbTableManager.GetPrimaryKey
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbTableManager.GetPrimaryKey
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
ms.custom: sfi-ropc-nochange
---

# IDbTableManager.GetPrimaryKey Method

Returns a list of primary keys for the specified table.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Function GetPrimaryKey ( _
    connectionString As String, _
    tableName As String, _
    schema As String _
) As String()
'Usage
Dim instance As IDbTableManager
Dim connectionString As String
Dim tableName As String
Dim schema As String
Dim returnValue As String()

returnValue = instance.GetPrimaryKey(connectionString, _
    tableName, schema)
```

```csharp
string[] GetPrimaryKey(
    string connectionString,
    string tableName,
    string schema
)
```

```cpp
array<String^>^ GetPrimaryKey(
    String^ connectionString, 
    String^ tableName, 
    String^ schema
)
```

```jscript
function GetPrimaryKey(
    connectionString : String, 
    tableName : String, 
    schema : String
) : String[]
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
    **Note**    If schema is empty, the default schema name will be used.  

### Return Value

Type: array\<[System.String](https://msdn.microsoft.com/library/s1wwdcbf)\[\]  
The array of primary keys.  

## Remarks

All database providers that implement the [IDbTableManager](idbtablemanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the GetPrimaryKey method, which the database manager will use to retrieve an array of primary keys from a database.

### Notes for Implementers

If your provider does not support retrieving the list of primary keys, you can use the following code sample to raise a not-implemented exception:

```csharp
public string[] GetPrimaryKey(string connectionString, string tableName, string schema)
{
    throw new NotImplementedException();
}
```

## Examples

The following code sample shows how to use the GetPrimaryKey method to retrieve the list of primary keys for an OLEDB connection by using the table name that the database manager provides.

```vb

    Public Function GetPrimaryKey( _
            ByVal connectionString As String, _
            ByVal tableName As String, _
            ByVal schema As String) As String() _
            Implements Microsoft.Web.Management.DatabaseManager.IDbTableManager.GetPrimaryKey

        Dim restrictions() As String = New String() {Nothing, Nothing, tableName}
        Dim dataTable As DataTable
        Dim primaryKeys As List(Of String) = New List(Of String)
        ' Create a connection to the database.
        Dim connection As OleDbConnection = New OleDbConnection(connectionString)
        connection.Open()
        ' Open the schema information for the primary keys.
        dataTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Primary_Keys, restrictions)
        ' Enumerate the table's primary keys.
        For Each row As DataRow In dataTable.Rows
            ' Append each primary key to the list.
            primaryKeys.Add(row("COLUMN_NAME").ToString)
        Next
        ' Return the list of primary keys.
        Return primaryKeys.ToArray

    End Function

```

```csharp

        // Retrieve a list of primary keys for a table.
        public string[] GetPrimaryKey(string connectionString, string tableName, string schema)
        {
            String[] restrictions = new string[] { null, null, tableName };
            DataTable dataTable;
            List<string> primaryKeys = new List<string>();

            // Create a connection to the database.
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                // Open the schema information for the primary keys.
                dataTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Primary_Keys, restrictions);
                // Enumerate the table's primary keys.
                foreach (DataRow row in dataTable.Rows)
                {
                    // Append each primary key to the list.
                    primaryKeys.Add(row["COLUMN_NAME"].ToString());
                }
            }
            // Return the list of primary keys.
            return primaryKeys.ToArray();
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[IDbTableManager Interface](idbtablemanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
