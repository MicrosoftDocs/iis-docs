---
title: ManifestStream.GetIterator Method
TOCTitle: GetIterator Method
ms:assetid: 73aa4861-e973-48bb-a4d4-67b233875c42
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822758(v=VS.90)
ms:contentKeyID: 50079513
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestStream.GetIterator Method

**Applies to:** Windows Store apps only

Gets the last chunk iterator within the specified time range.

## Syntax

``` csharp
public IChunkIter GetIterator(
long minTime,
long time
)
```

``` c++
public:
virtual IChunkIter^ GetIterator(
[InAttribute] long long minTime, 
[InAttribute] long long time
) sealed
```

``` jscript
public final function GetIterator(
minTime : long, 
time : long
) : IChunkIter
```

## Parameters

  - minTime  
    Type: System.Int64

  - time  
    Type: System.Int64

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

