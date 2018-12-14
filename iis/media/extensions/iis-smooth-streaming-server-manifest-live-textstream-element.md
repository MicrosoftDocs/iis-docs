---
title: IIS Smooth Streaming Server Manifest (Live) - textstream Element
TOCTitle: <textstream>
ms:assetid: 2ca89d4c-abe0-482c-9391-4d3ee2eb677a
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee673431(v=VS.90)
ms:contentKeyID: 26179474
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (Live) - textstream Element

The textstream element specifies a single track of textstream data.

[IIS Smooth Streaming Server Manifest (Live) - switch Element](iis-smooth-streaming-server-manifest-live-switch-element.md)  
  [IIS Smooth Streaming Server Manifest (Live) - video param Element](iis-smooth-streaming-server-manifest-live-video-param-element.md)  

    <textstream src="path" systemBitrate="bitrate number" >   <param name="parameter name" value="value" valuetype="data type" />
    </ textstream >

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
<td><p>Specifies the location in which the track resides. This location may be a URL relative to the encoder URL from which the Live Server Manifest was retrieved, or an absolute URL if an absolute url is specified. The value of the src attribute must be same for all tracks in the manifest. This attribute is required.</p></td>
</tr>
<tr class="even">
<td><p>systemBitrate</p></td>
<td><p>Specifies the bit rate of the track. This value is matched to the argument of the QualityLevels() noun on the URL. This attribute is required.</p></td>
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
<td><p>The param element specifies a single parameter for a textstream element.</p></td>
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


## Remarks

Text tracks are commonly used for closed captioning, script streaming, and chapter markers. Smooth Streaming also gives content producers the option of representing text data in a content element of the [IIS Smooth Streaming Client Manifest](iis-smooth-streaming-client-manifest.md) instead of encoding the text data as a text track.

## See Also

#### Reference

[IIS Smooth Streaming Server Manifest (Live) - switch Element](iis-smooth-streaming-server-manifest-live-switch-element.md)

[IIS Smooth Streaming Server Manifest (Live) - video param Element](iis-smooth-streaming-server-manifest-live-video-param-element.md)

