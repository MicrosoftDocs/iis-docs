---
title: AdaptiveSourceClosedEventHandler Delegate
TOCTitle: AdaptiveSourceClosedEventHandler Delegate
ms:assetid: fbe5303f-95bc-4f42-8287-3052bb457f93
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822876(v=VS.90)
ms:contentKeyID: 50079630
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# AdaptiveSourceClosedEventHandler Delegate

**Applies to:** Windows Store apps only

The actual handler for the adaptive source closed event.

## Syntax

``` csharp
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public delegate void AdaptiveSourceClosedEventHandler(
AdaptiveSource sender,
AdaptiveSourceClosedEventArgs args
)
```

``` c++
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public delegate void AdaptiveSourceClosedEventHandler(
[InAttribute] AdaptiveSource^ sender,
[InAttribute] AdaptiveSourceClosedEventArgs^ args
)
```

## Parameters

  - sender  
    Adaptive source this event belongs to.

  - AdaptiveSourceClosedEventArgs  
    Event arguments.

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

