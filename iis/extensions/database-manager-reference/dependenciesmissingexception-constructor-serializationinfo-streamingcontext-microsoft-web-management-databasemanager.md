---
title: DependenciesMissingException Constructor (SerializationInfo, StreamingContext) (Microsoft.Web.Management.DatabaseManager)
TOCTitle: DependenciesMissingException Constructor (SerializationInfo, StreamingContext)
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.DependenciesMissingException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.dependenciesmissingexception.dependenciesmissingexception(v=VS.90)
ms:contentKeyID: 22049490
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
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# DependenciesMissingException Constructor (SerializationInfo, StreamingContext)

Creates a new instance of the [DependenciesMissingException](dependenciesmissingexception-class-microsoft-web-management-databasemanager.md) class.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Protected Sub New ( _
    info As SerializationInfo, _
    context As StreamingContext _
)
'Usage
Dim info As SerializationInfo
Dim context As StreamingContext

Dim instance As New DependenciesMissingException(info, context)
```

```csharp
protected DependenciesMissingException(
    SerializationInfo info,
    StreamingContext context
)
```

```cpp
protected:
DependenciesMissingException(
    SerializationInfo^ info, 
    StreamingContext context
)
```

```jscript
protected function DependenciesMissingException(
    info : SerializationInfo, 
    context : StreamingContext
)
```

### Parameters

  - info  
    Type: [System.Runtime.Serialization.SerializationInfo](https://msdn.microsoft.com/library/a9b6042e)  
    A SerializationInfo object that contains the serialization information for the exception.  

<!-- end list -->

  - context  
    Type: [System.Runtime.Serialization.StreamingContext](https://msdn.microsoft.com/library/t16abws5)  
    A StreamingContext object that contains the contextual information for the info object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[DependenciesMissingException Class](dependenciesmissingexception-class-microsoft-web-management-databasemanager.md)

[DependenciesMissingException Overload](dependenciesmissingexception-constructor-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

