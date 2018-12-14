---
title: IStreamChangedResult.Action Property
TOCTitle: Action Property
ms:assetid: baa176ea-018f-42b5-b1f4-9749eff35a34
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822817(v=VS.90)
ms:contentKeyID: 50079571
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IStreamChangedResult.Action Property

**Applies to:** Windows Store apps only

Gets the action of the stream.

## Syntax

``` csharp
 StreamChangedAction Action { get; }
```

``` c++
 property StreamChangedAction Action {
StreamChangedAction get ();
}
```

``` jscript
 function get Action () : StreamChangedAction
```

## Property Value

Indicates whether the stream is selected or de-selected.

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

