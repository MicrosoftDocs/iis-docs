---
title: Query.Statement Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: Statement Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.Query.Statement
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.query.statement(v=VS.90)
ms:contentKeyID: 22049486
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.Query.Statement
- Microsoft.Web.Management.DatabaseManager.Query.get_Statement
- Microsoft.Web.Management.DatabaseManager.Query.set_Statement
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.Query.get_Statement
- Microsoft.Web.Management.DatabaseManager.Query.Statement
- Microsoft.Web.Management.DatabaseManager.Query.set_Statement
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Query.Statement Property

Gets or sets the SQL statement for a query.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property Statement As String
'Usage
Dim instance As Query
Dim value As String

value = instance.Statement

instance.Statement = value
```

```csharp
public string Statement { get; set; }
```

```cpp
public:
property String^ Statement {
    String^ get ();
    void set (String^ value);
}
```

```jscript
function get Statement () : String
function set Statement (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The string that contains the SQL statement for a query.  

## Remarks

The Statement property contains the SQL syntax for the [Query](query-class-microsoft-web-management-databasemanager.md) class.

> [!NOTE]  
> For information about the SQL syntax that is available for the Statement property, see the [Transact-SQL Reference](https://msdn.microsoft.com/library/bb510741.aspx) topic on the Microsoft MSDN Web site.

## Examples

The following code sample illustrates an example [ExecuteQuery](databaseprovider-executequery-method-microsoft-web-management-databasemanager.md) method that returns an array of query results from a database query.

```vb

    Public Overrides Function ExecuteQuery( _
            ByVal connectionString As String, _
            ByVal query As Microsoft.Web.Management.DatabaseManager.Query) _
            As Microsoft.Web.Management.DatabaseManager.QueryResult()

        Dim results As List(Of QueryResult) = New List(Of QueryResult)
        Dim result As QueryResult = New QueryResult
        Try
            ' Create a new OLEDB connection using the connection string.
            Dim connection As OleDbConnection = New OleDbConnection(connectionString)
            Dim command As OleDbCommand = New OleDbCommand(query.Statement, connection)
            ' Open the database connection.
            connection.Open()
            ' Execute the query and access the data.
            Dim reader As OleDbDataReader = command.ExecuteReader
            ' Add the results to the query list.
            results.Add(GetQueryResult(reader))
            ' Close the database connection.
            reader.Close()
            ' Return the query results.
            Return results.ToArray
        Catch ex As Exception
            Throw New ProviderException(ex.Message)
        End Try

    End Function



...



    Private Function GetQueryResult(ByVal reader As OleDbDataReader) As QueryResult
        Dim result As QueryResult = New QueryResult
        Dim fieldCount As Integer = reader.FieldCount
        Dim i As Integer = 0
        Do While (i < fieldCount)
            Dim metadata As QueryColumnMetadata = New QueryColumnMetadata
            metadata.Name = reader.GetName(i)
            result.ColumnMetadata.Add(metadata)
            i = (i + 1)
        Loop

        While reader.Read
            Dim itemData() As Object = New Object((fieldCount) - 1) {}
            i = 0
            Do While (i < fieldCount)
                itemData(i) = ConvertToSerializable(reader(i))
                i = (i + 1)
            Loop
            result.QueryResults.Add(itemData)

        End While
        Return result
    End Function

```

```csharp

        public override QueryResult[] ExecuteQuery(
            string connectionString,
            Query query )
        {
            List<QueryResult> results = new List<QueryResult>();
            QueryResult result = new QueryResult();
            try
            {
                // Create a new OLEDB connection using the connection string.
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    OleDbCommand command = new OleDbCommand(query.Statement, connection);
                    // Open the database connection.
                    connection.Open();
                    // Execute the query and access the data.
                    OleDbDataReader reader = command.ExecuteReader();
                    // Add the results to the query list.
                    results.Add(GetQueryResult(reader));
                    // Close the database connection.
                    reader.Close();
                }
                // Return the query results.
                return results.ToArray();
            }
            catch(Exception ex)
            {
                throw new ProviderException(ex.Message);
            }
        }



...



        private QueryResult GetQueryResult(OleDbDataReader reader)
        {
            QueryResult result = new QueryResult();
            int fieldCount = reader.FieldCount;

            for (int i = 0; i < fieldCount; i++)
            {
                QueryColumnMetadata metadata = new QueryColumnMetadata();
                metadata.Name = reader.GetName(i);
                result.ColumnMetadata.Add(metadata);
            }

            while (reader.Read())
            {
                object[] itemData = new object[fieldCount];
                for (int i = 0; i < fieldCount; i++)
                {
                    itemData[i] = ConvertToSerializable(reader[i]);
                }
                result.QueryResults.Add(itemData);
            }
            return result;
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[Query Class](query-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
