---
title: TableInfo.IsMarkedForDelete Property  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: IsMarkedForDelete Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.TableInfo.IsMarkedForDelete
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.tableinfo.ismarkedfordelete(v=VS.90)
ms:contentKeyID: 20476641
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.TableInfo.IsMarkedForDelete
- Microsoft.Web.Management.DatabaseManager.TableInfo.get_IsMarkedForDelete
- Microsoft.Web.Management.DatabaseManager.TableInfo.set_IsMarkedForDelete
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.TableInfo.get_IsMarkedForDelete
- Microsoft.Web.Management.DatabaseManager.TableInfo.IsMarkedForDelete
- Microsoft.Web.Management.DatabaseManager.TableInfo.set_IsMarkedForDelete
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TableInfo.IsMarkedForDelete Property

Gets or sets a value that indicates whether the table information is marked for deletion.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Public Property IsMarkedForDelete As Boolean
'Usage
Dim instance As TableInfo
Dim value As Boolean

value = instance.IsMarkedForDelete

instance.IsMarkedForDelete = value
```

``` csharp
public bool IsMarkedForDelete { get; set; }
```

``` c++
public:
property bool IsMarkedForDelete {
    bool get ();
    void set (bool value);
}
```

``` jscript
function get IsMarkedForDelete () : boolean
function set IsMarkedForDelete (value : boolean)
```

#### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the table information is marked for deletion; otherwise, false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[TableInfo Class](tableinfo-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

