---
title: ILogger Interface (Microsoft.Web.Media.TransformManager)
TOCTitle: ILogger Interface
ms:assetid: T:Microsoft.Web.Media.TransformManager.ILogger
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.ilogger(v=VS.90)
ms:contentKeyID: 35520832
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ILogger
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ILogger
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ILogger Interface

Defines a logger that can be used by the task to write data to the job-instance log.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public Interface ILogger
'Usage

  Dim instance As ILogger
```

```csharp
  public interface ILogger
```

```cpp
  public interface class ILogger
```

``` fsharp
  type ILogger =  interface end
```

```jscript
  public interface ILogger
```

The ILogger type exposes the following members.

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogFile](ilogger-logfile-property-microsoft-web-media-transformmanager.md)|Gets the [StreamWriter](https://msdn.microsoft.com/library/3ssew6tk) object for the logger.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogLevel](ilogger-loglevel-property-microsoft-web-media-transformmanager.md)|Gets the level of errors that will be logged.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[WriteLine(LogLevel, String)](ilogger-writeline-method-loglevel-string-microsoft-web-media-transformmanager.md)|Writes a line to the log.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[WriteLine(LogLevel, String, Int32)](ilogger-writeline-method-loglevel-string-int32-microsoft-web-media-transformmanager.md)||

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

