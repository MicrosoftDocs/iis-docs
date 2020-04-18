---
title: IDbViewManager.EditView Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: EditView Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbViewManager.EditView(System.String,System.String,Microsoft.Web.Management.DatabaseManager.View)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.idbviewmanager.editview(v=VS.90)
ms:contentKeyID: 20476436
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbViewManager.EditView
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbViewManager.EditView
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IDbViewManager.EditView Method

Modifies the definition of a view in the database.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Sub EditView ( _
    connectionString As String, _
    schema As String, _
    view As View _
)
'Usage
Dim instance As IDbViewManager
Dim connectionString As String
Dim schema As String
Dim view As View

instance.EditView(connectionString, schema, _
    view)
```

```csharp
void EditView(
    string connectionString,
    string schema,
    View view
)
```

```cpp
void EditView(
    String^ connectionString, 
    String^ schema, 
    View^ view
)
```

```jscript
function EditView(
    connectionString : String, 
    schema : String, 
    view : View
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
    **Note**    If schema is empty, the default schema name will be used.  

<!-- end list -->

  - view  
    Type: [Microsoft.Web.Management.DatabaseManager.View](view-class-microsoft-web-management-databasemanager.md)  
    The [View](view-class-microsoft-web-management-databasemanager.md) object for the view to edit.  

## Remarks

All database providers that implement the [IDbViewManager](idbviewmanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the EditView method, which the database manager will use to modify a view in a database.

### 

### Notes for Implementers

If your provider does not support editing views, you can use the following code sample to raise a not-implemented exception:

public void EditView(string connectionString, string schema, View view)

{

   throw new NotImplementedException();

}

> [!NOTE]  
> See the [ALTER VIEW (Transact-SQL)](https://msdn.microsoft.com/library/ms173846.aspx) topic for more information about the ALTER VIEW SQL statement.

## Examples

The following code sample implements the EditView method to modify a view in a database in an OLEDB data source.

```vb

    Public Sub EditView( _
            ByVal connectionString As String, _
            ByVal schema As String, _
            ByVal view As Microsoft.Web.Management.DatabaseManager.View) _
            Implements Microsoft.Web.Management.DatabaseManager.IDbViewManager.EditView

        ' Create a new database connection.
        Dim connection As OleDbConnection = New OleDbConnection(connectionString)
        ' Create the SQL for the CREATE VIEW statement.
        Dim dropView As String = String.Format("DROP VIEW {0}", EscapeName(view.Name))
        ' Create the SQL for the CREATE VIEW statement.
        Dim createView As String = String.Format("CREATE VIEW {0} AS {1}", EscapeName(view.Name), view.Definition)
        ' Create a transaction.
        Dim transaction As OleDbTransaction = Nothing
        Try
            ' Open the database connection.
            connection.Open()
            ' Begin a transaction.
            transaction = connection.BeginTransaction
            ' Create an OLEDB command object.
            Dim command As OleDbCommand = New OleDbCommand
            ' Specify the connection for the command.
            command.Connection = connection
            ' Specify the transaction for the command.
            command.Transaction = transaction
            ' Specify the DROP VIEW syntax.
            command.CommandText = dropView
            ' Execute the SQL statement.
            command.ExecuteNonQuery()
            ' Specify the CREATE VIEW syntax.
            command.CommandText = createView
            ' Execute the SQL statement.
            command.ExecuteNonQuery()
            ' Commit the transaction.
            transaction.Commit()
        Catch ex As Exception
            ' Roll back the transaction if en exception occurred
            transaction.Rollback()
            ' Raise an exception when an error occured.
            Throw New ProviderException(ex.Message)
        Finally
            ' Close the database connection.
            connection.Close()
        End Try

    End Sub

```

```csharp

        public void EditView(string connectionString, string schema, View view)
        {
            // Create a new database connection.
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Create the SQL for the CREATE VIEW statement.
                string dropView = String.Format("DROP VIEW {0}", EscapeName(view.Name));
                // Create the SQL for the CREATE VIEW statement.
                string createView = String.Format("CREATE VIEW {0} AS {1}", EscapeName(view.Name), view.Definition);
                // Create a transaction.
                OleDbTransaction transaction = null;

                try
                {
                    // Open the database connection.
                    connection.Open();
                    // Begin a transaction.
                    transaction = connection.BeginTransaction();

                    // Create an OLEDB command object.
                    using (OleDbCommand command = new OleDbCommand())
                    {
                        // Specify the connection for the command.
                        command.Connection = connection;
                        // Specify the transaction for the command.
                        command.Transaction = transaction;

                        // Specify the DROP VIEW syntax.
                        command.CommandText = dropView;
                        // Execute the SQL statement.
                        command.ExecuteNonQuery();

                        // Specify the CREATE VIEW syntax.
                        command.CommandText = createView;
                        // Execute the SQL statement.
                        command.ExecuteNonQuery();

                        // Commit the transaction.
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    // Roll back the transaction if en exception occurred
                    transaction.Rollback();
                    // Raise an exception when an error occured.
                    throw new ProviderException(ex.Message);
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

[IDbViewManager Interface](idbviewmanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
