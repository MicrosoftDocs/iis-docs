---
title: ConnectionArgument.IsPassword Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: IsPassword Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.ConnectionArgument.IsPassword
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.connectionargument.ispassword(v=VS.90)
ms:contentKeyID: 20476643
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.IsPassword
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.get_IsPassword
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.set_IsPassword
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.get_IsPassword
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.IsPassword
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.set_IsPassword
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ConnectionArgument.IsPassword Property

Gets or sets a value that indicates whether the connection argument is a password.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property IsPassword As Boolean
'Usage
Dim instance As ConnectionArgument
Dim value As Boolean

value = instance.IsPassword

instance.IsPassword = value
```

```csharp
public bool IsPassword { get; set; }
```

```cpp
public:
property bool IsPassword {
    bool get ();
    void set (bool value);
}
```

```jscript
function get IsPassword () : boolean
function set IsPassword (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the connection argument is a password; otherwise, false.  

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

