---
title: ILogger.WriteLine Method (LogLevel, String, Int32) (Microsoft.Web.Media.TransformManager)
description: Describes the WriteLine method for LogLevel, String, and Int32 and provides the method's namespace, assembly, syntax, and parameters.
TOCTitle: WriteLine Method (LogLevel, String, Int32)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ILogger.WriteLine(Microsoft.Web.Media.TransformManager.LogLevel,System.String,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.ilogger.writeline(v=VS.90)
ms:contentKeyID: 46408417
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- cpp
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ILogger.WriteLine
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# WriteLine Method (LogLevel, String, Int32)

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Sub WriteLine ( _
    level As LogLevel, _
    value As String, _
    eventId As Integer _
)
'Usage

  Dim instance As ILogger
Dim level As LogLevel
Dim value As String
Dim eventId As Integer

instance.WriteLine(level, value, eventId)
```

```csharp
  void WriteLine(
    LogLevel level,
    string value,
    int eventId
)
```

```cpp
  void WriteLine(
    LogLevel level, 
    String^ value, 
    int eventId
)
```

``` fsharp
  abstract WriteLine : 
        level:LogLevel * 
        value:string * 
        eventId:int -> unit 
```

```jscript
  function WriteLine(
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

## See Also

### Reference

[ILogger Interface](ilogger-interface-microsoft-web-media-transformmanager.md)

[WriteLine Overload](ilogger-writeline-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
