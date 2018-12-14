﻿---
title: ILogger.WriteLine Method (LogLevel, String) (Microsoft.Web.Media.TransformManager)
TOCTitle: WriteLine Method (LogLevel, String)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ILogger.WriteLine(Microsoft.Web.Media.TransformManager.LogLevel,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.ilogger.writeline(v=VS.90)
ms:contentKeyID: 35521199
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ILogger.WriteLine
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# WriteLine Method (LogLevel, String)

Writes a line to the log.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
SubWriteLine ( _
    levelAsLogLevel, _
    valueAsString _
)
'Usage
DiminstanceAsILoggerDimlevelAsLogLevelDimvalueAsString

instance.WriteLine(level, value)
```

``` csharp
voidWriteLine(
    LogLevellevel,
    stringvalue
)
```

``` c++
voidWriteLine(
    LogLevellevel, 
    String^ value
)
```

``` fsharp
abstractWriteLine : 
        level:LogLevel * 
        value:string->unit
```

``` jscript
functionWriteLine(
    level : LogLevel, 
    value : String
)
```

#### Parameters

  - level  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md)  
    The level of errors that will be logged.  

<!-- end list -->

  - value  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The value to write.  

## Remarks

The level parameter must be set to one of the values in the [LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md) enumeration.

## See Also

#### Reference

[ILogger Interface](ilogger-interface-microsoft-web-media-transformmanager.md)

[WriteLine Overload](ilogger-writeline-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
