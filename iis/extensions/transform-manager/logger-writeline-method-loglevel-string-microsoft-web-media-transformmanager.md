---
title: Logger.WriteLine Method (LogLevel, String) (Microsoft.Web.Media.TransformManager)
description: Describes the WriteLine method for LogLevel and Strings and provides the method's namespace, assembly, syntax, parameters, and remarks.
TOCTitle: WriteLine Method (LogLevel, String)
ms:assetid: M:Microsoft.Web.Media.TransformManager.Logger.WriteLine(Microsoft.Web.Media.TransformManager.LogLevel,System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.logger.writeline(v=VS.90)
ms:contentKeyID: 35520750
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- cpp
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Logger.WriteLine
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# WriteLine Method (LogLevel, String)

Writes a line to the log file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub WriteLine ( _
    level As LogLevel, _
    value As String _
)
'Usage

  Dim instance As Logger
Dim level As LogLevel
Dim value As String

instance.WriteLine(level, value)
```

```csharp
  public void WriteLine(
    LogLevel level,
    string value
)
```

```cpp
  public:
virtual void WriteLine(
    LogLevel level, 
    String^ value
) sealed
```

``` fsharp
  abstract WriteLine : 
        level:LogLevel * 
        value:string -> unit 
override WriteLine : 
        level:LogLevel * 
        value:string -> unit 
```

```jscript
  public final function WriteLine(
    level : LogLevel, 
    value : String
)
```

### Parameters

  - level  
    Type: [Microsoft.Web.Media.TransformManager.LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md)  
    A [LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md) object that specifies the level of information that will be logged.  

<!-- end list -->

  - value  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    A log value.  

### Implements

[ILogger.WriteLine(LogLevel, String)](ilogger-writeline-method-loglevel-string-microsoft-web-media-transformmanager.md)  

## Remarks

This method writes a date/time string, the log level, and the string to the log file.

## See Also

### Reference

[Logger Class](logger-class-microsoft-web-media-transformmanager.md)

[WriteLine Overload](logger-writeline-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
