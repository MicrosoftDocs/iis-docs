---
title: IMonitoringService.DeleteJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: DeleteJob Method
description: "The DeleteJob method deletes all input files, output files, and work item details of a job. This article describes its syntax and parameters."
ms:assetid: M:Microsoft.Web.Media.TransformManager.IMonitoringService.DeleteJob(Microsoft.Web.Media.TransformManager.JobDetails)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imonitoringservice.deletejob(v=VS.90)
ms:contentKeyID: 35520956
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IMonitoringService.DeleteJob
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IMonitoringService.DeleteJob
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DeleteJob Method

Deletes all input files, output files, and work item details of a job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Sub DeleteJob ( _
    jobDetails As JobDetails _
)
'Usage

  Dim instance As IMonitoringService
Dim jobDetails As JobDetails

instance.DeleteJob(jobDetails)
```

```csharp
[OperationContractAttribute]
void DeleteJob(
    JobDetails jobDetails
)
```

```cpp
[OperationContractAttribute]
void DeleteJob(
    JobDetails^ jobDetails
)
```

``` fsharp
[<OperationContractAttribute>]
abstract DeleteJob : 
        jobDetails:JobDetails -> unit 
```

```jscript
  function DeleteJob(
    jobDetails : JobDetails
)
```

### Parameters

  - jobDetails  
    Type: [Microsoft.Web.Media.TransformManager.JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
    An object that contains the ID of the job to delete.  

## See Also

### Reference

[IMonitoringService Interface](imonitoringservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
