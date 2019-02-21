---
title: IManagementService.DeleteJobScheduler Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: DeleteJobScheduler Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.DeleteJobScheduler(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imanagementservice.deletejobscheduler(v=VS.90)
ms:contentKeyID: 35520751
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.DeleteJobScheduler
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.DeleteJobScheduler
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# DeleteJobScheduler Method

Deletes a [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) object from IIS Transform Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Sub DeleteJobScheduler ( _
    jobSchedulerId As String _
)
'Usage

  Dim instance As IManagementService
Dim jobSchedulerId As String

instance.DeleteJobScheduler(jobSchedulerId)
```

```csharp
[OperationContractAttribute]
void DeleteJobScheduler(
    string jobSchedulerId
)
```

```cpp
[OperationContractAttribute]
void DeleteJobScheduler(
    String^ jobSchedulerId
)
```

``` fsharp
[<OperationContractAttribute>]
abstract DeleteJobScheduler : 
        jobSchedulerId:string -> unit 
```

```jscript
  function DeleteJobScheduler(
    jobSchedulerId : String
)
```

### Parameters

  - jobSchedulerId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) object to delete.  

## Exceptions

|Exception|Condition|
|--- |--- |
|[InvalidOperationException](https://msdn.microsoft.com/library/2asft85a)|The specified job scheduler is in use.|


## See Also

### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

