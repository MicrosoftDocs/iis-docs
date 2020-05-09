---
title: SmoothStreamingMediaElement.AutoPlay Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: AutoPlay Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AutoPlay
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.autoplay(v=VS.95)
ms:contentKeyID: 46307801
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AutoPlay
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_AutoPlay
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_AutoPlay
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AutoPlay
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_AutoPlay
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_AutoPlay
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.AutoPlay Property

Gets or sets a value that specifies whether the media element starts automatically.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property AutoPlay As Boolean
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Boolean

value = instance.AutoPlay

instance.AutoPlay = value
```

```csharp
public bool AutoPlay { get; set; }
```

```cpp
public:
property bool AutoPlay {
    bool get ();
    void set (bool value);
}
```

``` fsharp
member AutoPlay : bool with get, set
```

```jscript
function get AutoPlay () : boolean
function set AutoPlay (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
true if the media element starts automatically; otherwise, false.

## Remarks

For more information and for examples, see [Microsoft Smooth Streaming Client 2.0](microsoft-smooth-streaming-client-2-0.md).

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
