---
title: DatabaseProvider.GetDatabaseInfo Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: GetDatabaseInfo Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.DatabaseProvider.GetDatabaseInfo(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.databaseprovider.getdatabaseinfo(v=VS.90)
ms:contentKeyID: 22049471
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.GetDatabaseInfo
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.GetDatabaseInfo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DatabaseProvider.GetDatabaseInfo Method

Returns database-specific information for the database provider.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Public MustOverride Function GetDatabaseInfo ( _
    connectionString As String _
) As DatabaseInfo
'Usage
Dim instance As DatabaseProvider
Dim connectionString As String
Dim returnValue As DatabaseInfo

returnValue = instance.GetDatabaseInfo(connectionString)
```

``` csharp
public abstract DatabaseInfo GetDatabaseInfo(
    string connectionString
)
```

``` c++
public:
virtual DatabaseInfo^ GetDatabaseInfo(
    String^ connectionString
) abstract
```

``` jscript
public abstract function GetDatabaseInfo(
    connectionString : String
) : DatabaseInfo
```

#### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The connection string for the database connection.  

#### Return Value

Type: [Microsoft.Web.Management.DatabaseManager.DatabaseInfo](databaseinfo-class-microsoft-web-management-databasemanager.md)  
A [DatabaseInfo](databaseinfo-class-microsoft-web-management-databasemanager.md) object.  

## Remarks

Your provider must implement the GetDatabaseInfo method in order to return connection-specific information about a database.

## Examples

The following code sample illustrates an example GetDatabaseInfo method that returns a [DatabaseInfo](databaseinfo-class-microsoft-web-management-databasemanager.md) object that identifies the database provider for schema support.

``` vb

    Public Overrides Function GetDatabaseInfo( _
            ByVal connectionString As String) _
            As Microsoft.Web.Management.DatabaseManager.DatabaseInfo

        Dim info As DatabaseInfo = New DatabaseInfo
        info.SupportsSchemas = True
        Return info

    End Function

```

``` csharp

        public override DatabaseInfo GetDatabaseInfo(
            string connectionString )
        {
            DatabaseInfo info = new DatabaseInfo();
            info.SupportsSchemas = true;
            return info;
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DatabaseProvider Class](databaseprovider-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

