---
title: IDbTableDataManager Interface (Microsoft.Web.Management.DatabaseManager)
TOCTitle: IDbTableDataManager Interface
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.IDbTableDataManager
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.idbtabledatamanager(v=VS.90)
ms:contentKeyID: 20476493
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbTableDataManager
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbTableDataManager
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IDbTableDataManager Interface

Represents a table data manager interface within a database provider.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Public Interface IDbTableDataManager
'Usage
Dim instance As IDbTableDataManager
```

``` csharp
public interface IDbTableDataManager
```

``` c++
public interface class IDbTableDataManager
```

``` jscript
public interface IDbTableDataManager
```

The IDbTableDataManager type exposes the following members.

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[DeleteRow](idbtabledatamanager-deleterow-method-microsoft-web-management-databasemanager.md)|Removes a row from a table.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[EditRow](idbtabledatamanager-editrow-method-microsoft-web-management-databasemanager.md)|Modifies the data inside a table row.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetData](idbtabledatamanager-getdata-method-microsoft-web-management-databasemanager.md)|Returns table data as a query result.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[InsertRow](idbtabledatamanager-insertrow-method-microsoft-web-management-databasemanager.md)|Inserts a row of data into a table.|

Top

## Remarks

In order to manage table data, you need to implement IDbTableDataManager on the class that you derived from [DatabaseProvider](databaseprovider-class-microsoft-web-management-databasemanager.md). This interface allows to insert, modify, and delete data from tables.


> [!NOTE]  
> The IDbTableDataManager interface is used to manage data within a table, whereas the [IDbTableManager](idbtablemanager-interface-microsoft-web-management-databasemanager.md) interface is used to manage the actual tables.


### 

#### Notes for Implementers

If your provider implements the IDbTableDataManager interface, your provider must also implement all the following members:

  - [DeleteRow](idbtabledatamanager-deleterow-method-microsoft-web-management-databasemanager.md)

  - [EditRow](idbtabledatamanager-editrow-method-microsoft-web-management-databasemanager.md)

  - [GetData](idbtabledatamanager-getdata-method-microsoft-web-management-databasemanager.md)

  - [InsertRow](idbtabledatamanager-insertrow-method-microsoft-web-management-databasemanager.md)

## See Also

#### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

