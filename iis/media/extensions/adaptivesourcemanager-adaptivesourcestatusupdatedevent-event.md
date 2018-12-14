---
title: AdaptiveSourceManager.AdaptiveSourceStatusUpdatedEvent Event
TOCTitle: AdaptiveSourceStatusUpdatedEvent Event
ms:assetid: fa8b8e57-c632-45b5-b9da-c65e5bc271de
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822875(v=VS.90)
ms:contentKeyID: 50079629
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# AdaptiveSourceManager.AdaptiveSourceStatusUpdatedEvent Event

**Applies to:** Windows Store apps only

Adds or removes a subscription to AdaptiveSourceStatusUpdatedEvent events. Those events fire when the adaptive source status is updated.

## Syntax

``` csharp
public event AdaptiveSourceStatusUpdatedEventHandler AdaptiveSourceStatusUpdatedEvent
```

``` c++
public:
virtual  event AdaptiveSourceStatusUpdatedEventHandler^ AdaptiveSourceStatusUpdatedEvent {
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


## Remarks

Subscribing to events at the AdaptiveSourceManager level means that all AdaptiveSourceStatusUpdatedEvent events from all AdaptiveSource objects will be handled by this event handler. If you want to differentiate the AdaptiveSources, you need to get the AdaptiveSource.Uri or listen to individual events under each AdaptiveSources object.

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

