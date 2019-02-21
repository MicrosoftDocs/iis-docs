---
title: LogLevelHelper.GetLogLevel Method (String) (Microsoft.Web.Media.TransformManager)
TOCTitle: GetLogLevel Method (String)
ms:assetid: M:Microsoft.Web.Media.TransformManager.LogLevelHelper.GetLogLevel(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.loglevelhelper.getloglevel(v=VS.90)
ms:contentKeyID: 35520725
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- "cpp"
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
---

# GetLogLevel Method (String)

Returns a value that specifies the level of detail for a log.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Function GetLogLevel ( _
    level As String _
) As LogLevel
'Usage

  Dim level As String
Dim returnValue As LogLevel

returnValue = LogLevelHelper.GetLogLevel(level)
```

```csharp
  public static LogLevel GetLogLevel(
    string level
)
```

```cpp
  public:
static LogLevel GetLogLevel(
    String^ level
)
```

``` fsharp
  static member GetLogLevel : 
        level:string -> LogLevel 
```

```jscript
  public static function GetLogLevel(
    level : String
) : LogLevel
```

### Parameters

  - level  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The type of logging detail to write to the log file.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md)  
The level of detail for a log.  

## See Also

### Reference

[LogLevelHelper Class](loglevelhelper-class-microsoft-web-media-transformmanager.md)

[GetLogLevel Overload](loglevelhelper-getloglevel-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

