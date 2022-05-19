---
title: Column.Length Property (Microsoft.Web.Management.DatabaseManager)
description: The code samples presented show how to get or set a value that specifies the length of the database column.
TOCTitle: Length Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.Column.Length
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.column.length(v=VS.90)
ms:contentKeyID: 20476797
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.Column.Length
- Microsoft.Web.Management.DatabaseManager.Column.get_Length
- Microsoft.Web.Management.DatabaseManager.Column.set_Length
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.Column.get_Length
- Microsoft.Web.Management.DatabaseManager.Column.Length
- Microsoft.Web.Management.DatabaseManager.Column.set_Length
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Column.Length Property

Gets or sets a value that specifies the length of the database column.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Overridable Property Length As Long
'Usage
Dim instance As Column
Dim value As Long

value = instance.Length

instance.Length = value
```

```csharp
public virtual long Length { get; set; }
```

```cpp
public:
virtual property long long Length {
    long long get ();
    void set (long long value);
}
```

```jscript
function get Length () : long
function set Length (value : long)
```

### Property Value

Type: [System.Int64](https://msdn.microsoft.com/library/6yy583ek)  
The length of the database column.  

## Examples

The following code sample shows how to use the [GetTableInfo](idbtablemanager-gettableinfo-method-microsoft-web-management-databasemanager.md) method to retrieve the table information for the table name from a database.

> [!NOTE]  
> This example also provides helper methods that perform additional database tasks.

```vb

    ' Retrieve the information about a table.
    Public Function GetTableInfo( _
            ByVal connectionString As String, _
            ByVal tableName As String, _
            ByVal schema As String) As TableInfo _
            Implements Microsoft.Web.Management.DatabaseManager.IDbTableManager.GetTableInfo

        ' Create a new TableInfo object.
        Dim info As TableInfo = New TableInfo
        ' Create a connection to the database.
        Dim connection As OleDbConnection = New OleDbConnection(connectionString)
        connection.Open()
        ' Retrieve the table name.
        info.Name = tableName
        ' Retrieve the list of table columns.
        GetColumns(connection, tableName, schema, info.Columns)
        ' Retrieve the list of the table's foreign keys.
        GetForeignKeys(connection, tableName, info.ForeignKeys)
        ' Retrieve the list of the table's indices.
        GetIndexes(connection, tableName, info.Indexes)
        ' Return the table information.
        Return info

    End Function

    ' Retrieve the list of table colums.
    Private Sub GetColumns( _
            ByVal connection As OleDbConnection, _
            ByVal tableName As String, _
            ByVal tableSchema As String, _
            ByVal columns As ICollection(Of Column))

        Dim restrictions() As String = New String() {Nothing, Nothing, tableName, Nothing}
        Dim columnSchema As DataTable
        ' Retrieve a list of primary keys for a table.
        Dim primaryKeys() As String = GetPrimaryKey(connection.ConnectionString, tableName, tableSchema)
        ' Open the schema information for the columns.
        columnSchema = connection.GetSchema(OleDbMetaDataCollectionNames.Columns, restrictions)
        ' Enumerate the table's columns.
        For Each row As DataRow In columnSchema.Rows
            ' Create a new column object.
            Dim column As Column = New Column
            ' Retrieve the column name.
            column.Name = row("COLUMN_NAME").ToString
            column.OriginalName = row("COLUMN_NAME").ToString
            ' Test if the column allows nulls.
            column.AllowNulls = CType(row("IS_NULLABLE"), Boolean)
            ' Retrieve the column type.
            column.TypeInfo = GetColumnType(connection, OleDbTypeToString(CType(Int32.Parse(row("DATA_TYPE").ToString), OleDbType)))
            ' Retrieve the column's default value.
            If DBNull.Value.Equals(row("COLUMN_DEFAULT")) Then
                column.DefaultValue = "Null"
            Else
                column.DefaultValue = row("COLUMN_DEFAULT").ToString()
            End If
            ' Retrieve the column's precision.
            If DBNull.Value.Equals(row("NUMERIC_PRECISION")) Then
                column.Precision = 0
            Else
                column.Precision = Int32.Parse(CType(row("NUMERIC_PRECISION"), String))
            End If
            ' Retrieve the column's scale.
            If DBNull.Value.Equals(row("NUMERIC_SCALE")) Then
                column.Scale = 0
            Else
                column.Scale = Int32.Parse(CType(row("NUMERIC_SCALE"), String))
            End If
            ' Specify if the column is a primary key.
            column.InPrimaryKey = primaryKeys.Contains(row("COLUMN_NAME").ToString)
            ' Specify that the column is not an identity column.
            column.IsIdentity = False
            ' Retrieve the column length.
            If CType(Int32.Parse(row("DATA_TYPE").ToString()), OleDbType) <> OleDbType.WChar Then
                column.Length = -1
            Else
                column.Length = Int32.Parse(row("CHARACTER_MAXIMUM_LENGTH").ToString())
            End If
            ' Append the column to the list.
            columns.Add(column)
        Next

    End Sub

    ' Determine the type of a column.
    Private Function GetColumnType( _
            ByVal connection As OleDbConnection, _
            ByVal columnName As String) As TypeInfo

        ' Retrieve the list of column types.
        Dim serverTypes As ICollection = GetServerTypes(connection.ConnectionString)
        ' Enumerate the columns.
        For Each type As TypeInfo In serverTypes
            ' Return the column type if it is found.
            If type.Name.Equals(columnName) Then
                Return type
            End If
        Next
        ' Raise an exception if the column type was not found.
        Throw New ArgumentException(("Unknown column type: " + columnName))

    End Function

    ' Retrieve the list of a table's indices.
    Private Sub GetIndexes( _
            ByVal connection As OleDbConnection, _
            ByVal tableName As String, _
            ByVal indices As IList(Of Index))

        Dim restrictions() As String = New String() {Nothing, Nothing, Nothing, Nothing, tableName}
        Dim schema As DataTable
        ' Open the schema information for the indices.
        schema = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Indexes, restrictions)
        ' Enumerate the table's indices.
        For Each row As DataRow In schema.Rows
            ' Create a new index.
            Dim dbIndex As Index = New Index
            ' Append the index name.
            dbIndex.Name = row("INDEX_NAME").ToString
            dbIndex.OriginalName = row("INDEX_NAME").ToString
            ' Append the index's uniqueness.
            dbIndex.Unique = CType(row("UNIQUE"), Boolean)
            ' Specify the index type.
            If (CType(row("PRIMARY_KEY"), Boolean) = True) Then
                dbIndex.IndexType = IndexType.PrimaryKey
            Else
                dbIndex.IndexType = IndexType.Index
            End If
            ' Create an index column object.
            Dim column As IndexColumn = New IndexColumn
            column.Name = row("COLUMN_NAME").ToString
            ' Specify whether the index is descending.
            If (Int32.Parse(row("COLLATION").ToString) = 2) Then
                column.Descending = True
            Else
                column.Descending = False
            End If
            dbIndex.Columns.Add(column)
            ' Append the index to the list.
            indices.Add(dbIndex)
        Next

    End Sub

    ' Retrieve the list of a table's foreign keys.
    Private Sub GetForeignKeys( _
            ByVal connection As OleDbConnection, _
            ByVal tableName As String, _
            ByVal foreignKeys As IList(Of ForeignKey))

        Dim restrictions() As String = New String() {Nothing}
        Dim schema As DataTable
        ' Open the schema information for the foreign keys.
        schema = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Foreign_Keys, restrictions)
        ' Enumerate the table's foreign keys.
        For Each row As DataRow In schema.Rows

            Dim dbForeignKey As ForeignKey = New ForeignKey
            dbForeignKey.Name = row("FK_NAME").ToString
            dbForeignKey.OriginalName = row("FK_NAME").ToString
            dbForeignKey.FKTableName = row("FK_TABLE_NAME").ToString

            Dim fkc As ForeignKeyColumn = New ForeignKeyColumn
            fkc.Name = row("FK_COLUMN_NAME").ToString
            dbForeignKey.FKColumns.Add(fkc)
            dbForeignKey.FKTableSchema = schema.ToString
            dbForeignKey.PKTableName = row("PK_TABLE_NAME").ToString

            Dim pkc As ForeignKeyColumn = New ForeignKeyColumn
            pkc.Name = row("PK_COLUMN_NAME").ToString
            dbForeignKey.PKColumns.Add(pkc)
            dbForeignKey.PKTableSchema = schema.ToString
            foreignKeys.Add(dbForeignKey)
        Next

    End Sub



