---
title: View.Name Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: Name Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.View.Name
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.view.name(v=VS.90)
ms:contentKeyID: 20476456
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.View.Name
- Microsoft.Web.Management.DatabaseManager.View.get_Name
- Microsoft.Web.Management.DatabaseManager.View.set_Name
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.View.get_Name
- Microsoft.Web.Management.DatabaseManager.View.Name
- Microsoft.Web.Management.DatabaseManager.View.set_Name
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# View.Name Property

Gets or sets the name for a view.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property Name As String
'Usage
Dim instance As View
Dim value As String

value = instance.Name

instance.Name = value
```

```csharp
public string Name { get; set; }
```

```cpp
public:
property String^ Name {
    String^ get ();
    void set (String^ value);
}
```

```jscript
function get Name () : String
function set Name (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The name for a view.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[View Class](view-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

