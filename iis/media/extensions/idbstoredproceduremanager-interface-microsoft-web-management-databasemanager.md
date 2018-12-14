---
title: IDbStoredProcedureManager Interface (Microsoft.Web.Management.DatabaseManager)
TOCTitle: IDbStoredProcedureManager Interface
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.idbstoredproceduremanager(v=VS.90)
ms:contentKeyID: 20476431
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IDbStoredProcedureManager Interface

Represents a stored procedure manager interface for a database provider.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Public Interface IDbStoredProcedureManager
'Usage
Dim instance As IDbStoredProcedureManager
```

``` csharp
public interface IDbStoredProcedureManager
```

``` c++
public interface class IDbStoredProcedureManager
```

``` jscript
public interface IDbStoredProcedureManager
```

The IDbStoredProcedureManager type exposes the following members.

## Methods

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="idbstoredproceduremanager-dropprocedure-method-microsoft-web-management-databasemanager.md">DropProcedure</a></td>
<td>Removes a stored procedure from a database.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="idbstoredproceduremanager-getstoredprocedurecreatefromexistingstatement-method-microsoft-web-management-databasemanager.md">GetStoredProcedureCreateFromExistingStatement</a></td>
<td>Returns the CREATE PROCEDURE definition for a new stored procedure that is based on an existing stored procedure.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="idbstoredproceduremanager-getstoredprocedurecreatestatement-method-microsoft-web-management-databasemanager.md">GetStoredProcedureCreateStatement</a></td>
<td>Returns the CREATE PROCEDURE template for creating a new stored procedure.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="idbstoredproceduremanager-getstoredprocedureeditstatement-method-microsoft-web-management-databasemanager.md">GetStoredProcedureEditStatement</a></td>
<td>Returns the ALTER PROCEDURE statement for a stored procedure.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="idbstoredproceduremanager-getstoredprocedureexecstatement-method-microsoft-web-management-databasemanager.md">GetStoredProcedureExecStatement</a></td>
<td>Returns the EXECUTE statement for a stored procedure.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="idbstoredproceduremanager-getstoredprocedureparameters-method-microsoft-web-management-databasemanager.md">GetStoredProcedureParameters</a></td>
<td>Returns a collection of parameters for a stored procedure.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="idbstoredproceduremanager-getstoredprocedures-method-microsoft-web-management-databasemanager.md">GetStoredProcedures</a></td>
<td>Returns a collection of stored procedures for a database.</td>
</tr>
</tbody>
</table>


Top

## Remarks

In order to manage stored procedures, you need to implement IDbStoredProcedureManager on the class that you derived from [DatabaseProvider](databaseprovider-class-microsoft-web-management-databasemanager.md). Stored procedures are collections of SQL code that execute on the server, and are often used instead of queries. For example, you could create a stored procedure that performs a query that is based on values that are calculated from parameters that you pass to the stored procedure.


#### Notes for Implementers

If your provider implements the IDbStoredProcedureManager interface, your provider must also implement all of the following members:

  - [DropProcedure](idbstoredproceduremanager-dropprocedure-method-microsoft-web-management-databasemanager.md)

  - [GetStoredProcedureExecStatement](idbstoredproceduremanager-getstoredprocedureexecstatement-method-microsoft-web-management-databasemanager.md)

  - [GetStoredProcedureParameters](idbstoredproceduremanager-getstoredprocedureparameters-method-microsoft-web-management-databasemanager.md)

  - [GetStoredProcedures](idbstoredproceduremanager-getstoredprocedures-method-microsoft-web-management-databasemanager.md)

  - [GetStoredProcedureEditStatement](idbstoredproceduremanager-getstoredprocedureeditstatement-method-microsoft-web-management-databasemanager.md)

  - [GetStoredProcedureCreateStatement](idbstoredproceduremanager-getstoredprocedurecreatestatement-method-microsoft-web-management-databasemanager.md)

  - [GetStoredProcedureCreateFromExistingStatement](idbstoredproceduremanager-getstoredprocedurecreatefromexistingstatement-method-microsoft-web-management-databasemanager.md)

## See Also

#### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

