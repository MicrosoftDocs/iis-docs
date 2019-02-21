---
title: QueryColumnMetadata Class (Microsoft.Web.Management.DatabaseManager)
TOCTitle: QueryColumnMetadata Class
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.QueryColumnMetadata
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.querycolumnmetadata(v=VS.90)
ms:contentKeyID: 20476596
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.QueryColumnMetadata
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.QueryColumnMetadata
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# QueryColumnMetadata Class

Represents the metadata for a column within a query result.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Management.DatabaseManager.QueryColumnMetadata  

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Class QueryColumnMetadata
'Usage
Dim instance As QueryColumnMetadata
```

```csharp
public class QueryColumnMetadata
```

```cpp
public ref class QueryColumnMetadata
```

```jscript
public class QueryColumnMetadata
```

The QueryColumnMetadata type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[QueryColumnMetadata](querycolumnmetadata-constructor-microsoft-web-management-databasemanager.md)|Creates a new instance of the QueryColumnMetadata class.|

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[ColumnWidth](querycolumnmetadata-columnwidth-property-microsoft-web-management-databasemanager.md)|Gets or sets the column width for the column metadata within a query result.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[IsComputed](querycolumnmetadata-iscomputed-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the column data is computed within a query result.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[IsNullable](querycolumnmetadata-isnullable-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the column data supports nulla null reference (Nothing in Visual Basic) within a query result.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Name](querycolumnmetadata-name-property-microsoft-web-management-databasemanager.md)|Gets or sets the column name for the column metadata within a query result.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Tag](querycolumnmetadata-tag-property-microsoft-web-management-databasemanager.md)|Returns a generic object that is stored in the QueryColumnMetadata class.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[TypeInfo](querycolumnmetadata-typeinfo-property-microsoft-web-management-databasemanager.md)|Retrieves the type information for the query column's metadata.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Remarks

When your database provider retrieves table data using the [GetData](idbtabledatamanager-getdata-method-microsoft-web-management-databasemanager.md) method, your provider must specify the column metadata for your table's data before the database manager can query the information.

## Examples

The following code sample implements the [GetData](idbtabledatamanager-getdata-method-microsoft-web-management-databasemanager.md) method that is used to retrieve the data in a database table from an OLEDB data source.


> [!NOTE]  
> This example also provides helper methods that perform additional database tasks.


```vb

    ' Retrieve data from a database.
    Public Function GetData( _
            ByVal connectionString As String, _
            ByVal tableName As String, _
            ByVal schema As String) _
            As Microsoft.Web.Management.DatabaseManager.QueryResult _
            Implements Microsoft.Web.Management.DatabaseManager.IDbTableDataManager.GetData

        ' Create a new query result object.
        Dim queryResult As QueryResult = New QueryResult
        ' Create a connection to the database.
        Dim connection As OleDbConnection = New OleDbConnection(connectionString)
        ' Open the database connection.
        connection.Open()

        Dim columns As List(Of Column) = New List(Of Column)
        GetColumns(connection, tableName, schema, columns)
        Dim metadata As IList(Of QueryColumnMetadata) = New List(Of QueryColumnMetadata)

        For Each c As Column In columns
            Dim m As QueryColumnMetadata = New QueryColumnMetadata
            m.Name = c.Name
            m.ColumnWidth = c.Length
            m.IsNullable = c.AllowNulls
            m.TypeInfo = c.TypeInfo
            metadata.Add(m)
        Next

        Dim fields As StringBuilder = New StringBuilder

        If (metadata.Count = 0) Then
            ' When the table is not found, adding an asterix returns an error message.
            fields.Append("*")
        Else
            Dim fieldCount As Integer = metadata.Count
            Dim isFirst As Boolean = True
            Dim i As Integer = 0
            For i = 0 To (fieldCount - 1)
                Dim m As QueryColumnMetadata = metadata(i)
                If (isFirst = False) Then
                    fields.Append(",")
                End If
                isFirst = False
                fields.Append(EscapeName(m.Name))
                queryResult.ColumnMetadata.Add(m)
            Next
        End If

        ' Create a new query object.
        Dim query As Query = New Query
        ' Create a SQL query statement.
        query.Statement = "SELECT " + fields.ToString + " FROM " + EscapeName(tableName)
        ' retrieve the query results.
        Dim results() As QueryResult = ExecuteQuery(connectionString, query)
        ' Add the query results to the list.
        queryResult.QueryResults.AddRange(results(0).QueryResults)

        ' Return the query result.
        Return queryResult

    End Function



