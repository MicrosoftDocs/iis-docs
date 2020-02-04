---
title: QueryColumnMetadata.IsComputed Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: IsComputed Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.QueryColumnMetadata.IsComputed
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.querycolumnmetadata.iscomputed(v=VS.90)
ms:contentKeyID: 20476429
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.QueryColumnMetadata.IsComputed
- Microsoft.Web.Management.DatabaseManager.QueryColumnMetadata.get_IsComputed
- Microsoft.Web.Management.DatabaseManager.QueryColumnMetadata.set_IsComputed
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.QueryColumnMetadata.get_IsComputed
- Microsoft.Web.Management.DatabaseManager.QueryColumnMetadata.IsComputed
- Microsoft.Web.Management.DatabaseManager.QueryColumnMetadata.set_IsComputed
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# QueryColumnMetadata.IsComputed Property

Gets or sets a value that indicates whether the column data is computed within a query result.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property IsComputed As Boolean
'Usage
Dim instance As QueryColumnMetadata
Dim value As Boolean

value = instance.IsComputed

instance.IsComputed = value
```

```csharp
public bool IsComputed { get; set; }
```

```cpp
public:
property bool IsComputed {
    bool get ();
    void set (bool value);
}
```

```jscript
function get IsComputed () : boolean
function set IsComputed (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the column data is computed; otherwise, false.  

## Remarks

The data in some database columns is computed by the database server; for example, an identity column may be a computed value.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[QueryColumnMetadata Class](querycolumnmetadata-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

