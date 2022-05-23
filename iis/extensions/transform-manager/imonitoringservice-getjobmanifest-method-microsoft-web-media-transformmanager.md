---
title: IMonitoringService.GetJobManifest Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobManifest Method
description: Returns the job manifest that IIS Transform Manager created for a job.
ms:assetid: M:Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobManifest(Microsoft.Web.Media.TransformManager.JobDetails)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imonitoringservice.getjobmanifest(v=VS.90)
ms:contentKeyID: 35520881
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobManifest
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobManifest
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetJobManifest Method

Returns the job manifest that IIS Transform Manager created for a job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Function GetJobManifest ( _
    jobDetails As JobDetails _
) As String
'Usage

  Dim instance As IMonitoringService
Dim jobDetails As JobDetails
Dim returnValue As String

returnValue = instance.GetJobManifest(jobDetails)
```

```csharp
[OperationContractAttribute]
string GetJobManifest(
    JobDetails jobDetails
)
```

```cpp
[OperationContractAttribute]
String^ GetJobManifest(
    JobDetails^ jobDetails
)
```

``` fsharp
[<OperationContractAttribute>]
abstract GetJobManifest : 
        jobDetails:JobDetails -> string 
```

```jscript
  function GetJobManifest(
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

## See Also

### Reference

[IMonitoringService Interface](imonitoringservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
