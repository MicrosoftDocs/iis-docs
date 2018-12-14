---
title: IAdaptiveSourceManager.AdaptiveSourceOpenedEvent Event
TOCTitle: AdaptiveSourceOpenedEvent Event
ms:assetid: 0a53331b-023c-4c9e-b8f8-d491f2d49d77
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822674(v=VS.90)
ms:contentKeyID: 50079429
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# IAdaptiveSourceManager.AdaptiveSourceOpenedEvent Event

**Applies to:** Windows Store apps only

Specifies the adaptive source opened event handler.

## Syntax

``` csharp
event AdaptiveSourceOpenedEventHandler AdaptiveSourceOpenedEvent
```

``` c++
event AdaptiveSourceOpenedEventHandler^ AdaptiveSourceOpenedEvent {
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

