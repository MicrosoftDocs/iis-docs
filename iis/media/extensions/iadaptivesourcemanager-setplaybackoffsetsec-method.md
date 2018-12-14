---
title: IAdaptiveSourceManager.SetPlaybackOffsetSec Method
TOCTitle: SetPlaybackOffsetSec Method
ms:assetid: 6327a661-71f0-460d-87a1-da3f36189df4
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822749(v=VS.90)
ms:contentKeyID: 50079504
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IAdaptiveSourceManager.SetPlaybackOffsetSec Method

**Applies to:** Windows Store apps only

Sets the seconds playback is backed off from when tuning to live.

## Syntax

``` csharp
void SetPlaybackOffsetSec(
uint playbackOffsetSec
)
```

``` c++
void SetPlaybackOffsetSec(
[InAttribute] unsigned int playbackOffsetSec
)
```

``` jscript
function SetPlaybackOffsetSec(
playbackOffsetSec : uint
)
```

## Parameters

  - playbackOffsetSec  
    Back off value.

  -  

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

