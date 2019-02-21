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
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
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
---

# CancelJobById Method

Cancels a job that is represented by the specified job ID.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Function CancelJobById ( _
    jobId As String _
) As JobStatus
'Usage

  Dim instance As TransformManagerService
Dim jobId As String
Dim returnValue As JobStatus

returnValue = instance.CancelJobById(jobId)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public JobStatus CancelJobById(
    string jobId
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual JobStatus CancelJobById(
    String^ jobId
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract CancelJobById : 
        jobId:string -> JobStatus 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override CancelJobById : 
        jobId:string -> JobStatus 
```

```jscript
  public final function CancelJobById(
    jobId : String
) : JobStatus
```

### Parameters

  - jobId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the job to cancel.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The [JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md) object that corresponds to the action.  

### Implements

[IMonitoringService.CancelJobById(String)](imonitoringservice-canceljobbyid-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

