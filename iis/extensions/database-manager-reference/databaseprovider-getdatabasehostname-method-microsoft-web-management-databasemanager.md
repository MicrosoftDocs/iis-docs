---
title: DatabaseProvider.GetDatabaseHostName Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: GetDatabaseHostName Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.DatabaseProvider.GetDatabaseHostName(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.databaseprovider.getdatabasehostname(v=VS.90)
ms:contentKeyID: 22049502
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.GetDatabaseHostName
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.GetDatabaseHostName
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DatabaseProvider.GetDatabaseHostName Method

Returns the host name of the computer where the database in the connection string is located.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public MustOverride Function GetDatabaseHostName ( _
    connectionString As String _
) As String
'Usage
Dim instance As DatabaseProvider
Dim connectionString As String
Dim returnValue As String

returnValue = instance.GetDatabaseHostName(connectionString)
```

```csharp
public abstract string GetDatabaseHostName(
    string connectionString
)
```

```cpp
public:
virtual String^ GetDatabaseHostName(
    String^ connectionString
) abstract
```

```jscript
public abstract function GetDatabaseHostName(
    connectionString : String
) : String
```

### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The connection string for the database connection.  

### Return Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A string that contains the host name for the computer where the database is located.  

## Remarks

Your provider must implement the GetDatabaseHostName method in order to return the host name of the computer that is hosting the database for your provider.

## Examples

The following code sample illustrates an example GetDatabaseHostName method that returns the host name of the database.

```vb

    Public Overrides Function GetDatabaseHostName( _
            ByVal connectionString As String) As String

        Return System.Environment.MachineName

    End Function

```

```csharp

        // Retrieve the hostname for the database server.
        public override string GetDatabaseHostName( string connectionString )
        {
            // Return the computer name.
            return System.Environment.MachineName;
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[DatabaseProvider Class](databaseprovider-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

