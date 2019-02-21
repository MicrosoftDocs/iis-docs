---
title: IDbStoredProcedureManager.GetStoredProcedureExecStatement Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: GetStoredProcedureExecStatement Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.GetStoredProcedureExecStatement(System.String,System.String,System.String,System.Collections.Generic.IList{Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter})
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.idbstoredproceduremanager.getstoredprocedureexecstatement(v=VS.90)
ms:contentKeyID: 20476600
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.GetStoredProcedureExecStatement
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.GetStoredProcedureExecStatement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# IDbStoredProcedureManager.GetStoredProcedureExecStatement Method

Returns the EXECUTE statement for a stored procedure.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Function GetStoredProcedureExecStatement ( _
    connectionString As String, _
    schema As String, _
    storedProcedureName As String, _
    parameters As IList(Of StoredProcedureParameter) _
) As Query
'Usage
Dim instance As IDbStoredProcedureManager
Dim connectionString As String
Dim schema As String
Dim storedProcedureName As String
Dim parameters As IList(Of StoredProcedureParameter)
Dim returnValue As Query

returnValue = instance.GetStoredProcedureExecStatement(connectionString, _
    schema, storedProcedureName, parameters)
```

```csharp
Query GetStoredProcedureExecStatement(
    string connectionString,
    string schema,
    string storedProcedureName,
    IList<StoredProcedureParameter> parameters
)
```

```cpp
Query^ GetStoredProcedureExecStatement(
    String^ connectionString, 
    String^ schema, 
    String^ storedProcedureName, 
    IList<StoredProcedureParameter^>^ parameters
)
```

```jscript
function GetStoredProcedureExecStatement(
    connectionString : String, 
    schema : String, 
    storedProcedureName : String, 
    parameters : IList<StoredProcedureParameter>
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
    **Note**    If schema is empty, the default schema name will be used.  

<!-- end list -->

  - storedProcedureName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The name of the stored procedure.  

<!-- end list -->

  - parameters  
    Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6)\<[StoredProcedureParameter](storedprocedureparameter-class-microsoft-web-management-databasemanager.md)\>  
    An IList object that contains the list of [StoredProcedureParameter](storedprocedureparameter-class-microsoft-web-management-databasemanager.md) objects.  

### Return Value

Type: [Microsoft.Web.Management.DatabaseManager.Query](query-class-microsoft-web-management-databasemanager.md)  
A [Query](query-class-microsoft-web-management-databasemanager.md) object that contains the EXECUTE statement for a stored procedure.  

## Remarks

All database providers that implement the [IDbStoredProcedureManager](idbstoredproceduremanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the GetStoredProcedureExecStatement method. This method returns an EXECUTE statement that is based on the parameters that you specify in parameters.

### 

### Notes for Implementers

If your provider does not support executing stored procedures, you can use the following code sample to raise a not-implemented exception:

public Query GetStoredProcedureExecStatement(string connectionString, string schema, string storedProcedureName, IList\<StoredProcedureParameter\> parameters)

{

   throw new NotImplementedException();

}


> [!NOTE]  
> See the [EXECUTE (Transact-SQL)](http://msdn.microsoft.com/en-us/library/ms188332.aspx) topic for more information about the EXECUTE SQL statement.


## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[IDbStoredProcedureManager Interface](idbstoredproceduremanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

