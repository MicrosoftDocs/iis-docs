---
title: ILogger.LogLevel Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: LogLevel Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ILogger.LogLevel
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.ilogger.loglevel(v=VS.90)
ms:contentKeyID: 35521035
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ILogger.LogLevel
- Microsoft.Web.Media.TransformManager.ILogger.get_LogLevel
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ILogger.get_LogLevel
- Microsoft.Web.Media.TransformManager.ILogger.LogLevel
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LogLevel Property

Gets the level of errors that will be logged.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
ReadOnlyPropertyLogLevelAsLogLevelGet
'Usage
DiminstanceAsILoggerDimvalueAsLogLevelvalue = instance.LogLevel
```

``` csharp
LogLevelLogLevel { get; }
```

``` c++
propertyLogLevelLogLevel {
    LogLevelget ();
}
```

``` fsharp
abstractLogLevel : LogLevel
```

``` jscript
function getLogLevel () : LogLevel
```

#### Property Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md)  
The log-level object.  

## Remarks

The log level is one of the values in the [LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md) enumeration that is defined in the Microsoft.Web.Media.TransformManager.Common assembly.

## See Also

#### Reference

[ILogger Interface](ilogger-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

