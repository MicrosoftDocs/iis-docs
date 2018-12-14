---
title: IManifestStream.ParentStream Property
TOCTitle: ParentStream Property
ms:assetid: c37eda53-90cc-4b67-a1bd-185b3e186581
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822830(v=VS.90)
ms:contentKeyID: 50079584
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IManifestStream.ParentStream Property

**Applies to:** Windows Store apps only

Gets the parent stream of this stream.

## Syntax

``` csharp
IManifestStream ParentStream { get; }
```

``` c++
property IManifestStream^ ParentStream {
IManifestStream^ get ();
}
```

``` jscript
function get ParentStream () : IManifestStream
```

## Property Value

The parent stream of this stream.

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

