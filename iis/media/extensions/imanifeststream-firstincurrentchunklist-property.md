---
title: IManifestStream.FirstInCurrentChunkList Property
TOCTitle: FirstInCurrentChunkList Property
ms:assetid: 4b2ce767-a162-47c0-9f38-9817c8179c2f
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822729(v=VS.90)
ms:contentKeyID: 50079484
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IManifestStream.FirstInCurrentChunkList Property

**Applies to:** Windows Store apps only

Gets the first chunk iterator in the current chunklist.

## Syntax

``` csharp
IChunkIter FirstInCurrentChunkList { get; }
```

``` c++
property IChunkIter^ FirstInCurrentChunkList {
IChunkIter^ get ();
}
```

``` jscript
function get FirstInCurrentChunkList () : IChunkIter
```

## Property Value

The first chunk iterator in the current chunklist.

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

