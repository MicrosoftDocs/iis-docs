---
title: AdaptiveSourceManager Class
TOCTitle: AdaptiveSourceManager Class
ms:assetid: e8073a26-452b-461a-9a0f-32085dc000ae
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822860(v=VS.90)
ms:contentKeyID: 50079614
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# AdaptiveSourceManager Class

**Applies to:** Windows Store apps only

Represents the adaptive source single playback session.

## Syntax

``` csharp
[VersionAttribute()]
[StaticAttribute(typeof(IAdaptiveSourceManagerStatics), )]
public sealed class AdaptiveSourceManager : IAdaptiveSourceManager
```

``` c++
[VersionAttribute()]
[StaticAttribute(typeof(IAdaptiveSourceManagerStatics), )]
public ref class AdaptiveSourceManager sealed : IAdaptiveSourceManager
```

``` jscript
public final class AdaptiveSourceManager implements IAdaptiveSourceManager
```

## Members

This class exposes the following members.

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
<td><p><a href="adaptivesourcemanager-getdefault-method.md">GetDefault</a></p></td>
<td><p>Gets the source manager singleton.</p></td>
</tr>
<tr class="even">
<td><p><a href="adaptivesourcemanager-sendextendedcommand-method.md">SendExtendedCommand</a></p></td>
<td><p>Reserved for future use.</p></td>
</tr>
<tr class="odd">
<td><p><a href="adaptivesourcemanager-setbufferdelaysec-method.md">SetBufferDelaySec</a></p></td>
<td><p>Sets the buffer delay in seconds before playback starts.</p></td>
</tr>
<tr class="even">
<td><p><a href="adaptivesourcemanager-setdownloadbuffersec-method.md">SetDownloadBufferSec</a></p></td>
<td><p>Sets the downloader buffer in seconds.</p></td>
</tr>
<tr class="odd">
<td><p><a href="adaptivesourcemanager-setdownloaderplugin-method.md">SetDownloaderPlugin</a></p></td>
<td><p>Sets the downloader plugin.</p></td>
</tr>
<tr class="even">
<td><p><a href="adaptivesourcemanager-setlivebackoffsec-method.md">SetLiveBackoffSec</a></p></td>
<td><p>Sets the seconds backed off from current live server time.</p></td>
</tr>
<tr class="odd">
<td><p><a href="adaptivesourcemanager-setlivebeginoffsetsec-method.md">SetLiveBeginOffsetSec</a></p></td>
<td><p>Sets the seconds after first chunk to start playing at when tuning to left edge, when tuning to live.</p></td>
</tr>
<tr class="even">
<td><p><a href="adaptivesourcemanager-setplaybackoffsetsec-method.md">SetPlaybackOffsetSec</a></p></td>
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
<td><p><a href="adaptivesourcemanager-adaptivesources-property.md">AdaptiveSources</a></p></td>
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
<td><p><a href="adaptivesourcemanager-adaptivesourceclosedevent-event.md">AdaptiveSourceClosedEvent</a></p></td>
<td><p>Occurs when the adaptive source is closed.</p></td>
</tr>
<tr class="even">
<td><p><a href="adaptivesourcemanager-adaptivesourcefailedevent-event.md">AdaptiveSourceFailedEvent</a></p></td>
<td><p>Occurs when the adaptive source event failed.</p></td>
</tr>
<tr class="odd">
<td><p><a href="adaptivesourcemanager-adaptivesourcemanagerfailedevent-event.md">AdaptiveSourceManagerFailedEvent</a></p></td>
<td><p>Occurs when the AdaptiveSourceManager event failed.</p></td>
</tr>
<tr class="even">
<td><p><a href="adaptivesourcemanager-adaptivesourceopenedevent-event.md">AdaptiveSourceOpenedEvent</a></p></td>
<td><p>Occurs when the adaptive source is opened.</p></td>
</tr>
<tr class="odd">
<td><p><a href="adaptivesourcemanager-adaptivesourcestatusupdatedevent-event.md">AdaptiveSourceStatusUpdatedEvent</a></p></td>
<td><p>Occurs when the adaptive source status is updated.</p></td>
</tr>
<tr class="even">
<td><p><a href="adaptivesourcemanager-manifestreadyevent-event.md">ManifestReadyEvent</a></p></td>
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

