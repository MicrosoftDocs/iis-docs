---
title: TransformManagerService.Initialize Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: Initialize Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.Initialize(Microsoft.Web.Media.TransformManager.Logger)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.initialize(v=VS.90)
ms:contentKeyID: 35520770
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.Initialize
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.Initialize
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Initialize Method

Initializes the transform manager service.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
PublicSharedSubInitialize ( _
    loggerAsLogger _
)
'Usage
DimloggerAsLoggerTransformManagerService.Initialize(logger)
```

``` csharp
publicstaticvoidInitialize(
    Loggerlogger
)
```

``` c++
public:
staticvoidInitialize(
    Logger^ logger
)
```

``` fsharp
staticmemberInitialize : 
        logger:Logger->unit
```

``` jscript
publicstaticfunctionInitialize(
    logger : Logger
)
```

#### Parameters

  - logger  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .Logger](logger-class-microsoft-web-media-transformmanager.md)  
    The [Logger](logger-class-microsoft-web-media-transformmanager.md) object that is used to provide access to task definition and job template properties.  

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

