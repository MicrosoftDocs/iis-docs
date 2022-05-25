---
title: Logger.LogFileName Property (Microsoft.Web.Media.TransformManager)
description: The LogFileName property gets or sets the name of the log file. This page includes syntax samples for the code.
TOCTitle: LogFileName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.Logger.LogFileName
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.logger.logfilename(v=VS.90)
ms:contentKeyID: 35521002
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Logger.get_LogFileName
- Microsoft.Web.Media.TransformManager.Logger.LogFileName
- Microsoft.Web.Media.TransformManager.Logger.set_LogFileName
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Logger.get_LogFileName
- Microsoft.Web.Media.TransformManager.Logger.LogFileName
- Microsoft.Web.Media.TransformManager.Logger.set_LogFileName
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# LogFileName Property

Gets or sets the name of the log file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property LogFileName As String
    Get
    Set
'Usage

  Dim instance As Logger
Dim value As String

value = instance.LogFileName

instance.LogFileName = value
```

```csharp
  public string LogFileName { get; set; }
```

```cpp
  public:
property String^ LogFileName {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
  member LogFileName : string with get, set
```

```jscript
  function get LogFileName () : String
function set LogFileName (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The name of the log file.  

## See Also

### Reference

[Logger Class](logger-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
