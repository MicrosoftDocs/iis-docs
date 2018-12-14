---
title: IManifestStream.RestrictTracks Method
TOCTitle: RestrictTracks Method
ms:assetid: 65974158-70aa-4ab0-bacc-4431d059bbef
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822751(v=VS.90)
ms:contentKeyID: 50079506
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IManifestStream.RestrictTracks Method

**Applies to:** Windows Store apps only

Restricts the tracks to a subset of all the available tracks.

## Syntax

``` csharp
void RestrictTracks(
IVectorView<IManifestTrack> pTracks
)
```

``` c++
void RestrictTracks(
[InAttribute] IVectorView<IManifestTrack^>^ pTracks
)
```

``` jscript
function RestrictTracks(
pTracks : IVectorView<IManifestTrack>
)
```

## Parameters

  - pTracks  
    \[in\] The list of tracks to keep available in the stream. Tracks not in the list will be removed.

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

