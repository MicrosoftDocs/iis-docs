---
title: IDbViewManager Interface (Microsoft.Web.Management.DatabaseManager)
TOCTitle: IDbViewManager Interface
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.IDbViewManager
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.idbviewmanager(v=VS.90)
ms:contentKeyID: 20476396
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbViewManager
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbViewManager
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# IDbViewManager Interface

Represents a view manager interface within a database provider.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Interface IDbViewManager
'Usage
Dim instance As IDbViewManager
```

```csharp
public interface IDbViewManager
```

```cpp
public interface class IDbViewManager
```

```jscript
public interface IDbViewManager
```

The IDbViewManager type exposes the following members.

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[CreateView](idbviewmanager-createview-method-microsoft-web-management-databasemanager.md)|Creates a view within the database.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[DropView](idbviewmanager-dropview-method-microsoft-web-management-databasemanager.md)|Removes a view from the database.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[EditView](idbviewmanager-editview-method-microsoft-web-management-databasemanager.md)|Modifies the definition of a view in the database.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetViews](idbviewmanager-getviews-method-microsoft-web-management-databasemanager.md)|Retrieves a list of views in a database.|

## Remarks

In order to manage views, you need to implement IDbViewManager on the class that you derived from [DatabaseProvider](databaseprovider-class-microsoft-web-management-databasemanager.md). This interface allows to create, modify, and delete views.

### 

### Notes for Implementers

If your provider implements the IDbViewManager interface, your provider must also implement all of the following members:

  - [CreateView](idbviewmanager-createview-method-microsoft-web-management-databasemanager.md)

  - [DropView](idbviewmanager-dropview-method-microsoft-web-management-databasemanager.md)

  - [EditView](idbviewmanager-editview-method-microsoft-web-management-databasemanager.md)

  - [GetViews](idbviewmanager-getviews-method-microsoft-web-management-databasemanager.md)

## See Also

### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

