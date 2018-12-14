---
title: IAdaptiveSource.AdaptiveSourceFailedEvent Event
TOCTitle: AdaptiveSourceFailedEvent Event
ms:assetid: 3a38a94d-34a1-4f1b-927f-b0d9cc7c0105
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822719(v=VS.90)
ms:contentKeyID: 50079474
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# IAdaptiveSource.AdaptiveSourceFailedEvent Event

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

