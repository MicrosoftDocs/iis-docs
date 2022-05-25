---
title: IManagementService.GetJobSchedulers Method  (Microsoft.Web.Media.TransformManager)
description: GetJobSchedulers Method returns all JobScheduler objects from IIS Transform Manager.
TOCTitle: GetJobSchedulers Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.GetJobSchedulers
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imanagementservice.getjobschedulers(v=VS.90)
ms:contentKeyID: 35521153
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.GetJobSchedulers
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.GetJobSchedulers
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetJobSchedulers Method

Returns all [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) objects from IIS Transform Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Function GetJobSchedulers As Collection(Of JobScheduler)
'Usage

  Dim instance As IManagementService
Dim returnValue As Collection(Of JobScheduler)

returnValue = instance.GetJobSchedulers()
```

```csharp
[OperationContractAttribute]
Collection<JobScheduler> GetJobSchedulers()
```

```cpp
[OperationContractAttribute]
Collection<JobScheduler^>^ GetJobSchedulers()
```

``` fsharp
[<OperationContractAttribute>]
abstract GetJobSchedulers : unit -> Collection<JobScheduler> 
```

```jscript
  function GetJobSchedulers() : Collection<JobScheduler>
```

### Return Value

Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A collection of [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) objects.  

## See Also

### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
