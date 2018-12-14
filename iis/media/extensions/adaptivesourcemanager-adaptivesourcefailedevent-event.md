---
title: AdaptiveSourceManager.AdaptiveSourceFailedEvent Event
TOCTitle: AdaptiveSourceFailedEvent Event
ms:assetid: ff921d34-f2d5-4688-977c-252f294ce636
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822880(v=VS.90)
ms:contentKeyID: 50079634
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# AdaptiveSourceManager.AdaptiveSourceFailedEvent Event

**Applies to:** Windows Store apps only

Adds or removes a subscription to AdaptiveSourceFailedEvent events. Those events fire when the adaptive source has failed.

## Syntax

``` csharp
public event AdaptiveSourceFailedEventHandler AdaptiveSourceFailedEvent
```

``` c++
public:
virtual  event AdaptiveSourceFailedEventHandler^ AdaptiveSourceFailedEvent {
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


## Remarks

Subscribing to events at the AdaptiveSourceManager level means that all AdaptiveSourceFailedEvent events from all AdaptiveSource objects will be handled by this event handler. If you want to differentiate the AdaptiveSources, you need to get the AdaptiveSource.Uri or listen to individual events under each AdaptiveSources object.

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

