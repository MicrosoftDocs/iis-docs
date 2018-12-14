---
title: IAdaptiveSourceManager.SetBufferDelay Method
TOCTitle: SetBufferDelay Method
ms:assetid: b2d1afc0-9653-4bbe-bf18-48700a9bec4c
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822812(v=VS.90)
ms:contentKeyID: 50079566
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IAdaptiveSourceManager.SetBufferDelay Method

**Applies to:** Windows Store apps only

Sets the buffer delay before starting, in seconds.

## Syntax

``` csharp
void SetBufferDelay(
float bufferDelaySec
)
```

``` c++
void SetBufferDelay(
[InAttribute] float bufferDelaySec
)
```

``` jscript
function SetBufferDelay(
bufferDelaySec : float
)
```

## Parameters

  - bufferDelaySec  
    The buffer delay size value.

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

