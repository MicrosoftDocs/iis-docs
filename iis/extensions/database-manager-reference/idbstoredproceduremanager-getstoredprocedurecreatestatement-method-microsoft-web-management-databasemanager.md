---
title: IDbStoredProcedureManager.GetStoredProcedureCreateStatement Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: GetStoredProcedureCreateStatement Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.GetStoredProcedureCreateStatement(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.idbstoredproceduremanager.getstoredprocedurecreatestatement(v=VS.90)
ms:contentKeyID: 20476447
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.GetStoredProcedureCreateStatement
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.GetStoredProcedureCreateStatement
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IDbStoredProcedureManager.GetStoredProcedureCreateStatement Method

Returns the CREATE PROCEDURE template for creating a new stored procedure.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Function GetStoredProcedureCreateStatement ( _
    connectionString As String _
) As Query
'Usage
Dim instance As IDbStoredProcedureManager
Dim connectionString As String
Dim returnValue As Query

returnValue = instance.GetStoredProcedureCreateStatement(connectionString)
```

```csharp
Query GetStoredProcedureCreateStatement(
    string connectionString
)
```

```cpp
Query^ GetStoredProcedureCreateStatement(
    String^ connectionString
)
```

```jscript
function GetStoredProcedureCreateStatement(
    connectionString : String
) : Query
```

### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The connection string for the database.  

### Return Value

Type: [Microsoft.Web.Management.DatabaseManager.Query](query-class-microsoft-web-management-databasemanager.md)  
A [Query](query-class-microsoft-web-management-databasemanager.md) object that contains the CREATE PROCEDURE template for a new stored procedure.  

## Remarks

All database providers that implement the [IDbStoredProcedureManager](idbstoredproceduremanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the GetStoredProcedureCreateStatement method, which returns a CREATE PROCEDURE statement for your database provider.

### 

### Notes for Implementers

If your provider does not support creating stored procedures, you can use the following code sample to raise a not-implemented exception:

public Query GetStoredProcedureCreateStatement(string connectionString)

{

   throw new NotImplementedException();

}


> [!NOTE]  
> See the [CREATE PROCEDURE (Transact-SQL)](http://msdn.microsoft.com/en-us/library/ms187926.aspx) topic for more information about the CREATE PROCEDURE SQL statement.


## Examples

The following code sample shows how to use the GetStoredProcedureCreateStatement method to return a stored procedure CREATE PROCEDURE SQL statement for your database provider.

```vb

    Public Function GetStoredProcedureCreateStatement(ByVal connectionString As String) As Microsoft.Web.Management.DatabaseManager.Query Implements Microsoft.Web.Management.DatabaseManager.IDbStoredProcedureManager.GetStoredProcedureCreateStatement
        Dim query As New Query()
        query.Statement = "CREATE PROCEDURE ProcedureName " + vbCrLf + _
            vbTab + "<@p1 int> = 0, " + vbCrLf + _
            vbTab + "<@p2 int> = 0" + vbCrLf + _
            "AS" + vbCr + vbLf + _
            "BEGIN" + vbCrLf + _
            vbTab + "SET NOCOUNT ON;" + vbCrLf + _
            vbTab + "SELECT @p1, @p2" + vbCrLf + _
            "END" + vbCrLf + _
            "GO"
        Return query
    End Function

```

```csharp

        public Query GetStoredProcedureCreateStatement(string connectionString)
        {
            Query query = new Query();
            query.Statement =
@"CREATE PROCEDURE ProcedureName 
    <@p1 int> = 0, 
    <@p2 int> = 0
AS
BEGIN
    SET NOCOUNT ON;
    SELECT @p1, @p2
END
GO";
            return query;
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[IDbStoredProcedureManager Interface](idbstoredproceduremanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

