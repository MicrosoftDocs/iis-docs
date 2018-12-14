---
title: TransformManagerService.GetJobDetailsById Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobDetailsById Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDetailsById(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.getjobdetailsbyid(v=VS.90)
ms:contentKeyID: 35520567
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDetailsById
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDetailsById
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetJobDetailsById Method

Returns a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object for the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicFunctionGetJobDetailsById ( _
    jobIdAsString _
) AsJobDetails
'Usage
DiminstanceAsTransformManagerServiceDimjobIdAsStringDimreturnValueAsJobDetailsreturnValue = instance.GetJobDetailsById(jobId)
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicJobDetailsGetJobDetailsById(
    stringjobId
)
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualJobDetails^ GetJobDetailsById(
    String^ jobId
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractGetJobDetailsById : 
        jobId:string->JobDetails 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideGetJobDetailsById : 
        jobId:string->JobDetails
```

``` jscript
publicfinalfunctionGetJobDetailsById(
    jobId : String
) : JobDetails
```

#### Parameters

  - jobId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the job to return.  

#### Return Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
The [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object.  

#### Implements

[IMonitoringService. . :: . .GetJobDetailsById(String)](imonitoringservice-getjobdetailsbyid-method-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

