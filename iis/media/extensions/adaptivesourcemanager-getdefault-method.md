---
title: AdaptiveSourceManager.GetDefault Method
TOCTitle: GetDefault Method
ms:assetid: f71a679b-01e0-447b-b987-8d64acea64db
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822873(v=VS.90)
ms:contentKeyID: 50079627
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# AdaptiveSourceManager.GetDefault Method

**Applies to:** Windows Store apps only

Gets the source manager singleton.

## Syntax

``` csharp
public static IAdaptiveSourceManager GetDefault()
```

``` c++
public:
static IAdaptiveSourceManager^ GetDefault()
```

``` jscript
public static function GetDefault() : IAdaptiveSourceManager
```

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

