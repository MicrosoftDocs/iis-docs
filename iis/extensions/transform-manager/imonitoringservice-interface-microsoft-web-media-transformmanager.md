---
title: IMonitoringService Interface (Microsoft.Web.Media.TransformManager)
TOCTitle: IMonitoringService Interface
ms:assetid: T:Microsoft.Web.Media.TransformManager.IMonitoringService
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imonitoringservice(v=VS.90)
ms:contentKeyID: 35521044
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IMonitoringService
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IMonitoringService
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IMonitoringService Interface

Represents an interface that defines how the IIS Transform Manager monitors jobs that are related to a transform process.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<ServiceContractAttribute(Namespace := "http://schemas.microsoft.com/iis/media/v4/TM/monitoringservice")> _
Public Interface IMonitoringService
'Usage

  Dim instance As IMonitoringService
```

```csharp
[ServiceContractAttribute(Namespace = "http://schemas.microsoft.com/iis/media/v4/TM/monitoringservice")]
public interface IMonitoringService
```

```cpp
[ServiceContractAttribute(Namespace = L"http://schemas.microsoft.com/iis/media/v4/TM/monitoringservice")]
public interface class IMonitoringService
```

``` fsharp
[<ServiceContractAttribute(Namespace = "http://schemas.microsoft.com/iis/media/v4/TM/monitoringservice")>]
type IMonitoringService =  interface end
```

```jscript
  public interface IMonitoringService
```

The IMonitoringService type exposes the following members.

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[CancelJob](imonitoringservice-canceljob-method-microsoft-web-media-transformmanager.md)|Cancels a job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[CancelJobById](imonitoringservice-canceljobbyid-method-microsoft-web-media-transformmanager.md)|Cancels a job that is represented by the specified job ID.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[DeleteJob](imonitoringservice-deletejob-method-microsoft-web-media-transformmanager.md)|Deletes all input files, output files, and work item details of a job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetCumulativeJobCountByStatus](imonitoringservice-getcumulativejobcountbystatus-method-microsoft-web-media-transformmanager.md)||
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobCountByStatus](imonitoringservice-getjobcountbystatus-method-microsoft-web-media-transformmanager.md)|Returns the number of jobs in each job state.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobDetails](imonitoringservice-getjobdetails-method-microsoft-web-media-transformmanager.md)|Returns a collection of job details based on the specified filter parameters.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobDetailsById](imonitoringservice-getjobdetailsbyid-method-microsoft-web-media-transformmanager.md)|Returns a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object for a job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobDetailsByInstanceFileName](imonitoringservice-getjobdetailsbyinstancefilename-method-microsoft-web-media-transformmanager.md)|Returns a collection of [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) objects based on the instance file name.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobFiles](imonitoringservice-getjobfiles-method-microsoft-web-media-transformmanager.md)|Returns a list of the files in the folder that is created for this job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobLogFile](imonitoringservice-getjoblogfile-method-microsoft-web-media-transformmanager.md)|Returns the instance log for a job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobManifest](imonitoringservice-getjobmanifest-method-microsoft-web-media-transformmanager.md)|Returns the job manifest that IIS Transform Manager created for a job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetRunningJobs](imonitoringservice-getrunningjobs-method-microsoft-web-media-transformmanager.md)|Returns a collection of all of the running jobs for all [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) objects.|

## Remarks

Local administrative group credentials must be used when using the IMonitoringService type. In addition, the calling application must use an elevated privilege.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

