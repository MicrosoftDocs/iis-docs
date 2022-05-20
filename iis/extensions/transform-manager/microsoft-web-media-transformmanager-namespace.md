---
title: Microsoft.Web.Media.TransformManager Namespace ()
description: Describes the Microsoft.Web.Media.Transform manager namespace and provides tables for classes, structures, interfaces, delegates, and enumerations.
TOCTitle: Microsoft.Web.Media.TransformManager
ms:assetid: N:Microsoft.Web.Media.TransformManager
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager(v=VS.90)
ms:contentKeyID: 31477622
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager
dev_langs:
- csharp
- jscript
- vb
- FSharp
---

# Microsoft.Web.Media.TransformManager Namespace

The IIS Transformation Manager Task API provides a set of interface and class definitions, located in the Microsoft.Web.Media.TransformManager.SDK assembly, the Microsoft.Web.Media.TransformManager.ServiceLibrary assembly, and the Microsoft.Web.Media.TransformManager.Common assembly. These interface and class definitions form the plug-in model for the IIS Transform Manager task engine.

## Classes

|Class Type|Class|Description|
|--- |--- |--- |
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md)|Provides a base class that represents IIS Transform Manager configuration information.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[ConfigurationMessage](configurationmessage-class-microsoft-web-media-transformmanager.md)|Represents messages that are initialized during IIS Transform Manager service initialization.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[Credential](credential-class-microsoft-web-media-transformmanager.md)|Provides credentials to run jobs and access resources.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[EventViewer](eventviewer-class-microsoft-web-media-transformmanager.md)|Provides event details that are written to an event viewer for an IIS Transform Manager job. The default event viewer is the Windows Event Viewer. This type supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[HpcScheduler](hpcscheduler-class-microsoft-web-media-transformmanager.md)|Manages IIS Transform Manager jobs that are run on a High Performance Computing (HPC) computer cluster.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[IisNamespaces](iisnamespaces-class-microsoft-web-media-transformmanager.md)|Provides the URIs of XML namespace schema documents.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md)|Defines how IIS Transform Manager monitors, creates, schedules, and maintains jobs.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)|Provides details about an IIS Transform Manager job.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[JobManager](jobmanager-class-microsoft-web-media-transformmanager.md)|Processes IIS Transform Manager jobs.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[JobManifest](jobmanifest-class-microsoft-web-media-transformmanager.md)|Provides capabilities to manipulate job-instance metadata.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[JobMetadata](jobmetadata-class-microsoft-web-media-transformmanager.md)|Defines an object that is passed to the task through the [Initialize(ITaskStatus, IJobMetadata, ILogger)](itask-initialize-method-microsoft-web-media-transformmanager.md) method of the [ITask](itask-interface-microsoft-web-media-transformmanager.md) class.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md)|Provides scheduling capabilities for incoming jobs.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md)|Represents a set of sequential tasks that define a job and that are used during the transform process.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[LocalScheduler](localscheduler-class-microsoft-web-media-transformmanager.md)|Schedules a new IIS Transform Manager job that runs on the local computer.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[Logger](logger-class-microsoft-web-media-transformmanager.md)|Provides access to task definition and job template properties.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[LogLevelHelper](loglevelhelper-class-microsoft-web-media-transformmanager.md)|Provides the level of detail for a log.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[ManifestPropertiesDictionary](manifestpropertiesdictionary-class-microsoft-web-media-transformmanager.md)|Provides properties that can be used for task definitions and job templates. This type supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)|Defines the manifest properties that contain task-specific metadata for task definitions, in job templates, and in tasks.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[Scheduler](scheduler-class-microsoft-web-media-transformmanager.md)|Schedules IIS Transform Manager jobs.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md)|Provides scheduling information about an IIS Transform Manager job.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[SchedulerProvider](schedulerprovider-class-microsoft-web-media-transformmanager.md)|Provides information about scheduled jobs.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md)|Represents a single task that defines a transformation process.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[TaskStatus](taskstatus-class-microsoft-web-media-transformmanager.md)|Provides a status callback mechanism for the task.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[TransformManagerService](transformmanagerservice-class-microsoft-web-media-transformmanager.md)|Provides control of on-demand media transformation services.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[Utilities](utilities-class-microsoft-web-media-transformmanager.md)|Provides a set of utility functions for IIS Transform Manager.|
|![Public class](images/Ff729529.pubclass(en-us,VS.90).gif "Public class")|[WorkQueue](workqueue-class-microsoft-web-media-transformmanager.md)|Provides status details for jobs.|

## Structures

