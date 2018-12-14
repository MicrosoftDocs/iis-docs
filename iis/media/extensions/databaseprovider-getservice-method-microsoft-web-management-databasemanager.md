---
title: DatabaseProvider.GetService Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: GetService Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.DatabaseProvider.GetService(System.Type)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.databaseprovider.getservice(v=VS.90)
ms:contentKeyID: 20476401
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.GetService
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.GetService
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DatabaseProvider.GetService Method

Returns the service object for a database provider.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
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

``` csharp
public virtual Object GetService(
    Type serviceType
)
```

``` c++
public:
virtual Object^ GetService(
    Type^ serviceType
)
```

``` jscript
public function GetService(
    serviceType : Type
) : Object
```

#### Parameters

  - serviceType  
    Type: [System.Type](https://msdn.microsoft.com/en-us/library/42892f65\(v=vs.90\))  
    The service type for the database provider.  

#### Return Value

Type: [System.Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
The service object for a database provider.  

#### Implements

[IServiceProvider.GetService(Type)](https://msdn.microsoft.com/en-us/library/wacy2d1s\(v=vs.90\))  

## Remarks

Your provider may optionally implement the GetService method to return the system type for your database provider.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DatabaseProvider Class](databaseprovider-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

