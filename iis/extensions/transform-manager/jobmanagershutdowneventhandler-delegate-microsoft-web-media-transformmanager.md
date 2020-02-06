---
title: JobManagerShutDownEventHandler Delegate (Microsoft.Web.Media.TransformManager)
TOCTitle: JobManagerShutDownEventHandler Delegate
ms:assetid: T:Microsoft.Web.Media.TransformManager.JobManagerShutDownEventHandler
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanagershutdowneventhandler(v=VS.90)
ms:contentKeyID: 36868659
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManagerShutDownEventHandler
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManagerShutDownEventHandler
- Microsoft.Web.Media.TransformManager.JobManagerShutDownEventHandler..ctor
- Microsoft.Web.Media.TransformManager.JobManagerShutDownEventHandler.BeginInvoke
- Microsoft.Web.Media.TransformManager.JobManagerShutDownEventHandler.EndInvoke
- Microsoft.Web.Media.TransformManager.JobManagerShutDownEventHandler.Invoke
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# JobManagerShutDownEventHandler Delegate

Represents the method that handles the shutdown event for the job manager. This type supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public Delegate Sub JobManagerShutDownEventHandler ( _
    sender As Object, _
    e As EventArgs _
)
'Usage

  Dim instance As New JobManagerShutDownEventHandler(AddressOf HandlerMethod)
```

```csharp
  public delegate void JobManagerShutDownEventHandler(
    Object sender,
    EventArgs e
)
```

```cpp
  public delegate void JobManagerShutDownEventHandler(
    Object^ sender, 
    EventArgs^ e
)
```

``` fsharp
  type JobManagerShutDownEventHandler = 
    delegate of 
        sender:Object * 
        e:EventArgs -> unit
```

```jscript
  
```

### Parameters

  - sender  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b)  

<!-- end list -->

  - e  
    Type: [System.EventArgs](https://msdn.microsoft.com/library/118wxtk3)  

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

