---
title: IManagementService.UpdateJobScheduler Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: UpdateJobScheduler Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.UpdateJobScheduler(Microsoft.Web.Media.TransformManager.JobScheduler)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imanagementservice.updatejobscheduler(v=VS.90)
ms:contentKeyID: 35520910
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.UpdateJobScheduler
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.UpdateJobScheduler
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# UpdateJobScheduler Method

Adds or replaces a [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Sub UpdateJobScheduler ( _
    scheduler As JobScheduler _
)
'Usage

  Dim instance As IManagementService
Dim scheduler As JobScheduler

instance.UpdateJobScheduler(scheduler)
```

```csharp
[OperationContractAttribute]
void UpdateJobScheduler(
    JobScheduler scheduler
)
```

```cpp
[OperationContractAttribute]
void UpdateJobScheduler(
    JobScheduler^ scheduler
)
```

``` fsharp
[<OperationContractAttribute>]
abstract UpdateJobScheduler : 
        scheduler:JobScheduler -> unit 
```

```jscript
  function UpdateJobScheduler(
    scheduler : JobScheduler
)
```

### Parameters

  - scheduler  
    Type: [Microsoft.Web.Media.TransformManager.JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md)  
    A new or updated [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) object.  

## See Also

### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
