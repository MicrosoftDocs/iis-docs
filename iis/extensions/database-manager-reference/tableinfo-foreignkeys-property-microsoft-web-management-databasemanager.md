---
title: TableInfo.ForeignKeys Property  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: ForeignKeys Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.TableInfo.ForeignKeys
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.tableinfo.foreignkeys(v=VS.90)
ms:contentKeyID: 20476734
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.TableInfo.ForeignKeys
- Microsoft.Web.Management.DatabaseManager.TableInfo.get_ForeignKeys
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.TableInfo.ForeignKeys
- Microsoft.Web.Management.DatabaseManager.TableInfo.get_ForeignKeys
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TableInfo.ForeignKeys Property

Returns a list of foreign keys within the table information.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Public ReadOnly Property ForeignKeys As IList(Of ForeignKey)
'Usage
Dim instance As TableInfo
Dim value As IList(Of ForeignKey)

value = instance.ForeignKeys
```

``` csharp
public IList<ForeignKey> ForeignKeys { get; }
```

``` c++
public:
property IList<ForeignKey^>^ ForeignKeys {
    IList<ForeignKey^>^ get ();
}
```

``` jscript
function get ForeignKeys () : IList<ForeignKey>
```

#### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/en-us/library/5y536ey6\(v=vs.90\))\<[ForeignKey](foreignkey-class-microsoft-web-management-databasemanager.md)\>  
An IList interface that contains a collection of [ForeignKey](foreignkey-class-microsoft-web-management-databasemanager.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[TableInfo Class](tableinfo-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

