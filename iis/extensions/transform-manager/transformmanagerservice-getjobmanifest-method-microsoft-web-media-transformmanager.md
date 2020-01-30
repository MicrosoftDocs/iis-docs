---
title: TransformManagerService.GetJobManifest Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobManifest Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobManifest(Microsoft.Web.Media.TransformManager.JobDetails)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.transformmanagerservice.getjobmanifest(v=VS.90)
ms:contentKeyID: 35521138
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobManifest
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobManifest
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetJobManifest Method

Returns the job manifest that IIS Transform Manager created for the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Function GetJobManifest ( _
    jobDetails As JobDetails _
) As String
'Usage

  Dim instance As TransformManagerService
Dim jobDetails As JobDetails
Dim returnValue As String

returnValue = instance.GetJobManifest(jobDetails)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public string GetJobManifest(
    JobDetails jobDetails
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual String^ GetJobManifest(
    JobDetails^ jobDetails
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract GetJobManifest : 
        jobDetails:JobDetails -> string 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override GetJobManifest : 
        jobDetails:JobDetails -> string 
```

```jscript
  public final function GetJobManifest(
    jobDetails : JobDetails
) : String
```

### Parameters

  - jobDetails  
    Type: [Microsoft.Web.Media.TransformManager.JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
    An object that contains the ID of the job.  

### Return Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A string representation of the job manifest.  

### Implements

[IMonitoringService.GetJobManifest(JobDetails)](imonitoringservice-getjobmanifest-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

