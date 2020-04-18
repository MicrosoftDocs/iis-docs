---
title: SmoothStreamingMediaElement.LatencyCorrectionThreshold Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: LatencyCorrectionThreshold Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LatencyCorrectionThreshold
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.latencycorrectionthreshold(v=VS.90)
ms:contentKeyID: 32682299
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_LatencyCorrectionThreshold
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_LatencyCorrectionThreshold
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LatencyCorrectionThreshold
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_LatencyCorrectionThreshold
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LatencyCorrectionThreshold
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_LatencyCorrectionThreshold
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# LatencyCorrectionThreshold Property

Gets or sets the latency correction threshold for live playback.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property LatencyCorrectionThreshold As TimeSpan
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As TimeSpan

value = instance.LatencyCorrectionThreshold

instance.LatencyCorrectionThreshold = value
```

```csharp
  public TimeSpan LatencyCorrectionThreshold { get; set; }
```

```cpp
  public:
property TimeSpan LatencyCorrectionThreshold {
    TimeSpan get ();
    void set (TimeSpan value);
}
```

```jscript
  function get LatencyCorrectionThreshold () : TimeSpan
function set LatencyCorrectionThreshold (value : TimeSpan)
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577)  
The latency correction threshold.  

## Exceptions

|Exception|Condition|
|--- |--- |
|[InvalidOperationException](https://msdn.microsoft.com/library/2asft85a)|The value is smaller than the sum of the [LiveBackOff](smoothstreamingmediaelement-livebackoff-property-microsoft-web-media-smoothstreaming_1.md) value and the maximum between the [BufferingTime](smoothstreamingmediaelement-bufferingtime-property-microsoft-web-media-smoothstreaming_1.md) and the [LivePlaybackOffset](smoothstreamingmediaelement-liveplaybackoffset-property-microsoft-web-media-smoothstreaming_1.md) values.|

## Remarks

This property indicates the threshold at which content is deemed late and will be discarded. A default value of -1 indicates that no content is discarded. Changes that are made to this value after the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) property has been set are disregarded.

Avoid using B-frames in the encoded stream if you intend to use the LatencyCorrectionThreshold property.

## Version Information

### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

[BufferingTime](https://msdn.microsoft.com/library/cc190360)
