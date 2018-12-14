---
title: AdaptiveSourceManager.ManifestReadyEvent Event
TOCTitle: ManifestReadyEvent Event
ms:assetid: c86cae95-9b84-45bd-8512-68183ceb72ec
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822833(v=VS.90)
ms:contentKeyID: 50079587
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# AdaptiveSourceManager.ManifestReadyEvent Event

**Applies to:** Windows Store apps only

Adds or removes a subscription to ManifestReadyEvent events. Those events fire when the manifest is ready.

## Syntax

``` csharp
public event ManifestReadyEventHandler ManifestReadyEvent
```

``` c++
public:
virtual  event ManifestReadyEventHandler^ ManifestReadyEvent {
void add (ManifestReadyEventHandler^ value);
void remove (ManifestReadyEventHandler^ value);
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
<td><p><a href="manifestreadyeventhandler-delegate.md">ManifestReadyEventHandler Delegate</a></p></td>
</tr>
</tbody>
</table>


## Remarks

Subscribing to events at the AdaptiveSourceManager level means that all ManifestReadyEvent events from all AdaptiveSource objects will be handled by this event handler. If you want to differentiate the AdaptiveSources, you need to get the AdaptiveSource.Uri or listen to individual events under each AdaptiveSources object.

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

