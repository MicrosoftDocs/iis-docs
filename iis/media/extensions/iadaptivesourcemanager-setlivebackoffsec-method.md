---
title: IAdaptiveSourceManager.SetLiveBackoffSec Method
TOCTitle: SetLiveBackoffSec Method
ms:assetid: e2019ff5-6f08-4779-aab9-432076042660
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822853(v=VS.90)
ms:contentKeyID: 50079607
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IAdaptiveSourceManager.SetLiveBackoffSec Method

**Applies to:** Windows Store apps only

Sets the seconds backed off from current live server time.

## Syntax

``` csharp
void SetLiveBackoffSec(
uint liveBackOffSec
)
```

``` c++
void SetLiveBackoffSec(
[InAttribute] unsigned int liveBackOffSec
)
```

``` jscript
function SetLiveBackoffSec(
liveBackOffSec : uint
)
```

## Parameters

  - liveBackOffSec  
    Back off time value.

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

