---
title: JobManager.ShutdownComplete Event (Microsoft.Web.Media.TransformManager)
TOCTitle: ShutdownComplete Event
ms:assetid: E:Microsoft.Web.Media.TransformManager.JobManager.ShutdownComplete
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanager.shutdowncomplete(v=VS.90)
ms:contentKeyID: 36868665
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.ShutdownComplete
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.add_ShutdownComplete
- Microsoft.Web.Media.TransformManager.JobManager.remove_ShutdownComplete
- Microsoft.Web.Media.TransformManager.JobManager.ShutdownComplete
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ShutdownComplete Event

Occurs when all transform jobs have been processed.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
Public Event ShutdownCompleteAsJobManagerShutDownEventHandler
'Usage
DiminstanceAsJobManagerDimhandlerAsJobManagerShutDownEventHandlerAddHandler instance.ShutdownComplete, handler
```

``` csharp
public event JobManagerShutDownEventHandlerShutdownComplete
```

``` c++
public:
 eventJobManagerShutDownEventHandler^ ShutdownComplete {
    voidadd (JobManagerShutDownEventHandler^ value);
    voidremove (JobManagerShutDownEventHandler^ value);
}
```

``` fsharp
memberShutdownComplete : IEvent<JobManagerShutDownEventHandler,
    EventArgs>
```

``` jscript
```

## See Also

#### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

