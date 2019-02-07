---
title: Logger Constructor  (Microsoft.Web.Media.TransformManager)
TOCTitle: Logger Constructor
ms:assetid: M:Microsoft.Web.Media.TransformManager.Logger.#ctor(System.String,Microsoft.Web.Media.TransformManager.LogLevel)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.logger.logger(v=VS.90)
ms:contentKeyID: 35521177
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Logger.#ctor
- Microsoft.Web.Media.TransformManager.Logger.Logger
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Logger..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Logger Constructor

Initializes a new instance of the [Logger](logger-class-microsoft-web-media-transformmanager.md) class.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration

  Public Sub New ( _
    logFileName As String, _
    level As LogLevel _
)
'Usage

  Dim logFileName As String
Dim level As LogLevel

Dim instance As New Logger(logFileName, _
    level)
```

``` csharp
  public Logger(
    string logFileName,
    LogLevel level
)
```

``` c++
  public:
Logger(
    String^ logFileName, 
    LogLevel level
)
```

``` fsharp
  new : 
        logFileName:string * 
        level:LogLevel -> Logger
```

``` jscript
  public function Logger(
    logFileName : String, 
    level : LogLevel
)
```

#### Parameters

  - logFileName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the log file.  

<!-- end list -->

  - level  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md)  
    A [LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md) object that specifies the level of information that will be logged.  

## Remarks

Each line written to a log has a [LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md) value associated with it.

## See Also

#### Reference

[Logger Class](logger-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

