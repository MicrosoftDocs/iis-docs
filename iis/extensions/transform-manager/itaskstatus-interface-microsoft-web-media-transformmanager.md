---
title: ITaskStatus Interface (Microsoft.Web.Media.TransformManager)
TOCTitle: ITaskStatus Interface
ms:assetid: T:Microsoft.Web.Media.TransformManager.ITaskStatus
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.itaskstatus(v=VS.90)
ms:contentKeyID: 35520844
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ITaskStatus
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ITaskStatus
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ITaskStatus Interface

Defines an interface that is used to implement a status callback mechanism for the task.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public Interface ITaskStatus
'Usage

  Dim instance As ITaskStatus
```

```csharp
  public interface ITaskStatus
```

```cpp
  public interface class ITaskStatus
```

``` fsharp
  type ITaskStatus =  interface end
```

```jscript
  public interface ITaskStatus
```

The ITaskStatus type exposes the following members.

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Message](itaskstatus-message-property-microsoft-web-media-transformmanager.md)||
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[PercentComplete](itaskstatus-percentcomplete-property-microsoft-web-media-transformmanager.md)|Gets the percentage of task completion.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Status](itaskstatus-status-property-microsoft-web-media-transformmanager.md)|Gets the status of the task.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[UpdateStatus](itaskstatus-updatestatus-method-microsoft-web-media-transformmanager.md)|Updates the status of an ongoing task.|

## Remarks

Task status is reported through the [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object. Initialize this object with a manifest that contains scheduler information. Each task will be passed an object that implements this interface through dependency injection.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

