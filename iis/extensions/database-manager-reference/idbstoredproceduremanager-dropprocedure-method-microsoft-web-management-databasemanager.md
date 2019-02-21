---
title: IDbStoredProcedureManager.DropProcedure Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: DropProcedure Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.DropProcedure(System.String,System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.idbstoredproceduremanager.dropprocedure(v=VS.90)
ms:contentKeyID: 20476801
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.DropProcedure
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.DropProcedure
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# IDbStoredProcedureManager.DropProcedure Method

Removes a stored procedure from a database.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Sub DropProcedure ( _
    connectionString As String, _
    schema As String, _
    procedureName As String _
)
'Usage
Dim instance As IDbStoredProcedureManager
Dim connectionString As String
Dim schema As String
Dim procedureName As String

instance.DropProcedure(connectionString, _
    schema, procedureName)
```

```csharp
void DropProcedure(
    string connectionString,
    string schema,
    string procedureName
)
```

```cpp
void DropProcedure(
    String^ connectionString, 
    String^ schema, 
    String^ procedureName
)
```

```jscript
function DropProcedure(
    connectionString : String, 
    schema : String, 
    procedureName : String
)
```

### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The connection string for the database.  

<!-- end list -->

  - schema  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The schema name for the stored procedure.  
    **Note**    If schema is empty, the default schema name will be used.  

<!-- end list -->

  - procedureName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The name of the stored procedure.  

## Remarks

All database providers that implement the [IDbStoredProcedureManager](idbstoredproceduremanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the DropProcedure method, which the database manager will use to remove stored procedures from a table in a database.

### 

### Notes for Implementers

If your provider does not support deleting stored procedures, you can use the following code sample to raise a not-implemented exception:

public void DropProcedure(string connectionString, string schema, string procedureName)

{

   throw new NotImplementedException();

}


> [!NOTE]  
> See the [DROP PROCEDURE (Transact-SQL)](http://msdn.microsoft.com/en-us/library/ms174969.aspx) topic for more information about the DROP PROCEDURE SQL statement.


## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[IDbStoredProcedureManager Interface](idbstoredproceduremanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

