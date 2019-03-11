---
title: ConnectionArgument.DefaultValue Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: DefaultValue Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.ConnectionArgument.DefaultValue
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.connectionargument.defaultvalue(v=VS.90)
ms:contentKeyID: 20476727
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.DefaultValue
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.get_DefaultValue
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.set_DefaultValue
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.DefaultValue
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.get_DefaultValue
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.set_DefaultValue
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ConnectionArgument.DefaultValue Property

Gets or sets the default value for the database connection argument.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property DefaultValue As String
'Usage
Dim instance As ConnectionArgument
Dim value As String

value = instance.DefaultValue

instance.DefaultValue = value
```

```csharp
public string DefaultValue { get; set; }
```

```cpp
public:
property String^ DefaultValue {
    String^ get ();
    void set (String^ value);
}
```

```jscript
function get DefaultValue () : String
function set DefaultValue (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The database connection argument.  

## Examples

The following code sample illustrates an example ConnectionStringArgument property that returns the connection string arguments for a Microsoft Access database provider.

```vb

    Public Overrides ReadOnly Property ConnectionStringArguments() _
            As System.Collections.Generic.ICollection( _
            Of Microsoft.Web.Management.DatabaseManager.ConnectionArgument)

        Get
            Dim argList As LinkedList(Of ConnectionArgument) = New LinkedList(Of ConnectionArgument)
            Dim provider As ConnectionArgument = New ConnectionArgument
            provider.Name = "Provider"
            provider.DefaultValue = "Microsoft.Jet.OLEDB.4.0"
            argList.AddLast(provider)
            Dim database As ConnectionArgument = New ConnectionArgument
            database.Name = "Data Source"
            database.DefaultValue = "*.mdb"
            database.IsRequired = True
            argList.AddLast(database)
            Dim password As ConnectionArgument = New ConnectionArgument
            password.Name = "Jet OLEDB:Database Password"
            password.DefaultValue = ""
            password.IsRequired = False
            password.IsPassword = True
            argList.AddLast(password)
            Return argList
        End Get

    End Property

```

```csharp

        public override ICollection<ConnectionArgument> ConnectionStringArguments
        {
            get
            {
                LinkedList<ConnectionArgument> argList = new LinkedList<ConnectionArgument>();

                ConnectionArgument provider = new ConnectionArgument();
                provider.Name = "Provider";
                provider.DefaultValue = "Microsoft.Jet.OLEDB.4.0";
                argList.AddLast(provider);

                ConnectionArgument database = new ConnectionArgument();
                database.Name = "Data Source";
                database.DefaultValue = "*.mdb";
                database.IsRequired = true;
                argList.AddLast(database);

                ConnectionArgument password = new ConnectionArgument();
                password.Name = "Jet OLEDB:Database Password";
                password.DefaultValue = "";
                password.IsRequired = false;
                password.IsPassword = true;
                argList.AddLast(password);

                return argList;
            }
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[ConnectionArgument Class](connectionargument-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

