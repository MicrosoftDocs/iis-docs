---
title: LocalScheduler.SetLogWriter Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetLogWriter Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.SetLogWriter(Microsoft.Web.Media.TransformManager.Logger)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.localscheduler.setlogwriter(v=VS.90)
ms:contentKeyID: 35520978
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.SetLogWriter
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.SetLogWriter
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SetLogWriter Method

Sets the [Logger](logger-class-microsoft-web-media-transformmanager.md) object for the local scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Overrides Sub SetLogWriter ( _
    logger As Logger _
)
'Usage

  Dim instance As LocalScheduler
Dim logger As Logger

instance.SetLogWriter(logger)
```

```csharp
  public override void SetLogWriter(
    Logger logger
)
```

```cpp
  public:
virtual void SetLogWriter(
    Logger^ logger
) override
```

``` fsharp
  abstract SetLogWriter : 
        logger:Logger -> unit 
override SetLogWriter : 
        logger:Logger -> unit 
```

```jscript
  public override function SetLogWriter(
    logger : Logger
)
```

### Parameters

  - logger  
    Type: [Microsoft.Web.Media.TransformManager.Logger](logger-class-microsoft-web-media-transformmanager.md)  
    The [Logger](logger-class-microsoft-web-media-transformmanager.md) object that provides access to task definition and job template properties.  

## See Also

### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

