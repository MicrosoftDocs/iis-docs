---
title: Index Class (Microsoft.Web.Management.DatabaseManager)
description: Describes the Index class and provides the class' inheritance hierarchy, syntax, constructors, properties, and methods.
TOCTitle: Index Class
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.Index
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.index(v=VS.90)
ms:contentKeyID: 20476422
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.Index
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.Index
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Index Class

Represents an index within a database.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Management.DatabaseManager.Index  

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Class Index
'Usage
Dim instance As Index
```

```csharp
public class Index
```

```cpp
public ref class Index
```

```jscript
public class Index
```

The Index type exposes the following members.

## Constructors

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[Index](index-constructor-microsoft-web-management-databasemanager.md)|Creates a new instance of the Index class.|

## Properties

|Property Type|Name|Description|
|--- |--- |--- |
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Clustered](index-clustered-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the index is clustered.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Columns](index-columns-property-microsoft-web-management-databasemanager.md)|Returns a list of columns for the index.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[IgnoreDuplicateKeys](index-ignoreduplicatekeys-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the index ignores duplicate keys.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[IndexType](index-indextype-property-microsoft-web-management-databasemanager.md)|Gets or sets the [IndexType](indextype-enumeration-microsoft-web-management-databasemanager.md) property for the index.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[IsMarkedForDelete](index-ismarkedfordelete-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the index is marked for deletion.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[IsNew](index-isnew-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the index is new.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Name](index-name-property-microsoft-web-management-databasemanager.md)|Gets or sets the name for the index.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[OriginalName](index-originalname-property-microsoft-web-management-databasemanager.md)|Gets or sets the original name for the index.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Unique](index-unique-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the index is unique.|

## Methods

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetChanges](index-getchanges-method-microsoft-web-management-databasemanager.md)|Returns a value that indicates whether there are changes in the index.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
