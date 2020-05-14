---
title: HpcScheduler.SetLogWriter Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetLogWriter Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.HpcScheduler.SetLogWriter(Microsoft.Web.Media.TransformManager.Logger)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.hpcscheduler.setlogwriter(v=VS.90)
ms:contentKeyID: 35521197
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.HpcScheduler.SetLogWriter
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.HpcScheduler.SetLogWriter
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SetLogWriter Method

Sets the logger object for the HPC scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Overrides Sub SetLogWriter ( _
    logger As Logger _
)
'Usage

  Dim instance As HpcScheduler
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
    The [Logger](logger-class-microsoft-web-media-transformmanager.md) object for the HPC scheduler.  

## See Also

### Reference

[HpcScheduler Class](hpcscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
