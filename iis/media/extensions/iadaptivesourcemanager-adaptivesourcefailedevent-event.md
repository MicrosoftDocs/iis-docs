---
title: IAdaptiveSourceManager.AdaptiveSourceFailedEvent Event
TOCTitle: AdaptiveSourceFailedEvent Event
ms:assetid: 6719debe-d6c9-4be3-84ca-1fe1b2837f82
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822753(v=VS.90)
ms:contentKeyID: 50079508
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# IAdaptiveSourceManager.AdaptiveSourceFailedEvent Event

**Applies to:** Windows Store apps only

Adds the failed event handler.

## Syntax

``` csharp
event AdaptiveSourceFailedEventHandler AdaptiveSourceFailedEvent
```

``` c++
event AdaptiveSourceFailedEventHandler^ AdaptiveSourceFailedEvent {
void add (AdaptiveSourceFailedEventHandler^ value);
void remove (AdaptiveSourceFailedEventHandler^ value);
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
<td><p><a href="adaptivesourcefailedeventhandler-delegate.md">AdaptiveSourceFailedEventHandler Delegate</a></p></td>
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
<td><p><strong>Metadata</strong></p></td>
<td><p>Microsoft.Media.AdaptiveStreaming.winmd</p></td>
</tr>
</tbody>
</table>

