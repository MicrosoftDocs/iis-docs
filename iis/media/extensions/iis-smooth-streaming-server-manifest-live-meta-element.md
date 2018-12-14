---
title: IIS Smooth Streaming Server Manifest (Live) - meta Element
TOCTitle: <meta>
ms:assetid: fe6e56c1-2d82-405d-b00b-d843316675ab
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee673446(v=VS.90)
ms:contentKeyID: 26179487
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (Live) - meta Element

The meta element specifies a single piece of presentation-level metadata.

[IIS Smooth Streaming Server Manifest (Live) - head Element](iis-smooth-streaming-server-manifest-live-head-element.md)  

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


## Remarks

In the live manifest scenario, the clientManifestRelativePath value for the name attribute must be omitted.

## See Also

#### Reference

[IIS Smooth Streaming Server Manifest (Live) - head Element](iis-smooth-streaming-server-manifest-live-head-element.md)

