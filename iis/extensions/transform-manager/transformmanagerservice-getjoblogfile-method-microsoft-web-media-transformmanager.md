---
title: TransformManagerService.GetJobLogFile Method  (Microsoft.Web.Media.TransformManager)
description: This article contains information about syntax for the TransformManagerService.GetJobLogFile method.
TOCTitle: GetJobLogFile Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobLogFile(Microsoft.Web.Media.TransformManager.JobDetails)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.transformmanagerservice.getjoblogfile(v=VS.90)
ms:contentKeyID: 35521032
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobLogFile
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobLogFile
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetJobLogFile Method

Returns the instance log for the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Function GetJobLogFile ( _
    jobDetails As JobDetails _
) As String
'Usage

  Dim instance As TransformManagerService
Dim jobDetails As JobDetails
Dim returnValue As String

returnValue = instance.GetJobLogFile(jobDetails)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public string GetJobLogFile(
    JobDetails jobDetails
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual String^ GetJobLogFile(
    JobDetails^ jobDetails
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract GetJobLogFile : 
        jobDetails:JobDetails -> string 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override GetJobLogFile : 
        jobDetails:JobDetails -> string 
```

```jscript
  public final function GetJobLogFile(
    jobDetails : JobDetails
) : String
```

### Parameters

  - jobDetails  
    Type: [Microsoft.Web.Media.TransformManager.JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
    An object that contains the ID of the job.  

### Return Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A job log file.  

### Implements

[IMonitoringService.GetJobLogFile(JobDetails)](imonitoringservice-getjoblogfile-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
