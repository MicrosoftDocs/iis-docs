---
title: TransformManagerService Class (Microsoft.Web.Media.TransformManager)
TOCTitle: TransformManagerService Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.TransformManagerService
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice(v=VS.90)
ms:contentKeyID: 35521146
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TransformManagerService Class

Provides control of on-demand media transformation services.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.TransformManager..::..TransformManagerService  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<ServiceBehaviorAttribute(InstanceContextMode := InstanceContextMode.Single, Namespace := "http://schemas.microsoft.com/iis/media/v4/TM")> _
PublicClassTransformManagerService _
    ImplementsIManagementService, IMonitoringService
'Usage
DiminstanceAsTransformManagerService
```

``` csharp
[ServiceBehaviorAttribute(InstanceContextMode = InstanceContextMode.Single, Namespace = "http://schemas.microsoft.com/iis/media/v4/TM")]
publicclassTransformManagerService : IManagementService, 
    IMonitoringService
```

``` c++
[ServiceBehaviorAttribute(InstanceContextMode = InstanceContextMode::Single, Namespace = L"http://schemas.microsoft.com/iis/media/v4/TM")]
publicref classTransformManagerService : IManagementService, 
    IMonitoringService
```

``` fsharp
[<ServiceBehaviorAttribute(InstanceContextMode = InstanceContextMode.Single, Namespace = "http://schemas.microsoft.com/iis/media/v4/TM")>]
typeTransformManagerService =  
    classinterfaceIManagementServiceinterfaceIMonitoringServiceend
