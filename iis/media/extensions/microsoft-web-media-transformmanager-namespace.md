---
title: Microsoft.Web.Media.TransformManager Namespace ()
TOCTitle: Microsoft.Web.Media.TransformManager
ms:assetid: N:Microsoft.Web.Media.TransformManager
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager(v=VS.90)
ms:contentKeyID: 31477622
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager
dev_langs:
- CSharp
- JScript
- VB
- FSharp
---

# Microsoft.Web.Media.TransformManager Namespace

The IIS Transformation Manager Task API provides a set of interface and class definitions, located in the Microsoft.Web.Media.TransformManager.SDK assembly, the Microsoft.Web.Media.TransformManager.ServiceLibrary assembly, and the Microsoft.Web.Media.TransformManager.Common assembly. These interface and class definitions form the plug-in model for the IIS Transform Manager task engine.

## Classes

<table>
<thead>
<tr class="header">
<th> </th>
<th>Class</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a></td>
<td>Provides a base class that represents IIS Transform Manager configuration information.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="configurationmessage-class-microsoft-web-media-transformmanager.md">ConfigurationMessage</a></td>
<td>Represents messages that are initialized during IIS Transform Manager service initialization.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="credential-class-microsoft-web-media-transformmanager.md">Credential</a></td>
<td>Provides credentials to run jobs and access resources.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="eventviewer-class-microsoft-web-media-transformmanager.md">EventViewer</a></td>
<td>Provides event details that are written to an event viewer for an IIS Transform Manager job. The default event viewer is the Windows Event Viewer. This type supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="hpcscheduler-class-microsoft-web-media-transformmanager.md">HpcScheduler</a></td>
<td>Manages IIS Transform Manager jobs that are run on a High Performance Computing (HPC) computer cluster.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="iisnamespaces-class-microsoft-web-media-transformmanager.md">IisNamespaces</a></td>
<td>Provides the URIs of XML namespace schema documents.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="jobdefinition-class-microsoft-web-media-transformmanager.md">JobDefinition</a></td>
<td>Defines how IIS Transform Manager monitors, creates, schedules, and maintains jobs.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="jobdetails-class-microsoft-web-media-transformmanager.md">JobDetails</a></td>
<td>Provides details about an IIS Transform Manager job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="jobmanager-class-microsoft-web-media-transformmanager.md">JobManager</a></td>
<td>Processes IIS Transform Manager jobs.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="jobmanifest-class-microsoft-web-media-transformmanager.md">JobManifest</a></td>
<td>Provides capabilities to manipulate job-instance metadata.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="jobmetadata-class-microsoft-web-media-transformmanager.md">JobMetadata</a></td>
<td>Defines an object that is passed to the task through the <a href="itask-initialize-method-microsoft-web-media-transformmanager.md">Initialize(ITaskStatus, IJobMetadata, ILogger)</a> method of the <a href="itask-interface-microsoft-web-media-transformmanager.md">ITask</a> class.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="jobscheduler-class-microsoft-web-media-transformmanager.md">JobScheduler</a></td>
<td>Provides scheduling capabilities for incoming jobs.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="jobtemplate-class-microsoft-web-media-transformmanager.md">JobTemplate</a></td>
<td>Represents a set of sequential tasks that define a job and that are used during the transform process.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="localscheduler-class-microsoft-web-media-transformmanager.md">LocalScheduler</a></td>
<td>Schedules a new IIS Transform Manager job that runs on the local computer.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="logger-class-microsoft-web-media-transformmanager.md">Logger</a></td>
<td>Provides access to task definition and job template properties.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="loglevelhelper-class-microsoft-web-media-transformmanager.md">LogLevelHelper</a></td>
<td>Provides the level of detail for a log.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="manifestpropertiesdictionary-class-microsoft-web-media-transformmanager.md">ManifestPropertiesDictionary</a></td>
<td>Provides properties that can be used for task definitions and job templates. This type supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a></td>
<td>Defines the manifest properties that contain task-specific metadata for task definitions, in job templates, and in tasks.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="scheduler-class-microsoft-web-media-transformmanager.md">Scheduler</a></td>
<td>Schedules IIS Transform Manager jobs.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="schedulerinfo-class-microsoft-web-media-transformmanager.md">SchedulerInfo</a></td>
<td>Provides scheduling information about an IIS Transform Manager job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="schedulerprovider-class-microsoft-web-media-transformmanager.md">SchedulerProvider</a></td>
<td>Provides information about scheduled jobs.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="taskdefinition-class-microsoft-web-media-transformmanager.md">TaskDefinition</a></td>
<td>Represents a single task that defines a transformation process.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="taskstatus-class-microsoft-web-media-transformmanager.md">TaskStatus</a></td>
<td>Provides a status callback mechanism for the task.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="transformmanagerservice-class-microsoft-web-media-transformmanager.md">TransformManagerService</a></td>
<td>Provides control of on-demand media transformation services.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="utilities-class-microsoft-web-media-transformmanager.md">Utilities</a></td>
<td>Provides a set of utility functions for IIS Transform Manager.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubclass(en-us,VS.90).gif" title="Public class" alt="Public class" /></td>
<td><a href="workqueue-class-microsoft-web-media-transformmanager.md">WorkQueue</a></td>
<td>Provides status details for jobs.</td>
</tr>
</tbody>
</table>


