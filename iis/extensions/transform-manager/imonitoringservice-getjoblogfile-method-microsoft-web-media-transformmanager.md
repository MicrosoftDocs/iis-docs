---
title: IMonitoringService.GetJobLogFile Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobLogFile Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobLogFile(Microsoft.Web.Media.TransformManager.JobDetails)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imonitoringservice.getjoblogfile(v=VS.90)
ms:contentKeyID: 35520645
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobLogFile
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobLogFile
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetJobLogFile Method

Returns the instance log for a job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<OperationContractAttribute> _
Function GetJobLogFile ( _
    jobDetails As JobDetails _
) As String
'Usage

  Dim instance As IMonitoringService
Dim jobDetails As JobDetails
Dim returnValue As String

returnValue = instance.GetJobLogFile(jobDetails)
```

``` csharp
[OperationContractAttribute]
string GetJobLogFile(
    JobDetails jobDetails
)
```

``` c++
[OperationContractAttribute]
String^ GetJobLogFile(
    JobDetails^ jobDetails
)
```

``` fsharp
[<OperationContractAttribute>]
abstract GetJobLogFile : 
        jobDetails:JobDetails -> string 
```

``` jscript
  function GetJobLogFile(
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

## See Also

#### Reference

[IMonitoringService Interface](imonitoringservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

