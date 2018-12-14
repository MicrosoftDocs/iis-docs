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
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobFiles
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetJobFiles Method

Returns a list of the files in the folder that is created for the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicFunctionGetJobFiles ( _
    jobDetailsAsJobDetails _
) AsCollection(OfString)
'Usage
DiminstanceAsTransformManagerServiceDimjobDetailsAsJobDetailsDimreturnValueAsCollection(OfString)

returnValue = instance.GetJobFiles(jobDetails)
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicCollection<string> GetJobFiles(
    JobDetailsjobDetails
)
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualCollection<String^>^ GetJobFiles(
    JobDetails^ jobDetails
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractGetJobFiles : 
        jobDetails:JobDetails->Collection<string> 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideGetJobFiles : 
        jobDetails:JobDetails->Collection<string> 
```

``` jscript
publicfinalfunctionGetJobFiles(
    jobDetails : JobDetails
) : Collection<String>
```

#### Parameters

  - jobDetails  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
    A [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object that contains the ID of the job.  

#### Return Value

Type: [System.Collections.ObjectModel. . :: . .Collection](https://msdn.microsoft.com/en-us/library/ms132397\(v=vs.90\))\< (Of \< ( \<'[String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))\> ) \> ) \>  
A collection of file names.  

#### Implements

[IMonitoringService. . :: . .GetJobFiles(JobDetails)](imonitoringservice-getjobfiles-method-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

