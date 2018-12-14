---
title: IIS Smooth Streaming Server Manifest (On-Demand) - meta Element
TOCTitle: <meta>
ms:assetid: e4397b74-1779-48a3-97a2-cffeb65ccdd5
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee230820(v=VS.90)
ms:contentKeyID: 22049448
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (On-Demand) - meta Element

The meta element specifies a single piece of presentation-level metadata.

[IIS Smooth Streaming Server Manifest (On-Demand) - head Element](iis-smooth-streaming-server-manifest-on-demand-head-element.md)  

    <meta name="title" content="{content title}"/>

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
<td><p>name</p></td>
<td><p>The title of the presentation.This attribute is required.</p></td>
</tr>
<tr class="even">
<td><p>content</p></td>
<td><p>Specifies the value of the metadata.This attribute is required.</p></td>
</tr>
</tbody>
</table>


#### name Attribute

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Value</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>title</p></td>
<td><p>The content attribute specifies a title.</p></td>
</tr>
<tr class="even">
<td><p>clientManfiestPath</p></td>
<td><p>The content attribute specifies the physical path of the client manifest relative to the server manifest.</p></td>
</tr>
</tbody>
</table>


#### Child Elements

None

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
<td><p>head</p></td>
<td><p>The head element is a container for presentation-level metadata.</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[IIS Smooth Streaming Server Manifest (On-Demand) - head Element](iis-smooth-streaming-server-manifest-on-demand-head-element.md)

