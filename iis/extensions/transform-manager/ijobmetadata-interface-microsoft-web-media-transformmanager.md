---
title: IJobMetadata Interface (Microsoft.Web.Media.TransformManager)
TOCTitle: IJobMetadata Interface
ms:assetid: T:Microsoft.Web.Media.TransformManager.IJobMetadata
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.ijobmetadata(v=VS.90)
ms:contentKeyID: 35520802
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobMetadata
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobMetadata
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IJobMetadata Interface

Represents an interface that defines an object that is passed to the task through the [Initialize(ITaskStatus, IJobMetadata, ILogger)](itask-initialize-method-microsoft-web-media-transformmanager.md) method of the [ITask](itask-interface-microsoft-web-media-transformmanager.md) class.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public Interface IJobMetadata
'Usage

  Dim instance As IJobMetadata
```

```csharp
  public interface IJobMetadata
```

```cpp
  public interface class IJobMetadata
```

``` fsharp
  type IJobMetadata =  interface end
```

```jscript
  public interface IJobMetadata
```

The IJobMetadata type exposes the following members.

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[InputFolder](ijobmetadata-inputfolder-property-microsoft-web-media-transformmanager.md)|Gets the name of the input folder for the job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[InstanceFileIsManifest](ijobmetadata-instancefileismanifest-property-microsoft-web-media-transformmanager.md)|Gets a value that indicates whether the instance file is a manifest file.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[InstanceFileName](ijobmetadata-instancefilename-property-microsoft-web-media-transformmanager.md)|Gets the instance file name.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Manifest](ijobmetadata-manifest-property-microsoft-web-media-transformmanager.md)|Gets the full job manifest from the synchronized multimedia interface language (SMIL) manifest.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[OutputFolder](ijobmetadata-outputfolder-property-microsoft-web-media-transformmanager.md)|Gets the name of the output folder for completed jobs.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ProcessPriority](ijobmetadata-processpriority-property-microsoft-web-media-transformmanager.md)||
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Status](ijobmetadata-status-property-microsoft-web-media-transformmanager.md)|Gets or sets the status of an ongoing transform.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TaskElement](ijobmetadata-taskelement-property-microsoft-web-media-transformmanager.md)|Gets the task element from the manifest.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetProperty](ijobmetadata-getproperty-method-microsoft-web-media-transformmanager.md)|Returns the value of the specified property from the task resource description framework (RDF) metadata section in the manifest.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[SetProperty](ijobmetadata-setproperty-method-microsoft-web-media-transformmanager.md)|Sets a property value in the task resource description framework (RDF) metadata section in the manifest.|


## Remarks

This object contains the metadata that is required by the task. The [SetProperty(IManifestProperty)](ijobmetadata-setproperty-method-microsoft-web-media-transformmanager.md) and [GetProperty(XName)](ijobmetadata-getproperty-method-microsoft-web-media-transformmanager.md) methods can access metadata that is stored in the task resource description framework (RDF) metadata section in the manifest. The [TaskMetadata](jobmetadata-taskmetadata-property-microsoft-web-media-transformmanager.md) property provides read-only access to the task-specific metadata that was provided in the synchronized multimedia interface language (SMIL) manifest, which simplifies access to the task metadata stored in the manifest. This same metadata can also be accessed by reading the [Manifest](ijobmetadata-manifest-property-microsoft-web-media-transformmanager.md) property.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

