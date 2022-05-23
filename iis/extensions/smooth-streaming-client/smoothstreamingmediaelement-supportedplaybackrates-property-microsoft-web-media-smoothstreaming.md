---
title: SmoothStreamingMediaElement.SupportedPlaybackRates Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SupportedPlaybackRates Property
description: Gets or sets the playback rates list.
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SupportedPlaybackRates
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.supportedplaybackrates(v=VS.90)
ms:contentKeyID: 23960998
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SupportedPlaybackRates
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_SupportedPlaybackRates
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_SupportedPlaybackRates
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_SupportedPlaybackRates
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_SupportedPlaybackRates
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SupportedPlaybackRates
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SupportedPlaybackRates Property

Gets or sets the playback rates list.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property SupportedPlaybackRates As IList(Of Double)
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As IList(Of Double)

value = instance.SupportedPlaybackRates

instance.SupportedPlaybackRates = value
```

```csharp
  public IList<double> SupportedPlaybackRates { get; set; }
```

```cpp
  public:
property IList<double>^ SupportedPlaybackRates {
    IList<double>^ get ();
    void set (IList<double>^ value);
}
```

```jscript
  function get SupportedPlaybackRates () : IList<double>
function set SupportedPlaybackRates (value : IList<double>)
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6)\< (Of \< ( \<'[Double](https://msdn.microsoft.com/library/643eft0t)\> ) \> ) \>  
A list of numbers that represent the playback rates.  

## Remarks

For more information and for examples, see [Fast Forward and Rewind Modes (IIS Smooth Streaming)](fast-forward-and-rewind-modes.md).

> [!NOTE]  
> This property currently is not supported for audio-only playback.

## Examples

To set the playback rate, call the [SetPlaybackRate](smoothstreamingmediaelement-setplaybackrate-method-microsoft-web-media-smoothstreaming_1.md) method with a value from the SupportedPlaybackRates collection.

The following example shows how to get the available playback rates.

```csharp
// Usable playback rates
IList<double> playbackRates = SmoothPlayer.SupportedPlaybackRates;
```

After the previous line of code runs, the list will contain the following values:

```
-8.0, -4.0, 0.5, 1, 4.0, 8.0.
```

Positive values set the playback rate to half the normal speed, 4.0 times the normal speed, or 8.0 times the normal speed. Negative values rewind the media stream at rates that are multiples of the normal speed by factors of -4.0 or -8.0.

The following example shows how to call the [SetPlaybackRate](smoothstreamingmediaelement-setplaybackrate-method-microsoft-web-media-smoothstreaming_1.md) method and pass it a value from the SupportedPlaybackRates collection.

```csharp
SmoothPlayer.SetPlaybackRate(playbackRates[2]);
```

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
