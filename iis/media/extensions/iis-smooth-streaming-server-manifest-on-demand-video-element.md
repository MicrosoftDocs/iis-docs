---
title: IIS Smooth Streaming Server Manifest (On-Demand) - video Element
TOCTitle: <video>
ms:assetid: 06fa3ec9-3f49-4533-8737-6809e07392c2
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee230807(v=VS.90)
ms:contentKeyID: 22049435
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (On-Demand) - video Element

The video element specifies a single track of video data.

[IIS Smooth Streaming Server Manifest (On-Demand) - switch Element](iis-smooth-streaming-server-manifest-on-demand-switch-element.md)  

    <video src="path" systemBitrate="bitrate number" >   <param name="parameter name" value="value" valuetype="data type" />
    </video>

## Attributes and Elements

The following sections describe attributes, child elements, and parent elements.

#### Attributes

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Attribute</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>src</p></td>
<td><p>Specifies the file in which the track resides. This attribute is required.</p></td>
</tr>
<tr class="even">
<td><p>systemBitrate</p></td>
<td><p>Specifies the bit rate of the track. This value is matched to the argument of the QualityLevels() noun on the URL.This attribute is required.</p></td>
</tr>
<tr class="odd">
<td><p>systemLanguage</p></td>
<td><p>Specifies the language of the track using an RFC-1766 identifier. This is an informative tagging scheme and distinct track names are still required in order to discriminate between tracks at the same bit rate in different languages. This attribute is optional.</p></td>
</tr>
</tbody>
</table>


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
<td><p>param</p></td>
<td><p>The param element specifies a single parameter for a video element.</p></td>
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
<td><p>switch</p></td>
<td><p>The switch element is a container for track information.</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[IIS Smooth Streaming Server Manifest (On-Demand) - switch Element](iis-smooth-streaming-server-manifest-on-demand-switch-element.md)

[IIS Smooth Streaming Server Manifest (On-Demand) - textstream param Element](iis-smooth-streaming-server-manifest-on-demand-textstream-param-element.md)

