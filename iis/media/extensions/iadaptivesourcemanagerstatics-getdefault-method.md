﻿---
title: IAdaptiveSourceManagerStatics.GetDefault Method
TOCTitle: GetDefault Method
ms:assetid: 9c5cdd6b-72c1-490f-870f-db85a9d1bc9f
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822792(v=VS.90)
ms:contentKeyID: 50079546
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IAdaptiveSourceManagerStatics.GetDefault Method

**Applies to:** Windows Store apps only

Gets the source manager singleton.

## Syntax

``` csharp
IAdaptiveSourceManager GetDefault()
```

``` c++
IAdaptiveSourceManager^ GetDefault()
```

``` jscript
function GetDefault() : IAdaptiveSourceManager
```

## Parameters

  - ppAdaptiveSourceManager  
    The pointer to the source manager.

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
