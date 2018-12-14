---
title: IDbStoredProcedureManager.GetStoredProcedures Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: GetStoredProcedures Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.GetStoredProcedures(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.idbstoredproceduremanager.getstoredprocedures(v=VS.90)
ms:contentKeyID: 20476486
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.GetStoredProcedures
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.GetStoredProcedures
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IDbStoredProcedureManager.GetStoredProcedures Method

Returns a collection of stored procedures for a database.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Function GetStoredProcedures ( _
    connectionString As String _
) As ICollection(Of StoredProcedure)
'Usage
Dim instance As IDbStoredProcedureManager
Dim connectionString As String
Dim returnValue As ICollection(Of StoredProcedure)

returnValue = instance.GetStoredProcedures(connectionString)
```

``` csharp
ICollection<StoredProcedure> GetStoredProcedures(
    string connectionString
)
```

``` c++
ICollection<StoredProcedure^>^ GetStoredProcedures(
    String^ connectionString
)
```

``` jscript
function GetStoredProcedures(
    connectionString : String
) : ICollection<StoredProcedure>
```

#### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The connection string for the database.  

#### Return Value

Type: [System.Collections.Generic.ICollection](https://msdn.microsoft.com/en-us/library/92t2ye13\(v=vs.90\))\<[StoredProcedure](storedprocedure-class-microsoft-web-management-databasemanager.md)\>  
An ICollection object that contains the list of [StoredProcedure](storedprocedure-class-microsoft-web-management-databasemanager.md) objects.  

## Remarks

All database providers that implement the [IDbStoredProcedureManager](idbstoredproceduremanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the GetStoredProcedures method. This method returns a collection of StoredProcedure objects that will be displayed in IIS Manager.


#### Notes for Implementers

If your provider does not support retrieving stored procedures, you can use the following code sample to raise a not-implemented exception:

public ICollection\<StoredProcedure\> GetStoredProcedures(string connectionString)

{

   throw new NotImplementedException();

}

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[IDbStoredProcedureManager Interface](idbstoredproceduremanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

