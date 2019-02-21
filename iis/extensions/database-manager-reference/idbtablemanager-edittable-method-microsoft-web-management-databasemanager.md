---
title: IDbTableManager.EditTable Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: EditTable Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.IDbTableManager.EditTable(System.String,System.String,Microsoft.Web.Management.DatabaseManager.TableInfo)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.idbtablemanager.edittable(v=VS.90)
ms:contentKeyID: 20476597
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.IDbTableManager.EditTable
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.IDbTableManager.EditTable
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# IDbTableManager.EditTable Method

Modifies a table in a database.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Sub EditTable ( _
    connectionString As String, _
    schema As String, _
    tableInfo As TableInfo _
)
'Usage
Dim instance As IDbTableManager
Dim connectionString As String
Dim schema As String
Dim tableInfo As TableInfo

instance.EditTable(connectionString, _
    schema, tableInfo)
```

```csharp
void EditTable(
    string connectionString,
    string schema,
    TableInfo tableInfo
)
```

```cpp
void EditTable(
    String^ connectionString, 
    String^ schema, 
    TableInfo^ tableInfo
)
```

```jscript
function EditTable(
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

All database providers that implement the [IDbTableManager](idbtablemanager-interface-microsoft-web-management-databasemanager.md) interface must also implement the EditTable method, which the database manager will use to modify the columns, indexes, and relationships for a table.

### 

### Notes for Implementers

If your provider does not support editing tables, you can use the following code sample to raise a not-implemented exception:

    public void EditTable(string connectionString, string schema, TableInfo tableInfo)
    {
       throw new NotImplementedException();
    }


> [!NOTE]  
> See the [ALTER TABLE (Transact-SQL)](http://msdn.microsoft.com/en-us/library/ms190273.aspx) topic for more information about the ALTER TABLE SQL statement.


## Examples

The following code sample implements the EditTable method for an OLEDB connection by using the TableInfo object that the database manager provides.


> [!NOTE]  
> This example also provides helper methods that perform additional database tasks.


```vb

    Public Sub EditTable( _
            ByVal connectionString As String, _
            ByVal schema As String, _
            ByVal tableInfo As TableInfo) _
            Implements Microsoft.Web.Management.DatabaseManager.IDbTableManager.EditTable

        ' Test if the table has changes.
        If (tableInfo.HasChanges = True) Then
            ' Test if the table is marked for deletion.
            If (tableInfo.IsMarkedForDelete = True) Then
                ' Drop the table.
                DropTable(connectionString, schema, tableInfo)
            Else
                ' Create a connection to the database.
                Dim connection As OleDbConnection = New OleDbConnection(connectionString)
                ' Open the connection to the database.
                connection.Open()
                ' Begin a transaction.
                Dim transaction As OleDbTransaction = connection.BeginTransaction
                Try
                    ' Update the table information.
                    UpdateColumns(connection, transaction, schema, tableInfo)
                    UpdateIndexes(connection, transaction, schema, tableInfo)
                    UpdateForeignKeys(connection, transaction, schema, tableInfo)
                    ' Commit the transaction.
                    transaction.Commit()
                Catch ex As Exception
                    ' Roll back the transaction.
                    transaction.Rollback()
                    ' Raise an exception if an error occurs.
                    Throw New ProviderException(("ALTER TABLE Exception:" + vbCrLf + vbCrLf + ex.Message))
                Finally
                    ' Close the database connection.
                    connection.Close()
                End Try
            End If
        End If

    End Sub

    Private Sub UpdateColumns(ByVal connection As OleDbConnection, ByVal transaction As OleDbTransaction, ByVal schema As String, ByVal tableInfo As TableInfo)
        Dim deleteColumnList As List(Of String) = New List(Of String)
        Dim renameColumnList As List(Of Column) = New List(Of Column)
        Dim modifyColumnList As ArrayList = New ArrayList
        Dim addList As List(Of Column) = New List(Of Column)
        Dim dropDefaultConstraintList As ArrayList = New ArrayList
        Dim modifyDefaultConstraint As List(Of Column) = New List(Of Column)

        For Each column As Column In tableInfo.Columns
            If column.IsMarkedForDelete Then
                If Not column.IsNew Then
                    deleteColumnList.Add(column.OriginalName)
                End If
            ElseIf column.IsNew Then
                addList.Add(column)
            Else
                If (column.HasChanges(ColumnChanges.Name) _
                            AndAlso Not String.IsNullOrEmpty(column.OriginalName)) Then
                    renameColumnList.Add(column)
                ElseIf (column.HasChanges(ColumnChanges.AllowNull) _
                            OrElse (column.HasChanges(ColumnChanges.Type) OrElse column.HasChanges(ColumnChanges.Length))) Then
                    modifyColumnList.Add(column)
                End If
                If column.HasChanges(ColumnChanges.DefaultValue) Then
                    If String.IsNullOrEmpty(column.DefaultValue) Then
                        ' Drop the default constraint.
                        dropDefaultConstraintList.Add(column)
                    Else
                        ' Drop the default constraint.
                        dropDefaultConstraintList.Add(column)
                        ' Modify the default constraint.
                        modifyDefaultConstraint.Add(column)
                    End If
                End If
            End If
        Next
        ' Test if there are columns to delete.
        If (deleteColumnList.Count > 0) Then
            ' Delete any columns.
            DropColumns(connection, transaction, tableInfo.Name, schema, deleteColumnList.ToArray)
        End If
        ' Test if there are columns to rename.
        If (renameColumnList.Count > 0) Then
            ' Rename any columns.
            RenameColumns(connection, transaction, tableInfo.Name, schema, renameColumnList)
        End If
        ' Test if there are columns to alter.
        For Each column As Column In modifyColumnList
            ' Alter any columns.
            AlterColumn(connection, transaction, tableInfo.Name, schema, column)
        Next
        ' Loop through any column constraints to delete.
        For Each column As Column In dropDefaultConstraintList
            ' Drop each column constraint.
            DropDefaultConstraint(connection, transaction, tableInfo.Name, schema, column)
        Next
        ' Add the default constraints.
        AddDefaultConstraints(connection, transaction, tableInfo.Name, schema, modifyDefaultConstraint)
        ' Test if there are columns to add.
        If (addList.Count > 0) Then
            ' Add the columns.
            AddColumns(connection, transaction, tableInfo.Name, schema, addList)
        End If
    End Sub

    Private Sub DropColumns(ByVal connection As OleDbConnection, ByVal transaction As OleDbTransaction, ByVal tableName As String, ByVal schema As String, ByVal columns() As String)
        ' Create a new string builder for the SQL statement.
        Dim alterTableText As StringBuilder = New StringBuilder
        alterTableText.Append("ALTER TABLE ")
        alterTableText.Append(EscapeName(tableName))
        alterTableText.Append(" DROP COLUMN ")
        Dim addComma As Boolean = False
        For Each column As String In columns
            If (addComma = True) Then
                alterTableText.Append(Microsoft.VisualBasic.ChrW(44))
            End If
            addComma = True
            alterTableText.Append(EscapeName(column))
        Next
        Dim command As OleDbCommand = connection.CreateCommand
        command.CommandText = alterTableText.ToString
        command.Transaction = transaction
        command.ExecuteNonQuery()
    End Sub

    Private Sub RenameColumns(ByVal connection As OleDbConnection, ByVal transaction As OleDbTransaction, ByVal tableName As String, ByVal schema As String, ByVal columns As List(Of Column))
        For Each column As Column In columns
            ' Create a new string builder for the SQL statement.
            Dim alterTableText As StringBuilder = New StringBuilder
            alterTableText.Append("ALTER TABLE ")
            alterTableText.Append(EscapeName(tableName))
            alterTableText.Append(" CHANGE COLUMN ")
            alterTableText.Append(EscapeName(column.OriginalName))
            alterTableText.Append(" ")
            alterTableText.Append(EscapeName(column.Name))
            alterTableText.Append((" " + column.TypeInfo.Name))
            If (column.Length > 0) Then
                alterTableText.Append(("(" _
                                + (column.Length.ToString + ")")))
            End If
            If column.IsIdentity Then
                alterTableText.Append(" NOT NULL AUTO_INCREMENT PRIMARY KEY")
            ElseIf (column.AllowNulls) Then
                alterTableText.Append(" NULL")
            Else
                alterTableText.Append(" NOT NULL")
            End If
            Dim command As OleDbCommand = connection.CreateCommand
            command.CommandText = alterTableText.ToString
            command.Transaction = transaction
            command.ExecuteNonQuery()
        Next
    End Sub

    Private Sub AlterColumn(ByVal connection As OleDbConnection, ByVal transaction As OleDbTransaction, ByVal tableName As String, ByVal schema As String, ByVal column As Column)
        ' Create a new string builder for the SQL statement.
        Dim alterTableText As StringBuilder = New StringBuilder
        alterTableText.Append("ALTER TABLE ")
        alterTableText.Append(EscapeName(tableName))
        alterTableText.Append(" ALTER COLUMN ")
        alterTableText.Append(EscapeName(column.Name))
        alterTableText.Append((" " + column.TypeInfo.Name))
        If (column.Length > 0) Then
            alterTableText.Append(("(" _
                            + (column.Length.ToString + ")")))
        End If
        If column.IsIdentity Then
            alterTableText.Append(" NOT NULL AUTO_INCREMENT PRIMARY KEY")
        ElseIf (column.AllowNulls) Then
            alterTableText.Append(" NULL")
        Else
            alterTableText.Append(" NOT NULL")
        End If
        Dim command As OleDbCommand = connection.CreateCommand
        command.CommandText = alterTableText.ToString
        command.Transaction = transaction
        command.ExecuteNonQuery()
    End Sub

    Private Sub DropDefaultConstraint(ByVal connection As OleDbConnection, ByVal transaction As OleDbTransaction, ByVal tableName As String, ByVal schema As String, ByVal column As Column)
        Dim builder As StringBuilder = New StringBuilder
        builder.Append("ALTER TABLE ")
        builder.Append(EscapeName(tableName))
        builder.Append(" ALTER COLUMN ")
        builder.Append(EscapeName(column.Name))
        builder.Append(" DROP DEFAULT")
        Dim command As OleDbCommand = connection.CreateCommand
        command.CommandText = builder.ToString
        command.Transaction = transaction
        command.ExecuteNonQuery()
    End Sub

    Private Sub AddDefaultConstraints(ByVal connection As OleDbConnection, ByVal transaction As OleDbTransaction, ByVal tableName As String, ByVal schema As String, ByVal columns As IList)
        For Each column As Column In columns
            If Not String.IsNullOrEmpty(column.DefaultValue) Then
                ' Create a new string builder for the SQL statement.
                Dim AlterTableText As StringBuilder = New StringBuilder
                AlterTableText.Append("ALTER TABLE ")
                AlterTableText.Append(EscapeName(tableName))
                AlterTableText.Append(" ALTER COLUMN ")
                AlterTableText.Append(EscapeName(column.Name))
                AlterTableText.Append(" SET DEFAULT ")
                If IsStringType(column.TypeInfo) Then
                    AlterTableText.Append("'")
                    AlterTableText.Append(column.DefaultValue)
                    AlterTableText.Append("'")
                Else
                    AlterTableText.Append(column.DefaultValue)
                End If
                Dim command As OleDbCommand = connection.CreateCommand
                command.CommandText = AlterTableText.ToString
                command.Transaction = transaction
                command.ExecuteNonQuery()
            End If
        Next
    End Sub

    ' Add columns to a table.
    Private Sub AddColumns(ByVal connection As OleDbConnection, ByVal transaction As OleDbTransaction, ByVal tableName As String, ByVal schema As String, ByVal columns As IList)
        ' Create a new string builder for the SQL statement.
        Dim alterTableText As StringBuilder = New StringBuilder
        alterTableText.Append("ALTER TABLE ")
        alterTableText.Append(EscapeName(tableName))
        alterTableText.Append(" ADD ")
        alterTableText.Append(BuildColumnClause(columns))
        Dim command As OleDbCommand = connection.CreateCommand
        command.CommandText = alterTableText.ToString
        command.Transaction = transaction
        command.ExecuteNonQuery()
        AddDefaultConstraints(connection, transaction, tableName, schema, columns)
    End Sub

    Private Shared Function BuildColumnClause(ByVal columns As IList) As String
        ' Create a new string builder for the SQL statement.
        Dim columnClause As StringBuilder = New StringBuilder
        Dim addComma As Boolean = False
        For Each column As Column In columns
            If (addComma = True) Then
                columnClause.Append(Microsoft.VisualBasic.ChrW(44))
            End If
            addComma = True
            columnClause.Append(EscapeName(column.Name))
            columnClause.Append((" " + column.TypeInfo.Name))
            If (column.Length > 0) Then
                columnClause.Append(("(" _
                                + (column.Length.ToString + ")")))
            End If
            If column.IsIdentity Then
                columnClause.Append(" NOT NULL AUTO_INCREMENT PRIMARY KEY")
            ElseIf (column.AllowNulls) Then
                columnClause.Append(" NULL")
            Else
                columnClause.Append(" NOT NULL")
            End If
        Next
        Return columnClause.ToString
    End Function

    Private Sub UpdateIndexes(ByVal connection As OleDbConnection, ByVal transaction As OleDbTransaction, ByVal schema As String, ByVal tableInfo As TableInfo)
        Dim deleteList As List(Of Index) = New List(Of Index)
        Dim addList As List(Of Index) = New List(Of Index)
        For Each index As Index In tableInfo.Indexes
            If index.IsMarkedForDelete Then
                If Not index.IsNew Then
                    deleteList.Add(index)
                End If
            ElseIf index.IsNew Then
                addList.Add(index)
            ElseIf Not index.Name.Equals(index.OriginalName, StringComparison.Ordinal) Then
                ' Delete and re-add to rename the index.
                deleteList.Add(index)
                addList.Add(index)
            End If
        Next
        ' Test if there are indices to delete.
        If (deleteList.Count > 0) Then
            DropIndexes(connection, transaction, tableInfo.Name, schema, deleteList)
        End If
        ' Test if there are indices to add.
        If (addList.Count > 0) Then
            AddIndexes(connection, transaction, tableInfo.Name, schema, addList)
        End If
    End Sub

    Private Sub DropIndexes(ByVal connection As OleDbConnection, ByVal transaction As OleDbTransaction, ByVal tableName As String, ByVal schema As String, ByVal deleteList As IList)
        For Each index As Index In deleteList
            Dim sql As StringBuilder = New StringBuilder
            If (index.IndexType = IndexType.PrimaryKey) Then
                sql.Append("ALTER TABLE ")
                sql.Append(EscapeName(tableName))
                sql.Append(" DROP PRIMARY KEY")
            Else
                sql.Append(("DROP INDEX " + EscapeName(index.Name)))
                sql.Append((" ON " + EscapeName(tableName)))
            End If
            Dim command As OleDbCommand = connection.CreateCommand
            command.CommandText = sql.ToString
            command.Transaction = transaction
            command.ExecuteNonQuery()
        Next
    End Sub

    Private Sub AddIndexes(ByVal connection As OleDbConnection, ByVal transaction As OleDbTransaction, ByVal tableName As String, ByVal schema As String, ByVal indexes As IList)
        For Each index As Index In indexes
            If (index.IndexType = IndexType.PrimaryKey) Then
                AddPrimaryKey(connection, transaction, tableName, schema, index)
            Else
                Dim sql As StringBuilder = New StringBuilder
                sql.Append("CREATE ")
                If index.Unique Then
                    sql.Append("UNIQUE ")
                End If
                sql.Append(("INDEX " _
                                + (EscapeName(index.Name) + (" ON " + EscapeName(tableName)))))
                sql.Append("(")
                Dim addComma As Boolean = False
                For Each column As IndexColumn In index.Columns
                    If (addComma = True) Then
                        sql.Append(", ")
                    End If
                    addComma = True
                    sql.Append(EscapeName(column.Name))
                Next
                sql.Append(")")
                Dim command As OleDbCommand = connection.CreateCommand
                command.CommandText = sql.ToString
                command.Transaction = transaction
                command.ExecuteNonQuery()
            End If
        Next
    End Sub

    Private Sub AddPrimaryKey(ByVal connection As OleDbConnection, ByVal transaction As OleDbTransaction, ByVal tableName As String, ByVal schema As String, ByVal index As Index)
        Dim sql As StringBuilder = New StringBuilder
        sql.Append("ALTER TABLE ")
        sql.Append(EscapeName(tableName))
        sql.Append(" ADD PRIMARY KEY")
        sql.Append("(")
        Dim addComma As Boolean = False
        For Each column As IndexColumn In index.Columns
            If (addComma = True) Then
                sql.Append(", ")
            End If
            addComma = True
            sql.Append(EscapeName(column.Name))
        Next
        sql.Append(")")
        Dim command As OleDbCommand = connection.CreateCommand
        command.CommandText = sql.ToString
        command.Transaction = transaction
        command.ExecuteNonQuery()
    End Sub

    Private Sub UpdateForeignKeys(ByVal connection As OleDbConnection, ByVal transaction As OleDbTransaction, ByVal schema As String, ByVal tableInfo As TableInfo)
        Dim deleteList As List(Of String) = New List(Of String)
        Dim addList As List(Of ForeignKey) = New List(Of ForeignKey)
        For Each fk As ForeignKey In tableInfo.ForeignKeys
            If fk.IsMarkedForDelete Then
                If Not fk.IsNew Then
                    deleteList.Add(fk.Name)
                End If
            ElseIf fk.IsNew Then
                addList.Add(fk)
            ElseIf Not fk.Name.Equals(fk.OriginalName, StringComparison.Ordinal) Then
                deleteList.Add(fk.Name)
                addList.Add(fk)
            End If
        Next
        If (deleteList.Count > 0) Then
            DropForeignKeys(connection, transaction, tableInfo.Name, schema, deleteList.ToArray)
        End If
        If (addList.Count > 0) Then
            AddForeignKeys(connection, transaction, addList)
        End If
    End Sub

    Private Sub DropForeignKeys(ByVal connection As OleDbConnection, ByVal transaction As OleDbTransaction, ByVal tableName As String, ByVal schema As String, ByVal fkNames() As String)
        Dim sqlString As StringBuilder = New StringBuilder
        sqlString.Append("ALTER TABLE ")
        sqlString.Append(EscapeName(tableName))
        sqlString.Append(" DROP FOREIGN KEY ")
        For Each fkName As String In fkNames
            Dim sql As String = (sqlString.ToString + EscapeName(fkName))
            Dim command As OleDbCommand = connection.CreateCommand
            command.CommandText = sql
            command.Transaction = transaction
            command.ExecuteNonQuery()
        Next
    End Sub

    Private Sub AddForeignKeys(ByVal connection As OleDbConnection, ByVal transaction As OleDbTransaction, ByVal foreignKeys As IList)
        For Each fk As ForeignKey In foreignKeys
            Dim sql As StringBuilder = New StringBuilder
            sql.Append("ALTER TABLE ")
            sql.Append(EscapeName(fk.FKTableName))
            sql.Append(" ADD CONSTRAINT ")
            sql.Append(EscapeName(fk.Name))
            sql.Append(" FOREIGN KEY ")
            sql.Append("(")
            Dim addComma As Boolean = False
            For Each column As ForeignKeyColumn In fk.FKColumns
                If (addComma = True) Then
                    sql.Append(", ")
                End If
                addComma = True
                sql.Append(EscapeName(column.Name))
            Next
            sql.Append(")")
            sql.Append((" REFERENCES " _
                            + (EscapeName(fk.PKTableName) + " ")))
            sql.Append("(")
            addComma = False
            For Each column As ForeignKeyColumn In fk.PKColumns
                If (addComma = True) Then
                    sql.Append(", ")
                End If
                addComma = True
                sql.Append(EscapeName(column.Name))
            Next
            sql.Append(")")
            sql.Append(" ON UPDATE NO ACTION ON DELETE NO ACTION")
            Dim command As OleDbCommand = connection.CreateCommand
            command.CommandText = sql.ToString
            command.Transaction = transaction
            command.ExecuteNonQuery()
        Next
    End Sub



...



    Public Sub DropTable(ByVal connectionString As String, ByVal schema As String, ByVal tableInfo As Microsoft.Web.Management.DatabaseManager.TableInfo) Implements Microsoft.Web.Management.DatabaseManager.IDbTableManager.DropTable
        ' Create a connection to the database.
        Dim connection As OleDbConnection = New OleDbConnection(connectionString)
        ' Open the connection to the database.
        connection.Open()
        ' Begin a transaction.
        Dim transaction As OleDbTransaction = connection.BeginTransaction
        Try
            ' Create the DROP TABLE SQL statement.
            Dim dropStatement As String = String.Format("DROP TABLE {0}", EscapeName(tableInfo.Name))
            ' Create an OLEDB command object.
            Dim command As OleDbCommand = New OleDbCommand(dropStatement, connection)
            ' Specify the transaction.
            command.Transaction = transaction
            ' Run the SQL statement.
            command.ExecuteNonQuery()
            ' Commit the transaction.
            transaction.Commit()
        Catch ex As Exception
            ' Roll back the transaction.
            transaction.Rollback()
            ' Raise an exception if an error occurs.
            Throw New ProviderException(("DROP TABLE Exception:" + vbCrLf + vbCrLf + ex.Message))
        Finally
            ' Close the database connection.
            connection.Close()
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



...



    ' Determine if a database type is a string type.
    Private Function IsStringType(ByVal typeInfo As TypeInfo) As Boolean
        Return (String.Compare(typeInfo.Name, "Text", True) = 0)
    End Function

```

```csharp

// Modify a table in the database.
public void EditTable(
    string connectionString,
    string schema,
    TableInfo tableInfo)
{
    // Test if the table has changes.
    if (tableInfo.HasChanges == true)
    {
        // Test if the table is marked for deletion.
        if (tableInfo.IsMarkedForDelete == true)
        {
            // Drop the table.
            DropTable(connectionString, schema, tableInfo);
        }
        else
        {
            // Create a connection to the database.
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Open the connection to the database.
                connection.Open();
                // Begin a transaction.
                OleDbTransaction transaction = connection.BeginTransaction();
                try
                {
                    // Update the table information.
                    UpdateColumns(connection, transaction, schema, tableInfo);
                    UpdateIndexes(connection, transaction, schema, tableInfo);
                    UpdateForeignKeys(connection, transaction, schema, tableInfo);
                    // Commit the transaction.
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Roll back the transaction.
                    transaction.Rollback();
                    // Raise an exception if an error occurs.
                    throw new ProviderException("ALTER TABLE Exception:\n\n" + ex.Message);
                }
                finally
                {
                    // Close the database connection.
                    connection.Close();
                }
            }
        }
    }
}

private void UpdateColumns(
    OleDbConnection connection,
    OleDbTransaction transaction,
    string schema,
    TableInfo tableInfo)
{
    List<string> deleteColumnList = new List<string>();
    List<Column> renameColumnList = new List<Column>();
    ArrayList modifyColumnList = new ArrayList();
    List<Column> addList = new List<Column>();
    ArrayList dropDefaultConstraint = new ArrayList();
    List<Column> modifyDefaultConstraint = new List<Column>();

    foreach (Column column in tableInfo.Columns)
    {
        if (column.IsMarkedForDelete)
        {
            if (!column.IsNew)
            {
                deleteColumnList.Add(column.OriginalName);
            }
        }
        else if (column.IsNew)
        {
            addList.Add(column);
        }
        else
        {
            if (column.HasChanges(ColumnChanges.Name) &&
                !String.IsNullOrEmpty(column.OriginalName))
            {
                renameColumnList.Add(column);
            }
            else if (column.HasChanges(ColumnChanges.AllowNull) ||
                     column.HasChanges(ColumnChanges.Type) ||
                     column.HasChanges(ColumnChanges.Length))
            {
                modifyColumnList.Add(column);
            }

            if (column.HasChanges(ColumnChanges.DefaultValue))
            {
                if (String.IsNullOrEmpty(column.DefaultValue))
                {
                    // Drop the default constraint.
                    dropDefaultConstraint.Add(column);
                }
                else
                {
                    // Drop the default constraint.
                    dropDefaultConstraint.Add(column);
                    // Modify the default constraint.
                    modifyDefaultConstraint.Add(column);
                }
            }
        }
    }

    // Test if there are columns to delete.
    if (deleteColumnList.Count > 0)
    {
        // Delete any columns.
        DropColumns(connection, transaction, tableInfo.Name, schema, deleteColumnList.ToArray());
    }

    // Test if there are columns to rename.
    if (renameColumnList.Count > 0)
    {
        // Rename any columns.
        RenameColumns(connection, transaction, tableInfo.Name, schema, renameColumnList);
    }

    // Test if there are columns to alter.
    foreach (Column column in modifyColumnList)
    {
        // Alter any columns.
        AlterColumn(connection, transaction, tableInfo.Name, schema, column);
    }

    // Loop through any column constraints to delete.
    foreach (Column column in dropDefaultConstraint)
    {
        // Drop each column constraint.
        DropDefaultConstraint(connection, transaction, tableInfo.Name, schema, column);
    }

    // Add the default constraints.
    AddDefaultConstraints(connection, transaction, tableInfo.Name, schema, modifyDefaultConstraint);

    // Test if there are columns to add.
    if (addList.Count > 0)
    {
        // Add the columns.
        AddColumns(connection, transaction, tableInfo.Name, schema, addList);
    }
}

private void DropColumns(
    OleDbConnection connection,
    OleDbTransaction transaction,
    string tableName,
    string schema,
    string[] columns)
{
    // Create a new string builder for the SQL statement.
    StringBuilder alterTableText = new StringBuilder();
    alterTableText.Append("ALTER TABLE ");
    alterTableText.Append(EscapeName(tableName));
    alterTableText.Append(" DROP COLUMN ");

    bool addComma = false;
    foreach (string column in columns)
    {
        if (addComma == true)
        {
            alterTableText.Append(',');
        }
        addComma = true;

        alterTableText.Append(EscapeName(column));
    }

    OleDbCommand command = connection.CreateCommand();
    command.CommandText = alterTableText.ToString();
    command.Transaction = transaction;
    command.ExecuteNonQuery();
}

private void RenameColumns(
    OleDbConnection connection,
    OleDbTransaction transaction,
    string tableName,
    string schema,
    List<Column> columns)
{
    foreach (Column column in columns)
    {
        // Create a new string builder for the SQL statement.
        StringBuilder alterTableText = new StringBuilder();
        alterTableText.Append("ALTER TABLE ");
        alterTableText.Append(EscapeName(tableName));
        alterTableText.Append(" CHANGE COLUMN ");
        alterTableText.Append(EscapeName(column.OriginalName));
        alterTableText.Append(" ");
        alterTableText.Append(EscapeName(column.Name));
        alterTableText.Append(" " + column.TypeInfo.Name);

        if (column.Length > 0)
        {
            alterTableText.Append("(" + column.Length.ToString() + ")");
        }

        if (column.IsIdentity)
        {
            alterTableText.Append(" NOT NULL AUTO_INCREMENT PRIMARY KEY");
        }
        else
        {
            if (!column.AllowNulls)
            {
                alterTableText.Append(" NOT NULL");
            }
            else
            {
                alterTableText.Append(" NULL");
            }
        }

        OleDbCommand command = connection.CreateCommand();
        command.CommandText = alterTableText.ToString();
        command.Transaction = transaction;
        command.ExecuteNonQuery();
    }
}

private void AlterColumn(
    OleDbConnection connection,
    OleDbTransaction transaction,
    string tableName,
    string schema,
    Column column)
{
    // Create a new string builder for the SQL statement.
    StringBuilder alterTableText = new StringBuilder();

    alterTableText.Append("ALTER TABLE ");
    alterTableText.Append(EscapeName(tableName));
    alterTableText.Append(" ALTER COLUMN ");
    alterTableText.Append(EscapeName(column.Name));
    alterTableText.Append(" " + column.TypeInfo.Name);

    if (column.Length > 0)
    {
        alterTableText.Append("(" + column.Length.ToString() + ")");
    }

    if (column.IsIdentity)
    {
        alterTableText.Append(" NOT NULL AUTO_INCREMENT PRIMARY KEY");
    }
    else
    {
        if (!column.AllowNulls)
        {
            alterTableText.Append(" NOT NULL");
        }
        else
        {
            alterTableText.Append(" NULL");
        }
    }

    OleDbCommand command = connection.CreateCommand();
    command.CommandText = alterTableText.ToString();
    command.Transaction = transaction;
    command.ExecuteNonQuery();
}

private void DropDefaultConstraint(
    OleDbConnection connection,
    OleDbTransaction transaction,
    string tableName,
    string schema,
    Column column)
{
    StringBuilder builder = new StringBuilder();
    builder.Append("ALTER TABLE ");
    builder.Append(EscapeName(tableName));
    builder.Append(" ALTER COLUMN ");
    builder.Append(EscapeName(column.Name));
    builder.Append(" DROP DEFAULT");
    OleDbCommand command = connection.CreateCommand();
    command.CommandText = builder.ToString();
    command.Transaction = transaction;
    command.ExecuteNonQuery();
}

private void AddDefaultConstraints(
    OleDbConnection connection,
    OleDbTransaction transaction,
    string tableName,
    string schema,
    IList<Column> columns)
{
    foreach (Column column in columns)
    {
        if (!String.IsNullOrEmpty(column.DefaultValue))
        {
            // Create a new string builder for the SQL statement.
            StringBuilder AlterTableText = new StringBuilder();
            AlterTableText.Append("ALTER TABLE ");
            AlterTableText.Append(EscapeName(tableName));
            AlterTableText.Append(" ALTER COLUMN ");
            AlterTableText.Append(EscapeName(column.Name));
            AlterTableText.Append(" SET DEFAULT ");

            if (IsStringType(column.TypeInfo))
            {
                AlterTableText.Append("'");
                AlterTableText.Append(column.DefaultValue);
                AlterTableText.Append("'");
            }
            else
            {
                AlterTableText.Append(column.DefaultValue);
            }

            OleDbCommand command = connection.CreateCommand();
            command.CommandText = AlterTableText.ToString();
            command.Transaction = transaction;
            command.ExecuteNonQuery();
        }
    }
}

// Add columns to a table.
private void AddColumns(
    OleDbConnection connection,
    OleDbTransaction transaction,
    string tableName,
    string schema,
    IList<Column> columns)
{
    // Create a new string builder for the SQL statement.
    StringBuilder alterTableText = new StringBuilder();
    alterTableText.Append("ALTER TABLE ");
    alterTableText.Append(EscapeName(tableName));
    alterTableText.Append(" ADD ");
    alterTableText.Append(BuildColumnClause(columns));

    OleDbCommand command = connection.CreateCommand();
    command.CommandText = alterTableText.ToString();
    command.Transaction = transaction;
    command.ExecuteNonQuery();

    AddDefaultConstraints(connection, transaction, tableName, schema, columns);
}

private static string BuildColumnClause(
    IList<Column> columns)
{
    // Create a new string builder for the SQL statement.
    StringBuilder columnClause = new StringBuilder();

    bool addComma = false;
    foreach (Column column in columns)
    {
        if (addComma == true)
        {
            columnClause.Append(',');
        }

        addComma = true;

        columnClause.Append(EscapeName(column.Name));
        columnClause.Append(" " + column.TypeInfo.Name);

        if (column.Length > 0)
        {
            columnClause.Append("(" + column.Length.ToString() + ")");
        }

        if (column.IsIdentity)
        {
            columnClause.Append(" NOT NULL AUTO_INCREMENT PRIMARY KEY");
        }
        else
        {
            if (!column.AllowNulls)
            {
                columnClause.Append(" NOT NULL");
            }
            else
            {
                columnClause.Append(" NULL");
            }
        }
    }

    return columnClause.ToString();
}

private void UpdateIndexes(
    OleDbConnection connection,
    OleDbTransaction transaction,
    string schema,
    TableInfo tableInfo)
{
    List<Index> deleteList = new List<Index>();
    List<Index> addList = new List<Index>();

    foreach (Index index in tableInfo.Indexes)
    {
        if (index.IsMarkedForDelete)
        {
            if (!index.IsNew)
            {
                deleteList.Add(index);
            }
        }
        else if (index.IsNew)
        {
            addList.Add(index);
        }
        else if (!index.Name.Equals(index.OriginalName,StringComparison.Ordinal))
        {
            // Delete and re-add to rename the index.
            deleteList.Add(index);
            addList.Add(index);
        }
    }
    // Test if there are indices to delete.
    if (deleteList.Count > 0)
    {
        DropIndexes(connection, transaction, tableInfo.Name, schema, deleteList);
    }
    // Test if there are indices to add.
    if (addList.Count > 0)
    {
        AddIndexes(connection, transaction, tableInfo.Name, schema, addList);
    }
}

private void DropIndexes(
    OleDbConnection connection,
    OleDbTransaction transaction,
    string tableName,
    string schema,
    IList<Index> deleteList)
{
    foreach (Index index in deleteList)
    {
        StringBuilder sql = new StringBuilder();
        if (index.IndexType == IndexType.PrimaryKey)
        {
            sql.Append("ALTER TABLE ");
            sql.Append(EscapeName(tableName));
            sql.Append(" DROP PRIMARY KEY");
        }
        else
        {
            sql.Append("DROP INDEX " + EscapeName(index.Name));
            sql.Append(" ON " + EscapeName(tableName));
        }
        OleDbCommand command = connection.CreateCommand();
        command.CommandText = sql.ToString();
        command.Transaction = transaction;
        command.ExecuteNonQuery();
    }
}

private void AddIndexes(
    OleDbConnection connection,
    OleDbTransaction transaction,
    string tableName,
    string schema,
    IList<Index> indexes)
{
    foreach (Index index in indexes)
    {
        if (index.IndexType == IndexType.PrimaryKey)
        {
            AddPrimaryKey(connection, transaction, tableName, schema, index);
        }
        else
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("CREATE ");
            if (index.Unique)
            {
                sql.Append("UNIQUE ");
            }

            sql.Append("INDEX " + EscapeName(index.Name) + " ON " + EscapeName(tableName));
            sql.Append("(");
            bool addComma = false;
            foreach (IndexColumn column in index.Columns)
            {
                if (addComma == true)
                {
                    sql.Append(", ");
                }
                addComma = true;
                sql.Append(EscapeName(column.Name));
            }
            sql.Append(")");

            OleDbCommand command = connection.CreateCommand();
            command.CommandText = sql.ToString();
            command.Transaction = transaction;
            command.ExecuteNonQuery();
        }
    }
}

private void AddPrimaryKey(
    OleDbConnection connection,
    OleDbTransaction transaction,
    string tableName,
    string schema,
    Index index)
{
    StringBuilder sql = new StringBuilder();

    sql.Append("ALTER TABLE ");
    sql.Append(EscapeName(tableName));
    sql.Append(" ADD PRIMARY KEY");

    sql.Append("(");
    bool addComma = false;
    foreach (IndexColumn column in index.Columns)
    {
        if (addComma == true)
        {
            sql.Append(", ");
        }
        addComma = true;
        sql.Append(EscapeName(column.Name));
    }
    sql.Append(")");

    OleDbCommand command = connection.CreateCommand();
    command.CommandText = sql.ToString();
    command.Transaction = transaction;
    command.ExecuteNonQuery();
}

private void UpdateForeignKeys(
    OleDbConnection connection,
    OleDbTransaction transaction,
    string schema,
    TableInfo tableInfo)
{
    List<string> deleteList = new List<string>();
    List<ForeignKey> addList = new List<ForeignKey>();

    foreach (ForeignKey fk in tableInfo.ForeignKeys)
    {
        if (fk.IsMarkedForDelete)
        {
            if (!fk.IsNew)
            {
                deleteList.Add(fk.Name);
            }
        }
        else if (fk.IsNew)
        {
            addList.Add(fk);
        }
        else if (!fk.Name.Equals(fk.OriginalName, StringComparison.Ordinal))
        {
            deleteList.Add(fk.Name);
            addList.Add(fk);
        }
    }

    if (deleteList.Count > 0)
    {
        DropForeignKeys(connection, transaction, tableInfo.Name, schema, deleteList.ToArray());
    }

    if (addList.Count > 0)
    {
        AddForeignKeys(connection, transaction, addList);
    }
}

private void DropForeignKeys(
    OleDbConnection connection,
    OleDbTransaction transaction,
    string tableName,
    string schema,
    string[] fkNames)
{
    StringBuilder sqlString = new StringBuilder();
    sqlString.Append("ALTER TABLE ");
    sqlString.Append(EscapeName(tableName));
    sqlString.Append(" DROP FOREIGN KEY ");
    foreach (string fkName in fkNames)
    {
        string sql = sqlString.ToString() + EscapeName(fkName);

        OleDbCommand command = connection.CreateCommand();
        command.CommandText = sql;
        command.Transaction = transaction;
        command.ExecuteNonQuery();
    }
}

private void AddForeignKeys(
    OleDbConnection connection,
    OleDbTransaction transaction,
    IList<ForeignKey> foreignKeys)
{
    foreach (ForeignKey fk in foreignKeys)
    {
        StringBuilder sql = new StringBuilder();
        sql.Append("ALTER TABLE ");
        sql.Append(EscapeName(fk.FKTableName));
        sql.Append(" ADD CONSTRAINT ");
        sql.Append(EscapeName(fk.Name));
        sql.Append(" FOREIGN KEY ");
        sql.Append("(");
        bool addComma = false;
        foreach (ForeignKeyColumn column in fk.FKColumns)
        {
            if (addComma == true)
            {
                sql.Append(", ");
            }
            addComma = true;
            sql.Append(EscapeName(column.Name));
        }
        sql.Append(")");
        sql.Append(" REFERENCES " + EscapeName(fk.PKTableName) + " ");
        sql.Append("(");
        addComma = false;
        foreach (ForeignKeyColumn column in fk.PKColumns)
        {
            if (addComma == true)
            {
                sql.Append(", ");
            }
            addComma = true;
            sql.Append(EscapeName(column.Name));
        }
        sql.Append(")");
        sql.Append(" ON UPDATE NO ACTION ON DELETE NO ACTION");

        OleDbCommand command = connection.CreateCommand();
        command.CommandText = sql.ToString();
        command.Transaction = transaction;
        command.ExecuteNonQuery();
    }
}



...



        public void DropTable(string connectionString, string schema, TableInfo tableInfo)
        {
            // Create a connection to the database.
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Open the connection to the database.
                connection.Open();
                // Begin a transaction.
                OleDbTransaction transaction = connection.BeginTransaction();
                try
                {
                    // Create the DROP TABLE SQL statement.
                    string dropStatement = String.Format("DROP TABLE {0}", EscapeName(tableInfo.Name));
                    // Create an OLEDB command object.
                    using (OleDbCommand command = new OleDbCommand(dropStatement, connection))
                    {
                        // Specify the transaction.
                        command.Transaction = transaction;
                        // Run the SQL statement.
                        command.ExecuteNonQuery();
                        // Commit the transaction.
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    // Roll back the transaction.
                    transaction.Rollback();
                    // Raise an exception if an error occurs.
                    throw new ProviderException("DROP TABLE Exception:\n\n" + ex.Message);
                }
                finally
                {
                    // Close the database connection.
                    connection.Close();
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



...



        // Determine if a database type is a string type.
        private bool IsStringType(TypeInfo typeInfo)
        {
            return (String.Compare(typeInfo.Name, "Text", true) == 0);
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[IDbTableManager Interface](idbtablemanager-interface-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

