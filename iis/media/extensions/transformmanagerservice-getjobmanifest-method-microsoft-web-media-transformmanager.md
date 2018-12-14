---
title: TransformManagerService.GetJobManifest Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobManifest Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobManifest(Microsoft.Web.Media.TransformManager.JobDetails)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.getjobmanifest(v=VS.90)
ms:contentKeyID: 35521138
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobManifest
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobManifest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetJobManifest Method

Returns the job manifest that IIS Transform Manager created for the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicFunctionGetJobManifest ( _
    jobDetailsAsJobDetails _
) AsString
'Usage
DiminstanceAsTransformManagerServiceDimjobDetailsAsJobDetailsDimreturnValueAsStringreturnValue = instance.GetJobManifest(jobDetails)
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicstringGetJobManifest(
    JobDetailsjobDetails
)
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualString^ GetJobManifest(
    JobDetails^ jobDetails
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractGetJobManifest : 
        jobDetails:JobDetails->string 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideGetJobManifest : 
        jobDetails:JobDetails->string
```

``` jscript
publicfinalfunctionGetJobManifest(
    jobDetails : JobDetails
) : String
```

#### Parameters

  - jobDetails  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
    An object that contains the ID of the job.  

#### Return Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string representation of the job manifest.  

#### Implements

[IMonitoringService. . :: . .GetJobManifest(JobDetails)](imonitoringservice-getjobmanifest-method-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

