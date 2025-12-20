---
title: QueryResult Class (Microsoft.Web.Management.DatabaseManager)
TOCTitle: QueryResult Class
description: "The QueryResult class represents a query result that was returned from a database query. This article describes its syntax, constructors, properties, and methods."
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.QueryResult
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.queryresult(v=VS.90)
ms:contentKeyID: 20476472
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.QueryResult
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.QueryResult
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
ms.custom: sfi-ropc-nochange
---

# QueryResult Class

Represents a query result that was returned from a database query.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Management.DatabaseManager.QueryResult  

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Class QueryResult
'Usage
Dim instance As QueryResult
```

```csharp
public class QueryResult
```

```cpp
public ref class QueryResult
```

```jscript
public class QueryResult
```

The QueryResult type exposes the following members.

## Constructors

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[QueryResult](queryresult-constructor-microsoft-web-management-databasemanager.md)|Creates a new instance of the QueryResult class.|

## Properties

|Property Type|Name|Description|
|--- |--- |--- |
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[ColumnMetadata](queryresult-columnmetadata-property-microsoft-web-management-databasemanager.md)|Returns a list of column metadata for a query result.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[QueryResults](queryresult-queryresults-property-microsoft-web-management-databasemanager.md)|Retrieves an array of query results.|

## Methods

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

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

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
