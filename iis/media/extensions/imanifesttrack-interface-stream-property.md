---
title: IManifestTrack Interface.Stream Property
TOCTitle: Stream Property
ms:assetid: a42aa3f4-56a8-4357-a1f3-7047c68e32d7
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822800(v=VS.90)
ms:contentKeyID: 50079554
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IManifestTrack Interface.Stream Property

**Applies to:** Windows Store apps only

Gets the stream object that owns this track.

## Syntax

``` csharp
IManifestStream Stream { get; }
```

``` c++
property IManifestStream^ Stream {
IManifestStream^ get ();
}
```

``` jscript
function get Stream () : IManifestStream
```

## Property Value

The stream object that owns this track.

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

