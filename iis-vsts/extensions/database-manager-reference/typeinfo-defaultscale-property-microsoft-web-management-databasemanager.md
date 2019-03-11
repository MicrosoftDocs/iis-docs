---
title: TypeInfo.DefaultScale Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: DefaultScale Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.TypeInfo.DefaultScale
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.typeinfo.defaultscale(v=VS.90)
ms:contentKeyID: 22049621
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.TypeInfo.DefaultScale
- Microsoft.Web.Management.DatabaseManager.TypeInfo.get_DefaultScale
- Microsoft.Web.Management.DatabaseManager.TypeInfo.set_DefaultScale
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.TypeInfo.DefaultScale
- Microsoft.Web.Management.DatabaseManager.TypeInfo.get_DefaultScale
- Microsoft.Web.Management.DatabaseManager.TypeInfo.set_DefaultScale
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TypeInfo.DefaultScale Property

Gets or sets a value that specifies the default scale for the data type.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property DefaultScale As Integer
'Usage
Dim instance As TypeInfo
Dim value As Integer

value = instance.DefaultScale

instance.DefaultScale = value
```

```csharp
public int DefaultScale { get; set; }
```

```cpp
public:
property int DefaultScale {
    int get ();
    void set (int value);
}
```

```jscript
function get DefaultScale () : int
function set DefaultScale (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The default scale for the data type.  

## Remarks

The numeric scale for a data type refers to the number of digits that are allowed to the right of the decimal place.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TypeInfo Class](typeinfo-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

