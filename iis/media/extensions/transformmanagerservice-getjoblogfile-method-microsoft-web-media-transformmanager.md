---
title: TransformManagerService.GetJobLogFile Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobLogFile Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobLogFile(Microsoft.Web.Media.TransformManager.JobDetails)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.getjoblogfile(v=VS.90)
ms:contentKeyID: 35521032
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobLogFile
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobLogFile
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetJobLogFile Method

Returns the instance log for the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicFunctionGetJobLogFile ( _
    jobDetailsAsJobDetails _
) AsString
'Usage
DiminstanceAsTransformManagerServiceDimjobDetailsAsJobDetailsDimreturnValueAsStringreturnValue = instance.GetJobLogFile(jobDetails)
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicstringGetJobLogFile(
    JobDetailsjobDetails
)
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualString^ GetJobLogFile(
    JobDetails^ jobDetails
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractGetJobLogFile : 
        jobDetails:JobDetails->string 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideGetJobLogFile : 
        jobDetails:JobDetails->string
```

``` jscript
publicfinalfunctionGetJobLogFile(
    jobDetails : JobDetails
) : String
```

#### Parameters

  - jobDetails  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
    An object that contains the ID of the job.  

#### Return Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A job log file.  

#### Implements

[IMonitoringService. . :: . .GetJobLogFile(JobDetails)](imonitoringservice-getjoblogfile-method-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

