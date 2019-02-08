---
title: IDbRestoreManager.RestoreBackup Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: RestoreBackup Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbRestoreManager.RestoreBackup(System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.idbrestoremanager.restorebackup(v=VS.90)
ms:contentKeyID: 22049498
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbRestoreManager.RestoreBackup
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbRestoreManager.RestoreBackup
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IDbRestoreManager.RestoreBackup Method

Restores a database backup.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Sub RestoreBackup ( _
    connectionString As String, _
    backupPath As String _
)
'Usage
Dim instance As IDbRestoreManager
Dim connectionString As String
Dim backupPath As String

instance.RestoreBackup(connectionString, _
    backupPath)
```

``` csharp
void RestoreBackup(
    string connectionString,
    string backupPath
)
```

``` c++
void RestoreBackup(
    String^ connectionString, 
    String^ backupPath
)
```

``` jscript
function RestoreBackup(
    connectionString : String, 
    backupPath : String
)
```

#### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The connection string for the database.  

<!-- end list -->

  - backupPath  
    Type: [System.String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The path of the backup to restore.  

## Remarks

All implementations of the [IDbRestoreManager](idbrestoremanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the RestoreBackup method. The database manager will use this method to restore database backups.

## Examples

The following code sample implements the RestoreBackup method for an OLEDB connection by using the connection string and backup path that the database manager provides.

``` vb

    ' Restore a database backup.
    Public Sub RestoreBackup( _
            ByVal connectionString As String, _
            ByVal backupPath As String) _
            Implements Microsoft.Web.Management.DatabaseManager.IDbRestoreManager.RestoreBackup

        ' Create a connection to the database.
        Dim connection As OleDbConnection = New OleDbConnection(connectionString)
        Try
            ' Verify that the backup path exists.
            If File.Exists(backupPath) Then
                ' Copy the backup path over the database file.
                File.Copy(backupPath, connection.DataSource, True)
            Else
                ' Raise an exception that the database backup cannot be found.
                Throw New ArgumentException("The database backup path does not exist.")
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

``` csharp

        // Restore a database backup.
        public void RestoreBackup(string connectionString, string backupPath)
        {
            // Create a connection to the database.
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    // Verify that the backup path exists.
                    if (File.Exists(backupPath))
                    {
                        // Copy the backup path over the database file.
                        File.Copy(backupPath, connection.DataSource, true);
                    }
                    else
                    {
                        // Raise an exception that the database backup cannot be found.
                        throw new ArgumentException("The database backup path does not exist.");
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

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[IDbRestoreManager Interface](idbrestoremanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

