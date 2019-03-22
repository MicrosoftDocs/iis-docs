---
title: DatabaseProvider.TestConnection Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: TestConnection Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.DatabaseProvider.TestConnection(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.databaseprovider.testconnection(v=VS.90)
ms:contentKeyID: 20476646
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.TestConnection
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.TestConnection
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DatabaseProvider.TestConnection Method

Tests a connection string for a database provider.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public MustOverride Sub TestConnection ( _
    connectionString As String _
)
'Usage
Dim instance As DatabaseProvider
Dim connectionString As String

instance.TestConnection(connectionString)
```

```csharp
public abstract void TestConnection(
    string connectionString
)
```

```cpp
public:
virtual void TestConnection(
    String^ connectionString
) abstract
```

```jscript
public abstract function TestConnection(
    connectionString : String
)
```

### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The connection string to test.  

## Remarks

Your provider must implement the TestConnection method in order to test the database connection for your provider.

## Examples

The following code sample illustrates an example TestConnection method that opens and closes a database that will test the connection.

```vb

    Public Overrides Sub TestConnection(ByVal connectionString As String)

        Dim connection As OleDbConnection = New OleDbConnection(connectionString)
        connection.Open()
        connection.Close()

    End Sub

```

```csharp

        public override void TestConnection(
            string connectionString )
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                connection.Close();
            }
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[DatabaseProvider Class](databaseprovider-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

