---
title: AdaptiveSource Class
TOCTitle: AdaptiveSource Class
ms:assetid: a9628170-8425-4e70-98f9-26f255731f5c
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822807(v=VS.90)
ms:contentKeyID: 50079561
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# AdaptiveSource Class

**Applies to:** Windows Store apps only

Represents the list of opened adaptive sources.

## Syntax

``` csharp
[VersionAttribute()]
[ActivatableAttribute()]
public sealed class AdaptiveSource : IAdaptiveSource
```

``` c++
[VersionAttribute()]
[ActivatableAttribute()]
public ref class AdaptiveSource sealed : IAdaptiveSource
```

``` jscript
public final class AdaptiveSource implements IAdaptiveSource
```

## Members

This class exposes the following members.

### Properties

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Property</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><a href="adaptivesource-manifest-property.md">Manifest Property</a></p></td>
<td><p>Gets the manifest.</p></td>
</tr>
<tr class="even">
<td><p><a href="adaptivesource-uri-property.md">Uri Property</a></p></td>
<td><p>Gets the URI.</p></td>
</tr>
</tbody>
</table>


### Events

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Event</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><a href="adaptivesource-adaptivesourcefailedevent-event.md">AdaptiveSourceFailedEvent Event</a></p></td>
<td><p>Occurs when the AdaptiveSource event failed.</p></td>
</tr>
<tr class="even">
<td><p><a href="adaptivesource-adaptivesourcestatusupdatedevent-event.md">AdaptiveSourceStatusUpdatedEvent Event</a></p></td>
<td><p>Occurs when the status of the adaptive source is updated.</p></td>
</tr>
<tr class="odd">
<td><p><a href="adaptivesource-manifestreadyevent-event.md">ManifestReadyEvent Event</a></p></td>
<td><p>Occurs when the manifest is ready.</p></td>
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

