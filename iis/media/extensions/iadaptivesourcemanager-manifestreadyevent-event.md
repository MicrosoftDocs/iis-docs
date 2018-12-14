---
title: IAdaptiveSourceManager.ManifestReadyEvent Event
TOCTitle: ManifestReadyEvent Event
ms:assetid: 8b74b85d-6a03-4c6d-bd43-7287487ddb35
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822774(v=VS.90)
ms:contentKeyID: 50079529
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# IAdaptiveSourceManager.ManifestReadyEvent Event

**Applies to:** Windows Store apps only

Adds the manifest ready event handler.

## Syntax

``` csharp
event ManifestReadyEventHandler ManifestReadyEvent
```

``` c++
event ManifestReadyEventHandler^ ManifestReadyEvent {
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
<td><p>SSMFSourceplugin.idl</p></td>
</tr>
</tbody>
</table>