...



    Friend Shared Function EscapeName(ByVal name As String) As String
        ' Test if the value is already escaped.
        If (name.StartsWith("[", StringComparison.Ordinal) AndAlso name.EndsWith("]", StringComparison.Ordinal)) Then
            ' Return the string with no changes.
            Return name
        End If
        ' Create a new string builder for the escaped string.
        Dim escapedName As StringBuilder = New StringBuilder
        ' Prepend the string with an opening bracket.
        escapedName.Append(Microsoft.VisualBasic.ChrW(91))
        ' Loop through the string.
        Dim i As Integer = 0
        Do While (i < name.Length)
            Dim c As Char = name(i)
            If (c = Microsoft.VisualBasic.ChrW(93)) Then
                escapedName.Append(Microsoft.VisualBasic.ChrW(93))
            End If
            escapedName.Append(c)
            i = (i + 1)
        Loop
        ' Append the string with an opening bracket.
        escapedName.Append(Microsoft.VisualBasic.ChrW(93))
        ' Return the escaped string.
        Return escapedName.ToString
    End Function

```

```csharp

        // Retrieve data from a database.
        public QueryResult GetData(string connectionString, string tableName, string schema)
        {
            // Create a new query result object.
            QueryResult queryResult = new QueryResult();

            // Create a connection to the database.
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Open the database connection.
                connection.Open();

                List<Column> columns = new List<Column>();
                GetColumns(connection, tableName, schema, columns);
                IList<QueryColumnMetadata> metadata = new List<QueryColumnMetadata>();

                foreach (Column c in columns)
                {
                    QueryColumnMetadata m = new QueryColumnMetadata();
                    m.Name = c.Name;
                    m.ColumnWidth = c.Length;
                    m.IsNullable = c.AllowNulls;
                    m.TypeInfo = c.TypeInfo;
                    metadata.Add(m);
                }

                StringBuilder fields = new StringBuilder();

                if (metadata.Count == 0)
                {
                    // When the table is not found, adding an asterix returns an error message.
                    fields.Append("*");
                }
                else
                {
                    int fieldCount = metadata.Count;

                    bool isFirst = true;
                    for (int i = 0; i < fieldCount; i++)
                    {
                        QueryColumnMetadata m = metadata[i];
                        if (isFirst == false)
                        {
                            fields.Append(',');
                        }
                        isFirst = false;
                        fields.Append(EscapeName(m.Name));
                        queryResult.ColumnMetadata.Add(m);
                    }
                }

                // Create a new query object.
                Query query = new Query();

                // Create a SQL query statement.
                query.Statement = "SELECT " + fields.ToString() + " FROM " + EscapeName(tableName);

                // retrieve the query results.
                QueryResult[] results = ExecuteQuery(connectionString, query);

                // Add the query results to the list.
                queryResult.QueryResults.AddRange(results[0].QueryResults);
            }

            // Return the query result.
            return queryResult;
        }



...



        internal static string EscapeName(string name)
        {
            // Test if the value is already escaped.
            if (name.StartsWith("[", StringComparison.Ordinal) && name.EndsWith("]", StringComparison.Ordinal))
            {
                // Return the string with no changes.
                return name;
            }
            // Create a new string builder for the escaped string.
            StringBuilder escapedName = new StringBuilder();
            // Prepend the string with an opening bracket.
            escapedName.Append('[');
            // Loop through the string.
            for (int i = 0; i < name.Length; i++)
            {
                char c = name[i];
                if (c == ']')
                {
                    escapedName.Append(']');
                }
                escapedName.Append(c);
            }
            // Append the string with an opening bracket.
            escapedName.Append(']');
            // Return the escaped string.
            return escapedName.ToString();
        }

```

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

