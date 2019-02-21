---
title: TableInfo.Indexes Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: Indexes Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.TableInfo.Indexes
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.tableinfo.indexes(v=VS.90)
ms:contentKeyID: 20476608
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.TableInfo.Indexes
- Microsoft.Web.Management.DatabaseManager.TableInfo.get_Indexes
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.TableInfo.get_Indexes
- Microsoft.Web.Management.DatabaseManager.TableInfo.Indexes
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# TableInfo.Indexes Property

Returns a list of indexes within the table information.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public ReadOnly Property Indexes As IList(Of Index)
'Usage
Dim instance As TableInfo
Dim value As IList(Of Index)

value = instance.Indexes
```

```csharp
public IList<Index> Indexes { get; }
```

```cpp
public:
property IList<Index^>^ Indexes {
    IList<Index^>^ get ();
}
```

```jscript
function get Indexes () : IList<Index>
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6)\<[Index](index-class-microsoft-web-management-databasemanager.md)\>  
An IList interface that contains a collection of Microsoft.Web.Management.DatabaseManager.Index objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TableInfo Class](tableinfo-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

