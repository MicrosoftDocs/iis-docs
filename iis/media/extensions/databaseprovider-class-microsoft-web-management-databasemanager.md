---
title: DatabaseProvider Class (Microsoft.Web.Management.DatabaseManager)
TOCTitle: DatabaseProvider Class
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.DatabaseProvider
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.databaseprovider(v=VS.90)
ms:contentKeyID: 20476612
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DatabaseProvider Class

Represents the base class that needs to be implemented in order to manage a database.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Management.DatabaseManager.DatabaseProvider  

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Public MustInherit Class DatabaseProvider _
    Implements IServiceProvider
'Usage
Dim instance As DatabaseProvider
```

``` csharp
public abstract class DatabaseProvider : IServiceProvider
```

``` c++
public ref class DatabaseProvider abstract : IServiceProvider
```

``` jscript
public abstract class DatabaseProvider implements IServiceProvider
```

The DatabaseProvider type exposes the following members.

## Constructors

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="databaseprovider-constructor-microsoft-web-management-databasemanager.md">DatabaseProvider</a></td>
<td>Creates a new instance of the DatabaseProvider class.</td>
</tr>
</tbody>
</table>


Top

## Properties

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="databaseprovider-connectionstringarguments-property-microsoft-web-management-databasemanager.md">ConnectionStringArguments</a></td>
<td>Gets a collection that contains the collection of database connection arguments.</td>
</tr>
</tbody>
</table>


Top

## Methods

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="databaseprovider-calculateconnectionstring-method-microsoft-web-management-databasemanager.md">CalculateConnectionString</a></td>
<td>Returns the calculated connection string for the database provider.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="databaseprovider-executequery-method-microsoft-web-management-databasemanager.md">ExecuteQuery</a></td>
<td>Returns an array of query results after executing a database query.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="databaseprovider-getdatabasehostname-method-microsoft-web-management-databasemanager.md">GetDatabaseHostName</a></td>
<td>Returns the host name of the computer where the database in the connection string is located.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="databaseprovider-getdatabaseinfo-method-microsoft-web-management-databasemanager.md">GetDatabaseInfo</a></td>
<td>Returns database-specific information for the database provider.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="databaseprovider-getservertypes-method-microsoft-web-management-databasemanager.md">GetServerTypes</a></td>
<td>Returns the list of supported server types for a database provider.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="databaseprovider-getservice-method-microsoft-web-management-databasemanager.md">GetService</a></td>
<td>Returns the service object for a database provider.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="databaseprovider-testconnection-method-microsoft-web-management-databasemanager.md">TestConnection</a></td>
<td>Tests a connection string for a database provider.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="databaseprovider-verifydependencies-method-microsoft-web-management-databasemanager.md">VerifyDependencies</a></td>
<td>Verifies the database dependencies for your provider.</td>
</tr>
</tbody>
</table>


Top

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
> <P>See the <STRONG>Notes for Implementers</STRONG> section in the <A href="microsoft-web-management-databasemanager-namespace.md">Microsoft.Web.Management.DatabaseManager</A> topic for instructions about how to register your database provider for use with IIS Manager.</P>



## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

