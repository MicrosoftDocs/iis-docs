---
title: IDbCustomBackupRestoreManager.ListBackups Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: ListBackups Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbCustomBackupRestoreManager.ListBackups(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.idbcustombackuprestoremanager.listbackups(v=VS.90)
ms:contentKeyID: 22049499
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbCustomBackupRestoreManager.ListBackups
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbCustomBackupRestoreManager.ListBackups
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IDbCustomBackupRestoreManager.ListBackups Method

Retrieves a list of database backup names for a custom backup and restore module.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Function ListBackups ( _
    connectionString As String _
) As ICollection(Of String)
'Usage
Dim instance As IDbCustomBackupRestoreManager
Dim connectionString As String
Dim returnValue As ICollection(Of String)

returnValue = instance.ListBackups(connectionString)
```

``` csharp
ICollection<string> ListBackups(
    string connectionString
)
```

``` c++
ICollection<String^>^ ListBackups(
    String^ connectionString
)
```

``` jscript
function ListBackups(
    connectionString : String
) : ICollection<String>
```

#### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The connection string for the database.  

#### Return Value

Type: [System.Collections.Generic.ICollection](https://msdn.microsoft.com/en-us/library/92t2ye13\(v=vs.90\))\<[String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))\>  
An ICollection object that contains the collection of database backup names.  

## Remarks

All database providers that implement the [IDbCustomBackupRestoreManager](idbcustombackuprestoremanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the ListBackups method, which the database manager will use to retrieve a list of database backups for a custom backup and restore module.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[IDbCustomBackupRestoreManager Interface](idbcustombackuprestoremanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

