---
title: Logger.WriteLine Method (LogLevel, String) (Microsoft.Web.Media.TransformManager)
TOCTitle: WriteLine Method (LogLevel, String)
ms:assetid: M:Microsoft.Web.Media.TransformManager.Logger.WriteLine(Microsoft.Web.Media.TransformManager.LogLevel,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.logger.writeline(v=VS.90)
ms:contentKeyID: 35520750
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
- Microsoft.Web.Media.TransformManager.Logger.WriteLine
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# WriteLine Method (LogLevel, String)

Writes a line to the log file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSubWriteLine ( _
    levelAsLogLevel, _
    valueAsString _
)
'Usage
DiminstanceAsLoggerDimlevelAsLogLevelDimvalueAsString

instance.WriteLine(level, value)
```

``` csharp
publicvoidWriteLine(
    LogLevellevel,
    stringvalue
)
```

``` c++
public:
virtualvoidWriteLine(
    LogLevellevel, 
    String^ value
) sealed
```

``` fsharp
abstractWriteLine : 
        level:LogLevel * 
        value:string->unitoverrideWriteLine : 
        level:LogLevel * 
        value:string->unit
```

``` jscript
publicfinalfunctionWriteLine(
    level : LogLevel, 
    value : String
)
```

#### Parameters

  - level  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md)  
    A [LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md) object that specifies the level of information that will be logged.  

<!-- end list -->

  - value  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A log value.  

#### Implements

[ILogger. . :: . .WriteLine(LogLevel, String)](ilogger-writeline-method-loglevel-string-microsoft-web-media-transformmanager.md)  

## Remarks

This method writes a date/time string, the log level, and the string to the log file.

## See Also

#### Reference

[Logger Class](logger-class-microsoft-web-media-transformmanager.md)

[WriteLine Overload](logger-writeline-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

