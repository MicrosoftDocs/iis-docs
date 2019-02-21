---
title: ILogger.LogFile Property (Microsoft.Web.Media.TransformManager)
TOCTitle: LogFile Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ILogger.LogFile
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.ilogger.logfile(v=VS.90)
ms:contentKeyID: 35521081
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ILogger.LogFile
- Microsoft.Web.Media.TransformManager.ILogger.get_LogFile
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ILogger.get_LogFile
- Microsoft.Web.Media.TransformManager.ILogger.LogFile
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# LogFile Property

Gets the [StreamWriter](https://msdn.microsoft.com/library/3ssew6tk) object for the logger.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  ReadOnly Property LogFile As StreamWriter
    Get
'Usage

  Dim instance As ILogger
Dim value As StreamWriter

value = instance.LogFile
```

```csharp
  StreamWriter LogFile { get; }
```

```cpp
  property StreamWriter^ LogFile {
    StreamWriter^ get ();
}
```

``` fsharp
  abstract LogFile : StreamWriter
```

```jscript
  function get LogFile () : StreamWriter
```

### Property Value

Type: [System.IO.StreamWriter](https://msdn.microsoft.com/library/3ssew6tk)  
The stream writer.  

## See Also

### Reference

[ILogger Interface](ilogger-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

