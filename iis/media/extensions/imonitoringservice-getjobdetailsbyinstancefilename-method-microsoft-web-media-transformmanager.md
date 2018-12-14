---
title: IMonitoringService.GetJobDetailsByInstanceFileName Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobDetailsByInstanceFileName Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobDetailsByInstanceFileName(System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imonitoringservice.getjobdetailsbyinstancefilename(v=VS.90)
ms:contentKeyID: 36868666
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobDetailsByInstanceFileName
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobDetailsByInstanceFileName
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
<OperationContractAttribute> _
FunctionGetJobDetailsByInstanceFileName ( _
    jobDefinitionIdAsString, _
    instanceFileNameAsString _
) AsCollection(OfJobDetails)
'Usage
DiminstanceAsIMonitoringServiceDimjobDefinitionIdAsStringDiminstanceFileNameAsStringDimreturnValueAsCollection(OfJobDetails)

returnValue = instance.GetJobDetailsByInstanceFileName(jobDefinitionId, _
    instanceFileName)
```

``` csharp
[OperationContractAttribute]
Collection<JobDetails> GetJobDetailsByInstanceFileName(
    stringjobDefinitionId,
    stringinstanceFileName
)
```

``` c++
[OperationContractAttribute]
Collection<JobDetails^>^ GetJobDetailsByInstanceFileName(
    String^ jobDefinitionId, 
    String^ instanceFileName
)
```

``` fsharp
[<OperationContractAttribute>]
abstractGetJobDetailsByInstanceFileName : 
        jobDefinitionId:string * 
        instanceFileName:string->Collection<JobDetails> 
```

``` jscript
functionGetJobDetailsByInstanceFileName(
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
    The name of the file that matched the file watcher filter and that instantiated the job.  

#### Return Value

Type: [System.Collections.ObjectModel. . :: . .Collection](https://msdn.microsoft.com/en-us/library/ms132397\(v=vs.90\))\< (Of \< ( \<'[JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  

## See Also

#### Reference

[IMonitoringService Interface](imonitoringservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