|Structure Type|Structure|Description|
|--- |--- |--- |
|![Public structure](images/Ff729529.pubstructure(en-us,VS.90).gif "Public structure")|[TaskDetails](taskdetails-structure-microsoft-web-media-transformmanager.md)|Encapsulates task-related details.|

## Interfaces

|Interface Type|Interface|Description|
|--- |--- |--- |
|![Public interface](images/Ff729529.pubinterface(en-us,VS.90).gif "Public interface")|[IJobManifest](ijobmanifest-interface-microsoft-web-media-transformmanager.md)|Represents an interface that retrieves job scheduler information.|
|![Public interface](images/Ff729529.pubinterface(en-us,VS.90).gif "Public interface")|[IJobMetadata](ijobmetadata-interface-microsoft-web-media-transformmanager.md)|Represents an interface that defines an object that is passed to the task through the [Initialize(ITaskStatus, IJobMetadata, ILogger)](itask-initialize-method-microsoft-web-media-transformmanager.md) method of the [ITask](itask-interface-microsoft-web-media-transformmanager.md) class.|
|![Public interface](images/Ff729529.pubinterface(en-us,VS.90).gif "Public interface")|[ILogger](ilogger-interface-microsoft-web-media-transformmanager.md)|Defines a logger that can be used by the task to write data to the job-instance log.|
|![Public interface](images/Ff729529.pubinterface(en-us,VS.90).gif "Public interface")|[IManagementService](imanagementservice-interface-microsoft-web-media-transformmanager.md)|Represents an interface that defines how IIS Transform Manager manages jobs, tasks, and credentials that are related to a transform process.Several IIS Transform Manager classes are used to define jobs, such as task definitions, job templates, job schedulers and job definitions. An administrator can create, update, and delete these objects.Local administrator group credentials must be used when using the [IManagementService](imanagementservice-interface-microsoft-web-media-transformmanager.md) type. In addition, the calling application must use an elevated privilege. The [IManagementService](imanagementservice-interface-microsoft-web-media-transformmanager.md) and [IMonitoringService](imonitoringservice-interface-microsoft-web-media-transformmanager.md) interfaces are exposed through Windows Communication Foundation (WCF), which can require that the caller be a member of the administrators group. The interface uses this capability to secure calls to the service.|
|![Public interface](images/Ff729529.pubinterface(en-us,VS.90).gif "Public interface")|[IManifestProperty](imanifestproperty-interface-microsoft-web-media-transformmanager.md)|Defines the interface template for the definition of a manifest property that contains task-specific metadata.|
|![Public interface](images/Ff729529.pubinterface(en-us,VS.90).gif "Public interface")|[IMonitoringService](imonitoringservice-interface-microsoft-web-media-transformmanager.md)|Represents an interface that defines how the IIS Transform Manager monitors jobs that are related to a transform process.|
|![Public interface](images/Ff729529.pubinterface(en-us,VS.90).gif "Public interface")|[ITask](itask-interface-microsoft-web-media-transformmanager.md)|Defines a class as a transform task for use with the IIS Transform Manager framework.|
|![Public interface](images/Ff729529.pubinterface(en-us,VS.90).gif "Public interface")|[ITaskStatus](itaskstatus-interface-microsoft-web-media-transformmanager.md)|Defines an interface that is used to implement a status callback mechanism for the task.|

## Delegates

|Delegate Type|Delegate|Description|
|--- |--- |--- |
|![Public delegate](images/Ff729529.pubdelegate(en-us,VS.90).gif "Public delegate")|[JobManagerShutDownEventHandler](jobmanagershutdowneventhandler-delegate-microsoft-web-media-transformmanager.md)|Represents the method that handles the shutdown event for the job manager. This type supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|

## Enumerations

|Enumeration Type|Enumeration|Description|
|--- |--- |--- |
|![Public enumeration](images/Ff729529.pubenumeration(en-us,VS.90).gif "Public enumeration")|[ConfigurationMessageSeverity](configurationmessageseverity-enumeration-microsoft-web-media-transformmanager.md)|Specifies how to display IIS Transform Manager configuration messages.|
|![Public enumeration](images/Ff729529.pubenumeration(en-us,VS.90).gif "Public enumeration")|[JobDetailsField](jobdetailsfield-enumeration-microsoft-web-media-transformmanager.md)|Represents a value that is used to specify how job details are sorted and displayed.|
|![Public enumeration](images/Ff729529.pubenumeration(en-us,VS.90).gif "Public enumeration")|[JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)|Specifies status information about a job.|
|![Public enumeration](images/Ff729529.pubenumeration(en-us,VS.90).gif "Public enumeration")|[LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md)|Specifies the type of logging message to write to the log file.|
