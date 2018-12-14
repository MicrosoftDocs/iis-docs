---
title: Microsoft.Web.Management.DatabaseManager Namespace ()
TOCTitle: Microsoft.Web.Management.DatabaseManager
ms:assetid: N:Microsoft.Web.Management.DatabaseManager
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager(v=VS.90)
ms:contentKeyID: 20476685
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager
dev_langs:
- CSharp
- JScript
- VB
---

# Microsoft.Web.Management.DatabaseManager Namespace

The Microsoft.Web.Management.DatabaseManager namespace contains classes that a developer can use to build a provider to manage a database by using IIS Manager. Administrators can use this provider and the IIS Manager interface to remotely manage a database over the Internet.

The classes in the Microsoft.Web.Management.DatabaseManager namespace contain a series of top-level objects that let developers create providers that enable remote database administration tasks by using IIS Manager. The different logical objects represent the various database objects, including tables, views, stored procedures, columns, keys, and indexes. You can use the API to obtain and work with these objects to perform such actions as creating, deleting, or modifying tables, views, stored procedures, columns, keys, and indexes.


#### Notes for Implementers

After you have created a database provider, you must register it in the Global Assembly Cache for your server, and then register it in your Administration.config file before IIS Manager will recognize the provider. The following XML example illustrates a database provider registration from an Administration.config file.

    <system.webServer>
       <management>
          <dbManager>
             <DBProviders>
                <provider
                      name="SQL Server 2005/2008"
                      providerName="System.Data.SqlClient"
                      type="Microsoft.Web.Management.DatabaseManager.SqlDatabase.SqlDatabaseProvider, Microsoft.Web.Management.DatabaseManager.SqlDatabase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" >
                   <databaseBackup
                      backupEnabled="true"
                      restoreEnabled="true"
                      backupPath="C:\backups" />
                </provider>
             </DBProviders>
          </dbManager>
          </management>
    </system.webServer>

There are three attributes that your database provider must specify in the \<provider\> element before the database manager will recognize your database provider and display databases in IIS Manager. These attributes are listed in the following table:

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Parameter</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>name</p></td>
<td><p>(Required) A string that contains the friendly name for your provider.</p></td>
</tr>
<tr class="even">
<td><p>providerName</p></td>
<td><p>(Required) A string that contains the name of the .NET provider for your specific database. For example, you might specify System.Data.SqlClient for Microsoft SQL Server, or System.Data.OleDb for an OLEDB database.</p></td>
</tr>
<tr class="odd">
<td><p>type</p></td>
<td><p>(Required) The managed type for your database provider.</p></td>
</tr>
</tbody>
</table>


Depending on your implementation, there are three additional attributes that your database provider may specify in the \<databaseBackup\> element before the database manager will display the backup and restore options in IIS Manager. These attributes are listed in the following table:

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Parameter</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>backupPath</p></td>
<td><p>(Optional) A string that contains the path where the database manager will store database backup files.</p></td>
</tr>
<tr class="even">
<td><p>backupEnabled</p></td>
<td><p>(Optional) true if your provider supports backing up databases; otherwise, false.</p></td>
</tr>
<tr class="odd">
<td><p>restoreEnabled</p></td>
<td><p>(Optional) true if your provider supports restoring databases; otherwise, false.</p></td>
</tr>
</tbody>
</table>


The backupPath attribute may contain variables that IIS Manager will expand to their respective string equivalents. These variable names are case sensitive, and their descriptions are listed in the following table:

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Variable Names</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>{userName}</p></td>
<td><p>The current user's account name.</p></td>
</tr>
<tr class="even">
<td><p>{userDomain}</p></td>
<td><p>The name of the domain where the current user's account name is located.</p></td>
</tr>
<tr class="odd">
<td><p>{site}</p></td>
<td><p>The name of the current site.</p></td>
</tr>
<tr class="even">
<td><p>{appPath}</p></td>
<td><p>The name of the current application.</p></td>
</tr>
</tbody>
</table>


These variables are useful in an environment where multiple servers are storing backups in a common repository, such as a network location. For example, you could use a path such as \\\\server\\share\\{site}, so that multiple servers can share the same storage location, while being separated into unique folders by their respective site names.

## Classes

