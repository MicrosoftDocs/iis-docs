---
title: ForeignKey.GetChanges Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: GetChanges Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.ForeignKey.GetChanges(Microsoft.Web.Management.DatabaseManager.ForeignKeyChanges)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.foreignkey.getchanges(v=VS.90)
ms:contentKeyID: 20476799
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.ForeignKey.GetChanges
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.ForeignKey.GetChanges
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ForeignKey.GetChanges Method

Returns a value that indicates whether the foreign key has changes pending.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Function GetChanges ( _
    changes As ForeignKeyChanges _
) As Boolean
'Usage
Dim instance As ForeignKey
Dim changes As ForeignKeyChanges
Dim returnValue As Boolean

returnValue = instance.GetChanges(changes)
```

```csharp
public bool GetChanges(
    ForeignKeyChanges changes
)
```

```cpp
public:
bool GetChanges(
    ForeignKeyChanges changes
)
```

```jscript
public function GetChanges(
    changes : ForeignKeyChanges
) : boolean
```

### Parameters

  - changes  
    Type: [Microsoft.Web.Management.DatabaseManager.ForeignKeyChanges](foreignkeychanges-enumeration-microsoft-web-management-databasemanager.md)  
    A ForeignKeyChanges object.  

### Return Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the foreign key has pending changes; otherwise, false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[ForeignKey Class](foreignkey-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
