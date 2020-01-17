---
title: JobManager.OnShutdownComplete Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: OnShutdownComplete Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobManager.OnShutdownComplete(System.EventArgs)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanager.onshutdowncomplete(v=VS.90)
ms:contentKeyID: 36868662
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.OnShutdownComplete
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.OnShutdownComplete
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# OnShutdownComplete Method

Raises the [ShutdownComplete](jobmanager-shutdowncomplete-event-microsoft-web-media-transformmanager.md) event.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Protected Overridable Sub OnShutdownComplete ( _
    e As EventArgs _
)
'Usage

  Dim e As EventArgs

Me.OnShutdownComplete(e)
```

```csharp
  protected virtual void OnShutdownComplete(
    EventArgs e
)
```

```cpp
  protected:
virtual void OnShutdownComplete(
    EventArgs^ e
)
```

``` fsharp
  abstract OnShutdownComplete : 
        e:EventArgs -> unit 
override OnShutdownComplete : 
        e:EventArgs -> unit 
```

```jscript
  protected function OnShutdownComplete(
    e : EventArgs
)
```

### Parameters

  - e  
    Type: [System.EventArgs](https://msdn.microsoft.com/library/118wxtk3)  
    The event data.  

## See Also

### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

