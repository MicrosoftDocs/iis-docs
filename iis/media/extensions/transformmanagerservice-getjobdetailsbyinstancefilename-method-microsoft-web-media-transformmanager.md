---
title: TransformManagerService.GetJobDetailsByInstanceFileName Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobDetailsByInstanceFileName Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDetailsByInstanceFileName(System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.getjobdetailsbyinstancefilename(v=VS.90)
ms:contentKeyID: 36868660
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDetailsByInstanceFileName
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDetailsByInstanceFileName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetJobDetailsByInstanceFileName Method

Returns a collection of [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) objects based on the instance file name.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicFunctionGetJobDetailsByInstanceFileName ( _
    jobDefinitionIdAsString, _
    instanceFileNameAsString _
) AsCollection(OfJobDetails)
'Usage
DiminstanceAsTransformManagerServiceDimjobDefinitionIdAsStringDiminstanceFileNameAsStringDimreturnValueAsCollection(OfJobDetails)

returnValue = instance.GetJobDetailsByInstanceFileName(jobDefinitionId, _
    instanceFileName)
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicCollection<JobDetails> GetJobDetailsByInstanceFileName(
    stringjobDefinitionId,
    stringinstanceFileName
)
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualCollection<JobDetails^>^ GetJobDetailsByInstanceFileName(
    String^ jobDefinitionId, 
    String^ instanceFileName
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractGetJobDetailsByInstanceFileName : 
        jobDefinitionId:string * 
        instanceFileName:string->Collection<JobDetails> 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideGetJobDetailsByInstanceFileName : 
        jobDefinitionId:string * 
        instanceFileName:string->Collection<JobDetails> 
```

``` jscript
publicfinalfunctionGetJobDetailsByInstanceFileName(
    jobDefinitionId : String, 
    instanceFileName : String
) : Collection<JobDetails>
```

#### Parameters

  - jobDefinitionId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of a [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object.  

<!-- end list -->

  - instanceFileName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the file that instantiated the job.  

#### Return Value

Type: [System.Collections.ObjectModel. . :: . .Collection](https://msdn.microsoft.com/en-us/library/ms132397\(v=vs.90\))\< (Of \< ( \<'[JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A collection of job details.  

#### Implements

[IMonitoringService. . :: . .GetJobDetailsByInstanceFileName(String, String)](imonitoringservice-getjobdetailsbyinstancefilename-method-microsoft-web-media-transformmanager.md)  

## Remarks

The instance file name is created based on a combination of the date and a GUID.

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

