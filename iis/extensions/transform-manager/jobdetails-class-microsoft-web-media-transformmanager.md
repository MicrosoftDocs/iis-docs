---
title: JobDetails Class (Microsoft.Web.Media.TransformManager)
TOCTitle: JobDetails Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.JobDetails
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails(v=VS.90)
ms:contentKeyID: 35520812
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# JobDetails Class

Provides details about an IIS Transform Manager job.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.TransformManager..::..JobDetails  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<SerializableAttribute> _
<DataContractAttribute> _
Public Class JobDetails
'Usage

  Dim instance As JobDetails
```

```csharp
[SerializableAttribute]
[DataContractAttribute]
public class JobDetails
```

```cpp
[SerializableAttribute]
[DataContractAttribute]
public ref class JobDetails
```

``` fsharp
[<SerializableAttribute>]
[<DataContractAttribute>]
type JobDetails =  class end
```

```jscript
  public class JobDetails
```

The JobDetails type exposes the following members.

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[EndTime](jobdetails-endtime-property-microsoft-web-media-transformmanager.md)|Gets or sets the time when the job ended.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Folder](jobdetails-folder-property-microsoft-web-media-transformmanager.md)|Gets or sets the root folder of the [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object that is processing the job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[InstanceFileName](jobdetails-instancefilename-property-microsoft-web-media-transformmanager.md)|Gets or sets the name of the file that matched the file watcher filter and that instantiated the job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[JobDefinitionId](jobdetails-jobdefinitionid-property-microsoft-web-media-transformmanager.md)|Gets or sets the ID of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object that created this job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[JobDefinitionName](jobdetails-jobdefinitionname-property-microsoft-web-media-transformmanager.md)|Gets or sets the name of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object that created this job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[JobName](jobdetails-jobname-property-microsoft-web-media-transformmanager.md)|Gets or set the name of this job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[JobSchedulerId](jobdetails-jobschedulerid-property-microsoft-web-media-transformmanager.md)|Gets or sets the ID of the [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) object that runs this job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[JobSchedulerName](jobdetails-jobschedulername-property-microsoft-web-media-transformmanager.md)|Gets or sets the name of the job scheduler that runs this job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[JobTemplateId](jobdetails-jobtemplateid-property-microsoft-web-media-transformmanager.md)|Gets or sets the ID of the job template that defines the tasks for this job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[JobTemplateName](jobdetails-jobtemplatename-property-microsoft-web-media-transformmanager.md)|Gets or sets the name of the job template that defines the tasks for this job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogFolder](jobdetails-logfolder-property-microsoft-web-media-transformmanager.md)||
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ManifestName](jobdetails-manifestname-property-microsoft-web-media-transformmanager.md)|Gets or sets the name of the manifest file that defines this job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Priority](jobdetails-priority-property-microsoft-web-media-transformmanager.md)|Gets or sets the priority of the job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Progress](jobdetails-progress-property-microsoft-web-media-transformmanager.md)|Gets or sets the percentage complete of the job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[QueueTime](jobdetails-queuetime-property-microsoft-web-media-transformmanager.md)|Gets or sets the date and time when the job was added to the work queue.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[StartTime](jobdetails-starttime-property-microsoft-web-media-transformmanager.md)|Gets or sets the date and time when the job was started by the scheduler.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Status](jobdetails-status-property-microsoft-web-media-transformmanager.md)|Gets or sets the status of the job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[StatusString](jobdetails-statusstring-property-microsoft-web-media-transformmanager.md)|Gets a string representation of the status.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[SubmitTime](jobdetails-submittime-property-microsoft-web-media-transformmanager.md)|Gets or sets the time that the job was submitted to the scheduler.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TaskCount](jobdetails-taskcount-property-microsoft-web-media-transformmanager.md)|Gets or sets the number of tasks that are in this job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TaskIndex](jobdetails-taskindex-property-microsoft-web-media-transformmanager.md)|Gets or sets the index of the current task.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[CreateWorkItem](jobdetails-createworkitem-method-microsoft-web-media-transformmanager.md)|Creates a JobDetails object that defines a work item based on the specified job manifest.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[CreateWorkItemElement](jobdetails-createworkitemelement-method-microsoft-web-media-transformmanager.md)|Creates an XML element based on the specified JobDetails object that defines a work item.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[CreateWorkItemFromXElement](jobdetails-createworkitemfromxelement-method-microsoft-web-media-transformmanager.md)|Creates a JobDetails object that defines a work item using the specified XML element.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ExpandJobDetailsElement](jobdetails-expandjobdetailselement-method-microsoft-web-media-transformmanager.md)|Creates an XML element from a JobDetails object that defines a work item.|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[GetJobDetailsAttribute](jobdetails-getjobdetailsattribute-method-microsoft-web-media-transformmanager.md)|Returns the attribute name of a JobDetails object.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[StatusFromString](jobdetails-statusfromstring-method-microsoft-web-media-transformmanager.md)|Returns a [JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md) object that corresponds to the specified status string.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Fields

||Name|Description|
|--- |--- |--- |
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsEndTime](jobdetails-jobdetailsendtime-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "endTime" field.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsFolder](jobdetails-jobdetailsfolder-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "folder" field.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsId](jobdetails-jobdetailsid-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "id" field.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsInstanceFileName](jobdetails-jobdetailsinstancefilename-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "instanceFileName" field.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsJobDefinitionId](jobdetails-jobdetailsjobdefinitionid-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "jobDefinitionId" field.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsJobName](jobdetails-jobdetailsjobname-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "jobName" field.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsJobTemplateId](jobdetails-jobdetailsjobtemplateid-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "jobTemplateId" field.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsLogFolder](jobdetails-jobdetailslogfolder-field-microsoft-web-media-transformmanager.md)||
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsManifestName](jobdetails-jobdetailsmanifestname-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "manifestName" field.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsPriority](jobdetails-jobdetailspriority-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "priority" field.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsProgress](jobdetails-jobdetailsprogress-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "progress" field.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsQueueTime](jobdetails-jobdetailsqueuetime-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "queueTime" field.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsRoot](jobdetails-jobdetailsroot-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "workItem" field.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsSchedulerId](jobdetails-jobdetailsschedulerid-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "jobSchedulerId" field.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsStartTime](jobdetails-jobdetailsstarttime-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "startTime" field.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsStatus](jobdetails-jobdetailsstatus-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "status" field.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsSubmitTime](jobdetails-jobdetailssubmittime-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "submitTime" field.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsTaskCount](jobdetails-jobdetailstaskcount-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "taskCount" field.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDetailsTaskIndex](jobdetails-jobdetailstaskindex-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when transform jobs are sorted by the "taskIndex" field.|

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

