---
title: IAdaptiveSourceManager.SetLiveBeginOffsetSec Method
TOCTitle: SetLiveBeginOffsetSec Method
ms:assetid: 6a33c1cc-8cf9-41b2-befa-bb80b3b80949
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822755(v=VS.90)
ms:contentKeyID: 50079510
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IAdaptiveSourceManager.SetLiveBeginOffsetSec Method

**Applies to:** Windows Store apps only

Sets the seconds after first chunk to start playing at when tuning to left edge, when tuning to live.

## Syntax

``` csharp
void SetLiveBeginOffsetSec(
uint liveBeginOffsetSec
)
```

``` c++
void SetLiveBeginOffsetSec(
[InAttribute] unsigned int liveBeginOffsetSec
)
```

``` jscript
function SetLiveBeginOffsetSec(
liveBeginOffsetSec : uint
)
```

## Parameters

  - liveBeginOffsetSec  
    Begin offset value.

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

