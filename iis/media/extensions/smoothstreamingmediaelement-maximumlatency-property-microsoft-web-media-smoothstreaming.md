---
title: SmoothStreamingMediaElement.MaximumLatency Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: MaximumLatency Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MaximumLatency
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.maximumlatency(v=VS.90)
ms:contentKeyID: 32682289
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_MaximumLatency
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MaximumLatency
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_MaximumLatency
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_MaximumLatency
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MaximumLatency
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_MaximumLatency
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# MaximumLatency Property

Gets or sets the upper limit of latency correction threshold

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyMaximumLatencyAsTimeSpan
'Usage
DiminstanceAsSmoothStreamingMediaElementDimvalueAsTimeSpanvalue = instance.MaximumLatency

instance.MaximumLatency = value
```

``` csharp
publicTimeSpanMaximumLatency { get; set; }
```

``` c++
public:
propertyTimeSpanMaximumLatency {
    TimeSpanget ();
    voidset (TimeSpanvalue);
}
```

``` jscript
function getMaximumLatency () : TimeSpanfunction setMaximumLatency (value : TimeSpan)
```

#### Property Value

Type: [System. . :: . .TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\))  
The maximum time interval beyond which frames are dropped and the media element surface is blank.  

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
<td><p>The property is set to zero or set to a value smaller than the <a href="smoothstreamingmediaelement-latencycorrectionthreshold-property-microsoft-web-media-smoothstreaming.md">LatencyCorrectionThreshold</a> value.</p></td>
</tr>
</tbody>
</table>


## Remarks

The value has effect only when the [LatencyCorrectionThreshold](smoothstreamingmediaelement-latencycorrectionthreshold-property-microsoft-web-media-smoothstreaming.md) property has been set. The default value of -1 indicates that there is no upper limit to the latency threshold. Changes that are made to this value after the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) property has been set are disregarded.

## Version Information

#### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

