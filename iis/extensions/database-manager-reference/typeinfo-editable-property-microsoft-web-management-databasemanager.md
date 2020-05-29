---
title: TypeInfo.Editable Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: Editable Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.TypeInfo.Editable
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.typeinfo.editable(v=VS.90)
ms:contentKeyID: 22049475
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.TypeInfo.Editable
- Microsoft.Web.Management.DatabaseManager.TypeInfo.get_Editable
- Microsoft.Web.Management.DatabaseManager.TypeInfo.set_Editable
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.TypeInfo.Editable
- Microsoft.Web.Management.DatabaseManager.TypeInfo.set_Editable
- Microsoft.Web.Management.DatabaseManager.TypeInfo.get_Editable
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TypeInfo.Editable Property

Gets or sets a value that indicates whether the data type can be edited.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property Editable As Boolean
'Usage
Dim instance As TypeInfo
Dim value As Boolean

value = instance.Editable

instance.Editable = value
```

```csharp
public bool Editable { get; set; }
```

```cpp
public:
property bool Editable {
    bool get ();
    void set (bool value);
}
```

```jscript
function get Editable () : boolean
function set Editable (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the data type can be edited; otherwise, false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TypeInfo Class](typeinfo-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
