---
title: View.Schema Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: Schema Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.View.Schema
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.view.schema(v=VS.90)
ms:contentKeyID: 20476452
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.View.Schema
- Microsoft.Web.Management.DatabaseManager.View.get_Schema
- Microsoft.Web.Management.DatabaseManager.View.set_Schema
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.View.get_Schema
- Microsoft.Web.Management.DatabaseManager.View.Schema
- Microsoft.Web.Management.DatabaseManager.View.set_Schema
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# View.Schema Property

Gets or sets the schema name for a view.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property Schema As String
'Usage
Dim instance As View
Dim value As String

value = instance.Schema

instance.Schema = value
```

```csharp
public string Schema { get; set; }
```

```cpp
public:
property String^ Schema {
    String^ get ();
    void set (String^ value);
}
```

```jscript
function get Schema () : String
function set Schema (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The schema name for a view.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[View Class](view-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

