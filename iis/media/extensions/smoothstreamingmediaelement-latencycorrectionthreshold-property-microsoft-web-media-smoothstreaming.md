---
title: SmoothStreamingMediaElement.LatencyCorrectionThreshold Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: LatencyCorrectionThreshold Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LatencyCorrectionThreshold
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.latencycorrectionthreshold(v=VS.90)
ms:contentKeyID: 32682299
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_LatencyCorrectionThreshold
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_LatencyCorrectionThreshold
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LatencyCorrectionThreshold
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_LatencyCorrectionThreshold
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LatencyCorrectionThreshold
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_LatencyCorrectionThreshold
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LatencyCorrectionThreshold Property

Gets or sets the latency correction threshold for live playback.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyLatencyCorrectionThresholdAsTimeSpan
'Usage
DiminstanceAsSmoothStreamingMediaElementDimvalueAsTimeSpanvalue = instance.LatencyCorrectionThreshold

instance.LatencyCorrectionThreshold = value
```

``` csharp
publicTimeSpanLatencyCorrectionThreshold { get; set; }
```

``` c++
public:
propertyTimeSpanLatencyCorrectionThreshold {
    TimeSpanget ();
    voidset (TimeSpanvalue);
}
```

``` jscript
function getLatencyCorrectionThreshold () : TimeSpanfunction setLatencyCorrectionThreshold (value : TimeSpan)
```

#### Property Value

Type: [System. . :: . .TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\))  
The latency correction threshold.  

## Exceptions

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th>Exception</th>
<th>Condition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><a href="https://msdn.microsoft.com/en-us/library/2asft85a(v=vs.90)">InvalidOperationException</a></td>
<td><p>The value is smaller than the sum of the <a href="smoothstreamingmediaelement-livebackoff-property-microsoft-web-media-smoothstreaming_1.md">LiveBackOff</a> value and the maximum between the <a href="smoothstreamingmediaelement-bufferingtime-property-microsoft-web-media-smoothstreaming_1.md">BufferingTime</a> and the <a href="smoothstreamingmediaelement-liveplaybackoffset-property-microsoft-web-media-smoothstreaming_1.md">LivePlaybackOffset</a> values.</p></td>
</tr>
</tbody>
</table>


## Remarks

This property indicates the threshold at which content is deemed late and will be discarded. A default value of -1 indicates that no content is discarded. Changes that are made to this value after the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) property has been set are disregarded.

Avoid using B-frames in the encoded stream if you intend to use the LatencyCorrectionThreshold property.

## Version Information

#### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

[BufferingTime](https://msdn.microsoft.com/en-us/library/cc190360\(v=vs.90\))

