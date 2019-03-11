---
title: Index.Clustered Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: Clustered Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.Index.Clustered
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.index.clustered(v=VS.90)
ms:contentKeyID: 20476432
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.Index.Clustered
- Microsoft.Web.Management.DatabaseManager.Index.get_Clustered
- Microsoft.Web.Management.DatabaseManager.Index.set_Clustered
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.Index.Clustered
- Microsoft.Web.Management.DatabaseManager.Index.get_Clustered
- Microsoft.Web.Management.DatabaseManager.Index.set_Clustered
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Index.Clustered Property

Gets or sets a value that indicates whether the index is clustered.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property Clustered As Boolean
'Usage
Dim instance As Index
Dim value As Boolean

value = instance.Clustered

instance.Clustered = value
```

```csharp
public bool Clustered { get; set; }
```

```cpp
public:
property bool Clustered {
    bool get ();
    void set (bool value);
}
```

```jscript
function get Clustered () : boolean
function set Clustered (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the index is clustered; otherwise, false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[Index Class](index-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

