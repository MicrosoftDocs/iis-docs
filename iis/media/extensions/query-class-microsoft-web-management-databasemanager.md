---
title: Query Class (Microsoft.Web.Management.DatabaseManager)
TOCTitle: Query Class
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.Query
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.query(v=VS.90)
ms:contentKeyID: 22049496
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.Query
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.Query
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Query Class

Represents a database query.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Management.DatabaseManager.Query  

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Public Class Query
'Usage
Dim instance As Query
```

``` csharp
public class Query
```

``` c++
public ref class Query
```

``` jscript
public class Query
```

The Query type exposes the following members.

## Constructors

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="query-constructor-microsoft-web-management-databasemanager.md">Query</a></td>
<td>Creates a new instance of the Query class.</td>
</tr>
</tbody>
</table>


Top

## Properties

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="query-allowedit-property-microsoft-web-management-databasemanager.md">AllowEdit</a></td>
<td>Gets or sets a value that specifies whether editing the query is allowed.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="query-statement-property-microsoft-web-management-databasemanager.md">Statement</a></td>
<td>Gets or sets the SQL statement for a query.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="query-tag-property-microsoft-web-management-databasemanager.md">Tag</a></td>
<td>Returns a generic object that is stored in the Query class.</td>
</tr>
</tbody>
</table>


Top

## Methods

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
</tbody>
</table>


Top

## Remarks

The Query class represents a query as an object for working with a database. In the most basic implementation, a query would consist of a SQL statement that is contained in the [Statement](query-statement-property-microsoft-web-management-databasemanager.md) property.

## Examples

The following code sample illustrates an example [ExecuteQuery](databaseprovider-executequery-method-microsoft-web-management-databasemanager.md) method that returns an array of query results from a database query.

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

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

