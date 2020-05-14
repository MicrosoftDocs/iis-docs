---
title: IDbStoredProcedureManager.GetStoredProcedureParameters Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: GetStoredProcedureParameters Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.GetStoredProcedureParameters(System.String,System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.idbstoredproceduremanager.getstoredprocedureparameters(v=VS.90)
ms:contentKeyID: 20476701
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.GetStoredProcedureParameters
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.GetStoredProcedureParameters
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IDbStoredProcedureManager.GetStoredProcedureParameters Method

Returns a collection of parameters for a stored procedure.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Function GetStoredProcedureParameters ( _
    connectionString As String, _
    schema As String, _
    storedProcedureName As String _
) As ICollection(Of StoredProcedureParameter)
'Usage
Dim instance As IDbStoredProcedureManager
Dim connectionString As String
Dim schema As String
Dim storedProcedureName As String
Dim returnValue As ICollection(Of StoredProcedureParameter)

returnValue = instance.GetStoredProcedureParameters(connectionString, _
    schema, storedProcedureName)
```

```csharp
ICollection<StoredProcedureParameter> GetStoredProcedureParameters(
    string connectionString,
    string schema,
    string storedProcedureName
)
```

```cpp
ICollection<StoredProcedureParameter^>^ GetStoredProcedureParameters(
    String^ connectionString,
    String^ schema,
    String^ storedProcedureName
)
```

```jscript
function GetStoredProcedureParameters(
    connectionString : String,
    schema : String,
    storedProcedureName : String
) : ICollection<StoredProcedureParameter>
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

Type: [System.Collections.Generic.ICollection](https://msdn.microsoft.com/library/92t2ye13)\<[StoredProcedureParameter](storedprocedureparameter-class-microsoft-web-management-databasemanager.md)\>  
An ICollection object that contains the list of [StoredProcedureParameter](storedprocedureparameter-class-microsoft-web-management-databasemanager.md) objects.  

## Remarks

All database providers that implement the [IDbStoredProcedureManager](idbstoredproceduremanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the GetStoredProcedureParameters method. This method returns a collection of StoredProcedureParameter objects for a specific stored procedure that the database manager will use to provide the list of parameters for the various stored procedure methods in your provider.

### Notes for Implementers

If your provider does not support retrieving stored procedures, you can use the following code sample to raise a not-implemented exception:

public ICollection\<StoredProcedureParameter\> GetStoredProcedureParameters(string connectionString, string schema, string storedProcedureName)

{

   throw new NotImplementedException();

}

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[IDbStoredProcedureManager Interface](idbstoredproceduremanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
