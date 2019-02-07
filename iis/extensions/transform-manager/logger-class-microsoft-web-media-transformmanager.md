---
title: Logger Class (Microsoft.Web.Media.TransformManager)
TOCTitle: Logger Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.Logger
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.logger(v=VS.90)
ms:contentKeyID: 35520593
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Logger
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Logger
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Logger Class

Provides access to task definition and job template properties.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.TransformManager..::..Logger  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration

  Public Class Logger _
    Implements ILogger, IDisposable
'Usage

  Dim instance As Logger
```

``` csharp
  public class Logger : ILogger, IDisposable
```

``` c++
  public ref class Logger : ILogger, IDisposable
```

``` fsharp
  type Logger =  
    class
        interface ILogger
        interface IDisposable
    end
```

``` jscript
  public class Logger implements ILogger, IDisposable
```

The Logger type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Logger](logger-constructor-microsoft-web-media-transformmanager.md)|Initializes a new instance of the Logger class.|


Top

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogFile](logger-logfile-property-microsoft-web-media-transformmanager.md)|Gets or sets a [StreamWriter](https://msdn.microsoft.com/en-us/library/3ssew6tk(v=vs.90)) object that represents the log file.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogFileName](logger-logfilename-property-microsoft-web-media-transformmanager.md)|Gets or sets the name of the log file.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogLevel](logger-loglevel-property-microsoft-web-media-transformmanager.md)|Gets or sets the level of information that will be logged.|

Top

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Close](logger-close-method-microsoft-web-media-transformmanager.md)|Disposes logging resources if the log file exists.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Dispose() () () ()](logger-dispose-method-microsoft-web-media-transformmanager_1.md)|Disposes logging resources.|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Dispose(Boolean)](logger-dispose-method-boolean-microsoft-web-media-transformmanager.md)|Disposes logging resources and optionally releases the managed resources.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[WriteLine(LogLevel, String)](logger-writeline-method-loglevel-string-microsoft-web-media-transformmanager.md)|Writes a line to the log file.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[WriteLine(LogLevel, String, Int32)](logger-writeline-method-loglevel-string-int32-microsoft-web-media-transformmanager.md)||

Top

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

