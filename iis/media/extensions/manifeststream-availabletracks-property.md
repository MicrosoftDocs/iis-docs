---
title: ManifestStream.AvailableTracks Property
TOCTitle: AvailableTracks Property
ms:assetid: 9cd8b94c-363d-4683-ba41-2c095d577331
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822793(v=VS.90)
ms:contentKeyID: 50079547
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestStream.AvailableTracks Property

**Applies to:** Windows Store apps only

Gets the available tracks in the current stream.

## Syntax

``` csharp
public IVectorView<IManifestTrack> AvailableTracks { get; }
```

``` c++
public:
virtual property IVectorView<IManifestTrack^>^ AvailableTracks {
IVectorView<IManifestTrack^>^ get () sealed;
}
```

``` jscript
final function get AvailableTracks () : IVectorView<IManifestTrack>
```

## Property Value

The available tracks in the current stream.

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

