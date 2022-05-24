---
title: IDbStoredProcedureManager.GetStoredProcedureEditStatement Method  (Microsoft.Web.Management.DatabaseManager)
description: Describes the IDbStoredProcedureManager.GetStoredProcedureEditStatement method and provides the method's syntax, remarks, and permissions.
TOCTitle: GetStoredProcedureEditStatement Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.GetStoredProcedureEditStatement(System.String,System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.idbstoredproceduremanager.getstoredprocedureeditstatement(v=VS.90)
ms:contentKeyID: 20476780
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.GetStoredProcedureEditStatement
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.GetStoredProcedureEditStatement
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IDbStoredProcedureManager.GetStoredProcedureEditStatement Method

Returns the ALTER PROCEDURE statement for a stored procedure.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Function GetStoredProcedureEditStatement ( _
    connectionString As String, _
    schema As String, _
    storedProcedureName As String _
) As Query
'Usage
Dim instance As IDbStoredProcedureManager
Dim connectionString As String
Dim schema As String
Dim storedProcedureName As String
Dim returnValue As Query

returnValue = instance.GetStoredProcedureEditStatement(connectionString, _
    schema, storedProcedureName)
```

```csharp
Query GetStoredProcedureEditStatement(
    string connectionString,
    string schema,
    string storedProcedureName
)
```

```cpp
Query^ GetStoredProcedureEditStatement(
    String^ connectionString, 
    String^ schema, 
    String^ storedProcedureName
)
```

```jscript
function GetStoredProcedureEditStatement(
    connectionString : String, 
    schema : String, 
    storedProcedureName : String
) : Query
```

### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The connection string for the database.  

<!-- end list -->

  - schema  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The schema name for the stored procedure.  
    **Note**    If schema is empty, the default schema name will be used.  

<!-- end list -->

  - storedProcedureName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The name of the stored procedure.  

### Return Value

Type: [Microsoft.Web.Management.DatabaseManager.Query](query-class-microsoft-web-management-databasemanager.md)  
A [Query](query-class-microsoft-web-management-databasemanager.md) object that contains the ALTER PROCEDURE statement for a stored procedure.  

## Remarks

All database providers that implement the [IDbStoredProcedureManager](idbstoredproceduremanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the GetStoredProcedureEditStatement method, which returns an ALTER PROCEDURE statement for your database provider.

### Notes for Implementers

If your provider does not support editing stored procedures, you can use the following code sample to raise a not-implemented exception:

public Query GetStoredProcedureEditStatement(string connectionString, string schema, string storedProcedureName)

{

   throw new NotImplementedException();

}

> [!NOTE]  
> See the [ALTER PROCEDURE (Transact-SQL)](https://msdn.microsoft.com/library/ms189762.aspx) topic for more information about the ALTER PROCEDURE SQL statement.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[IDbStoredProcedureManager Interface](idbstoredproceduremanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
