---
title: DatabaseProvider Class (Microsoft.Web.Management.DatabaseManager)
TOCTitle: DatabaseProvider Class
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.DatabaseProvider
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.databaseprovider(v=VS.90)
ms:contentKeyID: 20476612
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DatabaseProvider Class

Represents the base class that needs to be implemented in order to manage a database.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Management.DatabaseManager.DatabaseProvider  

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public MustInherit Class DatabaseProvider _
    Implements IServiceProvider
'Usage
Dim instance As DatabaseProvider
```

```csharp
public abstract class DatabaseProvider : IServiceProvider
```

```cpp
public ref class DatabaseProvider abstract : IServiceProvider
```

```jscript
public abstract class DatabaseProvider implements IServiceProvider
```

The DatabaseProvider type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[DatabaseProvider](databaseprovider-constructor-microsoft-web-management-databasemanager.md)|Creates a new instance of the DatabaseProvider class.|


## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[ConnectionStringArguments](databaseprovider-connectionstringarguments-property-microsoft-web-management-databasemanager.md)|Gets a collection that contains the collection of database connection arguments.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[CalculateConnectionString](databaseprovider-calculateconnectionstring-method-microsoft-web-management-databasemanager.md)|Returns the calculated connection string for the database provider.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[ExecuteQuery](databaseprovider-executequery-method-microsoft-web-management-databasemanager.md)|Returns an array of query results after executing a database query.|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetDatabaseHostName](databaseprovider-getdatabasehostname-method-microsoft-web-management-databasemanager.md)|Returns the host name of the computer where the database in the connection string is located.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetDatabaseInfo](databaseprovider-getdatabaseinfo-method-microsoft-web-management-databasemanager.md)|Returns database-specific information for the database provider.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetServerTypes](databaseprovider-getservertypes-method-microsoft-web-management-databasemanager.md)|Returns the list of supported server types for a database provider.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetService](databaseprovider-getservice-method-microsoft-web-management-databasemanager.md)|Returns the service object for a database provider.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[TestConnection](databaseprovider-testconnection-method-microsoft-web-management-databasemanager.md)|Tests a connection string for a database provider.|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[VerifyDependencies](databaseprovider-verifydependencies-method-microsoft-web-management-databasemanager.md)|Verifies the database dependencies for your provider.|

## Remarks

When writing a database provider, your provider must implement the base DatabaseProvider class and must also implement the following abstract members:

  - [ConnectionStringArguments](databaseprovider-connectionstringarguments-property-microsoft-web-management-databasemanager.md)

  - [CalculateConnectionString](databaseprovider-calculateconnectionstring-method-microsoft-web-management-databasemanager.md)

  - [ExecuteQuery](databaseprovider-executequery-method-microsoft-web-management-databasemanager.md)

  - [TestConnection](databaseprovider-testconnection-method-microsoft-web-management-databasemanager.md)

  - [GetServerTypes](databaseprovider-getservertypes-method-microsoft-web-management-databasemanager.md)

  - [GetDatabaseInfo](databaseprovider-getdatabaseinfo-method-microsoft-web-management-databasemanager.md)

  - [GetDatabaseHostName](databaseprovider-getdatabasehostname-method-microsoft-web-management-databasemanager.md)


> [!NOTE]  
> See the <strong>Notes for Implementers</strong> section in the [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md) topic for instructions about how to register your database provider for use with IIS Manager.


## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

