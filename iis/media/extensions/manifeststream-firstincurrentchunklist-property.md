---
title: ManifestStream.FirstInCurrentChunkList Property
TOCTitle: FirstInCurrentChunkList Property
ms:assetid: 2021ddf8-b4b9-44c1-8fe4-5cc652b8bef6
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822699(v=VS.90)
ms:contentKeyID: 50079454
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestStream.FirstInCurrentChunkList Property

**Applies to:** Windows Store apps only

Gets the first chunk iterator in the current chunklist.

## Syntax

``` csharp
public IChunkIter FirstInCurrentChunkList { get; }
```

``` c++
public:
virtual property IChunkIter^ FirstInCurrentChunkList {
IChunkIter^ get () sealed;
}
```

``` jscript
final function get FirstInCurrentChunkList () : IChunkIter
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

