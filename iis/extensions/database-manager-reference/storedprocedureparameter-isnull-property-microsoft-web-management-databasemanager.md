---
title: StoredProcedureParameter.IsNull Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: IsNull Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.IsNull
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.storedprocedureparameter.isnull(v=VS.90)
ms:contentKeyID: 20476670
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.IsNull
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.get_IsNull
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.set_IsNull
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.get_IsNull
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.IsNull
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.set_IsNull
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StoredProcedureParameter.IsNull Property

Returns a value that indicates whether the parameter for a stored procedure is nulla null reference (Nothing in Visual Basic).

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property IsNull As Boolean
'Usage
Dim instance As StoredProcedureParameter
Dim value As Boolean

value = instance.IsNull

instance.IsNull = value
```

```csharp
public bool IsNull { get; set; }
```

```cpp
public:
property bool IsNull {
    bool get ();
    void set (bool value);
}
```

```jscript
function get IsNull () : boolean
function set IsNull (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the parameter is nulla null reference (Nothing in Visual Basic); otherwise, false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[StoredProcedureParameter Class](storedprocedureparameter-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

