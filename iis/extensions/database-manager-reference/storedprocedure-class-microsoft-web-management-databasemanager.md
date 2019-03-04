---
title: StoredProcedure Class (Microsoft.Web.Management.DatabaseManager)
TOCTitle: StoredProcedure Class
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.StoredProcedure
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.storedprocedure(v=VS.90)
ms:contentKeyID: 20476737
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.StoredProcedure
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.StoredProcedure
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StoredProcedure Class

Represents a stored procedure within a database.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Management.DatabaseManager.StoredProcedure  

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Class StoredProcedure
'Usage
Dim instance As StoredProcedure
```

```csharp
public class StoredProcedure
```

```cpp
public ref class StoredProcedure
```

```jscript
public class StoredProcedure
```

The StoredProcedure type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[StoredProcedure](storedprocedure-constructor-microsoft-web-management-databasemanager.md)|Creates a new instance of the StoredProcedure class.|


## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Definition](storedprocedure-definition-property-microsoft-web-management-databasemanager.md)|Gets or sets the definition for a stored procedure.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Name](storedprocedure-name-property-microsoft-web-management-databasemanager.md)|Gets or sets the name for a stored procedure.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Schema](storedprocedure-schema-property-microsoft-web-management-databasemanager.md)|Gets or sets the schema name for a stored procedure.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Remarks

Stored procedures are collections of SQL code that execute on the server, and are often used in place of queries. For example, you could create a stored procedure that performs a query that is based on values that are calculated from parameters that you pass to the stored procedure.

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

