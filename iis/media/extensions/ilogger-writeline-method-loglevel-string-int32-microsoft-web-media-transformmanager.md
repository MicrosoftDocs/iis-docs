---
title: ILogger.WriteLine Method (LogLevel, String, Int32) (Microsoft.Web.Media.TransformManager)
TOCTitle: WriteLine Method (LogLevel, String, Int32)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ILogger.WriteLine(Microsoft.Web.Media.TransformManager.LogLevel,System.String,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.ilogger.writeline(v=VS.90)
ms:contentKeyID: 46408417
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

# WriteLine Method (LogLevel, String, Int32)

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
SubWriteLine ( _
    levelAsLogLevel, _
    valueAsString, _
    eventIdAsInteger _
)
'Usage
DiminstanceAsILoggerDimlevelAsLogLevelDimvalueAsStringDimeventIdAsInteger

instance.WriteLine(level, value, eventId)
```

``` csharp
voidWriteLine(
    LogLevellevel,
    stringvalue,
    inteventId
)
```

``` c++
voidWriteLine(
    LogLevellevel, 
    String^ value, 
    inteventId
)
```

``` fsharp
abstractWriteLine : 
        level:LogLevel * 
        value:string * 
        eventId:int->unit
```

``` jscript
functionWriteLine(
    level : LogLevel, 
    value : String, 
    eventId : int
)
```

#### Parameters

  - level  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md)  

<!-- end list -->

  - value  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - eventId  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  

## See Also

#### Reference

[ILogger Interface](ilogger-interface-microsoft-web-media-transformmanager.md)

[WriteLine Overload](ilogger-writeline-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

