---
title: TransformManagerService.GetCumulativeJobCountByStatus Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetCumulativeJobCountByStatus Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetCumulativeJobCountByStatus(Microsoft.Web.Media.TransformManager.JobStatus)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.transformmanagerservice.getcumulativejobcountbystatus(v=VS.90)
ms:contentKeyID: 46408636
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetCumulativeJobCountByStatus
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetCumulativeJobCountByStatus
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetCumulativeJobCountByStatus Method

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Function GetCumulativeJobCountByStatus ( _
    status As JobStatus _
) As Integer
'Usage

  Dim instance As TransformManagerService
Dim status As JobStatus
Dim returnValue As Integer

returnValue = instance.GetCumulativeJobCountByStatus(status)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public int GetCumulativeJobCountByStatus(
    JobStatus status
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual int GetCumulativeJobCountByStatus(
    JobStatus status
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract GetCumulativeJobCountByStatus : 
        status:JobStatus -> int 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override GetCumulativeJobCountByStatus : 
        status:JobStatus -> int 
```

```jscript
  public final function GetCumulativeJobCountByStatus(
    status : JobStatus
) : int
```

### Parameters

  - status  
    Type: [Microsoft.Web.Media.TransformManager.JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  

### Return Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  

### Implements

[IMonitoringService.GetCumulativeJobCountByStatus(JobStatus)](imonitoringservice-getcumulativejobcountbystatus-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
