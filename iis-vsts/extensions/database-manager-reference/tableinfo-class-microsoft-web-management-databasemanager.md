---
title: TableInfo Class (Microsoft.Web.Management.DatabaseManager)
TOCTitle: TableInfo Class
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.TableInfo
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.tableinfo(v=VS.90)
ms:contentKeyID: 20476651
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.TableInfo
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.TableInfo
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TableInfo Class

Represents the information for a table within a database.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Management.DatabaseManager.TableInfo  

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Class TableInfo
'Usage
Dim instance As TableInfo
```

```csharp
public class TableInfo
```

```cpp
public ref class TableInfo
```

```jscript
public class TableInfo
```

The TableInfo type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[TableInfo](tableinfo-constructor-microsoft-web-management-databasemanager.md)|Creates a new instance of the TableInfo class.|


## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Columns](tableinfo-columns-property-microsoft-web-management-databasemanager.md)|Returns a list of columns within the table information.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[ForeignKeys](tableinfo-foreignkeys-property-microsoft-web-management-databasemanager.md)|Returns a list of foreign keys within the table information.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[HasChanges](tableinfo-haschanges-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the table information has changes.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Indexes](tableinfo-indexes-property-microsoft-web-management-databasemanager.md)|Returns a list of indexes within the table information.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[IsMarkedForDelete](tableinfo-ismarkedfordelete-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the table information is marked for deletion.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Name](tableinfo-name-property-microsoft-web-management-databasemanager.md)|Gets or sets the name of the table.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

