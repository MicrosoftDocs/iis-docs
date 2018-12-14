﻿---
title: AdaptiveSourceManager.SetDownloadBufferSec Method
TOCTitle: SetDownloadBufferSec Method
ms:assetid: dfd4f31a-248b-4db9-b556-441f33865582
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822850(v=VS.90)
ms:contentKeyID: 50079604
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# AdaptiveSourceManager.SetDownloadBufferSec Method

**Applies to:** Windows Store apps only

Sets the downloader buffer in seconds.

## Syntax

``` csharp
public void SetDownloadBufferSec(
float bufferSec
)
```

``` c++
public:
virtual void SetDownloadBufferSec(
[InAttribute] float bufferSec
) sealed
```

``` jscript
public final function SetDownloadBufferSec(
bufferSec : float
)
```

## Parameters

  - bufferSec  
    The download buffer size value in seconds. The value should be between 6 and 60. The default is 30 seconds.

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
