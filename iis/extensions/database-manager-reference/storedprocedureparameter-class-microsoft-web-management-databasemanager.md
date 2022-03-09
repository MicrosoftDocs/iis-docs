---
title: StoredProcedureParameter Class (Microsoft.Web.Management.DatabaseManager)
TOCTitle: StoredProcedureParameter Class
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.storedprocedureparameter(v=VS.90)
ms:contentKeyID: 20476410
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StoredProcedureParameter Class

Represents a parameter for a stored procedure within a database.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter  

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Class StoredProcedureParameter
'Usage
Dim instance As StoredProcedureParameter
```

```csharp
public class StoredProcedureParameter
```

```cpp
public ref class StoredProcedureParameter
```

```jscript
public class StoredProcedureParameter
```

The StoredProcedureParameter type exposes the following members.

## Constructors

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[StoredProcedureParameter](storedprocedureparameter-constructor-microsoft-web-management-databasemanager.md)|Creates a new instance of the StoredProcedureParameter class.|

## Properties

|Property Type|Name|Description|
|--- |--- |--- |
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[IsNull](storedprocedureparameter-isnull-property-microsoft-web-management-databasemanager.md)|Returns a value that indicates whether the parameter for a stored procedure is nulla null reference (Nothing in Visual Basic).|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[IsOutputParameter](storedprocedureparameter-isoutputparameter-property-microsoft-web-management-databasemanager.md)|Returns a value that indicates whether the parameter for a stored procedure is an output parameter.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Name](storedprocedureparameter-name-property-microsoft-web-management-databasemanager.md)|Gets or sets the name of the parameter for a stored procedure.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Tag](storedprocedureparameter-tag-property-microsoft-web-management-databasemanager.md)|Returns a generic object that is stored in the StoredProcedureParameter class.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[TypeInfo](storedprocedureparameter-typeinfo-property-microsoft-web-management-databasemanager.md)|Gets or sets the type information for a parameter of a stored procedure.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Value](storedprocedureparameter-value-property-microsoft-web-management-databasemanager.md)|Gets or sets the value of the parameter for a stored procedure.|

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

Stored procedures are collections of SQL code that execute on the server, and are often used to perform various tasks in place of queries. Parameters are variables that are passed to stored procedures. For example, you could create a stored procedure that performs a query that is based on values that are calculated from parameters that you pass to the stored procedure.

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
