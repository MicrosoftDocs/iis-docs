---
title: IManifestStream.LastInCurrentChunkList Property
TOCTitle: LastInCurrentChunkList Property
ms:assetid: 2c0de4a6-54e2-4d74-96c4-618f924be1e0
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822707(v=VS.90)
ms:contentKeyID: 50079462
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IManifestStream.LastInCurrentChunkList Property

**Applies to:** Windows Store apps only

Gets the last chunk iterator in the current chunklist.

## Syntax

``` csharp
IChunkIter LastInCurrentChunkList { get; }
```

``` c++
property IChunkIter^ LastInCurrentChunkList {
         IChunkIter^ get ();
```

``` jscript
function get LastInCurrentChunkList () : IChunkIter
```

## Property Value

The last chunk iterator in the current chunklist.

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

