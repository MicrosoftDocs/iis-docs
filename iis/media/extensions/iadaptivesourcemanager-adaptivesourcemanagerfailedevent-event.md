---
title: IAdaptiveSourceManager.AdaptiveSourceManagerFailedEvent Event
TOCTitle: AdaptiveSourceManagerFailedEvent Event
ms:assetid: 5f97ba70-027c-412c-84be-98bb841d25ed
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822747(v=VS.90)
ms:contentKeyID: 50079502
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# IAdaptiveSourceManager.AdaptiveSourceManagerFailedEvent Event

**Applies to:** Windows Store apps only

Adds the adaptive source manager failed event handler.

## Syntax

``` csharp
event AdaptiveSourceManagerFailedEventHandler AdaptiveSourceManagerFailedEvent
```

``` c++
event AdaptiveSourceManagerFailedEventHandler^ AdaptiveSourceManagerFailedEvent {
void add (AdaptiveSourceManagerFailedEventHandler^ value);
void remove (AdaptiveSourceManagerFailedEventHandler^ value);
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
<td><p><a href="adaptivesourcemanagerfailedeventhandler-delegate.md">AdaptiveSourceManagerFailedEventHandler Delegate</a></p></td>
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