<table>
<thead>
<tr class="header">
<th> </th>
<th>Class</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="column-class-microsoft-web-management-databasemanager.md">Column</a></td>
<td>Represents a column within a database.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="columndatainfo-class-microsoft-web-management-databasemanager.md">ColumnDataInfo</a></td>
<td>Represents the information about the data in a column within the database that is being managed.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="connectionargument-class-microsoft-web-management-databasemanager.md">ConnectionArgument</a></td>
<td>Specifies a connection argument for a database connection.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="databaseinfo-class-microsoft-web-management-databasemanager.md">DatabaseInfo</a></td>
<td>Represents the class that contains database-specific information for a provider.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="databaseprovider-class-microsoft-web-management-databasemanager.md">DatabaseProvider</a></td>
<td>Represents the base class that needs to be implemented in order to manage a database.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="dependenciesmissingexception-class-microsoft-web-management-databasemanager.md">DependenciesMissingException</a></td>
<td></td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="foreignkey-class-microsoft-web-management-databasemanager.md">ForeignKey</a></td>
<td>Represents a foreign key within a database.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="foreignkeycolumn-class-microsoft-web-management-databasemanager.md">ForeignKeyColumn</a></td>
<td>Represents a foreign key column within a database.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="index-class-microsoft-web-management-databasemanager.md">Index</a></td>
<td>Represents an index within a database.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="indexcolumn-class-microsoft-web-management-databasemanager.md">IndexColumn</a></td>
<td>Represents an index column within a database.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="query-class-microsoft-web-management-databasemanager.md">Query</a></td>
<td>Represents a database query.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="querycolumnmetadata-class-microsoft-web-management-databasemanager.md">QueryColumnMetadata</a></td>
<td>Represents the metadata for a column within a query result.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="queryresult-class-microsoft-web-management-databasemanager.md">QueryResult</a></td>
<td>Represents a query result that was returned from a database query.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="storedprocedure-class-microsoft-web-management-databasemanager.md">StoredProcedure</a></td>
<td>Represents a stored procedure within a database.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="storedprocedureparameter-class-microsoft-web-management-databasemanager.md">StoredProcedureParameter</a></td>
<td>Represents a parameter for a stored procedure within a database.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="table-class-microsoft-web-management-databasemanager.md">Table</a></td>
<td>Represents a table within a database.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="tableinfo-class-microsoft-web-management-databasemanager.md">TableInfo</a></td>
<td>Represents the information for a table within a database.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="typeinfo-class-microsoft-web-management-databasemanager.md">TypeInfo</a></td>
<td>Represents data type information within a database.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="view-class-microsoft-web-management-databasemanager.md">View</a></td>
<td>Represents a view within a database.</td>
</tr>
</tbody>
</table>


## Interfaces

<table>
<thead>
<tr class="header">
<th> </th>
<th>Interface</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Public interface" alt="Public interface" /></td>
<td><a href="idbbackupmanager-interface-microsoft-web-management-databasemanager.md">IDbBackupManager</a></td>
<td>Represents a database backup manager interface.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Public interface" alt="Public interface" /></td>
<td><a href="idbcustombackuprestoremanager-interface-microsoft-web-management-databasemanager.md">IDbCustomBackupRestoreManager</a></td>
<td>Represents a custom database backup and restore manager interface.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Public interface" alt="Public interface" /></td>
<td><a href="idbrestoremanager-interface-microsoft-web-management-databasemanager.md">IDbRestoreManager</a></td>
<td>Represents a database restore manager interface.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Public interface" alt="Public interface" /></td>
<td><a href="idbstoredproceduremanager-interface-microsoft-web-management-databasemanager.md">IDbStoredProcedureManager</a></td>
<td>Represents a stored procedure manager interface for a database provider.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Public interface" alt="Public interface" /></td>
<td><a href="idbtabledatamanager-interface-microsoft-web-management-databasemanager.md">IDbTableDataManager</a></td>
<td>Represents a table data manager interface within a database provider.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Public interface" alt="Public interface" /></td>
<td><a href="idbtablemanager-interface-microsoft-web-management-databasemanager.md">IDbTableManager</a></td>
<td>Represents a table manager interface for the database provider.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Public interface" alt="Public interface" /></td>
<td><a href="idbviewmanager-interface-microsoft-web-management-databasemanager.md">IDbViewManager</a></td>
<td>Represents a view manager interface within a database provider.</td>
</tr>
</tbody>
</table>


## Enumerations

<table>
<thead>
<tr class="header">
<th> </th>
<th>Enumeration</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd566080.pubenumeration(en-us,VS.90).gif" title="Public enumeration" alt="Public enumeration" /></td>
<td><a href="columnchanges-enumeration-microsoft-web-management-databasemanager.md">ColumnChanges</a></td>
<td>Defines the values for pending column changes.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubenumeration(en-us,VS.90).gif" title="Public enumeration" alt="Public enumeration" /></td>
<td><a href="foreignkeychanges-enumeration-microsoft-web-management-databasemanager.md">ForeignKeyChanges</a></td>
<td>Specifies the changes for foreign keys in a database.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubenumeration(en-us,VS.90).gif" title="Public enumeration" alt="Public enumeration" /></td>
<td><a href="indexchanges-enumeration-microsoft-web-management-databasemanager.md">IndexChanges</a></td>
<td>Specifies the types of index changes for a database.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubenumeration(en-us,VS.90).gif" title="Public enumeration" alt="Public enumeration" /></td>
<td><a href="indextype-enumeration-microsoft-web-management-databasemanager.md">IndexType</a></td>
<td>Specifies the index types for databases.</td>
</tr>
</tbody>
</table>

