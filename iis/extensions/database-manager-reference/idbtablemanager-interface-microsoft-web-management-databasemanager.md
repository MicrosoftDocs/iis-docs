---
title: IDbTableManager Interface (Microsoft.Web.Management.DatabaseManager)
TOCTitle: IDbTableManager Interface
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.IDbTableManager
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.idbtablemanager(v=VS.90)
ms:contentKeyID: 20476461
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbTableManager
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbTableManager
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IDbTableManager Interface

Represents a table manager interface for the database provider.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Interface IDbTableManager
'Usage
Dim instance As IDbTableManager
```

```csharp
public interface IDbTableManager
```

```cpp
public interface class IDbTableManager
```

```jscript
public interface IDbTableManager
```

The IDbTableManager type exposes the following members.

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[CreateTable](idbtablemanager-createtable-method-microsoft-web-management-databasemanager.md)|Creates a table in a database.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[DropTable](idbtablemanager-droptable-method-microsoft-web-management-databasemanager.md)|Removes a table from the database.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[EditTable](idbtablemanager-edittable-method-microsoft-web-management-databasemanager.md)|Modifies a table in a database.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetPrimaryKey](idbtablemanager-getprimarykey-method-microsoft-web-management-databasemanager.md)|Returns a list of primary keys for the specified table.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetTableInfo](idbtablemanager-gettableinfo-method-microsoft-web-management-databasemanager.md)|Returns the table information for a table.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetTables](idbtablemanager-gettables-method-microsoft-web-management-databasemanager.md)|Returns a list of tables from a database.|

## Remarks

In order to manage tables, you must implement IDbTableManager on the class that you derived from [DatabaseProvider](databaseprovider-class-microsoft-web-management-databasemanager.md). This interface allows to create, modify, and delete tables.

> [!NOTE]  
> Use the IDbTableManager interface to manage the actual tables, and use the [IDbTableDataManager](idbtabledatamanager-interface-microsoft-web-management-databasemanager.md) interface to manage data within a table.

### Notes for Implementers

If your provider implements the IDbTableManager interface, your provider must also implement all of the following members:

  - [CreateTable](idbtablemanager-createtable-method-microsoft-web-management-databasemanager.md)

  - [DropTable](idbtablemanager-droptable-method-microsoft-web-management-databasemanager.md)

  - [EditTable](idbtablemanager-edittable-method-microsoft-web-management-databasemanager.md)

  - [GetPrimaryKey](idbtablemanager-getprimarykey-method-microsoft-web-management-databasemanager.md)

  - [GetTableInfo](idbtablemanager-gettableinfo-method-microsoft-web-management-databasemanager.md)

  - [GetTables](idbtablemanager-gettables-method-microsoft-web-management-databasemanager.md)

## See Also

### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
