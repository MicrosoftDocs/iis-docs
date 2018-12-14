---
title: Logger.LogLevel Property  (Microsoft.Web.Media.TransformManager)
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
- CSharp
- JScript
- VB
- FSharp
- c++
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
ROBOTS: INDEX,FOLLOW
---

# LogLevel Property

Gets or sets the level of information that will be logged.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicPropertyLogLevelAsLogLevelGetSet
'Usage
DiminstanceAsLoggerDimvalueAsLogLevelvalue = instance.LogLevel

instance.LogLevel = value
```

``` csharp
publicLogLevelLogLevel { get; set; }
```

``` c++
public:
virtualpropertyLogLevelLogLevel {
    LogLevelget () sealed;
    voidset (LogLevelvalue) sealed;
}
```

``` fsharp
abstractLogLevel : LogLevelwithget, setoverrideLogLevel : LogLevelwithget, set
```

``` jscript
finalfunction getLogLevel () : LogLevelfinalfunction setLogLevel (value : LogLevel)
```

#### Property Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md)  
The level of information that will be logged.  

#### Implements

[ILogger. . :: . .LogLevel](ilogger-loglevel-property-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[Logger Class](logger-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

