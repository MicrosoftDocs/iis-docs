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

|Method|Description|
|--- |--- |
|[SendExtendedCommand](iadaptivesourcemanager-sendextendedcommand-method.md)|Reserved for future use.|
|[SetBufferDelay](iadaptivesourcemanager-setbufferdelay-method.md)|Sets the buffer delay in seconds before we start.|
|[SetDownloadBufferSec](iadaptivesourcemanager-setdownloadbuffersec-method.md)|Sets the downloader buffer in seconds.|
|[SetDownloaderPlugin](iadaptivesourcemanager-setdownloaderplugin-method.md)|Sets the downloader plugin.|
|[SetLiveBackoffSec](iadaptivesourcemanager-setlivebackoffsec-method.md)|Sets the seconds backed off from current live server time.|
|[SetLiveBeginOffsetSec](iadaptivesourcemanager-setlivebeginoffsetsec-method.md)|Sets the seconds after first chunk to start playing at when tuning to left edge, when tuning to live.|
|[SetPlaybackOffsetSec](iadaptivesourcemanager-setplaybackoffsetsec-method.md)|Sets the seconds playback is backed off from when tuning to live.|


### Properties

|Property|Description|
|--- |--- |
|[AdaptiveSources](iadaptivesourcemanager-adaptivesources-property.md)|Gets the list of opened adaptive sources.|


### Events

|Method|Description|
|--- |--- |
|[AdaptiveSourceClosedEvent](iadaptivesourcemanager-adaptivesourceclosedevent-event.md)|Occurs when the AdaptiveSource is closed.|
|[AdaptiveSourceFailedEvent](iadaptivesourcemanager-adaptivesourcefailedevent-event.md)|Adds the failed event handler.|
|[AdaptiveSourceManagerFailedEvent](iadaptivesourcemanager-adaptivesourcemanagerfailedevent-event.md)|Adds the adaptive source manager failed event handler.|
|[AdaptiveSourceOpenedEvent](iadaptivesourcemanager-adaptivesourcemanagerfailedevent-event.md)|Specifies the adaptive source opened event handler.|
|[AdaptiveSourceStatusUpdatedEvent](iadaptivesourcemanager-adaptivesourcestatusupdatedevent-event.md)|Adds the status updated event handler.|
|[ManifestReadyEvent](iadaptivesourcemanager-manifestreadyevent-event.md)|Adds the manifest ready event handler.|

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

