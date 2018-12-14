---
title: AdaptiveSourceManager.AdaptiveSourceClosedEvent Event
TOCTitle: AdaptiveSourceClosedEvent Event
ms:assetid: 5b610241-bcdf-45ae-8506-5bd604fe425a
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822740(v=VS.90)
ms:contentKeyID: 50079495
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# AdaptiveSourceManager.AdaptiveSourceClosedEvent Event

**Applies to:** Windows Store apps only

Adds or removes a subscription to AdaptiveSourceClosedEvent events. Those events fire when the adaptive source is closed.

## Syntax

``` csharp
public event AdaptiveSourceClosedEventHandler AdaptiveSourceClosedEvent
```

``` c++
public:
virtual  event AdaptiveSourceClosedEventHandler^ AdaptiveSourceClosedEvent {
void add (AdaptiveSourceClosedEventHandler^ value);
void remove (AdaptiveSourceClosedEventHandler^ value);
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


## Remarks

Subscribing to events at the AdaptiveSourceManager level means that all AdaptiveSourceClosedEvent events from all AdaptiveSource objects will be handled by this event handler. If you want to differentiate the AdaptiveSources, you need to get the AdaptiveSource.Uri or listen to individual events under each AdaptiveSources object.

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

