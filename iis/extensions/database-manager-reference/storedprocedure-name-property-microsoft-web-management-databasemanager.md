---
title: StoredProcedure.Name Property (Microsoft.Web.Management.DatabaseManager)
description: This article contains information on syntax and permissions for the StoredProcedure.Name Property, as well as links to reference materials.
TOCTitle: Name Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.StoredProcedure.Name
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.storedprocedure.name(v=VS.90)
ms:contentKeyID: 20476463
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.StoredProcedure.Name
- Microsoft.Web.Management.DatabaseManager.StoredProcedure.get_Name
- Microsoft.Web.Management.DatabaseManager.StoredProcedure.set_Name
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.StoredProcedure.get_Name
- Microsoft.Web.Management.DatabaseManager.StoredProcedure.Name
- Microsoft.Web.Management.DatabaseManager.StoredProcedure.set_Name
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StoredProcedure.Name Property

Gets or sets the name for a stored procedure.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property Name As String
'Usage
Dim instance As StoredProcedure
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
The name for a stored procedure.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[StoredProcedure Class](storedprocedure-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
