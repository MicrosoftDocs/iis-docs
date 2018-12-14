---
title: IAdaptiveSourceManager.SetDownloadBufferSec Method
TOCTitle: SetDownloadBufferSec Method
ms:assetid: 9cfd3bfa-0d75-467f-b4b2-d0920eccb3de
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822794(v=VS.90)
ms:contentKeyID: 50079548
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IAdaptiveSourceManager.SetDownloadBufferSec Method

**Applies to:** Windows Store apps only

Sets the downloader buffer in seconds.

## Syntax

``` csharp
void SetDownloadBufferSec(
float bufferSec
)
```

``` c++
void SetDownloadBufferSec(
[InAttribute] float bufferSec
)
```

``` jscript
function SetDownloadBufferSec(
bufferSec : float
)
```

## Parameters

  - bufferSec  
    Download buffer size value.

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

