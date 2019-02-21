---
title: DatabaseProvider.ConnectionStringArguments Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: ConnectionStringArguments Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.DatabaseProvider.ConnectionStringArguments
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.databaseprovider.connectionstringarguments(v=VS.90)
ms:contentKeyID: 20476681
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.ConnectionStringArguments
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.get_ConnectionStringArguments
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.ConnectionStringArguments
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.get_ConnectionStringArguments
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# DatabaseProvider.ConnectionStringArguments Property

Gets a collection that contains the collection of database connection arguments.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public MustOverride ReadOnly Property ConnectionStringArguments As ICollection(Of ConnectionArgument)
'Usage
Dim instance As DatabaseProvider
Dim value As ICollection(Of ConnectionArgument)

value = instance.ConnectionStringArguments
```

```csharp
public abstract ICollection<ConnectionArgument> ConnectionStringArguments { get; }
```

```cpp
public:
virtual property ICollection<ConnectionArgument^>^ ConnectionStringArguments {
    ICollection<ConnectionArgument^>^ get () abstract;
}
```

```jscript
abstract function get ConnectionStringArguments () : ICollection<ConnectionArgument>
```

### Property Value

Type: [System.Collections.Generic.ICollection](https://msdn.microsoft.com/library/92t2ye13)\<[ConnectionArgument](connectionargument-class-microsoft-web-management-databasemanager.md)\>  
A read-only ICollection object that contains a [ConnectionArgument](connectionargument-class-microsoft-web-management-databasemanager.md) collection.  

## Remarks

Your provider must implement the ConnectionStringArguments property in order to define the connection string arguments that your database provider requires.

## Examples

The following code sample illustrates an example ConnectionStringArguments property that returns the connection string arguments for a Microsoft Access database provider.

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

[DatabaseProvider Class](databaseprovider-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