## Structures

<table>
<thead>
<tr class="header">
<th> </th>
<th>Structure</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Ff729529.pubstructure(en-us,VS.90).gif" title="Public structure" alt="Public structure" /></td>
<td><a href="taskdetails-structure-microsoft-web-media-transformmanager.md">TaskDetails</a></td>
<td>Encapsulates task-related details.</td>
</tr>
</tbody>
</table>


## Interfaces

<table>
<thead>
<tr class="header">
<th> </th>
<th>Interface</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Public interface" alt="Public interface" /></td>
<td><a href="ijobmanifest-interface-microsoft-web-media-transformmanager.md">IJobManifest</a></td>
<td>Represents an interface that retrieves job scheduler information.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Public interface" alt="Public interface" /></td>
<td><a href="ijobmetadata-interface-microsoft-web-media-transformmanager.md">IJobMetadata</a></td>
<td>Represents an interface that defines an object that is passed to the task through the <a href="itask-initialize-method-microsoft-web-media-transformmanager.md">Initialize(ITaskStatus, IJobMetadata, ILogger)</a> method of the <a href="itask-interface-microsoft-web-media-transformmanager.md">ITask</a> class.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Public interface" alt="Public interface" /></td>
<td><a href="ilogger-interface-microsoft-web-media-transformmanager.md">ILogger</a></td>
<td>Defines a logger that can be used by the task to write data to the job-instance log.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Public interface" alt="Public interface" /></td>
<td><a href="imanagementservice-interface-microsoft-web-media-transformmanager.md">IManagementService</a></td>
<td>Represents an interface that defines how IIS Transform Manager manages jobs, tasks, and credentials that are related to a transform process.Several IIS Transform Manager classes are used to define jobs, such as task definitions, job templates, job schedulers and job definitions. An administrator can create, update, and delete these objects.Local administrator group credentials must be used when using the <a href="imanagementservice-interface-microsoft-web-media-transformmanager.md">IManagementService</a> type. In addition, the calling application must use an elevated privilege. The <a href="imanagementservice-interface-microsoft-web-media-transformmanager.md">IManagementService</a> and <a href="imonitoringservice-interface-microsoft-web-media-transformmanager.md">IMonitoringService</a> interfaces are exposed through Windows Communication Foundation (WCF), which can require that the caller be a member of the administrators group. The interface uses this capability to secure calls to the service.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Public interface" alt="Public interface" /></td>
<td><a href="imanifestproperty-interface-microsoft-web-media-transformmanager.md">IManifestProperty</a></td>
<td>Defines the interface template for the definition of a manifest property that contains task-specific metadata.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Public interface" alt="Public interface" /></td>
<td><a href="imonitoringservice-interface-microsoft-web-media-transformmanager.md">IMonitoringService</a></td>
<td>Represents an interface that defines how the IIS Transform Manager monitors jobs that are related to a transform process.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Public interface" alt="Public interface" /></td>
<td><a href="itask-interface-microsoft-web-media-transformmanager.md">ITask</a></td>
<td>Defines a class as a transform task for use with the IIS Transform Manager framework.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Public interface" alt="Public interface" /></td>
<td><a href="itaskstatus-interface-microsoft-web-media-transformmanager.md">ITaskStatus</a></td>
<td>Defines an interface that is used to implement a status callback mechanism for the task.</td>
</tr>
</tbody>
</table>


## Delegates

<table>
<thead>
<tr class="header">
<th> </th>
<th>Delegate</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Ee532718.pubdelegate(en-us,VS.90).gif" title="Public delegate" alt="Public delegate" /></td>
<td><a href="jobmanagershutdowneventhandler-delegate-microsoft-web-media-transformmanager.md">JobManagerShutDownEventHandler</a></td>
<td>Represents the method that handles the shutdown event for the job manager. This type supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
</tbody>
</table>


## Enumerations

<table>
<thead>
<tr class="header">
<th> </th>
<th>Enumeration</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd566080.pubenumeration(en-us,VS.90).gif" title="Public enumeration" alt="Public enumeration" /></td>
<td><a href="configurationmessageseverity-enumeration-microsoft-web-media-transformmanager.md">ConfigurationMessageSeverity</a></td>
<td>Specifies how to display IIS Transform Manager configuration messages.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubenumeration(en-us,VS.90).gif" title="Public enumeration" alt="Public enumeration" /></td>
<td><a href="jobdetailsfield-enumeration-microsoft-web-media-transformmanager.md">JobDetailsField</a></td>
<td>Represents a value that is used to specify how job details are sorted and displayed.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubenumeration(en-us,VS.90).gif" title="Public enumeration" alt="Public enumeration" /></td>
<td><a href="jobstatus-enumeration-microsoft-web-media-transformmanager.md">JobStatus</a></td>
<td>Specifies status information about a job.</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubenumeration(en-us,VS.90).gif" title="Public enumeration" alt="Public enumeration" /></td>
<td><a href="loglevel-enumeration-microsoft-web-media-transformmanager.md">LogLevel</a></td>
<td>Specifies the type of logging message to write to the log file.</td>
</tr>
</tbody>
</table>

