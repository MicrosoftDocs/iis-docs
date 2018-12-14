---
title: AdaptiveSourceManager.SetLiveBeginOffsetSec Method
TOCTitle: SetLiveBeginOffsetSec Method
ms:assetid: 5bf63905-3b78-4740-9df8-95cbb6b12661
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822742(v=VS.90)
ms:contentKeyID: 50079497
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# AdaptiveSourceManager.SetLiveBeginOffsetSec Method

**Applies to:** Windows Store apps only

Sets the seconds after first chunk to start playing at when tuning to left edge, when tuning to live.

## Syntax

``` csharp
public void SetLiveBeginOffsetSec(
uint liveBeginOffsetSec
)
```

``` c++
public:
virtual void SetLiveBeginOffsetSec(
[InAttribute] unsigned int liveBeginOffsetSec
) sealed
```

``` jscript
public final function SetLiveBeginOffsetSec(
liveBeginOffsetSec : uint
)
```

## Parameters

  - liveBeginOffsetSec  
    Type: System.UInt32

  - The begin offset value in seconds. The value should be between zero and the max value for a UInt32 data type; however, it should not exceed the DVR window length. The default value is 6 seconds.  

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

