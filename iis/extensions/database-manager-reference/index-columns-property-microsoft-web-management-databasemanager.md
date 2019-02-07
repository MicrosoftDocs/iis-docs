---
title: Index.Columns Property  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: Columns Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.Index.Columns
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.index.columns(v=VS.90)
ms:contentKeyID: 20476806
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.Index.Columns
- Microsoft.Web.Management.DatabaseManager.Index.get_Columns
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.Index.Columns
- Microsoft.Web.Management.DatabaseManager.Index.get_Columns
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Index.Columns Property

Returns a list of columns for the index.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Public ReadOnly Property Columns As IList(Of IndexColumn)
'Usage
Dim instance As Index
Dim value As IList(Of IndexColumn)

value = instance.Columns
```

``` csharp
public IList<IndexColumn> Columns { get; }
```

``` c++
public:
property IList<IndexColumn^>^ Columns {
    IList<IndexColumn^>^ get ();
}
```

``` jscript
function get Columns () : IList<IndexColumn>
```

#### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/en-us/library/5y536ey6\(v=vs.90\))\<[IndexColumn](indexcolumn-class-microsoft-web-management-databasemanager.md)\>  
An IList interface for the list of [IndexColumn](indexcolumn-class-microsoft-web-management-databasemanager.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[Index Class](index-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
