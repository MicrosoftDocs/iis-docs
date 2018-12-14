---
title: IAdaptiveSourceManager.AdaptiveSourceStatusUpdatedEvent Event
TOCTitle: AdaptiveSourceStatusUpdatedEvent Event
ms:assetid: 9368d96a-29ec-48e1-9eaa-4fb7b0fd0b67
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822785(v=VS.90)
ms:contentKeyID: 50079539
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# IAdaptiveSourceManager.AdaptiveSourceStatusUpdatedEvent Event

**Applies to:** Windows Store apps only

Adds the status updated event handler.

## Syntax

``` csharp
event AdaptiveSourceStatusUpdatedEventHandler AdaptiveSourceStatusUpdatedEvent
```

``` c++
event AdaptiveSourceStatusUpdatedEventHandler^ AdaptiveSourceStatusUpdatedEvent {
void add (AdaptiveSourceStatusUpdatedEventHandler^ value);
void remove (AdaptiveSourceStatusUpdatedEventHandler^ value);
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
<td><p><a href="adaptivesourcestatusupdatedeventhandler-delegate.md">AdaptiveSourceStatusUpdatedEventHandler Delegate</a></p></td>
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

