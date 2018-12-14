---
title: AdaptiveSourceManager.SetPlaybackOffsetSec Method
TOCTitle: SetPlaybackOffsetSec Method
ms:assetid: 2eccc183-b379-48ef-a332-f8858d9a2084
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822710(v=VS.90)
ms:contentKeyID: 50079465
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# AdaptiveSourceManager.SetPlaybackOffsetSec Method

**Applies to:** Windows Store apps only

Sets the seconds playback is backed off from when tuning to live.

## Syntax

``` csharp
public void SetPlaybackOffsetSec(
uint playbackOffsetSec
)
```

``` c++
public:
virtual void SetPlaybackOffsetSec(
[InAttribute] unsigned int playbackOffsetSec
) sealed
```

``` jscript
public final function SetPlaybackOffsetSec(
playbackOffsetSec : uint
)
```

## Parameters

  - playbackOffsetSec  
    The back off value. The value should be between 5 and 50 and should be less than the value of downloadBufferSec. The default value for playbackOffsetSec is 8 seconds.

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

