---
title: DatabaseInfo.SupportsSchemas Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: SupportsSchemas Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.DatabaseInfo.SupportsSchemas
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.databaseinfo.supportsschemas(v=VS.90)
ms:contentKeyID: 22049504
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.DatabaseInfo.SupportsSchemas
- Microsoft.Web.Management.DatabaseManager.DatabaseInfo.get_SupportsSchemas
- Microsoft.Web.Management.DatabaseManager.DatabaseInfo.set_SupportsSchemas
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.DatabaseInfo.get_SupportsSchemas
- Microsoft.Web.Management.DatabaseManager.DatabaseInfo.SupportsSchemas
- Microsoft.Web.Management.DatabaseManager.DatabaseInfo.set_SupportsSchemas
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# DatabaseInfo.SupportsSchemas Property

Specifies whether the database supports schemas.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property SupportsSchemas As Boolean
'Usage
Dim instance As DatabaseInfo
Dim value As Boolean

value = instance.SupportsSchemas

instance.SupportsSchemas = value
```

```csharp
public bool SupportsSchemas { get; set; }
```

```cpp
public:
property bool SupportsSchemas {
    bool get ();
    void set (bool value);
}
```

```jscript
function get SupportsSchemas () : boolean
function set SupportsSchemas (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the database supports schemas; otherwise, false.  

## Remarks

Your provider must implement the [GetDatabaseInfo](databaseprovider-getdatabaseinfo-method-microsoft-web-management-databasemanager.md) method to return a [DatabaseInfo](databaseinfo-class-microsoft-web-management-databasemanager.md) object for your provider. This object should indicate whether your database supports schemas.


> [!NOTE]  
> The schema support for a provider varies greatly between database servers; you must consult the documentation for your database server in order to determine schema support for your provider.


## Examples

The following code sample illustrates a sample [GetDatabaseInfo](databaseprovider-getdatabaseinfo-method-microsoft-web-management-databasemanager.md) method that returns a [DatabaseInfo](databaseinfo-class-microsoft-web-management-databasemanager.md) object that identifies the database provider for schema support.

```vb

    Public Overrides Function GetDatabaseInfo( _
            ByVal connectionString As String) _
            As Microsoft.Web.Management.DatabaseManager.DatabaseInfo

        Dim info As DatabaseInfo = New DatabaseInfo
        info.SupportsSchemas = True
        Return info

    End Function

```

```csharp

        public override DatabaseInfo GetDatabaseInfo(
            string connectionString )
        {
            DatabaseInfo info = new DatabaseInfo();
            info.SupportsSchemas = true;
            return info;
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[DatabaseInfo Class](databaseinfo-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

