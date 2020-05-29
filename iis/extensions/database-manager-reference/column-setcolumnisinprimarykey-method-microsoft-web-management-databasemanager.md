---
title: Column.SetColumnIsInPrimaryKey Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: SetColumnIsInPrimaryKey Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.Column.SetColumnIsInPrimaryKey(System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.column.setcolumnisinprimarykey(v=VS.90)
ms:contentKeyID: 20476458
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.Column.SetColumnIsInPrimaryKey
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.Column.SetColumnIsInPrimaryKey
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Column.SetColumnIsInPrimaryKey Method

Specifies the database column as part of the primary key.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Sub SetColumnIsInPrimaryKey ( _
    isInPrimaryKey As Boolean _
)
'Usage
Dim instance As Column
Dim isInPrimaryKey As Boolean

instance.SetColumnIsInPrimaryKey(isInPrimaryKey)
```

```csharp
public void SetColumnIsInPrimaryKey(
    bool isInPrimaryKey
)
```

```cpp
public:
void SetColumnIsInPrimaryKey(
    bool isInPrimaryKey
)
```

```jscript
public function SetColumnIsInPrimaryKey(
    isInPrimaryKey : boolean
)
```

### Parameters

  - isInPrimaryKey  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
    true to specify that the column is part of the primary key; otherwise, false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[Column Class](column-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
