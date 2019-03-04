---
title: TypeInfo.DefaultLength Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: DefaultLength Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.TypeInfo.DefaultLength
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.typeinfo.defaultlength(v=VS.90)
ms:contentKeyID: 20476490
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.TypeInfo.DefaultLength
- Microsoft.Web.Management.DatabaseManager.TypeInfo.get_DefaultLength
- Microsoft.Web.Management.DatabaseManager.TypeInfo.set_DefaultLength
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.TypeInfo.DefaultLength
- Microsoft.Web.Management.DatabaseManager.TypeInfo.get_DefaultLength
- Microsoft.Web.Management.DatabaseManager.TypeInfo.set_DefaultLength
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TypeInfo.DefaultLength Property

Gets or sets the default length for the data type.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property DefaultLength As Integer
'Usage
Dim instance As TypeInfo
Dim value As Integer

value = instance.DefaultLength

instance.DefaultLength = value
```

```csharp
public int DefaultLength { get; set; }
```

```cpp
public:
property int DefaultLength {
    int get ();
    void set (int value);
}
```

```jscript
function get DefaultLength () : int
function set DefaultLength (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The default length for the data type.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TypeInfo Class](typeinfo-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