...



    ' Map OLEDB data types to their respective string descriptions.
    Friend Shared Function OleDbTypeToString(ByVal type As OleDbType) As String
        Select Case (type)
            Case OleDbType.Binary
                Return "Binary"
            Case OleDbType.Boolean
                Return "Bit"
            Case OleDbType.UnsignedTinyInt
                Return "Byte"
            Case OleDbType.TinyInt
                Return "TinyInt"
            Case OleDbType.Integer
                Return "Integer"
            Case OleDbType.Currency
                Return "Currency"
            Case OleDbType.Date
                Return "DateTime"
            Case OleDbType.Double
                Return "Float"
            Case OleDbType.Guid
                Return "UniqueIdentifier"
            Case OleDbType.Char, OleDbType.WChar
                Return "Text"
            Case OleDbType.Single
                Return "Real"
            Case OleDbType.SmallInt
                Return "SmallInt"
            Case OleDbType.Numeric, OleDbType.Decimal
                Return "Decimal"
            Case Else
                Return "Unknown"
        End Select
    End Function

```

```csharp

        // Retrieve the information about a table.
        public TableInfo GetTableInfo(string connectionString, string tableName, string schema)
        {
            // Create a new TableInfo object.
            TableInfo info = new TableInfo();
            // Create a connection to the database.
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                // Retrieve the table name.
                info.Name = tableName;
                // Retrieve the list of table columns.
                GetColumns(connection, tableName, schema, info.Columns);
                // Retrieve the list of the table's foreign keys.
                GetForeignKeys(connection, tableName, info.ForeignKeys);
                // Retrieve the list of the table's indices.
                GetIndexes(connection, tableName, info.Indexes);
            }
            // Return the table information.
            return info;
        }

        // Retrieve the list of table colums.
        private void GetColumns(OleDbConnection connection, string tableName, string tableSchema, ICollection<Column> columns)
        {
            String[] restrictions = new string[] { null, null, tableName, null };
            DataTable columnSchema;

            // Retrieve a list of primary keys for a table.
            string[] primaryKeys = GetPrimaryKey(
                connection.ConnectionString, tableName, tableSchema);
            // Open the schema information for the columns.
            columnSchema = connection.GetSchema(
                OleDbMetaDataCollectionNames.Columns, restrictions);
            // Enumerate the table's columns.
            foreach (DataRow row in columnSchema.Rows)
            {
                // Create a new column object.
                Column column = new Column();
                // Retrieve the column name.
                column.Name = row["COLUMN_NAME"].ToString();
                column.OriginalName = row["COLUMN_NAME"].ToString();
                // Test if the column allows nulls.
                column.AllowNulls = (bool)row["IS_NULLABLE"];
                // Retrieve the column type.
                column.TypeInfo = GetColumnType(connection,
                    OleDbTypeToString((OleDbType)
                    Int32.Parse(row["DATA_TYPE"].ToString())));
                // Retrieve the column's default value.
                column.DefaultValue = ((row["COLUMN_DEFAULT"] as DBNull)
                    != null) ? "Null" : row["COLUMN_DEFAULT"].ToString();
                // Retrieve the column's precision.
                column.Precision = ((row["NUMERIC_PRECISION"] as DBNull)
                    != null) ? 0 : Int32.Parse(row["NUMERIC_PRECISION"].ToString());
                // Retrieve the column's scale.
                column.Scale = ((row["NUMERIC_SCALE"] as DBNull) != null) ? 0 : Int32.Parse(row["NUMERIC_SCALE"].ToString());
                // Specify if the column is a primary key.
                column.InPrimaryKey = primaryKeys.Contains(row["COLUMN_NAME"].ToString());
                // Specify that the column is not an identity column.
                column.IsIdentity = false;
                // Retrieve the column length.
                column.Length = ((OleDbType)Int32.Parse(row["DATA_TYPE"].ToString()) != OleDbType.WChar) ? -1 : Int32.Parse(row["CHARACTER_MAXIMUM_LENGTH"].ToString());
                // Append the column to the list.
                columns.Add(column);
            }
        }

        // Determine the type of a column.
        private TypeInfo GetColumnType(OleDbConnection connection, string columnName)
        {
            // Retrieve the list of column types.
            ICollection<TypeInfo> serverTypes = GetServerTypes(connection.ConnectionString);
            // Enumerate the columns.
            foreach (TypeInfo type in serverTypes)
            {
                // Return the column type if it is found.
                if (type.Name.Equals(columnName))
                {
                    return type;
                }
            }
            // Raise an exception if the column type was not found.
            throw new ArgumentException("Unknown column type: " + columnName);
        }

        // Retrieve the list of a table's indices.
        private void GetIndexes(OleDbConnection connection, string tableName, IList<Index> indices)
        {
            String[] restrictions = new string[] { null, null, null, null, tableName };
            DataTable schema;
            // Open the schema information for the indices.
            schema = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Indexes, restrictions);
            // Enumerate the table's indices.
            foreach (DataRow row in schema.Rows)
            {
                // Create a new index.
                Index dbIndex = new Index();
                // Append the index name.
                dbIndex.Name = row["INDEX_NAME"].ToString();
                dbIndex.OriginalName = row["INDEX_NAME"].ToString();
                // Append the index's uniqueness.
                dbIndex.Unique = (bool)row["UNIQUE"];
                // Specify the index type. 
                dbIndex.IndexType = (bool)row["PRIMARY_KEY"] == true ? IndexType.PrimaryKey : IndexType.Index;
                // Create an index column object.
                IndexColumn column = new IndexColumn();
                column.Name = row["COLUMN_NAME"].ToString();
                // Specify whether the index is descending.
                column.Descending = (Int32.Parse(row["COLLATION"].ToString()) == 2) ? true : false;
                dbIndex.Columns.Add(column);
                // Append the index to the list.
                indices.Add(dbIndex);
            }
        }

        // Retrieve the list of a table's foreign keys.
        private void GetForeignKeys(OleDbConnection connection, string tableName, IList<ForeignKey> foreignKeys)
        {
            String[] restrictions = new string[] { null };
            DataTable schema;
            // Open the schema information for the foreign keys.
            schema = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Foreign_Keys, restrictions);
            // Enumerate the table's foreign keys.
            foreach (DataRow row in schema.Rows)
            {
                ForeignKey dbForeignKey = new ForeignKey();
                dbForeignKey.Name = row["FK_NAME"].ToString();
                dbForeignKey.OriginalName = row["FK_NAME"].ToString();

                dbForeignKey.FKTableName = row["FK_TABLE_NAME"].ToString();
                ForeignKeyColumn fkc = new ForeignKeyColumn();
                fkc.Name = row["FK_COLUMN_NAME"].ToString();
                dbForeignKey.FKColumns.Add(fkc);
                dbForeignKey.FKTableSchema = schema.ToString();

                dbForeignKey.PKTableName = row["PK_TABLE_NAME"].ToString();
                ForeignKeyColumn pkc = new ForeignKeyColumn();
                pkc.Name = row["PK_COLUMN_NAME"].ToString();
                dbForeignKey.PKColumns.Add(pkc);
                dbForeignKey.PKTableSchema = schema.ToString();

                foreignKeys.Add(dbForeignKey);
            }
        }



...



        // Map OLEDB data types to their respective string descriptions.
        internal static string OleDbTypeToString(OleDbType type)
        {
            switch (type)
            {
                case OleDbType.Binary:
                    return "Binary";
                case OleDbType.Boolean:
                    return "Bit";
                case OleDbType.UnsignedTinyInt:
                    return "Byte";
                case OleDbType.TinyInt:
                    return "TinyInt";
                case OleDbType.Integer:
                    return "Integer";
                case OleDbType.Currency:
                    return "Currency";
                case OleDbType.Date:
                    return "DateTime";
                case OleDbType.Double:
                    return "Float";
                case OleDbType.Guid:
                    return "UniqueIdentifier";
                case OleDbType.Char:
                case OleDbType.WChar:
                    return "Text";
                case OleDbType.Single:
                    return "Real";
                case OleDbType.SmallInt:
                    return "SmallInt";
                case OleDbType.Numeric:
                case OleDbType.Decimal:
                    return "Decimal";
                default:
                    return "Unknown";
            }
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[Column Class](column-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
