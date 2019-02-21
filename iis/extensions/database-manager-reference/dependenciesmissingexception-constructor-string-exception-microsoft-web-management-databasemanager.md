---
title: DependenciesMissingException Constructor (String, Exception) (Microsoft.Web.Management.DatabaseManager)
TOCTitle: DependenciesMissingException Constructor (String, Exception)
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.DependenciesMissingException.#ctor(System.String,System.Exception)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.dependenciesmissingexception.dependenciesmissingexception(v=VS.90)
ms:contentKeyID: 22049485
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- cpp
- jscript
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.DependenciesMissingException..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DependenciesMissingException Constructor (String, Exception)

Creates a new instance of the [DependenciesMissingException](dependenciesmissingexception-class-microsoft-web-management-databasemanager.md) class.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Sub New ( _
    message As String, _
    innerException As Exception _
)
'Usage
Dim message As String
Dim innerException As Exception

Dim instance As New DependenciesMissingException(message, _
    innerException)
```

```csharp
public DependenciesMissingException(
    string message,
    Exception innerException
)
```

```cpp
public:
DependenciesMissingException(
    String^ message, 
    Exception^ innerException
)
```

```jscript
public function DependenciesMissingException(
    message : String, 
    innerException : Exception
)
```

### Parameters

  - message  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The message to return with the exception.  

<!-- end list -->

  - innerException  
    Type: [System.Exception](https://msdn.microsoft.com/library/c18k6c59)  
    The Exception that your provider will raise as an inner exception.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[DependenciesMissingException Class](dependenciesmissingexception-class-microsoft-web-management-databasemanager.md)

[DependenciesMissingException Overload](dependenciesmissingexception-constructor-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

