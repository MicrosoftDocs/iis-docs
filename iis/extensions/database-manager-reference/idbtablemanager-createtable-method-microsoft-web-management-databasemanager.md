---
title: IDbTableManager.CreateTable Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: CreateTable Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbTableManager.CreateTable(System.String,System.String,Microsoft.Web.Management.DatabaseManager.TableInfo)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.idbtablemanager.createtable(v=VS.90)
ms:contentKeyID: 20476815
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbTableManager.CreateTable
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbTableManager.CreateTable
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IDbTableManager.CreateTable Method

Creates a table in a database.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Sub CreateTable ( _
    connectionString As String, _
    schema As String, _
    tableInfo As TableInfo _
)
'Usage
Dim instance As IDbTableManager
Dim connectionString As String
Dim schema As String
Dim tableInfo As TableInfo

instance.CreateTable(connectionString, _
    schema, tableInfo)
```

```csharp
void CreateTable(
    string connectionString,
    string schema,
    TableInfo tableInfo
)
```

```cpp
void CreateTable(
    String^ connectionString, 
    String^ schema, 
    TableInfo^ tableInfo
)
```

```jscript
function CreateTable(
    connectionString : String, 
    schema : String, 
    tableInfo : TableInfo
)
```

### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The connection string for the database.  

<!-- end list -->

  - schema  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The schema name for the table.  
    **Note**    If schema is empty, the default schema name will be used.  

<!-- end list -->

  - tableInfo  
    Type: [Microsoft.Web.Management.DatabaseManager.TableInfo](tableinfo-class-microsoft-web-management-databasemanager.md)  
    A [TableInfo](tableinfo-class-microsoft-web-management-databasemanager.md) object that contains the list of information about the table and columns.  

## Remarks

All database providers that implement the [IDbTableManager](idbtablemanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the CreateTable method, which the database manager will use to create tables in a database.

### 

### Notes for Implementers

If your provider does not support adding tables, you can use the following code sample to raise a not-implemented exception:

    public void CreateTable(string connectionString, string schema, TableInfo tableInfo)
    {
       throw new NotImplementedException();
    }


> [!NOTE]  
> See the [CREATE TABLE (Transact-SQL)](http://msdn.microsoft.com/en-us/library/ms174979.aspx) topic for more information about the CREATE TABLE SQL statement.


## Examples

The following code sample implements the CreateTable method for an OLEDB connection by using the TableInfo object that the database manager provides.


> [!NOTE]  
> This example also provides helper methods that perform additional database tasks.


```vb

    Public Sub CreateTable( _
            ByVal connectionString As String, _
            ByVal schema As String, _
            ByVal tableInfo As TableInfo) _
            Implements Microsoft.Web.Management.DatabaseManager.IDbTableManager.CreateTable

        ' Create a connection to the database.
        Dim connection As OleDbConnection = New OleDbConnection(connectionString)
        ' Create a new string builder for the SQL statement.
        Dim createTableText As StringBuilder = New StringBuilder
        Try
            ' Begin the SQL statement.
            createTableText.Append("CREATE TABLE ")
            ' Append the table name to the SQL statement.
            createTableText.Append(EscapeName(tableInfo.Name))
            ' Begin the list of columns.
            createTableText.Append(" (")
            For Each column As Column In tableInfo.Columns
                ' Append a column name to the SQL statement.
                createTableText.Append(EscapeName(column.Name))
                createTableText.Append(" ")
                ' Append a column type to the SQL statement.
                createTableText.Append(column.TypeInfo)
                ' Test if the column type allows nulls.
                If (column.AllowNulls) Then
                    createTableText.Append(" NULL, ")
                Else
                    createTableText.Append(" NOT NULL, ")
                End If
            Next
            createTableText.Remove((createTableText.Length - 2), 2)
            ' End the list of columns.
            createTableText.Append(")")
            ' Create an OLEDB command object.
            Dim command As OleDbCommand = New OleDbCommand(createTableText.ToString, connection)
            ' Open the connection to the database.
            connection.Open()
            ' Run the SQL statement.
            command.ExecuteNonQuery()
        Catch ex As Exception
            ' Raise an exception if an error occurs.
            Throw New ProviderException(("CREATE TABLE Exception:" + vbLf + vbLf + ex.Message))
        End Try

    End Sub



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

        // Create a table in the database.
        public void CreateTable(
            string connectionString,
            string schema,
            TableInfo tableInfo )
        {
            // Create a connection to the database.
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Create a new string builder for the SQL statement.
                StringBuilder createTableText = new StringBuilder();
                try
                {
                    // Begin the SQL statement.
                    createTableText.Append("CREATE TABLE ");
                    // Append the table name to the SQL statement.
                    createTableText.Append(EscapeName(tableInfo.Name));
                    // Begin the list of columns.
                    createTableText.Append(" (");
                    foreach (Column column in tableInfo.Columns)
                    {
                        // Append a column name to the SQL statement.
                        createTableText.Append(EscapeName(column.Name));
                        createTableText.Append(" ");
                        // Append a column type to the SQL statement.
                        createTableText.Append(column.TypeInfo);
                        // Test if the column type allows nulls.
                        createTableText.Append(column.AllowNulls ? " NOT NULL, " : " NULL, ");
                    }
                    createTableText.Remove(createTableText.Length - 2, 2);
                    // End the list of columns.
                    createTableText.Append(")");
                    // Create an OLEDB command object.
                    using (OleDbCommand command = new OleDbCommand(createTableText.ToString(), connection))
                    {
                        // Open the connection to the database.
                        connection.Open();
                        // Run the SQL statement.
                        command.ExecuteNonQuery();
                    }
                }
                catch(Exception ex)
                {
                    // Raise an exception if an error occurs.
                    throw new ProviderException("CREATE TABLE Exception:\n\n" + ex.Message);
                }
            }
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

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[IDbTableManager Interface](idbtablemanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

