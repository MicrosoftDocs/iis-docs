---
title: JobManager Class (Microsoft.Web.Media.TransformManager)
TOCTitle: JobManager Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.JobManager
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanager(v=VS.90)
ms:contentKeyID: 35520677
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# JobManager Class

Processes IIS Transform Manager jobs.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.TransformManager..::..JobManager  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PermissionSetAttribute(SecurityAction.Demand, Name := "FullTrust")> _
Public Class JobManager _
    Implements IDisposable
'Usage

  Dim instance As JobManager
```

```csharp
[PermissionSetAttribute(SecurityAction.Demand, Name = "FullTrust")]
public class JobManager : IDisposable
```

```cpp
[PermissionSetAttribute(SecurityAction::Demand, Name = L"FullTrust")]
public ref class JobManager : IDisposable
```

``` fsharp
[<PermissionSetAttribute(SecurityAction.Demand, Name = "FullTrust")>]
type JobManager =  
    class
        interface IDisposable
    end
```

```jscript
  public class JobManager implements IDisposable
```

The JobManager type exposes the following members.

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfiguringJobs](jobmanager-configuringjobs-property-microsoft-web-media-transformmanager.md)|Gets a collection of job details that specify jobs that are being configured.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[CredentialId](jobmanager-credentialid-property-microsoft-web-media-transformmanager.md)|Gets a GUID that identifies the credential that is associated with this job definition.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Enabled](jobmanager-enabled-property-microsoft-web-media-transformmanager.md)|Gets a value that indicates whether the job manager that is associated with this job definition can be started.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Id](jobmanager-id-property-microsoft-web-media-transformmanager.md)|Gets the XML element ID of the IIS Transform Manager configuration.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[InputFolderPath](jobmanager-inputfolderpath-property-microsoft-web-media-transformmanager.md)|Gets the input folder name.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[InputIsManifest](jobmanager-inputismanifest-property-microsoft-web-media-transformmanager.md)|Gets a value that indicates whether the file that initiates job creation is a SMIL 2.0-compliant manifest.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LastModified](jobmanager-lastmodified-property-microsoft-web-media-transformmanager.md)|Gets the date and time when the IIS Transform Manager configuration was last modified.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LocalFileWatcherFilter](jobmanager-localfilewatcherfilter-property-microsoft-web-media-transformmanager.md)|Gets a file filter value that is used to initiate job creation.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogLevel](jobmanager-loglevel-property-microsoft-web-media-transformmanager.md)|Gets a log level value that is contained in the log level element of the IIS Transform Manager configuration.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Name](jobmanager-name-property-microsoft-web-media-transformmanager.md)|Gets the XML element name of the IIS Transform Manager configuration.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[OutputFolderPath](jobmanager-outputfolderpath-property-microsoft-web-media-transformmanager.md)|Gets the output folder for a job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Priority](jobmanager-priority-property-microsoft-web-media-transformmanager.md)|Gets the priority of a job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[RunningJobs](jobmanager-runningjobs-property-microsoft-web-media-transformmanager.md)|Gets a collection of job details that specify jobs that are running.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[SchedulerId](jobmanager-schedulerid-property-microsoft-web-media-transformmanager.md)|Gets the ID of the scheduler that is associated with this job definition.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[SchedulerInfo](jobmanager-schedulerinfo-property-microsoft-web-media-transformmanager.md)|Gets scheduling information about the IIS Transform Manager job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[SubmittedJobs](jobmanager-submittedjobs-property-microsoft-web-media-transformmanager.md)|Gets a collection of job details that specify jobs that have been submitted.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Template](jobmanager-template-property-microsoft-web-media-transformmanager.md)|Gets the job template that defines the tasks for this job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TemplateId](jobmanager-templateid-property-microsoft-web-media-transformmanager.md)|Gets the ID of the job template that the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object uses.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[WatchFolder](jobmanager-watchfolder-property-microsoft-web-media-transformmanager.md)|Gets a file system folder that will be watched for files that instantiate jobs.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Dispose() () () ()](jobmanager-dispose-method-microsoft-web-media-transformmanager_1.md)|Releases all resources that are used by the current instance of the JobManager class.|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Dispose(Boolean)](jobmanager-dispose-method-boolean-microsoft-web-media-transformmanager.md)|Releases unmanaged resources and optionally releases managed resources.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[OnShutdownComplete](jobmanager-onshutdowncomplete-method-microsoft-web-media-transformmanager.md)|Raises the [ShutdownComplete](jobmanager-shutdowncomplete-event-microsoft-web-media-transformmanager.md) event.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Events

||Name|Description|
|--- |--- |--- |
|![Public event](images/Hh125579.pubevent(en-us,VS.90).gif "Public event")|[ShutdownComplete](jobmanager-shutdowncomplete-event-microsoft-web-media-transformmanager.md)|Occurs when all transform jobs have been processed.|

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
