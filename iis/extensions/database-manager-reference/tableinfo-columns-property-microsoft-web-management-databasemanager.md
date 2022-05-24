---
title: TableInfo.Columns Property (Microsoft.Web.Management.DatabaseManager)
description: Details the syntax for the TableInfo.Columns property and returns a list of columns within the table information.
TOCTitle: Columns Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.TableInfo.Columns
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.tableinfo.columns(v=VS.90)
ms:contentKeyID: 20476438
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.TableInfo.Columns
- Microsoft.Web.Management.DatabaseManager.TableInfo.get_Columns
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.TableInfo.Columns
- Microsoft.Web.Management.DatabaseManager.TableInfo.get_Columns
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TableInfo.Columns Property

Returns a list of columns within the table information.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public ReadOnly Property Columns As IList(Of Column)
'Usage
Dim instance As TableInfo
Dim value As IList(Of Column)

value = instance.Columns
```

```csharp
public IList<Column> Columns { get; }
```

```cpp
public:
property IList<Column^>^ Columns {
    IList<Column^>^ get ();
}
```

```jscript
function get Columns () : IList<Column>
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6)\<[Column](column-class-microsoft-web-management-databasemanager.md)\>  
An IList interface that contains a collection of [Column](column-class-microsoft-web-management-databasemanager.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TableInfo Class](tableinfo-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
