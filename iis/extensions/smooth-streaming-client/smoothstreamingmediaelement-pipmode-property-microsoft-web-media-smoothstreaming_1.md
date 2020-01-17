---
title: SmoothStreamingMediaElement.PipMode Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: PipMode Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PipMode
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.pipmode(v=VS.95)
ms:contentKeyID: 46307847
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PipMode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_PipMode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_PipMode
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_PipMode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PipMode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_PipMode
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.PipMode Property

Gets or sets a value that indicates whether the media stream is in picture-in-picture (PIP) mode.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property PipMode As Boolean
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Boolean

value = instance.PipMode

instance.PipMode = value
```

```csharp
public bool PipMode { get; set; }
```

```cpp
public:
property bool PipMode {
    bool get ();
    void set (bool value);
}
```

``` fsharp
member PipMode : bool with get, set
```

```jscript
function get PipMode () : boolean
function set PipMode (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
true if the media stream is in picture-in-picture (PIP) mode; otherwise, false.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

