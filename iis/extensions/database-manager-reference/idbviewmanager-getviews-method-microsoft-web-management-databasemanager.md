---
title: IDbViewManager.GetViews Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: GetViews Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbViewManager.GetViews(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.idbviewmanager.getviews(v=VS.90)
ms:contentKeyID: 20476455
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbViewManager.GetViews
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbViewManager.GetViews
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IDbViewManager.GetViews Method

Retrieves a list of views in a database.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Function GetViews ( _
    connectionString As String _
) As ICollection(Of View)
'Usage
Dim instance As IDbViewManager
Dim connectionString As String
Dim returnValue As ICollection(Of View)

returnValue = instance.GetViews(connectionString)
```

```csharp
ICollection<View> GetViews(
    string connectionString
)
```

```cpp
ICollection<View^>^ GetViews(
    String^ connectionString
)
```

```jscript
function GetViews(
    connectionString : String
) : ICollection<View>
```

### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The connection string for the database.  

### Return Value

Type: [System.Collections.Generic.ICollection](https://msdn.microsoft.com/library/92t2ye13)\<[View](view-class-microsoft-web-management-databasemanager.md)\>  
An ICollection object that contains the list of [View](view-class-microsoft-web-management-databasemanager.md) objects.  

## Remarks

All database providers that implement the [IDbViewManager](idbviewmanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the GetViews method, which the database manager will use to retrieve a list of views from a database.

### 

### Notes for Implementers

If your provider does not support retrieving the list of views, you can use the following code sample to raise a not-implemented exception:

public ICollection\<View\> GetViews(string connectionString)

{

   throw new NotImplementedException();

}

## Examples

The following code sample implements the GetViews method to retrieve a list of views from a database in an OLEDB data source.

```vb

    ' Retrieve the list of views from a database.
    Public Function GetViews( _
            ByVal connectionString As String) _
            As System.Collections.Generic.ICollection( _
            Of Microsoft.Web.Management.DatabaseManager.View) _
            Implements Microsoft.Web.Management.DatabaseManager.IDbViewManager.GetViews

        ' Create a new list to hold the view information.
        Dim views As List(Of View) = New List(Of View)
        ' Create a new database connection.
        Dim connection As OleDbConnection = New OleDbConnection(connectionString)
        ' Open the database connection.
        connection.Open()
        ' Retrieve the schema information for the views.
        Dim schema As DataTable = connection.GetSchema(OleDbMetaDataCollectionNames.Views)
        ' Loop through the collection of views.
        For Each row As DataRow In schema.Rows
            ' Create a new view object.
            Dim view As View = New View
            ' Retrieve the name of the view.
            view.Name = CType(row("TABLE_NAME"), String)
            ' Retrieve the table schema for the view.
            If DBNull.Value.Equals(row("TABLE_SCHEMA")) Then
                view.Schema = String.Empty
            Else
                view.Schema = row("TABLE_SCHEMA").ToString()
            End If
            ' Retrieve the definition for the view.
            view.Definition = CType(row("VIEW_DEFINITION"), String)
            ' Add the view to the list.
            views.Add(view)
        Next
        ' Return the list of views.
        Return views

    End Function

```

```csharp

        // Retrieve the list of views from a database.
        public ICollection<View> GetViews(string connectionString)
        {
            // Create a new list to hold the view information.
            List<View> views = new List<View>();
            // Create a new database connection.
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Open the database connection.
                connection.Open();
                // Retrieve the schema information for the views.
                DataTable schema = connection.GetSchema(OleDbMetaDataCollectionNames.Views);
                // Loop through the collection of views.
                foreach (DataRow row in schema.Rows)
                {
                    // Create a new view object.
                    View view = new View();
                    // Retrieve the name of the view.
                    view.Name = (string)row["TABLE_NAME"];
                    // Retrieve the table schema for the view.
                    view.Schema = (string)(row["TABLE_SCHEMA"] == DBNull.Value ? String.Empty : row["TABLE_SCHEMA"]);
                    // Retrieve the definition for the view.
                    view.Definition = (string)row["VIEW_DEFINITION"];
                    // Add the view to the list.
                    views.Add(view);
                }
            }
            // Return the list of views.
            return views;
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[IDbViewManager Interface](idbviewmanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
