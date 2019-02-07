---
title: Index.IgnoreDuplicateKeys Property  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: IgnoreDuplicateKeys Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.Index.IgnoreDuplicateKeys
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.index.ignoreduplicatekeys(v=VS.90)
ms:contentKeyID: 20476481
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.Index.IgnoreDuplicateKeys
- Microsoft.Web.Management.DatabaseManager.Index.get_IgnoreDuplicateKeys
- Microsoft.Web.Management.DatabaseManager.Index.set_IgnoreDuplicateKeys
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.Index.get_IgnoreDuplicateKeys
- Microsoft.Web.Management.DatabaseManager.Index.IgnoreDuplicateKeys
- Microsoft.Web.Management.DatabaseManager.Index.set_IgnoreDuplicateKeys
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Index.IgnoreDuplicateKeys Property

Gets or sets a value that indicates whether the index ignores duplicate keys.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Public Property IgnoreDuplicateKeys As Boolean
'Usage
Dim instance As Index
Dim value As Boolean

value = instance.IgnoreDuplicateKeys

instance.IgnoreDuplicateKeys = value
```

``` csharp
public bool IgnoreDuplicateKeys { get; set; }
```

``` c++
public:
property bool IgnoreDuplicateKeys {
    bool get ();
    void set (bool value);
}
```

``` jscript
function get IgnoreDuplicateKeys () : boolean
function set IgnoreDuplicateKeys (value : boolean)
```

#### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the index ignores duplicate keys; otherwise, false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[Index Class](index-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

