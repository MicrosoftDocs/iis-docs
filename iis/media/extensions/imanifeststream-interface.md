---
title: IManifestStream Interface
TOCTitle: IManifestStream Interface
ms:assetid: ddaf345c-e931-40e2-82eb-e819f04876d2
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822846(v=VS.90)
ms:contentKeyID: 50079600
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IManifestStream Interface

**Applies to:** Windows Store apps only

Represents the stream interface.

## Syntax

``` csharp
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public interface IManifestStream
```

``` c++
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public interface class IManifestStream
```

``` jscript
public interface IManifestStream
```

## Members

This interface exposes the following members.

### Methods

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Method</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><a href="imanifeststream-downloadfragmentasync-method.md">DownloadFragmentAsync</a></p></td>
<td><p>Downloads the fragment data for the given chunk iterator through async call.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifeststream-getattribute-method.md">GetAttribute</a></p></td>
<td><p>Gets the stream level attributes from the manifest.</p></td>
</tr>
<tr class="odd">
<td><p><a href="imanifeststream-getchunkinfoasync-method.md">GetChunkInfoAsync</a></p></td>
<td><p>Gets the chunk info of the given chunk iterator through async call.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifeststream-getiterator-method.md">GetIterator</a></p></td>
<td><p>Gets the last chunk iterator within the specified time range.</p></td>
</tr>
<tr class="odd">
<td><p><a href="imanifeststream-restricttracks-method.md">RestrictTracks</a></p></td>
<td><p>Restricts the tracks to a subset of all the available tracks.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifeststream-selecttracks-method.md">SelectTracks</a></p></td>
<td><p>Selects the tracks in a subset of all the available tracks.</p></td>
</tr>
</tbody>
</table>


### Properties

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Property</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><a href="imanifeststream-availabletracks-property.md">AvailableTracks</a></p></td>
<td><p>Gets the available tracks in the current stream.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifeststream-childstreams-property.md">ChildStreams</a></p></td>
<td><p>Gets the child (sparse) streams of this stream.</p></td>
</tr>
<tr class="odd">
<td><p><a href="imanifeststream-displayheight-property.md">DisplayHeight</a></p></td>
<td><p>Gets the stream 'DisplayHeight' field.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifeststream-displaywidth-property.md">DisplayWidth</a></p></td>
<td><p>Gets the stream 'DisplayWidth' field.</p></td>
</tr>
<tr class="odd">
<td><p><a href="imanifeststream-firstincurrentchunklist-property.md">FirstInCurrentChunklist</a></p></td>
<td><p>Gets the first chunk iterator in the current chunklist.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifeststream-language-property.md">Language</a></p></td>
<td><p>Gets the stream 'Language' field.</p></td>
</tr>
<tr class="odd">
<td><p><a href="imanifeststream-lastincurrentchunklist-property.md">LastInCurrentChunkList</a></p></td>
<td><p>Gets the last chunk iterator in the current chunklist.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifeststream-maxheight-property.md">MaxHeight</a></p></td>
<td><p>Gets the stream 'MaxHeight' field.</p></td>
</tr>
<tr class="odd">
<td><p><a href="imanifeststream-maxwidth-property.md">MaxWidth</a></p></td>
<td><p>Gets the stream 'MaxWidth' field.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifeststream-name-property.md">Name</a></p></td>
<td><p>Gets the stream 'Name' field.</p></td>
</tr>
<tr class="odd">
<td><p><a href="imanifeststream-parentstream-property.md">ParentStream</a></p></td>
<td><p>Gets the parent stream of this stream.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifeststream-selectedtracks-property.md">SelectedTracks</a></p></td>
<td><p>Gets the selected tracks in the current stream.</p></td>
</tr>
<tr class="odd">
<td><p><a href="imanifeststream-subtype-property.md">SubType</a></p></td>
<td><p>Gets the stream 'SubType' field.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifeststream-timescale-property.md">TimeScale</a></p></td>
<td><p>Gets the stream 'TimeScale' field.</p></td>
</tr>
<tr class="odd">
<td><p><a href="imanifeststream-type-property.md">Type</a></p></td>
<td><p>Gets the stream 'Type' field.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifeststream-url-property.md">Url</a></p></td>
<td><p>Gets the url template.</p></td>
</tr>
</tbody>
</table>


## Requirements

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p><strong>Minimum supported client</strong></p></td>
<td><p>Windows 8</p></td>
</tr>
<tr class="even">
<td><p><strong>Minimum supported server</strong></p></td>
<td><p>Not Supported</p></td>
</tr>
<tr class="odd">
<td><p><strong>Metadata</strong></p></td>
<td><p>Microsoft.Media.AdaptiveStreaming.winmd</p></td>
</tr>
</tbody>
</table>

