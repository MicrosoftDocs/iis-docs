---
title: IDbViewManager.DropView Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: DropView Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbViewManager.DropView(System.String,System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.idbviewmanager.dropview(v=VS.90)
ms:contentKeyID: 20476741
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbViewManager.DropView
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbViewManager.DropView
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IDbViewManager.DropView Method

Removes a view from the database.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Sub DropView ( _
    connectionString As String, _
    schema As String, _
    viewName As String _
)
'Usage
Dim instance As IDbViewManager
Dim connectionString As String
Dim schema As String
Dim viewName As String

instance.DropView(connectionString, schema, _
    viewName)
```

```csharp
void DropView(
    string connectionString,
    string schema,
    string viewName
)
```

```cpp
void DropView(
    String^ connectionString, 
    String^ schema, 
    String^ viewName
)
```

```jscript
function DropView(
    connectionString : String, 
    schema : String, 
    viewName : String
)
```

### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The connection string for the database.  

<!-- end list -->

  - schema  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The schema name for the view.  
    **Note**    If schema is empty, the default schema name will be used.  

<!-- end list -->

  - viewName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The name of the view to drop.  

## Remarks

All database providers that implement the [IDbViewManager](idbviewmanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the DropView method, which the database manager will use to remove a view from a database.

### 

### Notes for Implementers

If your provider does not support deleting views, you can use the following code sample to raise a not-implemented exception:

public void DropView(string connectionString, string schema, string viewName)

{

   throw new NotImplementedException();

}

> [!NOTE]  
> See the [DROP VIEW (Transact-SQL)](https://msdn.microsoft.com/library/ms173492.aspx) topic for more information about the DROP VIEW SQL statement.

## Examples

The following code sample implements the DropView method to remove a view from a database in an OLEDB data source.

```vb

    ' Remove a view from the database.
    Public Sub DropView( _
            ByVal connectionString As String, _
            ByVal schema As String, _
            ByVal viewName As String) _
            Implements Microsoft.Web.Management.DatabaseManager.IDbViewManager.DropView

        ' Create a new database connection.
        Dim connection As OleDbConnection = New OleDbConnection(connectionString)
        ' Create the SQL for the CREATE VIEW statement.
        Dim dropView As String = String.Format("DROP VIEW {0}", EscapeName(viewName))
        ' Create an OLEDB command object.
        Dim command As OleDbCommand = New OleDbCommand(dropView, connection)
        ' Open the database connection.
        connection.Open()
        ' Execute the SQL statement.
        command.ExecuteNonQuery()

    End Sub

```

```csharp

        // Remove a view from the database.
        public void DropView(string connectionString, string schema, string viewName)
        {
            // Create a new database connection.
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Create the SQL for the CREATE VIEW statement.
                string dropView = String.Format("DROP VIEW {0}", EscapeName(viewName));
                // Create an OLEDB command object.
                using (OleDbCommand command = new OleDbCommand(dropView, connection))
                {
                    // Open the database connection.
                    connection.Open();
                    // Execute the SQL statement.
                    command.ExecuteNonQuery();
                }
            }
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[IDbViewManager Interface](idbviewmanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
