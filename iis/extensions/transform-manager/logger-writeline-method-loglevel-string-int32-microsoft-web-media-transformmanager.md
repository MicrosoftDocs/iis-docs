---
title: Logger.WriteLine Method (LogLevel, String, Int32) (Microsoft.Web.Media.TransformManager)
TOCTitle: WriteLine Method (LogLevel, String, Int32)
ms:assetid: M:Microsoft.Web.Media.TransformManager.Logger.WriteLine(Microsoft.Web.Media.TransformManager.LogLevel,System.String,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.logger.writeline(v=VS.90)
ms:contentKeyID: 46408192
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
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# WriteLine Method (LogLevel, String, Int32)

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub WriteLine ( _
    level As LogLevel, _
    value As String, _
    eventId As Integer _
)
'Usage

  Dim instance As Logger
Dim level As LogLevel
Dim value As String
Dim eventId As Integer

instance.WriteLine(level, value, eventId)
```

```csharp
  public void WriteLine(
    LogLevel level,
    string value,
    int eventId
)
```

```cpp
  public:
virtual void WriteLine(
    LogLevel level, 
    String^ value, 
    int eventId
) sealed
```

``` fsharp
  abstract WriteLine : 
        level:LogLevel * 
        value:string * 
        eventId:int -> unit 
override WriteLine : 
        level:LogLevel * 
        value:string * 
        eventId:int -> unit 
```

```jscript
  public final function WriteLine(
    level : LogLevel, 
    value : String, 
    eventId : int
)
```

### Parameters

  - level  
    Type: [Microsoft.Web.Media.TransformManager.LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md)  

<!-- end list -->

  - value  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  

<!-- end list -->

  - eventId  
    Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  

### Implements

[ILogger.WriteLine(LogLevel, String, Int32)](ilogger-writeline-method-loglevel-string-int32-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[Logger Class](logger-class-microsoft-web-media-transformmanager.md)

[WriteLine Overload](logger-writeline-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

