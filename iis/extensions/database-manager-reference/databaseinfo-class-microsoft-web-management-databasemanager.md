---
title: DatabaseInfo Class (Microsoft.Web.Management.DatabaseManager)
description: The DatabaseInfo Class contains database-specific information for a provider. This page lists the constructors, properties, and methods available.
TOCTitle: DatabaseInfo Class
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.DatabaseInfo
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.databaseinfo(v=VS.90)
ms:contentKeyID: 22049610
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.DatabaseInfo
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.DatabaseInfo
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DatabaseInfo Class

Represents the class that contains database-specific information for a provider.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Management.DatabaseManager.DatabaseInfo  

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Class DatabaseInfo
'Usage
Dim instance As DatabaseInfo
```

```csharp
public class DatabaseInfo
```

```cpp
public ref class DatabaseInfo
```

```jscript
public class DatabaseInfo
```

The DatabaseInfo type exposes the following members.

## Constructors

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[DatabaseInfo](databaseinfo-constructor-microsoft-web-management-databasemanager.md)|Creates a new instance of the DatabaseInfo class.|

## Properties

|Property Type|Name|Description|
|--- |--- |--- |
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[SupportsSchemas](databaseinfo-supportsschemas-property-microsoft-web-management-databasemanager.md)|Specifies whether the database supports schemas.|

## Methods

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Remarks

The [GetDatabaseInfo](databaseprovider-getdatabaseinfo-method-microsoft-web-management-databasemanager.md) method returns a DatabaseInfo object that contains information that is specific to the database that is supported by a provider.

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
