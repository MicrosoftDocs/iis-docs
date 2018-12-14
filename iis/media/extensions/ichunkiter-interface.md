---
title: IChunkIter Interface
TOCTitle: IChunkIter Interface
ms:assetid: bff052ca-5f58-4f2e-8c99-cdabbed9a130
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822824(v=VS.90)
ms:contentKeyID: 50079578
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IChunkIter Interface

**Applies to:** Windows Store apps only

ChunkIter interface.

## Syntax

``` csharp
[GuidAttribute(, , , , , , , , , , )] 

[VersionAttribute()]

public interface IChunkIter
```

``` c++
[GuidAttribute(, , , , , , , , , , )] 

[VersionAttribute()]

public interface class IChunkIter
```

``` jscript
public interface IChunkIter
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
<td><p><a href="ichunkiter-movenext-method.md">MoveNext</a></p></td>
<td><p>Move to the next chunk.</p></td>
</tr>
<tr class="even">
<td><p><a href="ichunkiter-moveprev-method.md">MovePrev</a></p></td>
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

