---
title: DatabaseProvider.CalculateConnectionString Method  (Microsoft.Web.Management.DatabaseManager)
description: This article contains information on syntax and permissions for the DatabaseProvider.CalculateConnectionString method.
TOCTitle: CalculateConnectionString Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.DatabaseProvider.CalculateConnectionString(System.Collections.Generic.ICollection{Microsoft.Web.Management.DatabaseManager.ConnectionArgument})
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.databaseprovider.calculateconnectionstring(v=VS.90)
ms:contentKeyID: 20476444
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.CalculateConnectionString
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.CalculateConnectionString
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DatabaseProvider.CalculateConnectionString Method

Returns the calculated connection string for the database provider.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public MustOverride Function CalculateConnectionString ( _
    arguments As ICollection(Of ConnectionArgument) _
) As String
'Usage
Dim instance As DatabaseProvider
Dim arguments As ICollection(Of ConnectionArgument)
Dim returnValue As String

returnValue = instance.CalculateConnectionString(arguments)
```

```csharp
public abstract string CalculateConnectionString(
    ICollection<ConnectionArgument> arguments
)
```

```cpp
public:
virtual String^ CalculateConnectionString(
    ICollection<ConnectionArgument^>^ arguments
) abstract
```

```jscript
public abstract function CalculateConnectionString(
    arguments : ICollection<ConnectionArgument>
) : String
```

### Parameters

  - arguments  
    Type: [System.Collections.Generic.ICollection](https://msdn.microsoft.com/library/92t2ye13)\<[ConnectionArgument](connectionargument-class-microsoft-web-management-databasemanager.md)\>  
    The ICollection object that contains a collection of [ConnectionArgument](connectionargument-class-microsoft-web-management-databasemanager.md) objects.  

### Return Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The calculated database connection string.  

## Remarks

Your provider must implement the CalculateConnectionString method in order to generate a connection string based on the arguments that your database provider requires.

## Examples

The following code sample illustrates an example CalculateConnectionString method that returns the connection string for a Microsoft Access database provider.

```vb

    Public Overrides Function CalculateConnectionString( _
            ByVal arguments As System.Collections.Generic.ICollection( _
            Of Microsoft.Web.Management.DatabaseManager.ConnectionArgument)) As String

        Dim builder As OleDbConnectionStringBuilder = New OleDbConnectionStringBuilder
        For Each argument As ConnectionArgument In arguments
            Select Case (argument.Name)
                Case "Provider"
                    builder.Provider = argument.Value
                Case "Data Source"
                    builder.DataSource = argument.Value
                Case "Jet OLEDB:Database Password"
                    builder.Add(argument.Name, argument.Value)
                Case Else
                    Throw New ArgumentException(String.Format("The argument {0} is unexpected for this database provider!", argument.Name))
            End Select
        Next
        Return builder.ToString

    End Function

```

```csharp

        public override string CalculateConnectionString(
            ICollection<ConnectionArgument> arguments )
        {
            OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();

            foreach (ConnectionArgument argument in arguments)
            {
                switch (argument.Name)
                {
                    case "Provider":
                        builder.Provider = argument.Value;
                        break;
                    case "Data Source":
                        builder.DataSource = argument.Value;
                        break;
                    case "Jet OLEDB:Database Password":
                        builder.Add(argument.Name, argument.Value);
                        break;
                    default:
                        throw new ArgumentException(String.Format("The argument {0} is unexpected for this database provider!", argument.Name));
                }
            }
            return builder.ToString();
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[DatabaseProvider Class](databaseprovider-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
