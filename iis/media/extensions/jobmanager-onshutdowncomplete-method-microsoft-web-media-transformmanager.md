---
title: JobManager.OnShutdownComplete Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: OnShutdownComplete Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobManager.OnShutdownComplete(System.EventArgs)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanager.onshutdowncomplete(v=VS.90)
ms:contentKeyID: 36868662
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.OnShutdownComplete
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.OnShutdownComplete
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# OnShutdownComplete Method

Raises the [ShutdownComplete](jobmanager-shutdowncomplete-event-microsoft-web-media-transformmanager.md) event.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
ProtectedOverridableSubOnShutdownComplete ( _
    eAsEventArgs _
)
'Usage
DimeAsEventArgsMe.OnShutdownComplete(e)
```

``` csharp
protectedvirtualvoidOnShutdownComplete(
    EventArgse
)
```

``` c++
protected:
virtualvoidOnShutdownComplete(
    EventArgs^ e
)
```

``` fsharp
abstractOnShutdownComplete : 
        e:EventArgs->unitoverrideOnShutdownComplete : 
        e:EventArgs->unit
```

``` jscript
protectedfunctionOnShutdownComplete(
    e : EventArgs
)
```

#### Parameters

  - e  
    Type: [System. . :: . .EventArgs](https://msdn.microsoft.com/en-us/library/118wxtk3\(v=vs.90\))  
    The event data.  

## See Also

#### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

