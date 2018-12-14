---
title: IIS Smooth Streaming Server Manifest (Live) - body Element
TOCTitle: <body>
ms:assetid: 32015356-29af-4e0b-a81b-c198939235a0
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee673432(v=VS.90)
ms:contentKeyID: 26179475
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (Live) - body Element

The body element is a container for track information and references to other media.

[IIS Smooth Streaming Server Manifest (Live) - smil Element](iis-smooth-streaming-server-manifest-live-smil-element.md)  
  [IIS Smooth Streaming Server Manifest (Live) - switch Element](iis-smooth-streaming-server-manifest-live-switch-element.md)  

    <body>
    </body>

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
<td><p>switch</p></td>
<td><p>The switch element is a container for track information. A Smooth Streaming presentation must contain one or more <a href="iis-smooth-streaming-server-manifest-live-video-element.md">IIS Smooth Streaming Server Manifest (Live) - video Element</a>, <a href="iis-smooth-streaming-server-manifest-live-audio-element.md">IIS Smooth Streaming Server Manifest (Live) - audio Element</a>, and <a href="iis-smooth-streaming-server-manifest-live-textstream-element.md">IIS Smooth Streaming Server Manifest (Live) - textstream Element</a> tracks.</p></td>
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
<td><p>smil</p></td>
<td><p>Smooth Streaming uses the SMIL 2.0 format for Server Manifest. The smil element is the root container used by SMIL 2.0.</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[IIS Smooth Streaming Server Manifest (Live) - smil Element](iis-smooth-streaming-server-manifest-live-smil-element.md)

[IIS Smooth Streaming Server Manifest (Live) - switch Element](iis-smooth-streaming-server-manifest-live-switch-element.md)

