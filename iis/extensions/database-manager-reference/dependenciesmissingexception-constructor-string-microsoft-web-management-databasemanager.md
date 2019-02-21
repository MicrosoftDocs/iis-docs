---
title: DependenciesMissingException Constructor (String) (Microsoft.Web.Management.DatabaseManager)
TOCTitle: DependenciesMissingException Constructor (String)
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.DependenciesMissingException.#ctor(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.dependenciesmissingexception.dependenciesmissingexception(v=VS.90)
ms:contentKeyID: 22049492
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- "cpp"
- jscript
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.DependenciesMissingException..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# DependenciesMissingException Constructor (String)

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Sub New ( _
    helpLink As String _
)
'Usage
Dim helpLink As String

Dim instance As New DependenciesMissingException(helpLink)
```

```csharp
public DependenciesMissingException(
    string helpLink
)
```

```cpp
public:
DependenciesMissingException(
    String^ helpLink
)
```

```jscript
public function DependenciesMissingException(
    helpLink : String
)
```

### Parameters

  - helpLink  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    A string that contains the help URL for the exception.  

## Remarks

When a database provider raises a [DependenciesMissingException](dependenciesmissingexception-class-microsoft-web-management-databasemanager.md), IIS Manager will display the URL that you specify in the helpLink parameter as part of the error dialog.

## Examples

The following code sample illustrates an example VerifyDependencies method that verifies the dependencies for a sample OLEDB provider.

```vb

    ' Verify the database provider dependencies.
    Public Overrides Sub VerifyDependencies()

        Try
            ' Create a database provider factory for OLEDB.
            Dim oledbFactory As DbProviderFactory = _
                DbProviderFactories.GetFactory("System.Data.OleDb")
            ' Test for null.
            If (Not (oledbFactory) Is Nothing) Then
                ' Create an assembly name class.
                Dim name As AssemblyName = _
                    New AssemblyName(oledbFactory.GetType.Assembly.FullName)
                ' Test the version to make sure that it's greater than 1.
                If (name.Version.Major < 1) Then
                    ' Raise an exception if the version is not sufficient.
                    Throw New DependenciesMissingException("http://www.iis.net/")
                End If
            End If
        Catch
            ' Throw an exception when an error occurs.
            Throw New DependenciesMissingException("http://www.iis.net/")
        End Try

    End Sub

```

```csharp

        // Verify the database provider dependencies.
        public override void VerifyDependencies()
        {
            try
            {
                // Create a database provider factory for OLEDB.
                DbProviderFactory oledbFactory = DbProviderFactories.GetFactory("System.Data.OleDb");
                // Test for null.
                if (oledbFactory != null)
                {
                    // Create an assembly name class.
                    AssemblyName name = new AssemblyName(oledbFactory.GetType().Assembly.FullName);
                    // Test the version to make sure that it's greater than 1.
                    if (name.Version.Major < 1)
                    {
                        // Raise an exception if the version is not sufficient.
                        throw new DependenciesMissingException("http://www.iis.net/");
                    }
                }
            }
            catch
            {
                // Throw an exception when an error occurs.
                throw new DependenciesMissingException("http://www.iis.net/");
            }
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[DependenciesMissingException Class](dependenciesmissingexception-class-microsoft-web-management-databasemanager.md)

[DependenciesMissingException Overload](dependenciesmissingexception-constructor-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

