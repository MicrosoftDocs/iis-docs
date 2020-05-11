---
title: LogLevelHelper.GetLogLevel Method (LogLevel) (Microsoft.Web.Media.TransformManager)
TOCTitle: GetLogLevel Method (LogLevel)
ms:assetid: M:Microsoft.Web.Media.TransformManager.LogLevelHelper.GetLogLevel(Microsoft.Web.Media.TransformManager.LogLevel)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.loglevelhelper.getloglevel(v=VS.90)
ms:contentKeyID: 35520968
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
- Microsoft.Web.Media.TransformManager.LogLevelHelper.GetLogLevel
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetLogLevel Method (LogLevel)

Returns the level of detail for a log.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Function GetLogLevel ( _
    level As LogLevel _
) As String
'Usage

  Dim level As LogLevel
Dim returnValue As String

returnValue = LogLevelHelper.GetLogLevel(level)
```

```csharp
  public static string GetLogLevel(
    LogLevel level
)
```

```cpp
  public:
static String^ GetLogLevel(
    LogLevel level
)
```

``` fsharp
  static member GetLogLevel : 
        level:LogLevel -> string 
```

```jscript
  public static function GetLogLevel(
    level : LogLevel
) : String
```

### Parameters

  - level  
    Type: [Microsoft.Web.Media.TransformManager.LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md)  
    The type of logging detail to write to the log file.  

### Return Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The level of detail for a log.  

## See Also

### Reference

[LogLevelHelper Class](loglevelhelper-class-microsoft-web-media-transformmanager.md)

[GetLogLevel Overload](loglevelhelper-getloglevel-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
