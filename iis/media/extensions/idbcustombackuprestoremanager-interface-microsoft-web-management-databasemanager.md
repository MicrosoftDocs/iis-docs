---
title: IDbCustomBackupRestoreManager Interface (Microsoft.Web.Management.DatabaseManager)
TOCTitle: IDbCustomBackupRestoreManager Interface
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.IDbCustomBackupRestoreManager
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.idbcustombackuprestoremanager(v=VS.90)
ms:contentKeyID: 22049493
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbCustomBackupRestoreManager
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbCustomBackupRestoreManager
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IDbCustomBackupRestoreManager Interface

Represents a custom database backup and restore manager interface.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Public Interface IDbCustomBackupRestoreManager _
    Inherits IDbBackupManager, IDbRestoreManager
'Usage
Dim instance As IDbCustomBackupRestoreManager
```

``` csharp
public interface IDbCustomBackupRestoreManager : IDbBackupManager, 
    IDbRestoreManager
```

``` c++
public interface class IDbCustomBackupRestoreManager : IDbBackupManager, 
    IDbRestoreManager
```

``` jscript
public interface IDbCustomBackupRestoreManager extends IDbBackupManager, IDbRestoreManager
```

The IDbCustomBackupRestoreManager type exposes the following members.

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
<td><a href="idbbackupmanager-createbackup-method-microsoft-web-management-databasemanager.md">CreateBackup</a></td>
<td>Creates a database backup. (Inherited from <a href="idbbackupmanager-interface-microsoft-web-management-databasemanager.md">IDbBackupManager</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="idbcustombackuprestoremanager-listbackups-method-microsoft-web-management-databasemanager.md">ListBackups</a></td>
<td>Retrieves a list of database backup names for a custom backup and restore module.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="idbrestoremanager-restorebackup-method-microsoft-web-management-databasemanager.md">RestoreBackup</a></td>
<td>Restores a database backup. (Inherited from <a href="idbrestoremanager-interface-microsoft-web-management-databasemanager.md">IDbRestoreManager</a>.)</td>
</tr>
</tbody>
</table>


Top

## Remarks

Developers can use the IDbCustomBackupRestoreManager interface to override the existing backup and restore functionality of a database provider. For example, if you have already written a database backup and restore feature for your database type using .NET, you can add an instance of IDbCustomBackupRestoreManager to your assembly to allow the IIS database manager to list your database backups and call your existing backup and restore features.

After you have created a custom backup and restore database manager for a databse provider, you must register it in the Global Assembly Cache for your server, then you must register it in your Administration.config file before IIS Manager will override the existing backup and restore functionality of a database provider.

The following example shows a sample registration for a custom backup and restore manager that is added to the SQL server database provider, and will override the backup and restore functionality that was implemented in the SQL server database provider.

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
                      customBackupType="MyDatabase.MyManager, MyDatabase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f0e1d2c3b4a59687"
                      backupPath="C:\backups" />
                </provider>
             </DBProviders>
          </dbManager>
          </management>
    </system.webServer>


#### Notes for Implementers

If your provider implements the IDbCustomBackupRestoreManager interface, your provider must also implement all of the following abstract members:

  - [ListBackups](idbcustombackuprestoremanager-listbackups-method-microsoft-web-management-databasemanager.md)

  - [CreateBackup](idbbackupmanager-createbackup-method-microsoft-web-management-databasemanager.md)

  - [RestoreBackup](idbrestoremanager-restorebackup-method-microsoft-web-management-databasemanager.md)

## See Also

#### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

