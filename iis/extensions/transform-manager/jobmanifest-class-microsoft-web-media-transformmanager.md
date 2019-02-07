---
title: JobManifest Class (Microsoft.Web.Media.TransformManager)
TOCTitle: JobManifest Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.JobManifest
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest(v=VS.90)
ms:contentKeyID: 35521078
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobManifest Class

Provides capabilities to manipulate job-instance metadata.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.TransformManager..::..JobManifest  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration

  Public Class JobManifest _
    Implements IJobManifest
'Usage

  Dim instance As JobManifest
```

``` csharp
  public class JobManifest : IJobManifest
```

``` c++
  public ref class JobManifest : IJobManifest
```

``` fsharp
  type JobManifest =  
    class
        interface IJobManifest
    end
```

``` jscript
  public class JobManifest implements IJobManifest
```

The JobManifest type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[JobManifest](jobmanifest-constructor-microsoft-web-media-transformmanager.md)|Initializes a new instance of the JobManifest class.|


Top

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Arguments](jobmanifest-arguments-property-microsoft-web-media-transformmanager.md)|Gets executable program task arguments that are associated with the data in the manifest.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[FileName](jobmanifest-filename-property-microsoft-web-media-transformmanager.md)|Gets or sets the file name of the manifest.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Folder](jobmanifest-folder-property-microsoft-web-media-transformmanager.md)|Gets or sets the folder name of the manifest.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[FullFileName](jobmanifest-fullfilename-property-microsoft-web-media-transformmanager.md)|Gets the folder name and file name of the manifest.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[InputFileNames](jobmanifest-inputfilenames-property-microsoft-web-media-transformmanager.md)|Gets a collection of input file names for a job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[InstanceFileIsManifest](jobmanifest-instancefileismanifest-property-microsoft-web-media-transformmanager.md)|Gets a value that indicates whether the file that initiates job creation is a SMIL 2.0-compliant manifest.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[InstanceFileName](jobmanifest-instancefilename-property-microsoft-web-media-transformmanager.md)|Gets or sets the file name of the manifest instance.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[InstanceId](jobmanifest-instanceid-property-microsoft-web-media-transformmanager.md)|Gets or sets the ID of the manifest instance.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[JobDefinitionId](jobmanifest-jobdefinitionid-property-microsoft-web-media-transformmanager.md)|Gets the ID of the job definition.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[JobDefinitionName](jobmanifest-jobdefinitionname-property-microsoft-web-media-transformmanager.md)|Gets the name of the job definition from the job manifest.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[JobDetails](jobmanifest-jobdetails-property-microsoft-web-media-transformmanager.md)|Gets a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object that is based on details from the job manifest.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogFolder](jobmanifest-logfolder-property-microsoft-web-media-transformmanager.md)||
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ManifestAsString](jobmanifest-manifestasstring-property-microsoft-web-media-transformmanager.md)|Gets the manifest XML content.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Name](jobmanifest-name-property-microsoft-web-media-transformmanager.md)|Gets or sets the name of the job manifest.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Priority](jobmanifest-priority-property-microsoft-web-media-transformmanager.md)|Gets the priority of a job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ProcessPriority](jobmanifest-processpriority-property-microsoft-web-media-transformmanager.md)||
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Programs](jobmanifest-programs-property-microsoft-web-media-transformmanager.md)|Gets a collection of tasks that are executable program files.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[RawManifest](jobmanifest-rawmanifest-property-microsoft-web-media-transformmanager.md)|Gets the manifest XML content.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Status](jobmanifest-status-property-microsoft-web-media-transformmanager.md)|Gets or sets the status value from the manifest.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TaskIndex](jobmanifest-taskindex-property-microsoft-web-media-transformmanager.md)|Gets or sets the task index value from the task index element.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Template](jobmanifest-template-property-microsoft-web-media-transformmanager.md)|Gets an XML element that contains a set of sequential tasks that define a job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[WorkFolder](jobmanifest-workfolder-property-microsoft-web-media-transformmanager.md)||
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[WorkQueueRoot](jobmanifest-workqueueroot-property-microsoft-web-media-transformmanager.md)|Gets the root work folder name.|

Top

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[CreateManifest](jobmanifest-createmanifest-method-microsoft-web-media-transformmanager.md)|Creates a JobManifest object by using the job definition, the root work folder name, scheduling information about a job, tasks that define a job, shared properties, the name of the file that is used to create the manifest, and the ID of the manifest instance.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[FindJobElement](jobmanifest-findjobelement-method-microsoft-web-media-transformmanager.md)|Returns the XML job element from the manifest.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[GetInputFileNames](jobmanifest-getinputfilenames-method-microsoft-web-media-transformmanager.md)|Returns a collection of input file names.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[GetManifestElement](jobmanifest-getmanifestelement-method-microsoft-web-media-transformmanager.md)|Returns an XML representation of the manifest metadata.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetMetadataForTask](jobmanifest-getmetadatafortask-method-microsoft-web-media-transformmanager.md)|Returns the metadata for the specified task.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetScheduler](jobmanifest-getscheduler-method-microsoft-web-media-transformmanager.md)|Creates and returns a new [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetSchedulerInfo](jobmanifest-getschedulerinfo-method-microsoft-web-media-transformmanager.md)|Returns scheduling information about a job.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Initialize](jobmanifest-initialize-method-microsoft-web-media-transformmanager.md)|Initializes member variables for a manifest that is loaded from disk instead of created as part of job submission.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[LoadManifest](jobmanifest-loadmanifest-method-microsoft-web-media-transformmanager.md)|Loads the manifest file.|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Save](jobmanifest-save-method-microsoft-web-media-transformmanager.md)|Saves a job manifest file.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|

Top

## Fields

||Name|Description|
|--- |--- |--- |
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[ManifestExtension](jobmanifest-manifestextension-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used as the job manifest file extension (".smil").|


Top

## Remarks

The job manifest holds the information about a job instance. The job manifest is a .smil file that conforms to the Synchronized Multimedia Integration Language (SMIL). It contains a body section that lists all of the files that triggered the job. The job manifest also contains Resource Description Framework (RDF) metadata in a head section that describes the job definition, job scheduler, and job template. This metadata is combined with the input files to create the manifest for a job. The manifest constitutes the instructions that a scheduler requires in order to create, run, and report on the job.

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

