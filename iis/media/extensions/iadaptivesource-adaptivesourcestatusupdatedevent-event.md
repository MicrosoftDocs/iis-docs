---
title: IAdaptiveSource.AdaptiveSourceStatusUpdatedEvent Event
TOCTitle: AdaptiveSourceStatusUpdatedEvent Event
ms:assetid: d35f9a59-663d-491b-b387-65a287d766f0
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822839(v=VS.90)
ms:contentKeyID: 50079593
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# IAdaptiveSource.AdaptiveSourceStatusUpdatedEvent Event

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

