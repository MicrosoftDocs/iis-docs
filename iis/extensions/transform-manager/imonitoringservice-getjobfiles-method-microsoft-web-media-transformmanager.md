---
title: IMonitoringService.GetJobFiles Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobFiles Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobFiles(Microsoft.Web.Media.TransformManager.JobDetails)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imonitoringservice.getjobfiles(v=VS.90)
ms:contentKeyID: 35520621
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobFiles
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobFiles
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetJobFiles Method

Returns a list of the files in the folder that is created for this job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<OperationContractAttribute> _
Function GetJobFiles ( _
    jobDetails As JobDetails _
) As Collection(Of String)
'Usage

  Dim instance As IMonitoringService
Dim jobDetails As JobDetails
Dim returnValue As Collection(Of String)

returnValue = instance.GetJobFiles(jobDetails)
```

``` csharp
[OperationContractAttribute]
Collection<string> GetJobFiles(
    JobDetails jobDetails
)
```

``` c++
[OperationContractAttribute]
Collection<String^>^ GetJobFiles(
    JobDetails^ jobDetails
)
```

``` fsharp
[<OperationContractAttribute>]
abstract GetJobFiles : 
        jobDetails:JobDetails -> Collection<string> 
```

``` jscript
  function GetJobFiles(
    jobDetails : JobDetails
) : Collection<String>
```

#### Parameters

  - jobDetails  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
    An object that contains the ID of the job.  

#### Return Value

Type: [System.Collections.ObjectModel. . :: . .Collection](https://msdn.microsoft.com/en-us/library/ms132397\(v=vs.90\))\< (Of \< ( \<'[String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))\> ) \> ) \>  
A collection of file names based on the files in the job folder.  

## See Also

#### Reference

[IMonitoringService Interface](imonitoringservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

