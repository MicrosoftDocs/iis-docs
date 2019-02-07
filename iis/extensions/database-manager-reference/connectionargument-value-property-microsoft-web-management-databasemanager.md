---
title: ConnectionArgument.Value Property  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: Value Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.ConnectionArgument.Value
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.connectionargument.value(v=VS.90)
ms:contentKeyID: 20476446
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.Value
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.get_Value
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.set_Value
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.get_Value
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.set_Value
- Microsoft.Web.Management.DatabaseManager.ConnectionArgument.Value
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ConnectionArgument.Value Property

Gets or sets a value that specifies the value of the connection argument.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Public Property Value As String
'Usage
Dim instance As ConnectionArgument
Dim value As String

value = instance.Value

instance.Value = value
```

``` csharp
public string Value { get; set; }
```

``` c++
public:
property String^ Value {
    String^ get ();
    void set (String^ value);
}
```

``` jscript
function get Value () : String
function set Value (value : String)
```

#### Property Value

Type: [System.String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The value of the connection argument.  

## Examples

The following code sample illustrates an example ConnectionStringArgument property that returns the connection string arguments for a Microsoft Access database provider.

``` vb

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

``` csharp

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

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ConnectionArgument Class](connectionargument-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

