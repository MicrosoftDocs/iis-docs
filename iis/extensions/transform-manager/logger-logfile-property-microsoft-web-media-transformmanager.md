---
title: Logger.LogFile Property (Microsoft.Web.Media.TransformManager)
TOCTitle: LogFile Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.Logger.LogFile
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.logger.logfile(v=VS.90)
ms:contentKeyID: 35520985
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Logger.get_LogFile
- Microsoft.Web.Media.TransformManager.Logger.set_LogFile
- Microsoft.Web.Media.TransformManager.Logger.LogFile
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Logger.get_LogFile
- Microsoft.Web.Media.TransformManager.Logger.LogFile
- Microsoft.Web.Media.TransformManager.Logger.set_LogFile
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# LogFile Property

Gets or sets a [StreamWriter](https://msdn.microsoft.com/library/3ssew6tk) object that represents the log file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property LogFile As StreamWriter
    Get
    Set
'Usage

  Dim instance As Logger
Dim value As StreamWriter

value = instance.LogFile

instance.LogFile = value
```

```csharp
  public StreamWriter LogFile { get; set; }
```

```cpp
  public:
virtual property StreamWriter^ LogFile {
    StreamWriter^ get () sealed;
    void set (StreamWriter^ value) sealed;
}
```

``` fsharp
  abstract LogFile : StreamWriter with get, set
override LogFile : StreamWriter with get, set
```

```jscript
  final function get LogFile () : StreamWriter
final function set LogFile (value : StreamWriter)
```

### Property Value

Type: [System.IO.StreamWriter](https://msdn.microsoft.com/library/3ssew6tk)  
The stream writer that represents the log file.  

### Implements

[ILogger.LogFile](ilogger-logfile-property-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[Logger Class](logger-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

