---
title: SmoothStreamingMediaElement.IsMuted Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: IsMuted Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.IsMuted
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.ismuted(v=VS.95)
ms:contentKeyID: 46307827
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.IsMuted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_IsMuted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_IsMuted
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_IsMuted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.IsMuted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_IsMuted
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.IsMuted Property

Gets or sets a value that indicates whether the audio track is muted.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property IsMuted As Boolean
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Boolean

value = instance.IsMuted

instance.IsMuted = value
```

```csharp
public bool IsMuted { get; set; }
```

```cpp
public:
property bool IsMuted {
    bool get ();
    void set (bool value);
}
```

``` fsharp
member IsMuted : bool with get, set
```

```jscript
function get IsMuted () : boolean
function set IsMuted (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
true if the media element is muted; otherwise, false.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

