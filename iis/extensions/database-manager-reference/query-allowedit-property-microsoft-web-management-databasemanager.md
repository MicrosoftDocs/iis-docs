---
title: Query.AllowEdit Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: AllowEdit Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.Query.AllowEdit
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.query.allowedit(v=VS.90)
ms:contentKeyID: 22049614
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.Query.AllowEdit
- Microsoft.Web.Management.DatabaseManager.Query.get_AllowEdit
- Microsoft.Web.Management.DatabaseManager.Query.set_AllowEdit
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.Query.AllowEdit
- Microsoft.Web.Management.DatabaseManager.Query.set_AllowEdit
- Microsoft.Web.Management.DatabaseManager.Query.get_AllowEdit
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Query.AllowEdit Property

Gets or sets a value that specifies whether editing the query is allowed.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property AllowEdit As Boolean
'Usage
Dim instance As Query
Dim value As Boolean

value = instance.AllowEdit

instance.AllowEdit = value
```

```csharp
public bool AllowEdit { get; set; }
```

```cpp
public:
property bool AllowEdit {
    bool get ();
    void set (bool value);
}
```

```jscript
function get AllowEdit () : boolean
function set AllowEdit (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if editing the query is allowed; otherwise, false.  

## Remarks

The AllowEdit property specifies whether your provider should allow editing a query. For example, your provider might want to provider a read-only query object.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[Query Class](query-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

