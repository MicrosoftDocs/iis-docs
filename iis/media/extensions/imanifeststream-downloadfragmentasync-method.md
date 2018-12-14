---
title: IManifestStream.DownloadFragmentAsync Method
TOCTitle: DownloadFragmentAsync Method
ms:assetid: 9613ba62-8b18-4eeb-aa33-2e40d5c543f4
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822787(v=VS.90)
ms:contentKeyID: 50079541
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IManifestStream.DownloadFragmentAsync Method

**Applies to:** Windows Store apps only

Downloads the fragment data for the given chunk iterator through async call.

## Syntax

``` csharp
public IAsyncOperation<IBuffer> DownloadFragmentAsync(
IChunkIter pChunkIter,
IManifestTrack pTrack
)
```

``` c++
public:
virtual IAsyncOperation<IBuffer^>^ DownloadFragmentAsync(
[InAttribute] IChunkIter^ pChunkIter,
[InAttribute] IManifestTrack^ pTrack
) sealed
```

``` jscript
public final function DownloadFragmentAsync(
pChunkIter : IChunkIter,
pTrack : IManifestTrack
) : IAsyncOperation<IBuffer>
```

## Parameters

  - pChunkIter  
    \[in\] The pointer to the chunk iterator.

  - pTrack  
    \[in\] The pointer to the track.

  - ppAsyncInfo  
    \[out\] The async operation result with fragment data in IBuffer.

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

