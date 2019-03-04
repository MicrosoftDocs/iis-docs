---
title: StoredProcedureParameter.TypeInfo Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: TypeInfo Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.TypeInfo
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.storedprocedureparameter.typeinfo(v=VS.90)
ms:contentKeyID: 22049609
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.TypeInfo
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.get_TypeInfo
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.set_TypeInfo
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.get_TypeInfo
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.set_TypeInfo
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.TypeInfo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StoredProcedureParameter.TypeInfo Property

Gets or sets the type information for a parameter of a stored procedure.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property TypeInfo As TypeInfo
'Usage
Dim instance As StoredProcedureParameter
Dim value As TypeInfo

value = instance.TypeInfo

instance.TypeInfo = value
```

```csharp
public TypeInfo TypeInfo { get; set; }
```

```cpp
public:
property TypeInfo^ TypeInfo {
    TypeInfo^ get ();
    void set (TypeInfo^ value);
}
```

```jscript
function get TypeInfo () : TypeInfo
function set TypeInfo (value : TypeInfo)
```

### Property Value

Type: [Microsoft.Web.Management.DatabaseManager.TypeInfo](typeinfo-class-microsoft-web-management-databasemanager.md)  
A [TypeInfo](typeinfo-class-microsoft-web-management-databasemanager.md) object that contains the type information for the parameter.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[StoredProcedureParameter Class](storedprocedureparameter-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

