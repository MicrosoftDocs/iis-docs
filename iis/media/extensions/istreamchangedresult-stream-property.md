---
title: IStreamChangedResult.Stream Property
TOCTitle: Stream Property
ms:assetid: d17fa187-f0fd-4302-a914-3604b9368204
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822838(v=VS.90)
ms:contentKeyID: 50079592
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IStreamChangedResult.Stream Property

**Applies to:** Windows Store apps only

Gets the stream that is selected or de-selected

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

The stream that is selected or de-selected.

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

