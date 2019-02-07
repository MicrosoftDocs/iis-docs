---
title: DatabaseProvider.ExecuteQuery Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: ExecuteQuery Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.DatabaseProvider.ExecuteQuery(System.String,Microsoft.Web.Management.DatabaseManager.Query)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.databaseprovider.executequery(v=VS.90)
ms:contentKeyID: 22049611
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.ExecuteQuery
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.ExecuteQuery
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DatabaseProvider.ExecuteQuery Method

Returns an array of query results after executing a database query.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Public MustOverride Function ExecuteQuery ( _
    connectionString As String, _
    query As Query _
) As QueryResult()
'Usage
Dim instance As DatabaseProvider
Dim connectionString As String
Dim query As Query
Dim returnValue As QueryResult()

returnValue = instance.ExecuteQuery(connectionString, _
    query)
```

``` csharp
public abstract QueryResult[] ExecuteQuery(
    string connectionString,
    Query query
)
```

``` c++
public:
virtual array<QueryResult^>^ ExecuteQuery(
    String^ connectionString, 
    Query^ query
) abstract
```

``` jscript
public abstract function ExecuteQuery(
    connectionString : String, 
    query : Query
) : QueryResult[]
```

#### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The connection string for the database connection.  

<!-- end list -->

  - query  
    Type: [Microsoft.Web.Management.DatabaseManager.Query](query-class-microsoft-web-management-databasemanager.md)  
    The [Query](query-class-microsoft-web-management-databasemanager.md) object that contains the query statement to execute.  

#### Return Value

Type: array\<[Microsoft.Web.Management.DatabaseManager.QueryResult](queryresult-class-microsoft-web-management-databasemanager.md)\[\]  
An array of [QueryResult](queryresult-class-microsoft-web-management-databasemanager.md) objects.  

## Remarks

Your provider must implement the ExecuteQuery method in order to submit database queries for your provider.

## Examples

The following code sample illustrates an example ExecuteQuery method that returns an array of query results from a database query.

``` vb

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

``` csharp

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

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DatabaseProvider Class](databaseprovider-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

