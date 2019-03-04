---
title: TableInfo.HasChanges Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: HasChanges Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.TableInfo.HasChanges
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.tableinfo.haschanges(v=VS.90)
ms:contentKeyID: 22049619
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.TableInfo.HasChanges
- Microsoft.Web.Management.DatabaseManager.TableInfo.get_HasChanges
- Microsoft.Web.Management.DatabaseManager.TableInfo.set_HasChanges
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.TableInfo.get_HasChanges
- Microsoft.Web.Management.DatabaseManager.TableInfo.HasChanges
- Microsoft.Web.Management.DatabaseManager.TableInfo.set_HasChanges
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TableInfo.HasChanges Property

Gets or sets a value that indicates whether the table information has changes.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property HasChanges As Boolean
'Usage
Dim instance As TableInfo
Dim value As Boolean

value = instance.HasChanges

instance.HasChanges = value
```

```csharp
public bool HasChanges { get; set; }
```

```cpp
public:
property bool HasChanges {
    bool get ();
    void set (bool value);
}
```

```jscript
function get HasChanges () : boolean
function set HasChanges (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the table information is marked as having changes; otherwise, false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TableInfo Class](tableinfo-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

