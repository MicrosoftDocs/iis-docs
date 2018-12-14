---
title: TransformManagerService.CancelJobById Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CancelJobById Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.CancelJobById(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.canceljobbyid(v=VS.90)
ms:contentKeyID: 35521077
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.CancelJobById
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.CancelJobById
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CancelJobById Method

Cancels a job that is represented by the specified job ID.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicFunctionCancelJobById ( _
    jobIdAsString _
) AsJobStatus
'Usage
DiminstanceAsTransformManagerServiceDimjobIdAsStringDimreturnValueAsJobStatusreturnValue = instance.CancelJobById(jobId)
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicJobStatusCancelJobById(
    stringjobId
)
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualJobStatusCancelJobById(
    String^ jobId
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractCancelJobById : 
        jobId:string->JobStatus 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideCancelJobById : 
        jobId:string->JobStatus
```

``` jscript
publicfinalfunctionCancelJobById(
    jobId : String
) : JobStatus
```

#### Parameters

  - jobId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the job to cancel.  

#### Return Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The [JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md) object that corresponds to the action.  

#### Implements

[IMonitoringService. . :: . .CancelJobById(String)](imonitoringservice-canceljobbyid-method-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

