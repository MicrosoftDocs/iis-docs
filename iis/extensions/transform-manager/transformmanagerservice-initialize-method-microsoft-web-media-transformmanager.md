---
title: TransformManagerService.Initialize Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: Initialize Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.Initialize(Microsoft.Web.Media.TransformManager.Logger)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.transformmanagerservice.initialize(v=VS.90)
ms:contentKeyID: 35520770
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.Initialize
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.Initialize
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Initialize Method

Initializes the transform manager service.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public Shared Sub Initialize ( _
    logger As Logger _
)
'Usage

  Dim logger As Logger

TransformManagerService.Initialize(logger)
```

```csharp
  public static void Initialize(
    Logger logger
)
```

```cpp
  public:
static void Initialize(
    Logger^ logger
)
```

``` fsharp
  static member Initialize :
        logger:Logger -> unit
```

```jscript
  public static function Initialize(
    logger : Logger
)
```

### Parameters

  - logger  
    Type: [Microsoft.Web.Media.TransformManager.Logger](logger-class-microsoft-web-media-transformmanager.md)  
    The [Logger](logger-class-microsoft-web-media-transformmanager.md) object that is used to provide access to task definition and job template properties.  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
