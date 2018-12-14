---
title: IAdaptiveSource Interface
TOCTitle: IAdaptiveSource Interface
ms:assetid: d0656cbb-c4f9-407d-9566-cf840783d895
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822837(v=VS.90)
ms:contentKeyID: 50079591
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IAdaptiveSource Interface

**Applies to:** Windows Store apps only

Adaptive source, single playback session.

## Syntax

``` csharp
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public interface IAdaptiveSource
```

``` c++
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public interface class IAdaptiveSource
```

``` jscript
public interface IAdaptiveSource
```

## Members

This interface exposes the following members.

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
<td><p><a href="iadaptivesource-manifest-property.md">Manifest</a></p></td>
<td><p>Gets the manifest.</p></td>
</tr>
<tr class="even">
<td><p><a href="iadaptivesource-uri-property.md">Uri</a></p></td>
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
<th><p>Method</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>AdaptiveSourceFailedEvent</p></td>
<td><p>Adds the failed event handler.</p></td>
</tr>
<tr class="even">
<td><p><a href="iadaptivesource-adaptivesourcestatusupdatedevent-event.md">AdaptiveSourceStatusUpdatedEvent</a></p></td>
<td><p>Adds the status updated event handler.</p></td>
</tr>
<tr class="odd">
<td><p><a href="iadaptivesource-manifestreadyevent-event.md">ManifestReadyEvent</a></p></td>
<td><p>Adds the manifest ready event handler.</p></td>
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

