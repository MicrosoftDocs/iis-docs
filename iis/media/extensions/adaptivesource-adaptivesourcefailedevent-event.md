---
title: AdaptiveSource.AdaptiveSourceFailedEvent Event
TOCTitle: AdaptiveSourceFailedEvent Event
ms:assetid: b14983dd-5395-416a-b154-fbbdca77e81b
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822810(v=VS.90)
ms:contentKeyID: 50079564
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# AdaptiveSource.AdaptiveSourceFailedEvent Event

**Applies to:** Windows Store apps only

Occurs when the AdaptiveSource event failed.

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
<td><p>AdaptiveSourceFailedEventHandler</p></td>
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

