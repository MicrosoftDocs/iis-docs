---
title: IManagementService Interface (Microsoft.Web.Media.TransformManager)
TOCTitle: IManagementService Interface
ms:assetid: T:Microsoft.Web.Media.TransformManager.IManagementService
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imanagementservice(v=VS.90)
ms:contentKeyID: 35520898
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IManagementService Interface

Represents an interface that defines how IIS Transform Manager manages jobs, tasks, and credentials that are related to a transform process.

Several IIS Transform Manager classes are used to define jobs, such as task definitions, job templates, job schedulers and job definitions. An administrator can create, update, and delete these objects.

Local administrator group credentials must be used when using the IManagementService type. In addition, the calling application must use an elevated privilege. The IManagementService and [IMonitoringService](imonitoringservice-interface-microsoft-web-media-transformmanager.md) interfaces are exposed through Windows Communication Foundation (WCF), which can require that the caller be a member of the administrators group. The interface uses this capability to secure calls to the service.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<ServiceContractAttribute(Namespace := "http://schemas.microsoft.com/iis/media/v4/TM/managementservice")> _
Public Interface IManagementService
'Usage

  Dim instance As IManagementService
```

```csharp
[ServiceContractAttribute(Namespace = "http://schemas.microsoft.com/iis/media/v4/TM/managementservice")]
public interface IManagementService
```

```cpp
[ServiceContractAttribute(Namespace = L"http://schemas.microsoft.com/iis/media/v4/TM/managementservice")]
public interface class IManagementService
```

``` fsharp
[<ServiceContractAttribute(Namespace = "http://schemas.microsoft.com/iis/media/v4/TM/managementservice")>]
type IManagementService =  interface end
```

```jscript
  public interface IManagementService
```

The IManagementService type exposes the following members.

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[DeleteCredential](imanagementservice-deletecredential-method-microsoft-web-media-transformmanager.md)|Deletes a [Credential](credential-class-microsoft-web-media-transformmanager.md) object for the service account from the Generic Credentials vault in Windows Credential Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[DeleteJobDefinition](imanagementservice-deletejobdefinition-method-microsoft-web-media-transformmanager.md)|Deletes a [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object from IIS Transform Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[DeleteJobScheduler](imanagementservice-deletejobscheduler-method-microsoft-web-media-transformmanager.md)|Deletes a [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) object from IIS Transform Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[DeleteJobTemplate](imanagementservice-deletejobtemplate-method-microsoft-web-media-transformmanager.md)|Deletes a [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) object from IIS Transform Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[DeleteTaskDefinition](imanagementservice-deletetaskdefinition-method-microsoft-web-media-transformmanager.md)|Deletes a [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) object from IIS Transform Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetConfigurationMessages](imanagementservice-getconfigurationmessages-method-microsoft-web-media-transformmanager.md)|Returns configuration messages that are related to the IIS Transform Manager service.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetCredential](imanagementservice-getcredential-method-microsoft-web-media-transformmanager.md)|Returns a [Credential](credential-class-microsoft-web-media-transformmanager.md) object for the service account from the Generic Credentials vault in Windows Credential Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetCredentials](imanagementservice-getcredentials-method-microsoft-web-media-transformmanager.md)|Returns all [Credential](credential-class-microsoft-web-media-transformmanager.md) objects for the service account from the Generic Credentials vault in Windows Credential Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobDefinition](imanagementservice-getjobdefinition-method-microsoft-web-media-transformmanager.md)|Returns a [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object that defines how IIS Transform Manager monitors, creates, schedules, and maintains jobs.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobDefinitions](imanagementservice-getjobdefinitions-method-microsoft-web-media-transformmanager.md)|Returns all [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) objects from IIS Transform Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobSchedulers](imanagementservice-getjobschedulers-method-microsoft-web-media-transformmanager.md)|Returns all [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) objects from IIS Transform Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetJobTemplates](imanagementservice-getjobtemplates-method-microsoft-web-media-transformmanager.md)|Returns all [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) objects from IIS Transform Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetTaskDefinitions](imanagementservice-gettaskdefinitions-method-microsoft-web-media-transformmanager.md)|Returns a list of [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) objects from IIS Transform Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[InitializeService](imanagementservice-initializeservice-method-microsoft-web-media-transformmanager.md)|Initializes the IIS Transform Manager service using the specified service credential.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[IsServiceInitialized](imanagementservice-isserviceinitialized-method-microsoft-web-media-transformmanager.md)|Determines whether the IIS Transform Manager service is initialized.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ResubmitJob](imanagementservice-resubmitjob-method-microsoft-web-media-transformmanager.md)|Moves a transform job to the configuring queue, where it will be resubmitted.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[StartJobManager](imanagementservice-startjobmanager-method-microsoft-web-media-transformmanager.md)|Enables jobs to be processed using a [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[StopJobManager](imanagementservice-stopjobmanager-method-microsoft-web-media-transformmanager.md)|Signals a [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object to stop.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SubmitJob](imanagementservice-submitjob-method-microsoft-web-media-transformmanager.md)|Submits a job to the IIS Transform Manager service.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[TestConnection](imanagementservice-testconnection-method-microsoft-web-media-transformmanager.md)|Tests connectivity of the IIS Transform Manager service to the [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[UpdateCredential](imanagementservice-updatecredential-method-microsoft-web-media-transformmanager.md)|Adds or replaces a [Credential](credential-class-microsoft-web-media-transformmanager.md) object for the service account from the Generic Credentials vault in Windows Credential Manager.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[UpdateJobDefinition](imanagementservice-updatejobdefinition-method-microsoft-web-media-transformmanager.md)|Adds or replaces a [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[UpdateJobScheduler](imanagementservice-updatejobscheduler-method-microsoft-web-media-transformmanager.md)|Adds or replaces a [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) object.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[UpdateJobTemplate](imanagementservice-updatejobtemplate-method-microsoft-web-media-transformmanager.md)|Adds or replaces a [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) object.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[UpdateTaskDefinition](imanagementservice-updatetaskdefinition-method-microsoft-web-media-transformmanager.md)|Adds or replaces a single task as defined in the job template.|

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

