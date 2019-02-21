---
title: Index.GetChanges Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: GetChanges Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.Index.GetChanges(Microsoft.Web.Management.DatabaseManager.IndexChanges)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.index.getchanges(v=VS.90)
ms:contentKeyID: 20476399
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.Index.GetChanges
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.Index.GetChanges
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Index.GetChanges Method

Returns a value that indicates whether there are changes in the index.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Function GetChanges ( _
    changes As IndexChanges _
) As Boolean
'Usage
Dim instance As Index
Dim changes As IndexChanges
Dim returnValue As Boolean

returnValue = instance.GetChanges(changes)
```

```csharp
public bool GetChanges(
    IndexChanges changes
)
```

```cpp
public:
bool GetChanges(
    IndexChanges changes
)
```

```jscript
public function GetChanges(
    changes : IndexChanges
) : boolean
```

### Parameters

  - changes  
    Type: [Microsoft.Web.Management.DatabaseManager.IndexChanges](indexchanges-enumeration-microsoft-web-management-databasemanager.md)  
    The [IndexChanges](indexchanges-enumeration-microsoft-web-management-databasemanager.md) flags.  

### Return Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the index has changes; otherwise, false.  

## Remarks

This method uses values from the [IndexChanges](indexchanges-enumeration-microsoft-web-management-databasemanager.md) enumeration to define the type of change.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[Index Class](index-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

