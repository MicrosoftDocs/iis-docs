---
title: DatabaseProvider.GetService Method (Microsoft.Web.Management.DatabaseManager)
description: "This article provides syntax, parameters, return value, implements, remarks, permissions, and references for the DatabaseProvider.GetService Method, which returns the service object for a database provider."
TOCTitle: GetService Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.DatabaseProvider.GetService(System.Type)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.databaseprovider.getservice(v=VS.90)
ms:contentKeyID: 20476401
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.GetService
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.GetService
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DatabaseProvider.GetService Method

Returns the service object for a database provider.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Overridable Function GetService ( _
    serviceType As Type _
) As Object
'Usage
Dim instance As DatabaseProvider
Dim serviceType As Type
Dim returnValue As Object

returnValue = instance.GetService(serviceType)
```

```csharp
public virtual Object GetService(
    Type serviceType
)
```

```cpp
public:
virtual Object^ GetService(
    Type^ serviceType
)
```

```jscript
public function GetService(
    serviceType : Type
) : Object
```

### Parameters

  - serviceType  
    Type: [System.Type](https://msdn.microsoft.com/library/42892f65)  
    The service type for the database provider.  

### Return Value

Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
The service object for a database provider.  

### Implements

[IServiceProvider.GetService(Type)](https://msdn.microsoft.com/library/wacy2d1s)  

## Remarks

Your provider may optionally implement the GetService method to return the system type for your database provider.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[DatabaseProvider Class](databaseprovider-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)
