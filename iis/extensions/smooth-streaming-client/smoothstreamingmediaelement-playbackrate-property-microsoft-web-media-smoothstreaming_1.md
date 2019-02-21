---
title: SmoothStreamingMediaElement.PlaybackRate Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: PlaybackRate Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PlaybackRate
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.playbackrate(v=VS.95)
ms:contentKeyID: 46307849
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PlaybackRate
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_PlaybackRate
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_PlaybackRate
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PlaybackRate
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.PlaybackRate Property

Gets the playback rate.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property PlaybackRate As Nullable(Of Double)
    Get
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Nullable(Of Double)

value = instance.PlaybackRate
```

```csharp
public Nullable<double> PlaybackRate { get; }
```

```cpp
public:
property Nullable<double> PlaybackRate {
    Nullable<double> get ();
}
```

``` fsharp
member PlaybackRate : Nullable<float>
```

```jscript
function get PlaybackRate () : Nullable<double>
```

### Property Value

Type: [System.Nullable](https://msdn.microsoft.com/library/b3h38hb0\(v=vs.95\))\<[Double](https://msdn.microsoft.com/library/643eft0t\(v=vs.95\))\>  
A value from the [SupportedPlaybackRates](smoothstreamingmediaelement-supportedplaybackrates-property-microsoft-web-media-smoothstreaming_1.md) list.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

