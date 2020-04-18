---
title: TypeInfo.MaximumLength Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: MaximumLength Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.TypeInfo.MaximumLength
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.typeinfo.maximumlength(v=VS.90)
ms:contentKeyID: 20476695
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.TypeInfo.MaximumLength
- Microsoft.Web.Management.DatabaseManager.TypeInfo.get_MaximumLength
- Microsoft.Web.Management.DatabaseManager.TypeInfo.set_MaximumLength
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.TypeInfo.get_MaximumLength
- Microsoft.Web.Management.DatabaseManager.TypeInfo.MaximumLength
- Microsoft.Web.Management.DatabaseManager.TypeInfo.set_MaximumLength
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TypeInfo.MaximumLength Property

Gets or sets the maximum length for the data type.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property MaximumLength As Long
'Usage
Dim instance As TypeInfo
Dim value As Long

value = instance.MaximumLength

instance.MaximumLength = value
```

```csharp
public long MaximumLength { get; set; }
```

```cpp
public:
property long long MaximumLength {
    long long get ();
    void set (long long value);
}
```

```jscript
function get MaximumLength () : long
function set MaximumLength (value : long)
```

### Property Value

Type: [System.Int64](https://msdn.microsoft.com/library/6yy583ek)  
The maximum length for the data type.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TypeInfo Class](typeinfo-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
