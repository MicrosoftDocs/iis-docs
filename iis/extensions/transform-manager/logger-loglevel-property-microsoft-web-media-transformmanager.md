---
title: Logger.LogLevel Property (Microsoft.Web.Media.TransformManager)
TOCTitle: LogLevel Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.Logger.LogLevel
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.logger.loglevel(v=VS.90)
ms:contentKeyID: 35521136
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Logger.set_LogLevel
- Microsoft.Web.Media.TransformManager.Logger.LogLevel
- Microsoft.Web.Media.TransformManager.Logger.get_LogLevel
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Logger.get_LogLevel
- Microsoft.Web.Media.TransformManager.Logger.LogLevel
- Microsoft.Web.Media.TransformManager.Logger.set_LogLevel
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# LogLevel Property

Gets or sets the level of information that will be logged.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property LogLevel As LogLevel
    Get
    Set
'Usage

  Dim instance As Logger
Dim value As LogLevel

value = instance.LogLevel

instance.LogLevel = value
```

```csharp
  public LogLevel LogLevel { get; set; }
```

```cpp
  public:
virtual property LogLevel LogLevel {
    LogLevel get () sealed;
    void set (LogLevel value) sealed;
}
```

``` fsharp
  abstract LogLevel : LogLevel with get, set
override LogLevel : LogLevel with get, set
```

```jscript
  final function get LogLevel () : LogLevel
final function set LogLevel (value : LogLevel)
```

### Property Value

Type: [Microsoft.Web.Media.TransformManager.LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md)  
The level of information that will be logged.  

### Implements

[ILogger.LogLevel](ilogger-loglevel-property-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[Logger Class](logger-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

