---
title: IDbBackupManager.CreateBackup Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: CreateBackup Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbBackupManager.CreateBackup(System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.idbbackupmanager.createbackup(v=VS.90)
ms:contentKeyID: 22049620
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbBackupManager.CreateBackup
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbBackupManager.CreateBackup
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IDbBackupManager.CreateBackup Method

Creates a database backup.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Sub CreateBackup ( _
    connectionString As String, _
    backupPath As String _
)
'Usage
Dim instance As IDbBackupManager
Dim connectionString As String
Dim backupPath As String

instance.CreateBackup(connectionString, _
    backupPath)
```

```csharp
void CreateBackup(
    string connectionString,
    string backupPath
)
```

```cpp
void CreateBackup(
    String^ connectionString, 
    String^ backupPath
)
```

```jscript
function CreateBackup(
    connectionString : String, 
    backupPath : String
)
```

### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The connection string for the database.  

<!-- end list -->

  - backupPath  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The path of the backup to create.  

## Remarks

All implementations of the [IDbBackupManager](idbbackupmanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the CreateBackup method, which the database manager will use to create database backups.

## Examples

The following code sample implements the CreateBackup method for an OLEDB connection that uses the connection string and backup path that the database manager provides.

```vb

    ' Create a database backup.
    Public Sub CreateBackup( _
            ByVal connectionString As String, _
            ByVal backupPath As String) _
            Implements Microsoft.Web.Management.DatabaseManager.IDbBackupManager.CreateBackup

        ' Create a connection to the database.
        Dim connection As OleDbConnection = New OleDbConnection(connectionString)
        Try
            ' Verify that the source database path is not the same as the backup path.
            If connection.DataSource.Equals(backupPath, StringComparison.OrdinalIgnoreCase) Then
                ' Raise an exception that the database file paths cannot match.
                Throw New ArgumentException("The database backup path cannot match the source path.")
            Else
                ' Copy the database file to the backup path.
                File.Copy(connection.DataSource, backupPath, True)
            End If
        Catch ex As Exception
            ' Raise an exception if an error occurs.
            Throw New ProviderException(ex.Message)
        Finally
            ' Close the database connection.
            connection.Close()
        End Try

    End Sub

```

```csharp

        // Create a database backup.
        public void CreateBackup(string connectionString, string backupPath)
        {
            // Create a connection to the database.
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    // Verify that the source database path is not the same as the backup path.
                    if (connection.DataSource.Equals(backupPath, StringComparison.OrdinalIgnoreCase))
                    {
                        // Raise an exception that the database file paths cannot match.
                        throw new ArgumentException("The database backup path cannot match the source path.");
                    }
                    else
                    {
                        // Copy the database file to the backup path.
                        File.Copy(connection.DataSource, backupPath, true);
                    }
                }
                catch (Exception ex)
                {
                    // Raise an exception if an error occurs.
                    throw new ProviderException(ex.Message);
                }
                finally
                {
                    // Close the database connection.
                    connection.Close();
                }
            }
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[IDbBackupManager Interface](idbbackupmanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

