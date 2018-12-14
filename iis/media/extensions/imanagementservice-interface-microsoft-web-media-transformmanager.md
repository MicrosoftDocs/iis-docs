---
title: IManagementService Interface (Microsoft.Web.Media.TransformManager)
TOCTitle: IManagementService Interface
ms:assetid: T:Microsoft.Web.Media.TransformManager.IManagementService
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imanagementservice(v=VS.90)
ms:contentKeyID: 35520898
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IManagementService Interface

Represents an interface that defines how IIS Transform Manager manages jobs, tasks, and credentials that are related to a transform process.

Several IIS Transform Manager classes are used to define jobs, such as task definitions, job templates, job schedulers and job definitions. An administrator can create, update, and delete these objects.

Local administrator group credentials must be used when using the IManagementService type. In addition, the calling application must use an elevated privilege. The IManagementService and [IMonitoringService](imonitoringservice-interface-microsoft-web-media-transformmanager.md) interfaces are exposed through Windows Communication Foundation (WCF), which can require that the caller be a member of the administrators group. The interface uses this capability to secure calls to the service.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<ServiceContractAttribute(Namespace := "http://schemas.microsoft.com/iis/media/v4/TM/managementservice")> _
PublicInterfaceIManagementService
'Usage
DiminstanceAsIManagementService
```

``` csharp
[ServiceContractAttribute(Namespace = "http://schemas.microsoft.com/iis/media/v4/TM/managementservice")]
publicinterfaceIManagementService
```

``` c++
[ServiceContractAttribute(Namespace = L"http://schemas.microsoft.com/iis/media/v4/TM/managementservice")]
publicinterface classIManagementService
```

``` fsharp
[<ServiceContractAttribute(Namespace = "http://schemas.microsoft.com/iis/media/v4/TM/managementservice")>]
typeIManagementService =  interfaceend
```

``` jscript
publicinterface IManagementService
```

The IManagementService type exposes the following members.

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
<td><a href="imanagementservice-deletecredential-method-microsoft-web-media-transformmanager.md">DeleteCredential</a></td>
<td>Deletes a <a href="credential-class-microsoft-web-media-transformmanager.md">Credential</a> object for the service account from the Generic Credentials vault in Windows Credential Manager.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-deletejobdefinition-method-microsoft-web-media-transformmanager.md">DeleteJobDefinition</a></td>
<td>Deletes a <a href="jobdefinition-class-microsoft-web-media-transformmanager.md">JobDefinition</a> object from IIS Transform Manager.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-deletejobscheduler-method-microsoft-web-media-transformmanager.md">DeleteJobScheduler</a></td>
<td>Deletes a <a href="jobscheduler-class-microsoft-web-media-transformmanager.md">JobScheduler</a> object from IIS Transform Manager.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-deletejobtemplate-method-microsoft-web-media-transformmanager.md">DeleteJobTemplate</a></td>
<td>Deletes a <a href="jobtemplate-class-microsoft-web-media-transformmanager.md">JobTemplate</a> object from IIS Transform Manager.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-deletetaskdefinition-method-microsoft-web-media-transformmanager.md">DeleteTaskDefinition</a></td>
<td>Deletes a <a href="taskdefinition-class-microsoft-web-media-transformmanager.md">TaskDefinition</a> object from IIS Transform Manager.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-getconfigurationmessages-method-microsoft-web-media-transformmanager.md">GetConfigurationMessages</a></td>
<td>Returns configuration messages that are related to the IIS Transform Manager service.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-getcredential-method-microsoft-web-media-transformmanager.md">GetCredential</a></td>
<td>Returns a <a href="credential-class-microsoft-web-media-transformmanager.md">Credential</a> object for the service account from the Generic Credentials vault in Windows Credential Manager.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-getcredentials-method-microsoft-web-media-transformmanager.md">GetCredentials</a></td>
<td>Returns all <a href="credential-class-microsoft-web-media-transformmanager.md">Credential</a> objects for the service account from the Generic Credentials vault in Windows Credential Manager.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-getjobdefinition-method-microsoft-web-media-transformmanager.md">GetJobDefinition</a></td>
<td>Returns a <a href="jobdefinition-class-microsoft-web-media-transformmanager.md">JobDefinition</a> object that defines how IIS Transform Manager monitors, creates, schedules, and maintains jobs.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-getjobdefinitions-method-microsoft-web-media-transformmanager.md">GetJobDefinitions</a></td>
<td>Returns all <a href="jobdefinition-class-microsoft-web-media-transformmanager.md">JobDefinition</a> objects from IIS Transform Manager.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-getjobschedulers-method-microsoft-web-media-transformmanager.md">GetJobSchedulers</a></td>
<td>Returns all <a href="jobscheduler-class-microsoft-web-media-transformmanager.md">JobScheduler</a> objects from IIS Transform Manager.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-getjobtemplates-method-microsoft-web-media-transformmanager.md">GetJobTemplates</a></td>
<td>Returns all <a href="jobtemplate-class-microsoft-web-media-transformmanager.md">JobTemplate</a> objects from IIS Transform Manager.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-gettaskdefinitions-method-microsoft-web-media-transformmanager.md">GetTaskDefinitions</a></td>
<td>Returns a list of <a href="taskdefinition-class-microsoft-web-media-transformmanager.md">TaskDefinition</a> objects from IIS Transform Manager.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-initializeservice-method-microsoft-web-media-transformmanager.md">InitializeService</a></td>
<td>Initializes the IIS Transform Manager service using the specified service credential.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-isserviceinitialized-method-microsoft-web-media-transformmanager.md">IsServiceInitialized</a></td>
<td>Determines whether the IIS Transform Manager service is initialized.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-resubmitjob-method-microsoft-web-media-transformmanager.md">ResubmitJob</a></td>
<td>Moves a transform job to the configuring queue, where it will be resubmitted.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-startjobmanager-method-microsoft-web-media-transformmanager.md">StartJobManager</a></td>
<td>Enables jobs to be processed using a <a href="jobmanager-class-microsoft-web-media-transformmanager.md">JobManager</a> object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-stopjobmanager-method-microsoft-web-media-transformmanager.md">StopJobManager</a></td>
<td>Signals a <a href="jobmanager-class-microsoft-web-media-transformmanager.md">JobManager</a> object to stop.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-submitjob-method-microsoft-web-media-transformmanager.md">SubmitJob</a></td>
<td>Submits a job to the IIS Transform Manager service.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-testconnection-method-microsoft-web-media-transformmanager.md">TestConnection</a></td>
<td>Tests connectivity of the IIS Transform Manager service to the <a href="scheduler-class-microsoft-web-media-transformmanager.md">Scheduler</a> object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-updatecredential-method-microsoft-web-media-transformmanager.md">UpdateCredential</a></td>
<td>Adds or replaces a <a href="credential-class-microsoft-web-media-transformmanager.md">Credential</a> object for the service account from the Generic Credentials vault in Windows Credential Manager.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-updatejobdefinition-method-microsoft-web-media-transformmanager.md">UpdateJobDefinition</a></td>
<td>Adds or replaces a <a href="jobdefinition-class-microsoft-web-media-transformmanager.md">JobDefinition</a> object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-updatejobscheduler-method-microsoft-web-media-transformmanager.md">UpdateJobScheduler</a></td>
<td>Adds or replaces a <a href="jobscheduler-class-microsoft-web-media-transformmanager.md">JobScheduler</a> object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-updatejobtemplate-method-microsoft-web-media-transformmanager.md">UpdateJobTemplate</a></td>
<td>Adds or replaces a <a href="jobtemplate-class-microsoft-web-media-transformmanager.md">JobTemplate</a> object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="imanagementservice-updatetaskdefinition-method-microsoft-web-media-transformmanager.md">UpdateTaskDefinition</a></td>
<td>Adds or replaces a single task as defined in the job template.</td>
</tr>
</tbody>
</table>


Top

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

