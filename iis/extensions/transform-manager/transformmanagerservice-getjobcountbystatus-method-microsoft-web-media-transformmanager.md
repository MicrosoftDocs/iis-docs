---
title: TransformManagerService.GetJobCountByStatus Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobCountByStatus Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobCountByStatus(Microsoft.Web.Media.TransformManager.JobStatus)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.transformmanagerservice.getjobcountbystatus(v=VS.90)
ms:contentKeyID: 35521161
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobCountByStatus
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobCountByStatus
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetJobCountByStatus Method

Returns the number of jobs in each job state.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Function GetJobCountByStatus ( _
    status As JobStatus _
) As Integer
'Usage

  Dim instance As TransformManagerService
Dim status As JobStatus
Dim returnValue As Integer

returnValue = instance.GetJobCountByStatus(status)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public int GetJobCountByStatus(
    JobStatus status
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual int GetJobCountByStatus(
    JobStatus status
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract GetJobCountByStatus : 
        status:JobStatus -> int 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override GetJobCountByStatus : 
        status:JobStatus -> int 
```

```jscript
  public final function GetJobCountByStatus(
    status : JobStatus
) : int
```

### Parameters

  - status  
    Type: [Microsoft.Web.Media.TransformManager.JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
    The state of the jobs to count.  

### Return Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The number of jobs that correspond to the specified state.  

### Implements

[IMonitoringService.GetJobCountByStatus(JobStatus)](imonitoringservice-getjobcountbystatus-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

