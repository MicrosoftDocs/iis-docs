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
- csharp
- jscript
- vb
- FSharp
- cpp
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
---

# TransformManagerService Class

Provides control of on-demand media transformation services.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.TransformManager..::..TransformManagerService  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<ServiceBehaviorAttribute(InstanceContextMode := InstanceContextMode.Single, Namespace := "http://schemas.microsoft.com/iis/media/v4/TM")> _
Public Class TransformManagerService _
    Implements IManagementService, IMonitoringService
'Usage

  Dim instance As TransformManagerService
```

```csharp
[ServiceBehaviorAttribute(InstanceContextMode = InstanceContextMode.Single, Namespace = "http://schemas.microsoft.com/iis/media/v4/TM")]
public class TransformManagerService : IManagementService, 
    IMonitoringService
```

```cpp
[ServiceBehaviorAttribute(InstanceContextMode = InstanceContextMode::Single, Namespace = L"http://schemas.microsoft.com/iis/media/v4/TM")]
public ref class TransformManagerService : IManagementService, 
    IMonitoringService
```

``` fsharp
[<ServiceBehaviorAttribute(InstanceContextMode = InstanceContextMode.Single, Namespace = "http://schemas.microsoft.com/iis/media/v4/TM")>]
type TransformManagerService =  
    class
        interface IManagementService
        interface IMonitoringService
    end
```

```jscript
  public class TransformManagerService implements IManagementService, IMonitoringService
