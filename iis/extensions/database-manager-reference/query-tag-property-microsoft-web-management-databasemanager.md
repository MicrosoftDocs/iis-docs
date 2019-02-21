---
title: Query.Tag Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: Tag Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.Query.Tag
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.query.tag(v=VS.90)
ms:contentKeyID: 22049482
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.Query.Tag
- Microsoft.Web.Management.DatabaseManager.Query.get_Tag
- Microsoft.Web.Management.DatabaseManager.Query.set_Tag
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.Query.get_Tag
- Microsoft.Web.Management.DatabaseManager.Query.Tag
- Microsoft.Web.Management.DatabaseManager.Query.set_Tag
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Query.Tag Property

Returns a generic object that is stored in the Query class.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property Tag As Object
'Usage
Dim instance As Query
Dim value As Object

value = instance.Tag

instance.Tag = value
```

```csharp
public Object Tag { get; set; }
```

```cpp
public:
property Object^ Tag {
    Object^ get ();
    void set (Object^ value);
}
```

```jscript
function get Tag () : Object
function set Tag (value : Object)
```

### Property Value

Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
The generic object.  

## Remarks

The Tag property provides a simple storage mechanism that lets your database provider store application-specific information for your provider.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[Query Class](query-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

