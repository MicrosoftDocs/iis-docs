---
title: ChunkIter Class
TOCTitle: ChunkIter Class
ms:assetid: 015c26af-c923-407e-9fae-ca3f848770b7
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ851081(v=VS.90)
ms:contentKeyID: 50079420
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ChunkIter Class

**Applies to:** Windows Store apps only

Chunk iterator class.

## Syntax

``` csharp
[VersionAttribute()]
public sealed class ChunkIter : IChunkIter
```

``` c++
[VersionAttribute()]
public ref class ChunkIter sealed : IChunkIter
```

``` jscript
public final class ChunkIter implements IChunkIter
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
<td><p><a href="movenext-method.md">MoveNext</a></p></td>
<td><p>Move to the next chunk.</p></td>
</tr>
<tr class="even">
<td><p><a href="moveprev-method.md">MovePrev</a></p></td>
<td><p>Move to the previous chunk.</p></td>
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

