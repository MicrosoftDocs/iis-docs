---
title: Column.Changes Property  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: Changes Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.Column.Changes
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.column.changes(v=VS.90)
ms:contentKeyID: 20476650
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.Column.Changes
- Microsoft.Web.Management.DatabaseManager.Column.get_Changes
- Microsoft.Web.Management.DatabaseManager.Column.set_Changes
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.Column.Changes
- Microsoft.Web.Management.DatabaseManager.Column.get_Changes
- Microsoft.Web.Management.DatabaseManager.Column.set_Changes
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Column.Changes Property

Gets or sets the flags that indicate which changes are pending for the database column.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Public Overridable Property Changes As ColumnChanges
'Usage
Dim instance As Column
Dim value As ColumnChanges

value = instance.Changes

instance.Changes = value
```

``` csharp
public virtual ColumnChanges Changes { get; set; }
```

``` c++
public:
virtual property ColumnChanges Changes {
    ColumnChanges get ();
    void set (ColumnChanges value);
}
```

``` jscript
function get Changes () : ColumnChanges
function set Changes (value : ColumnChanges)
```

#### Property Value

Type: [Microsoft.Web.Management.DatabaseManager.ColumnChanges](columnchanges-enumeration-microsoft-web-management-databasemanager.md)  
The [ColumnChanges](columnchanges-enumeration-microsoft-web-management-databasemanager.md) flags for the database column.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[Column Class](column-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

