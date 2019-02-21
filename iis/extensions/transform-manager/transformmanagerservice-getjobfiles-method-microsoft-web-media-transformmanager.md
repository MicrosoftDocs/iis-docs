---
title: TransformManagerService.GetJobFiles Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobFiles Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobFiles(Microsoft.Web.Media.TransformManager.JobDetails)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.getjobfiles(v=VS.90)
ms:contentKeyID: 35520798
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobFiles
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobFiles
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetJobFiles Method

Returns a list of the files in the folder that is created for the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Function GetJobFiles ( _
    jobDetails As JobDetails _
) As Collection(Of String)
'Usage

  Dim instance As TransformManagerService
Dim jobDetails As JobDetails
Dim returnValue As Collection(Of String)

returnValue = instance.GetJobFiles(jobDetails)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public Collection<string> GetJobFiles(
    JobDetails jobDetails
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual Collection<String^>^ GetJobFiles(
    JobDetails^ jobDetails
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract GetJobFiles : 
        jobDetails:JobDetails -> Collection<string> 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override GetJobFiles : 
        jobDetails:JobDetails -> Collection<string> 
```

```jscript
  public final function GetJobFiles(
    jobDetails : JobDetails
) : Collection<String>
```

### Parameters

  - jobDetails  
    Type: [Microsoft.Web.Media.TransformManager.JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
    A [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object that contains the ID of the job.  

### Return Value

Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[String](https://msdn.microsoft.com/library/s1wwdcbf)\> ) \> ) \>  
A collection of file names.  

### Implements

[IMonitoringService.GetJobFiles(JobDetails)](imonitoringservice-getjobfiles-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

