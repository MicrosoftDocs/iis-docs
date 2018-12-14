---
title: IDbBackupManager Interface (Microsoft.Web.Management.DatabaseManager)
TOCTitle: IDbBackupManager Interface
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.IDbBackupManager
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.idbbackupmanager(v=VS.90)
ms:contentKeyID: 22049483
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbBackupManager
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbBackupManager
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IDbBackupManager Interface

Represents a database backup manager interface.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Public Interface IDbBackupManager
'Usage
Dim instance As IDbBackupManager
```

``` csharp
public interface IDbBackupManager
```

``` c++
public interface class IDbBackupManager
```

``` jscript
public interface IDbBackupManager
```

The IDbBackupManager type exposes the following members.

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
<td><a href="idbbackupmanager-createbackup-method-microsoft-web-management-databasemanager.md">CreateBackup</a></td>
<td>Creates a database backup.</td>
</tr>
</tbody>
</table>


Top

## Remarks

In order to implement database backup features in your database provider, you need to implement IDbBackupManager on the class that you derived from the [DatabaseProvider](databaseprovider-class-microsoft-web-management-databasemanager.md) method.


#### Notes for Implementers

If your provider implements the IDbBackupManager interface, your provider must also implement all of the following members:

  - [CreateBackup](idbbackupmanager-createbackup-method-microsoft-web-management-databasemanager.md)

## See Also

#### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

