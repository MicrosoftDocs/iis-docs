---
title: JobMetadata Class (Microsoft.Web.Media.TransformManager)
TOCTitle: JobMetadata Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.JobMetadata
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmetadata(v=VS.90)
ms:contentKeyID: 35520790
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobMetadata Class

Defines an object that is passed to the task through the [Initialize(ITaskStatus, IJobMetadata, ILogger)](itask-initialize-method-microsoft-web-media-transformmanager.md) method of the [ITask](itask-interface-microsoft-web-media-transformmanager.md) class.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.TransformManager..::..JobMetadata  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration

  Public Class JobMetadata _
    Implements IJobMetadata
'Usage

  Dim instance As JobMetadata
```

``` csharp
  public class JobMetadata : IJobMetadata
```

``` c++
  public ref class JobMetadata : IJobMetadata
```

``` fsharp
  type JobMetadata =  
    class
        interface IJobMetadata
    end
```

``` jscript
  public class JobMetadata implements IJobMetadata
```

The JobMetadata type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[JobMetadata](jobmetadata-constructor-microsoft-web-media-transformmanager.md)|Initializes a new instance of the JobMetadata class by using the specified manifest and task index.|


Top

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[InputFolder](jobmetadata-inputfolder-property-microsoft-web-media-transformmanager.md)|Gets the name of the input folder for the job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[InstanceFileIsManifest](jobmetadata-instancefileismanifest-property-microsoft-web-media-transformmanager.md)|Gets a value that indicates whether the instance file is a manifest file.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[InstanceFileName](jobmetadata-instancefilename-property-microsoft-web-media-transformmanager.md)|Gets the instance file name.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[JobManifest](jobmetadata-jobmanifest-property-microsoft-web-media-transformmanager.md)|Gets the job-specific metadata from the [JobManifest](jobmanifest-class-microsoft-web-media-transformmanager.md) object.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Manifest](jobmetadata-manifest-property-microsoft-web-media-transformmanager.md)|Gets the manifest metadata from the synchronized multimedia interface language (SMIL) manifest.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[OutputFolder](jobmetadata-outputfolder-property-microsoft-web-media-transformmanager.md)|Gets the name of the output folder for completed jobs.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ProcessPriority](jobmetadata-processpriority-property-microsoft-web-media-transformmanager.md)||
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Status](jobmetadata-status-property-microsoft-web-media-transformmanager.md)|Gets or sets the status of an ongoing transform.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[SuccessCodes](jobmetadata-successcodes-property-microsoft-web-media-transformmanager.md)|Gets the success codes from the task element that is contained in the manifest.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TaskCode](jobmetadata-taskcode-property-microsoft-web-media-transformmanager.md)|Gets the task code from the task element that is contained in the manifest.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TaskElement](jobmetadata-taskelement-property-microsoft-web-media-transformmanager.md)|Gets the task element from the manifest.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TaskMetadata](jobmetadata-taskmetadata-property-microsoft-web-media-transformmanager.md)|Gets the task metadata from the task element that is contained in the manifest.|

Top

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetProperty](jobmetadata-getproperty-method-microsoft-web-media-transformmanager.md)|Returns the value of the specified property from the task resource description framework (RDF) metadata section in the manifest.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetProperty](jobmetadata-setproperty-method-microsoft-web-media-transformmanager.md)|Sets a property value in the task resource description framework (RDF) metadata section in the manifest.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|

Top

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

