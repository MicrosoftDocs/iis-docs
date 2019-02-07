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

### 

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

|Parameter|Description|
|--- |--- |
|name|(Required) A string that contains the friendly name for your provider.|
|providerName|(Required) A string that contains the name of the .NET provider for your specific database. For example, you might specify System.Data.SqlClient for Microsoft SQL Server, or System.Data.OleDb for an OLEDB database.|
|type|(Required) The managed type for your database provider.|

Depending on your implementation, there are three additional attributes that your database provider may specify in the \<databaseBackup\> element before the database manager will display the backup and restore options in IIS Manager. These attributes are listed in the following table:

|Parameter|Description|
|--- |--- |
|backupPath|(Optional) A string that contains the path where the database manager will store database backup files.|
|backupEnabled|(Optional) true if your provider supports backing up databases; otherwise, false.|
|restoreEnabled|(Optional) true if your provider supports restoring databases; otherwise, false.|

The backupPath attribute may contain variables that IIS Manager will expand to their respective string equivalents. These variable names are case sensitive, and their descriptions are listed in the following table:

|Variable Names|Description|
|--- |--- |
|{userName}|The current user's account name.|
|{userDomain}|The name of the domain where the current user's account name is located.|
|{site}|The name of the current site.|
|{appPath}|The name of the current application.|

These variables are useful in an environment where multiple servers are storing backups in a common repository, such as a network location. For example, you could use a path such as \\\\server\\share\\{site}, so that multiple servers can share the same storage location, while being separated into unique folders by their respective site names.

## Classes

||Class|Description|
|--- |--- |--- |
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[Column](column-class-microsoft-web-management-databasemanager.md)|Represents a column within a database.|
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[ColumnDataInfo](columndatainfo-class-microsoft-web-management-databasemanager.md)|Represents the information about the data in a column within the database that is being managed.|
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[ConnectionArgument](connectionargument-class-microsoft-web-management-databasemanager.md)|Specifies a connection argument for a database connection.|
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[DatabaseInfo](databaseinfo-class-microsoft-web-management-databasemanager.md)|Represents the class that contains database-specific information for a provider.|
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[DatabaseProvider](databaseprovider-class-microsoft-web-management-databasemanager.md)|Represents the base class that needs to be implemented in order to manage a database.|
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[DependenciesMissingException](dependenciesmissingexception-class-microsoft-web-management-databasemanager.md)||
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[ForeignKey](foreignkey-class-microsoft-web-management-databasemanager.md)|Represents a foreign key within a database.|
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[ForeignKeyColumn](foreignkeycolumn-class-microsoft-web-management-databasemanager.md)|Represents a foreign key column within a database.|
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[Index](index-class-microsoft-web-management-databasemanager.md)|Represents an index within a database.|
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[IndexColumn](indexcolumn-class-microsoft-web-management-databasemanager.md)|Represents an index column within a database.|
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[Query](query-class-microsoft-web-management-databasemanager.md)|Represents a database query.|
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[QueryColumnMetadata](querycolumnmetadata-class-microsoft-web-management-databasemanager.md)|Represents the metadata for a column within a query result.|
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[QueryResult](queryresult-class-microsoft-web-management-databasemanager.md)|Represents a query result that was returned from a database query.|
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[StoredProcedure](storedprocedure-class-microsoft-web-management-databasemanager.md)|Represents a stored procedure within a database.|
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[StoredProcedureParameter](storedprocedureparameter-class-microsoft-web-management-databasemanager.md)|Represents a parameter for a stored procedure within a database.|
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[Table](table-class-microsoft-web-management-databasemanager.md)|Represents a table within a database.|
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[TableInfo](tableinfo-class-microsoft-web-management-databasemanager.md)|Represents the information for a table within a database.|
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[TypeInfo](typeinfo-class-microsoft-web-management-databasemanager.md)|Represents data type information within a database.|
|![Public class](images/Dd566080.pubclass(en-us,VS.90).gif "Public class")|[View](view-class-microsoft-web-management-databasemanager.md)|Represents a view within a database.|

## Interfaces

||Interface|Description|
|--- |--- |--- |
|![Public interface](images/Dd566080.pubinterface(en-us,VS.90).gif "Public interface")|[IDbBackupManager](idbbackupmanager-interface-microsoft-web-management-databasemanager.md)|Represents a database backup manager interface.|
|![Public interface](images/Dd566080.pubinterface(en-us,VS.90).gif "Public interface")|[IDbCustomBackupRestoreManager](idbcustombackuprestoremanager-interface-microsoft-web-management-databasemanager.md)|Represents a custom database backup and restore manager interface.|
|![Public interface](images/Dd566080.pubinterface(en-us,VS.90).gif "Public interface")|[IDbRestoreManager](idbrestoremanager-interface-microsoft-web-management-databasemanager.md)|Represents a database restore manager interface.|
|![Public interface](images/Dd566080.pubinterface(en-us,VS.90).gif "Public interface")|[IDbStoredProcedureManager](idbstoredproceduremanager-interface-microsoft-web-management-databasemanager.md)|Represents a stored procedure manager interface for a database provider.|
|![Public interface](images/Dd566080.pubinterface(en-us,VS.90).gif "Public interface")|[IDbTableDataManager](idbtabledatamanager-interface-microsoft-web-management-databasemanager.md)|Represents a table data manager interface within a database provider.|
|![Public interface](images/Dd566080.pubinterface(en-us,VS.90).gif "Public interface")|[IDbTableManager](idbtablemanager-interface-microsoft-web-management-databasemanager.md)|Represents a table manager interface for the database provider.|
|![Public interface](images/Dd566080.pubinterface(en-us,VS.90).gif "Public interface")|[IDbViewManager](idbviewmanager-interface-microsoft-web-management-databasemanager.md)|Represents a view manager interface within a database provider.|

## Enumerations

||Enumeration|Description|
|--- |--- |--- |
|![Public enumeration](images/Dd566080.pubenumeration(en-us,VS.90).gif "Public enumeration")|[ColumnChanges](columnchanges-enumeration-microsoft-web-management-databasemanager.md)|Defines the values for pending column changes.|
|![Public enumeration](images/Dd566080.pubenumeration(en-us,VS.90).gif "Public enumeration")|[ForeignKeyChanges](foreignkeychanges-enumeration-microsoft-web-management-databasemanager.md)|Specifies the changes for foreign keys in a database.|
|![Public enumeration](images/Dd566080.pubenumeration(en-us,VS.90).gif "Public enumeration")|[IndexChanges](indexchanges-enumeration-microsoft-web-management-databasemanager.md)|Specifies the types of index changes for a database.|
|![Public enumeration](images/Dd566080.pubenumeration(en-us,VS.90).gif "Public enumeration")|[IndexType](indextype-enumeration-microsoft-web-management-databasemanager.md)|Specifies the index types for databases.|

