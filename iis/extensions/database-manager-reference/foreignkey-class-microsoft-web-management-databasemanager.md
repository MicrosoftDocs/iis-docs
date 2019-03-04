---
title: ForeignKey Class (Microsoft.Web.Management.DatabaseManager)
TOCTitle: ForeignKey Class
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.ForeignKey
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.foreignkey(v=VS.90)
ms:contentKeyID: 20476630
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.ForeignKey
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.ForeignKey
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ForeignKey Class

Represents a foreign key within a database.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Management.DatabaseManager.ForeignKey  

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Class ForeignKey
'Usage
Dim instance As ForeignKey
```

```csharp
public class ForeignKey
```

```cpp
public ref class ForeignKey
```

```jscript
public class ForeignKey
```

The ForeignKey type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[ForeignKey](foreignkey-constructor-microsoft-web-management-databasemanager.md)|Creates a new instance of the ForeignKey class.|


## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[FKColumns](foreignkey-fkcolumns-property-microsoft-web-management-databasemanager.md)|Retrieves a list of foreign key columns.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[FKTableName](foreignkey-fktablename-property-microsoft-web-management-databasemanager.md)|Gets or sets the table name for a foreign key.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[FKTableSchema](foreignkey-fktableschema-property-microsoft-web-management-databasemanager.md)|Gets or sets the schema table name for a foreign key.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[IsMarkedForDelete](foreignkey-ismarkedfordelete-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the foreign key is marked for deletion.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[IsNew](foreignkey-isnew-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the foreign key is new.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Name](foreignkey-name-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that specifies the name of the foreign key.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[OriginalName](foreignkey-originalname-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that specifies the original name of the foreign key.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[PKColumns](foreignkey-pkcolumns-property-microsoft-web-management-databasemanager.md)|Gets a list of primary key columns.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[PKTableName](foreignkey-pktablename-property-microsoft-web-management-databasemanager.md)|Gets or sets the table name of the primary key.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[PKTableSchema](foreignkey-pktableschema-property-microsoft-web-management-databasemanager.md)|Gets or sets the schema table name of the primary key.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetChanges](foreignkey-getchanges-method-microsoft-web-management-databasemanager.md)|Returns a value that indicates whether the foreign key has changes pending.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

