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

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

