---
title: SmoothStreamingMediaElement.SupportedPlaybackRates Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SupportedPlaybackRates Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SupportedPlaybackRates
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.supportedplaybackrates(v=VS.95)
ms:contentKeyID: 46307855
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SupportedPlaybackRates
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_SupportedPlaybackRates
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_SupportedPlaybackRates
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_SupportedPlaybackRates
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_SupportedPlaybackRates
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SupportedPlaybackRates
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.SupportedPlaybackRates Property

Gets or sets the playback rates list.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property SupportedPlaybackRates As IList(Of Double)
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As IList(Of Double)

value = instance.SupportedPlaybackRates

instance.SupportedPlaybackRates = value
```

``` csharp
public IList<double> SupportedPlaybackRates { get; set; }
```

``` c++
public:
property IList<double>^ SupportedPlaybackRates {
    IList<double>^ get ();
    void set (IList<double>^ value);
}
```

``` fsharp
member SupportedPlaybackRates : IList<float> with get, set
```

``` jscript
function get SupportedPlaybackRates () : IList<double>
function set SupportedPlaybackRates (value : IList<double>)
```

#### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/en-us/library/5y536ey6\(v=vs.95\))\<[Double](https://msdn.microsoft.com/en-us/library/643eft0t\(v=vs.95\))\>  
A list of numbers that represent the playback rates.

## Remarks

For more information and for examples, see [Fast Forward and Rewind Modes](fast-forward-and-rewind-modes.md).


> [!NOTE]
> <P>This property currently is not supported for audio-only playback.</P>



## Examples

To set the playback rate, call the [SetPlaybackRate](smoothstreamingmediaelement-setplaybackrate-method-microsoft-web-media-smoothstreaming_1.md) method with a value from the SupportedPlaybackRates collection.

The following example shows how to get the available playback rates.

    // Usable playback rates
    IList<double> playbackRates = SmoothPlayer.SupportedPlaybackRates;

After the previous line of code runs, the list will contain the following values:

    -8.0, -4.0, 0.5, 1, 4.0, 8.0.

Positive values set the playback rate to half the normal speed, 4.0 times the normal speed, or 8.0 times the normal speed. Negative values rewind the media stream at rates that are multiples of the normal speed by factors of -4.0 or -8.0.

The following example shows how to call the [SetPlaybackRate](smoothstreamingmediaelement-setplaybackrate-method-microsoft-web-media-smoothstreaming_1.md) method and pass it a value from the SupportedPlaybackRates collection.

    SmoothPlayer.SetPlaybackRate(playbackRates[2]);

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

