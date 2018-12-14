---
title: IAdaptiveSourceManager.AdaptiveSourceClosedEvent Event
TOCTitle: AdaptiveSourceClosedEvent Event
ms:assetid: 4e8e44d1-f06a-4317-afe0-774fdb3458fc
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822731(v=VS.90)
ms:contentKeyID: 50079486
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# IAdaptiveSourceManager.AdaptiveSourceClosedEvent Event

**Applies to:** Windows Store apps only

Occurs when the Adaptive Source is closed.

## Syntax

``` csharp
event AdaptiveSourceClosedEventHandler AdaptiveSourceClosedEvent
```

``` c++
event AdaptiveSourceClosedEventHandler^ AdaptiveSourceClosedEvent {
void add (AdaptiveSourceClosedEventHandler^ value);
void remove (AdaptiveSourceClosedEventHandler^ value);
}
```

## Event information

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p>Delegate</p></td>
<td><p><a href="adaptivesourceclosedeventhandler-delegate.md">AdaptiveSourceClosedEventHandler Delegate</a></p></td>
</tr>
</tbody>
</table>


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
<td><p><strong>IDL</strong></p></td>
<td><p>Microsoft.Media.AdaptiveStreaming.winmd</p></td>
</tr>
</tbody>
</table>

