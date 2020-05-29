---
title: DatabaseProvider.VerifyDependencies Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: VerifyDependencies Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.DatabaseProvider.VerifyDependencies
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.databaseprovider.verifydependencies(v=VS.90)
ms:contentKeyID: 22049478
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.VerifyDependencies
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.VerifyDependencies
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DatabaseProvider.VerifyDependencies Method

Verifies the database dependencies for your provider.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Overridable Sub VerifyDependencies
'Usage
Dim instance As DatabaseProvider

instance.VerifyDependencies()
```

```csharp
public virtual void VerifyDependencies()
```

```cpp
public:
virtual void VerifyDependencies()
```

```jscript
public function VerifyDependencies()
```

## Remarks

You can optionally implement the VerifyDependencies method to verify any dependencies that your database provider may have. This method takes no parameters and does not have a return value; your database provider should raise an exception by using the [DependenciesMissingException](dependenciesmissingexception-class-microsoft-web-management-databasemanager.md) class if the operating system environment does not meet your database provider's dependencies.

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

[DatabaseProvider Class](databaseprovider-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
