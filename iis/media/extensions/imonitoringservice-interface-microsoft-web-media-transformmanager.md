---
title: IMonitoringService Interface (Microsoft.Web.Media.TransformManager)
TOCTitle: IMonitoringService Interface
ms:assetid: T:Microsoft.Web.Media.TransformManager.IMonitoringService
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imonitoringservice(v=VS.90)
ms:contentKeyID: 35521044
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IMonitoringService
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IMonitoringService
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IMonitoringService Interface

Represents an interface that defines how the IIS Transform Manager monitors jobs that are related to a transform process.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<ServiceContractAttribute(Namespace := "http://schemas.microsoft.com/iis/media/v4/TM/monitoringservice")> _
PublicInterfaceIMonitoringService
'Usage
DiminstanceAsIMonitoringService
```

``` csharp
[ServiceContractAttribute(Namespace = "http://schemas.microsoft.com/iis/media/v4/TM/monitoringservice")]
publicinterfaceIMonitoringService
```

``` c++
[ServiceContractAttribute(Namespace = L"http://schemas.microsoft.com/iis/media/v4/TM/monitoringservice")]
publicinterface classIMonitoringService
```

``` fsharp
[<ServiceContractAttribute(Namespace = "http://schemas.microsoft.com/iis/media/v4/TM/monitoringservice")>]
typeIMonitoringService =  interfaceend
```

``` jscript
publicinterface IMonitoringService
```

The IMonitoringService type exposes the following members.

## Methods

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imonitoringservice-canceljob-method-microsoft-web-media-transformmanager.md">CancelJob</a></td>
<td>Cancels a job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imonitoringservice-canceljobbyid-method-microsoft-web-media-transformmanager.md">CancelJobById</a></td>
<td>Cancels a job that is represented by the specified job ID.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imonitoringservice-deletejob-method-microsoft-web-media-transformmanager.md">DeleteJob</a></td>
<td>Deletes all input files, output files, and work item details of a job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imonitoringservice-getcumulativejobcountbystatus-method-microsoft-web-media-transformmanager.md">GetCumulativeJobCountByStatus</a></td>
<td></td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imonitoringservice-getjobcountbystatus-method-microsoft-web-media-transformmanager.md">GetJobCountByStatus</a></td>
<td>Returns the number of jobs in each job state.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imonitoringservice-getjobdetails-method-microsoft-web-media-transformmanager.md">GetJobDetails</a></td>
<td>Returns a collection of job details based on the specified filter parameters.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imonitoringservice-getjobdetailsbyid-method-microsoft-web-media-transformmanager.md">GetJobDetailsById</a></td>
<td>Returns a <a href="jobdetails-class-microsoft-web-media-transformmanager.md">JobDetails</a> object for a job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imonitoringservice-getjobdetailsbyinstancefilename-method-microsoft-web-media-transformmanager.md">GetJobDetailsByInstanceFileName</a></td>
<td>Returns a collection of <a href="jobdetails-class-microsoft-web-media-transformmanager.md">JobDetails</a> objects based on the instance file name.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imonitoringservice-getjobfiles-method-microsoft-web-media-transformmanager.md">GetJobFiles</a></td>
<td>Returns a list of the files in the folder that is created for this job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imonitoringservice-getjoblogfile-method-microsoft-web-media-transformmanager.md">GetJobLogFile</a></td>
<td>Returns the instance log for a job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imonitoringservice-getjobmanifest-method-microsoft-web-media-transformmanager.md">GetJobManifest</a></td>
<td>Returns the job manifest that IIS Transform Manager created for a job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imonitoringservice-getrunningjobs-method-microsoft-web-media-transformmanager.md">GetRunningJobs</a></td>
<td>Returns a collection of all of the running jobs for all <a href="jobdefinition-class-microsoft-web-media-transformmanager.md">JobDefinition</a> objects.</td>
</tr>
</tbody>
</table>


Top

## Remarks

Local administrative group credentials must be used when using the IMonitoringService type. In addition, the calling application must use an elevated privilege.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

