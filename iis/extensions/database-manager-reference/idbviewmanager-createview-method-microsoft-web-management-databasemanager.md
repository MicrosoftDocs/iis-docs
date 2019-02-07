---
title: IDbViewManager.CreateView Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: CreateView Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbViewManager.CreateView(System.String,System.String,Microsoft.Web.Management.DatabaseManager.View)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.idbviewmanager.createview(v=VS.90)
ms:contentKeyID: 20476744
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbViewManager.CreateView
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbViewManager.CreateView
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IDbViewManager.CreateView Method

Creates a view within the database.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Sub CreateView ( _
    connectionString As String, _
    schema As String, _
    view As View _
)
'Usage
Dim instance As IDbViewManager
Dim connectionString As String
Dim schema As String
Dim view As View

instance.CreateView(connectionString, _
    schema, view)
```

``` csharp
void CreateView(
    string connectionString,
    string schema,
    View view
)
```

``` c++
void CreateView(
    String^ connectionString, 
    String^ schema, 
    View^ view
)
```

``` jscript
function CreateView(
    connectionString : String, 
    schema : String, 
    view : View
)
```

#### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The connection string for the database.  

<!-- end list -->

  - schema  
    Type: [System.String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The schema name for the view.  
    **Note**    If schema is empty, the default schema name will be used.  

<!-- end list -->

  - view  
    Type: [Microsoft.Web.Management.DatabaseManager.View](view-class-microsoft-web-management-databasemanager.md)  
    The [View](view-class-microsoft-web-management-databasemanager.md) object for the view to create.  

## Remarks

All database providers that implement the [IDbViewManager](idbviewmanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the CreateView method, which the database manager will use to create a view in a database.

### 

#### Notes for Implementers

If your provider does not support creating views, you can use the following code sample to raise a not-implemented exception:

public void CreateView(string connectionString, string schema, View view)

{

   throw new NotImplementedException();

}


> [!NOTE]  
> See the [CREATE VIEW (Transact-SQL)](http://msdn.microsoft.com/en-us/library/ms187956.aspx) topic for more information about the CREATE VIEW SQL statement.


## Examples

The following code sample implements the CreateView method to add a view to a database in an OLEDB data source.

``` vb

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

``` csharp

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

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[IDbViewManager Interface](idbviewmanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

