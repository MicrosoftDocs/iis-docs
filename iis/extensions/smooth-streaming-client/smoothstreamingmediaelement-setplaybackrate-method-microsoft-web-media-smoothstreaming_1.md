---
title: SmoothStreamingMediaElement.SetPlaybackRate Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SetPlaybackRate Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SetPlaybackRate(System.Double)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.setplaybackrate(v=VS.95)
ms:contentKeyID: 46307693
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SetPlaybackRate
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SetPlaybackRate
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.SetPlaybackRate Method

Sets the playback rate of media stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Sub SetPlaybackRate ( _
    playbackRate As Double _
)
'Usage

Dim instance As SmoothStreamingMediaElement
Dim playbackRate As Double

instance.SetPlaybackRate(playbackRate)
```

```csharp
public void SetPlaybackRate(
    double playbackRate
)
```

```cpp
public:
void SetPlaybackRate(
    double playbackRate
)
```

``` fsharp
member SetPlaybackRate : 
        playbackRate:float -> unit 
```

```jscript
public function SetPlaybackRate(
    playbackRate : double
)
```

### Parameters

  - playbackRate  
    Type: [System.Double](https://msdn.microsoft.com/library/643eft0t\(v=vs.95\))  
    The playback rate.

## Remarks

For more information and for examples, see [Fast Forward and Rewind Modes](fast-forward-and-rewind-modes.md).

## Examples

To set the playback rate, use the SetPlaybackRate method using a value from the [SupportedPlaybackRates](smoothstreamingmediaelement-supportedplaybackrates-property-microsoft-web-media-smoothstreaming_1.md) collection.

The following example shows how to get the available playback rates.

    // Usable playback rates
        IList<double> playbackRates = SmoothPlayer.SupportedPlaybackRates;

After the previous line of code runs the list will contain the following values:

    -8.0, -4.0, 0.5, 1, 4.0, 8.0.

Positive values set the playback rate to half the normal speed, 4.0 times the normal speed, or 8.0 times the normal speed. Negative values rewind the media stream at rates that are multiples of the normal speed by factors of -4.0 or -8.0.

The following example shows how to call the SetPlaybackRate method using a value from the [SupportedPlaybackRates](smoothstreamingmediaelement-supportedplaybackrates-property-microsoft-web-media-smoothstreaming_1.md) collection.

``` 
    SmoothPlayer.SetPlaybackRate(playbackRates[2]);
```

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
