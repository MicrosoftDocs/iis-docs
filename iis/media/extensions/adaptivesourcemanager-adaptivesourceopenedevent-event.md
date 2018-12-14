---
title: AdaptiveSourceManager.AdaptiveSourceOpenedEvent Event
TOCTitle: AdaptiveSourceOpenedEvent Event
ms:assetid: b77b4f93-3775-46ae-b986-ddc53e532400
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822816(v=VS.90)
ms:contentKeyID: 50079570
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# AdaptiveSourceManager.AdaptiveSourceOpenedEvent Event

**Applies to:** Windows Store apps only

Adds or removes a subscription to AdaptiveSourceOpenedEvent events. Those events fire when the Adaptive Source is opened.

## Syntax

``` csharp
public event AdaptiveSourceOpenedEventHandler AdaptiveSourceOpenedEvent
```

``` c++
public:
virtual  event AdaptiveSourceOpenedEventHandler^ AdaptiveSourceOpenedEvent {
void add (AdaptiveSourceOpenedEventHandler^ value);
void remove (AdaptiveSourceOpenedEventHandler^ value);
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
<td><p><a href="adaptivesourceopenedeventhandler-delegate.md">AdaptiveSourceOpenedEventHandler Delegate</a></p></td>
</tr>
</tbody>
</table>


## Remarks

Subscribing to events at the AdaptiveSourceManager level means that all AdaptiveSourceOpenedEvent events from all AdaptiveSource objects will be handled by this event handler. If you want to differentiate the AdaptiveSources, you need to get the AdaptiveSource.Uri or listen to individual events under each AdaptiveSources object.

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

