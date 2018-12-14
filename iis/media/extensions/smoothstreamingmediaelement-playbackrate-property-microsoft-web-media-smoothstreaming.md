---
title: SmoothStreamingMediaElement.PlaybackRate Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: PlaybackRate Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PlaybackRate
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.playbackrate(v=VS.90)
ms:contentKeyID: 23961065
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PlaybackRate
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_PlaybackRate
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_PlaybackRate
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.PlaybackRate
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# PlaybackRate Property

Gets the playback rate.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyPlaybackRateAsNullable(OfDouble)
'Usage
DiminstanceAsSmoothStreamingMediaElementDimvalueAsNullable(OfDouble)

value = instance.PlaybackRate
```

``` csharp
publicNullable<double> PlaybackRate { get; }
```

``` c++
public:
propertyNullable<double> PlaybackRate {
    Nullable<double> get ();
}
```

``` jscript
function getPlaybackRate () : Nullable<double>
```

#### Property Value

Type: [System. . :: . .Nullable](https://msdn.microsoft.com/en-us/library/b3h38hb0\(v=vs.90\))\< (Of \< ( \<'[Double](https://msdn.microsoft.com/en-us/library/643eft0t\(v=vs.90\))\> ) \> ) \>  
A value from the [SupportedPlaybackRates](smoothstreamingmediaelement-supportedplaybackrates-property-microsoft-web-media-smoothstreaming_1.md) list.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

