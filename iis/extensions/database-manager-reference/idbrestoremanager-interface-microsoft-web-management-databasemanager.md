---
title: IDbRestoreManager Interface (Microsoft.Web.Management.DatabaseManager)
TOCTitle: IDbRestoreManager Interface
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.IDbRestoreManager
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.idbrestoremanager(v=VS.90)
ms:contentKeyID: 22049623
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbRestoreManager
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbRestoreManager
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IDbRestoreManager Interface

Represents a database restore manager interface.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Interface IDbRestoreManager
'Usage
Dim instance As IDbRestoreManager
```

```csharp
public interface IDbRestoreManager
```

```cpp
public interface class IDbRestoreManager
```

```jscript
public interface IDbRestoreManager
```

The IDbRestoreManager type exposes the following members.

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[RestoreBackup](idbrestoremanager-restorebackup-method-microsoft-web-management-databasemanager.md)|Restores a database backup.|

## Remarks

In order to implement database restore features in your database provider, you need to implement IDbRestoreManager on the class that you derived from [DatabaseProvider](databaseprovider-class-microsoft-web-management-databasemanager.md).

### 

### Notes for Implementers

If your provider implements the IDbRestoreManager interface, your provider must also implement all of the following members:

  - [RestoreBackup](idbrestoremanager-restorebackup-method-microsoft-web-management-databasemanager.md)

## See Also

### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
