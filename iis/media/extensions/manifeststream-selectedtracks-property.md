---
title: ManifestStream.SelectedTracks Property
TOCTitle: SelectedTracks Property
ms:assetid: 0c5ad117-bcae-4f9f-97ee-335f3aee7a7d
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822676(v=VS.90)
ms:contentKeyID: 50079431
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestStream.SelectedTracks Property

Gets the selected tracks in the current stream.

## Syntax

``` csharp
public IVectorView<IManifestTrack> SelectedTracks { get; }
```

``` c++
public:
virtual property IVectorView<IManifestTrack^>^ SelectedTracks {
IVectorView<IManifestTrack^>^ get () sealed;
}
```

``` jscript
final function get SelectedTracks () : IVectorView<IManifestTrack>
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

