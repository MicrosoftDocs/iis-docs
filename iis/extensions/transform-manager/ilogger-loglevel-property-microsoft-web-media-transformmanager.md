---
title: ILogger.LogLevel Property (Microsoft.Web.Media.TransformManager)
TOCTitle: LogLevel Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ILogger.LogLevel
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.ilogger.loglevel(v=VS.90)
ms:contentKeyID: 35521035
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ILogger.LogLevel
- Microsoft.Web.Media.TransformManager.ILogger.get_LogLevel
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ILogger.get_LogLevel
- Microsoft.Web.Media.TransformManager.ILogger.LogLevel
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# LogLevel Property

Gets the level of errors that will be logged.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  ReadOnly Property LogLevel As LogLevel
    Get
'Usage

  Dim instance As ILogger
Dim value As LogLevel

value = instance.LogLevel
```

```csharp
  LogLevel LogLevel { get; }
```

```cpp
  property LogLevel LogLevel {
    LogLevel get ();
}
```

``` fsharp
  abstract LogLevel : LogLevel
```

```jscript
  function get LogLevel () : LogLevel
```

### Property Value

Type: [Microsoft.Web.Media.TransformManager.LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md)  
The log-level object.  

## Remarks

The log level is one of the values in the [LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md) enumeration that is defined in the Microsoft.Web.Media.TransformManager.Common assembly.

## See Also

### Reference

[ILogger Interface](ilogger-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
