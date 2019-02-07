---
title: ITask Interface (Microsoft.Web.Media.TransformManager)
TOCTitle: ITask Interface
ms:assetid: T:Microsoft.Web.Media.TransformManager.ITask
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.itask(v=VS.90)
ms:contentKeyID: 35520845
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ITask
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ITask
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ITask Interface

Defines a class as a transform task for use with the IIS Transform Manager framework.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration

  Public Interface ITask _
    Inherits IDisposable
'Usage

  Dim instance As ITask
```

``` csharp
  public interface ITask : IDisposable
```

``` c++
  public interface class ITask : IDisposable
```

``` fsharp
  type ITask =  
    interface
        interface IDisposable
    end
```

``` jscript
  public interface ITask extends IDisposable
```

The ITask type exposes the following members.

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Dispose](https://msdn.microsoft.com/en-us/library/es4s3w1d(v=vs.90))|(Inherited from [IDisposable](https://msdn.microsoft.com/en-us/library/aax125c9(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Initialize](itask-initialize-method-microsoft-web-media-transformmanager.md)|Initializes the task with objects for reporting status, logging data, and getting metadata from the job manifest.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Start](itask-start-method-microsoft-web-media-transformmanager.md)|Called by the framework to start the task immediately after the [Initialize(ITaskStatus, IJobMetadata, ILogger)](itask-initialize-method-microsoft-web-media-transformmanager.md) method runs.|

Top

## Remarks

The ITask interface implements the setter injection pattern. As parameters, the [Initialize(ITaskStatus, IJobMetadata, ILogger)](itask-initialize-method-microsoft-web-media-transformmanager.md) method takes instances of [ITaskStatus](itaskstatus-interface-microsoft-web-media-transformmanager.md), [IJobMetadata](ijobmetadata-interface-microsoft-web-media-transformmanager.md), and [ILogger](ilogger-interface-microsoft-web-media-transformmanager.md) to explicitly inject dependent objects. For more information, see [Inversion of Control Containers and the Dependency Injection Pattern](http://martinfowler.com/articles/injection.html).

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

