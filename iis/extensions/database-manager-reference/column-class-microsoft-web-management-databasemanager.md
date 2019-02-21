---
title: Column Class (Microsoft.Web.Management.DatabaseManager)
TOCTitle: Column Class
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.Column
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.column(v=VS.90)
ms:contentKeyID: 20476404
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.Column
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.Column
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Column Class

Represents a column within a database.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Management.DatabaseManager.Column  

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Class Column
'Usage
Dim instance As Column
```

```csharp
public class Column
```

```cpp
public ref class Column
```

```jscript
public class Column
```

The Column type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[Column](column-constructor-microsoft-web-management-databasemanager.md)|Creates a new instance of the Column class.|


## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[AllowNulls](column-allownulls-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the database column allows nulla null reference (Nothing in Visual Basic) values.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Changes](column-changes-property-microsoft-web-management-databasemanager.md)|Gets or sets the flags that indicate which changes are pending for the database column.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[DefaultValue](column-defaultvalue-property-microsoft-web-management-databasemanager.md)|Gets or sets the default value for the database column.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[InPrimaryKey](column-inprimarykey-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the database column is in the primary key.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[IsIdentity](column-isidentity-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the database column is an identity column.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[IsMarkedForDelete](column-ismarkedfordelete-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the database column is marked for deletion.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[IsNew](column-isnew-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the database column is new.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Length](column-length-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that specifies the length of the database column.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Name](column-name-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that specifies the name of the database column.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[OriginalName](column-originalname-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that specifies the original name of the database column.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Precision](column-precision-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that specifies the numeric precision of the database column.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Scale](column-scale-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that specifies the numeric scale of the database column.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Tag](column-tag-property-microsoft-web-management-databasemanager.md)|Returns a generic object that is stored in the Column class.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[TypeInfo](column-typeinfo-property-microsoft-web-management-databasemanager.md)|Retrieves the type information for a column.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[HasChanges](column-haschanges-method-microsoft-web-management-databasemanager.md)|Retrieves whether the column has specific changes.|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[SetColumnIsInPrimaryKey](column-setcolumnisinprimarykey-method-microsoft-web-management-databasemanager.md)|Specifies the database column as part of the primary key.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

