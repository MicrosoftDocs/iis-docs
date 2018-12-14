---
title: AdaptiveSourceManager.AdaptiveSourceManagerFailedEvent Event
TOCTitle: AdaptiveSourceManagerFailedEvent Event
ms:assetid: 1c56fae3-c783-4385-bafb-833ccfb11455
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822692(v=VS.90)
ms:contentKeyID: 50079447
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# AdaptiveSourceManager.AdaptiveSourceManagerFailedEvent Event

**Applies to:** Windows Store apps only

Adds or removes a subscription to AdaptiveSourceManagerFailedEvent events. Those events fire when the AdaptiveSourceManager event failed.

## Syntax

``` csharp
public event AdaptiveSourceManagerFailedEventHandler AdaptiveSourceManagerFailedEvent
```

``` c++
public:
virtual  event AdaptiveSourceManagerFailedEventHandler ^ AdaptiveSourceManagerFailedEvent {
void add (AdaptiveSourceManagerFailedEventHandler ^ value);
void remove (AdaptiveSourceManagerFailedEventHandler ^ value);
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


## Remarks

Subscribing to events at the AdaptiveSourceManager level means that all AdaptiveSourceManagerFailedEvent events from all AdaptiveSource objects will be handled by this event handler. If you want to differentiate the AdaptiveSources, you need to get the AdaptiveSource.Uri or listen to individual events under each AdaptiveSources object.

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

