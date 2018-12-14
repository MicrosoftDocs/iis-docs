---
title: ManifestStream.DownloadFragmentAsync Method
TOCTitle: DownloadFragmentAsync Method
ms:assetid: 91f7430b-8fd6-40b4-98ef-8d6caabe5b10
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822783(v=VS.90)
ms:contentKeyID: 50079537
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestStream.DownloadFragmentAsync Method

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
    Type: Microsoft.Media.AdaptiveStreaming.IChunkIter

  - pTrack  
    Type: Microsoft.Media.AdaptiveStreaming.IManifestTrack

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

