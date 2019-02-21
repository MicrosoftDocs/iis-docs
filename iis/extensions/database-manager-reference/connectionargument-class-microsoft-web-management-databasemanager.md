---
title: ConnectionArgument Class (Microsoft.Web.Management.DatabaseManager)
TOCTitle: ConnectionArgument Class
ms:assetid: T:Microsoft.Web.Management.DatabaseManager.ConnectionArgument
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.connectionargument(v=VS.90)
ms:contentKeyID: 20476628
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ConnectionArgument Class

Specifies a connection argument for a database connection.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Management.DatabaseManager.ConnectionArgument  

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Class ConnectionArgument
'Usage
Dim instance As ConnectionArgument
```

```csharp
public class ConnectionArgument
```

```cpp
public ref class ConnectionArgument
```

```jscript
public class ConnectionArgument
```

The ConnectionArgument type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[ConnectionArgument](connectionargument-constructor-microsoft-web-management-databasemanager.md)|Creates a new instance of the ConnectionArgument class.|


## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[DefaultValue](connectionargument-defaultvalue-property-microsoft-web-management-databasemanager.md)|Gets or sets the default value for the database connection argument.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[IsPassword](connectionargument-ispassword-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the connection argument is a password.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[IsRequired](connectionargument-isrequired-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that indicates whether the connection argument is required.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Name](connectionargument-name-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that specifies the name of the connection argument.|
|![Public property](images/Dd565931.pubproperty(en-us,VS.90).gif "Public property")|[Value](connectionargument-value-property-microsoft-web-management-databasemanager.md)|Gets or sets a value that specifies the value of the connection argument.|


## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Dd566041.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Dd566041.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

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

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

