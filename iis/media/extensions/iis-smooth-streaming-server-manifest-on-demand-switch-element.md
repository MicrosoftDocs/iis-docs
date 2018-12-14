---
title: IIS Smooth Streaming Server Manifest (On-Demand) - switch Element
TOCTitle: <switch>
ms:assetid: 52109d46-962d-4421-8a91-256ef637614c
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee230812(v=VS.90)
ms:contentKeyID: 22049440
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (On-Demand) - switch Element

The switch element is a container for track information.

[IIS Smooth Streaming Server Manifest (On-Demand) - body Element](iis-smooth-streaming-server-manifest-on-demand-body-element.md)  
  [IIS Smooth Streaming Server Manifest (On-Demand) - video Element](iis-smooth-streaming-server-manifest-on-demand-video-element.md)  
    [IIS Smooth Streaming Server Manifest (On-Demand) - audio Element](iis-smooth-streaming-server-manifest-on-demand-audio-element.md)  
      [IIS Smooth Streaming Server Manifest (On-Demand) - textstream Element](iis-smooth-streaming-server-manifest-on-demand-textstream-element.md)  

    <switch>
    </switch>

## Attributes and Elements

The following sections describe attributes, child elements, and parent elements.

#### Attributes

None

#### Child Elements

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Element</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>video</p></td>
<td><p>The video element specifies a single track of video data.</p></td>
</tr>
<tr class="even">
<td><p>audio</p></td>
<td><p>The audio element specifies a single track of audio data.</p></td>
</tr>
<tr class="odd">
<td><p>textstream</p></td>
<td><p>The textstream element specifies a single track of textstream data. Text tracks are commonly used for closed captioning, script streaming and chapter markers.</p></td>
</tr>
</tbody>
</table>


#### Parent Elements

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Element</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>body</p></td>
<td><p>The body element is a container for track information and references to other media.</p></td>
</tr>
</tbody>
</table>


## Remarks

A Smooth Streaming presentation must contain one or more tracks (specified by [IIS Smooth Streaming Server Manifest (On-Demand) - video Element](iis-smooth-streaming-server-manifest-on-demand-video-element.md), [IIS Smooth Streaming Server Manifest (On-Demand) - audio Element](iis-smooth-streaming-server-manifest-on-demand-audio-element.md) and [IIS Smooth Streaming Server Manifest (On-Demand) - textstream Element](iis-smooth-streaming-server-manifest-on-demand-textstream-element.md) elements).

## See Also

#### Reference

[IIS Smooth Streaming Server Manifest (On-Demand) - body Element](iis-smooth-streaming-server-manifest-on-demand-body-element.md)

[IIS Smooth Streaming Server Manifest (On-Demand) - video Element](iis-smooth-streaming-server-manifest-on-demand-video-element.md)

[IIS Smooth Streaming Server Manifest (On-Demand) - audio Element](iis-smooth-streaming-server-manifest-on-demand-audio-element.md)

[IIS Smooth Streaming Server Manifest (On-Demand) - textstream Element](iis-smooth-streaming-server-manifest-on-demand-textstream-element.md)

