---
title: Scheduler.SetLogWriter Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetLogWriter Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.SetLogWriter(Microsoft.Web.Media.TransformManager.Logger)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.scheduler.setlogwriter(v=VS.90)
ms:contentKeyID: 35520806
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.SetLogWriter
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.SetLogWriter
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SetLogWriter Method

Sets the [Logger](logger-class-microsoft-web-media-transformmanager.md) object for the scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public MustOverride Sub SetLogWriter ( _
    logger As Logger _
)
'Usage

  Dim instance As Scheduler
Dim logger As Logger

instance.SetLogWriter(logger)
```

```csharp
  public abstract void SetLogWriter(
    Logger logger
)
```

```cpp
  public:
virtual void SetLogWriter(
    Logger^ logger
) abstract
```

``` fsharp
  abstract SetLogWriter : 
        logger:Logger -> unit 
```

```jscript
  public abstract function SetLogWriter(
    logger : Logger
)
```

### Parameters

  - logger  
    Type: [Microsoft.Web.Media.TransformManager.Logger](logger-class-microsoft-web-media-transformmanager.md)  
    The [Logger](logger-class-microsoft-web-media-transformmanager.md) object that provides access to task definition and job template properties.  

## Remarks

This method enables either the job manager or task engine to collect logging information.

## See Also

### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

