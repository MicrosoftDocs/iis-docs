---
title: JobManagerShutDownEventHandler Delegate (Microsoft.Web.Media.TransformManager)
TOCTitle: JobManagerShutDownEventHandler Delegate
ms:assetid: T:Microsoft.Web.Media.TransformManager.JobManagerShutDownEventHandler
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanagershutdowneventhandler(v=VS.90)
ms:contentKeyID: 36868659
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManagerShutDownEventHandler
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManagerShutDownEventHandler
- Microsoft.Web.Media.TransformManager.JobManagerShutDownEventHandler..ctor
- Microsoft.Web.Media.TransformManager.JobManagerShutDownEventHandler.BeginInvoke
- Microsoft.Web.Media.TransformManager.JobManagerShutDownEventHandler.EndInvoke
- Microsoft.Web.Media.TransformManager.JobManagerShutDownEventHandler.Invoke
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobManagerShutDownEventHandler Delegate

Represents the method that handles the shutdown event for the job manager. This type supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
PublicDelegateSubJobManagerShutDownEventHandler ( _
    senderAsObject, _
    eAsEventArgs _
)
'Usage
DiminstanceAsNewJobManagerShutDownEventHandler(AddressOf HandlerMethod)
```

``` csharp
publicdelegatevoidJobManagerShutDownEventHandler(
    Objectsender,
    EventArgse
)
```

``` c++
publicdelegatevoidJobManagerShutDownEventHandler(
    Object^ sender, 
    EventArgs^ e
)
```

``` fsharp
typeJobManagerShutDownEventHandler = 
    delegateofsender:Object * 
        e:EventArgs->unit
```

``` jscript
```

#### Parameters

  - sender  
    Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  

<!-- end list -->

  - e  
    Type: [System. . :: . .EventArgs](https://msdn.microsoft.com/en-us/library/118wxtk3\(v=vs.90\))  

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

