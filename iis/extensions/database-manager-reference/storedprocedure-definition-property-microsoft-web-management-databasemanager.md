---
title: StoredProcedure.Definition Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: Definition Property
description: "The StoredProcedure.Definition property gets or sets the definition for a stored procedure. This article describes its syntax, remarks, and permissions."
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.StoredProcedure.Definition
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.storedprocedure.definition(v=VS.90)
ms:contentKeyID: 20476761
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.StoredProcedure.Definition
- Microsoft.Web.Management.DatabaseManager.StoredProcedure.get_Definition
- Microsoft.Web.Management.DatabaseManager.StoredProcedure.set_Definition
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.StoredProcedure.Definition
- Microsoft.Web.Management.DatabaseManager.StoredProcedure.get_Definition
- Microsoft.Web.Management.DatabaseManager.StoredProcedure.set_Definition
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StoredProcedure.Definition Property

Gets or sets the definition for a stored procedure.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property Definition As String
'Usage
Dim instance As StoredProcedure
Dim value As String

value = instance.Definition

instance.Definition = value
```

```csharp
public string Definition { get; set; }
```

```cpp
public:
property String^ Definition {
    String^ get ();
    void set (String^ value);
}
```

```jscript
function get Definition () : String
function set Definition (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The definition for a stored procedure.  

## Remarks

The definition for a stored procedure contains the collection of SQL statements that comprise the body of the stored procedure.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[StoredProcedure Class](storedprocedure-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
