---
title: Manifest Class
TOCTitle: Manifest Class
ms:assetid: f0a9e6d7-5714-49c0-9470-25fa5be0013f
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822869(v=VS.90)
ms:contentKeyID: 50079623
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# Manifest Class

**Applies to:** Windows Store apps only

The manifest class.

## Syntax

``` csharp
[VersionAttribute()]
public sealed class Manifest
```

``` c++
[VersionAttribute()]
public ref class Manifest sealed
```

``` jscript
public final class Manifest
```

## Members

This class exposes the following members.

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
<td><p><a href="manifest-getattribute-method.md">GetAttribute</a></p></td>
<td><p>Gets the stream level attributes from the manifest.</p></td>
</tr>
<tr class="even">
<td><p><a href="manifest-selectstreamsasync-method.md">SelectStreamsAsync</a></p></td>
<td><p>Select the streams in the current manifest.</p></td>
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
<td><p><a href="manifest-availablestreams-property.md">AvailableStreams</a></p></td>
<td><p>Gets the available streams.</p></td>
</tr>
<tr class="even">
<td><p><a href="manifest-duration-property.md">Duration</a></p></td>
<td><p>Gets the manifest 'Duration' field.</p></td>
</tr>
<tr class="odd">
<td><p><a href="manifest-dvrwindowlength-property.md">DVRWindowLength</a></p></td>
<td><p>Gets the manifest 'DVRWindowLength' field.</p></td>
</tr>
<tr class="even">
<td><p><a href="manifest-islive-property.md">IsLive</a></p></td>
<td><p>Gets the manifest 'isLive' field.</p></td>
</tr>
<tr class="odd">
<td><p><a href="manifest-lookaheadcount-property.md">LookAheadCount</a></p></td>
<td><p>Gets the manifest 'LookAheadFragmentCount' field.</p></td>
</tr>
<tr class="even">
<td><p><a href="manifest-majorversion-property.md">MajorVersion</a></p></td>
<td><p>Gets the manifest 'MajorVersion' field.</p></td>
</tr>
<tr class="odd">
<td><p><a href="manifest-minorversion-property.md">MinorVersion</a></p></td>
<td><p>Gets the manifest 'MinorVersion' field.</p></td>
</tr>
<tr class="even">
<td><p><a href="manifest-selectedstreams-property.md">SelectedStreams</a></p></td>
<td><p>Gets the selected streams.</p></td>
</tr>
<tr class="odd">
<td><p><a href="manifest-starttime-property.md">StartTime</a></p></td>
<td><p>Gets the manifest start time.</p></td>
</tr>
<tr class="even">
<td><p><a href="manifest-timescale-property.md">TimeScale</a></p></td>
<td><p>Gets the manifest 'TimeScale' field.</p></td>
</tr>
<tr class="odd">
<td><p><a href="manifest-type-property.md">Type</a></p></td>
<td><p></p></td>
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

