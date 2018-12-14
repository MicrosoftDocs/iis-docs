---
title: IAdaptiveSourceManager Interface
TOCTitle: IAdaptiveSourceManager Interface
ms:assetid: 1eb62758-d31e-4b24-9251-db31f5ad9015
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822695(v=VS.90)
ms:contentKeyID: 50079450
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IAdaptiveSourceManager Interface

**Applies to:** Windows Store apps only

Gets the list of opened adaptive sources.

## Syntax

``` csharp
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public interface IAdaptiveSourceManager
```

``` c++
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public interface class IAdaptiveSourceManager
```

``` jscript
public interface IAdaptiveSourceManager
```

## Members

This interface exposes the following members.

### Methods

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
<td><p><a href="iadaptivesourcemanager-sendextendedcommand-method.md">SendExtendedCommand</a></p></td>
<td><p>Reserved for future use.</p></td>
</tr>
<tr class="even">
<td><p><a href="iadaptivesourcemanager-setbufferdelay-method.md">SetBufferDelay</a></p></td>
<td><p>Sets the buffer delay in seconds before we start.</p></td>
</tr>
<tr class="odd">
<td><p><a href="iadaptivesourcemanager-setdownloadbuffersec-method.md">SetDownloadBufferSec</a></p></td>
<td><p>Sets the downloader buffer in seconds.</p></td>
</tr>
<tr class="even">
<td><p><a href="iadaptivesourcemanager-setdownloaderplugin-method.md">SetDownloaderPlugin</a></p></td>
<td><p>Sets the downloader plugin.</p></td>
</tr>
<tr class="odd">
<td><p><a href="iadaptivesourcemanager-setlivebackoffsec-method.md">SetLiveBackoffSec</a></p></td>
<td><p>Sets the seconds backed off from current live server time.</p></td>
</tr>
<tr class="even">
<td><p><a href="iadaptivesourcemanager-setlivebeginoffsetsec-method.md">SetLiveBeginOffsetSec</a></p></td>
<td><p>Sets the seconds after first chunk to start playing at when tuning to left edge, when tuning to live.</p></td>
</tr>
<tr class="odd">
<td><p><a href="iadaptivesourcemanager-setplaybackoffsetsec-method.md">SetPlaybackOffsetSec</a></p></td>
<td><p>Sets the seconds playback is backed off from when tuning to live.</p></td>
</tr>
</tbody>
</table>


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
<td><p><a href="iadaptivesourcemanager-adaptivesources-property.md">AdaptiveSources</a></p></td>
<td><p>Gets the list of opened adaptive sources.</p></td>
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
<td><p><a href="iadaptivesourcemanager-adaptivesourceclosedevent-event.md">AdaptiveSourceClosedEvent</a></p></td>
<td><p>Occurs when the AdaptiveSource is closed.</p></td>
</tr>
<tr class="even">
<td><p><a href="iadaptivesourcemanager-adaptivesourcefailedevent-event.md">AdaptiveSourceFailedEvent</a></p></td>
<td><p>Adds the failed event handler.</p></td>
</tr>
<tr class="odd">
<td><p><a href="iadaptivesourcemanager-adaptivesourcemanagerfailedevent-event.md">AdaptiveSourceManagerFailedEvent</a></p></td>
<td><p>Adds the adaptive source manager failed event handler.</p></td>
</tr>
<tr class="even">
<td><p><a href="iadaptivesourcemanager-adaptivesourcemanagerfailedevent-event.md">AdaptiveSourceOpenedEvent</a></p></td>
<td><p>Specifies the adaptive source opened event handler.</p></td>
</tr>
<tr class="odd">
<td><p><a href="iadaptivesourcemanager-adaptivesourcestatusupdatedevent-event.md">AdaptiveSourceStatusUpdatedEvent</a></p></td>
<td><p>Adds the status updated event handler.</p></td>
</tr>
<tr class="even">
<td><p><a href="iadaptivesourcemanager-manifestreadyevent-event.md">ManifestReadyEvent</a></p></td>
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

