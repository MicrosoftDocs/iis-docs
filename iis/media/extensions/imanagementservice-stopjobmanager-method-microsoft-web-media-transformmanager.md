---
title: IManagementService.StopJobManager Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: StopJobManager Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.StopJobManager(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imanagementservice.stopjobmanager(v=VS.90)
ms:contentKeyID: 35521019
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.StopJobManager
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.StopJobManager
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StopJobManager Method

Signals a [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object to stop.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<OperationContractAttribute> _
SubStopJobManager ( _
    jobDefinitionIdAsString _
)
'Usage
DiminstanceAsIManagementServiceDimjobDefinitionIdAsString

instance.StopJobManager(jobDefinitionId)
```

``` csharp
[OperationContractAttribute]
voidStopJobManager(
    stringjobDefinitionId
)
```

``` c++
[OperationContractAttribute]
voidStopJobManager(
    String^ jobDefinitionId
)
```

``` fsharp
[<OperationContractAttribute>]
abstractStopJobManager : 
        jobDefinitionId:string->unit
```

``` jscript
functionStopJobManager(
    jobDefinitionId : String
)
```

#### Parameters

  - jobDefinitionId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object to stop.  

## Remarks

When the StopJobManager method is called, the [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object stops creating new jobs, finishes running any jobs that are already started or submitted, and shuts down.

## See Also

#### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

