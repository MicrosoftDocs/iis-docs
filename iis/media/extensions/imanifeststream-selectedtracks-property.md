---
title: IManifestStream.SelectedTracks Property
TOCTitle: SelectedTracks Property
ms:assetid: bca9989e-270d-4bf6-90ae-ae587b63855d
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822818(v=VS.90)
ms:contentKeyID: 50079572
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IManifestStream.SelectedTracks Property

**Applies to:** Windows Store apps only

Gets the selected tracks in the current stream.

## Syntax

``` csharp
IVectorView<IManifestTrack> SelectedTracks { get; }
```

``` c++
property IVectorView<IManifestTrack^>^ SelectedTracks {
IVectorView<IManifestTrack^>^ get ();
}
```

``` jscript
function get SelectedTracks () : IVectorView<IManifestTrack>
```

## Property Value

The selected tracks in the current stream.

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