```

The TransformManagerService type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[TransformManagerService](transformmanagerservice-constructor-microsoft-web-media-transformmanager.md)|Initializes a new instance of the TransformManagerService class.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[CancelJob](transformmanagerservice-canceljob-method-microsoft-web-media-transformmanager.md)|Cancels a job that is represented by the specified job ID and work queue name.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[CancelJobById](transformmanagerservice-canceljobbyid-method-microsoft-web-media-transformmanager.md)|Cancels a job that is represented by the specified job ID.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[DeleteCredential](transformmanagerservice-deletecredential-method-microsoft-web-media-transformmanager.md)|Deletes a [Credential](credential-class-microsoft-web-media-transformmanager.md) object for the service account from the Generic Credentials vault in Windows Credential Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[DeleteJob](transformmanagerservice-deletejob-method-microsoft-web-media-transformmanager.md)|Deletes all input files, output files, and work item details for the specified job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[DeleteJobDefinition](transformmanagerservice-deletejobdefinition-method-microsoft-web-media-transformmanager.md)|Deletes a [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object from IIS Transform Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[DeleteJobScheduler](transformmanagerservice-deletejobscheduler-method-microsoft-web-media-transformmanager.md)|Deletes a [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) object from IIS Transform Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[DeleteJobTemplate](transformmanagerservice-deletejobtemplate-method-microsoft-web-media-transformmanager.md)|Deletes a [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) object from IIS Transform Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[DeleteTaskDefinition](transformmanagerservice-deletetaskdefinition-method-microsoft-web-media-transformmanager.md)|Deletes a [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) object from IIS Transform Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetConfigurationMessages](transformmanagerservice-getconfigurationmessages-method-microsoft-web-media-transformmanager.md)|Returns configuration messages that are related to the IIS Transform Manager service.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetCredential](transformmanagerservice-getcredential-method-microsoft-web-media-transformmanager.md)|Returns a [Credential](credential-class-microsoft-web-media-transformmanager.md) object from the credential store of the service account.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetCredentials](transformmanagerservice-getcredentials-method-microsoft-web-media-transformmanager.md)|Returns all of the [Credential](credential-class-microsoft-web-media-transformmanager.md) objects from the credential store of the service account.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetCumulativeJobCountByStatus](transformmanagerservice-getcumulativejobcountbystatus-method-microsoft-web-media-transformmanager.md)||
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobCountByStatus](transformmanagerservice-getjobcountbystatus-method-microsoft-web-media-transformmanager.md)|Returns the number of jobs in each job state.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobDefinition](transformmanagerservice-getjobdefinition-method-microsoft-web-media-transformmanager.md)|Returns a [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object that defines how IIS Transform Manager monitors, creates, schedules, and maintains jobs.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobDefinitions](transformmanagerservice-getjobdefinitions-method-microsoft-web-media-transformmanager.md)|Returns all of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) objects from IIS Transform Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobDetails](transformmanagerservice-getjobdetails-method-microsoft-web-media-transformmanager.md)|Returns a collection of job details based on the specified filter parameters.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobDetailsById](transformmanagerservice-getjobdetailsbyid-method-microsoft-web-media-transformmanager.md)|Returns a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object for the specified job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobDetailsByInstanceFileName](transformmanagerservice-getjobdetailsbyinstancefilename-method-microsoft-web-media-transformmanager.md)|Returns a collection of [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) objects based on the instance file name.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobFiles](transformmanagerservice-getjobfiles-method-microsoft-web-media-transformmanager.md)|Returns a list of the files in the folder that is created for the specified job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobLogFile](transformmanagerservice-getjoblogfile-method-microsoft-web-media-transformmanager.md)|Returns the instance log for the specified job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobManifest](transformmanagerservice-getjobmanifest-method-microsoft-web-media-transformmanager.md)|Returns the job manifest that IIS Transform Manager created for the specified job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobSchedulers](transformmanagerservice-getjobschedulers-method-microsoft-web-media-transformmanager.md)|Returns all [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) objects from IIS Transform Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobTemplates](transformmanagerservice-getjobtemplates-method-microsoft-web-media-transformmanager.md)|Returns all [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) objects from IIS Transform Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetRunningJobs](transformmanagerservice-getrunningjobs-method-microsoft-web-media-transformmanager.md)|Returns a collection of all of the running jobs for all [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) objects.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetTaskDefinitions](transformmanagerservice-gettaskdefinitions-method-microsoft-web-media-transformmanager.md)|Returns a list of [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) objects from IIS Transform Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[Initialize](transformmanagerservice-initialize-method-microsoft-web-media-transformmanager.md)|Initializes the transform manager service.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[InitializeService](transformmanagerservice-initializeservice-method-microsoft-web-media-transformmanager.md)|Initializes the IIS Transform Manager service using the specified service credential.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[IsServiceInitialized](transformmanagerservice-isserviceinitialized-method-microsoft-web-media-transformmanager.md)|Determines whether the IIS Transform Manager service is initialized.|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ResubmitJob](transformmanagerservice-resubmitjob-method-microsoft-web-media-transformmanager.md)|Moves a job to the configuring queue where it can be resubmitted.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[Shutdown](transformmanagerservice-shutdown-method-microsoft-web-media-transformmanager.md)|Shuts down the IIS Transform Manager service.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[StartJobManager](transformmanagerservice-startjobmanager-method-microsoft-web-media-transformmanager.md)|Enables jobs to be processed using a [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[StopJobManager](transformmanagerservice-stopjobmanager-method-microsoft-web-media-transformmanager.md)|Signals a [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object to stop.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SubmitJob](transformmanagerservice-submitjob-method-microsoft-web-media-transformmanager.md)|Submits a job to the IIS Transform Manager service.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[TestConnection](transformmanagerservice-testconnection-method-microsoft-web-media-transformmanager.md)|Tests connectivity of the IIS Transform Manager service to the [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[UpdateCredential](transformmanagerservice-updatecredential-method-microsoft-web-media-transformmanager.md)|Adds or replaces a [Credential](credential-class-microsoft-web-media-transformmanager.md) object that is in the credential store of the service account.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[UpdateJobDefinition](transformmanagerservice-updatejobdefinition-method-microsoft-web-media-transformmanager.md)|Adds or updates the specified [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[UpdateJobScheduler](transformmanagerservice-updatejobscheduler-method-microsoft-web-media-transformmanager.md)|Adds or updates the specified [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) object.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[UpdateJobTemplate](transformmanagerservice-updatejobtemplate-method-microsoft-web-media-transformmanager.md)|Adds or replaces a [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) object.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[UpdateTaskDefinition](transformmanagerservice-updatetaskdefinition-method-microsoft-web-media-transformmanager.md)|Adds or updates the specified [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) object.|

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

