---
title: LogLevelHelper.GetLogLevel Method (LogLevel) (Microsoft.Web.Media.TransformManager)
TOCTitle: GetLogLevel Method (LogLevel)
ms:assetid: M:Microsoft.Web.Media.TransformManager.LogLevelHelper.GetLogLevel(Microsoft.Web.Media.TransformManager.LogLevel)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.loglevelhelper.getloglevel(v=VS.90)
ms:contentKeyID: 35520968
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LogLevelHelper.GetLogLevel
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetLogLevel Method (LogLevel)

Returns the level of detail for a log.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSharedFunctionGetLogLevel ( _
    levelAsLogLevel _
) AsString
'Usage
DimlevelAsLogLevelDimreturnValueAsStringreturnValue = LogLevelHelper.GetLogLevel(level)
```

``` csharp
publicstaticstringGetLogLevel(
    LogLevellevel
)
```

``` c++
public:
staticString^ GetLogLevel(
    LogLevellevel
)
```

``` fsharp
staticmemberGetLogLevel : 
        level:LogLevel->string
```

``` jscript
publicstaticfunctionGetLogLevel(
    level : LogLevel
) : String
```

#### Parameters

  - level  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md)  
    The type of logging detail to write to the log file.  

#### Return Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The level of detail for a log.  

## See Also

#### Reference

[LogLevelHelper Class](loglevelhelper-class-microsoft-web-media-transformmanager.md)

[GetLogLevel Overload](loglevelhelper-getloglevel-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

