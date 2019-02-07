---
title: IJobManifest Interface (Microsoft.Web.Media.TransformManager)
TOCTitle: IJobManifest Interface
ms:assetid: T:Microsoft.Web.Media.TransformManager.IJobManifest
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.ijobmanifest(v=VS.90)
ms:contentKeyID: 35521191
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobManifest
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobManifest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IJobManifest Interface

Represents an interface that retrieves job scheduler information.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration

  Public Interface IJobManifest
'Usage

  Dim instance As IJobManifest
```

``` csharp
  public interface IJobManifest
```

``` c++
  public interface class IJobManifest
```

``` fsharp
  type IJobManifest =  interface end
```

``` jscript
  public interface IJobManifest
```

The IJobManifest type exposes the following members.

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetScheduler](ijobmanifest-getscheduler-method-microsoft-web-media-transformmanager.md)|Returns a job scheduler object by searching the job manifest.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetSchedulerInfo](ijobmanifest-getschedulerinfo-method-microsoft-web-media-transformmanager.md)|Returns scheduler information by searching the job manifest.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Initialize](ijobmanifest-initialize-method-microsoft-web-media-transformmanager.md)|Initializes member variables for a job manifest that is loaded from disk instead of created as part of a job submission.|

Top

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

