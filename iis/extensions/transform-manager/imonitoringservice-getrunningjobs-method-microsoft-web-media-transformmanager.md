---
title: IMonitoringService.GetRunningJobs Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetRunningJobs Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IMonitoringService.GetRunningJobs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imonitoringservice.getrunningjobs(v=VS.90)
ms:contentKeyID: 35520733
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetRunningJobs
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetRunningJobs
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetRunningJobs Method

Returns a collection of all of the running jobs for all [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) objects.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<OperationContractAttribute> _
Function GetRunningJobs As Collection(Of JobDetails)
'Usage

  Dim instance As IMonitoringService
Dim returnValue As Collection(Of JobDetails)

returnValue = instance.GetRunningJobs()
```

``` csharp
[OperationContractAttribute]
Collection<JobDetails> GetRunningJobs()
```

``` c++
[OperationContractAttribute]
Collection<JobDetails^>^ GetRunningJobs()
```

``` fsharp
[<OperationContractAttribute>]
abstract GetRunningJobs : unit -> Collection<JobDetails> 
```

``` jscript
  function GetRunningJobs() : Collection<JobDetails>
```

#### Return Value

Type: [System.Collections.ObjectModel. . :: . .Collection](https://msdn.microsoft.com/en-us/library/ms132397\(v=vs.90\))\< (Of \< ( \<'[JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
The collection of running jobs.  

## See Also

#### Reference

[IMonitoringService Interface](imonitoringservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