```

``` jscript
publicclass TransformManagerService implementsIManagementService, IMonitoringService
```

The TransformManagerService type exposes the following members.

## Constructors

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
<td><a href="transformmanagerservice-constructor-microsoft-web-media-transformmanager.md">TransformManagerService</a></td>
<td>Initializes a new instance of the TransformManagerService class.</td>
</tr>
</tbody>
</table>


Top

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
<td><a href="transformmanagerservice-canceljob-method-microsoft-web-media-transformmanager.md">CancelJob</a></td>
<td>Cancels a job that is represented by the specified job ID and work queue name.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-canceljobbyid-method-microsoft-web-media-transformmanager.md">CancelJobById</a></td>
<td>Cancels a job that is represented by the specified job ID.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-deletecredential-method-microsoft-web-media-transformmanager.md">DeleteCredential</a></td>
<td>Deletes a <a href="credential-class-microsoft-web-media-transformmanager.md">Credential</a> object for the service account from the Generic Credentials vault in Windows Credential Manager.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-deletejob-method-microsoft-web-media-transformmanager.md">DeleteJob</a></td>
<td>Deletes all input files, output files, and work item details for the specified job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-deletejobdefinition-method-microsoft-web-media-transformmanager.md">DeleteJobDefinition</a></td>
<td>Deletes a <a href="jobdefinition-class-microsoft-web-media-transformmanager.md">JobDefinition</a> object from IIS Transform Manager.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-deletejobscheduler-method-microsoft-web-media-transformmanager.md">DeleteJobScheduler</a></td>
<td>Deletes a <a href="jobscheduler-class-microsoft-web-media-transformmanager.md">JobScheduler</a> object from IIS Transform Manager.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-deletejobtemplate-method-microsoft-web-media-transformmanager.md">DeleteJobTemplate</a></td>
<td>Deletes a <a href="jobtemplate-class-microsoft-web-media-transformmanager.md">JobTemplate</a> object from IIS Transform Manager.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-deletetaskdefinition-method-microsoft-web-media-transformmanager.md">DeleteTaskDefinition</a></td>
<td>Deletes a <a href="taskdefinition-class-microsoft-web-media-transformmanager.md">TaskDefinition</a> object from IIS Transform Manager.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-getconfigurationmessages-method-microsoft-web-media-transformmanager.md">GetConfigurationMessages</a></td>
<td>Returns configuration messages that are related to the IIS Transform Manager service.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-getcredential-method-microsoft-web-media-transformmanager.md">GetCredential</a></td>
<td>Returns a <a href="credential-class-microsoft-web-media-transformmanager.md">Credential</a> object from the credential store of the service account.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-getcredentials-method-microsoft-web-media-transformmanager.md">GetCredentials</a></td>
<td>Returns all of the <a href="credential-class-microsoft-web-media-transformmanager.md">Credential</a> objects from the credential store of the service account.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-getcumulativejobcountbystatus-method-microsoft-web-media-transformmanager.md">GetCumulativeJobCountByStatus</a></td>
<td></td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-getjobcountbystatus-method-microsoft-web-media-transformmanager.md">GetJobCountByStatus</a></td>
<td>Returns the number of jobs in each job state.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-getjobdefinition-method-microsoft-web-media-transformmanager.md">GetJobDefinition</a></td>
<td>Returns a <a href="jobdefinition-class-microsoft-web-media-transformmanager.md">JobDefinition</a> object that defines how IIS Transform Manager monitors, creates, schedules, and maintains jobs.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-getjobdefinitions-method-microsoft-web-media-transformmanager.md">GetJobDefinitions</a></td>
<td>Returns all of the <a href="jobdefinition-class-microsoft-web-media-transformmanager.md">JobDefinition</a> objects from IIS Transform Manager.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-getjobdetails-method-microsoft-web-media-transformmanager.md">GetJobDetails</a></td>
<td>Returns a collection of job details based on the specified filter parameters.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-getjobdetailsbyid-method-microsoft-web-media-transformmanager.md">GetJobDetailsById</a></td>
<td>Returns a <a href="jobdetails-class-microsoft-web-media-transformmanager.md">JobDetails</a> object for the specified job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-getjobdetailsbyinstancefilename-method-microsoft-web-media-transformmanager.md">GetJobDetailsByInstanceFileName</a></td>
<td>Returns a collection of <a href="jobdetails-class-microsoft-web-media-transformmanager.md">JobDetails</a> objects based on the instance file name.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-getjobfiles-method-microsoft-web-media-transformmanager.md">GetJobFiles</a></td>
<td>Returns a list of the files in the folder that is created for the specified job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-getjoblogfile-method-microsoft-web-media-transformmanager.md">GetJobLogFile</a></td>
<td>Returns the instance log for the specified job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-getjobmanifest-method-microsoft-web-media-transformmanager.md">GetJobManifest</a></td>
<td>Returns the job manifest that IIS Transform Manager created for the specified job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-getjobschedulers-method-microsoft-web-media-transformmanager.md">GetJobSchedulers</a></td>
<td>Returns all <a href="jobscheduler-class-microsoft-web-media-transformmanager.md">JobScheduler</a> objects from IIS Transform Manager.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-getjobtemplates-method-microsoft-web-media-transformmanager.md">GetJobTemplates</a></td>
<td>Returns all <a href="jobtemplate-class-microsoft-web-media-transformmanager.md">JobTemplate</a> objects from IIS Transform Manager.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-getrunningjobs-method-microsoft-web-media-transformmanager.md">GetRunningJobs</a></td>
<td>Returns a collection of all of the running jobs for all <a href="jobdefinition-class-microsoft-web-media-transformmanager.md">JobDefinition</a> objects.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-gettaskdefinitions-method-microsoft-web-media-transformmanager.md">GetTaskDefinitions</a></td>
<td>Returns a list of <a href="taskdefinition-class-microsoft-web-media-transformmanager.md">TaskDefinition</a> objects from IIS Transform Manager.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="transformmanagerservice-initialize-method-microsoft-web-media-transformmanager.md">Initialize</a></td>
<td>Initializes the transform manager service.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-initializeservice-method-microsoft-web-media-transformmanager.md">InitializeService</a></td>
<td>Initializes the IIS Transform Manager service using the specified service credential.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-isserviceinitialized-method-microsoft-web-media-transformmanager.md">IsServiceInitialized</a></td>
<td>Determines whether the IIS Transform Manager service is initialized.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-resubmitjob-method-microsoft-web-media-transformmanager.md">ResubmitJob</a></td>
<td>Moves a job to the configuring queue where it can be resubmitted.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="transformmanagerservice-shutdown-method-microsoft-web-media-transformmanager.md">Shutdown</a></td>
<td>Shuts down the IIS Transform Manager service.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-startjobmanager-method-microsoft-web-media-transformmanager.md">StartJobManager</a></td>
<td>Enables jobs to be processed using a <a href="jobmanager-class-microsoft-web-media-transformmanager.md">JobManager</a> object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-stopjobmanager-method-microsoft-web-media-transformmanager.md">StopJobManager</a></td>
<td>Signals a <a href="jobmanager-class-microsoft-web-media-transformmanager.md">JobManager</a> object to stop.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-submitjob-method-microsoft-web-media-transformmanager.md">SubmitJob</a></td>
<td>Submits a job to the IIS Transform Manager service.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-testconnection-method-microsoft-web-media-transformmanager.md">TestConnection</a></td>
<td>Tests connectivity of the IIS Transform Manager service to the <a href="scheduler-class-microsoft-web-media-transformmanager.md">Scheduler</a> object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-updatecredential-method-microsoft-web-media-transformmanager.md">UpdateCredential</a></td>
<td>Adds or replaces a <a href="credential-class-microsoft-web-media-transformmanager.md">Credential</a> object that is in the credential store of the service account.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-updatejobdefinition-method-microsoft-web-media-transformmanager.md">UpdateJobDefinition</a></td>
<td>Adds or updates the specified <a href="jobdefinition-class-microsoft-web-media-transformmanager.md">JobDefinition</a> object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-updatejobscheduler-method-microsoft-web-media-transformmanager.md">UpdateJobScheduler</a></td>
<td>Adds or updates the specified <a href="jobscheduler-class-microsoft-web-media-transformmanager.md">JobScheduler</a> object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-updatejobtemplate-method-microsoft-web-media-transformmanager.md">UpdateJobTemplate</a></td>
<td>Adds or replaces a <a href="jobtemplate-class-microsoft-web-media-transformmanager.md">JobTemplate</a> object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="transformmanagerservice-updatetaskdefinition-method-microsoft-web-media-transformmanager.md">UpdateTaskDefinition</a></td>
<td>Adds or updates the specified <a href="taskdefinition-class-microsoft-web-media-transformmanager.md">TaskDefinition</a> object.</td>
</tr>
</tbody>
</table>


Top

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

