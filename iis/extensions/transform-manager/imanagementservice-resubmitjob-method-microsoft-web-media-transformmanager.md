---
title: IManagementService.ResubmitJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: ResubmitJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.ResubmitJob(Microsoft.Web.Media.TransformManager.JobDetails)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imanagementservice.resubmitjob(v=VS.90)
ms:contentKeyID: 35520661
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.ResubmitJob
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.ResubmitJob
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ResubmitJob Method

Moves a transform job to the configuring queue, where it will be resubmitted.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Sub ResubmitJob ( _
    jobDetails As JobDetails _
)
'Usage

  Dim instance As IManagementService
Dim jobDetails As JobDetails

instance.ResubmitJob(jobDetails)
```

```csharp
[OperationContractAttribute]
void ResubmitJob(
    JobDetails jobDetails
)
```

```cpp
[OperationContractAttribute]
void ResubmitJob(
    JobDetails^ jobDetails
)
```

``` fsharp
[<OperationContractAttribute>]
abstract ResubmitJob : 
        jobDetails:JobDetails -> unit 
```

```jscript
  function ResubmitJob(
    jobDetails : JobDetails
)
```

### Parameters

  - jobDetails  
    Type: [Microsoft.Web.Media.TransformManager.JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
    A [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object for the job to resubmit.  

## Exceptions

|Exception|Condition|
|--- |--- |
|[ArgumentNullException](https://msdn.microsoft.com/library/27426hcy)|jobDetails is null Nothing nullptr unit a null reference (Nothing in Visual Basic) .|
|[ArgumentNullException](https://msdn.microsoft.com/library/27426hcy)|The JobDefinitionId property of the jobDetails parameter is null Nothing nullptr unit a null reference (Nothing in Visual Basic) .|

## See Also

### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
