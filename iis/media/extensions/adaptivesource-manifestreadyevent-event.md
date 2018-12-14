---
title: AdaptiveSource.ManifestReadyEvent Event
TOCTitle: ManifestReadyEvent Event
ms:assetid: 0de1bf24-1507-4a3d-a275-e8b715fd7026
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822678(v=VS.90)
ms:contentKeyID: 50079433
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# AdaptiveSource.ManifestReadyEvent Event

**Applies to:** Windows Store apps only

Occurs when the manifest is ready.

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
<td><p>ManifestReadyEventHandler</p></td>
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

