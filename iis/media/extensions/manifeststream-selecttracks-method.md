---
title: ManifestStream.SelectTracks Method
TOCTitle: SelectTracks Method
ms:assetid: bcaaf5c4-3f40-4dfa-926c-01508efab3df
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822819(v=VS.90)
ms:contentKeyID: 50079573
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestStream.SelectTracks Method

**Applies to:** Windows Store apps only

Selects the tracks in a subset of all the available tracks.

## Syntax

``` csharp
public void SelectTracks(
IVectorView<IManifestTrack> pTracks
)
```

``` c++
public:
virtual void SelectTracks(
[InAttribute] IVectorView<IManifestTrack^>^ pTracks
) sealed
```

``` jscript
public final function SelectTracks(
pTracks : IVectorView<IManifestTrack>
)
```

## Parameters

  - pTracks  
    Type: IVectorView(IManifestTrack)

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

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

